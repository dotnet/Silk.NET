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
    [NativeName("Name", "StdVideoEncodeH264SliceHeader")]
    public unsafe partial struct StdVideoEncodeH264SliceHeader
    {
        public StdVideoEncodeH264SliceHeader
        (
            StdVideoEncodeH264SliceHeaderFlags? flags = null,
            uint? firstMbInSlice = null,
            StdVideoH264SliceType? sliceType = null,
            byte? sliceAlphaC0OffsetDiv2 = null,
            byte? sliceBetaOffsetDiv2 = null,
            byte? sliceQpDelta = null,
            byte? reserved1 = null,
            StdVideoH264CabacInitIdc? cabacInitIdc = null,
            StdVideoH264DisableDeblockingFilterIdc? disableDeblockingFilterIdc = null,
            StdVideoEncodeH264WeightTable* pWeightTable = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (firstMbInSlice is not null)
            {
                FirstMbInSlice = firstMbInSlice.Value;
            }

            if (sliceType is not null)
            {
                SliceType = sliceType.Value;
            }

            if (sliceAlphaC0OffsetDiv2 is not null)
            {
                SliceAlphaC0OffsetDiv2 = sliceAlphaC0OffsetDiv2.Value;
            }

            if (sliceBetaOffsetDiv2 is not null)
            {
                SliceBetaOffsetDiv2 = sliceBetaOffsetDiv2.Value;
            }

            if (sliceQpDelta is not null)
            {
                SliceQpDelta = sliceQpDelta.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (cabacInitIdc is not null)
            {
                CabacInitIdc = cabacInitIdc.Value;
            }

            if (disableDeblockingFilterIdc is not null)
            {
                DisableDeblockingFilterIdc = disableDeblockingFilterIdc.Value;
            }

            if (pWeightTable is not null)
            {
                PWeightTable = pWeightTable;
            }
        }


        [NativeName("Type", "StdVideoEncodeH264SliceHeaderFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH264SliceHeaderFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH264SliceHeaderFlags Flags;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "first_mb_in_slice")]
        public uint FirstMbInSlice;

        [NativeName("Type", "StdVideoH264SliceType")]
        [NativeName("Type.Name", "StdVideoH264SliceType")]
        [NativeName("Name", "slice_type")]
        public StdVideoH264SliceType SliceType;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_alpha_c0_offset_div2")]
        public byte SliceAlphaC0OffsetDiv2;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_beta_offset_div2")]
        public byte SliceBetaOffsetDiv2;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slice_qp_delta")]
        public byte SliceQpDelta;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "StdVideoH264CabacInitIdc")]
        [NativeName("Type.Name", "StdVideoH264CabacInitIdc")]
        [NativeName("Name", "cabac_init_idc")]
        public StdVideoH264CabacInitIdc CabacInitIdc;

        [NativeName("Type", "StdVideoH264DisableDeblockingFilterIdc")]
        [NativeName("Type.Name", "StdVideoH264DisableDeblockingFilterIdc")]
        [NativeName("Name", "disable_deblocking_filter_idc")]
        public StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc;

        [NativeName("Type", "const StdVideoEncodeH264WeightTable *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264WeightTable *")]
        [NativeName("Name", "pWeightTable")]
        public StdVideoEncodeH264WeightTable* PWeightTable;
    }
}
