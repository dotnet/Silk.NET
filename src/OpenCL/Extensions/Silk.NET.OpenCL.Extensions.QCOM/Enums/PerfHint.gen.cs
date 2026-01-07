// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [NativeName("Name", "cl_perf_hint_qcom")]
    public enum PerfHint : int
    {
        [NativeName("Name", "CL_PERF_HINT_HIGH_QCOM")]
        High = 0x40C3,
        [NativeName("Name", "CL_PERF_HINT_NORMAL_QCOM")]
        Normal = 0x40C4,
        [NativeName("Name", "CL_PERF_HINT_LOW_QCOM")]
        Low = 0x40C5,
    }
}
