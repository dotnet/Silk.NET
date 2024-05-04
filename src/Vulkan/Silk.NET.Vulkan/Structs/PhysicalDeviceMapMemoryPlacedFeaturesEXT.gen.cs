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
    [NativeName("Name", "VkPhysicalDeviceMapMemoryPlacedFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceMapMemoryPlacedFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceMapMemoryPlacedFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceMapMemoryPlacedFeaturesExt,
            void* pNext = null,
            Bool32? memoryMapPlaced = null,
            Bool32? memoryMapRangePlaced = null,
            Bool32? memoryUnmapReserve = null
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

            if (memoryMapPlaced is not null)
            {
                MemoryMapPlaced = memoryMapPlaced.Value;
            }

            if (memoryMapRangePlaced is not null)
            {
                MemoryMapRangePlaced = memoryMapRangePlaced.Value;
            }

            if (memoryUnmapReserve is not null)
            {
                MemoryUnmapReserve = memoryUnmapReserve.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "memoryMapPlaced")]
        public Bool32 MemoryMapPlaced;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "memoryMapRangePlaced")]
        public Bool32 MemoryMapRangePlaced;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "memoryUnmapReserve")]
        public Bool32 MemoryUnmapReserve;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMapMemoryPlacedFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
