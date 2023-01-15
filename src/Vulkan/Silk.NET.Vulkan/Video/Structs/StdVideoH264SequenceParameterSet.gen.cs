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
    [NativeName("Name", "StdVideoH264SequenceParameterSet")]
    public unsafe partial struct StdVideoH264SequenceParameterSet
    {
        public StdVideoH264SequenceParameterSet
        (
            StdVideoH264SpsFlags? flags = null,
            StdVideoH264ProfileIdc? profileIdc = null,
            StdVideoH264LevelIdc? levelIdc = null,
            StdVideoH264ChromaFormatIdc? chromaFormatIdc = null,
            byte? seqParameterSetId = null,
            byte? bitDepthLumaMinus8 = null,
            byte? bitDepthChromaMinus8 = null,
            byte? log2MaxFrameNumMinus4 = null,
            StdVideoH264PocType? picOrderCntType = null,
            int? offsetForNonRefPic = null,
            int? offsetForTopToBottomField = null,
            byte? log2MaxPicOrderCntLsbMinus4 = null,
            byte? numRefFramesInPicOrderCntCycle = null,
            byte? maxNumRefFrames = null,
            byte? reserved1 = null,
            uint? picWidthInMbsMinus1 = null,
            uint? picHeightInMapUnitsMinus1 = null,
            uint? frameCropLeftOffset = null,
            uint? frameCropRightOffset = null,
            uint? frameCropTopOffset = null,
            uint? frameCropBottomOffset = null,
            uint? reserved2 = null,
            int* pOffsetForRefFrame = null,
            StdVideoH264ScalingLists* pScalingLists = null,
            StdVideoH264SequenceParameterSetVui* pSequenceParameterSetVui = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (profileIdc is not null)
            {
                ProfileIdc = profileIdc.Value;
            }

            if (levelIdc is not null)
            {
                LevelIdc = levelIdc.Value;
            }

            if (chromaFormatIdc is not null)
            {
                ChromaFormatIdc = chromaFormatIdc.Value;
            }

            if (seqParameterSetId is not null)
            {
                SeqParameterSetId = seqParameterSetId.Value;
            }

            if (bitDepthLumaMinus8 is not null)
            {
                BitDepthLumaMinus8 = bitDepthLumaMinus8.Value;
            }

            if (bitDepthChromaMinus8 is not null)
            {
                BitDepthChromaMinus8 = bitDepthChromaMinus8.Value;
            }

            if (log2MaxFrameNumMinus4 is not null)
            {
                Log2MaxFrameNumMinus4 = log2MaxFrameNumMinus4.Value;
            }

            if (picOrderCntType is not null)
            {
                PicOrderCntType = picOrderCntType.Value;
            }

            if (offsetForNonRefPic is not null)
            {
                OffsetForNonRefPic = offsetForNonRefPic.Value;
            }

            if (offsetForTopToBottomField is not null)
            {
                OffsetForTopToBottomField = offsetForTopToBottomField.Value;
            }

            if (log2MaxPicOrderCntLsbMinus4 is not null)
            {
                Log2MaxPicOrderCntLsbMinus4 = log2MaxPicOrderCntLsbMinus4.Value;
            }

            if (numRefFramesInPicOrderCntCycle is not null)
            {
                NumRefFramesInPicOrderCntCycle = numRefFramesInPicOrderCntCycle.Value;
            }

            if (maxNumRefFrames is not null)
            {
                MaxNumRefFrames = maxNumRefFrames.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (picWidthInMbsMinus1 is not null)
            {
                PicWidthInMbsMinus1 = picWidthInMbsMinus1.Value;
            }

            if (picHeightInMapUnitsMinus1 is not null)
            {
                PicHeightInMapUnitsMinus1 = picHeightInMapUnitsMinus1.Value;
            }

            if (frameCropLeftOffset is not null)
            {
                FrameCropLeftOffset = frameCropLeftOffset.Value;
            }

            if (frameCropRightOffset is not null)
            {
                FrameCropRightOffset = frameCropRightOffset.Value;
            }

            if (frameCropTopOffset is not null)
            {
                FrameCropTopOffset = frameCropTopOffset.Value;
            }

            if (frameCropBottomOffset is not null)
            {
                FrameCropBottomOffset = frameCropBottomOffset.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (pOffsetForRefFrame is not null)
            {
                POffsetForRefFrame = pOffsetForRefFrame;
            }

            if (pScalingLists is not null)
            {
                PScalingLists = pScalingLists;
            }

            if (pSequenceParameterSetVui is not null)
            {
                PSequenceParameterSetVui = pSequenceParameterSetVui;
            }
        }


        [NativeName("Type", "StdVideoH264SpsFlags")]
        [NativeName("Type.Name", "StdVideoH264SpsFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH264SpsFlags Flags;

        [NativeName("Type", "StdVideoH264ProfileIdc")]
        [NativeName("Type.Name", "StdVideoH264ProfileIdc")]
        [NativeName("Name", "profile_idc")]
        public StdVideoH264ProfileIdc ProfileIdc;

        [NativeName("Type", "StdVideoH264LevelIdc")]
        [NativeName("Type.Name", "StdVideoH264LevelIdc")]
        [NativeName("Name", "level_idc")]
        public StdVideoH264LevelIdc LevelIdc;

        [NativeName("Type", "StdVideoH264ChromaFormatIdc")]
        [NativeName("Type.Name", "StdVideoH264ChromaFormatIdc")]
        [NativeName("Name", "chroma_format_idc")]
        public StdVideoH264ChromaFormatIdc ChromaFormatIdc;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_parameter_set_id")]
        public byte SeqParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "bit_depth_luma_minus8")]
        public byte BitDepthLumaMinus8;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "bit_depth_chroma_minus8")]
        public byte BitDepthChromaMinus8;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_max_frame_num_minus4")]
        public byte Log2MaxFrameNumMinus4;

        [NativeName("Type", "StdVideoH264PocType")]
        [NativeName("Type.Name", "StdVideoH264PocType")]
        [NativeName("Name", "pic_order_cnt_type")]
        public StdVideoH264PocType PicOrderCntType;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "offset_for_non_ref_pic")]
        public int OffsetForNonRefPic;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "offset_for_top_to_bottom_field")]
        public int OffsetForTopToBottomField;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_max_pic_order_cnt_lsb_minus4")]
        public byte Log2MaxPicOrderCntLsbMinus4;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_frames_in_pic_order_cnt_cycle")]
        public byte NumRefFramesInPicOrderCntCycle;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_num_ref_frames")]
        public byte MaxNumRefFrames;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pic_width_in_mbs_minus1")]
        public uint PicWidthInMbsMinus1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pic_height_in_map_units_minus1")]
        public uint PicHeightInMapUnitsMinus1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_crop_left_offset")]
        public uint FrameCropLeftOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_crop_right_offset")]
        public uint FrameCropRightOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_crop_top_offset")]
        public uint FrameCropTopOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_crop_bottom_offset")]
        public uint FrameCropBottomOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "reserved2")]
        public uint Reserved2;

        [NativeName("Type", "const int32_t *")]
        [NativeName("Type.Name", "const int32_t *")]
        [NativeName("Name", "pOffsetForRefFrame")]
        public int* POffsetForRefFrame;

        [NativeName("Type", "const StdVideoH264ScalingLists *")]
        [NativeName("Type.Name", "const StdVideoH264ScalingLists *")]
        [NativeName("Name", "pScalingLists")]
        public StdVideoH264ScalingLists* PScalingLists;

        [NativeName("Type", "const StdVideoH264SequenceParameterSetVui *")]
        [NativeName("Type.Name", "const StdVideoH264SequenceParameterSetVui *")]
        [NativeName("Name", "pSequenceParameterSetVui")]
        public StdVideoH264SequenceParameterSetVui* PSequenceParameterSetVui;
    }
}
