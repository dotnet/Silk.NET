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
    [NativeName("Name", "StdVideoH265SpsVuiFlags")]
    public unsafe partial struct StdVideoH265SpsVuiFlags
    {
        public StdVideoH265SpsVuiFlags
        (
            uint? aspectRatioInfoPresentFlag = null,
            uint? overscanInfoPresentFlag = null,
            uint? overscanAppropriateFlag = null,
            uint? videoSignalTypePresentFlag = null,
            uint? videoFullRangeFlag = null,
            uint? colourDescriptionPresentFlag = null,
            uint? chromaLocInfoPresentFlag = null,
            uint? neutralChromaIndicationFlag = null,
            uint? fieldSeqFlag = null,
            uint? frameFieldInfoPresentFlag = null,
            uint? defaultDisplayWindowFlag = null,
            uint? vuiTimingInfoPresentFlag = null,
            uint? vuiPocProportionalToTimingFlag = null,
            uint? vuiHrdParametersPresentFlag = null,
            uint? bitstreamRestrictionFlag = null,
            uint? tilesFixedStructureFlag = null,
            uint? motionVectorsOverPicBoundariesFlag = null,
            uint? restrictedRefPicListsFlag = null
        ) : this()
        {
            if (aspectRatioInfoPresentFlag is not null)
            {
                AspectRatioInfoPresentFlag = aspectRatioInfoPresentFlag.Value;
            }

            if (overscanInfoPresentFlag is not null)
            {
                OverscanInfoPresentFlag = overscanInfoPresentFlag.Value;
            }

            if (overscanAppropriateFlag is not null)
            {
                OverscanAppropriateFlag = overscanAppropriateFlag.Value;
            }

            if (videoSignalTypePresentFlag is not null)
            {
                VideoSignalTypePresentFlag = videoSignalTypePresentFlag.Value;
            }

            if (videoFullRangeFlag is not null)
            {
                VideoFullRangeFlag = videoFullRangeFlag.Value;
            }

            if (colourDescriptionPresentFlag is not null)
            {
                ColourDescriptionPresentFlag = colourDescriptionPresentFlag.Value;
            }

            if (chromaLocInfoPresentFlag is not null)
            {
                ChromaLocInfoPresentFlag = chromaLocInfoPresentFlag.Value;
            }

            if (neutralChromaIndicationFlag is not null)
            {
                NeutralChromaIndicationFlag = neutralChromaIndicationFlag.Value;
            }

            if (fieldSeqFlag is not null)
            {
                FieldSeqFlag = fieldSeqFlag.Value;
            }

            if (frameFieldInfoPresentFlag is not null)
            {
                FrameFieldInfoPresentFlag = frameFieldInfoPresentFlag.Value;
            }

            if (defaultDisplayWindowFlag is not null)
            {
                DefaultDisplayWindowFlag = defaultDisplayWindowFlag.Value;
            }

            if (vuiTimingInfoPresentFlag is not null)
            {
                VuiTimingInfoPresentFlag = vuiTimingInfoPresentFlag.Value;
            }

            if (vuiPocProportionalToTimingFlag is not null)
            {
                VuiPocProportionalToTimingFlag = vuiPocProportionalToTimingFlag.Value;
            }

            if (vuiHrdParametersPresentFlag is not null)
            {
                VuiHrdParametersPresentFlag = vuiHrdParametersPresentFlag.Value;
            }

            if (bitstreamRestrictionFlag is not null)
            {
                BitstreamRestrictionFlag = bitstreamRestrictionFlag.Value;
            }

            if (tilesFixedStructureFlag is not null)
            {
                TilesFixedStructureFlag = tilesFixedStructureFlag.Value;
            }

            if (motionVectorsOverPicBoundariesFlag is not null)
            {
                MotionVectorsOverPicBoundariesFlag = motionVectorsOverPicBoundariesFlag.Value;
            }

            if (restrictedRefPicListsFlag is not null)
            {
                RestrictedRefPicListsFlag = restrictedRefPicListsFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "aspect_ratio_info_present_flag")]
        public uint AspectRatioInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "overscan_info_present_flag")]
        public uint OverscanInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "overscan_appropriate_flag")]
        public uint OverscanAppropriateFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "video_signal_type_present_flag")]
        public uint VideoSignalTypePresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "video_full_range_flag")]
        public uint VideoFullRangeFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colour_description_present_flag")]
        public uint ColourDescriptionPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "chroma_loc_info_present_flag")]
        public uint ChromaLocInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "neutral_chroma_indication_flag")]
        public uint NeutralChromaIndicationFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "field_seq_flag")]
        public uint FieldSeqFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_field_info_present_flag")]
        public uint FrameFieldInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "default_display_window_flag")]
        public uint DefaultDisplayWindowFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_timing_info_present_flag")]
        public uint VuiTimingInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_poc_proportional_to_timing_flag")]
        public uint VuiPocProportionalToTimingFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_hrd_parameters_present_flag")]
        public uint VuiHrdParametersPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bitstream_restriction_flag")]
        public uint BitstreamRestrictionFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "tiles_fixed_structure_flag")]
        public uint TilesFixedStructureFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "motion_vectors_over_pic_boundaries_flag")]
        public uint MotionVectorsOverPicBoundariesFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "restricted_ref_pic_lists_flag")]
        public uint RestrictedRefPicListsFlag;
    }
}
