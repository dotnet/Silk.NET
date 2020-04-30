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

namespace Silk.NET.Vulkan.Extensions.MVK
{
    [Extension("VK_MVK_ios_surface")]
    public abstract unsafe partial class MvkIosSurface : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateIOSSurfaceMVK")]
        public abstract unsafe Result CreateIossurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] IOSSurfaceCreateInfoMVK* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateIOSSurfaceMVK")]
        public abstract Result CreateIossurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref IOSSurfaceCreateInfoMVK pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        public MvkIosSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

