# LotHistoryMcp (C#)

자연어로 LOT 이력 조회 요청이 들어오면 `LOTHST` 테이블을 조회하는 **HTTP 기반 MCP 서버** 샘플입니다.

## 1) 실행

```powershell
cd LotHistoryMcp
$env:LOT_DB_CONNECTION="Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_ID;Password=YOUR_PW;TrustServerCertificate=True"
$env:MCP_SERVER_URLS="http://0.0.0.0:3001"
dotnet run
```

- MCP endpoint: `http://localhost:3001/mcp`
- Health check: `http://localhost:3001/`

## 2) 제공 툴

- `get_lot_history`
- 입력:
  - `lotNo` (string, 필수)
  - `limit` (int, 선택, 기본 20)

## 3) 조회 SQL

현재 샘플 SQL은 아래 컬럼 기준입니다. 실제 스키마에 맞게 컬럼명을 수정하세요.

- `LOT_NO`
- `PROCESS_CODE`
- `EVENT_TIME`
- `EVENT_USER`
- `REMARK`

## 4) MCP 클라이언트 연결
이 서버는 `stdio`가 아닌 `HTTP`로 동작하므로, MCP HTTP transport를 지원하는 클라이언트에서 URL을 `http://<host>:3001/mcp` 로 지정해 연결합니다.

외부 서비스에서 접근하려면 방화벽/리버스프록시(Nginx, APIM 등)에서 `3001` 또는 프록시 경로를 열어주세요.

## 5) AI가 툴을 호출하게 하는 프롬프트 예시

시스템 프롬프트 또는 워크스페이스 지침에 다음처럼 적습니다.

- "사용자가 LOT 이력/LOT history/lot trace를 요청하면 `get_lot_history` 툴을 우선 호출한다."
- "lot 번호가 없으면 먼저 lot 번호를 질문한다."
- "결과는 최신순으로 요약하고, 건수와 주요 공정 이력을 함께 설명한다."

