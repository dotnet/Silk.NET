// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDriverId")]
public enum DriverId : uint
{
    [NativeName("VK_DRIVER_ID_AMD_PROPRIETARY")]
    AmdProprietary = 1,

    [NativeName("VK_DRIVER_ID_AMD_OPEN_SOURCE")]
    AmdOpenSource = 2,

    [NativeName("VK_DRIVER_ID_MESA_RADV")]
    MesaRadv = 3,

    [NativeName("VK_DRIVER_ID_NVIDIA_PROPRIETARY")]
    NvidiaProprietary = 4,

    [NativeName("VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS")]
    IntelProprietaryWindows = 5,

    [NativeName("VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA")]
    IntelOpenSourceMESA = 6,

    [NativeName("VK_DRIVER_ID_IMAGINATION_PROPRIETARY")]
    ImaginationProprietary = 7,

    [NativeName("VK_DRIVER_ID_QUALCOMM_PROPRIETARY")]
    QualcommProprietary = 8,

    [NativeName("VK_DRIVER_ID_ARM_PROPRIETARY")]
    ArmProprietary = 9,

    [NativeName("VK_DRIVER_ID_GOOGLE_SWIFTSHADER")]
    GoogleSwiftshader = 10,

    [NativeName("VK_DRIVER_ID_GGP_PROPRIETARY")]
    GgpProprietary = 11,

    [NativeName("VK_DRIVER_ID_BROADCOM_PROPRIETARY")]
    BroadcomProprietary = 12,

    [NativeName("VK_DRIVER_ID_MESA_LLVMPIPE")]
    MesaLlvmpipe = 13,

    [NativeName("VK_DRIVER_ID_MOLTENVK")]
    Moltenvk = 14,

    [NativeName("VK_DRIVER_ID_COREAVI_PROPRIETARY")]
    CoreaviProprietary = 15,

    [NativeName("VK_DRIVER_ID_JUICE_PROPRIETARY")]
    JuiceProprietary = 16,

    [NativeName("VK_DRIVER_ID_VERISILICON_PROPRIETARY")]
    VerisiliconProprietary = 17,

    [NativeName("VK_DRIVER_ID_MESA_TURNIP")]
    MesaTurnip = 18,

    [NativeName("VK_DRIVER_ID_MESA_V3DV")]
    MesaV3Dv = 19,

    [NativeName("VK_DRIVER_ID_MESA_PANVK")]
    MesaPanvk = 20,

    [NativeName("VK_DRIVER_ID_SAMSUNG_PROPRIETARY")]
    SamsungProprietary = 21,

    [NativeName("VK_DRIVER_ID_MESA_VENUS")]
    MesaVenus = 22,

    [NativeName("VK_DRIVER_ID_MESA_DOZEN")]
    MesaDozen = 23,

    [NativeName("VK_DRIVER_ID_MESA_NVK")]
    MesaNvk = 24,

    [NativeName("VK_DRIVER_ID_IMAGINATION_OPEN_SOURCE_MESA")]
    ImaginationOpenSourceMESA = 25,

    [NativeName("VK_DRIVER_ID_MESA_HONEYKRISP")]
    MesaHoneykrisp = 26,

    [NativeName("VK_DRIVER_ID_VULKAN_SC_EMULATION_ON_VULKAN")]
    VulkanScEmulationOnVulkan = 27,

    [NativeName("VK_DRIVER_ID_MESA_KOSMICKRISP")]
    MesaKosmickrisp = 28,

    [NativeName("VK_DRIVER_ID_MESA_GFXSTREAM")]
    MesaGfxstream = 29,

    [NativeName("VK_DRIVER_ID_APE_SOFT")]
    ApeSoft = 30,

    [NativeName("VK_DRIVER_ID_AMD_PROPRIETARY_KHR")]
    AmdProprietaryKHR = AmdProprietary,

    [NativeName("VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR")]
    AmdOpenSourceKHR = AmdOpenSource,

    [NativeName("VK_DRIVER_ID_MESA_RADV_KHR")]
    MesaRadvKHR = MesaRadv,

    [NativeName("VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR")]
    NvidiaProprietaryKHR = NvidiaProprietary,

    [NativeName("VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR")]
    IntelProprietaryWindowsKHR = IntelProprietaryWindows,

    [NativeName("VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR")]
    IntelOpenSourceMesaKHR = IntelOpenSourceMESA,

    [NativeName("VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR")]
    ImaginationProprietaryKHR = ImaginationProprietary,

    [NativeName("VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR")]
    QualcommProprietaryKHR = QualcommProprietary,

    [NativeName("VK_DRIVER_ID_ARM_PROPRIETARY_KHR")]
    ArmProprietaryKHR = ArmProprietary,

    [NativeName("VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR")]
    GoogleSwiftshaderKHR = GoogleSwiftshader,

    [NativeName("VK_DRIVER_ID_GGP_PROPRIETARY_KHR")]
    GgpProprietaryKHR = GgpProprietary,

    [NativeName("VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR")]
    BroadcomProprietaryKHR = BroadcomProprietary,
}
