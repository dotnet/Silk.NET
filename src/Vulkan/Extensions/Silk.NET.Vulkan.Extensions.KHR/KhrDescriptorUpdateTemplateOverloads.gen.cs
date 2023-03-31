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
    public static class KhrDescriptorUpdateTemplateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdPushDescriptorSetWithTemplate<T0>(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CmdPushDescriptorSetWithTemplate(commandBuffer, descriptorUpdateTemplate, layout, set, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, pCreateInfo, in pAllocator.GetPinnableReference(), pDescriptorUpdateTemplate);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), pAllocator, pDescriptorUpdateTemplate);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pDescriptorUpdateTemplate);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorUpdateTemplateCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorUpdateTemplate> pDescriptorUpdateTemplate)
        {
            // SpanOverloader
            return thisApi.CreateDescriptorUpdateTemplate(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pDescriptorUpdateTemplate.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyDescriptorUpdateTemplate(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void UpdateDescriptorSetWithTemplate<T0>(this KhrDescriptorUpdateTemplate thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UpdateDescriptorSetWithTemplate(device, descriptorSet, descriptorUpdateTemplate, ref pData.GetPinnableReference());
        }

    }
}

