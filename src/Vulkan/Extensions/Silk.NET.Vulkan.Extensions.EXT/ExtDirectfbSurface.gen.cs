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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_directfb_surface")]
    public unsafe partial class ExtDirectfbSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_directfb_surface";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DirectFBSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public unsafe partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDirectFBSurfaceEXT")]
        public partial Result CreateDirectFbsurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DirectFBSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDirectFBPresentationSupportEXT")]
        public partial Bool32 GetPhysicalDeviceDirectFbpresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr dfb);

        public ExtDirectfbSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

