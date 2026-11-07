// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplaySurfaceStereoTypeNV")]
public enum DisplaySurfaceStereoTypeNV : uint
{
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV")]
    None = 0,

    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV")]
    OnboardDin = 1,

    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV")]
    Hdmi3D = 2,

    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV")]
    InbandDisplayport = 3,
}
