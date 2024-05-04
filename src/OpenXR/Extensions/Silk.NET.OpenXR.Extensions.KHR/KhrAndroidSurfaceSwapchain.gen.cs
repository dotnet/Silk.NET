// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_android_surface_swapchain")]
    public unsafe partial class KhrAndroidSurfaceSwapchain : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_android_surface_swapchain";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] nint* surface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] ref nint surface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] ref Swapchain swapchain, [Count(Count = 0)] nint* surface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* info, [Count(Count = 0)] ref Swapchain swapchain, [Count(Count = 0)] ref nint surface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfo info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] nint* surface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfo info, [Count(Count = 0)] Swapchain* swapchain, [Count(Count = 0)] ref nint surface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfo info, [Count(Count = 0)] ref Swapchain swapchain, [Count(Count = 0)] nint* surface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchainAndroidSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateSwapchainAndroidSurface([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfo info, [Count(Count = 0)] ref Swapchain swapchain, [Count(Count = 0)] ref nint surface);

        public KhrAndroidSurfaceSwapchain(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

