// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUBufferUsage")]
    public enum BufferUsage : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "WGPUBufferUsage_None")]
        BufferUsageNone = 0x0,
        [Obsolete("Deprecated in favour of \"MapRead\"")]
        [NativeName("Name", "WGPUBufferUsage_MapRead")]
        BufferUsageMapRead = 0x1,
        [Obsolete("Deprecated in favour of \"MapWrite\"")]
        [NativeName("Name", "WGPUBufferUsage_MapWrite")]
        BufferUsageMapWrite = 0x2,
        [Obsolete("Deprecated in favour of \"CopySrc\"")]
        [NativeName("Name", "WGPUBufferUsage_CopySrc")]
        BufferUsageCopySrc = 0x4,
        [Obsolete("Deprecated in favour of \"CopyDst\"")]
        [NativeName("Name", "WGPUBufferUsage_CopyDst")]
        BufferUsageCopyDst = 0x8,
        [Obsolete("Deprecated in favour of \"Index\"")]
        [NativeName("Name", "WGPUBufferUsage_Index")]
        BufferUsageIndex = 0x10,
        [Obsolete("Deprecated in favour of \"Vertex\"")]
        [NativeName("Name", "WGPUBufferUsage_Vertex")]
        BufferUsageVertex = 0x20,
        [Obsolete("Deprecated in favour of \"Uniform\"")]
        [NativeName("Name", "WGPUBufferUsage_Uniform")]
        BufferUsageUniform = 0x40,
        [Obsolete("Deprecated in favour of \"Storage\"")]
        [NativeName("Name", "WGPUBufferUsage_Storage")]
        BufferUsageStorage = 0x80,
        [Obsolete("Deprecated in favour of \"Indirect\"")]
        [NativeName("Name", "WGPUBufferUsage_Indirect")]
        BufferUsageIndirect = 0x100,
        [Obsolete("Deprecated in favour of \"QueryResolve\"")]
        [NativeName("Name", "WGPUBufferUsage_QueryResolve")]
        BufferUsageQueryResolve = 0x200,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUBufferUsage_Force32")]
        BufferUsageForce32 = 0x7FFFFFFF,
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
