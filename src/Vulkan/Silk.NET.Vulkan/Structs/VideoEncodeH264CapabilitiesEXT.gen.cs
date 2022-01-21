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
    [NativeName("Name", "VkVideoEncodeH264CapabilitiesEXT")]
    public unsafe partial struct VideoEncodeH264CapabilitiesEXT : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeH264CapabilitiesEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264CapabilitiesExt,
            void* pNext = null,
            VideoEncodeH264CapabilityFlagsEXT? flags = null,
            VideoEncodeH264InputModeFlagsEXT? inputModeFlags = null,
            VideoEncodeH264OutputModeFlagsEXT? outputModeFlags = null,
            Extent2D? minPictureSizeInMbs = null,
            Extent2D? maxPictureSizeInMbs = null,
            Extent2D? inputImageDataAlignment = null,
            byte? maxNumL0ReferenceForP = null,
            byte? maxNumL0ReferenceForB = null,
            byte? maxNumL1Reference = null,
            byte? qualityLevelCount = null,
            ExtensionProperties? stdExtensionVersion = null
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

            if (inputModeFlags is not null)
            {
                InputModeFlags = inputModeFlags.Value;
            }

            if (outputModeFlags is not null)
            {
                OutputModeFlags = outputModeFlags.Value;
            }

            if (minPictureSizeInMbs is not null)
            {
                MinPictureSizeInMbs = minPictureSizeInMbs.Value;
            }

            if (maxPictureSizeInMbs is not null)
            {
                MaxPictureSizeInMbs = maxPictureSizeInMbs.Value;
            }

            if (inputImageDataAlignment is not null)
            {
                InputImageDataAlignment = inputImageDataAlignment.Value;
            }

            if (maxNumL0ReferenceForP is not null)
            {
                MaxNumL0ReferenceForP = maxNumL0ReferenceForP.Value;
            }

            if (maxNumL0ReferenceForB is not null)
            {
                MaxNumL0ReferenceForB = maxNumL0ReferenceForB.Value;
            }

            if (maxNumL1Reference is not null)
            {
                MaxNumL1Reference = maxNumL1Reference.Value;
            }

            if (qualityLevelCount is not null)
            {
                QualityLevelCount = qualityLevelCount.Value;
            }

            if (stdExtensionVersion is not null)
            {
                StdExtensionVersion = stdExtensionVersion.Value;
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
        [NativeName("Type", "VkVideoEncodeH264CapabilityFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264CapabilityFlagsEXT")]
        [NativeName("Name", "flags")]
        public VideoEncodeH264CapabilityFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264InputModeFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264InputModeFlagsEXT")]
        [NativeName("Name", "inputModeFlags")]
        public VideoEncodeH264InputModeFlagsEXT InputModeFlags;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264OutputModeFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264OutputModeFlagsEXT")]
        [NativeName("Name", "outputModeFlags")]
        public VideoEncodeH264OutputModeFlagsEXT OutputModeFlags;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minPictureSizeInMbs")]
        public Extent2D MinPictureSizeInMbs;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxPictureSizeInMbs")]
        public Extent2D MaxPictureSizeInMbs;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "inputImageDataAlignment")]
        public Extent2D InputImageDataAlignment;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "maxNumL0ReferenceForP")]
        public byte MaxNumL0ReferenceForP;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "maxNumL0ReferenceForB")]
        public byte MaxNumL0ReferenceForB;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "maxNumL1Reference")]
        public byte MaxNumL1Reference;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "qualityLevelCount")]
        public byte QualityLevelCount;
/// <summary></summary>
        [NativeName("Type", "VkExtensionProperties")]
        [NativeName("Type.Name", "VkExtensionProperties")]
        [NativeName("Name", "stdExtensionVersion")]
        public ExtensionProperties StdExtensionVersion;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264CapabilitiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
