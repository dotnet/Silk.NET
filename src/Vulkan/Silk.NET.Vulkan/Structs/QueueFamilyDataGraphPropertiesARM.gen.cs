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
    [NativeName("Name", "VkQueueFamilyDataGraphPropertiesARM")]
    public unsafe partial struct QueueFamilyDataGraphPropertiesARM : IChainable
    {
        public QueueFamilyDataGraphPropertiesARM
        (
            StructureType? sType = StructureType.QueueFamilyDataGraphPropertiesArm,
            void* pNext = null,
            PhysicalDeviceDataGraphProcessingEngineARM? engine = null,
            PhysicalDeviceDataGraphOperationSupportARM? operation = null
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

            if (engine is not null)
            {
                Engine = engine.Value;
            }

            if (operation is not null)
            {
                Operation = operation.Value;
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
        [NativeName("Type", "VkPhysicalDeviceDataGraphProcessingEngineARM")]
        [NativeName("Type.Name", "VkPhysicalDeviceDataGraphProcessingEngineARM")]
        [NativeName("Name", "engine")]
        public PhysicalDeviceDataGraphProcessingEngineARM Engine;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceDataGraphOperationSupportARM")]
        [NativeName("Type.Name", "VkPhysicalDeviceDataGraphOperationSupportARM")]
        [NativeName("Name", "operation")]
        public PhysicalDeviceDataGraphOperationSupportARM Operation;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueueFamilyDataGraphPropertiesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
