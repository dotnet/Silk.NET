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
    [NativeName("Name", "D3D12_GLOBAL_BARRIER")]
    public unsafe partial struct GlobalBarrier
    {
        public GlobalBarrier
        (
            BarrierSync? syncBefore = null,
            BarrierSync? syncAfter = null,
            BarrierAccess? accessBefore = null,
            BarrierAccess? accessAfter = null
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
    }
}
