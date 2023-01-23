// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUBufferUsage")]
    public enum BufferUsage : int
    {
        [NativeName("Name", "WGPUBufferUsage_None")]
        None = 0x0,
        [NativeName("Name", "WGPUBufferUsage_MapRead")]
        MapRead = 0x1,
        [NativeName("Name", "WGPUBufferUsage_MapWrite")]
        MapWrite = 0x2,
        [NativeName("Name", "WGPUBufferUsage_CopySrc")]
        CopySrc = 0x4,
        [NativeName("Name", "WGPUBufferUsage_CopyDst")]
        CopyDst = 0x8,
        [NativeName("Name", "WGPUBufferUsage_Index")]
        Index = 0x10,
        [NativeName("Name", "WGPUBufferUsage_Vertex")]
        Vertex = 0x20,
        [NativeName("Name", "WGPUBufferUsage_Uniform")]
        Uniform = 0x40,
        [NativeName("Name", "WGPUBufferUsage_Storage")]
        Storage = 0x80,
        [NativeName("Name", "WGPUBufferUsage_Indirect")]
        Indirect = 0x100,
        [NativeName("Name", "WGPUBufferUsage_QueryResolve")]
        QueryResolve = 0x200,
        [NativeName("Name", "WGPUBufferUsage_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
