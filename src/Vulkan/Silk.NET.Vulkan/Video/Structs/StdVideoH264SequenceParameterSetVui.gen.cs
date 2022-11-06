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
    [NativeName("Name", "StdVideoH264SequenceParameterSetVui")]
    public unsafe partial struct StdVideoH264SequenceParameterSetVui
    {
        public StdVideoH264SequenceParameterSetVui
        (
            StdVideoH264SpsVuiFlags? flags = null,
            StdVideoH264AspectRatioIdc? aspectRatioIdc = null,
            ushort? sarWidth = null,
            ushort? sarHeight = null,
            byte? videoFormat = null,
            byte? colourPrimaries = null,
            byte? transferCharacteristics = null,
            byte? matrixCoefficients = null,
            uint? numUnitsInTick = null,
            uint? timeScale = null,
            byte? maxNumReorderFrames = null,
            byte? maxDecFrameBuffering = null,
            byte? chromaSampleLocTypeTopField = null,
            byte? chromaSampleLocTypeBottomField = null,
            uint? reserved1 = null,
            StdVideoH264HrdParameters* pHrdParameters = null
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

            if (matrixCoefficients is not null)
            {
                MatrixCoefficients = matrixCoefficients.Value;
            }

            if (numUnitsInTick is not null)
            {
                NumUnitsInTick = numUnitsInTick.Value;
            }

            if (timeScale is not null)
            {
                TimeScale = timeScale.Value;
            }

            if (maxNumReorderFrames is not null)
            {
                MaxNumReorderFrames = maxNumReorderFrames.Value;
            }

            if (maxDecFrameBuffering is not null)
            {
                MaxDecFrameBuffering = maxDecFrameBuffering.Value;
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

            if (pHrdParameters is not null)
            {
                PHrdParameters = pHrdParameters;
            }
        }


        [NativeName("Type", "StdVideoH264SpsVuiFlags")]
        [NativeName("Type.Name", "StdVideoH264SpsVuiFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH264SpsVuiFlags Flags;

        [NativeName("Type", "StdVideoH264AspectRatioIdc")]
        [NativeName("Type.Name", "StdVideoH264AspectRatioIdc")]
        [NativeName("Name", "aspect_ratio_idc")]
        public StdVideoH264AspectRatioIdc AspectRatioIdc;

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
        [NativeName("Name", "matrix_coefficients")]
        public byte MatrixCoefficients;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "num_units_in_tick")]
        public uint NumUnitsInTick;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "time_scale")]
        public uint TimeScale;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_num_reorder_frames")]
        public byte MaxNumReorderFrames;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_dec_frame_buffering")]
        public byte MaxDecFrameBuffering;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "chroma_sample_loc_type_top_field")]
        public byte ChromaSampleLocTypeTopField;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "chroma_sample_loc_type_bottom_field")]
        public byte ChromaSampleLocTypeBottomField;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "reserved1")]
        public uint Reserved1;

        [NativeName("Type", "const StdVideoH264HrdParameters *")]
        [NativeName("Type.Name", "const StdVideoH264HrdParameters *")]
        [NativeName("Name", "pHrdParameters")]
        public StdVideoH264HrdParameters* PHrdParameters;
    }
}
