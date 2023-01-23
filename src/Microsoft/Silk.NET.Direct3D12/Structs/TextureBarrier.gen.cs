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
    [NativeName("Name", "D3D12_TEXTURE_BARRIER")]
    public unsafe partial struct TextureBarrier
    {
        public TextureBarrier
        (
            BarrierSync? syncBefore = null,
            BarrierSync? syncAfter = null,
            BarrierAccess? accessBefore = null,
            BarrierAccess? accessAfter = null,
            BarrierLayout? layoutBefore = null,
            BarrierLayout? layoutAfter = null,
            ID3D12Resource* pResource = null,
            BarrierSubresourceRange? subresources = null,
            TextureBarrierFlags? flags = null
        ) : this()
        {
            if (syncBefore is not null)
            {
                SyncBefore = syncBefore.Value;
            }

            if (syncAfter is not null)
            {
                SyncAfter = syncAfter.Value;
            }

            if (accessBefore is not null)
            {
                AccessBefore = accessBefore.Value;
            }

            if (accessAfter is not null)
            {
                AccessAfter = accessAfter.Value;
            }

            if (layoutBefore is not null)
            {
                LayoutBefore = layoutBefore.Value;
            }

            if (layoutAfter is not null)
            {
                LayoutAfter = layoutAfter.Value;
            }

            if (pResource is not null)
            {
                PResource = pResource;
            }

            if (subresources is not null)
            {
                Subresources = subresources.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "D3D12_BARRIER_SYNC")]
        [NativeName("Type.Name", "D3D12_BARRIER_SYNC")]
        [NativeName("Name", "SyncBefore")]
        public BarrierSync SyncBefore;

        [NativeName("Type", "D3D12_BARRIER_SYNC")]
        [NativeName("Type.Name", "D3D12_BARRIER_SYNC")]
        [NativeName("Name", "SyncAfter")]
        public BarrierSync SyncAfter;

        [NativeName("Type", "D3D12_BARRIER_ACCESS")]
        [NativeName("Type.Name", "D3D12_BARRIER_ACCESS")]
        [NativeName("Name", "AccessBefore")]
        public BarrierAccess AccessBefore;

        [NativeName("Type", "D3D12_BARRIER_ACCESS")]
        [NativeName("Type.Name", "D3D12_BARRIER_ACCESS")]
        [NativeName("Name", "AccessAfter")]
        public BarrierAccess AccessAfter;

        [NativeName("Type", "D3D12_BARRIER_LAYOUT")]
        [NativeName("Type.Name", "D3D12_BARRIER_LAYOUT")]
        [NativeName("Name", "LayoutBefore")]
        public BarrierLayout LayoutBefore;

        [NativeName("Type", "D3D12_BARRIER_LAYOUT")]
        [NativeName("Type.Name", "D3D12_BARRIER_LAYOUT")]
        [NativeName("Name", "LayoutAfter")]
        public BarrierLayout LayoutAfter;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResource")]
        public ID3D12Resource* PResource;

        [NativeName("Type", "D3D12_BARRIER_SUBRESOURCE_RANGE")]
        [NativeName("Type.Name", "D3D12_BARRIER_SUBRESOURCE_RANGE")]
        [NativeName("Name", "Subresources")]
        public BarrierSubresourceRange Subresources;

        [NativeName("Type", "D3D12_TEXTURE_BARRIER_FLAGS")]
        [NativeName("Type.Name", "D3D12_TEXTURE_BARRIER_FLAGS")]
        [NativeName("Name", "Flags")]
        public TextureBarrierFlags Flags;
    }
}
