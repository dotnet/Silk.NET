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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC")]
    public unsafe partial struct VideoEncoderPictureControlCodecDataHevc
    {
        public VideoEncoderPictureControlCodecDataHevc
        (
            VideoEncoderPictureControlCodecDataHevcFlags? flags = null,
            VideoEncoderFrameTypeHevc? frameType = null,
            uint? slicePicParameterSetId = null,
            uint? pictureOrderCountNumber = null,
            uint? temporalLayerIndex = null,
            uint? list0ReferenceFramesCount = null,
            uint* pList0ReferenceFrames = null,
            uint? list1ReferenceFramesCount = null,
            uint* pList1ReferenceFrames = null,
            uint? referenceFramesReconPictureDescriptorsCount = null,
            VideoEncoderReferencePictureDescriptorHevc* pReferenceFramesReconPictureDescriptors = null,
            uint? list0RefPicModificationsCount = null,
            uint* pList0RefPicModifications = null,
            uint? list1RefPicModificationsCount = null,
            uint* pList1RefPicModifications = null,
            uint? qPMapValuesCount = null,
            byte* pRateControlQPMap = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (frameType is not null)
            {
                FrameType = frameType.Value;
            }

            if (slicePicParameterSetId is not null)
            {
                SlicePicParameterSetId = slicePicParameterSetId.Value;
            }

            if (pictureOrderCountNumber is not null)
            {
                PictureOrderCountNumber = pictureOrderCountNumber.Value;
            }

            if (temporalLayerIndex is not null)
            {
                TemporalLayerIndex = temporalLayerIndex.Value;
            }

            if (list0ReferenceFramesCount is not null)
            {
                List0ReferenceFramesCount = list0ReferenceFramesCount.Value;
            }

            if (pList0ReferenceFrames is not null)
            {
                PList0ReferenceFrames = pList0ReferenceFrames;
            }

            if (list1ReferenceFramesCount is not null)
            {
                List1ReferenceFramesCount = list1ReferenceFramesCount.Value;
            }

            if (pList1ReferenceFrames is not null)
            {
                PList1ReferenceFrames = pList1ReferenceFrames;
            }

            if (referenceFramesReconPictureDescriptorsCount is not null)
            {
                ReferenceFramesReconPictureDescriptorsCount = referenceFramesReconPictureDescriptorsCount.Value;
            }

            if (pReferenceFramesReconPictureDescriptors is not null)
            {
                PReferenceFramesReconPictureDescriptors = pReferenceFramesReconPictureDescriptors;
            }

            if (list0RefPicModificationsCount is not null)
            {
                List0RefPicModificationsCount = list0RefPicModificationsCount.Value;
            }

            if (pList0RefPicModifications is not null)
            {
                PList0RefPicModifications = pList0RefPicModifications;
            }

            if (list1RefPicModificationsCount is not null)
            {
                List1RefPicModificationsCount = list1RefPicModificationsCount.Value;
            }

            if (pList1RefPicModifications is not null)
            {
                PList1RefPicModifications = pList1RefPicModifications;
            }

            if (qPMapValuesCount is not null)
            {
                QPMapValuesCount = qPMapValuesCount.Value;
            }

            if (pRateControlQPMap is not null)
            {
                PRateControlQPMap = pRateControlQPMap;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderPictureControlCodecDataHevcFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC")]
        [NativeName("Name", "FrameType")]
        public VideoEncoderFrameTypeHevc FrameType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "slice_pic_parameter_set_id")]
        public uint SlicePicParameterSetId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PictureOrderCountNumber")]
        public uint PictureOrderCountNumber;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TemporalLayerIndex")]
        public uint TemporalLayerIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "List0ReferenceFramesCount")]
        public uint List0ReferenceFramesCount;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pList0ReferenceFrames")]
        public uint* PList0ReferenceFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "List1ReferenceFramesCount")]
        public uint List1ReferenceFramesCount;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pList1ReferenceFrames")]
        public uint* PList1ReferenceFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReferenceFramesReconPictureDescriptorsCount")]
        public uint ReferenceFramesReconPictureDescriptorsCount;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC *")]
        [NativeName("Name", "pReferenceFramesReconPictureDescriptors")]
        public VideoEncoderReferencePictureDescriptorHevc* PReferenceFramesReconPictureDescriptors;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "List0RefPicModificationsCount")]
        public uint List0RefPicModificationsCount;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pList0RefPicModifications")]
        public uint* PList0RefPicModifications;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "List1RefPicModificationsCount")]
        public uint List1RefPicModificationsCount;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pList1RefPicModifications")]
        public uint* PList1RefPicModifications;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "QPMapValuesCount")]
        public uint QPMapValuesCount;

        [NativeName("Type", "INT8 *")]
        [NativeName("Type.Name", "INT8 *")]
        [NativeName("Name", "pRateControlQPMap")]
        public byte* PRateControlQPMap;
    }
}
