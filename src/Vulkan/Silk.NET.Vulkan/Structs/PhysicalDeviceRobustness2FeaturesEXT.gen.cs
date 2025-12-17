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
    [NativeName("Name", "VkPhysicalDeviceRobustness2FeaturesEXT")]
    [NativeName("AliasOf", "VkPhysicalDeviceRobustness2FeaturesKHR")]
    public unsafe partial struct PhysicalDeviceRobustness2FeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceRobustness2FeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceRobustness2FeaturesKhr,
            void* pNext = null,
            Bool32? robustBufferAccess2 = null,
            Bool32? robustImageAccess2 = null,
            Bool32? nullDescriptor = null
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

            if (robustBufferAccess2 is not null)
            {
                RobustBufferAccess2 = robustBufferAccess2.Value;
            }

            if (robustImageAccess2 is not null)
            {
                RobustImageAccess2 = robustImageAccess2.Value;
            }

            if (nullDescriptor is not null)
            {
                NullDescriptor = nullDescriptor.Value;
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
        [NativeName("Name", "robustBufferAccess2")]
        public Bool32 RobustBufferAccess2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "robustImageAccess2")]
        public Bool32 RobustImageAccess2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nullDescriptor")]
        public Bool32 NullDescriptor;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceRobustness2FeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
