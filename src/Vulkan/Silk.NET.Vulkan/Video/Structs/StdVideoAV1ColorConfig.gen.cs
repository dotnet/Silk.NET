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
    [NativeName("Name", "StdVideoAV1ColorConfig")]
    public unsafe partial struct StdVideoAV1ColorConfig
    {
        public StdVideoAV1ColorConfig
        (
            StdVideoAV1ColorConfigFlags? flags = null,
            byte? bitDepth = null,
            byte? subsamplingX = null,
            byte? subsamplingY = null,
            byte? reserved1 = null,
            StdVideoAV1ColorPrimaries? colorPrimaries = null,
            StdVideoAV1TransferCharacteristics? transferCharacteristics = null,
            StdVideoAV1MatrixCoefficients? matrixCoefficients = null,
            StdVideoAV1ChromaSamplePosition? chromaSamplePosition = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (bitDepth is not null)
            {
                BitDepth = bitDepth.Value;
            }

            if (subsamplingX is not null)
            {
                SubsamplingX = subsamplingX.Value;
            }

            if (subsamplingY is not null)
            {
                SubsamplingY = subsamplingY.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
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

            if (chromaSamplePosition is not null)
            {
                ChromaSamplePosition = chromaSamplePosition.Value;
            }
        }


        [NativeName("Type", "StdVideoAV1ColorConfigFlags")]
        [NativeName("Type.Name", "StdVideoAV1ColorConfigFlags")]
        [NativeName("Name", "flags")]
        public StdVideoAV1ColorConfigFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "BitDepth")]
        public byte BitDepth;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "subsampling_x")]
        public byte SubsamplingX;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "subsampling_y")]
        public byte SubsamplingY;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "StdVideoAV1ColorPrimaries")]
        [NativeName("Type.Name", "StdVideoAV1ColorPrimaries")]
        [NativeName("Name", "color_primaries")]
        public StdVideoAV1ColorPrimaries ColorPrimaries;

        [NativeName("Type", "StdVideoAV1TransferCharacteristics")]
        [NativeName("Type.Name", "StdVideoAV1TransferCharacteristics")]
        [NativeName("Name", "transfer_characteristics")]
        public StdVideoAV1TransferCharacteristics TransferCharacteristics;

        [NativeName("Type", "StdVideoAV1MatrixCoefficients")]
        [NativeName("Type.Name", "StdVideoAV1MatrixCoefficients")]
        [NativeName("Name", "matrix_coefficients")]
        public StdVideoAV1MatrixCoefficients MatrixCoefficients;

        [NativeName("Type", "StdVideoAV1ChromaSamplePosition")]
        [NativeName("Type.Name", "StdVideoAV1ChromaSamplePosition")]
        [NativeName("Name", "chroma_sample_position")]
        public StdVideoAV1ChromaSamplePosition ChromaSamplePosition;
    }
}
