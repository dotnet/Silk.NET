// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDriverIdKHR")]
    public enum DriverIdKHR : int
    {
        [NativeName("Name", "VK_DRIVER_ID_AMD_PROPRIETARY")]
        DriverIDAmdProprietary = 1,
        [NativeName("Name", "VK_DRIVER_ID_AMD_OPEN_SOURCE")]
        DriverIDAmdOpenSource = 2,
        [NativeName("Name", "VK_DRIVER_ID_MESA_RADV")]
        DriverIDMesaRadv = 3,
        [NativeName("Name", "VK_DRIVER_ID_NVIDIA_PROPRIETARY")]
        DriverIDNvidiaProprietary = 4,
        [NativeName("Name", "VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS")]
        DriverIDIntelProprietaryWindows = 5,
        [NativeName("Name", "VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA")]
        DriverIDIntelOpenSourceMesa = 6,
        [NativeName("Name", "VK_DRIVER_ID_IMAGINATION_PROPRIETARY")]
        DriverIDImaginationProprietary = 7,
        [NativeName("Name", "VK_DRIVER_ID_QUALCOMM_PROPRIETARY")]
        DriverIDQualcommProprietary = 8,
        [NativeName("Name", "VK_DRIVER_ID_ARM_PROPRIETARY")]
        DriverIDArmProprietary = 9,
        [NativeName("Name", "VK_DRIVER_ID_GOOGLE_SWIFTSHADER")]
        DriverIDGoogleSwiftshader = 10,
        [NativeName("Name", "VK_DRIVER_ID_GGP_PROPRIETARY")]
        DriverIDGgpProprietary = 11,
        [NativeName("Name", "VK_DRIVER_ID_BROADCOM_PROPRIETARY")]
        DriverIDBroadcomProprietary = 12,
        [NativeName("Name", "VK_DRIVER_ID_MESA_LLVMPIPE")]
        DriverIDMesaLlvmpipe = 13,
        [NativeName("Name", "VK_DRIVER_ID_MOLTENVK")]
        DriverIDMoltenvk = 14,
    }
}
