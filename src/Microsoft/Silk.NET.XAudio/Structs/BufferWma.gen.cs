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
    [NativeName("Name", "XAUDIO2_BUFFER_WMA")]
    public unsafe partial struct BufferWma
    {
        public BufferWma
        (
            uint* pDecodedPacketCumulativeBytes = null,
            uint? packetCount = null
        ) : this()
        {
            if (pDecodedPacketCumulativeBytes is not null)
            {
                PDecodedPacketCumulativeBytes = pDecodedPacketCumulativeBytes;
            }

            if (packetCount is not null)
            {
                PacketCount = packetCount.Value;
            }
        }


        [NativeName("Type", "const UINT32 *")]
        [NativeName("Type.Name", "const UINT32 *")]
        [NativeName("Name", "pDecodedPacketCumulativeBytes")]
        public uint* PDecodedPacketCumulativeBytes;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "PacketCount")]
        public uint PacketCount;
    }
}
