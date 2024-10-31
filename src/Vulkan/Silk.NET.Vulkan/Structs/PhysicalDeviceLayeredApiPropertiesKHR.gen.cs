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
    [NativeName("Name", "VkPhysicalDeviceLayeredApiPropertiesKHR")]
    public unsafe partial struct PhysicalDeviceLayeredApiPropertiesKHR : IChainStart
    {
        public PhysicalDeviceLayeredApiPropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceLayeredApiPropertiesKhr,
            void* pNext = null,
            uint? vendorID = null,
            uint? deviceID = null,
            PhysicalDeviceLayeredApiKHR? layeredApi = null
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

            if (vendorID is not null)
            {
                VendorID = vendorID.Value;
            }

            if (deviceID is not null)
            {
                DeviceID = deviceID.Value;
            }

            if (layeredApi is not null)
            {
                LayeredApi = layeredApi.Value;
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
        [NativeName("Name", "vendorID")]
        public uint VendorID;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceID")]
        public uint DeviceID;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceLayeredApiKHR")]
        [NativeName("Type.Name", "VkPhysicalDeviceLayeredApiKHR")]
        [NativeName("Name", "layeredAPI")]
        public PhysicalDeviceLayeredApiKHR LayeredApi;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "deviceName")]
        public fixed byte DeviceName[256];

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceLayeredApiPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref PhysicalDeviceLayeredApiPropertiesKHR Chain(
            out PhysicalDeviceLayeredApiPropertiesKHR capture)
        {
            capture = new PhysicalDeviceLayeredApiPropertiesKHR(StructureType.PhysicalDeviceLayeredApiPropertiesKhr);
            return ref capture;
        }
    }
}
