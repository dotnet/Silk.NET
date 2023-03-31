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
    public static class KhrVideoQueueOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BindVideoSessionMemory(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] uint bindSessionMemoryInfoCount, [Count(Parameter = "bindSessionMemoryInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindVideoSessionMemoryInfoKHR> pBindSessionMemoryInfos)
        {
            // SpanOverloader
            return thisApi.BindVideoSessionMemory(device, videoSession, bindSessionMemoryInfoCount, in pBindSessionMemoryInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginVideoCoding(this KhrVideoQueue thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoBeginCodingInfoKHR> pBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginVideoCoding(commandBuffer, in pBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdControlVideoCoding(this KhrVideoQueue thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoCodingControlInfoKHR> pCodingControlInfo)
        {
            // SpanOverloader
            thisApi.CmdControlVideoCoding(commandBuffer, in pCodingControlInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdEndVideoCoding(this KhrVideoQueue thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEndCodingInfoKHR> pEndCodingInfo)
        {
            // SpanOverloader
            thisApi.CmdEndVideoCoding(commandBuffer, in pEndCodingInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionKHR> pVideoSession)
        {
            // SpanOverloader
            return thisApi.CreateVideoSession(device, pCreateInfo, pAllocator, out pVideoSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionKHR* pVideoSession)
        {
            // SpanOverloader
            return thisApi.CreateVideoSession(device, pCreateInfo, in pAllocator.GetPinnableReference(), pVideoSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionKHR> pVideoSession)
        {
            // SpanOverloader
            return thisApi.CreateVideoSession(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pVideoSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionKHR* pVideoSession)
        {
            // SpanOverloader
            return thisApi.CreateVideoSession(device, in pCreateInfo.GetPinnableReference(), pAllocator, pVideoSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionKHR> pVideoSession)
        {
            // SpanOverloader
            return thisApi.CreateVideoSession(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pVideoSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionKHR* pVideoSession)
        {
            // SpanOverloader
            return thisApi.CreateVideoSession(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pVideoSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionKHR> pVideoSession)
        {
            // SpanOverloader
            return thisApi.CreateVideoSession(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pVideoSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionParametersKHR> pVideoSessionParameters)
        {
            // SpanOverloader
            return thisApi.CreateVideoSessionParameters(device, pCreateInfo, pAllocator, out pVideoSessionParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionParametersKHR* pVideoSessionParameters)
        {
            // SpanOverloader
            return thisApi.CreateVideoSessionParameters(device, pCreateInfo, in pAllocator.GetPinnableReference(), pVideoSessionParameters);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSessionParametersCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionParametersKHR> pVideoSessionParameters)
        {
            // SpanOverloader
            return thisApi.CreateVideoSessionParameters(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pVideoSessionParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionParametersCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionParametersKHR* pVideoSessionParameters)
        {
            // SpanOverloader
            return thisApi.CreateVideoSessionParameters(device, in pCreateInfo.GetPinnableReference(), pAllocator, pVideoSessionParameters);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionParametersCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionParametersKHR> pVideoSessionParameters)
        {
            // SpanOverloader
            return thisApi.CreateVideoSessionParameters(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pVideoSessionParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionParametersCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionParametersKHR* pVideoSessionParameters)
        {
            // SpanOverloader
            return thisApi.CreateVideoSessionParameters(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pVideoSessionParameters);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionParametersCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionParametersKHR> pVideoSessionParameters)
        {
            // SpanOverloader
            return thisApi.CreateVideoSessionParameters(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pVideoSessionParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyVideoSession(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyVideoSession(device, videoSession, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionParametersKHR videoSessionParameters, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyVideoSessionParameters(device, videoSessionParameters, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.VideoCapabilitiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoCapabilities(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProfileInfoKHR* pVideoProfile, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoCapabilitiesKHR> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoCapabilities(physicalDevice, pVideoProfile, out pCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceVideoCapabilities(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProfileInfoKHR> pVideoProfile, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoCapabilitiesKHR* pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoCapabilities(physicalDevice, in pVideoProfile.GetPinnableReference(), pCapabilities);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.VideoCapabilitiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoCapabilities(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProfileInfoKHR> pVideoProfile, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoCapabilitiesKHR> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoCapabilities(physicalDevice, in pVideoProfile.GetPinnableReference(), out pCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoFormatProperties(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [Count(Count = 0)] uint* pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoFormatPropertiesKHR> pVideoFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoFormatProperties(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, out pVideoFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceVideoFormatProperties(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [Count(Count = 0)] Span<uint> pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoFormatProperties(physicalDevice, pVideoFormatInfo, ref pVideoFormatPropertyCount.GetPinnableReference(), pVideoFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoFormatProperties(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [Count(Count = 0)] Span<uint> pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoFormatPropertiesKHR> pVideoFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoFormatProperties(physicalDevice, pVideoFormatInfo, ref pVideoFormatPropertyCount.GetPinnableReference(), out pVideoFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceVideoFormatProperties(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceVideoFormatInfoKHR> pVideoFormatInfo, [Count(Count = 0)] uint* pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoFormatProperties(physicalDevice, in pVideoFormatInfo.GetPinnableReference(), pVideoFormatPropertyCount, pVideoFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoFormatProperties(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceVideoFormatInfoKHR> pVideoFormatInfo, [Count(Count = 0)] uint* pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoFormatPropertiesKHR> pVideoFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoFormatProperties(physicalDevice, in pVideoFormatInfo.GetPinnableReference(), pVideoFormatPropertyCount, out pVideoFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceVideoFormatProperties(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceVideoFormatInfoKHR> pVideoFormatInfo, [Count(Count = 0)] Span<uint> pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoFormatProperties(physicalDevice, in pVideoFormatInfo.GetPinnableReference(), ref pVideoFormatPropertyCount.GetPinnableReference(), pVideoFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pVideoFormatProperties = new(StructureType.VideoFormatPropertiesKhr);")]
        public static unsafe Result GetPhysicalDeviceVideoFormatProperties(this KhrVideoQueue thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceVideoFormatInfoKHR> pVideoFormatInfo, [Count(Count = 0)] Span<uint> pVideoFormatPropertyCount, [Count(Parameter = "pVideoFormatPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoFormatPropertiesKHR> pVideoFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceVideoFormatProperties(physicalDevice, in pVideoFormatInfo.GetPinnableReference(), ref pVideoFormatPropertyCount.GetPinnableReference(), out pVideoFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.VideoSessionMemoryRequirementsKhr);")]
        public static unsafe Result GetVideoSessionMemoryRequirements(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] uint* pMemoryRequirementsCount, [Count(Parameter = "pMemoryRequirementsCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionMemoryRequirementsKHR> pMemoryRequirements)
        {
            // SpanOverloader
            return thisApi.GetVideoSessionMemoryRequirements(device, videoSession, pMemoryRequirementsCount, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVideoSessionMemoryRequirements(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] Span<uint> pMemoryRequirementsCount, [Count(Parameter = "pMemoryRequirementsCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            // SpanOverloader
            return thisApi.GetVideoSessionMemoryRequirements(device, videoSession, ref pMemoryRequirementsCount.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.VideoSessionMemoryRequirementsKhr);")]
        public static unsafe Result GetVideoSessionMemoryRequirements(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionKHR videoSession, [Count(Count = 0)] Span<uint> pMemoryRequirementsCount, [Count(Parameter = "pMemoryRequirementsCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VideoSessionMemoryRequirementsKHR> pMemoryRequirements)
        {
            // SpanOverloader
            return thisApi.GetVideoSessionMemoryRequirements(device, videoSession, ref pMemoryRequirementsCount.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UpdateVideoSessionParameters(this KhrVideoQueue thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] VideoSessionParametersKHR videoSessionParameters, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSessionParametersUpdateInfoKHR> pUpdateInfo)
        {
            // SpanOverloader
            return thisApi.UpdateVideoSessionParameters(device, videoSessionParameters, in pUpdateInfo.GetPinnableReference());
        }

    }
}

