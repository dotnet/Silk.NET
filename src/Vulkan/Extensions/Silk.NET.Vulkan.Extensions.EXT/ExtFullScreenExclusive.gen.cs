// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_full_screen_exclusive")]
    public unsafe partial class ExtFullScreenExclusive : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_full_screen_exclusive";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireFullScreenExclusiveModeEXT", Convention = CallingConvention.Winapi)]
        public partial Result AcquireFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceGroupSurfacePresentModes2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PresentModeKHR* pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSurfacePresentModes2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, [Count(Count = 0)] ref uint pPresentModeCount, [Count(Parameter = "pPresentModeCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PresentModeKHR pPresentModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkReleaseFullScreenExclusiveModeEXT", Convention = CallingConvention.Winapi)]
        public partial Result ReleaseFullScreenExclusiveMode([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        public ExtFullScreenExclusive(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

