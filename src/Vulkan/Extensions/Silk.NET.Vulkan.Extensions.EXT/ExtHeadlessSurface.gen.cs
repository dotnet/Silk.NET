// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_headless_surface")]
    public unsafe partial class ExtHeadlessSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_headless_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateHeadlessSurfaceEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateHeadlessSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] HeadlessSurfaceCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface)
            => ImplCreateHeadlessSurface(instance, pCreateInfo, pAllocator, pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateHeadlessSurfaceEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateHeadlessSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref HeadlessSurfaceCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface)
            => ImplCreateHeadlessSurface(instance, pCreateInfo, pAllocator, pSurface);

        public ExtHeadlessSurface(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

