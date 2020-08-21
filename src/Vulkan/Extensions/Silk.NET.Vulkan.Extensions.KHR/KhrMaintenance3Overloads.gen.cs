// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrMaintenance3Overloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void GetDescriptorSetLayoutSupport(this KhrMaintenance3 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DescriptorSetLayoutSupport> pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, pCreateInfo, out pSupport.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetDescriptorSetLayoutSupport(this KhrMaintenance3 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, in pCreateInfo.GetPinnableReference(), pSupport);
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetDescriptorSetLayoutSupport(this KhrMaintenance3 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DescriptorSetLayoutCreateInfo> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DescriptorSetLayoutSupport> pSupport)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutSupport(device, in pCreateInfo.GetPinnableReference(), out pSupport.GetPinnableReference());
        }

    }
}

