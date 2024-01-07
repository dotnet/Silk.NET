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
    [Extension("VK_KHR_win32_surface")]
    public unsafe partial class KhrWin32Surface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_win32_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Win32SurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Win32SurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Win32SurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Win32SurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Win32SurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Win32SurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Win32SurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Win32SurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceWin32PresentationSupportKHR", Convention = CallingConvention.Winapi)]
        public partial Bool32 GetPhysicalDeviceWin32PresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex);

        public KhrWin32Surface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

