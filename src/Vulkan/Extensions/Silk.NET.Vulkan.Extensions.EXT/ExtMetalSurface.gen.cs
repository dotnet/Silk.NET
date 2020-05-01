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
    [Extension("VK_EXT_metal_surface")]
    public abstract unsafe partial class ExtMetalSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_metal_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateMetalSurfaceEXT")]
        public abstract unsafe Result CreateMetalSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] MetalSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateMetalSurfaceEXT")]
        public abstract Result CreateMetalSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref MetalSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        public ExtMetalSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

