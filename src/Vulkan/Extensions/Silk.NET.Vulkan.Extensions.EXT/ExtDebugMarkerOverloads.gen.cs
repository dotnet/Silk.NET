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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtDebugMarkerOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void CmdDebugMarkerBegin(this ExtDebugMarker thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugMarkerMarkerInfoEXT> pMarkerInfo)
        {
            // SpanOverloader
            thisApi.CmdDebugMarkerBegin(commandBuffer, in pMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdDebugMarkerInsert(this ExtDebugMarker thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugMarkerMarkerInfoEXT> pMarkerInfo)
        {
            // SpanOverloader
            thisApi.CmdDebugMarkerInsert(commandBuffer, in pMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result DebugMarkerSetObjectName(this ExtDebugMarker thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugMarkerObjectNameInfoEXT> pNameInfo)
        {
            // SpanOverloader
            return thisApi.DebugMarkerSetObjectName(device, in pNameInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result DebugMarkerSetObjectTag(this ExtDebugMarker thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DebugMarkerObjectTagInfoEXT> pTagInfo)
        {
            // SpanOverloader
            return thisApi.DebugMarkerSetObjectTag(device, in pTagInfo.GetPinnableReference());
        }

    }
}

