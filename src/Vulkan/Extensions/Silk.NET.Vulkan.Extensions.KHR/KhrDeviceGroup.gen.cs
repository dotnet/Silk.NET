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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_device_group")]
    public unsafe partial class KhrDeviceGroup : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_device_group";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] uint* pImageIndex)
            => ImplAcquireNextImage2(device, pAcquireInfo, pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex)
            => ImplAcquireNextImage2(device, pAcquireInfo, pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBaseKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ)
            => ImplCmdDispatchBase(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMaskKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask)
            => ImplCmdSetDeviceMask(commandBuffer, deviceMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures)
            => ImplGetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out PeerMemoryFeatureFlags pPeerMemoryFeatures)
            => ImplGetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
            => ImplGetDeviceGroupPresentCapabilities(device, pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities)
            => ImplGetDeviceGroupPresentCapabilities(device, pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes)
            => ImplGetDeviceGroupSurfacePresentModes(device, surface, pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes)
            => ImplGetDeviceGroupSurfacePresentModes(device, surface, pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] Rect2D* pRects)
            => ImplGetPhysicalDevicePresentRectangles(physicalDevice, surface, pRectCount, pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] out Rect2D pRects)
            => ImplGetPhysicalDevicePresentRectangles(physicalDevice, surface, pRectCount, pRects);

        public KhrDeviceGroup(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

