// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.INTEL
{
    [NativeName("Name", "GLenum")]
    public enum INTEL : int
    {
        [NativeName("Name", "GL_BLACKHOLE_RENDER_INTEL")]
        BlackholeRenderIntel = 0x83FC,
        [NativeName("Name", "GL_CONSERVATIVE_RASTERIZATION_INTEL")]
        ConservativeRasterizationIntel = 0x83FE,
        [NativeName("Name", "GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
        PerfquerySingleContextIntel = 0x0,
        [NativeName("Name", "GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
        PerfqueryGlobalContextIntel = 0x1,
        [NativeName("Name", "GL_PERFQUERY_WAIT_INTEL")]
        PerfqueryWaitIntel = 0x83FB,
        [NativeName("Name", "GL_PERFQUERY_FLUSH_INTEL")]
        PerfqueryFlushIntel = 0x83FA,
        [NativeName("Name", "GL_PERFQUERY_DONOT_FLUSH_INTEL")]
        PerfqueryDonotFlushIntel = 0x83F9,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_EVENT_INTEL")]
        PerfqueryCounterEventIntel = 0x94F0,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL")]
        PerfqueryCounterDurationNormIntel = 0x94F1,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL")]
        PerfqueryCounterDurationRawIntel = 0x94F2,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL")]
        PerfqueryCounterThroughputIntel = 0x94F3,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_RAW_INTEL")]
        PerfqueryCounterRawIntel = 0x94F4,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL")]
        PerfqueryCounterTimestampIntel = 0x94F5,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL")]
        PerfqueryCounterDataUint32Intel = 0x94F8,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL")]
        PerfqueryCounterDataUint64Intel = 0x94F9,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL")]
        PerfqueryCounterDataFloatIntel = 0x94FA,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL")]
        PerfqueryCounterDataDoubleIntel = 0x94FB,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL")]
        PerfqueryCounterDataBool32Intel = 0x94FC,
        [NativeName("Name", "GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL")]
        PerfqueryQueryNameLengthMaxIntel = 0x94FD,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL")]
        PerfqueryCounterNameLengthMaxIntel = 0x94FE,
        [NativeName("Name", "GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL")]
        PerfqueryCounterDescLengthMaxIntel = 0x94FF,
        [NativeName("Name", "GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL")]
        PerfqueryGpaExtendedCountersIntel = 0x9500,
    }
}
