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
    [NativeName("Name", "XAUDIO2_BUFFER")]
    public unsafe partial struct Buffer
    {
        public Buffer
        (
            uint? flags = null,
            uint? audioBytes = null,
            byte* pAudioData = null,
            uint? playBegin = null,
            uint? playLength = null,
            uint? loopBegin = null,
            uint? loopLength = null,
            uint? loopCount = null,
            void* pContext = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (audioBytes is not null)
            {
                AudioBytes = audioBytes.Value;
            }

            if (pAudioData is not null)
            {
                PAudioData = pAudioData;
            }

            if (playBegin is not null)
            {
                PlayBegin = playBegin.Value;
            }

            if (playLength is not null)
            {
                PlayLength = playLength.Value;
            }

            if (loopBegin is not null)
            {
                LoopBegin = loopBegin.Value;
            }

            if (loopLength is not null)
            {
                LoopLength = loopLength.Value;
            }

            if (loopCount is not null)
            {
                LoopCount = loopCount.Value;
            }

            if (pContext is not null)
            {
                PContext = pContext;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "AudioBytes")]
        public uint AudioBytes;

        [NativeName("Type", "const BYTE *")]
        [NativeName("Type.Name", "const BYTE *")]
        [NativeName("Name", "pAudioData")]
        public byte* PAudioData;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "PlayBegin")]
        public uint PlayBegin;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "PlayLength")]
        public uint PlayLength;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "LoopBegin")]
        public uint LoopBegin;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "LoopLength")]
        public uint LoopLength;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "LoopCount")]
        public uint LoopCount;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pContext")]
        public void* PContext;
    }
}
