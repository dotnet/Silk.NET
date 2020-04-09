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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_android_surface")]
    public abstract unsafe partial class KhrAndroidSurface : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateAndroidSurfaceKHR")]
        public abstract unsafe Result CreateAndroidSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] AndroidSurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateAndroidSurfaceKHR")]
        public abstract Result CreateAndroidSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref AndroidSurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        public KhrAndroidSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

