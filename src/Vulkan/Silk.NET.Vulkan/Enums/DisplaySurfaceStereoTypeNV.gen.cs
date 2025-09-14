// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplaySurfaceStereoTypeNV")]
    public enum DisplaySurfaceStereoTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"NoneNV\"")]
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV")]
        DisplaySurfaceStereoTypeNoneNV = 0,
        [Obsolete("Deprecated in favour of \"OnboardDinNV\"")]
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV")]
        DisplaySurfaceStereoTypeOnboardDinNV = 1,
        [Obsolete("Deprecated in favour of \"Hdmi3DNV\"")]
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV")]
        DisplaySurfaceStereoTypeHdmi3DNV = 2,
        [Obsolete("Deprecated in favour of \"InbandDisplayportNV\"")]
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV")]
        DisplaySurfaceStereoTypeInbandDisplayportNV = 3,
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV")]
        NoneNV = 0,
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV")]
        OnboardDinNV = 1,
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV")]
        Hdmi3DNV = 2,
        [NativeName("Name", "VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV")]
        InbandDisplayportNV = 3,
    }
}
