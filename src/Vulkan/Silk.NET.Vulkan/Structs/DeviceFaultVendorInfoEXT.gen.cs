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
    [NativeName("Name", "VkDeviceFaultVendorInfoEXT")]
    public unsafe partial struct DeviceFaultVendorInfoEXT
    {
        public DeviceFaultVendorInfoEXT
        (
            ulong? vendorFaultCode = null,
            ulong? vendorFaultData = null
        ) : this()
        {
            if (vendorFaultCode is not null)
            {
                VendorFaultCode = vendorFaultCode.Value;
            }

            if (vendorFaultData is not null)
            {
                VendorFaultData = vendorFaultData.Value;
            }
        }

        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "vendorFaultCode")]
        public ulong VendorFaultCode;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "vendorFaultData")]
        public ulong VendorFaultData;
    }
}
