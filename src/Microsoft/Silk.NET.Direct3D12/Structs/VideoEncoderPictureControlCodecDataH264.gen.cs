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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264")]
    public unsafe partial struct VideoEncoderPictureControlCodecDataH264
    {
        public VideoEncoderPictureControlCodecDataH264
        (
            VideoEncoderPictureControlCodecDataH264Flags? flags = null,
            VideoEncoderFrameTypeH264? frameType = null,
            uint? picParameterSetId = null,
            uint? idrPicId = null,
            uint? pictureOrderCountNumber = null,
            uint? frameDecodingOrderNumber = null,
            uint? temporalLayerIndex = null,
            uint? list0ReferenceFramesCount = null,
            uint* pList0ReferenceFrames = null,
            uint? list1ReferenceFramesCount = null,
            uint* pList1ReferenceFrames = null,
            uint? referenceFramesReconPictureDescriptorsCount = null,
            VideoEncoderReferencePictureDescriptorH264* pReferenceFramesReconPictureDescriptors = null,
            byte? adaptiveRefPicMarkingModeFlag = null,
            uint? refPicMarkingOperationsCommandsCount = null,
            VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation* pRefPicMarkingOperationsCommands = null,
            uint? list0RefPicModificationsCount = null,
            VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* pList0RefPicModifications = null,
            uint? list1RefPicModificationsCount = null,
            VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* pList1RefPicModifications = null,
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

            if (picParameterSetId is not null)
            {
                PicParameterSetId = picParameterSetId.Value;
            }

            if (idrPicId is not null)
            {
                IdrPicId = idrPicId.Value;
            }

            if (pictureOrderCountNumber is not null)
            {
                PictureOrderCountNumber = pictureOrderCountNumber.Value;
            }

            if (frameDecodingOrderNumber is not null)
            {
                FrameDecodingOrderNumber = frameDecodingOrderNumber.Value;
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

            if (adaptiveRefPicMarkingModeFlag is not null)
            {
                AdaptiveRefPicMarkingModeFlag = adaptiveRefPicMarkingModeFlag.Value;
            }

            if (refPicMarkingOperationsCommandsCount is not null)
            {
                RefPicMarkingOperationsCommandsCount = refPicMarkingOperationsCommandsCount.Value;
            }

            if (pRefPicMarkingOperationsCommands is not null)
            {
                PRefPicMarkingOperationsCommands = pRefPicMarkingOperationsCommands;
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


        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderPictureControlCodecDataH264Flags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_TYPE_H264")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_H264")]
        [NativeName("Name", "FrameType")]
        public VideoEncoderFrameTypeH264 FrameType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "pic_parameter_set_id")]
        public uint PicParameterSetId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "idr_pic_id")]
        public uint IdrPicId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PictureOrderCountNumber")]
        public uint PictureOrderCountNumber;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FrameDecodingOrderNumber")]
        public uint FrameDecodingOrderNumber;

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

        [NativeName("Type", "D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264 *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264 *")]
        [NativeName("Name", "pReferenceFramesReconPictureDescriptors")]
        public VideoEncoderReferencePictureDescriptorH264* PReferenceFramesReconPictureDescriptors;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "adaptive_ref_pic_marking_mode_flag")]
        public byte AdaptiveRefPicMarkingModeFlag;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RefPicMarkingOperationsCommandsCount")]
        public uint RefPicMarkingOperationsCommandsCount;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION *")]
        [NativeName("Name", "pRefPicMarkingOperationsCommands")]
        public VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation* PRefPicMarkingOperationsCommands;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "List0RefPicModificationsCount")]
        public uint List0RefPicModificationsCount;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION *")]
        [NativeName("Name", "pList0RefPicModifications")]
        public VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* PList0RefPicModifications;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "List1RefPicModificationsCount")]
        public uint List1RefPicModificationsCount;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION *")]
        [NativeName("Name", "pList1RefPicModifications")]
        public VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* PList1RefPicModifications;

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
