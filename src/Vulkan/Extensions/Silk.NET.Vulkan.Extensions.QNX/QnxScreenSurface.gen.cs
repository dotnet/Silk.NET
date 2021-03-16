// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.Vulkan.Extensions.QNX
{
    [Extension("VK_QNX_screen_surface")]
    public unsafe partial class QnxScreenSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_QNX_screen_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX")]
        public partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceScreenPresentationSupportQNX")]
        public unsafe partial Bool32 GetPhysicalDeviceScreenPresentationSupportQnx([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] void* window);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceScreenPresentationSupportQNX")]
        public partial Bool32 GetPhysicalDeviceScreenPresentationSupportQnx<T0>([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 window) where T0 : unmanaged;

        public QnxScreenSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

