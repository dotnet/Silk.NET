// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVendorId")]
    public enum VendorId : int
    {
        [NativeName("Name", "VK_VENDOR_ID_VIV")]
        VendorIDViv = 65537,
        [NativeName("Name", "VK_VENDOR_ID_VSI")]
        VendorIDVsi = 65538,
        [NativeName("Name", "VK_VENDOR_ID_KAZAN")]
        VendorIDKazan = 65539,
        [NativeName("Name", "VK_VENDOR_ID_CODEPLAY")]
        VendorIDCodeplay = 65540,
        [NativeName("Name", "VK_VENDOR_ID_MESA")]
        VendorIDMesa = 65541,
        [NativeName("Name", "VK_VENDOR_ID_POCL")]
        VendorIDPocl = 65542,
    }
}
