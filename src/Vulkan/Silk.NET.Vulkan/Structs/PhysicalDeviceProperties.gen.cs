// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceProperties")]
    public unsafe partial struct PhysicalDeviceProperties
    {
        public PhysicalDeviceProperties
        (
            uint apiVersion = default,
            uint driverVersion = default,
            uint vendorID = default,
            uint deviceID = default,
            PhysicalDeviceType deviceType = default,
            PhysicalDeviceLimits limits = default,
            PhysicalDeviceSparseProperties sparseProperties = default
        )
        {
            ApiVersion = apiVersion;
            DriverVersion = driverVersion;
            VendorID = vendorID;
            DeviceID = deviceID;
            DeviceType = deviceType;
            Limits = limits;
            SparseProperties = sparseProperties;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "apiVersion")]
        public uint ApiVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "driverVersion")]
        public uint DriverVersion;
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
        [NativeName("Type", "VkPhysicalDeviceType")]
        [NativeName("Type.Name", "VkPhysicalDeviceType")]
        [NativeName("Name", "deviceType")]
        public PhysicalDeviceType DeviceType;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "deviceName")]
        public fixed byte DeviceName[256];
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pipelineCacheUUID")]
        public fixed byte PipelineCacheUuid[16];
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceLimits")]
        [NativeName("Type.Name", "VkPhysicalDeviceLimits")]
        [NativeName("Name", "limits")]
        public PhysicalDeviceLimits Limits;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceSparseProperties")]
        [NativeName("Type.Name", "VkPhysicalDeviceSparseProperties")]
        [NativeName("Name", "sparseProperties")]
        public PhysicalDeviceSparseProperties SparseProperties;
    }
}
