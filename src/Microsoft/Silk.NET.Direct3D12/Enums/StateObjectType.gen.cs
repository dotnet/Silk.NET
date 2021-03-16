// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STATE_OBJECT_TYPE")]
    public enum StateObjectType : int
    {
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_COLLECTION")]
        StateObjectTypeCollection = 0x0,
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_RAYTRACING_PIPELINE")]
        StateObjectTypeRaytracingPipeline = 0x3,
    }
}
