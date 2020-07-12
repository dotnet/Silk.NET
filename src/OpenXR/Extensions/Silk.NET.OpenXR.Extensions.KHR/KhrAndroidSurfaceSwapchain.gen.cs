// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_android_surface_swapchain")]
    public abstract unsafe partial class KhrAndroidSurfaceSwapchain : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_android_surface_swapchain";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR")]
        public abstract unsafe Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] IntPtr* surface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR")]
        public abstract Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref SwapchainCreateInfo info, [Count(Count = 0)] ref Swapchain swapchain, [Count(Count = 0)] ref IntPtr surface);

        public KhrAndroidSurfaceSwapchain(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

