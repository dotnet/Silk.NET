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
    [NativeName("Name", "VkDeviceQueueGlobalPriorityCreateInfoEXT")]
    [NativeName("AliasOf", "VkDeviceQueueGlobalPriorityCreateInfoKHR")]
    public unsafe partial struct DeviceQueueGlobalPriorityCreateInfoEXT : IExtendsChain<DeviceQueueCreateInfo>
    {
        public DeviceQueueGlobalPriorityCreateInfoEXT
        (
            StructureType? sType = StructureType.DeviceQueueGlobalPriorityCreateInfoKhr,
            void* pNext = null,
            QueueGlobalPriorityKHR? globalPriority = null
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

            if (globalPriority is not null)
            {
                GlobalPriority = globalPriority.Value;
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
        [NativeName("Type", "VkQueueGlobalPriorityKHR")]
        [NativeName("Type.Name", "VkQueueGlobalPriorityKHR")]
        [NativeName("Name", "globalPriority")]
        public QueueGlobalPriorityKHR GlobalPriority;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceQueueGlobalPriorityCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
