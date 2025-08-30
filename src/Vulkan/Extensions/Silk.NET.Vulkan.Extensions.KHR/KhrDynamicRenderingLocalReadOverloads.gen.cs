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
    public static class KhrDynamicRenderingLocalReadOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetRenderingAttachmentLocation(this KhrDynamicRenderingLocalRead thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderingAttachmentLocationInfoKHR> pLocationInfo)
        {
            // SpanOverloader
            thisApi.CmdSetRenderingAttachmentLocation(commandBuffer, in pLocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetRenderingInputAttachmentIndices(this KhrDynamicRenderingLocalRead thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderingInputAttachmentIndexInfoKHR> pInputAttachmentIndexInfo)
        {
            // SpanOverloader
            thisApi.CmdSetRenderingInputAttachmentIndices(commandBuffer, in pInputAttachmentIndexInfo.GetPinnableReference());
        }

    }
}

