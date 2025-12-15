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

namespace Silk.NET.Vulkan.Video
{
    public unsafe partial class VkVideo
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_AV1STD_H_")]
        public const int VulkanVideoCodecAV1StdH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_av1std")]
        public const int VulkanVideoCodecAv1std = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODECS_COMMON_H_")]
        public const int VulkanVideoCodecsCommonH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codecs_common")]
        public const int VulkanVideoCodecsCommon = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_NUM_REF_FRAMES")]
        public const uint StdVideoAV1NumRefFrames = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_REFS_PER_FRAME")]
        public const uint StdVideoAV1RefsPerFrame = unchecked((uint) 0x7);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_TOTAL_REFS_PER_FRAME")]
        public const uint StdVideoAV1TotalRefsPerFrame = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_TILE_COLS")]
        public const uint StdVideoAV1MaxTileCols = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_TILE_ROWS")]
        public const uint StdVideoAV1MaxTileRows = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_SEGMENTS")]
        public const uint StdVideoAV1MaxSegments = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_SEG_LVL_MAX")]
        public const uint StdVideoAV1SegLvlMax = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_PRIMARY_REF_NONE")]
        public const uint StdVideoAV1PrimaryRefNone = unchecked((uint) 0x7);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_SELECT_INTEGER_MV")]
        public const uint StdVideoAV1SelectIntegerMV = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_SELECT_SCREEN_CONTENT_TOOLS")]
        public const uint StdVideoAV1SelectScreenContentTools = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_SKIP_MODE_FRAMES")]
        public const uint StdVideoAV1SkipModeFrames = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_LOOP_FILTER_STRENGTHS")]
        public const uint StdVideoAV1MaxLoopFilterStrengths = unchecked((uint) 0x4);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_LOOP_FILTER_ADJUSTMENTS")]
        public const uint StdVideoAV1LoopFilterAdjustments = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS")]
        public const uint StdVideoAV1MaxCdefFilterStrengths = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_NUM_PLANES")]
        public const uint StdVideoAV1MaxNumPlanes = unchecked((uint) 0x3);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_GLOBAL_MOTION_PARAMS")]
        public const uint StdVideoAV1GlobalMotionParams = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_NUM_Y_POINTS")]
        public const uint StdVideoAV1MaxNumYPoints = unchecked((uint) 0xE);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_NUM_CB_POINTS")]
        public const uint StdVideoAV1MaxNumCBPoints = unchecked((uint) 0xA);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_NUM_CR_POINTS")]
        public const uint StdVideoAV1MaxNumCRPoints = unchecked((uint) 0xA);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_NUM_POS_LUMA")]
        public const uint StdVideoAV1MaxNumPosLuma = unchecked((uint) 0x18);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_AV1_MAX_NUM_POS_CHROMA")]
        public const uint StdVideoAV1MaxNumPosChroma = unchecked((uint) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_AV1STD_DECODE_H_")]
        public const int VulkanVideoCodecAV1StdDecodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_av1std_decode")]
        public const int VulkanVideoCodecAv1stdDecode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_AV1_DECODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecAV1DecodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_av1_decode");
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_AV1STD_ENCODE_H_")]
        public const int VulkanVideoCodecAV1StdEncodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_av1std_encode")]
        public const int VulkanVideoCodecAv1stdEncode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_AV1_ENCODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecAV1EncodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_av1_encode");
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H264STD_H_")]
        public const int VulkanVideoCodecH264StdH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h264std")]
        public const int VulkanVideoCodecH264std = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_CPB_CNT_LIST_SIZE")]
        public const uint StdVideoH264CpbCntListSize = unchecked((uint) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS")]
        public const uint StdVideoH264ScalingList4X4NumLists = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS")]
        public const uint StdVideoH264ScalingList4X4NumElements = unchecked((uint) 0x10);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS")]
        public const uint StdVideoH264ScalingList8X8NumLists = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS")]
        public const uint StdVideoH264ScalingList8X8NumElements = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_MAX_NUM_LIST_REF")]
        public const uint StdVideoH264MaxNumListRef = unchecked((uint) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_MAX_CHROMA_PLANES")]
        public const uint StdVideoH264MaxChromaPlanes = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H264_NO_REFERENCE_PICTURE")]
        public const uint StdVideoH264NoReferencePicture = unchecked((uint) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H264STD_DECODE_H_")]
        public const int VulkanVideoCodecH264StdDecodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h264std_decode")]
        public const int VulkanVideoCodecH264stdDecode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecH264DecodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_h264_decode");
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE")]
        public const uint StdVideoDecodeH264FieldOrderCountListSize = unchecked((uint) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H264STD_ENCODE_H_")]
        public const int VulkanVideoCodecH264StdEncodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h264std_encode")]
        public const int VulkanVideoCodecH264stdEncode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecH264EncodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_h264_encode");
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H265STD_H_")]
        public const int VulkanVideoCodecH265StdH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h265std")]
        public const int VulkanVideoCodecH265std = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_CPB_CNT_LIST_SIZE")]
        public const uint StdVideoH265CpbCntListSize = unchecked((uint) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SUBLAYERS_LIST_SIZE")]
        public const uint StdVideoH265SublayersListSize = unchecked((uint) 0x7);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS")]
        public const uint StdVideoH265ScalingList4X4NumLists = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS")]
        public const uint StdVideoH265ScalingList4X4NumElements = unchecked((uint) 0x10);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS")]
        public const uint StdVideoH265ScalingList8X8NumLists = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS")]
        public const uint StdVideoH265ScalingList8X8NumElements = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS")]
        public const uint StdVideoH265ScalingList16X16NumLists = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS")]
        public const uint StdVideoH265ScalingList16X16NumElements = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS")]
        public const uint StdVideoH265ScalingList32X32NumLists = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS")]
        public const uint StdVideoH265ScalingList32X32NumElements = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE")]
        public const uint StdVideoH265ChromaQPOffsetListSize = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE")]
        public const uint StdVideoH265ChromaQPOffsetTileColsListSize = unchecked((uint) 0x13);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE")]
        public const uint StdVideoH265ChromaQPOffsetTileRowsListSize = unchecked((uint) 0x15);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE")]
        public const uint StdVideoH265PredictorPaletteComponentsListSize = unchecked((uint) 0x3);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE")]
        public const uint StdVideoH265PredictorPaletteCompEntriesListSize = unchecked((uint) 0x80);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_NUM_LIST_REF")]
        public const uint StdVideoH265MaxNumListRef = unchecked((uint) 0xF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_CHROMA_PLANES")]
        public const uint StdVideoH265MaxChromaPlanes = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_SHORT_TERM_REF_PIC_SETS")]
        public const uint StdVideoH265MaxShortTermRefPicSets = unchecked((uint) 0x40);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_DPB_SIZE")]
        public const uint StdVideoH265MaxDpbSize = unchecked((uint) 0x10);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS")]
        public const uint StdVideoH265MaxLongTermRefPicsSps = unchecked((uint) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_LONG_TERM_PICS")]
        public const uint StdVideoH265MaxLongTermPics = unchecked((uint) 0x10);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_DELTA_POC")]
        public const uint StdVideoH265MaxDeltaPoc = unchecked((uint) 0x30);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_H265_NO_REFERENCE_PICTURE")]
        public const uint StdVideoH265NoReferencePicture = unchecked((uint) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H265STD_DECODE_H_")]
        public const int VulkanVideoCodecH265StdDecodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h265std_decode")]
        public const int VulkanVideoCodecH265stdDecode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_H265_DECODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecH265DecodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_h265_decode");
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE")]
        public const uint StdVideoDecodeH265RefPicSetListSize = unchecked((uint) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H265STD_ENCODE_H_")]
        public const int VulkanVideoCodecH265StdEncodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h265std_encode")]
        public const int VulkanVideoCodecH265stdEncode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecH265EncodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_h265_encode");
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_VP9STD_H_")]
        public const int VulkanVideoCodecVP9StdH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_vp9std")]
        public const int VulkanVideoCodecVp9std = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_NUM_REF_FRAMES")]
        public const uint StdVideoVP9NumRefFrames = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_REFS_PER_FRAME")]
        public const uint StdVideoVP9RefsPerFrame = unchecked((uint) 0x3);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_MAX_REF_FRAMES")]
        public const uint StdVideoVP9MaxRefFrames = unchecked((uint) 0x4);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_LOOP_FILTER_ADJUSTMENTS")]
        public const uint StdVideoVP9LoopFilterAdjustments = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_MAX_SEGMENTS")]
        public const uint StdVideoVP9MaxSegments = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_SEG_LVL_MAX")]
        public const uint StdVideoVP9SegLvlMax = unchecked((uint) 0x4);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_MAX_SEGMENTATION_TREE_PROBS")]
        public const uint StdVideoVP9MaxSegmentationTreeProbs = unchecked((uint) 0x7);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "STD_VIDEO_VP9_MAX_SEGMENTATION_PRED_PROB")]
        public const uint StdVideoVP9MaxSegmentationPredProb = unchecked((uint) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_VP9STD_DECODE_H_")]
        public const int VulkanVideoCodecVP9StdDecodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_vp9std_decode")]
        public const int VulkanVideoCodecVp9stdDecode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_VP9_DECODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecVP9DecodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_vp9_decode");

    }
}

