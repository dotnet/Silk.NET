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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP")]
    public unsafe partial struct VideoEncoderAV1SegmentationMap
    {
        public VideoEncoderAV1SegmentationMap
        (
            uint? segmentsMapByteSize = null,
            byte* pSegmentsMap = null
        ) : this()
        {
            if (segmentsMapByteSize is not null)
            {
                SegmentsMapByteSize = segmentsMapByteSize.Value;
            }

            if (pSegmentsMap is not null)
            {
                PSegmentsMap = pSegmentsMap;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SegmentsMapByteSize")]
        public uint SegmentsMapByteSize;

        [NativeName("Type", "UINT8 *")]
        [NativeName("Type.Name", "UINT8 *")]
        [NativeName("Name", "pSegmentsMap")]
        public byte* PSegmentsMap;
    }
}
