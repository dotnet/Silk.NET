// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_HEAP_TYPE")]
    public enum HeapType : int
    {
        [NativeName("Name", "D3D12_HEAP_TYPE_DEFAULT")]
        HeapTypeDefault = 0x1,
        [NativeName("Name", "D3D12_HEAP_TYPE_UPLOAD")]
        HeapTypeUpload = 0x2,
        [NativeName("Name", "D3D12_HEAP_TYPE_READBACK")]
        HeapTypeReadback = 0x3,
        [NativeName("Name", "D3D12_HEAP_TYPE_CUSTOM")]
        HeapTypeCustom = 0x4,
    }
}
