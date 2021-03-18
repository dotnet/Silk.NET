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
    [NativeName("Name", "D3D12_RESOURCE_TRANSITION_BARRIER")]
    public unsafe partial struct ResourceTransitionBarrier
    {
        public ResourceTransitionBarrier
        (
            ID3D12Resource* pResource = null,
            uint? subresource = null,
            ResourceStates? stateBefore = null,
            ResourceStates? stateAfter = null
        ) : this()
        {
            if (pResource is not null)
            {
                PResource = pResource;
            }

            if (subresource is not null)
            {
                Subresource = subresource.Value;
            }

            if (stateBefore is not null)
            {
                StateBefore = stateBefore.Value;
            }

            if (stateAfter is not null)
            {
                StateAfter = stateAfter.Value;
            }
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
