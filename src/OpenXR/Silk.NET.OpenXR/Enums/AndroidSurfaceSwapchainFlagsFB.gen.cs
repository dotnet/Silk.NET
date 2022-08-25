// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrAndroidSurfaceSwapchainFlagsFB")]
    public enum AndroidSurfaceSwapchainFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SynchronousBitFB\"")]
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_SYNCHRONOUS_BIT_FB")]
        AndroidSurfaceSwapchainSynchronousBitFB = 1,
        [Obsolete("Deprecated in favour of \"UseTimestampsBitFB\"")]
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_USE_TIMESTAMPS_BIT_FB")]
        AndroidSurfaceSwapchainUseTimestampsBitFB = 2,
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_SYNCHRONOUS_BIT_FB")]
        SynchronousBitFB = 1,
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_USE_TIMESTAMPS_BIT_FB")]
        UseTimestampsBitFB = 2,
    }
}
