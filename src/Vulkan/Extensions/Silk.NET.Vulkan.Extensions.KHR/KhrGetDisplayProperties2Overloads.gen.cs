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
    public static class KhrGetDisplayProperties2Overloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayModeProperties2Khr);")]
        public static unsafe Result GetDisplayModeProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModeProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties2(physicalDevice, display, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayModeProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayModeProperties2KHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties2(physicalDevice, display, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayModeProperties2Khr);")]
        public static unsafe Result GetDisplayModeProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayModeProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties2(physicalDevice, display, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.DisplayPlaneCapabilities2Khr);")]
        public static unsafe Result GetDisplayPlaneCapabilities2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayPlaneInfo2KHR* pDisplayPlaneInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPlaneCapabilities2KHR> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneCapabilities2(physicalDevice, pDisplayPlaneInfo, out pCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayPlaneCapabilities2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayPlaneInfo2KHR> pDisplayPlaneInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlaneCapabilities2KHR* pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneCapabilities2(physicalDevice, in pDisplayPlaneInfo.GetPinnableReference(), pCapabilities);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCapabilities = new(StructureType.DisplayPlaneCapabilities2Khr);")]
        public static unsafe Result GetDisplayPlaneCapabilities2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayPlaneInfo2KHR> pDisplayPlaneInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPlaneCapabilities2KHR> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneCapabilities2(physicalDevice, in pDisplayPlaneInfo.GetPinnableReference(), out pCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayPlaneProperties2Khr);")]
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPlaneProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayPlaneProperties2KHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayPlaneProperties2Khr);")]
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayPlaneProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayProperties2Khr);")]
        public static unsafe Result GetPhysicalDeviceDisplayProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties2(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DisplayProperties2KHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.DisplayProperties2Khr);")]
        public static unsafe Result GetPhysicalDeviceDisplayProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DisplayProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

