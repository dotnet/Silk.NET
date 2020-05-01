// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.GOOGLE
{
    [Extension("VK_GOOGLE_display_timing")]
    public abstract unsafe partial class GoogleDisplayTiming : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_GOOGLE_display_timing";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        public abstract unsafe Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] PastPresentationTimingGOOGLE* pPresentationTimings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        public abstract Result GetPastPresentationTiming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pPresentationTimingCount, [Count(Computed = "pPresentationTimingCount"), Flow(FlowDirection.Out)] out PastPresentationTimingGOOGLE pPresentationTimings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
        public abstract unsafe Result GetRefreshCycleDuration([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.Out)] RefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
        public abstract Result GetRefreshCycleDuration([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.Out)] out RefreshCycleDurationGOOGLE pDisplayTimingProperties);

        public GoogleDisplayTiming(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

