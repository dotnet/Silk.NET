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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_wayland_surface")]
    public unsafe partial class KhrWaylandSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_wayland_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public unsafe partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] WaylandSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public unsafe partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] WaylandSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public unsafe partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] WaylandSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public unsafe partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] WaylandSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public unsafe partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in WaylandSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public unsafe partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in WaylandSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public unsafe partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in WaylandSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public partial Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in WaylandSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceWaylandPresentationSupportKHR")]
        public unsafe partial Bool32 GetPhysicalDeviceWaylandPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] nint* display);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceWaylandPresentationSupportKHR")]
        public partial Bool32 GetPhysicalDeviceWaylandPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out nint display);

        public KhrWaylandSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

