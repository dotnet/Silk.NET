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
    public static class KhrGetPhysicalDeviceProperties2Overloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFeatures = new(StructureType.PhysicalDeviceFeatures2);")]
        public static unsafe void GetPhysicalDeviceFeatures2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceFeatures2> pFeatures)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceFeatures2(physicalDevice, out pFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFormatProperties = new(StructureType.FormatProperties2);")]
        public static unsafe void GetPhysicalDeviceFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<FormatProperties2> pFormatProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceFormatProperties2(physicalDevice, format, out pFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        public static unsafe Result GetPhysicalDeviceImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageFormatProperties2> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceImageFormatInfo2> pImageFormatInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceImageFormatProperties2(physicalDevice, in pImageFormatInfo.GetPinnableReference(), pImageFormatProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        public static unsafe Result GetPhysicalDeviceImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceImageFormatInfo2> pImageFormatInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageFormatProperties2> pImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceImageFormatProperties2(physicalDevice, in pImageFormatInfo.GetPinnableReference(), out pImageFormatProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryProperties = new(StructureType.PhysicalDeviceMemoryProperties2);")]
        public static unsafe void GetPhysicalDeviceMemoryProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceMemoryProperties2> pMemoryProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceMemoryProperties2(physicalDevice, out pMemoryProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PhysicalDeviceProperties2);")]
        public static unsafe void GetPhysicalDeviceProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PhysicalDeviceProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceProperties2(physicalDevice, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyProperties2> pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, out pQueueFamilyProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, ref pQueueFamilyPropertyCount.GetPinnableReference(), pQueueFamilyProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        public static unsafe void GetPhysicalDeviceQueueFamilyProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<QueueFamilyProperties2> pQueueFamilyProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, ref pQueueFamilyPropertyCount.GetPinnableReference(), out pQueueFamilyProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), pPropertyCount, pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        public static unsafe void GetPhysicalDeviceSparseImageFormatProperties2(this KhrGetPhysicalDeviceProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSparseImageFormatInfo2> pFormatInfo, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageFormatProperties2> pProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, in pFormatInfo.GetPinnableReference(), ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

