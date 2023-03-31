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
    public static class ExtDebugMarkerOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdDebugMarkerBegin(this ExtDebugMarker thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugMarkerMarkerInfoEXT> pMarkerInfo)
        {
            // SpanOverloader
            thisApi.CmdDebugMarkerBegin(commandBuffer, in pMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdDebugMarkerInsert(this ExtDebugMarker thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugMarkerMarkerInfoEXT> pMarkerInfo)
        {
            // SpanOverloader
            thisApi.CmdDebugMarkerInsert(commandBuffer, in pMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DebugMarkerSetObjectName(this ExtDebugMarker thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugMarkerObjectNameInfoEXT> pNameInfo)
        {
            // SpanOverloader
            return thisApi.DebugMarkerSetObjectName(device, in pNameInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DebugMarkerSetObjectTag(this ExtDebugMarker thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugMarkerObjectTagInfoEXT> pTagInfo)
        {
            // SpanOverloader
            return thisApi.DebugMarkerSetObjectTag(device, in pTagInfo.GetPinnableReference());
        }

    }
}

