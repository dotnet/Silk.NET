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
    [NativeName("Name", "VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM")]
    public unsafe partial struct PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM : IChainable
    {
        public PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM
        (
            StructureType? sType = StructureType.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoArm,
            void* pNext = null,
            uint? queueFamilyIndex = null,
            PhysicalDeviceDataGraphProcessingEngineTypeARM? engineType = null
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

            if (queueFamilyIndex is not null)
            {
                QueueFamilyIndex = queueFamilyIndex.Value;
            }

            if (engineType is not null)
            {
                EngineType = engineType.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndex")]
        public uint QueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceDataGraphProcessingEngineTypeARM")]
        [NativeName("Type.Name", "VkPhysicalDeviceDataGraphProcessingEngineTypeARM")]
        [NativeName("Name", "engineType")]
        public PhysicalDeviceDataGraphProcessingEngineTypeARM EngineType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
