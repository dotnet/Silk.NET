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
    [NativeName("AnonymousName", "__AnonymousRecord_dcomptypes_L78_C9")]
    [NativeName("Name", "DCOMPOSITION_FRAME_STATISTICS")]
    public unsafe partial struct FRAMESTATISTICS
    {
        public FRAMESTATISTICS
        (
            long? lastFrameTime = null,
            Silk.NET.DXGI.Rational? currentCompositionRate = null,
            long? currentTime = null,
            long? timeFrequency = null,
            long? nextEstimatedFrameTime = null
        ) : this()
        {
            if (lastFrameTime is not null)
            {
                LastFrameTime = lastFrameTime.Value;
            }

            if (currentCompositionRate is not null)
            {
                CurrentCompositionRate = currentCompositionRate.Value;
            }

            if (currentTime is not null)
            {
                CurrentTime = currentTime.Value;
            }

            if (timeFrequency is not null)
            {
                TimeFrequency = timeFrequency.Value;
            }

            if (nextEstimatedFrameTime is not null)
            {
                NextEstimatedFrameTime = nextEstimatedFrameTime.Value;
            }
        }


        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "lastFrameTime")]
        public long LastFrameTime;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "currentCompositionRate")]
        public Silk.NET.DXGI.Rational CurrentCompositionRate;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "currentTime")]
        public long CurrentTime;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "timeFrequency")]
        public long TimeFrequency;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "nextEstimatedFrameTime")]
        public long NextEstimatedFrameTime;
    }
}
