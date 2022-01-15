// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_TYPE")]
    public enum DescriptorRangeType : int
    {
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_TYPE_SRV")]
        DescriptorRangeTypeSrv = 0x0,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_TYPE_UAV")]
        DescriptorRangeTypeUav = 0x1,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_TYPE_CBV")]
        DescriptorRangeTypeCbv = 0x2,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_TYPE_SAMPLER")]
        DescriptorRangeTypeSampler = 0x3,
    }
}
