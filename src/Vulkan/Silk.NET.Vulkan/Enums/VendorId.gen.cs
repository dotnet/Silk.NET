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
        [Obsolete("Deprecated in favour of \"Khronos\"")]
        [NativeName("Name", "VK_VENDOR_ID_KHRONOS")]
        VendorIDKhronos = 65536,
        [Obsolete("Deprecated in favour of \"Viv\"")]
        [NativeName("Name", "VK_VENDOR_ID_VIV")]
        VendorIDViv = 65537,
        [Obsolete("Deprecated in favour of \"Vsi\"")]
        [NativeName("Name", "VK_VENDOR_ID_VSI")]
        VendorIDVsi = 65538,
        [Obsolete("Deprecated in favour of \"Kazan\"")]
        [NativeName("Name", "VK_VENDOR_ID_KAZAN")]
        VendorIDKazan = 65539,
        [Obsolete("Deprecated in favour of \"Codeplay\"")]
        [NativeName("Name", "VK_VENDOR_ID_CODEPLAY")]
        VendorIDCodeplay = 65540,
        [Obsolete("Deprecated in favour of \"Mesa\"")]
        [NativeName("Name", "VK_VENDOR_ID_MESA")]
        VendorIDMesa = 65541,
        [Obsolete("Deprecated in favour of \"Pocl\"")]
        [NativeName("Name", "VK_VENDOR_ID_POCL")]
        VendorIDPocl = 65542,
        [Obsolete("Deprecated in favour of \"Mobileye\"")]
        [NativeName("Name", "VK_VENDOR_ID_MOBILEYE")]
        VendorIDMobileye = 65543,
        [NativeName("Name", "VK_VENDOR_ID_KHRONOS")]
        Khronos = 65536,
        [NativeName("Name", "VK_VENDOR_ID_VIV")]
        Viv = 65537,
        [NativeName("Name", "VK_VENDOR_ID_VSI")]
        Vsi = 65538,
        [NativeName("Name", "VK_VENDOR_ID_KAZAN")]
        Kazan = 65539,
        [NativeName("Name", "VK_VENDOR_ID_CODEPLAY")]
        Codeplay = 65540,
        [NativeName("Name", "VK_VENDOR_ID_MESA")]
        Mesa = 65541,
        [NativeName("Name", "VK_VENDOR_ID_POCL")]
        Pocl = 65542,
        [NativeName("Name", "VK_VENDOR_ID_MOBILEYE")]
        Mobileye = 65543,
    }
}
