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
    [NativeName("Name", "XAUDIO2_SEND_DESCRIPTOR")]
    public unsafe partial struct SendDescriptor
    {
        public SendDescriptor
        (
            uint? flags = null,
            IXAudio2Voice* pOutputVoice = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pOutputVoice is not null)
            {
                POutputVoice = pOutputVoice;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "IXAudio2Voice *")]
        [NativeName("Type.Name", "IXAudio2Voice *")]
        [NativeName("Name", "pOutputVoice")]
        public IXAudio2Voice* POutputVoice;
    }
}
