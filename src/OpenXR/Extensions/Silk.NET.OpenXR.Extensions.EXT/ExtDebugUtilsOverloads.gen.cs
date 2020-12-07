// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtDebugUtilsOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* createInfo, [Count(Count = 0)] Span<DebugUtilsMessengerEXT> messenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, createInfo, ref messenger.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCreateInfoEXT> createInfo, [Count(Count = 0)] DebugUtilsMessengerEXT* messenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, in createInfo.GetPinnableReference(), messenger);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateDebugUtilsMessenger(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCreateInfoEXT> createInfo, [Count(Count = 0)] Span<DebugUtilsMessengerEXT> messenger)
        {
            // SpanOverloader
            return thisApi.CreateDebugUtilsMessenger(instance, in createInfo.GetPinnableReference(), ref messenger.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result SessionBeginDebugUtilsLabelRegion(this ExtDebugUtils thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugUtilsLabelEXT> labelInfo)
        {
            // SpanOverloader
            return thisApi.SessionBeginDebugUtilsLabelRegion(session, in labelInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result SessionInsertDebugUtilsLabel(this ExtDebugUtils thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugUtilsLabelEXT> labelInfo)
        {
            // SpanOverloader
            return thisApi.SessionInsertDebugUtilsLabel(session, in labelInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result SetDebugUtilsObjectName(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugUtilsObjectNameInfoEXT> nameInfo)
        {
            // SpanOverloader
            return thisApi.SetDebugUtilsObjectName(instance, in nameInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result SubmitDebugUtilsMessage(this ExtDebugUtils thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugUtilsMessengerCallbackDataEXT> callbackData)
        {
            // SpanOverloader
            return thisApi.SubmitDebugUtilsMessage(instance, messageSeverity, messageTypes, in callbackData.GetPinnableReference());
        }

    }
}

