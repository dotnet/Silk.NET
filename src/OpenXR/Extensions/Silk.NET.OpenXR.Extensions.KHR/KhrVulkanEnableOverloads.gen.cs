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
    public static class KhrVulkanEnableOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanGraphicsDevice(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle vkInstance, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vkPhysicalDevice)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsDevice(instance, systemId, vkInstance, ref vkPhysicalDevice.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanGraphicsRequirements(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Span<GraphicsRequirementsVulkanKHR> graphicsRequirements)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsRequirements(instance, systemId, ref graphicsRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

    }
}

