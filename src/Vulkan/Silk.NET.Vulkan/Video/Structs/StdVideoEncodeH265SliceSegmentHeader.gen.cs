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
            StdVideoEncodeH265SliceSegmentHeaderFlags? flags = null,
            StdVideoH265SliceType? sliceType = null,
            uint? sliceSegmentAddress = null,
            byte? collocatedRefIdx = null,
            byte? maxNumMergeCand = null,
            byte? sliceCbQpOffset = null,
            byte? sliceCrQpOffset = null,
            byte? sliceBetaOffsetDiv2 = null,
            byte? sliceTcOffsetDiv2 = null,
            byte? sliceActYQpOffset = null,
            byte? sliceActCbQpOffset = null,
            byte? sliceActCrQpOffset = null,
            byte? sliceQpDelta = null,
            ushort? reserved1 = null,
            StdVideoEncodeH265WeightTable* pWeightTable = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (sliceType is not null)
            {
                SliceType = sliceType.Value;
            }

            if (sliceSegmentAddress is not null)
            {
                SliceSegmentAddress = sliceSegmentAddress.Value;
            }

            if (collocatedRefIdx is not null)
            {
                CollocatedRefIdx = collocatedRefIdx.Value;
            }

            if (maxNumMergeCand is not null)
            {
                MaxNumMergeCand = maxNumMergeCand.Value;
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

            if (sliceQpDelta is not null)
            {
                SliceQpDelta = sliceQpDelta.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (pWeightTable is not null)
            {
                PWeightTable = pWeightTable;
            }
        }


        [NativeName("Type", "StdVideoEncodeH265SliceSegmentHeaderFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265SliceSegmentHeaderFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265SliceSegmentHeaderFlags Flags;

        [NativeName("Type", "StdVideoH265SliceType")]
        [NativeName("Type.Name", "StdVideoH265SliceType")]
        [NativeName("Name", "slice_type")]
        public StdVideoH265SliceType SliceType;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "slice_segment_address")]
        public uint SliceSegmentAddress;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "collocated_ref_idx")]
        public byte CollocatedRefIdx;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "MaxNumMergeCand")]
        public byte MaxNumMergeCand;

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

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_qp_delta")]
        public byte SliceQpDelta;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "reserved1")]
        public ushort Reserved1;

        [NativeName("Type", "const StdVideoEncodeH265WeightTable *")]
        [NativeName("Type.Name", "const StdVideoEncodeH265WeightTable *")]
        [NativeName("Name", "pWeightTable")]
        public StdVideoEncodeH265WeightTable* PWeightTable;
    }
}
