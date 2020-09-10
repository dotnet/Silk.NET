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
    [NativeName("Name", "D3D12_RESOURCE_TRANSITION_BARRIER")]
    public unsafe partial struct ResourceTransitionBarrier
    {
        public ResourceTransitionBarrier
        (
            ID3D12Resource* pResource = default,
            uint subresource = default,
            ResourceStates stateBefore = default,
            ResourceStates stateAfter = default
        )
        {
            PResource = pResource;
            Subresource = subresource;
            StateBefore = stateBefore;
            StateAfter = stateAfter;
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResource")]
        public ID3D12Resource* PResource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Subresource")]
        public uint Subresource;

        [NativeName("Type", "D3D12_RESOURCE_STATES")]
        [NativeName("Type.Name", "D3D12_RESOURCE_STATES")]
        [NativeName("Name", "StateBefore")]
        public ResourceStates StateBefore;

        [NativeName("Type", "D3D12_RESOURCE_STATES")]
        [NativeName("Type.Name", "D3D12_RESOURCE_STATES")]
        [NativeName("Name", "StateAfter")]
        public ResourceStates StateAfter;
    }
}
