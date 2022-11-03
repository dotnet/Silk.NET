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
    [NativeName("Name", "VkDeviceQueueInfo2")]
    public unsafe partial struct DeviceQueueInfo2 : IChainable
    {
        public DeviceQueueInfo2
        (
            StructureType? sType = StructureType.DeviceQueueInfo2,
            void* pNext = null,
            DeviceQueueCreateFlags? flags = null,
            uint? queueFamilyIndex = null,
            uint? queueIndex = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (queueFamilyIndex is not null)
            {
                QueueFamilyIndex = queueFamilyIndex.Value;
            }

            if (queueIndex is not null)
            {
                QueueIndex = queueIndex.Value;
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
        [NativeName("Type", "VkDeviceQueueCreateFlags")]
        [NativeName("Type.Name", "VkDeviceQueueCreateFlags")]
        [NativeName("Name", "flags")]
        public DeviceQueueCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndex")]
        public uint QueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueIndex")]
        public uint QueueIndex;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceQueueInfo2;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
