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
    [NativeName("Name", "VkVideoEncodeSessionRgbConversionCreateInfoVALVE")]
    public unsafe partial struct VideoEncodeSessionRgbConversionCreateInfoVALVE : IExtendsChain<VideoSessionCreateInfoKHR>
    {
        public VideoEncodeSessionRgbConversionCreateInfoVALVE
        (
            StructureType? sType = StructureType.VideoEncodeSessionRgbConversionCreateInfoValve,
            void* pNext = null,
            VideoEncodeRgbModelConversionFlagsVALVE? rgbModel = null,
            VideoEncodeRgbRangeCompressionFlagsVALVE? rgbRange = null,
            VideoEncodeRgbChromaOffsetFlagsVALVE? xChromaOffset = null,
            VideoEncodeRgbChromaOffsetFlagsVALVE? yChromaOffset = null
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

            if (rgbModel is not null)
            {
                RgbModel = rgbModel.Value;
            }

            if (rgbRange is not null)
            {
                RgbRange = rgbRange.Value;
            }

            if (xChromaOffset is not null)
            {
                XChromaOffset = xChromaOffset.Value;
            }

            if (yChromaOffset is not null)
            {
                YChromaOffset = yChromaOffset.Value;
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
        [NativeName("Type", "VkVideoEncodeRgbModelConversionFlagBitsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbModelConversionFlagBitsVALVE")]
        [NativeName("Name", "rgbModel")]
        public VideoEncodeRgbModelConversionFlagsVALVE RgbModel;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRgbRangeCompressionFlagBitsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbRangeCompressionFlagBitsVALVE")]
        [NativeName("Name", "rgbRange")]
        public VideoEncodeRgbRangeCompressionFlagsVALVE RgbRange;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRgbChromaOffsetFlagBitsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbChromaOffsetFlagBitsVALVE")]
        [NativeName("Name", "xChromaOffset")]
        public VideoEncodeRgbChromaOffsetFlagsVALVE XChromaOffset;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRgbChromaOffsetFlagBitsVALVE")]
        [NativeName("Type.Name", "VkVideoEncodeRgbChromaOffsetFlagBitsVALVE")]
        [NativeName("Name", "yChromaOffset")]
        public VideoEncodeRgbChromaOffsetFlagsVALVE YChromaOffset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeSessionRgbConversionCreateInfoValve;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
