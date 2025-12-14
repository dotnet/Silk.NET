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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeRgbConversionCapabilitiesVALVE")]
    public unsafe partial struct VideoEncodeRgbConversionCapabilitiesVALVE : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeRgbConversionCapabilitiesVALVE
        (
            StructureType? sType = StructureType.VideoEncodeRgbConversionCapabilitiesValve,
            void* pNext = null,
            VideoEncodeRgbModelConversionFlagsVALVE? rgbModels = null,
            VideoEncodeRgbRangeCompressionFlagsVALVE? rgbRanges = null,
            VideoEncodeRgbChromaOffsetFlagsVALVE? xChromaOffsets = null,
            VideoEncodeRgbChromaOffsetFlagsVALVE? yChromaOffsets = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (rgbModels is not null)
            {
                RgbModels = rgbModels.Value;
            }

            if (rgbRanges is not null)
            {
                RgbRanges = rgbRanges.Value;
            }

            if (xChromaOffsets is not null)
            {
                XChromaOffsets = xChromaOffsets.Value;
            }

            if (yChromaOffsets is not null)
            {
                YChromaOffsets = yChromaOffsets.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRgbModelConversionFlagsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbModelConversionFlagsVALVE")]
        [NativeName("Name", "rgbModels")]
        public VideoEncodeRgbModelConversionFlagsVALVE RgbModels;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRgbRangeCompressionFlagsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbRangeCompressionFlagsVALVE")]
        [NativeName("Name", "rgbRanges")]
        public VideoEncodeRgbRangeCompressionFlagsVALVE RgbRanges;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
        [NativeName("Name", "xChromaOffsets")]
        public VideoEncodeRgbChromaOffsetFlagsVALVE XChromaOffsets;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
        [NativeName("Name", "yChromaOffsets")]
        public VideoEncodeRgbChromaOffsetFlagsVALVE YChromaOffsets;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeRgbConversionCapabilitiesValve;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
