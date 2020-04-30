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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_full_screen_exclusive")]
    public abstract unsafe partial class ExtFullScreenExclusive : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkAcquireFullScreenExclusiveModeEXT")]
        public abstract Result AcquireFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT")]
        public abstract unsafe Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT")]
        public abstract Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT")]
        public abstract unsafe Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT")]
        public abstract Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkReleaseFullScreenExclusiveModeEXT")]
        public abstract Result ReleaseFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        public ExtFullScreenExclusive(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

