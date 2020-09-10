// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L2754_C5")]
    public unsafe partial struct AnonymousRecordD3d12L2754C5
    {
        public AnonymousRecordD3d12L2754C5
        (
            ResourceTransitionBarrier transition = default,
            ResourceAliasingBarrier aliasing = default,
            ResourceUavBarrier uAV = default
        )
        {
            Transition = transition;
            Aliasing = aliasing;
            UAV = uAV;
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RESOURCE_TRANSITION_BARRIER")]
        [NativeName("Type.Name", "D3D12_RESOURCE_TRANSITION_BARRIER")]
        [NativeName("Name", "Transition")]
        public ResourceTransitionBarrier Transition;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RESOURCE_ALIASING_BARRIER")]
        [NativeName("Type.Name", "D3D12_RESOURCE_ALIASING_BARRIER")]
        [NativeName("Name", "Aliasing")]
        public ResourceAliasingBarrier Aliasing;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RESOURCE_UAV_BARRIER")]
        [NativeName("Type.Name", "D3D12_RESOURCE_UAV_BARRIER")]
        [NativeName("Name", "UAV")]
        public ResourceUavBarrier UAV;
    }
}
