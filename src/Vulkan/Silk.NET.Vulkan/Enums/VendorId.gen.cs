// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
