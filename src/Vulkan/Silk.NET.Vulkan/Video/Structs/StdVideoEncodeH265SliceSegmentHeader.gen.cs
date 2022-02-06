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
    [NativeName("Name", "StdVideoEncodeH265SliceSegmentHeader")]
    public unsafe partial struct StdVideoEncodeH265SliceSegmentHeader
    {
        public StdVideoEncodeH265SliceSegmentHeader
        (
            StdVideoH265SliceType? sliceType = null,
            byte? slicePicParameterSetId = null,
            byte? numShortTermRefPicSets = null,
            uint? sliceSegmentAddress = null,
            byte? shortTermRefPicSetIdx = null,
            byte? numLongTermSps = null,
            byte? numLongTermPics = null,
            byte? collocatedRefIdx = null,
            byte? numRefIdxL0ActiveMinus1 = null,
            byte? numRefIdxL1ActiveMinus1 = null,
            byte? lumaLog2WeightDenom = null,
            byte? deltaChromaLog2WeightDenom = null,
            byte? maxNumMergeCand = null,
            byte? sliceQpDelta = null,
            byte? sliceCbQpOffset = null,
            byte? sliceCrQpOffset = null,
            byte? sliceBetaOffsetDiv2 = null,
            byte? sliceTcOffsetDiv2 = null,
            byte? sliceActYQpOffset = null,
            byte? sliceActCbQpOffset = null,
            byte? sliceActCrQpOffset = null,
            StdVideoEncodeH265SliceSegmentHeaderFlags? flags = null
        ) : this()
        {
            if (sliceType is not null)
            {
                SliceType = sliceType.Value;
            }

            if (slicePicParameterSetId is not null)
            {
                SlicePicParameterSetId = slicePicParameterSetId.Value;
            }

            if (numShortTermRefPicSets is not null)
            {
                NumShortTermRefPicSets = numShortTermRefPicSets.Value;
            }

            if (sliceSegmentAddress is not null)
            {
                SliceSegmentAddress = sliceSegmentAddress.Value;
            }

            if (shortTermRefPicSetIdx is not null)
            {
                ShortTermRefPicSetIdx = shortTermRefPicSetIdx.Value;
            }

            if (numLongTermSps is not null)
            {
                NumLongTermSps = numLongTermSps.Value;
            }

            if (numLongTermPics is not null)
            {
                NumLongTermPics = numLongTermPics.Value;
            }

            if (collocatedRefIdx is not null)
            {
                CollocatedRefIdx = collocatedRefIdx.Value;
            }

            if (numRefIdxL0ActiveMinus1 is not null)
            {
                NumRefIdxL0ActiveMinus1 = numRefIdxL0ActiveMinus1.Value;
            }

            if (numRefIdxL1ActiveMinus1 is not null)
            {
                NumRefIdxL1ActiveMinus1 = numRefIdxL1ActiveMinus1.Value;
            }

            if (lumaLog2WeightDenom is not null)
            {
                LumaLog2WeightDenom = lumaLog2WeightDenom.Value;
            }

            if (deltaChromaLog2WeightDenom is not null)
            {
                DeltaChromaLog2WeightDenom = deltaChromaLog2WeightDenom.Value;
            }

            if (maxNumMergeCand is not null)
            {
                MaxNumMergeCand = maxNumMergeCand.Value;
            }

            if (sliceQpDelta is not null)
            {
                SliceQpDelta = sliceQpDelta.Value;
            }

            if (sliceCbQpOffset is not null)
            {
                SliceCbQpOffset = sliceCbQpOffset.Value;
            }

            if (sliceCrQpOffset is not null)
            {
                SliceCrQpOffset = sliceCrQpOffset.Value;
            }

            if (sliceBetaOffsetDiv2 is not null)
            {
                SliceBetaOffsetDiv2 = sliceBetaOffsetDiv2.Value;
            }

            if (sliceTcOffsetDiv2 is not null)
            {
                SliceTcOffsetDiv2 = sliceTcOffsetDiv2.Value;
            }

            if (sliceActYQpOffset is not null)
            {
                SliceActYQpOffset = sliceActYQpOffset.Value;
            }

            if (sliceActCbQpOffset is not null)
            {
                SliceActCbQpOffset = sliceActCbQpOffset.Value;
            }

            if (sliceActCrQpOffset is not null)
            {
                SliceActCrQpOffset = sliceActCrQpOffset.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "StdVideoH265SliceType")]
        [NativeName("Type.Name", "StdVideoH265SliceType")]
        [NativeName("Name", "slice_type")]
        public StdVideoH265SliceType SliceType;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "slice_pic_parameter_set_id")]
        public byte SlicePicParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_short_term_ref_pic_sets")]
        public byte NumShortTermRefPicSets;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "slice_segment_address")]
        public uint SliceSegmentAddress;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "short_term_ref_pic_set_idx")]
        public byte ShortTermRefPicSetIdx;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_long_term_sps")]
        public byte NumLongTermSps;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_long_term_pics")]
        public byte NumLongTermPics;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "collocated_ref_idx")]
        public byte CollocatedRefIdx;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l0_active_minus1")]
        public byte NumRefIdxL0ActiveMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l1_active_minus1")]
        public byte NumRefIdxL1ActiveMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "luma_log2_weight_denom")]
        public byte LumaLog2WeightDenom;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "delta_chroma_log2_weight_denom")]
        public byte DeltaChromaLog2WeightDenom;
        [NativeName("Type", "int8_t [15]")]
        [NativeName("Type.Name", "int8_t [15]")]
        [NativeName("Name", "delta_luma_weight_l0")]
        public fixed byte DeltaLumaWeightL0[15];
        [NativeName("Type", "int8_t [15]")]
        [NativeName("Type.Name", "int8_t [15]")]
        [NativeName("Name", "luma_offset_l0")]
        public fixed byte LumaOffsetL0[15];
        [NativeName("Type", "int8_t [15][2]")]
        [NativeName("Type.Name", "int8_t [15][2]")]
        [NativeName("Name", "delta_chroma_weight_l0")]
        public fixed byte DeltaChromaWeightL0[30];
        [NativeName("Type", "int8_t [15][2]")]
        [NativeName("Type.Name", "int8_t [15][2]")]
        [NativeName("Name", "delta_chroma_offset_l0")]
        public fixed byte DeltaChromaOffsetL0[30];
        [NativeName("Type", "int8_t [15]")]
        [NativeName("Type.Name", "int8_t [15]")]
        [NativeName("Name", "delta_luma_weight_l1")]
        public fixed byte DeltaLumaWeightL1[15];
        [NativeName("Type", "int8_t [15]")]
        [NativeName("Type.Name", "int8_t [15]")]
        [NativeName("Name", "luma_offset_l1")]
        public fixed byte LumaOffsetL1[15];
        [NativeName("Type", "int8_t [15][2]")]
        [NativeName("Type.Name", "int8_t [15][2]")]
        [NativeName("Name", "delta_chroma_weight_l1")]
        public fixed byte DeltaChromaWeightL1[30];
        [NativeName("Type", "int8_t [15][2]")]
        [NativeName("Type.Name", "int8_t [15][2]")]
        [NativeName("Name", "delta_chroma_offset_l1")]
        public fixed byte DeltaChromaOffsetL1[30];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "MaxNumMergeCand")]
        public byte MaxNumMergeCand;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_qp_delta")]
        public byte SliceQpDelta;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_cb_qp_offset")]
        public byte SliceCbQpOffset;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_cr_qp_offset")]
        public byte SliceCrQpOffset;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_beta_offset_div2")]
        public byte SliceBetaOffsetDiv2;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_tc_offset_div2")]
        public byte SliceTcOffsetDiv2;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_act_y_qp_offset")]
        public byte SliceActYQpOffset;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_act_cb_qp_offset")]
        public byte SliceActCbQpOffset;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_act_cr_qp_offset")]
        public byte SliceActCrQpOffset;

        [NativeName("Type", "StdVideoEncodeH265SliceSegmentHeaderFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265SliceSegmentHeaderFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265SliceSegmentHeaderFlags Flags;
    }
}
