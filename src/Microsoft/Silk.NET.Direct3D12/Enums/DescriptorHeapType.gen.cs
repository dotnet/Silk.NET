// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE")]
    public enum DescriptorHeapType : int
    {
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV")]
        DescriptorHeapTypeCbvSrvUav = 0x0,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER")]
        DescriptorHeapTypeSampler = 0x1,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_RTV")]
        DescriptorHeapTypeRtv = 0x2,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_DSV")]
        DescriptorHeapTypeDsv = 0x3,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES")]
        DescriptorHeapTypeNumTypes = 0x4,
    }
}
