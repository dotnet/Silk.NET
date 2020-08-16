// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_display_swapchain")]
    public unsafe partial class KhrDisplaySwapchain : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_display_swapchain";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ref SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Computed = "swapchainCount"), Flow(FlowDirection.Out)] out SwapchainKHR pSwapchains);

        public KhrDisplaySwapchain(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

