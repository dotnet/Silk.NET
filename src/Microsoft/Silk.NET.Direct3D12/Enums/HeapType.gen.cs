// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_HEAP_TYPE")]
    public enum HeapType : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D3D12_HEAP_TYPE_DEFAULT")]
        HeapTypeDefault = 0x1,
        [Obsolete("Deprecated in favour of \"Upload\"")]
        [NativeName("Name", "D3D12_HEAP_TYPE_UPLOAD")]
        HeapTypeUpload = 0x2,
        [Obsolete("Deprecated in favour of \"Readback\"")]
        [NativeName("Name", "D3D12_HEAP_TYPE_READBACK")]
        HeapTypeReadback = 0x3,
        [Obsolete("Deprecated in favour of \"Custom\"")]
        [NativeName("Name", "D3D12_HEAP_TYPE_CUSTOM")]
        HeapTypeCustom = 0x4,
        [Obsolete("Deprecated in favour of \"GpuUpload\"")]
        [NativeName("Name", "D3D12_HEAP_TYPE_GPU_UPLOAD")]
        HeapTypeGpuUpload = 0x5,
        [NativeName("Name", "D3D12_HEAP_TYPE_DEFAULT")]
        Default = 0x1,
        [NativeName("Name", "D3D12_HEAP_TYPE_UPLOAD")]
        Upload = 0x2,
        [NativeName("Name", "D3D12_HEAP_TYPE_READBACK")]
        Readback = 0x3,
        [NativeName("Name", "D3D12_HEAP_TYPE_CUSTOM")]
        Custom = 0x4,
        [NativeName("Name", "D3D12_HEAP_TYPE_GPU_UPLOAD")]
        GpuUpload = 0x5,
    }
}
