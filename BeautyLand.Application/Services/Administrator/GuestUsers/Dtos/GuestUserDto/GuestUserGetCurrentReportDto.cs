﻿namespace BeautyLand.Application.Services.Administrator.GuestUsers.GuestUserReport
{
    public class GuestUserGetCurrentReportDto
        {
            public long Views { get; set; }
            public long GuestUsers { get; set; }
            public float ViewsPerGuestUser { get; set; }
           public GuestUserGetChartReportDto IllusterationViews { get; set; }

    }
}
