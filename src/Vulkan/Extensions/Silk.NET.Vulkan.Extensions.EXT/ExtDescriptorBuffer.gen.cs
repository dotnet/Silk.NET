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
        [NativeApi(EntryPoint = "vkCmdSetDescriptorBufferOffsetsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetDescriptorBufferOffsets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint setCount, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pBufferIndices, [Count(Parameter = "setCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAccelerationStructureOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetBufferOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptor([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorGetInfoEXT* pDescriptorInfo, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pDescriptor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutBindingOffsetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutBindingOffset([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0)] uint binding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSizeEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutSize([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout layout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pLayoutSizeInBytes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageViewOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageViewOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageViewCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSamplerOpaqueCaptureDescriptorDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSamplerOpaqueCaptureDescriptorData([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerCaptureDescriptorDataInfoEXT* pInfo, [Count(Count = 0)] void* pData);

        public ExtDescriptorBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

