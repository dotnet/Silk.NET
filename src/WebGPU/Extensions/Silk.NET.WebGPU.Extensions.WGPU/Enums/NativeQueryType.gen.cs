// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeQueryType")]
    public enum NativeQueryType : int
    {
        [NativeName("Name", "WGPUNativeQueryType_PipelineStatistics")]
        PipelineStatistics = 0x30000,
        [NativeName("Name", "WGPUNativeQueryType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
