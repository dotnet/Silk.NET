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
    [NativeName("Name", "VkDeviceFaultAddressInfoEXT")]
    public unsafe partial struct DeviceFaultAddressInfoEXT
    {
        public DeviceFaultAddressInfoEXT
        (
            DeviceFaultAddressTypeEXT? addressType = null,
            ulong? reportedAddress = null,
            ulong? addressPrecision = null
        ) : this()
        {
            if (addressType is not null)
            {
                AddressType = addressType.Value;
            }

            if (reportedAddress is not null)
            {
                ReportedAddress = reportedAddress.Value;
            }

            if (addressPrecision is not null)
            {
                AddressPrecision = addressPrecision.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceFaultAddressTypeEXT")]
        [NativeName("Type.Name", "VkDeviceFaultAddressTypeEXT")]
        [NativeName("Name", "addressType")]
        public DeviceFaultAddressTypeEXT AddressType;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "reportedAddress")]
        public ulong ReportedAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "addressPrecision")]
        public ulong AddressPrecision;
    }
}
