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
