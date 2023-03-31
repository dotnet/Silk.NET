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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.GOOGLE
{
    [Extension("VK_GOOGLE_display_timing")]
    public unsafe partial class GoogleDisplayTiming : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_GOOGLE_display_timing";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pPresentationTimingCount, [Count(Parameter = "pPresentationTimingCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PastPresentationTimingGOOGLE* pPresentationTimings);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pPresentationTimingCount, [Count(Parameter = "pPresentationTimingCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PastPresentationTimingGOOGLE pPresentationTimings);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pPresentationTimingCount, [Count(Parameter = "pPresentationTimingCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PastPresentationTimingGOOGLE* pPresentationTimings);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE", Convention = CallingConvention.Winapi)]
        public partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pPresentationTimingCount, [Count(Parameter = "pPresentationTimingCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PastPresentationTimingGOOGLE pPresentationTimings);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRefreshCycleDurationGOOGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRefreshCycleDuration([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] RefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRefreshCycleDurationGOOGLE", Convention = CallingConvention.Winapi)]
        public partial Result GetRefreshCycleDuration([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out RefreshCycleDurationGOOGLE pDisplayTimingProperties);

        public GoogleDisplayTiming(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

