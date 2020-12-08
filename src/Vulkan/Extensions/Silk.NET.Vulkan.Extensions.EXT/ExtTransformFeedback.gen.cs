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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_transform_feedback")]
    public unsafe partial class ExtTransformFeedback : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_transform_feedback";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginQueryIndexedEXT")]
        public partial void CmdBeginQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags, [Count(Count = 0)] uint index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        public unsafe partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        public unsafe partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in ulong pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        public unsafe partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        public partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in ulong pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectByteCountEXT")]
        public partial void CmdDrawIndirectByteCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] Buffer counterBuffer, [Count(Count = 0)] ulong counterBufferOffset, [Count(Count = 0)] uint counterOffset, [Count(Count = 0)] uint vertexStride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQueryIndexedEXT")]
        public partial void CmdEndQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] uint index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        public unsafe partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        public unsafe partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in ulong pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        public unsafe partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        public partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] in ulong pCounterBufferOffsets);

        public ExtTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

