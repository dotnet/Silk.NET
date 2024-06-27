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
    [Extension("VK_KHR_xlib_surface")]
    public unsafe partial class KhrXlibSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_xlib_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] XlibSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in XlibSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in XlibSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in XlibSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateXlibSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateXlibSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in XlibSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceXlibPresentationSupportKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Bool32 GetPhysicalDeviceXlibPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] nint* dpy, [Count(Count = 0)] nint visualID);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceXlibPresentationSupportKHR", Convention = CallingConvention.Winapi)]
        public partial Bool32 GetPhysicalDeviceXlibPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref nint dpy, [Count(Count = 0)] nint visualID);

        public KhrXlibSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

