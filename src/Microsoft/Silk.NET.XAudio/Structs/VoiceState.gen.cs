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

namespace Silk.NET.XAudio
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "XAUDIO2_VOICE_STATE")]
    public unsafe partial struct VoiceState
    {
        public VoiceState
        (
            void* pCurrentBufferContext = null,
            uint? buffersQueued = null,
            ulong? samplesPlayed = null
        ) : this()
        {
            if (pCurrentBufferContext is not null)
            {
                PCurrentBufferContext = pCurrentBufferContext;
            }

            if (buffersQueued is not null)
            {
                BuffersQueued = buffersQueued.Value;
            }

            if (samplesPlayed is not null)
            {
                SamplesPlayed = samplesPlayed.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pCurrentBufferContext")]
        public void* PCurrentBufferContext;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "BuffersQueued")]
        public uint BuffersQueued;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SamplesPlayed")]
        public ulong SamplesPlayed;
    }
}
