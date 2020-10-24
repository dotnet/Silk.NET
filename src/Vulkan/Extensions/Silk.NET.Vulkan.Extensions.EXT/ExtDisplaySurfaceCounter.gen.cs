// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_display_surface_counter")]
    public unsafe partial class ExtDisplaySurfaceCounter : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_display_surface_counter";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        public unsafe partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceCapabilities2EXT* pSurfaceCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        public partial Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceCapabilities2EXT pSurfaceCapabilities);

        public ExtDisplaySurfaceCounter(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

