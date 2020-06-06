// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_transform_feedback")]
    public unsafe partial class ExtTransformFeedback : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_transform_feedback";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginQueryIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBeginQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags, [Count(Count = 0)] uint index)
            => ImplCmdBeginQueryIndexed(commandBuffer, queryPool, query, flags, index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets)
            => ImplCmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref ulong pCounterBufferOffsets)
            => ImplCmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes)
            => ImplCmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pSizes)
            => ImplCmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectByteCountEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawIndirectByteCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] Buffer counterBuffer, [Count(Count = 0)] ulong counterBufferOffset, [Count(Count = 0)] uint counterOffset, [Count(Count = 0)] uint vertexStride)
            => ImplCmdDrawIndirectByteCount(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQueryIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdEndQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] uint index)
            => ImplCmdEndQueryIndexed(commandBuffer, queryPool, query, index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] Buffer* pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ulong* pCounterBufferOffsets)
            => ImplCmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref Buffer pCounterBuffers, [Count(Computed = "counterBufferCount"), Flow(FlowDirection.In)] ref ulong pCounterBufferOffsets)
            => ImplCmdEndTransformFeedback(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

        public ExtTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

