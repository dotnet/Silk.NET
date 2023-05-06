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
    public static class ExtMultiDrawOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdDrawMult(this ExtMultiDraw thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MultiDrawInfoEXT> pVertexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride)
        {
            // SpanOverloader
            thisApi.CmdDrawMult(commandBuffer, drawCount, in pVertexInfo.GetPinnableReference(), instanceCount, firstInstance, stride);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdDrawMultiIndexed(this ExtMultiDraw thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] MultiDrawIndexedInfoEXT* pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> pVertexOffset)
        {
            // SpanOverloader
            thisApi.CmdDrawMultiIndexed(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, in pVertexOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdDrawMultiIndexed(this ExtMultiDraw thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MultiDrawIndexedInfoEXT> pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pVertexOffset)
        {
            // SpanOverloader
            thisApi.CmdDrawMultiIndexed(commandBuffer, drawCount, in pIndexInfo.GetPinnableReference(), instanceCount, firstInstance, stride, pVertexOffset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdDrawMultiIndexed(this ExtMultiDraw thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint drawCount, [Count(Parameter = "drawCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MultiDrawIndexedInfoEXT> pIndexInfo, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] uint stride, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> pVertexOffset)
        {
            // SpanOverloader
            thisApi.CmdDrawMultiIndexed(commandBuffer, drawCount, in pIndexInfo.GetPinnableReference(), instanceCount, firstInstance, stride, in pVertexOffset.GetPinnableReference());
        }

    }
}

