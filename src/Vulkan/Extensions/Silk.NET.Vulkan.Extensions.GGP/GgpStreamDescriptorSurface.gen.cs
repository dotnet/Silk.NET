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

namespace Silk.NET.Vulkan.Extensions.GGP
{
    [Extension("VK_GGP_stream_descriptor_surface")]
    public unsafe partial class GgpStreamDescriptorSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_GGP_stream_descriptor_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateStreamDescriptorSurfaceGGP")]
        public unsafe partial Result CreateStreamDescriptorSurfaceGgp([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] StreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateStreamDescriptorSurfaceGGP")]
        public partial Result CreateStreamDescriptorSurfaceGgp([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref StreamDescriptorSurfaceCreateInfoGGP pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        public GgpStreamDescriptorSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

