// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_TRACE_QUERY_INFO_CLASS")]
    public enum TraceQueryInfoClass : int
    {
        [NativeName("Name", "TraceGuidQueryList")]
        TraceGuidQueryList = 0x0,
        [NativeName("Name", "TraceGuidQueryInfo")]
        TraceGuidQueryInfo = 0x1,
        [NativeName("Name", "TraceGuidQueryProcess")]
        TraceGuidQueryProcess = 0x2,
        [NativeName("Name", "TraceStackTracingInfo")]
        TraceStackTracingInfo = 0x3,
        [NativeName("Name", "TraceSystemTraceEnableFlagsInfo")]
        TraceSystemTraceEnableFlagsInfo = 0x4,
        [NativeName("Name", "TraceSampledProfileIntervalInfo")]
        TraceSampledProfileIntervalInfo = 0x5,
        [NativeName("Name", "TraceProfileSourceConfigInfo")]
        TraceProfileSourceConfigInfo = 0x6,
        [NativeName("Name", "TraceProfileSourceListInfo")]
        TraceProfileSourceListInfo = 0x7,
        [NativeName("Name", "TracePmcEventListInfo")]
        TracePmcEventListInfo = 0x8,
        [NativeName("Name", "TracePmcCounterListInfo")]
        TracePmcCounterListInfo = 0x9,
        [NativeName("Name", "TraceSetDisallowList")]
        TraceSetDisallowList = 0xA,
        [NativeName("Name", "TraceVersionInfo")]
        TraceVersionInfo = 0xB,
        [NativeName("Name", "TraceGroupQueryList")]
        TraceGroupQueryList = 0xC,
        [NativeName("Name", "TraceGroupQueryInfo")]
        TraceGroupQueryInfo = 0xD,
        [NativeName("Name", "TraceDisallowListQuery")]
        TraceDisallowListQuery = 0xE,
        [NativeName("Name", "TraceInfoReserved15")]
        TraceInfoReserved15 = 0xF,
        [NativeName("Name", "TracePeriodicCaptureStateListInfo")]
        TracePeriodicCaptureStateListInfo = 0x10,
        [NativeName("Name", "TracePeriodicCaptureStateInfo")]
        TracePeriodicCaptureStateInfo = 0x11,
        [NativeName("Name", "TraceProviderBinaryTracking")]
        TraceProviderBinaryTracking = 0x12,
        [NativeName("Name", "TraceMaxLoggersQuery")]
        TraceMaxLoggersQuery = 0x13,
        [NativeName("Name", "TraceLbrConfigurationInfo")]
        TraceLbrConfigurationInfo = 0x14,
        [NativeName("Name", "TraceLbrEventListInfo")]
        TraceLbrEventListInfo = 0x15,
        [NativeName("Name", "TraceMaxPmcCounterQuery")]
        TraceMaxPmcCounterQuery = 0x16,
        [NativeName("Name", "TraceStreamCount")]
        TraceStreamCount = 0x17,
        [NativeName("Name", "TraceStackCachingInfo")]
        TraceStackCachingInfo = 0x18,
        [NativeName("Name", "TracePmcCounterOwners")]
        TracePmcCounterOwners = 0x19,
        [NativeName("Name", "TraceUnifiedStackCachingInfo")]
        TraceUnifiedStackCachingInfo = 0x1A,
        [NativeName("Name", "TracePmcSessionInformation")]
        TracePmcSessionInformation = 0x1B,
        [NativeName("Name", "TraceContextRegisterInfo")]
        TraceContextRegisterInfo = 0x1C,
        [NativeName("Name", "MaxTraceSetInfoClass")]
        MaxTraceSetInfoClass = 0x1D,
    }
}
