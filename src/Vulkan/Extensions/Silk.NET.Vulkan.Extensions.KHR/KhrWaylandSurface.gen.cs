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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_wayland_surface")]
    public abstract unsafe partial class KhrWaylandSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_wayland_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public abstract unsafe Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] WaylandSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateWaylandSurfaceKHR")]
        public abstract Result CreateWaylandSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref WaylandSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceWaylandPresentationSupportKHR")]
        public abstract unsafe Bool32 GetPhysicalDeviceWaylandPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* display);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceWaylandPresentationSupportKHR")]
        public abstract Bool32 GetPhysicalDeviceWaylandPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr display);

        public KhrWaylandSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

