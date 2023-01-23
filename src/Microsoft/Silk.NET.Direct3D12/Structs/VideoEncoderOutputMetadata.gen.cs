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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_OUTPUT_METADATA")]
    public unsafe partial struct VideoEncoderOutputMetadata
    {
        public VideoEncoderOutputMetadata
        (
            ulong? encodeErrorFlags = null,
            VideoEncoderOutputMetadataStatistics? encodeStats = null,
            ulong? encodedBitstreamWrittenBytesCount = null,
            ulong? writtenSubregionsCount = null
        ) : this()
        {
            if (encodeErrorFlags is not null)
            {
                EncodeErrorFlags = encodeErrorFlags.Value;
            }

            if (encodeStats is not null)
            {
                EncodeStats = encodeStats.Value;
            }

            if (encodedBitstreamWrittenBytesCount is not null)
            {
                EncodedBitstreamWrittenBytesCount = encodedBitstreamWrittenBytesCount.Value;
            }

            if (writtenSubregionsCount is not null)
            {
                WrittenSubregionsCount = writtenSubregionsCount.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "EncodeErrorFlags")]
        public ulong EncodeErrorFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS")]
        [NativeName("Name", "EncodeStats")]
        public VideoEncoderOutputMetadataStatistics EncodeStats;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "EncodedBitstreamWrittenBytesCount")]
        public ulong EncodedBitstreamWrittenBytesCount;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "WrittenSubregionsCount")]
        public ulong WrittenSubregionsCount;
    }
}
