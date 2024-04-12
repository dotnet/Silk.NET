// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUPipelineStatisticName")]
    public enum PipelineStatisticName : int
    {
        [NativeName("Name", "WGPUPipelineStatisticName_VertexShaderInvocations")]
        VertexShaderInvocations = 0x0,
        [NativeName("Name", "WGPUPipelineStatisticName_ClipperInvocations")]
        ClipperInvocations = 0x1,
        [NativeName("Name", "WGPUPipelineStatisticName_ClipperPrimitivesOut")]
        ClipperPrimitivesOut = 0x2,
        [NativeName("Name", "WGPUPipelineStatisticName_FragmentShaderInvocations")]
        FragmentShaderInvocations = 0x3,
        [NativeName("Name", "WGPUPipelineStatisticName_ComputeShaderInvocations")]
        ComputeShaderInvocations = 0x4,
        [NativeName("Name", "WGPUPipelineStatisticName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
