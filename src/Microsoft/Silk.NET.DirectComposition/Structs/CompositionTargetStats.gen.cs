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

namespace Silk.NET.DirectComposition
{
    [NativeName("Name", "tagCOMPOSITION_TARGET_STATS")]
    public unsafe partial struct CompositionTargetStats
    {
        public CompositionTargetStats
        (
            uint? outstandingPresents = null,
            ulong? presentTime = null,
            ulong? vblankDuration = null,
            CompositionStats? presentedStats = null,
            CompositionStats? completedStats = null
        ) : this()
        {
            if (outstandingPresents is not null)
            {
                OutstandingPresents = outstandingPresents.Value;
            }

            if (presentTime is not null)
            {
                PresentTime = presentTime.Value;
            }

            if (vblankDuration is not null)
            {
                VblankDuration = vblankDuration.Value;
            }

            if (presentedStats is not null)
            {
                PresentedStats = presentedStats.Value;
            }

            if (completedStats is not null)
            {
                CompletedStats = completedStats.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "outstandingPresents")]
        public uint OutstandingPresents;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "presentTime")]
        public ulong PresentTime;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "vblankDuration")]
        public ulong VblankDuration;

        [NativeName("Type", "COMPOSITION_STATS")]
        [NativeName("Type.Name", "COMPOSITION_STATS")]
        [NativeName("Name", "presentedStats")]
        public CompositionStats PresentedStats;

        [NativeName("Type", "COMPOSITION_STATS")]
        [NativeName("Type.Name", "COMPOSITION_STATS")]
        [NativeName("Name", "completedStats")]
        public CompositionStats CompletedStats;
    }
}
