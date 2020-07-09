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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_directfb_surface")]
    public abstract unsafe partial class ExtDirectfbSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_directfb_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public abstract unsafe Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public abstract Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDirectFBPresentationSupportEXT")]
        public abstract Bool32 GetPhysicalDeviceDirectFbpresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr dfb);

        /// <summary>To be added.</summary>
        public unsafe Bool32 GetPhysicalDeviceDirectFbpresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] int dfb)
        {
            // IntPtrOverloader
            return GetPhysicalDeviceDirectFbpresentationSupport(physicalDevice, queueFamilyIndex, new IntPtr(dfb));
        }

        public ExtDirectfbSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

