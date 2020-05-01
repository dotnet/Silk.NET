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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_win32_surface")]
    public abstract unsafe partial class KhrWin32Surface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_win32_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR")]
        public abstract unsafe Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] Win32SurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateWin32SurfaceKHR")]
        public abstract Result CreateWin32Surface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref Win32SurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceWin32PresentationSupportKHR")]
        public abstract Bool32 GetPhysicalDeviceWin32PresentationSupport([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint queueFamilyIndex);

        public KhrWin32Surface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

