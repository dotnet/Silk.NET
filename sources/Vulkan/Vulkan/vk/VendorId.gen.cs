// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVendorId")]
public enum VendorId : uint
{
    [NativeName("VK_VENDOR_ID_KHRONOS")]
    Khronos = 65536,

    [NativeName("VK_VENDOR_ID_VIV")]
    Viv = 65537,

    [NativeName("VK_VENDOR_ID_VSI")]
    Vsi = 65538,

    [NativeName("VK_VENDOR_ID_KAZAN")]
    Kazan = 65539,

    [NativeName("VK_VENDOR_ID_CODEPLAY")]
    Codeplay = 65540,

    [NativeName("VK_VENDOR_ID_MESA")]
    Mesa = 65541,

    [NativeName("VK_VENDOR_ID_POCL")]
    Pocl = 65542,

    [NativeName("VK_VENDOR_ID_MOBILEYE")]
    Mobileye = 65543,

    [NativeName("VK_VENDOR_ID_APE")]
    Ape = 65544,
}
