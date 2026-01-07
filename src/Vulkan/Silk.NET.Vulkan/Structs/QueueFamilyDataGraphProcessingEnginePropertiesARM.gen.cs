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
    [NativeName("Name", "VkQueueFamilyDataGraphProcessingEnginePropertiesARM")]
    public unsafe partial struct QueueFamilyDataGraphProcessingEnginePropertiesARM : IChainable
    {
        public QueueFamilyDataGraphProcessingEnginePropertiesARM
        (
            StructureType? sType = StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm,
            void* pNext = null,
            ExternalSemaphoreHandleTypeFlags? foreignSemaphoreHandleTypes = null,
            ExternalMemoryHandleTypeFlags? foreignMemoryHandleTypes = null
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

            if (foreignSemaphoreHandleTypes is not null)
            {
                ForeignSemaphoreHandleTypes = foreignSemaphoreHandleTypes.Value;
            }

            if (foreignMemoryHandleTypes is not null)
            {
                ForeignMemoryHandleTypes = foreignMemoryHandleTypes.Value;
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
        [NativeName("Type", "VkExternalSemaphoreHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalSemaphoreHandleTypeFlags")]
        [NativeName("Name", "foreignSemaphoreHandleTypes")]
        public ExternalSemaphoreHandleTypeFlags ForeignSemaphoreHandleTypes;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlags")]
        [NativeName("Name", "foreignMemoryHandleTypes")]
        public ExternalMemoryHandleTypeFlags ForeignMemoryHandleTypes;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueueFamilyDataGraphProcessingEnginePropertiesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
