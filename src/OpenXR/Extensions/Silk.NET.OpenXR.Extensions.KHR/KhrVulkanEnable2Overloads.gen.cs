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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrVulkanEnable2Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanDevice(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanDevice(instance, createInfo, vulkanDevice, ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanDevice(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanDevice, [Count(Count = 0)] uint* vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanDevice(instance, createInfo, ref vulkanDevice.GetPinnableReference(), vulkanResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanDevice(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanDevice, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanDevice(instance, createInfo, ref vulkanDevice.GetPinnableReference(), ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanDevice(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanDeviceCreateInfoKHR> createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] uint* vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanDevice(instance, in createInfo.GetPinnableReference(), vulkanDevice, vulkanResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanDevice(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanDeviceCreateInfoKHR> createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanDevice(instance, in createInfo.GetPinnableReference(), vulkanDevice, ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanDevice(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanDeviceCreateInfoKHR> createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanDevice, [Count(Count = 0)] uint* vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanDevice(instance, in createInfo.GetPinnableReference(), ref vulkanDevice.GetPinnableReference(), vulkanResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanDevice(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanDeviceCreateInfoKHR> createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanDevice, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanDevice(instance, in createInfo.GetPinnableReference(), ref vulkanDevice.GetPinnableReference(), ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanInstance(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanInstance(instance, createInfo, vulkanInstance, ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanInstance(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanInstance, [Count(Count = 0)] uint* vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanInstance(instance, createInfo, ref vulkanInstance.GetPinnableReference(), vulkanResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanInstance(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanInstance, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanInstance(instance, createInfo, ref vulkanInstance.GetPinnableReference(), ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanInstance(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanInstanceCreateInfoKHR> createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] uint* vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanInstance(instance, in createInfo.GetPinnableReference(), vulkanInstance, vulkanResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanInstance(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanInstanceCreateInfoKHR> createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanInstance(instance, in createInfo.GetPinnableReference(), vulkanInstance, ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanInstance(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanInstanceCreateInfoKHR> createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanInstance, [Count(Count = 0)] uint* vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanInstance(instance, in createInfo.GetPinnableReference(), ref vulkanInstance.GetPinnableReference(), vulkanResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateVulkanInstance(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanInstanceCreateInfoKHR> createInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanInstance, [Count(Count = 0)] Span<uint> vulkanResult)
        {
            // SpanOverloader
            return thisApi.CreateVulkanInstance(instance, in createInfo.GetPinnableReference(), ref vulkanInstance.GetPinnableReference(), ref vulkanResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanGraphicsDevice2(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] VulkanGraphicsDeviceGetInfoKHR* getInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanPhysicalDevice)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsDevice2(instance, getInfo, ref vulkanPhysicalDevice.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanGraphicsDevice2(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanGraphicsDeviceGetInfoKHR> getInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanPhysicalDevice)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsDevice2(instance, in getInfo.GetPinnableReference(), vulkanPhysicalDevice);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanGraphicsDevice2(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VulkanGraphicsDeviceGetInfoKHR> getInfo, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vulkanPhysicalDevice)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsDevice2(instance, in getInfo.GetPinnableReference(), ref vulkanPhysicalDevice.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanGraphicsRequirements2(this KhrVulkanEnable2 thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Span<GraphicsRequirementsVulkanKHR> graphicsRequirements)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsRequirements2(instance, systemId, ref graphicsRequirements.GetPinnableReference());
        }

    }
}

