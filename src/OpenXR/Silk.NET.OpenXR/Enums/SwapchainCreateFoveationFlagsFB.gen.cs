// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSwapchainCreateFoveationFlagsFB")]
    public enum SwapchainCreateFoveationFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ScaledBinBitFB\"")]
        [NativeName("Name", "XR_SWAPCHAIN_CREATE_FOVEATION_SCALED_BIN_BIT_FB")]
        SwapchainCreateFoveationScaledBinBitFB = 1,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapBitFB\"")]
        [NativeName("Name", "XR_SWAPCHAIN_CREATE_FOVEATION_FRAGMENT_DENSITY_MAP_BIT_FB")]
        SwapchainCreateFoveationFragmentDensityMapBitFB = 2,
        [NativeName("Name", "XR_SWAPCHAIN_CREATE_FOVEATION_SCALED_BIN_BIT_FB")]
        ScaledBinBitFB = 1,
        [NativeName("Name", "XR_SWAPCHAIN_CREATE_FOVEATION_FRAGMENT_DENSITY_MAP_BIT_FB")]
        FragmentDensityMapBitFB = 2,
    }
}
