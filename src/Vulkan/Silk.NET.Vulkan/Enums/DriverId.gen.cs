// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDriverId")]
    public enum DriverId : int
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
        [NativeName("Name", "VK_DRIVER_ID_COREAVI_PROPRIETARY")]
        DriverIDCoreaviProprietary = 15,
        [NativeName("Name", "VK_DRIVER_ID_JUICE_PROPRIETARY")]
        DriverIDJuiceProprietary = 16,
        [NativeName("Name", "VK_DRIVER_ID_VERISILICON_PROPRIETARY")]
        DriverIDVerisiliconProprietary = 17,
        [NativeName("Name", "VK_DRIVER_ID_MESA_TURNIP")]
        DriverIDMesaTurnip = 18,
        [NativeName("Name", "VK_DRIVER_ID_MESA_V3DV")]
        DriverIDMesaV3DV = 19,
        [NativeName("Name", "VK_DRIVER_ID_MESA_PANVK")]
        DriverIDMesaPanvk = 20,
        [NativeName("Name", "VK_DRIVER_ID_SAMSUNG_PROPRIETARY")]
        DriverIDSamsungProprietary = 21,
    }
}
