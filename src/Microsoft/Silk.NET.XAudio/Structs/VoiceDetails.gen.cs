// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "XAUDIO2_VOICE_DETAILS")]
    public unsafe partial struct VoiceDetails
    {
        public VoiceDetails
        (
            uint? creationFlags = null,
            uint? activeFlags = null,
            uint? inputChannels = null,
            uint? inputSampleRate = null
        ) : this()
        {
            if (creationFlags is not null)
            {
                CreationFlags = creationFlags.Value;
            }

            if (activeFlags is not null)
            {
                ActiveFlags = activeFlags.Value;
            }

            if (inputChannels is not null)
            {
                InputChannels = inputChannels.Value;
            }

            if (inputSampleRate is not null)
            {
                InputSampleRate = inputSampleRate.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "CreationFlags")]
        public uint CreationFlags;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "ActiveFlags")]
        public uint ActiveFlags;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "InputChannels")]
        public uint InputChannels;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "InputSampleRate")]
        public uint InputSampleRate;
    }
}
