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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_directfb_surface")]
    public unsafe partial class ExtDirectfbSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_directfb_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDirectFBPresentationSupportEXT", Convention = CallingConvention.Winapi)]
        public partial Bool32 GetPhysicalDeviceDirectFbpresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint dfb);

        public ExtDirectfbSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

