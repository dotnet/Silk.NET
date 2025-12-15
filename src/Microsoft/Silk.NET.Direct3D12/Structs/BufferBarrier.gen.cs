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
    [NativeName("Name", "D3D12_BUFFER_BARRIER")]
    public unsafe partial struct BufferBarrier
    {
        public BufferBarrier
        (
            BarrierSync? syncBefore = null,
            BarrierSync? syncAfter = null,
            BarrierAccess? accessBefore = null,
            BarrierAccess? accessAfter = null,
            ID3D12Resource* pResource = null,
            ulong? offset = null,
            ulong? size = null
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

            if (pResource is not null)
            {
                PResource = pResource;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
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

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResource")]
        public ID3D12Resource* PResource;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Offset")]
        public ulong Offset;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Size")]
        public ulong Size;
    }
}
