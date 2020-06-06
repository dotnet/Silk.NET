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
    [Extension("VK_EXT_display_surface_counter")]
    public unsafe partial class ExtDisplaySurfaceCounter : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_display_surface_counter";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceCapabilities2EXT* pSurfaceCapabilities)
            => ImplGetPhysicalDeviceSurfaceCapabilities2(physicalDevice, surface, pSurfaceCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceSurfaceCapabilities2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceCapabilities2EXT pSurfaceCapabilities)
            => ImplGetPhysicalDeviceSurfaceCapabilities2(physicalDevice, surface, pSurfaceCapabilities);

        public ExtDisplaySurfaceCounter(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

