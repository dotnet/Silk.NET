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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA")]
    public unsafe partial struct VideoEncoderFrameSubregionMetadata
    {
        public VideoEncoderFrameSubregionMetadata
        (
            ulong? bSize = null,
            ulong? bStartOffset = null,
            ulong? bHeaderSize = null
        ) : this()
        {
            if (bSize is not null)
            {
                BSize = bSize.Value;
            }

            if (bStartOffset is not null)
            {
                BStartOffset = bStartOffset.Value;
            }

            if (bHeaderSize is not null)
            {
                BHeaderSize = bHeaderSize.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "bSize")]
        public ulong BSize;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "bStartOffset")]
        public ulong BStartOffset;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "bHeaderSize")]
        public ulong BHeaderSize;
    }
}
