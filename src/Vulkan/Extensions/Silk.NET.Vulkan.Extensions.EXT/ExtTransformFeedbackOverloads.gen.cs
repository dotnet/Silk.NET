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
    public static class ExtTransformFeedbackOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), pCounterBufferOffsets);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdEndTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdEndTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), pCounterBufferOffsets);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdEndTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), in pCounterBufferOffsets.GetPinnableReference());
        }

    }
}

