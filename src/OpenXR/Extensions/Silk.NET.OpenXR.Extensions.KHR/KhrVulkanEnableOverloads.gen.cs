// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrVulkanEnableOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanDeviceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, string buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanDeviceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanGraphicsDevice(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle vkInstance, [Count(Count = 0)] Span<Silk.NET.Core.Native.VkHandle> vkPhysicalDevice)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsDevice(instance, systemId, vkInstance, ref vkPhysicalDevice.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanGraphicsRequirements(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Span<GraphicsRequirementsVulkanKHR> graphicsRequirements)
        {
            // SpanOverloader
            return thisApi.GetVulkanGraphicsRequirements(instance, systemId, ref graphicsRequirements.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetVulkanInstanceExtension(this KhrVulkanEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, string buffer)
        {
            // SpanOverloader
            return thisApi.GetVulkanInstanceExtension(instance, systemId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

    }
}

