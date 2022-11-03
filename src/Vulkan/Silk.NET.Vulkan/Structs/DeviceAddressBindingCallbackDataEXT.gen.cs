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
    [NativeName("Name", "VkDeviceAddressBindingCallbackDataEXT")]
    public unsafe partial struct DeviceAddressBindingCallbackDataEXT : IExtendsChain<DebugUtilsMessengerCallbackDataEXT>
    {
        public DeviceAddressBindingCallbackDataEXT
        (
            StructureType? sType = StructureType.DeviceAddressBindingCallbackDataExt,
            void* pNext = null,
            DeviceAddressBindingFlagsEXT? flags = null,
            ulong? baseAddress = null,
            ulong? size = null,
            DeviceAddressBindingTypeEXT? bindingType = null
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

            if (baseAddress is not null)
            {
                BaseAddress = baseAddress.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (bindingType is not null)
            {
                BindingType = bindingType.Value;
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
        [NativeName("Type", "VkDeviceAddressBindingFlagsEXT")]
        [NativeName("Type.Name", "VkDeviceAddressBindingFlagsEXT")]
        [NativeName("Name", "flags")]
        public DeviceAddressBindingFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "baseAddress")]
        public ulong BaseAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddressBindingTypeEXT")]
        [NativeName("Type.Name", "VkDeviceAddressBindingTypeEXT")]
        [NativeName("Name", "bindingType")]
        public DeviceAddressBindingTypeEXT BindingType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceAddressBindingCallbackDataExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
