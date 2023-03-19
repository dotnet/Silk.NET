// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUCompilationInfoRequestStatus")]
    public enum CompilationInfoRequestStatus : int
    {
        [NativeName("Name", "WGPUCompilationInfoRequestStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUCompilationInfoRequestStatus_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPUCompilationInfoRequestStatus_DeviceLost")]
        DeviceLost = 0x2,
        [NativeName("Name", "WGPUCompilationInfoRequestStatus_Unknown")]
        Unknown = 0x3,
        [NativeName("Name", "WGPUCompilationInfoRequestStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
