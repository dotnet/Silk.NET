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
    public static class ExtTransformFeedbackOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void CmdBeginTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBeginTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), pCounterBufferOffsets);
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBeginTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes);
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes);
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes);
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdBindTransformFeedbackBuffers(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // SpanOverloader
            thisApi.CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdEndTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdEndTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), pCounterBufferOffsets);
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdEndTransformFeedback(this ExtTransformFeedback thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // SpanOverloader
            thisApi.CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, in pCounterBuffers.GetPinnableReference(), in pCounterBufferOffsets.GetPinnableReference());
        }

    }
}

