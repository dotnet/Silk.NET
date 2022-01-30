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
            StdVideoH264AspectRatioIdc? aspectRatioIdc = null,
            ushort? sarWidth = null,
            ushort? sarHeight = null,
            byte? videoFormat = null,
            byte? colorPrimaries = null,
            byte? transferCharacteristics = null,
            byte? matrixCoefficients = null,
            uint? numUnitsInTick = null,
            uint? timeScale = null,
            StdVideoH264HrdParameters* pHrdParameters = null,
            byte? maxNumReorderFrames = null,
            byte? maxDecFrameBuffering = null,
            StdVideoH264SpsVuiFlags? flags = null
        ) : this()
        {
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

            if (colorPrimaries is not null)
            {
                ColorPrimaries = colorPrimaries.Value;
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

            if (pHrdParameters is not null)
            {
                PHrdParameters = pHrdParameters;
            }

            if (maxNumReorderFrames is not null)
            {
                MaxNumReorderFrames = maxNumReorderFrames.Value;
            }

            if (maxDecFrameBuffering is not null)
            {
                MaxDecFrameBuffering = maxDecFrameBuffering.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


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
        [NativeName("Name", "color_primaries")]
        public byte ColorPrimaries;

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

        [NativeName("Type", "StdVideoH264HrdParameters *")]
        [NativeName("Type.Name", "StdVideoH264HrdParameters *")]
        [NativeName("Name", "pHrdParameters")]
        public StdVideoH264HrdParameters* PHrdParameters;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_num_reorder_frames")]
        public byte MaxNumReorderFrames;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "max_dec_frame_buffering")]
        public byte MaxDecFrameBuffering;

        [NativeName("Type", "StdVideoH264SpsVuiFlags")]
        [NativeName("Type.Name", "StdVideoH264SpsVuiFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH264SpsVuiFlags Flags;
    }
}
