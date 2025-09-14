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
    [NativeName("Name", "VkVideoFormatH265QuantizationMapPropertiesKHR")]
    public unsafe partial struct VideoFormatH265QuantizationMapPropertiesKHR : IExtendsChain<VideoFormatPropertiesKHR>
    {
        public VideoFormatH265QuantizationMapPropertiesKHR
        (
            StructureType? sType = StructureType.VideoFormatH265QuantizationMapPropertiesKhr,
            void* pNext = null,
            VideoEncodeH265CtbSizeFlagsKHR? compatibleCtbSizes = null
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

            if (compatibleCtbSizes is not null)
            {
                CompatibleCtbSizes = compatibleCtbSizes.Value;
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
        [NativeName("Type", "VkVideoEncodeH265CtbSizeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265CtbSizeFlagsKHR")]
        [NativeName("Name", "compatibleCtbSizes")]
        public VideoEncodeH265CtbSizeFlagsKHR CompatibleCtbSizes;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoFormatH265QuantizationMapPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
