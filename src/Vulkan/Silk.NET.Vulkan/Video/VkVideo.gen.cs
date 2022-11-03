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
        [NativeName("Name", "VULKAN_VIDEO_CODECS_COMMON_H_")]
        public const int VulkanVideoCodecsCommonH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codecs_common")]
        public const int VulkanVideoCodecsCommon = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H264STD_H_")]
        public const int VulkanVideoCodecH264StdH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h264std")]
        public const int VulkanVideoCodecH264std = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H264_CPB_CNT_LIST_SIZE")]
        public const int StdVideoH264CpbCntListSize = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS")]
        public const int StdVideoH264ScalingList4X4NumLists = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS")]
        public const int StdVideoH264ScalingList4X4NumElements = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS")]
        public const int StdVideoH264ScalingList8X8NumLists = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS")]
        public const int StdVideoH264ScalingList8X8NumElements = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H264_MAX_NUM_LIST_REF")]
        public const int StdVideoH264MaxNumListRef = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H264_MAX_CHROMA_PLANES")]
        public const int StdVideoH264MaxChromaPlanes = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H264STD_DECODE_H_")]
        public const int VulkanVideoCodecH264StdDecodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h264std_decode")]
        public const int VulkanVideoCodecH264stdDecode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE")]
        public const int StdVideoDecodeH264FieldOrderCountListSize = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_DECODE_H264_MVC_REF_LIST_SIZE")]
        public const int StdVideoDecodeH264MvcRefListSize = unchecked((int) 0xF);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecH264DecodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_h264_decode");
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
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SUBLAYERS_MINUS1_LIST_SIZE")]
        public const int StdVideoH265SublayersMinus1ListSize = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_CPB_CNT_LIST_SIZE")]
        public const int StdVideoH265CpbCntListSize = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS")]
        public const int StdVideoH265ScalingList4X4NumLists = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS")]
        public const int StdVideoH265ScalingList4X4NumElements = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS")]
        public const int StdVideoH265ScalingList8X8NumLists = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS")]
        public const int StdVideoH265ScalingList8X8NumElements = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS")]
        public const int StdVideoH265ScalingList16X16NumLists = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS")]
        public const int StdVideoH265ScalingList16X16NumElements = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS")]
        public const int StdVideoH265ScalingList32X32NumLists = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS")]
        public const int StdVideoH265ScalingList32X32NumElements = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE")]
        public const int StdVideoH265PredictorPaletteComponentsListSize = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE")]
        public const int StdVideoH265PredictorPaletteCompEntriesListSize = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE")]
        public const int StdVideoH265ChromaQPOffsetTileColsListSize = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE")]
        public const int StdVideoH265ChromaQPOffsetTileRowsListSize = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE")]
        public const int StdVideoH265ChromaQPOffsetListSize = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_NUM_LIST_REF")]
        public const int StdVideoH265MaxNumListRef = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_H265_MAX_CHROMA_PLANES")]
        public const int StdVideoH265MaxChromaPlanes = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H265STD_DECODE_H_")]
        public const int VulkanVideoCodecH265StdDecodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h265std_decode")]
        public const int VulkanVideoCodecH265stdDecode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE")]
        public const int StdVideoDecodeH265RefPicSetListSize = unchecked((int) 0x8);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_H265_DECODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecH265DecodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_h265_decode");
        [NativeName("Type", "int")]
        [NativeName("Name", "VULKAN_VIDEO_CODEC_H265STD_ENCODE_H_")]
        public const int VulkanVideoCodecH265StdEncodeH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "vulkan_video_codec_h265std_encode")]
        public const int VulkanVideoCodecH265stdEncode = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_EXTENSION_NAME")]
        public const string VKStdVulkanVideoCodecH265EncodeExtensionName = unchecked((string) "VK_STD_vulkan_video_codec_h265_encode");

    }
}

