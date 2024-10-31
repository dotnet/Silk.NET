// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDriverIdKHR")]
    public enum DriverIdKHR : int
    {
        [Obsolete("Deprecated in favour of \"AmdProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_AMD_PROPRIETARY")]
        DriverIDAmdProprietary = 1,
        [Obsolete("Deprecated in favour of \"AmdOpenSource\"")]
        [NativeName("Name", "VK_DRIVER_ID_AMD_OPEN_SOURCE")]
        DriverIDAmdOpenSource = 2,
        [Obsolete("Deprecated in favour of \"MesaRadv\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_RADV")]
        DriverIDMesaRadv = 3,
        [Obsolete("Deprecated in favour of \"NvidiaProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_NVIDIA_PROPRIETARY")]
        DriverIDNvidiaProprietary = 4,
        [Obsolete("Deprecated in favour of \"IntelProprietaryWindows\"")]
        [NativeName("Name", "VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS")]
        DriverIDIntelProprietaryWindows = 5,
        [Obsolete("Deprecated in favour of \"IntelOpenSourceMesa\"")]
        [NativeName("Name", "VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA")]
        DriverIDIntelOpenSourceMesa = 6,
        [Obsolete("Deprecated in favour of \"ImaginationProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_IMAGINATION_PROPRIETARY")]
        DriverIDImaginationProprietary = 7,
        [Obsolete("Deprecated in favour of \"QualcommProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_QUALCOMM_PROPRIETARY")]
        DriverIDQualcommProprietary = 8,
        [Obsolete("Deprecated in favour of \"ArmProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_ARM_PROPRIETARY")]
        DriverIDArmProprietary = 9,
        [Obsolete("Deprecated in favour of \"GoogleSwiftshader\"")]
        [NativeName("Name", "VK_DRIVER_ID_GOOGLE_SWIFTSHADER")]
        DriverIDGoogleSwiftshader = 10,
        [Obsolete("Deprecated in favour of \"GgpProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_GGP_PROPRIETARY")]
        DriverIDGgpProprietary = 11,
        [Obsolete("Deprecated in favour of \"BroadcomProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_BROADCOM_PROPRIETARY")]
        DriverIDBroadcomProprietary = 12,
        [Obsolete("Deprecated in favour of \"MesaLlvmpipe\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_LLVMPIPE")]
        DriverIDMesaLlvmpipe = 13,
        [Obsolete("Deprecated in favour of \"Moltenvk\"")]
        [NativeName("Name", "VK_DRIVER_ID_MOLTENVK")]
        DriverIDMoltenvk = 14,
        [Obsolete("Deprecated in favour of \"CoreaviProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_COREAVI_PROPRIETARY")]
        DriverIDCoreaviProprietary = 15,
        [Obsolete("Deprecated in favour of \"JuiceProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_JUICE_PROPRIETARY")]
        DriverIDJuiceProprietary = 16,
        [Obsolete("Deprecated in favour of \"VerisiliconProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_VERISILICON_PROPRIETARY")]
        DriverIDVerisiliconProprietary = 17,
        [Obsolete("Deprecated in favour of \"MesaTurnip\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_TURNIP")]
        DriverIDMesaTurnip = 18,
        [Obsolete("Deprecated in favour of \"MesaV3DV\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_V3DV")]
        DriverIDMesaV3DV = 19,
        [Obsolete("Deprecated in favour of \"MesaPanvk\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_PANVK")]
        DriverIDMesaPanvk = 20,
        [Obsolete("Deprecated in favour of \"SamsungProprietary\"")]
        [NativeName("Name", "VK_DRIVER_ID_SAMSUNG_PROPRIETARY")]
        DriverIDSamsungProprietary = 21,
        [Obsolete("Deprecated in favour of \"MesaVenus\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_VENUS")]
        DriverIDMesaVenus = 22,
        [Obsolete("Deprecated in favour of \"MesaDozen\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_DOZEN")]
        DriverIDMesaDozen = 23,
        [Obsolete("Deprecated in favour of \"MesaNvk\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_NVK")]
        DriverIDMesaNvk = 24,
        [Obsolete("Deprecated in favour of \"ImaginationOpenSourceMesa\"")]
        [NativeName("Name", "VK_DRIVER_ID_IMAGINATION_OPEN_SOURCE_MESA")]
        DriverIDImaginationOpenSourceMesa = 25,
        [Obsolete("Deprecated in favour of \"MesaHoneykrisp\"")]
        [NativeName("Name", "VK_DRIVER_ID_MESA_HONEYKRISP")]
        DriverIDMesaHoneykrisp = 26,
        [Obsolete("Deprecated in favour of \"Reserved27\"")]
        [NativeName("Name", "VK_DRIVER_ID_RESERVED_27")]
        DriverIDReserved27 = 27,
        [NativeName("Name", "VK_DRIVER_ID_AMD_PROPRIETARY")]
        AmdProprietary = 1,
        [NativeName("Name", "VK_DRIVER_ID_AMD_OPEN_SOURCE")]
        AmdOpenSource = 2,
        [NativeName("Name", "VK_DRIVER_ID_MESA_RADV")]
        MesaRadv = 3,
        [NativeName("Name", "VK_DRIVER_ID_NVIDIA_PROPRIETARY")]
        NvidiaProprietary = 4,
        [NativeName("Name", "VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS")]
        IntelProprietaryWindows = 5,
        [NativeName("Name", "VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA")]
        IntelOpenSourceMesa = 6,
        [NativeName("Name", "VK_DRIVER_ID_IMAGINATION_PROPRIETARY")]
        ImaginationProprietary = 7,
        [NativeName("Name", "VK_DRIVER_ID_QUALCOMM_PROPRIETARY")]
        QualcommProprietary = 8,
        [NativeName("Name", "VK_DRIVER_ID_ARM_PROPRIETARY")]
        ArmProprietary = 9,
        [NativeName("Name", "VK_DRIVER_ID_GOOGLE_SWIFTSHADER")]
        GoogleSwiftshader = 10,
        [NativeName("Name", "VK_DRIVER_ID_GGP_PROPRIETARY")]
        GgpProprietary = 11,
        [NativeName("Name", "VK_DRIVER_ID_BROADCOM_PROPRIETARY")]
        BroadcomProprietary = 12,
        [NativeName("Name", "VK_DRIVER_ID_MESA_LLVMPIPE")]
        MesaLlvmpipe = 13,
        [NativeName("Name", "VK_DRIVER_ID_MOLTENVK")]
        Moltenvk = 14,
        [NativeName("Name", "VK_DRIVER_ID_COREAVI_PROPRIETARY")]
        CoreaviProprietary = 15,
        [NativeName("Name", "VK_DRIVER_ID_JUICE_PROPRIETARY")]
        JuiceProprietary = 16,
        [NativeName("Name", "VK_DRIVER_ID_VERISILICON_PROPRIETARY")]
        VerisiliconProprietary = 17,
        [NativeName("Name", "VK_DRIVER_ID_MESA_TURNIP")]
        MesaTurnip = 18,
        [NativeName("Name", "VK_DRIVER_ID_MESA_V3DV")]
        MesaV3DV = 19,
        [NativeName("Name", "VK_DRIVER_ID_MESA_PANVK")]
        MesaPanvk = 20,
        [NativeName("Name", "VK_DRIVER_ID_SAMSUNG_PROPRIETARY")]
        SamsungProprietary = 21,
        [NativeName("Name", "VK_DRIVER_ID_MESA_VENUS")]
        MesaVenus = 22,
        [NativeName("Name", "VK_DRIVER_ID_MESA_DOZEN")]
        MesaDozen = 23,
        [NativeName("Name", "VK_DRIVER_ID_MESA_NVK")]
        MesaNvk = 24,
        [NativeName("Name", "VK_DRIVER_ID_IMAGINATION_OPEN_SOURCE_MESA")]
        ImaginationOpenSourceMesa = 25,
        [NativeName("Name", "VK_DRIVER_ID_MESA_HONEYKRISP")]
        MesaHoneykrisp = 26,
        [NativeName("Name", "VK_DRIVER_ID_RESERVED_27")]
        Reserved27 = 27,
    }
}
