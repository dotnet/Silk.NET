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

namespace Silk.NET.Vulkan.Extensions.VALVE
{
    public static class ValveDescriptorSetHostMappingOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pHostMapping = new(StructureType.DescriptorSetLayoutHostMappingInfoValve);")]
        public static unsafe void GetDescriptorSetLayoutHostMappingInfoValve(this ValveDescriptorSetHostMapping thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetBindingReferenceVALVE* pBindingReference, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayoutHostMappingInfoVALVE> pHostMapping)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutHostMappingInfoValve(device, pBindingReference, out pHostMapping.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetDescriptorSetLayoutHostMappingInfoValve(this ValveDescriptorSetHostMapping thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetBindingReferenceVALVE> pBindingReference, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutHostMappingInfoValve(device, in pBindingReference.GetPinnableReference(), pHostMapping);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pHostMapping = new(StructureType.DescriptorSetLayoutHostMappingInfoValve);")]
        public static unsafe void GetDescriptorSetLayoutHostMappingInfoValve(this ValveDescriptorSetHostMapping thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorSetBindingReferenceVALVE> pBindingReference, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DescriptorSetLayoutHostMappingInfoVALVE> pHostMapping)
        {
            // SpanOverloader
            thisApi.GetDescriptorSetLayoutHostMappingInfoValve(device, in pBindingReference.GetPinnableReference(), out pHostMapping.GetPinnableReference());
        }

    }
}

