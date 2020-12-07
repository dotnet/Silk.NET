// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        public unsafe partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] uint* pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkAcquireNextImage2KHR")]
        public partial Result AcquireNextImage2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AcquireNextImageInfoKHR pAcquireInfo, [Count(Count = 0)] ref uint pImageIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBaseKHR")]
        public partial void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMaskKHR")]
        public partial void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        public unsafe partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        public partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out PeerMemoryFeatureFlags pPeerMemoryFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        public unsafe partial Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        public partial Result GetDeviceGroupPresentCapabilities([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        public unsafe partial Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        public partial Result GetDeviceGroupSurfacePresentModes([Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceGroupPresentModeFlagsKHR pModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] Rect2D* pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] out Rect2D pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        public unsafe partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] Rect2D* pRects);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        public partial Result GetPhysicalDevicePresentRectangles([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] ref uint pRectCount, [Count(Computed = "pRectCount"), Flow(FlowDirection.Out)] out Rect2D pRects);

        public KhrDeviceGroup(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

