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
        public static unsafe void CmdBindDescriptorBuffers(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint bufferCount, [Count(Parameter = "bufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorBufferBindingInfoEXT> pBindingInfos)
        {
            // SpanOverloader
            thisApi.CmdBindDescriptorBuffers(commandBuffer, bufferCount, in pBindingInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDescriptorBufferOffsets(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // SpanOverloader
            thisApi.CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDescriptorBufferOffsets(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets)
        {
            // SpanOverloader
            thisApi.CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, in pBufferIndices.GetPinnableReference(), pOffsets);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDescriptorBufferOffsets(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // SpanOverloader
            thisApi.CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, in pBufferIndices.GetPinnableReference(), in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAccelerationStructureOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAccelerationStructureOpaqueCaptureDescriptorData(device, pInfo, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAccelerationStructureOpaqueCaptureDescriptorData(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            return thisApi.GetAccelerationStructureOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAccelerationStructureOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AccelerationStructureCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetAccelerationStructureOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetBufferOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetBufferOpaqueCaptureDescriptorData(device, pInfo, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetBufferOpaqueCaptureDescriptorData(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            return thisApi.GetBufferOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetBufferOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetBufferOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptor<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorGetInfoEXT* pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pDescriptor) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetDescriptor(device, pDescriptorInfo, dataSize, ref pDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptor(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorGetInfoEXT> pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pDescriptor)
        {
            // SpanOverloader
            thisApi.GetDescriptor(device, in pDescriptorInfo.GetPinnableReference(), dataSize, pDescriptor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptor<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorGetInfoEXT> pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] Span<T0> pDescriptor) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetDescriptor(device, in pDescriptorInfo.GetPinnableReference(), dataSize, ref pDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptorSetLayoutBindingOffset(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0)] uint binding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pOffset)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutBindingOffset(device, layout, binding, out pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptorSetLayoutSize(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> pLayoutSizeInBytes)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSize(device, layout, out pLayoutSizeInBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetImageOpaqueCaptureDescriptorData(device, pInfo, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageOpaqueCaptureDescriptorData(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            return thisApi.GetImageOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetImageOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageViewOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetImageViewOpaqueCaptureDescriptorData(device, pInfo, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageViewOpaqueCaptureDescriptorData(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageViewCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            return thisApi.GetImageViewOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetImageViewOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageViewCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetImageViewOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSamplerOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSamplerOpaqueCaptureDescriptorData(device, pInfo, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSamplerOpaqueCaptureDescriptorData(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] void* pData)
        {
            // SpanOverloader
            return thisApi.GetSamplerOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSamplerOpaqueCaptureDescriptorData<T0>(this ExtDescriptorBuffer thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerCaptureDescriptorDataInfoEXT> pInfo, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSamplerOpaqueCaptureDescriptorData(device, in pInfo.GetPinnableReference(), ref pData.GetPinnableReference());
        }

    }
}

