// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUShaderStage")]
    public enum ShaderStage : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "WGPUShaderStage_None")]
        ShaderStageNone = 0x0,
        [Obsolete("Deprecated in favour of \"Vertex\"")]
        [NativeName("Name", "WGPUShaderStage_Vertex")]
        ShaderStageVertex = 0x1,
        [Obsolete("Deprecated in favour of \"Fragment\"")]
        [NativeName("Name", "WGPUShaderStage_Fragment")]
        ShaderStageFragment = 0x2,
        [Obsolete("Deprecated in favour of \"Compute\"")]
        [NativeName("Name", "WGPUShaderStage_Compute")]
        ShaderStageCompute = 0x4,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUShaderStage_Force32")]
        ShaderStageForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUShaderStage_None")]
        None = 0x0,
        [NativeName("Name", "WGPUShaderStage_Vertex")]
        Vertex = 0x1,
        [NativeName("Name", "WGPUShaderStage_Fragment")]
        Fragment = 0x2,
        [NativeName("Name", "WGPUShaderStage_Compute")]
        Compute = 0x4,
        [NativeName("Name", "WGPUShaderStage_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
