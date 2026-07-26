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
    [NativeName("Name", "VkPhysicalDeviceRobustness2PropertiesKHR")]
    [NativeName("Aliases", "VkPhysicalDeviceRobustness2PropertiesEXT")]
    public unsafe partial struct PhysicalDeviceRobustness2PropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceRobustness2PropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceRobustness2PropertiesKhr,
            void* pNext = null,
            ulong? robustStorageBufferAccessSizeAlignment = null,
            ulong? robustUniformBufferAccessSizeAlignment = null
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

            if (robustStorageBufferAccessSizeAlignment is not null)
            {
                RobustStorageBufferAccessSizeAlignment = robustStorageBufferAccessSizeAlignment.Value;
            }

            if (robustUniformBufferAccessSizeAlignment is not null)
            {
                RobustUniformBufferAccessSizeAlignment = robustUniformBufferAccessSizeAlignment.Value;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "robustStorageBufferAccessSizeAlignment")]
        public ulong RobustStorageBufferAccessSizeAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "robustUniformBufferAccessSizeAlignment")]
        public ulong RobustUniformBufferAccessSizeAlignment;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceRobustness2PropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
