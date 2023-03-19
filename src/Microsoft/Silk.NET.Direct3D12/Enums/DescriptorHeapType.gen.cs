// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE")]
    public enum DescriptorHeapType : int
    {
        [Obsolete("Deprecated in favour of \"CbvSrvUav\"")]
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV")]
        DescriptorHeapTypeCbvSrvUav = 0x0,
        [Obsolete("Deprecated in favour of \"Sampler\"")]
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER")]
        DescriptorHeapTypeSampler = 0x1,
        [Obsolete("Deprecated in favour of \"Rtv\"")]
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_RTV")]
        DescriptorHeapTypeRtv = 0x2,
        [Obsolete("Deprecated in favour of \"Dsv\"")]
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_DSV")]
        DescriptorHeapTypeDsv = 0x3,
        [Obsolete("Deprecated in favour of \"NumTypes\"")]
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES")]
        DescriptorHeapTypeNumTypes = 0x4,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV")]
        CbvSrvUav = 0x0,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER")]
        Sampler = 0x1,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_RTV")]
        Rtv = 0x2,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_DSV")]
        Dsv = 0x3,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES")]
        NumTypes = 0x4,
    }
}
