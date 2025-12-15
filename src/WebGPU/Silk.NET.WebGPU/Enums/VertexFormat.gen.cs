// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUVertexFormat")]
    public enum VertexFormat : int
    {
        [NativeName("Name", "WGPUVertexFormat_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUVertexFormat_Uint8x2")]
        Uint8x2 = 0x1,
        [NativeName("Name", "WGPUVertexFormat_Uint8x4")]
        Uint8x4 = 0x2,
        [NativeName("Name", "WGPUVertexFormat_Sint8x2")]
        Sint8x2 = 0x3,
        [NativeName("Name", "WGPUVertexFormat_Sint8x4")]
        Sint8x4 = 0x4,
        [NativeName("Name", "WGPUVertexFormat_Unorm8x2")]
        Unorm8x2 = 0x5,
        [NativeName("Name", "WGPUVertexFormat_Unorm8x4")]
        Unorm8x4 = 0x6,
        [NativeName("Name", "WGPUVertexFormat_Snorm8x2")]
        Snorm8x2 = 0x7,
        [NativeName("Name", "WGPUVertexFormat_Snorm8x4")]
        Snorm8x4 = 0x8,
        [NativeName("Name", "WGPUVertexFormat_Uint16x2")]
        Uint16x2 = 0x9,
        [NativeName("Name", "WGPUVertexFormat_Uint16x4")]
        Uint16x4 = 0xA,
        [NativeName("Name", "WGPUVertexFormat_Sint16x2")]
        Sint16x2 = 0xB,
        [NativeName("Name", "WGPUVertexFormat_Sint16x4")]
        Sint16x4 = 0xC,
        [NativeName("Name", "WGPUVertexFormat_Unorm16x2")]
        Unorm16x2 = 0xD,
        [NativeName("Name", "WGPUVertexFormat_Unorm16x4")]
        Unorm16x4 = 0xE,
        [NativeName("Name", "WGPUVertexFormat_Snorm16x2")]
        Snorm16x2 = 0xF,
        [NativeName("Name", "WGPUVertexFormat_Snorm16x4")]
        Snorm16x4 = 0x10,
        [NativeName("Name", "WGPUVertexFormat_Float16x2")]
        Float16x2 = 0x11,
        [NativeName("Name", "WGPUVertexFormat_Float16x4")]
        Float16x4 = 0x12,
        [NativeName("Name", "WGPUVertexFormat_Float32")]
        Float32 = 0x13,
        [NativeName("Name", "WGPUVertexFormat_Float32x2")]
        Float32x2 = 0x14,
        [NativeName("Name", "WGPUVertexFormat_Float32x3")]
        Float32x3 = 0x15,
        [NativeName("Name", "WGPUVertexFormat_Float32x4")]
        Float32x4 = 0x16,
        [NativeName("Name", "WGPUVertexFormat_Uint32")]
        Uint32 = 0x17,
        [NativeName("Name", "WGPUVertexFormat_Uint32x2")]
        Uint32x2 = 0x18,
        [NativeName("Name", "WGPUVertexFormat_Uint32x3")]
        Uint32x3 = 0x19,
        [NativeName("Name", "WGPUVertexFormat_Uint32x4")]
        Uint32x4 = 0x1A,
        [NativeName("Name", "WGPUVertexFormat_Sint32")]
        Sint32 = 0x1B,
        [NativeName("Name", "WGPUVertexFormat_Sint32x2")]
        Sint32x2 = 0x1C,
        [NativeName("Name", "WGPUVertexFormat_Sint32x3")]
        Sint32x3 = 0x1D,
        [NativeName("Name", "WGPUVertexFormat_Sint32x4")]
        Sint32x4 = 0x1E,
        [NativeName("Name", "WGPUVertexFormat_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
