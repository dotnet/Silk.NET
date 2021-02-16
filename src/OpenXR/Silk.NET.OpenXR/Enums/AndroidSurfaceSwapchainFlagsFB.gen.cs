// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrAndroidSurfaceSwapchainFlagsFB")]
    public enum AndroidSurfaceSwapchainFlagsFB : int
    {
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_SYNCHRONOUS_BIT_FB")]
        AndroidSurfaceSwapchainSynchronousBitFB = 1,
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_USE_TIMESTAMPS_BIT_FB")]
        AndroidSurfaceSwapchainUseTimestampsBitFB = 2,
    }
}
