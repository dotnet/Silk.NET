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
