// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUPipelineStatisticName")]
    public enum PipelineStatisticName : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"VertexShaderInvocations\"")]
        [NativeName("Name", "WGPUPipelineStatisticName_VertexShaderInvocations")]
        PipelineStatisticNameVertexShaderInvocations = 0x0,
        [Obsolete("Deprecated in favour of \"ClipperInvocations\"")]
        [NativeName("Name", "WGPUPipelineStatisticName_ClipperInvocations")]
        PipelineStatisticNameClipperInvocations = 0x1,
        [Obsolete("Deprecated in favour of \"ClipperPrimitivesOut\"")]
        [NativeName("Name", "WGPUPipelineStatisticName_ClipperPrimitivesOut")]
        PipelineStatisticNameClipperPrimitivesOut = 0x2,
        [Obsolete("Deprecated in favour of \"FragmentShaderInvocations\"")]
        [NativeName("Name", "WGPUPipelineStatisticName_FragmentShaderInvocations")]
        PipelineStatisticNameFragmentShaderInvocations = 0x3,
        [Obsolete("Deprecated in favour of \"ComputeShaderInvocations\"")]
        [NativeName("Name", "WGPUPipelineStatisticName_ComputeShaderInvocations")]
        PipelineStatisticNameComputeShaderInvocations = 0x4,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUPipelineStatisticName_Force32")]
        PipelineStatisticNameForce32 = 0x7FFFFFFF,
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
