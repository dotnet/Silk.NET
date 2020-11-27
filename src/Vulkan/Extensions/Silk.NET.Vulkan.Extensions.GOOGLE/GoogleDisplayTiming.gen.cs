// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.GOOGLE
{
    [Extension("VK_GOOGLE_display_timing")]
    public unsafe partial class GoogleDisplayTiming : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_GOOGLE_display_timing";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] PastPresentationTimingGOOGLE* pPresentationTimings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] out PastPresentationTimingGOOGLE pPresentationTimings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        public unsafe partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] PastPresentationTimingGOOGLE* pPresentationTimings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        public partial Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] out PastPresentationTimingGOOGLE pPresentationTimings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
        public unsafe partial Result GetRefreshCycleDuration([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.Out)] RefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
        public partial Result GetRefreshCycleDuration([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.Out)] out RefreshCycleDurationGOOGLE pDisplayTimingProperties);

        public GoogleDisplayTiming(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

