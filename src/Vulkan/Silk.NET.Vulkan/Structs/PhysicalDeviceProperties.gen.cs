// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceProperties
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
        public uint ApiVersion;
/// <summary></summary>
        public uint DriverVersion;
/// <summary></summary>
        public uint VendorID;
/// <summary></summary>
        public uint DeviceID;
/// <summary></summary>
        public PhysicalDeviceType DeviceType;
        /// <summary></summary>
       public fixed byte DeviceName[256];
        /// <summary></summary>
       public fixed byte PipelineCacheUuid[16];
/// <summary></summary>
        public PhysicalDeviceLimits Limits;
/// <summary></summary>
        public PhysicalDeviceSparseProperties SparseProperties;
    }
}
