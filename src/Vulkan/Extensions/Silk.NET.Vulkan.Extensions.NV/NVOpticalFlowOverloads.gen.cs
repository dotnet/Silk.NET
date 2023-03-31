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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVOpticalFlowOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdOpticalFlowExecute(this NVOpticalFlow thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] OpticalFlowSessionNV session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowExecuteInfoNV> pExecuteInfo)
        {
            // SpanOverloader
            thisApi.CmdOpticalFlowExecute(commandBuffer, session, in pExecuteInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowSessionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowSessionNV> pSession)
        {
            // SpanOverloader
            return thisApi.CreateOpticalFlowSession(device, pCreateInfo, pAllocator, out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowSessionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowSessionNV* pSession)
        {
            // SpanOverloader
            return thisApi.CreateOpticalFlowSession(device, pCreateInfo, in pAllocator.GetPinnableReference(), pSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowSessionCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowSessionNV> pSession)
        {
            // SpanOverloader
            return thisApi.CreateOpticalFlowSession(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowSessionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowSessionNV* pSession)
        {
            // SpanOverloader
            return thisApi.CreateOpticalFlowSession(device, in pCreateInfo.GetPinnableReference(), pAllocator, pSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowSessionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowSessionNV> pSession)
        {
            // SpanOverloader
            return thisApi.CreateOpticalFlowSession(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowSessionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowSessionNV* pSession)
        {
            // SpanOverloader
            return thisApi.CreateOpticalFlowSession(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pSession);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowSessionCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowSessionNV> pSession)
        {
            // SpanOverloader
            return thisApi.CreateOpticalFlowSession(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pSession.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyOpticalFlowSession(this NVOpticalFlow thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] OpticalFlowSessionNV session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyOpticalFlowSession(device, session, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        public static unsafe Result GetPhysicalDeviceOpticalFlowImageFormats(this NVOpticalFlow thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, [Count(Count = 0)] uint* pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowImageFormatPropertiesNV> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceOpticalFlowImageFormats(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceOpticalFlowImageFormats(this NVOpticalFlow thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, [Count(Count = 0)] Span<uint> pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceOpticalFlowImageFormats(physicalDevice, pOpticalFlowImageFormatInfo, ref pFormatCount.GetPinnableReference(), pImageFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        public static unsafe Result GetPhysicalDeviceOpticalFlowImageFormats(this NVOpticalFlow thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] OpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, [Count(Count = 0)] Span<uint> pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowImageFormatPropertiesNV> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceOpticalFlowImageFormats(physicalDevice, pOpticalFlowImageFormatInfo, ref pFormatCount.GetPinnableReference(), out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceOpticalFlowImageFormats(this NVOpticalFlow thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowImageFormatInfoNV> pOpticalFlowImageFormatInfo, [Count(Count = 0)] uint* pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceOpticalFlowImageFormats(physicalDevice, in pOpticalFlowImageFormatInfo.GetPinnableReference(), pFormatCount, pImageFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        public static unsafe Result GetPhysicalDeviceOpticalFlowImageFormats(this NVOpticalFlow thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowImageFormatInfoNV> pOpticalFlowImageFormatInfo, [Count(Count = 0)] uint* pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowImageFormatPropertiesNV> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceOpticalFlowImageFormats(physicalDevice, in pOpticalFlowImageFormatInfo.GetPinnableReference(), pFormatCount, out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceOpticalFlowImageFormats(this NVOpticalFlow thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowImageFormatInfoNV> pOpticalFlowImageFormatInfo, [Count(Count = 0)] Span<uint> pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] OpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceOpticalFlowImageFormats(physicalDevice, in pOpticalFlowImageFormatInfo.GetPinnableReference(), ref pFormatCount.GetPinnableReference(), pImageFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.OpticalFlowImageFormatPropertiesNV);")]
        public static unsafe Result GetPhysicalDeviceOpticalFlowImageFormats(this NVOpticalFlow thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpticalFlowImageFormatInfoNV> pOpticalFlowImageFormatInfo, [Count(Count = 0)] Span<uint> pFormatCount, [Count(Parameter = "pFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<OpticalFlowImageFormatPropertiesNV> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceOpticalFlowImageFormats(physicalDevice, in pOpticalFlowImageFormatInfo.GetPinnableReference(), ref pFormatCount.GetPinnableReference(), out pImageFormatProperties.GetPinnableReference());
        }

    }
}

