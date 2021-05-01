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
    [NativeName("Name", "StdVideoH264SpsVuiFlags")]
    public unsafe partial struct StdVideoH264SpsVuiFlags
    {
        public StdVideoH264SpsVuiFlags
        (
            uint? aspectRatioInfoPresentFlag = null,
            uint? overscanInfoPresentFlag = null,
            uint? overscanAppropriateFlag = null,
            uint? videoSignalTypePresentFlag = null,
            uint? videoFullRangeFlag = null,
            uint? colorDescriptionPresentFlag = null,
            uint? chromaLocInfoPresentFlag = null,
            uint? timingInfoPresentFlag = null,
            uint? fixedFrameRateFlag = null,
            uint? bitstreamRestrictionFlag = null,
            uint? nalHrdParametersPresentFlag = null,
            uint? vclHrdParametersPresentFlag = null
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

            if (colorDescriptionPresentFlag is not null)
            {
                ColorDescriptionPresentFlag = colorDescriptionPresentFlag.Value;
            }

            if (chromaLocInfoPresentFlag is not null)
            {
                ChromaLocInfoPresentFlag = chromaLocInfoPresentFlag.Value;
            }

            if (timingInfoPresentFlag is not null)
            {
                TimingInfoPresentFlag = timingInfoPresentFlag.Value;
            }

            if (fixedFrameRateFlag is not null)
            {
                FixedFrameRateFlag = fixedFrameRateFlag.Value;
            }

            if (bitstreamRestrictionFlag is not null)
            {
                BitstreamRestrictionFlag = bitstreamRestrictionFlag.Value;
            }

            if (nalHrdParametersPresentFlag is not null)
            {
                NalHrdParametersPresentFlag = nalHrdParametersPresentFlag.Value;
            }

            if (vclHrdParametersPresentFlag is not null)
            {
                VclHrdParametersPresentFlag = vclHrdParametersPresentFlag.Value;
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
        [NativeName("Name", "color_description_present_flag")]
        public uint ColorDescriptionPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "chroma_loc_info_present_flag")]
        public uint ChromaLocInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "timing_info_present_flag")]
        public uint TimingInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "fixed_frame_rate_flag")]
        public uint FixedFrameRateFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bitstream_restriction_flag")]
        public uint BitstreamRestrictionFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "nal_hrd_parameters_present_flag")]
        public uint NalHrdParametersPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vcl_hrd_parameters_present_flag")]
        public uint VclHrdParametersPresentFlag;
    }
}
