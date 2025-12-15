// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAGS")]
    public enum ResourceBarrierFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_NONE")]
        ResourceBarrierFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"BeginOnly\"")]
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_BEGIN_ONLY")]
        ResourceBarrierFlagBeginOnly = 0x1,
        [Obsolete("Deprecated in favour of \"EndOnly\"")]
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_END_ONLY")]
        ResourceBarrierFlagEndOnly = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_BEGIN_ONLY")]
        BeginOnly = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_END_ONLY")]
        EndOnly = 0x2,
    }
}
