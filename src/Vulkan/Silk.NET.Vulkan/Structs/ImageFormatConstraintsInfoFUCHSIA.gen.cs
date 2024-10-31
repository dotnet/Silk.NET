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
    [NativeName("Name", "VkImageFormatConstraintsInfoFUCHSIA")]
    public unsafe partial struct ImageFormatConstraintsInfoFUCHSIA : IChainable
    {
        public ImageFormatConstraintsInfoFUCHSIA
        (
            StructureType? sType = StructureType.ImageFormatConstraintsInfoFuchsia,
            void* pNext = null,
            ImageCreateInfo? imageCreateInfo = null,
            FormatFeatureFlags? requiredFormatFeatures = null,
            ImageFormatConstraintsFlagsFUCHSIA? flags = null,
            ulong? sysmemPixelFormat = null,
            uint? colorSpaceCount = null,
            SysmemColorSpaceFUCHSIA* pColorSpaces = null
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

            if (imageCreateInfo is not null)
            {
                ImageCreateInfo = imageCreateInfo.Value;
            }

            if (requiredFormatFeatures is not null)
            {
                RequiredFormatFeatures = requiredFormatFeatures.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (sysmemPixelFormat is not null)
            {
                SysmemPixelFormat = sysmemPixelFormat.Value;
            }

            if (colorSpaceCount is not null)
            {
                ColorSpaceCount = colorSpaceCount.Value;
            }

            if (pColorSpaces is not null)
            {
                PColorSpaces = pColorSpaces;
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
        [NativeName("Type", "VkImageCreateInfo")]
        [NativeName("Type.Name", "VkImageCreateInfo")]
        [NativeName("Name", "imageCreateInfo")]
        public ImageCreateInfo ImageCreateInfo;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags")]
        [NativeName("Type.Name", "VkFormatFeatureFlags")]
        [NativeName("Name", "requiredFormatFeatures")]
        public FormatFeatureFlags RequiredFormatFeatures;
/// <summary></summary>
        [NativeName("Type", "VkImageFormatConstraintsFlagsFUCHSIA")]
        [NativeName("Type.Name", "VkImageFormatConstraintsFlagsFUCHSIA")]
        [NativeName("Name", "flags")]
        public ImageFormatConstraintsFlagsFUCHSIA Flags;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "sysmemPixelFormat")]
        public ulong SysmemPixelFormat;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorSpaceCount")]
        public uint ColorSpaceCount;
/// <summary></summary>
        [NativeName("Type", "VkSysmemColorSpaceFUCHSIA*")]
        [NativeName("Type.Name", "VkSysmemColorSpaceFUCHSIA")]
        [NativeName("Name", "pColorSpaces")]
        public SysmemColorSpaceFUCHSIA* PColorSpaces;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageFormatConstraintsInfoFuchsia;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
