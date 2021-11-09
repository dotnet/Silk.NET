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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM")]
    public unsafe partial struct VideoEncoderCompressedBitstream
    {
        public VideoEncoderCompressedBitstream
        (
            ID3D12Resource* pBuffer = null,
            ulong? frameStartOffset = null
        ) : this()
        {
            if (pBuffer is not null)
            {
                PBuffer = pBuffer;
            }

            if (frameStartOffset is not null)
            {
                FrameStartOffset = frameStartOffset.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pBuffer")]
        public ID3D12Resource* PBuffer;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "FrameStartOffset")]
        public ulong FrameStartOffset;
    }
}
