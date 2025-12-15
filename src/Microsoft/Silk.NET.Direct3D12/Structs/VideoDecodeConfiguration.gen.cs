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
    [NativeName("Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
    public unsafe partial struct VideoDecodeConfiguration
    {
        public VideoDecodeConfiguration
        (
            Guid? decodeProfile = null,
            BitstreamEncryptionType? bitstreamEncryption = null,
            VideoFrameCodedInterlaceType? interlaceType = null
        ) : this()
        {
            if (decodeProfile is not null)
            {
                DecodeProfile = decodeProfile.Value;
            }

            if (bitstreamEncryption is not null)
            {
                BitstreamEncryption = bitstreamEncryption.Value;
            }

            if (interlaceType is not null)
            {
                InterlaceType = interlaceType.Value;
            }
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
