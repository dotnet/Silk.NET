// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_FLAGS")]
    public enum DescriptorRangeFlags : int
    {
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_FLAG_NONE")]
        DescriptorRangeFlagNone = 0x0,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_VOLATILE")]
        DescriptorRangeFlagDescriptorsVolatile = 0x1,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_FLAG_DATA_VOLATILE")]
        DescriptorRangeFlagDataVolatile = 0x2,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE")]
        DescriptorRangeFlagDataStaticWhileSetATExecute = 0x4,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC")]
        DescriptorRangeFlagDataStatic = 0x8,
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_STATIC_KEEPING_BUFFER_BOUNDS_CHECKS")]
        DescriptorRangeFlagDescriptorsStaticKeepingBufferBoundsChecks = 0x10000,
    }
}
