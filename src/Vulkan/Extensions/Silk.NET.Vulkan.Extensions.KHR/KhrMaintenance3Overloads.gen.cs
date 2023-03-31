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
    public static class KhrMaintenance3Overloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSupport = new(StructureType.DescriptorSetLayoutSupport);")]
        public static unsafe void GetDescriptorSetLayoutSupport(this KhrMaintenance3 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayoutSupport> pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, pCreateInfo, out pSupport.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptorSetLayoutSupport(this KhrMaintenance3 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, in pCreateInfo.GetPinnableReference(), pSupport);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSupport = new(StructureType.DescriptorSetLayoutSupport);")]
        public static unsafe void GetDescriptorSetLayoutSupport(this KhrMaintenance3 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayoutSupport> pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, in pCreateInfo.GetPinnableReference(), out pSupport.GetPinnableReference());
        }

    }
}

