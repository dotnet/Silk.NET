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
    [Extension("VK_EXT_descriptor_buffer")]
    public unsafe partial class ExtDescriptorBuffer : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_descriptor_buffer";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplersEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBindDescriptorBufferEmbeddedSamplers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindDescriptorBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint bufferCount, [Count(Parameter = "bufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorBufferBindingInfoEXT* pBindingInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorBuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBindDescriptorBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint bufferCount, [Count(Parameter = "bufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorBufferBindingInfoEXT pBindingInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAccelerationStructureOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAccelerationStructureOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAccelerationStructureOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetAccelerationStructureOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AccelerationStructureCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetBufferOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetBufferOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetBufferOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetBufferOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorGetInfoEXT* pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pDescriptor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptor<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorGetInfoEXT* pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pDescriptor) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorGetInfoEXT pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pDescriptor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDescriptor<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorGetInfoEXT pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pDescriptor) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutBindingOffsetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutBindingOffset([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0)] uint binding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutBindingOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDescriptorSetLayoutBindingOffset([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0)] uint binding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSizeEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutSize([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pLayoutSizeInBytes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSizeEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDescriptorSetLayoutSize([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pLayoutSizeInBytes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetImageOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageViewOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageViewOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageViewOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageViewCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetImageViewOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageViewCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSamplerOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSamplerOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSamplerOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SamplerCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSamplerOpaqueCaptureDescriptorData<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SamplerCaptureDescriptorDataInfoEXT pInfo, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindDescriptorBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "bufferCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorBufferBindingInfoEXT> pBindingInfos)
        {
            // ImplicitCountSpanOverloader
            CmdBindDescriptorBuffers(commandBuffer, (uint) pBindingInfos.Length, in pBindingInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, (uint) pOffsets.Length, pBufferIndices, in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, (uint) pBufferIndices.Length, in pBufferIndices.GetPinnableReference(), pOffsets);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdSetDescriptorBufferOffsets(commandBuffer, pipelineBindPoint, layout, firstSet, (uint) pOffsets.Length, in pBufferIndices.GetPinnableReference(), in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void GetDescriptor<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorGetInfoEXT* pDescriptorInfo, [Count(Parameter = "dataSize")] Span<T0> pDescriptor) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetDescriptor(device, pDescriptorInfo, (nuint) ((pDescriptor.Length) * Unsafe.SizeOf<T0>()), ref pDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void GetDescriptor<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorGetInfoEXT pDescriptorInfo, [Count(Parameter = "dataSize")] Span<T0> pDescriptor) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetDescriptor(device, in pDescriptorInfo, (nuint) ((pDescriptor.Length) * Unsafe.SizeOf<T0>()), ref pDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe ulong GetDescriptorSetLayoutBindingOffset([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0)] uint binding)
        {
            // NonKhrReturnTypeOverloader
            GetDescriptorSetLayoutBindingOffset(device, layout, binding, out ulong silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public unsafe ulong GetDescriptorSetLayoutSize([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout)
        {
            // NonKhrReturnTypeOverloader
            GetDescriptorSetLayoutSize(device, layout, out ulong silkRet);
            return silkRet;
        }

        public ExtDescriptorBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

