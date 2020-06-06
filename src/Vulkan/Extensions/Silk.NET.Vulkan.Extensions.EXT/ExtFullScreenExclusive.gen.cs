// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_full_screen_exclusive")]
    public unsafe partial class ExtFullScreenExclusive : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_full_screen_exclusive";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireFullScreenExclusiveModeEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AcquireFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain)
            => ImplAcquireFullScreenExclusiveMode(device, swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes)
            => ImplGetDeviceGroupSurfacePresentModes2(device, pSurfaceInfo, pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes)
            => ImplGetDeviceGroupSurfacePresentModes2(device, pSurfaceInfo, pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] PresentModeKHR* pPresentModes)
            => ImplGetPhysicalDeviceSurfacePresentModes2(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] out PresentModeKHR pPresentModes)
            => ImplGetPhysicalDeviceSurfacePresentModes2(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkReleaseFullScreenExclusiveModeEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ReleaseFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain)
            => ImplReleaseFullScreenExclusiveMode(device, swapchain);

        public ExtFullScreenExclusive(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

