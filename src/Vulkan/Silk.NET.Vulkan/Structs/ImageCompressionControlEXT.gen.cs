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
    [NativeName("Name", "VkImageCompressionControlEXT")]
    public unsafe partial struct ImageCompressionControlEXT : IExtendsChain<ImageCreateInfo>, IExtendsChain<SwapchainCreateInfoKHR>, IExtendsChain<PhysicalDeviceImageFormatInfo2>, IExtendsChain<PhysicalDeviceImageFormatInfo2KHR>
    {
        public ImageCompressionControlEXT
        (
            StructureType? sType = StructureType.ImageCompressionControlExt,
            void* pNext = null,
            ImageCompressionFlagsEXT? flags = null,
            uint? compressionControlPlaneCount = null,
            ImageCompressionFixedRateFlagsEXT* pFixedRateFlags = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (compressionControlPlaneCount is not null)
            {
                CompressionControlPlaneCount = compressionControlPlaneCount.Value;
            }

            if (pFixedRateFlags is not null)
            {
                PFixedRateFlags = pFixedRateFlags;
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
        [NativeName("Name", "flags")]
        public ImageCompressionFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "compressionControlPlaneCount")]
        public uint CompressionControlPlaneCount;
/// <summary></summary>
        [NativeName("Type", "VkImageCompressionFixedRateFlagsEXT*")]
        [NativeName("Type.Name", "VkImageCompressionFixedRateFlagsEXT")]
        [NativeName("Name", "pFixedRateFlags")]
        public ImageCompressionFixedRateFlagsEXT* PFixedRateFlags;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageCompressionControlExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
