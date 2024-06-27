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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrMaintenance6Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindDescriptorBufferEmbeddedSamplers2(this KhrMaintenance6 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindDescriptorBufferEmbeddedSamplersInfoEXT> pBindDescriptorBufferEmbeddedSamplersInfo)
        {
            // SpanOverloader
            thisApi.CmdBindDescriptorBufferEmbeddedSamplers2(commandBuffer, in pBindDescriptorBufferEmbeddedSamplersInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindDescriptorSets2(this KhrMaintenance6 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindDescriptorSetsInfoKHR> pBindDescriptorSetsInfo)
        {
            // SpanOverloader
            thisApi.CmdBindDescriptorSets2(commandBuffer, in pBindDescriptorSetsInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPushConstants2(this KhrMaintenance6 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PushConstantsInfoKHR> pPushConstantsInfo)
        {
            // SpanOverloader
            thisApi.CmdPushConstants2(commandBuffer, in pPushConstantsInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPushDescriptorSet2(this KhrMaintenance6 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PushDescriptorSetInfoKHR> pPushDescriptorSetInfo)
        {
            // SpanOverloader
            thisApi.CmdPushDescriptorSet2(commandBuffer, in pPushDescriptorSetInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPushDescriptorSetWithTemplate2(this KhrMaintenance6 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PushDescriptorSetWithTemplateInfoKHR> pPushDescriptorSetWithTemplateInfo)
        {
            // SpanOverloader
            thisApi.CmdPushDescriptorSetWithTemplate2(commandBuffer, in pPushDescriptorSetWithTemplateInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDescriptorBufferOffsets2(this KhrMaintenance6 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SetDescriptorBufferOffsetsInfoEXT> pSetDescriptorBufferOffsetsInfo)
        {
            // SpanOverloader
            thisApi.CmdSetDescriptorBufferOffsets2(commandBuffer, in pSetDescriptorBufferOffsetsInfo.GetPinnableReference());
        }

    }
}

