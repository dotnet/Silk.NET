// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUVertexStepMode")]
    public enum VertexStepMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Vertex\"")]
        [NativeName("Name", "WGPUVertexStepMode_Vertex")]
        VertexStepModeVertex = 0x0,
        [Obsolete("Deprecated in favour of \"Instance\"")]
        [NativeName("Name", "WGPUVertexStepMode_Instance")]
        VertexStepModeInstance = 0x1,
        [Obsolete("Deprecated in favour of \"VertexBufferNotUsed\"")]
        [NativeName("Name", "WGPUVertexStepMode_VertexBufferNotUsed")]
        VertexStepModeVertexBufferNotUsed = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUVertexStepMode_Force32")]
        VertexStepModeForce32 = 0x7FFFFFFF,
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
