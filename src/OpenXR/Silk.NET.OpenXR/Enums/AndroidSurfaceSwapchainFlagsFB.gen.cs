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
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_SYNCHRONOUS_BIT_FB")]
        AndroidSurfaceSwapchainSynchronousBitFB = 1,
        [NativeName("Name", "XR_ANDROID_SURFACE_SWAPCHAIN_USE_TIMESTAMPS_BIT_FB")]
        AndroidSurfaceSwapchainUseTimestampsBitFB = 2,
    }
}
