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
    [NativeName("Name", "StdVideoH265SequenceParameterSet")]
    public unsafe partial struct StdVideoH265SequenceParameterSet
    {
        public StdVideoH265SequenceParameterSet
        (
            StdVideoH265SpsFlags? flags = null,
            StdVideoH265ChromaFormatIdc? chromaFormatIdc = null,
            uint? picWidthInLumaSamples = null,
            uint? picHeightInLumaSamples = null,
            byte? spsVideoParameterSetId = null,
            byte? spsMaxSubLayersMinus1 = null,
            byte? spsSeqParameterSetId = null,
            byte? bitDepthLumaMinus8 = null,
            byte? bitDepthChromaMinus8 = null,
            byte? log2MaxPicOrderCntLsbMinus4 = null,
            byte? log2MinLumaCodingBlockSizeMinus3 = null,
            byte? log2DiffMaxMinLumaCodingBlockSize = null,
            byte? log2MinLumaTransformBlockSizeMinus2 = null,
            byte? log2DiffMaxMinLumaTransformBlockSize = null,
            byte? maxTransformHierarchyDepthInter = null,
            byte? maxTransformHierarchyDepthIntra = null,
            byte? numShortTermRefPicSets = null,
            byte? numLongTermRefPicsSps = null,
            byte? pcmSampleBitDepthLumaMinus1 = null,
            byte? pcmSampleBitDepthChromaMinus1 = null,
            byte? log2MinPcmLumaCodingBlockSizeMinus3 = null,
            byte? log2DiffMaxMinPcmLumaCodingBlockSize = null,
            byte? reserved1 = null,
            byte? reserved2 = null,
            byte? paletteMaxSize = null,
            byte? deltaPaletteMaxPredictorSize = null,
            byte? motionVectorResolutionControlIdc = null,
            byte? spsNumPalettePredictorInitializersMinus1 = null,
            uint? confWinLeftOffset = null,
            uint? confWinRightOffset = null,
            uint? confWinTopOffset = null,
            uint? confWinBottomOffset = null,
            StdVideoH265ProfileTierLevel* pProfileTierLevel = null,
            StdVideoH265DecPicBufMgr* pDecPicBufMgr = null,
            StdVideoH265ScalingLists* pScalingLists = null,
            StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet = null,
            StdVideoH265LongTermRefPicsSps* pLongTermRefPicsSps = null,
            StdVideoH265SequenceParameterSetVui* pSequenceParameterSetVui = null,
            StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (chromaFormatIdc is not null)
            {
                ChromaFormatIdc = chromaFormatIdc.Value;
            }

            if (picWidthInLumaSamples is not null)
            {
                PicWidthInLumaSamples = picWidthInLumaSamples.Value;
            }

            if (picHeightInLumaSamples is not null)
            {
                PicHeightInLumaSamples = picHeightInLumaSamples.Value;
            }

            if (spsVideoParameterSetId is not null)
            {
                SpsVideoParameterSetId = spsVideoParameterSetId.Value;
            }

            if (spsMaxSubLayersMinus1 is not null)
            {
                SpsMaxSubLayersMinus1 = spsMaxSubLayersMinus1.Value;
            }

            if (spsSeqParameterSetId is not null)
            {
                SpsSeqParameterSetId = spsSeqParameterSetId.Value;
            }

            if (bitDepthLumaMinus8 is not null)
            {
                BitDepthLumaMinus8 = bitDepthLumaMinus8.Value;
            }

            if (bitDepthChromaMinus8 is not null)
            {
                BitDepthChromaMinus8 = bitDepthChromaMinus8.Value;
            }

            if (log2MaxPicOrderCntLsbMinus4 is not null)
            {
                Log2MaxPicOrderCntLsbMinus4 = log2MaxPicOrderCntLsbMinus4.Value;
            }

            if (log2MinLumaCodingBlockSizeMinus3 is not null)
            {
                Log2MinLumaCodingBlockSizeMinus3 = log2MinLumaCodingBlockSizeMinus3.Value;
            }

            if (log2DiffMaxMinLumaCodingBlockSize is not null)
            {
                Log2DiffMaxMinLumaCodingBlockSize = log2DiffMaxMinLumaCodingBlockSize.Value;
            }

            if (log2MinLumaTransformBlockSizeMinus2 is not null)
            {
                Log2MinLumaTransformBlockSizeMinus2 = log2MinLumaTransformBlockSizeMinus2.Value;
            }

            if (log2DiffMaxMinLumaTransformBlockSize is not null)
            {
                Log2DiffMaxMinLumaTransformBlockSize = log2DiffMaxMinLumaTransformBlockSize.Value;
            }

            if (maxTransformHierarchyDepthInter is not null)
            {
                MaxTransformHierarchyDepthInter = maxTransformHierarchyDepthInter.Value;
            }

            if (maxTransformHierarchyDepthIntra is not null)
            {
                MaxTransformHierarchyDepthIntra = maxTransformHierarchyDepthIntra.Value;
            }

            if (numShortTermRefPicSets is not null)
            {
                NumShortTermRefPicSets = numShortTermRefPicSets.Value;
            }

            if (numLongTermRefPicsSps is not null)
            {
                NumLongTermRefPicsSps = numLongTermRefPicsSps.Value;
            }

            if (pcmSampleBitDepthLumaMinus1 is not null)
            {
                PcmSampleBitDepthLumaMinus1 = pcmSampleBitDepthLumaMinus1.Value;
            }

            if (pcmSampleBitDepthChromaMinus1 is not null)
            {
                PcmSampleBitDepthChromaMinus1 = pcmSampleBitDepthChromaMinus1.Value;
            }

            if (log2MinPcmLumaCodingBlockSizeMinus3 is not null)
            {
                Log2MinPcmLumaCodingBlockSizeMinus3 = log2MinPcmLumaCodingBlockSizeMinus3.Value;
            }

            if (log2DiffMaxMinPcmLumaCodingBlockSize is not null)
            {
                Log2DiffMaxMinPcmLumaCodingBlockSize = log2DiffMaxMinPcmLumaCodingBlockSize.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (paletteMaxSize is not null)
            {
                PaletteMaxSize = paletteMaxSize.Value;
            }

            if (deltaPaletteMaxPredictorSize is not null)
            {
                DeltaPaletteMaxPredictorSize = deltaPaletteMaxPredictorSize.Value;
            }

            if (motionVectorResolutionControlIdc is not null)
            {
                MotionVectorResolutionControlIdc = motionVectorResolutionControlIdc.Value;
            }

            if (spsNumPalettePredictorInitializersMinus1 is not null)
            {
                SpsNumPalettePredictorInitializersMinus1 = spsNumPalettePredictorInitializersMinus1.Value;
            }

            if (confWinLeftOffset is not null)
            {
                ConfWinLeftOffset = confWinLeftOffset.Value;
            }

            if (confWinRightOffset is not null)
            {
                ConfWinRightOffset = confWinRightOffset.Value;
            }

            if (confWinTopOffset is not null)
            {
                ConfWinTopOffset = confWinTopOffset.Value;
            }

            if (confWinBottomOffset is not null)
            {
                ConfWinBottomOffset = confWinBottomOffset.Value;
            }

            if (pProfileTierLevel is not null)
            {
                PProfileTierLevel = pProfileTierLevel;
            }

            if (pDecPicBufMgr is not null)
            {
                PDecPicBufMgr = pDecPicBufMgr;
            }

            if (pScalingLists is not null)
            {
                PScalingLists = pScalingLists;
            }

            if (pShortTermRefPicSet is not null)
            {
                PShortTermRefPicSet = pShortTermRefPicSet;
            }

            if (pLongTermRefPicsSps is not null)
            {
                PLongTermRefPicsSps = pLongTermRefPicsSps;
            }

            if (pSequenceParameterSetVui is not null)
            {
                PSequenceParameterSetVui = pSequenceParameterSetVui;
            }

            if (pPredictorPaletteEntries is not null)
            {
                PPredictorPaletteEntries = pPredictorPaletteEntries;
            }
        }


        [NativeName("Type", "StdVideoH265SpsFlags")]
        [NativeName("Type.Name", "StdVideoH265SpsFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH265SpsFlags Flags;

        [NativeName("Type", "StdVideoH265ChromaFormatIdc")]
        [NativeName("Type.Name", "StdVideoH265ChromaFormatIdc")]
        [NativeName("Name", "chroma_format_idc")]
        public StdVideoH265ChromaFormatIdc ChromaFormatIdc;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pic_width_in_luma_samples")]
        public uint PicWidthInLumaSamples;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pic_height_in_luma_samples")]
        public uint PicHeightInLumaSamples;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "sps_video_parameter_set_id")]
        public byte SpsVideoParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "sps_max_sub_layers_minus1")]
        public byte SpsMaxSubLayersMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "sps_seq_parameter_set_id")]
        public byte SpsSeqParameterSetId;

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
        [NativeName("Name", "log2_max_pic_order_cnt_lsb_minus4")]
        public byte Log2MaxPicOrderCntLsbMinus4;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_min_luma_coding_block_size_minus3")]
        public byte Log2MinLumaCodingBlockSizeMinus3;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_diff_max_min_luma_coding_block_size")]
        public byte Log2DiffMaxMinLumaCodingBlockSize;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_min_luma_transform_block_size_minus2")]
        public byte Log2MinLumaTransformBlockSizeMinus2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_diff_max_min_luma_transform_block_size")]
        public byte Log2DiffMaxMinLumaTransformBlockSize;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_transform_hierarchy_depth_inter")]
        public byte MaxTransformHierarchyDepthInter;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_transform_hierarchy_depth_intra")]
        public byte MaxTransformHierarchyDepthIntra;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_short_term_ref_pic_sets")]
        public byte NumShortTermRefPicSets;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_long_term_ref_pics_sps")]
        public byte NumLongTermRefPicsSps;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pcm_sample_bit_depth_luma_minus1")]
        public byte PcmSampleBitDepthLumaMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pcm_sample_bit_depth_chroma_minus1")]
        public byte PcmSampleBitDepthChromaMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_min_pcm_luma_coding_block_size_minus3")]
        public byte Log2MinPcmLumaCodingBlockSizeMinus3;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_diff_max_min_pcm_luma_coding_block_size")]
        public byte Log2DiffMaxMinPcmLumaCodingBlockSize;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved2")]
        public byte Reserved2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "palette_max_size")]
        public byte PaletteMaxSize;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "delta_palette_max_predictor_size")]
        public byte DeltaPaletteMaxPredictorSize;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "motion_vector_resolution_control_idc")]
        public byte MotionVectorResolutionControlIdc;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "sps_num_palette_predictor_initializers_minus1")]
        public byte SpsNumPalettePredictorInitializersMinus1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "conf_win_left_offset")]
        public uint ConfWinLeftOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "conf_win_right_offset")]
        public uint ConfWinRightOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "conf_win_top_offset")]
        public uint ConfWinTopOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "conf_win_bottom_offset")]
        public uint ConfWinBottomOffset;

        [NativeName("Type", "const StdVideoH265ProfileTierLevel *")]
        [NativeName("Type.Name", "const StdVideoH265ProfileTierLevel *")]
        [NativeName("Name", "pProfileTierLevel")]
        public StdVideoH265ProfileTierLevel* PProfileTierLevel;

        [NativeName("Type", "const StdVideoH265DecPicBufMgr *")]
        [NativeName("Type.Name", "const StdVideoH265DecPicBufMgr *")]
        [NativeName("Name", "pDecPicBufMgr")]
        public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

        [NativeName("Type", "const StdVideoH265ScalingLists *")]
        [NativeName("Type.Name", "const StdVideoH265ScalingLists *")]
        [NativeName("Name", "pScalingLists")]
        public StdVideoH265ScalingLists* PScalingLists;

        [NativeName("Type", "const StdVideoH265ShortTermRefPicSet *")]
        [NativeName("Type.Name", "const StdVideoH265ShortTermRefPicSet *")]
        [NativeName("Name", "pShortTermRefPicSet")]
        public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

        [NativeName("Type", "const StdVideoH265LongTermRefPicsSps *")]
        [NativeName("Type.Name", "const StdVideoH265LongTermRefPicsSps *")]
        [NativeName("Name", "pLongTermRefPicsSps")]
        public StdVideoH265LongTermRefPicsSps* PLongTermRefPicsSps;

        [NativeName("Type", "const StdVideoH265SequenceParameterSetVui *")]
        [NativeName("Type.Name", "const StdVideoH265SequenceParameterSetVui *")]
        [NativeName("Name", "pSequenceParameterSetVui")]
        public StdVideoH265SequenceParameterSetVui* PSequenceParameterSetVui;

        [NativeName("Type", "const StdVideoH265PredictorPaletteEntries *")]
        [NativeName("Type.Name", "const StdVideoH265PredictorPaletteEntries *")]
        [NativeName("Name", "pPredictorPaletteEntries")]
        public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
    }
}
