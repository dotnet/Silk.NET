// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3215_C5")]
    public unsafe partial struct ResourceBarrierUnion
    {
        public ResourceBarrierUnion
        (
            ResourceTransitionBarrier? transition = null,
            ResourceAliasingBarrier? aliasing = null,
            ResourceUavBarrier? uAV = null
        ) : this()
        {
            if (transition is not null)
            {
                Transition = transition.Value;
            }

            if (aliasing is not null)
            {
                Aliasing = aliasing.Value;
            }

            if (uAV is not null)
            {
                UAV = uAV.Value;
            }
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
