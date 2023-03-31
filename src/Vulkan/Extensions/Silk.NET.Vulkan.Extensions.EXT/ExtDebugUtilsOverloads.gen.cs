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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtDebugUtilsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginDebugUtilsLabel(this ExtDebugUtils thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsLabelEXT> pLabelInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginDebugUtilsLabel(commandBuffer, in pLabelInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdInsertDebugUtilsLabel(this ExtDebugUtils thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsLabelEXT> pLabelInfo)
        {
            // SpanOverloader
            thisApi.CmdInsertDebugUtilsLabel(commandBuffer, in pLabelInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugUtilsMessengerEXT> pMessenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, pCreateInfo, pAllocator, out pMessenger.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, pCreateInfo, in pAllocator.GetPinnableReference(), pMessenger);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugUtilsMessengerEXT> pMessenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, pCreateInfo, in pAllocator.GetPinnableReference(), out pMessenger.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, in pCreateInfo.GetPinnableReference(), pAllocator, pMessenger);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugUtilsMessengerEXT> pMessenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, in pCreateInfo.GetPinnableReference(), pAllocator, out pMessenger.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pMessenger);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugUtilsMessengerEXT> pMessenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pMessenger.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDebugUtilsMessenger(instance, messenger, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void QueueBeginDebugUtilsLabel(this ExtDebugUtils thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsLabelEXT> pLabelInfo)
        {
            // SpanOverloader
            thisApi.QueueBeginDebugUtilsLabel(queue, in pLabelInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void QueueInsertDebugUtilsLabel(this ExtDebugUtils thisApi, [Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsLabelEXT> pLabelInfo)
        {
            // SpanOverloader
            thisApi.QueueInsertDebugUtilsLabel(queue, in pLabelInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetDebugUtilsObjectName(this ExtDebugUtils thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsObjectNameInfoEXT> pNameInfo)
        {
            // SpanOverloader
            return thisApi.SetDebugUtilsObjectName(device, in pNameInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetDebugUtilsObjectTag(this ExtDebugUtils thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsObjectTagInfoEXT> pTagInfo)
        {
            // SpanOverloader
            return thisApi.SetDebugUtilsObjectTag(device, in pTagInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void SubmitDebugUtilsMessage(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCallbackDataEXT> pCallbackData)
        {
            // SpanOverloader
            thisApi.SubmitDebugUtilsMessage(instance, messageSeverity, messageTypes, in pCallbackData.GetPinnableReference());
        }

    }
}

