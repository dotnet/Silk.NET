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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrDeviceGroupOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireNextImage2(this KhrDeviceGroup thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AcquireNextImageInfoKHR* pAcquireInfo, [Count(Count = 0)] Span<uint> pImageIndex)
        {
            // SpanOverloader
            return thisApi.AcquireNextImage2(device, pAcquireInfo, ref pImageIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireNextImage2(this KhrDeviceGroup thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AcquireNextImageInfoKHR> pAcquireInfo, [Count(Count = 0)] uint* pImageIndex)
        {
            // SpanOverloader
            return thisApi.AcquireNextImage2(device, in pAcquireInfo.GetPinnableReference(), pImageIndex);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireNextImage2(this KhrDeviceGroup thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AcquireNextImageInfoKHR> pAcquireInfo, [Count(Count = 0)] Span<uint> pImageIndex)
        {
            // SpanOverloader
            return thisApi.AcquireNextImage2(device, in pAcquireInfo.GetPinnableReference(), ref pImageIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDeviceGroupPeerMemoryFeatures(this KhrDeviceGroup thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PeerMemoryFeatureFlags> pPeerMemoryFeatures)
        {
            // SpanOverloader
            thisApi.GetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, out pPeerMemoryFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pDeviceGroupPresentCapabilities = new(StructureType.DeviceGroupPresentCapabilitiesKhr);")]
        public static unsafe Result GetDeviceGroupPresentCapabilities(this KhrDeviceGroup thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceGroupPresentCapabilitiesKHR> pDeviceGroupPresentCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDeviceGroupPresentCapabilities(device, out pDeviceGroupPresentCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceGroupSurfacePresentModes(this KhrDeviceGroup thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DeviceGroupPresentModeFlagsKHR> pModes)
        {
            // SpanOverloader
            return thisApi.GetDeviceGroupSurfacePresentModes(device, surface, out pModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDevicePresentRectangles(this KhrDeviceGroup thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] uint* pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Rect2D> pRects)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDevicePresentRectangles(physicalDevice, surface, pRectCount, out pRects.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDevicePresentRectangles(this KhrDeviceGroup thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Rect2D* pRects)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDevicePresentRectangles(physicalDevice, surface, ref pRectCount.GetPinnableReference(), pRects);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDevicePresentRectangles(this KhrDeviceGroup thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SurfaceKHR surface, [Count(Count = 0)] Span<uint> pRectCount, [Count(Parameter = "pRectCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Rect2D> pRects)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDevicePresentRectangles(physicalDevice, surface, ref pRectCount.GetPinnableReference(), out pRects.GetPinnableReference());
        }

    }
}

