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
    [NativeName("Name", "StdVideoH265SequenceParameterSetVui")]
    public unsafe partial struct StdVideoH265SequenceParameterSetVui
    {
        public StdVideoH265SequenceParameterSetVui
        (
            StdVideoH265SpsVuiFlags? flags = null,
            StdVideoH265AspectRatioIdc? aspectRatioIdc = null,
            ushort? sarWidth = null,
            ushort? sarHeight = null,
            byte? videoFormat = null,
            byte? colourPrimaries = null,
            byte? transferCharacteristics = null,
            byte? matrixCoeffs = null,
            byte? chromaSampleLocTypeTopField = null,
            byte? chromaSampleLocTypeBottomField = null,
            byte? reserved1 = null,
            byte? reserved2 = null,
            ushort? defDispWinLeftOffset = null,
            ushort? defDispWinRightOffset = null,
            ushort? defDispWinTopOffset = null,
            ushort? defDispWinBottomOffset = null,
            uint? vuiNumUnitsInTick = null,
            uint? vuiTimeScale = null,
            uint? vuiNumTicksPocDiffOneMinus1 = null,
            ushort? minSpatialSegmentationIdc = null,
            ushort? reserved3 = null,
            byte? maxBytesPerPicDenom = null,
            byte? maxBitsPerMinCuDenom = null,
            byte? log2MaxMvLengthHorizontal = null,
            byte? log2MaxMvLengthVertical = null,
            StdVideoH265HrdParameters* pHrdParameters = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (aspectRatioIdc is not null)
            {
                AspectRatioIdc = aspectRatioIdc.Value;
            }

            if (sarWidth is not null)
            {
                SarWidth = sarWidth.Value;
            }

            if (sarHeight is not null)
            {
                SarHeight = sarHeight.Value;
            }

            if (videoFormat is not null)
            {
                VideoFormat = videoFormat.Value;
            }

            if (colourPrimaries is not null)
            {
                ColourPrimaries = colourPrimaries.Value;
            }

            if (transferCharacteristics is not null)
            {
                TransferCharacteristics = transferCharacteristics.Value;
            }

            if (matrixCoeffs is not null)
            {
                MatrixCoeffs = matrixCoeffs.Value;
            }

            if (chromaSampleLocTypeTopField is not null)
            {
                ChromaSampleLocTypeTopField = chromaSampleLocTypeTopField.Value;
            }

            if (chromaSampleLocTypeBottomField is not null)
            {
                ChromaSampleLocTypeBottomField = chromaSampleLocTypeBottomField.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (defDispWinLeftOffset is not null)
            {
                DefDispWinLeftOffset = defDispWinLeftOffset.Value;
            }

            if (defDispWinRightOffset is not null)
            {
                DefDispWinRightOffset = defDispWinRightOffset.Value;
            }

            if (defDispWinTopOffset is not null)
            {
                DefDispWinTopOffset = defDispWinTopOffset.Value;
            }

            if (defDispWinBottomOffset is not null)
            {
                DefDispWinBottomOffset = defDispWinBottomOffset.Value;
            }

            if (vuiNumUnitsInTick is not null)
            {
                VuiNumUnitsInTick = vuiNumUnitsInTick.Value;
            }

            if (vuiTimeScale is not null)
            {
                VuiTimeScale = vuiTimeScale.Value;
            }

            if (vuiNumTicksPocDiffOneMinus1 is not null)
            {
                VuiNumTicksPocDiffOneMinus1 = vuiNumTicksPocDiffOneMinus1.Value;
            }

            if (minSpatialSegmentationIdc is not null)
            {
                MinSpatialSegmentationIdc = minSpatialSegmentationIdc.Value;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3.Value;
            }

            if (maxBytesPerPicDenom is not null)
            {
                MaxBytesPerPicDenom = maxBytesPerPicDenom.Value;
            }

            if (maxBitsPerMinCuDenom is not null)
            {
                MaxBitsPerMinCuDenom = maxBitsPerMinCuDenom.Value;
            }

            if (log2MaxMvLengthHorizontal is not null)
            {
                Log2MaxMvLengthHorizontal = log2MaxMvLengthHorizontal.Value;
            }

            if (log2MaxMvLengthVertical is not null)
            {
                Log2MaxMvLengthVertical = log2MaxMvLengthVertical.Value;
            }

            if (pHrdParameters is not null)
            {
                PHrdParameters = pHrdParameters;
            }
        }


        [NativeName("Type", "StdVideoH265SpsVuiFlags")]
        [NativeName("Type.Name", "StdVideoH265SpsVuiFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH265SpsVuiFlags Flags;

        [NativeName("Type", "StdVideoH265AspectRatioIdc")]
        [NativeName("Type.Name", "StdVideoH265AspectRatioIdc")]
        [NativeName("Name", "aspect_ratio_idc")]
        public StdVideoH265AspectRatioIdc AspectRatioIdc;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "sar_width")]
        public ushort SarWidth;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "sar_height")]
        public ushort SarHeight;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "video_format")]
        public byte VideoFormat;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "colour_primaries")]
        public byte ColourPrimaries;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "transfer_characteristics")]
        public byte TransferCharacteristics;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "matrix_coeffs")]
        public byte MatrixCoeffs;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "chroma_sample_loc_type_top_field")]
        public byte ChromaSampleLocTypeTopField;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "chroma_sample_loc_type_bottom_field")]
        public byte ChromaSampleLocTypeBottomField;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved2")]
        public byte Reserved2;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "def_disp_win_left_offset")]
        public ushort DefDispWinLeftOffset;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "def_disp_win_right_offset")]
        public ushort DefDispWinRightOffset;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "def_disp_win_top_offset")]
        public ushort DefDispWinTopOffset;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "def_disp_win_bottom_offset")]
        public ushort DefDispWinBottomOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_num_units_in_tick")]
        public uint VuiNumUnitsInTick;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_time_scale")]
        public uint VuiTimeScale;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_num_ticks_poc_diff_one_minus1")]
        public uint VuiNumTicksPocDiffOneMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "min_spatial_segmentation_idc")]
        public ushort MinSpatialSegmentationIdc;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "reserved3")]
        public ushort Reserved3;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_bytes_per_pic_denom")]
        public byte MaxBytesPerPicDenom;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_bits_per_min_cu_denom")]
        public byte MaxBitsPerMinCuDenom;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_max_mv_length_horizontal")]
        public byte Log2MaxMvLengthHorizontal;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_max_mv_length_vertical")]
        public byte Log2MaxMvLengthVertical;

        [NativeName("Type", "const StdVideoH265HrdParameters *")]
        [NativeName("Type.Name", "const StdVideoH265HrdParameters *")]
        [NativeName("Name", "pHrdParameters")]
        public StdVideoH265HrdParameters* PHrdParameters;
    }
}
