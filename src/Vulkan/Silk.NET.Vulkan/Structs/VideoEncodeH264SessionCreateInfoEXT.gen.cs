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
    [NativeName("Name", "VkVideoEncodeH264SessionCreateInfoEXT")]
    public unsafe partial struct VideoEncodeH264SessionCreateInfoEXT : IExtendsChain<VideoSessionCreateInfoKHR>
    {
        public VideoEncodeH264SessionCreateInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264SessionCreateInfoExt,
            void* pNext = null,
            VideoEncodeH264CreateFlagsEXT? flags = null,
            Extent2D? maxPictureSizeInMbs = null,
            ExtensionProperties* pStdExtensionVersion = null
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

            if (maxPictureSizeInMbs is not null)
            {
                MaxPictureSizeInMbs = maxPictureSizeInMbs.Value;
            }

            if (pStdExtensionVersion is not null)
            {
                PStdExtensionVersion = pStdExtensionVersion;
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
        [NativeName("Type", "VkVideoEncodeH264CreateFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH264CreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public VideoEncodeH264CreateFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxPictureSizeInMbs")]
        public Extent2D MaxPictureSizeInMbs;
/// <summary></summary>
        [NativeName("Type", "VkExtensionProperties*")]
        [NativeName("Type.Name", "VkExtensionProperties")]
        [NativeName("Name", "pStdExtensionVersion")]
        public ExtensionProperties* PStdExtensionVersion;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264SessionCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
