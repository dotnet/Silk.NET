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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_swapchain")]
    public unsafe partial class KhrSwapchain : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_swapchain";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireNextImage([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ulong timeout, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImageKHR", Convention = CallingConvention.Winapi)]
        public partial Result AcquireNextImage([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ulong timeout, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0)] Fence fence, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSwapchainKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateSwapchain([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySwapchainKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroySwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySwapchainKHR", Convention = CallingConvention.Winapi)]
        public partial void DestroySwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pDeviceGroupPresentCapabilities = new(StructureType.DeviceGroupPresentCapabilitiesKhr);")]
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Rect2D* pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Rect2D pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Rect2D* pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Rect2D pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pSwapchainImageCount, [Count(Parameter = "pSwapchainImageCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Image* pSwapchainImages);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] uint* pSwapchainImageCount, [Count(Parameter = "pSwapchainImageCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Image pSwapchainImages);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pSwapchainImageCount, [Count(Parameter = "pSwapchainImageCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Image* pSwapchainImages);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainImagesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetSwapchainImages([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain, [Count(Count = 0)] ref uint pSwapchainImageCount, [Count(Parameter = "pSwapchainImageCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Image pSwapchainImages);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueuePresentKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueuePresent([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PresentInfoKHR* pPresentInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueuePresentKHR", Convention = CallingConvention.Winapi)]
        public partial Result QueuePresent([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PresentInfoKHR pPresentInfo);

        public KhrSwapchain(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

