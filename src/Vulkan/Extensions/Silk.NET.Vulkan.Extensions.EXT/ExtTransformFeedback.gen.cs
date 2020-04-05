// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_transform_feedback")]
    public abstract unsafe partial class ExtTransformFeedback : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBeginQueryIndexedEXT")]
        public abstract void CmdBeginQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags, [Count(Count = 0)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        public abstract unsafe void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        public abstract void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref ulong pCounterBufferOffsets);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public abstract unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public abstract void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pSizes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdDrawIndirectByteCountEXT")]
        public abstract void CmdDrawIndirectByteCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] Buffer counterBuffer, [Count(Count = 0)] ulong counterBufferOffset, [Count(Count = 0)] uint counterOffset, [Count(Count = 0)] uint vertexStride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdEndQueryIndexedEXT")]
        public abstract void CmdEndQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        public abstract unsafe void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        public abstract void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref ulong pCounterBufferOffsets);

        public ExtTransformFeedback(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

