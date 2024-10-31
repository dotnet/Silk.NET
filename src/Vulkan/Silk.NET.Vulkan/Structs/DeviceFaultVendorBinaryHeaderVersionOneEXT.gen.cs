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
    [NativeName("Name", "VkDeviceFaultVendorBinaryHeaderVersionOneEXT")]
    public unsafe partial struct DeviceFaultVendorBinaryHeaderVersionOneEXT
    {
        public DeviceFaultVendorBinaryHeaderVersionOneEXT
        (
            uint? headerSize = null,
            DeviceFaultVendorBinaryHeaderVersionEXT? headerVersion = null,
            uint? vendorID = null,
            uint? deviceID = null,
            uint? driverVersion = null,
            uint? applicationNameOffset = null,
            uint? applicationVersion = null,
            uint? engineNameOffset = null,
            uint? engineVersion = null,
            uint? apiVersion = null
        ) : this()
        {
            if (headerSize is not null)
            {
                HeaderSize = headerSize.Value;
            }

            if (headerVersion is not null)
            {
                HeaderVersion = headerVersion.Value;
            }

            if (vendorID is not null)
            {
                VendorID = vendorID.Value;
            }

            if (deviceID is not null)
            {
                DeviceID = deviceID.Value;
            }

            if (driverVersion is not null)
            {
                DriverVersion = driverVersion.Value;
            }

            if (applicationNameOffset is not null)
            {
                ApplicationNameOffset = applicationNameOffset.Value;
            }

            if (applicationVersion is not null)
            {
                ApplicationVersion = applicationVersion.Value;
            }

            if (engineNameOffset is not null)
            {
                EngineNameOffset = engineNameOffset.Value;
            }

            if (engineVersion is not null)
            {
                EngineVersion = engineVersion.Value;
            }

            if (apiVersion is not null)
            {
                ApiVersion = apiVersion.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "headerSize")]
        public uint HeaderSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceFaultVendorBinaryHeaderVersionEXT")]
        [NativeName("Type.Name", "VkDeviceFaultVendorBinaryHeaderVersionEXT")]
        [NativeName("Name", "headerVersion")]
        public DeviceFaultVendorBinaryHeaderVersionEXT HeaderVersion;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "driverVersion")]
        public uint DriverVersion;
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pipelineCacheUUID")]
        public fixed byte PipelineCacheUuid[16];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "applicationNameOffset")]
        public uint ApplicationNameOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "applicationVersion")]
        public uint ApplicationVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "engineNameOffset")]
        public uint EngineNameOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "engineVersion")]
        public uint EngineVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "apiVersion")]
        public uint ApiVersion;
    }
}
