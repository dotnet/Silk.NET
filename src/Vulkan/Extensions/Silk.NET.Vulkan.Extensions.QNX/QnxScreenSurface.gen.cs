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

namespace Silk.NET.Vulkan.Extensions.QNX
{
    [Extension("VK_QNX_screen_surface")]
    public unsafe partial class QnxScreenSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_QNX_screen_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ScreenSurfaceCreateInfoQNX* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateScreenSurfaceQNX", Convention = CallingConvention.Winapi)]
        public partial Result CreateScreenSurfaceQnx([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ScreenSurfaceCreateInfoQNX pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceScreenPresentationSupportQNX", Convention = CallingConvention.Winapi)]
        public unsafe partial Bool32 GetPhysicalDeviceScreenPresentationSupportQnx([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* window);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceScreenPresentationSupportQNX", Convention = CallingConvention.Winapi)]
        public partial Bool32 GetPhysicalDeviceScreenPresentationSupportQnx<T0>([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 window) where T0 : unmanaged;

        public QnxScreenSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

