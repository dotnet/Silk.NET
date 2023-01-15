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
    [NativeName("Name", "VkMicromapCreateInfoEXT")]
    public unsafe partial struct MicromapCreateInfoEXT : IChainable
    {
        public MicromapCreateInfoEXT
        (
            StructureType? sType = StructureType.MicromapCreateInfoExt,
            void* pNext = null,
            MicromapCreateFlagsEXT? createFlags = null,
            Buffer? buffer = null,
            ulong? offset = null,
            ulong? size = null,
            MicromapTypeEXT? type = null,
            ulong? deviceAddress = null
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

            if (createFlags is not null)
            {
                CreateFlags = createFlags.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (deviceAddress is not null)
            {
                DeviceAddress = deviceAddress.Value;
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
        [NativeName("Type", "VkMicromapCreateFlagsEXT")]
        [NativeName("Type.Name", "VkMicromapCreateFlagsEXT")]
        [NativeName("Name", "createFlags")]
        public MicromapCreateFlagsEXT CreateFlags;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "buffer")]
        public Buffer Buffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "offset")]
        public ulong Offset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkMicromapTypeEXT")]
        [NativeName("Type.Name", "VkMicromapTypeEXT")]
        [NativeName("Name", "type")]
        public MicromapTypeEXT Type;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "deviceAddress")]
        public ulong DeviceAddress;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MicromapCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
