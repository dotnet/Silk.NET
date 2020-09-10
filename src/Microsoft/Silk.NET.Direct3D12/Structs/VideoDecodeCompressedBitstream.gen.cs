// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM")]
    public unsafe partial struct VideoDecodeCompressedBitstream
    {
        public VideoDecodeCompressedBitstream
        (
            ID3D12Resource* pBuffer = default,
            ulong offset = default,
            ulong size = default
        )
        {
            PBuffer = pBuffer;
            Offset = offset;
            Size = size;
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pBuffer")]
        public ID3D12Resource* PBuffer;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Offset")]
        public ulong Offset;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Size")]
        public ulong Size;
    }
}
