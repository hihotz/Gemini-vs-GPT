namespace BlazorDashboard.Models;

public sealed record DashboardSnapshot(
    IReadOnlyList<DashboardMetric> Metrics,
    IReadOnlyList<ChannelRevenue> RevenueByChannel,
    IReadOnlyList<TeamStatus> TeamStatuses,
    IReadOnlyList<ActivityItem> RecentActivities,
    IReadOnlyList<TrendPoint> MonthlyProduction,
    IReadOnlyList<ConversionSegment> ConversionFunnel,
    ErrorSummary ErrorStatus,
    AiErrorInsight AiInsight);

public sealed record DashboardMetric(string Label, string Value, string Delta, bool IsPositive);

public sealed record ChannelRevenue(string Channel, int RevenueKrwInThousands, int GoalKrwInThousands);

public sealed record TeamStatus(string Team, int ProgressPercent, int OpenTasks, string Owner);

public sealed record ActivityItem(string Time, string Description, string Tag);

public sealed record TrendPoint(string Label, int Value);

public sealed record ConversionSegment(string Label, int Percent, string ColorHex);

public sealed record ErrorSummary(double ErrorRatePercent, int ErrorCountThisMonth, int OpenErrorCount);

public sealed record AiErrorInsight(
    string Status,
    int ConfidencePercent,
    string RootCause,
    string Summary,
    IReadOnlyList<string> Evidence,
    IReadOnlyList<string> Actions);
