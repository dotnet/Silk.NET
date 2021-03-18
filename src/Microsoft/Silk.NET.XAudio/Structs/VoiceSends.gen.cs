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
    [NativeName("Name", "XAUDIO2_VOICE_SENDS")]
    public unsafe partial struct VoiceSends
    {
        public VoiceSends
        (
            uint? sendCount = null,
            SendDescriptor* pSends = null
        ) : this()
        {
            if (sendCount is not null)
            {
                SendCount = sendCount.Value;
            }

            if (pSends is not null)
            {
                PSends = pSends;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "SendCount")]
        public uint SendCount;

        [NativeName("Type", "XAUDIO2_SEND_DESCRIPTOR *")]
        [NativeName("Type.Name", "XAUDIO2_SEND_DESCRIPTOR *")]
        [NativeName("Name", "pSends")]
        public SendDescriptor* PSends;
    }
}
