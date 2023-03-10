// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUVertexStepMode")]
    public enum VertexStepMode : int
    {
        [NativeName("Name", "WGPUVertexStepMode_Vertex")]
        Vertex = 0x0,
        [NativeName("Name", "WGPUVertexStepMode_Instance")]
        Instance = 0x1,
        [NativeName("Name", "WGPUVertexStepMode_VertexBufferNotUsed")]
        VertexBufferNotUsed = 0x2,
        [NativeName("Name", "WGPUVertexStepMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
