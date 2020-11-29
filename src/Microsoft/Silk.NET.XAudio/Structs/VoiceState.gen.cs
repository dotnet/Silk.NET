// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
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
