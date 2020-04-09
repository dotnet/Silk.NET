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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_display_surface_counter")]
    public abstract unsafe partial class ExtDisplaySurfaceCounter : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        public abstract unsafe Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceCapabilities2EXT* pSurfaceCapabilities);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        public abstract Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceCapabilities2EXT pSurfaceCapabilities);

        public ExtDisplaySurfaceCounter(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

