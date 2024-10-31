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
    [NativeName("Name", "VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT")]
    public unsafe partial struct PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDevicePrimitiveTopologyListRestartFeaturesExt,
            void* pNext = null,
            Bool32? primitiveTopologyListRestart = null,
            Bool32? primitiveTopologyPatchListRestart = null
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

            if (primitiveTopologyListRestart is not null)
            {
                PrimitiveTopologyListRestart = primitiveTopologyListRestart.Value;
            }

            if (primitiveTopologyPatchListRestart is not null)
            {
                PrimitiveTopologyPatchListRestart = primitiveTopologyPatchListRestart.Value;
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
        [NativeName("Name", "primitiveTopologyListRestart")]
        public Bool32 PrimitiveTopologyListRestart;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitiveTopologyPatchListRestart")]
        public Bool32 PrimitiveTopologyPatchListRestart;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevicePrimitiveTopologyListRestartFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
