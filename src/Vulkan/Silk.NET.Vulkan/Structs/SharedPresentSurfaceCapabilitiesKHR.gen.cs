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
    [NativeName("Name", "VkSharedPresentSurfaceCapabilitiesKHR")]
    public unsafe partial struct SharedPresentSurfaceCapabilitiesKHR : IExtendsChain<SurfaceCapabilities2KHR>
    {
        public SharedPresentSurfaceCapabilitiesKHR
        (
            StructureType? sType = StructureType.SharedPresentSurfaceCapabilitiesKhr,
            void* pNext = null,
            ImageUsageFlags? sharedPresentSupportedUsageFlags = null
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

            if (sharedPresentSupportedUsageFlags is not null)
            {
                SharedPresentSupportedUsageFlags = sharedPresentSupportedUsageFlags.Value;
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
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "sharedPresentSupportedUsageFlags")]
        public ImageUsageFlags SharedPresentSupportedUsageFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SharedPresentSurfaceCapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
