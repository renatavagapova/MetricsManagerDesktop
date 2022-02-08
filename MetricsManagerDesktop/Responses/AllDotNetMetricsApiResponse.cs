﻿using System;
using System.Collections.Generic;


namespace MetricsManagerDesktop.Responses
{
    public class AllDotNetMetricsApiResponse
    {
        public List<DotNetMetricApiResponse> Metrics { get; set; }
    }
    public class DotNetMetricApiResponse
    {
        public DateTimeOffset Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
        public int IdAgent { get; set; }
    }
}