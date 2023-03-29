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
    public static class ExtDescriptorBufferOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindDescriptorBuffers(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint bufferCount, [Count(Parameter = "bufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<DescriptorBufferBindingInfoEXT> pBindingInfos)
        {
            // SpanOverloader
            thisApi.CmdBindDescriptorBuffers(commandBuffer, bufferCount, in pBindingInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDescriptorBufferOffsets(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(FlowDirection.In)] uint* pBufferIndices, [Count(Parameter = "setCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // SpanOverloader
            thisApi.CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDescriptorBufferOffsets(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> pBufferIndices, [Count(Parameter = "setCount"), Flow(FlowDirection.In)] ulong* pOffsets)
        {
            // SpanOverloader
            thisApi.CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, in pBufferIndices.GetPinnableReference(), pOffsets);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDescriptorBufferOffsets(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> pBufferIndices, [Count(Parameter = "setCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // SpanOverloader
            thisApi.CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, in pBufferIndices.GetPinnableReference(), in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAccelerationStructureOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pDataSpp = pData)
                return thisApi.GetAccelerationStructureOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pDataSpp);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetBufferOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<BufferCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pDataSpp = pData)
                return thisApi.GetBufferOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pDataSpp);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptor<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DescriptorGetInfoEXT> pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pDescriptor) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pDescriptorSpp = pDescriptor)
                thisApi.GetDescriptor(device, in pDescriptorInfo.GetPinnableReference(), dataSize, pDescriptorSpp);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptorSetLayoutBindingOffset(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0)] uint binding, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pOffset)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutBindingOffset(device, layout, binding, out pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptorSetLayoutSize(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pLayoutSizeInBytes)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSize(device, layout, out pLayoutSizeInBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImageCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pDataSpp = pData)
                return thisApi.GetImageOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pDataSpp);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageViewOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImageViewCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pDataSpp = pData)
                return thisApi.GetImageViewOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pDataSpp);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSamplerOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SamplerCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pDataSpp = pData)
                return thisApi.GetSamplerOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pDataSpp);
        }

    }
}

