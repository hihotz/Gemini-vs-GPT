using BlazorDashboard.Models;

namespace BlazorDashboard.Services;

public sealed class SampleDashboardDataService
{
    public DashboardSnapshot GetSnapshot()
    {
        return new DashboardSnapshot(
            Metrics:
            [
                new("월 생산량", "31.2k", "+9.3%", true),
                new("라인 가동률", "94.8%", "+1.7%", true),
                new("불량률", "1.6%", "-0.4%", true),
                new("미해결 이슈", "37", "+4", false)
            ],
            RevenueByChannel:
            [
                new("웹", 46200, 50000),
                new("모바일", 39800, 43000),
                new("파트너", 25100, 28000),
                new("오프라인", 17400, 22000)
            ],
            TeamStatuses:
            [
                new("Growth", 82, 12, "Minji"),
                new("Product", 67, 19, "Jisoo"),
                new("Operations", 91, 6, "Hyun"),
                new("Customer Success", 74, 10, "Seojun")
            ],
            RecentActivities:
            [
                new("09:12", "신규 캠페인 예산 승인", "승인"),
                new("08:47", "모바일 결제 오류 핫픽스 배포", "배포"),
                new("08:20", "주간 리텐션 리포트 업로드", "리포트"),
                new("07:55", "파트너 정산 데이터 동기화 완료", "동기화")
            ],
            MonthlyProduction:
            [
                new("1월", 18),
                new("2월", 20),
                new("3월", 23),
                new("4월", 21),
                new("5월", 25),
                new("6월", 27),
                new("7월", 31),
                new("8월", 29),
                new("9월", 30),
                new("10월", 32),
                new("11월", 34),
                new("12월", 36)
            ],
            ConversionFunnel:
            [
                new("방문", 46, "#0ea5e9"),
                new("가입", 31, "#14b8a6"),
                new("결제", 23, "#22c55e")
            ],
            ErrorStatus: new ErrorSummary(
                ErrorRatePercent: 1.6,
                ErrorCountThisMonth: 128,
                OpenErrorCount: 37),
            AiInsight: new AiErrorInsight(
                Status: "샘플 분석",
                ConfidencePercent: 86,
                RootCause: "주말 배치 이후 캐시 만료 정책 충돌로 결제 승인 API 재시도 증가",
                Summary: "에러의 62%가 결제 승인 단계에서 집중되며, 모바일 앱 2.4.1 버전에서 비율이 높게 관찰됩니다.",
                Evidence:
                [
                    "08:30~10:00 구간 502/504 비율이 평시 대비 2.3배",
                    "모바일 경로 트래픽에서 동일 요청 중복 비율 18%",
                    "재시도 헤더 누락 요청의 실패율 41%"
                ],
                Actions:
                [
                    "결제 API 타임아웃 3.0s -> 4.5s 임시 상향",
                    "모바일 2.4.1 강제 업데이트 배너 노출",
                    "재시도 헤더 미포함 요청 차단 룰 추가"
                ]));
    }
}
