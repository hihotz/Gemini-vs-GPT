using System.ComponentModel;
using System.Data;
using System.Text.Json;
using Microsoft.Data.SqlClient;
using ModelContextProtocol.Server;

namespace LotHistoryMcp;

[McpServerToolType]
public static class LotHistoryTools
{
    [McpServerTool(
        Name = "get_lot_history",
        Title = "LOT History Lookup",
        ReadOnly = true,
        Destructive = false,
        Idempotent = true,
        OpenWorld = false)]
    [Description("LOTHST 테이블에서 특정 LOT의 이력을 조회합니다.")]
    public static async Task<string> GetLotHistory(
        [Description("조회할 LOT 번호")] string lotNo,
        [Description("최대 조회 건수 (기본 20)")] int limit = 20)
    {
        if (string.IsNullOrWhiteSpace(lotNo))
        {
            return "lotNo가 비어 있습니다.";
        }

        if (limit <= 0 || limit > 200)
        {
            limit = 20;
        }

        var connectionString = Environment.GetEnvironmentVariable("LOT_DB_CONNECTION");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            return "환경 변수 LOT_DB_CONNECTION 이 설정되지 않았습니다.";
        }

        var rows = new List<Dictionary<string, object?>>();

        await using var conn = new SqlConnection(connectionString);
        await conn.OpenAsync();

        const string sql = """
            SELECT TOP (@limit)
                   LOT_NO,
                   PROCESS_CODE,
                   EVENT_TIME,
                   EVENT_USER,
                   REMARK
            FROM LOTHST
            WHERE LOT_NO = @lotNo
            ORDER BY EVENT_TIME DESC
            """;

        await using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add(new SqlParameter("@limit", SqlDbType.Int) { Value = limit });
        cmd.Parameters.Add(new SqlParameter("@lotNo", SqlDbType.VarChar, 100) { Value = lotNo.Trim() });

        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            rows.Add(new Dictionary<string, object?>
            {
                ["LOT_NO"] = reader["LOT_NO"],
                ["PROCESS_CODE"] = reader["PROCESS_CODE"],
                ["EVENT_TIME"] = reader["EVENT_TIME"],
                ["EVENT_USER"] = reader["EVENT_USER"],
                ["REMARK"] = reader["REMARK"]
            });
        }

        var payload = new
        {
            lotNo = lotNo.Trim(),
            count = rows.Count,
            rows
        };

        return JsonSerializer.Serialize(payload, new JsonSerializerOptions
        {
            WriteIndented = true
        });
    }
}
