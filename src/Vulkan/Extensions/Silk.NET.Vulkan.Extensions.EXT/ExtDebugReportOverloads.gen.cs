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
    public static class ExtDebugReportOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugReportCallbackEXT> pCallback)
        {
            // SpanOverloader
            return thisApi.CreateDebugReportCallback(instance, pCreateInfo, pAllocator, out pCallback.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugReportCallbackEXT* pCallback)
        {
            // SpanOverloader
            return thisApi.CreateDebugReportCallback(instance, pCreateInfo, in pAllocator.GetPinnableReference(), pCallback);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugReportCallbackEXT> pCallback)
        {
            // SpanOverloader
            return thisApi.CreateDebugReportCallback(instance, pCreateInfo, in pAllocator.GetPinnableReference(), out pCallback.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugReportCallbackCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugReportCallbackEXT* pCallback)
        {
            // SpanOverloader
            return thisApi.CreateDebugReportCallback(instance, in pCreateInfo.GetPinnableReference(), pAllocator, pCallback);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugReportCallbackCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugReportCallbackEXT> pCallback)
        {
            // SpanOverloader
            return thisApi.CreateDebugReportCallback(instance, in pCreateInfo.GetPinnableReference(), pAllocator, out pCallback.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugReportCallbackCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugReportCallbackEXT* pCallback)
        {
            // SpanOverloader
            return thisApi.CreateDebugReportCallback(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pCallback);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugReportCallbackCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugReportCallbackEXT> pCallback)
        {
            // SpanOverloader
            return thisApi.CreateDebugReportCallback(instance, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pCallback.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DebugReportMessage(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pMessage)
        {
            // SpanOverloader
            thisApi.DebugReportMessage(instance, flags, objectType, @object, location, messageCode, pLayerPrefix, in pMessage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DebugReportMessage(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pMessage)
        {
            // SpanOverloader
            thisApi.DebugReportMessage(instance, flags, objectType, @object, location, messageCode, in pLayerPrefix.GetPinnableReference(), pMessage);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DebugReportMessage(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pMessage)
        {
            // SpanOverloader
            thisApi.DebugReportMessage(instance, flags, objectType, @object, location, messageCode, in pLayerPrefix.GetPinnableReference(), in pMessage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DebugReportMessage(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pLayerPrefix, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pMessage)
        {
            // SpanOverloader
            thisApi.DebugReportMessage(instance, flags, objectType, @object, location, messageCode, in pLayerPrefix.GetPinnableReference(), pMessage);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DebugReportMessage(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pMessage)
        {
            // SpanOverloader
            thisApi.DebugReportMessage(instance, flags, objectType, @object, location, messageCode, pLayerPrefix, in pMessage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDebugReportCallback(this ExtDebugReport thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDebugReportCallback(instance, callback, in pAllocator.GetPinnableReference());
        }

    }
}

