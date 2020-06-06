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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_swapchain")]
    public unsafe partial class KhrSwapchain : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_swapchain";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImageKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AcquireNextImage([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ulong timeout, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence, [Count(Count = 0)] uint* pImageIndex)
            => ImplAcquireNextImage(device, swapchain, timeout, semaphore, fence, pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImageKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AcquireNextImage([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ulong timeout, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence, [Count(Count = 0)] ref uint pImageIndex)
            => ImplAcquireNextImage(device, swapchain, timeout, semaphore, fence, pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] uint* pImageIndex)
            => ImplAcquireNextImage2(device, pAcquireInfo, pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex)
            => ImplAcquireNextImage2(device, pAcquireInfo, pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SwapchainKHR* pSwapchain)
            => ImplCreateSwapchain(device, pCreateInfo, pAllocator, pSwapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SwapchainCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SwapchainKHR pSwapchain)
            => ImplCreateSwapchain(device, pCreateInfo, pAllocator, pSwapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySwapchainKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroySwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroySwapchain(device, swapchain, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySwapchainKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroySwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroySwapchain(device, swapchain, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
            => ImplGetDeviceGroupPresentCapabilities(device, pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities)
            => ImplGetDeviceGroupPresentCapabilities(device, pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes)
            => ImplGetDeviceGroupSurfacePresentModes(device, surface, pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes)
            => ImplGetDeviceGroupSurfacePresentModes(device, surface, pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] Rect2D* pRects)
            => ImplGetPhysicalDevicePresentRectangles(physicalDevice, surface, pRectCount, pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] out Rect2D pRects)
            => ImplGetPhysicalDevicePresentRectangles(physicalDevice, surface, pRectCount, pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pSwapchainImageCount, [Count(Computed = "pSwapchainImageCount"), Flow(FlowDirection.Out)] Image* pSwapchainImages)
            => ImplGetSwapchainImages(device, swapchain, pSwapchainImageCount, pSwapchainImages);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pSwapchainImageCount, [Count(Computed = "pSwapchainImageCount"), Flow(FlowDirection.Out)] out Image pSwapchainImages)
            => ImplGetSwapchainImages(device, swapchain, pSwapchainImageCount, pSwapchainImages);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueuePresentKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result QueuePresent([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] PresentInfoKHR* pPresentInfo)
            => ImplQueuePresent(queue, pPresentInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueuePresentKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result QueuePresent([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] ref PresentInfoKHR pPresentInfo)
            => ImplQueuePresent(queue, pPresentInfo);

        public KhrSwapchain(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

