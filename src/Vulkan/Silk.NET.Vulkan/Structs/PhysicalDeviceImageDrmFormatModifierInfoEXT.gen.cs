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
    [NativeName("Name", "VkPhysicalDeviceImageDrmFormatModifierInfoEXT")]
    public unsafe partial struct PhysicalDeviceImageDrmFormatModifierInfoEXT : IExtendsChain<PhysicalDeviceImageFormatInfo2>, IExtendsChain<PhysicalDeviceImageFormatInfo2KHR>
    {
        public PhysicalDeviceImageDrmFormatModifierInfoEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceImageDrmFormatModifierInfoExt,
            void* pNext = null,
            ulong? drmFormatModifier = null,
            SharingMode? sharingMode = null,
            uint? queueFamilyIndexCount = null,
            uint* pQueueFamilyIndices = null
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

            if (drmFormatModifier is not null)
            {
                DrmFormatModifier = drmFormatModifier.Value;
            }

            if (sharingMode is not null)
            {
                SharingMode = sharingMode.Value;
            }

            if (queueFamilyIndexCount is not null)
            {
                QueueFamilyIndexCount = queueFamilyIndexCount.Value;
            }

            if (pQueueFamilyIndices is not null)
            {
                PQueueFamilyIndices = pQueueFamilyIndices;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "drmFormatModifier")]
        public ulong DrmFormatModifier;
/// <summary></summary>
        [NativeName("Type", "VkSharingMode")]
        [NativeName("Type.Name", "VkSharingMode")]
        [NativeName("Name", "sharingMode")]
        public SharingMode SharingMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndexCount")]
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pQueueFamilyIndices")]
        public uint* PQueueFamilyIndices;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceImageDrmFormatModifierInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
