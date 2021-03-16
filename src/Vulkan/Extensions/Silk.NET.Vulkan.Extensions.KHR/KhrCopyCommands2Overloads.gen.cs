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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrCopyCommands2Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBlitImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<BlitImageInfo2KHR> pBlitImageInfo)
        {
            // SpanOverloader
            thisApi.CmdBlitImage2(commandBuffer, in pBlitImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBuffer2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyBufferInfo2KHR> pCopyBufferInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyBuffer2(commandBuffer, in pCopyBufferInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyBufferToImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyBufferToImageInfo2KHR> pCopyBufferToImageInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyBufferToImage2(commandBuffer, in pCopyBufferToImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyImageInfo2KHR> pCopyImageInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyImage2(commandBuffer, in pCopyImageInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdCopyImageToBuffer2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<CopyImageToBufferInfo2KHR> pCopyImageToBufferInfo)
        {
            // SpanOverloader
            thisApi.CmdCopyImageToBuffer2(commandBuffer, in pCopyImageToBufferInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdResolveImage2(this KhrCopyCommands2 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ResolveImageInfo2KHR> pResolveImageInfo)
        {
            // SpanOverloader
            thisApi.CmdResolveImage2(commandBuffer, in pResolveImageInfo.GetPinnableReference());
        }

    }
}

