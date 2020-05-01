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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_full_screen_exclusive")]
    public abstract unsafe partial class ExtFullScreenExclusive : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_full_screen_exclusive";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireFullScreenExclusiveModeEXT")]
        public abstract Result AcquireFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT")]
        public abstract unsafe Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT")]
        public abstract Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT")]
        public abstract unsafe Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT")]
        public abstract Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleaseFullScreenExclusiveModeEXT")]
        public abstract Result ReleaseFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        public ExtFullScreenExclusive(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

