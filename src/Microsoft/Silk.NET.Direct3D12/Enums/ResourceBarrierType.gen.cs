// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE")]
    public enum ResourceBarrierType
    {
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE_TRANSITION")]
        ResourceBarrierTypeTransition = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE_ALIASING")]
        ResourceBarrierTypeAliasing = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE_UAV")]
        ResourceBarrierTypeUav = 0x2,
    }
}
