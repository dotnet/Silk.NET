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
    [NativeName("Name", "VkVideoFormatAV1QuantizationMapPropertiesKHR")]
    public unsafe partial struct VideoFormatAV1QuantizationMapPropertiesKHR : IExtendsChain<VideoFormatPropertiesKHR>
    {
        public VideoFormatAV1QuantizationMapPropertiesKHR
        (
            StructureType? sType = StructureType.VideoFormatAV1QuantizationMapPropertiesKhr,
            void* pNext = null,
            VideoEncodeAV1SuperblockSizeFlagsKHR? compatibleSuperblockSizes = null
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

            if (compatibleSuperblockSizes is not null)
            {
                CompatibleSuperblockSizes = compatibleSuperblockSizes.Value;
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
        [NativeName("Type", "VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
        [NativeName("Name", "compatibleSuperblockSizes")]
        public VideoEncodeAV1SuperblockSizeFlagsKHR CompatibleSuperblockSizes;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoFormatAV1QuantizationMapPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
