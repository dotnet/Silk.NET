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

namespace Silk.NET.Vulkan.Extensions.GGP
{
    [Extension("VK_GGP_stream_descriptor_surface")]
    public abstract unsafe partial class GgpStreamDescriptorSurface : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateStreamDescriptorSurfaceGGP")]
        public abstract unsafe Result CreateStreamDescriptorSurfaceGgp([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] StreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateStreamDescriptorSurfaceGGP")]
        public abstract Result CreateStreamDescriptorSurfaceGgp([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref StreamDescriptorSurfaceCreateInfoGGP pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        public GgpStreamDescriptorSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

