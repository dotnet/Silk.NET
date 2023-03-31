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
    public static class KhrCopyCommands2Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBlitImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlitImageInfo2> pBlitImageInfo)
        {
            // SpanOverloader
            thisApi.CmdBlitImage2(commandBuffer, in pBlitImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBuffer2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyBufferInfo2> pCopyBufferInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyBuffer2(commandBuffer, in pCopyBufferInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBufferToImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyBufferToImageInfo2> pCopyBufferToImageInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyBufferToImage2(commandBuffer, in pCopyBufferToImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyImageInfo2> pCopyImageInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyImage2(commandBuffer, in pCopyImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImageToBuffer2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyImageToBufferInfo2> pCopyImageToBufferInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyImageToBuffer2(commandBuffer, in pCopyImageToBufferInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdResolveImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResolveImageInfo2> pResolveImageInfo)
        {
            // SpanOverloader
            thisApi.CmdResolveImage2(commandBuffer, in pResolveImageInfo.GetPinnableReference());
        }

    }
}

