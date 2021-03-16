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
    [NativeName("Name", "VkPhysicalDeviceProperties")]
    public unsafe partial struct PhysicalDeviceProperties
    {
        public PhysicalDeviceProperties
        (
            uint? apiVersion = null,
            uint? driverVersion = null,
            uint? vendorID = null,
            uint? deviceID = null,
            PhysicalDeviceType? deviceType = null,
            PhysicalDeviceLimits? limits = null,
            PhysicalDeviceSparseProperties? sparseProperties = null
        ) : this()
        {
            if (apiVersion is not null)
            {
                ApiVersion = apiVersion.Value;
            }

            if (driverVersion is not null)
            {
                DriverVersion = driverVersion.Value;
            }

            if (vendorID is not null)
            {
                VendorID = vendorID.Value;
            }

            if (deviceID is not null)
            {
                DeviceID = deviceID.Value;
            }

            if (deviceType is not null)
            {
                DeviceType = deviceType.Value;
            }

            if (limits is not null)
            {
                Limits = limits.Value;
            }

            if (sparseProperties is not null)
            {
                SparseProperties = sparseProperties.Value;
            }
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
