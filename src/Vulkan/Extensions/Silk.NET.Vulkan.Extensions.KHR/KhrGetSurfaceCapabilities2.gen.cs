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
    [Extension("VK_KHR_get_surface_capabilities2")]
    public abstract unsafe partial class KhrGetSurfaceCapabilities2 : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
        public abstract unsafe Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceCapabilities2KHR* pSurfaceCapabilities);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
        public abstract Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceCapabilities2KHR pSurfaceCapabilities);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR")]
        public abstract unsafe Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Computed = "pSurfaceFormatCount"), Flow(FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR")]
        public abstract Result GetPhysicalDeviceSurfaceFormats2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pSurfaceFormatCount, [Count(Computed = "pSurfaceFormatCount"), Flow(FlowDirection.Out)] out SurfaceFormat2KHR pSurfaceFormats);

        public KhrGetSurfaceCapabilities2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

