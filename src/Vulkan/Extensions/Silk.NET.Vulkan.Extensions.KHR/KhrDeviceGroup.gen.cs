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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_device_group")]
    public unsafe partial class KhrDeviceGroup : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_device_group";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR", Convention = CallingConvention.Winapi)]
        public partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBaseKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMaskKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR", Convention = CallingConvention.Winapi)]
        public partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PeerMemoryFeatureFlags pPeerMemoryFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pDeviceGroupPresentCapabilities = new(StructureType.DeviceGroupPresentCapabilitiesKhr);")]
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Rect2D* pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Rect2D pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Rect2D* pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Rect2D pRects);

        /// <summary>To be documented.</summary>
        public unsafe PeerMemoryFeatureFlags GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex)
        {
            // NonKhrReturnTypeOverloader
            GetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out PeerMemoryFeatureFlags silkRet);
            return silkRet;
        }

        public KhrDeviceGroup(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

