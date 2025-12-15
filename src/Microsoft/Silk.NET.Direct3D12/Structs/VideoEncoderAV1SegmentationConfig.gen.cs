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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG")]
    public unsafe partial struct VideoEncoderAV1SegmentationConfig
    {
        public VideoEncoderAV1SegmentationConfig
        (
            ulong? updateMap = null,
            ulong? temporalUpdate = null,
            ulong? updateData = null,
            ulong? numSegments = null
        ) : this()
        {
            if (updateMap is not null)
            {
                UpdateMap = updateMap.Value;
            }

            if (temporalUpdate is not null)
            {
                TemporalUpdate = temporalUpdate.Value;
            }

            if (updateData is not null)
            {
                UpdateData = updateData.Value;
            }

            if (numSegments is not null)
            {
                NumSegments = numSegments.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "UpdateMap")]
        public ulong UpdateMap;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "TemporalUpdate")]
        public ulong TemporalUpdate;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "UpdateData")]
        public ulong UpdateData;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumSegments")]
        public ulong NumSegments;
        
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA[8]")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA[8]")]
        [NativeName("Name", "SegmentsData")]
        public SegmentsDataBuffer SegmentsData;

        public struct SegmentsDataBuffer
        {
            public VideoEncoderAV1SegmentData Element0;
            public VideoEncoderAV1SegmentData Element1;
            public VideoEncoderAV1SegmentData Element2;
            public VideoEncoderAV1SegmentData Element3;
            public VideoEncoderAV1SegmentData Element4;
            public VideoEncoderAV1SegmentData Element5;
            public VideoEncoderAV1SegmentData Element6;
            public VideoEncoderAV1SegmentData Element7;
            public ref VideoEncoderAV1SegmentData this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoEncoderAV1SegmentData* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoEncoderAV1SegmentData> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }

    }
}
