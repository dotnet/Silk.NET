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
    [Extension("VK_KHR_xcb_surface")]
    public abstract unsafe partial class KhrXcbSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_xcb_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateXcbSurfaceKHR")]
        public abstract unsafe Result CreateXcbSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] XcbSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateXcbSurfaceKHR")]
        public abstract Result CreateXcbSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref XcbSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceXcbPresentationSupportKHR")]
        public abstract unsafe Bool32 GetPhysicalDeviceXcbPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] IntPtr* connection, [Count(Count = 0)] IntPtr visual_id);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceXcbPresentationSupportKHR")]
        public abstract Bool32 GetPhysicalDeviceXcbPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref IntPtr connection, [Count(Count = 0)] IntPtr visual_id);

        /// <summary>To be added.</summary>
        public unsafe Bool32 GetPhysicalDeviceXcbPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] IntPtr* connection, [Count(Count = 0)] int visual_id)
        {
            // IntPtrOverloader
            return GetPhysicalDeviceXcbPresentationSupport(physicalDevice, queueFamilyIndex, connection, new IntPtr(visual_id));
        }

        /// <summary>To be added.</summary>
        public unsafe Bool32 GetPhysicalDeviceXcbPresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] ref IntPtr connection, [Count(Count = 0)] int visual_id)
        {
            // IntPtrOverloader
            return GetPhysicalDeviceXcbPresentationSupport(physicalDevice, queueFamilyIndex, ref connection, new IntPtr(visual_id));
        }

        public KhrXcbSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

