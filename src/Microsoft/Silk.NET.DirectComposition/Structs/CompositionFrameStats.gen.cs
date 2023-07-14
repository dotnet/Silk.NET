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
    [NativeName("Name", "tagCOMPOSITION_FRAME_STATS")]
    public unsafe partial struct CompositionFrameStats
    {
        public CompositionFrameStats
        (
            ulong? startTime = null,
            ulong? targetTime = null,
            ulong? framePeriod = null
        ) : this()
        {
            if (startTime is not null)
            {
                StartTime = startTime.Value;
            }

            if (targetTime is not null)
            {
                TargetTime = targetTime.Value;
            }

            if (framePeriod is not null)
            {
                FramePeriod = framePeriod.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "startTime")]
        public ulong StartTime;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "targetTime")]
        public ulong TargetTime;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "framePeriod")]
        public ulong FramePeriod;
    }
}
