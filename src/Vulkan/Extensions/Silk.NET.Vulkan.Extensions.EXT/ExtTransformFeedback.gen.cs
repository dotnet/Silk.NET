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
        [NativeApi(EntryPoint = "vkCmdBeginQueryIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags, [Count(Count = 0)] uint index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pSizes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectByteCountEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawIndirectByteCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstInstance, [Count(Count = 0)] Buffer counterBuffer, [Count(Count = 0)] ulong counterBufferOffset, [Count(Count = 0)] uint counterOffset, [Count(Count = 0)] uint vertexStride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQueryIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdEndQueryIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] uint index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Count = 0)] uint counterBufferCount, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pCounterBufferOffsets);

        /// <summary>To be documented.</summary>
        public unsafe void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, (uint) pCounterBufferOffsets.Length, pCounterBuffers, in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, (uint) pCounterBuffers.Length, in pCounterBuffers.GetPinnableReference(), pCounterBufferOffsets);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBeginTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBeginTransformFeedback(commandBuffer, firstCounterBuffer, (uint) pCounterBufferOffsets.Length, in pCounterBuffers.GetPinnableReference(), in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // ImplicitCountSpanOverloader
            CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, (uint) pSizes.Length, pBuffers, pOffsets, in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes)
        {
            // ImplicitCountSpanOverloader
            CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, (uint) pOffsets.Length, pBuffers, in pOffsets.GetPinnableReference(), pSizes);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // ImplicitCountSpanOverloader
            CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, (uint) pSizes.Length, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes)
        {
            // ImplicitCountSpanOverloader
            CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, (uint) pBuffers.Length, in pBuffers.GetPinnableReference(), pOffsets, pSizes);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // ImplicitCountSpanOverloader
            CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, (uint) pSizes.Length, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes)
        {
            // ImplicitCountSpanOverloader
            CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, (uint) pOffsets.Length, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindTransformFeedbackBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes)
        {
            // ImplicitCountSpanOverloader
            CmdBindTransformFeedbackBuffers(commandBuffer, firstBinding, (uint) pSizes.Length, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, (uint) pCounterBufferOffsets.Length, pCounterBuffers, in pCounterBufferOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pCounterBufferOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, (uint) pCounterBuffers.Length, in pCounterBuffers.GetPinnableReference(), pCounterBufferOffsets);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdEndTransformFeedback([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstCounterBuffer, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pCounterBuffers, [Count(Parameter = "counterBufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pCounterBufferOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdEndTransformFeedback(commandBuffer, firstCounterBuffer, (uint) pCounterBufferOffsets.Length, in pCounterBuffers.GetPinnableReference(), in pCounterBufferOffsets.GetPinnableReference());
        }

        public ExtTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

