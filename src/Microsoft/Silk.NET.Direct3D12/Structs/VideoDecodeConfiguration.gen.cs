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
    [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
    public unsafe partial struct VideoDecodeConfiguration
    {
        public VideoDecodeConfiguration
        (
            Guid decodeProfile = default,
            BitstreamEncryptionType bitstreamEncryption = default,
            VideoFrameCodedInterlaceType interlaceType = default
        )
        {
            DecodeProfile = decodeProfile;
            BitstreamEncryption = bitstreamEncryption;
            InterlaceType = interlaceType;
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "DecodeProfile")]
        public Guid DecodeProfile;

        [NativeName("Type", "D3D12_BITSTREAM_ENCRYPTION_TYPE")]
        [NativeName("Type.Name", "D3D12_BITSTREAM_ENCRYPTION_TYPE")]
        [NativeName("Name", "BitstreamEncryption")]
        public BitstreamEncryptionType BitstreamEncryption;

        [NativeName("Type", "D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE")]
        [NativeName("Name", "InterlaceType")]
        public VideoFrameCodedInterlaceType InterlaceType;
    }
}
