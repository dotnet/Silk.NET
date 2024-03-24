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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_maintenance6")]
    public unsafe partial class KhrMaintenance6 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance6";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindDescriptorBufferEmbeddedSamplers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBindDescriptorBufferEmbeddedSamplers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BindDescriptorBufferEmbeddedSamplersInfoEXT pBindDescriptorBufferEmbeddedSamplersInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindDescriptorSets2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BindDescriptorSetsInfoKHR* pBindDescriptorSetsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdBindDescriptorSets2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BindDescriptorSetsInfoKHR pBindDescriptorSetsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPushConstants2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PushConstantsInfoKHR* pPushConstantsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdPushConstants2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PushConstantsInfoKHR pPushConstantsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSet2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPushDescriptorSet2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PushDescriptorSetInfoKHR* pPushDescriptorSetInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSet2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdPushDescriptorSet2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PushDescriptorSetInfoKHR pPushDescriptorSetInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplate2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPushDescriptorSetWithTemplate2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PushDescriptorSetWithTemplateInfoKHR* pPushDescriptorSetWithTemplateInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplate2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdPushDescriptorSetWithTemplate2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PushDescriptorSetWithTemplateInfoKHR pPushDescriptorSetWithTemplateInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDescriptorBufferOffsets2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetDescriptorBufferOffsets2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDescriptorBufferOffsets2EXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDescriptorBufferOffsets2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SetDescriptorBufferOffsetsInfoEXT pSetDescriptorBufferOffsetsInfo);

        public KhrMaintenance6(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

