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
    public static class KhrGetSurfaceCapabilities2Overloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceCapabilities = new(StructureType.SurfaceCapabilities2Khr);")]
        public static unsafe Result GetPhysicalDeviceSurfaceCapabilities2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceCapabilities2KHR> pSurfaceCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceCapabilities2(physicalDevice, pSurfaceInfo, out pSurfaceCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceCapabilities2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceCapabilities2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), pSurfaceCapabilities);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceCapabilities = new(StructureType.SurfaceCapabilities2Khr);")]
        public static unsafe Result GetPhysicalDeviceSurfaceCapabilities2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceCapabilities2KHR> pSurfaceCapabilities)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceCapabilities2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), out pSurfaceCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        public static unsafe Result GetPhysicalDeviceSurfaceFormats2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceFormat2KHR> pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats2(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, out pSurfaceFormats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceFormats2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] Span<uint> pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats2(physicalDevice, pSurfaceInfo, ref pSurfaceFormatCount.GetPinnableReference(), pSurfaceFormats);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        public static unsafe Result GetPhysicalDeviceSurfaceFormats2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] Span<uint> pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceFormat2KHR> pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats2(physicalDevice, pSurfaceInfo, ref pSurfaceFormatCount.GetPinnableReference(), out pSurfaceFormats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceFormats2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), pSurfaceFormatCount, pSurfaceFormats);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        public static unsafe Result GetPhysicalDeviceSurfaceFormats2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] uint* pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceFormat2KHR> pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), pSurfaceFormatCount, out pSurfaceFormats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfaceFormats2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] Span<uint> pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SurfaceFormat2KHR* pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), ref pSurfaceFormatCount.GetPinnableReference(), pSurfaceFormats);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSurfaceFormats = new(StructureType.SurfaceFormat2Khr);")]
        public static unsafe Result GetPhysicalDeviceSurfaceFormats2(this KhrGetSurfaceCapabilities2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] Span<uint> pSurfaceFormatCount, [Count(Parameter = "pSurfaceFormatCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SurfaceFormat2KHR> pSurfaceFormats)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfaceFormats2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), ref pSurfaceFormatCount.GetPinnableReference(), out pSurfaceFormats.GetPinnableReference());
        }

    }
}

