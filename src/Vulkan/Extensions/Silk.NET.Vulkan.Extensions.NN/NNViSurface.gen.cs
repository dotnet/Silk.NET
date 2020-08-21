// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NN
{
    [Extension("VK_NN_vi_surface")]
    public unsafe partial class NNViSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NN_vi_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public unsafe partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ViSurfaceCreateInfoNN* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public unsafe partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ViSurfaceCreateInfoNN* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public unsafe partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ViSurfaceCreateInfoNN* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public unsafe partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ViSurfaceCreateInfoNN* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public unsafe partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ViSurfaceCreateInfoNN pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public unsafe partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ViSurfaceCreateInfoNN pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public unsafe partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ViSurfaceCreateInfoNN pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        public partial Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ViSurfaceCreateInfoNN pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        public NNViSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

