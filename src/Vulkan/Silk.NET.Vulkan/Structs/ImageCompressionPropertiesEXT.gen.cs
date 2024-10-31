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
    [NativeName("Name", "VkImageCompressionPropertiesEXT")]
    public unsafe partial struct ImageCompressionPropertiesEXT : IExtendsChain<ImageFormatProperties2>, IExtendsChain<ImageFormatProperties2KHR>, IExtendsChain<SurfaceFormat2KHR>, IExtendsChain<SubresourceLayout2KHR>, IExtendsChain<SubresourceLayout2EXT>
    {
        public ImageCompressionPropertiesEXT
        (
            StructureType? sType = StructureType.ImageCompressionPropertiesExt,
            void* pNext = null,
            ImageCompressionFlagsEXT? imageCompressionFlags = null,
            ImageCompressionFixedRateFlagsEXT? imageCompressionFixedRateFlags = null
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

            if (imageCompressionFlags is not null)
            {
                ImageCompressionFlags = imageCompressionFlags.Value;
            }

            if (imageCompressionFixedRateFlags is not null)
            {
                ImageCompressionFixedRateFlags = imageCompressionFixedRateFlags.Value;
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
        [NativeName("Type", "VkImageCompressionFlagsEXT")]
        [NativeName("Type.Name", "VkImageCompressionFlagsEXT")]
        [NativeName("Name", "imageCompressionFlags")]
        public ImageCompressionFlagsEXT ImageCompressionFlags;
/// <summary></summary>
        [NativeName("Type", "VkImageCompressionFixedRateFlagsEXT")]
        [NativeName("Type.Name", "VkImageCompressionFixedRateFlagsEXT")]
        [NativeName("Name", "imageCompressionFixedRateFlags")]
        public ImageCompressionFixedRateFlagsEXT ImageCompressionFixedRateFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageCompressionPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
