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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVDeviceGeneratedCommandsComputeOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe ulong GetPipelineIndirectDeviceAddress(this NVDeviceGeneratedCommandsCompute thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineIndirectDeviceAddressInfoNV> pInfo)
        {
            // SpanOverloader
            return thisApi.GetPipelineIndirectDeviceAddress(device, in pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetPipelineIndirectMemoryRequirements(this NVDeviceGeneratedCommandsCompute thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetPipelineIndirectMemoryRequirements(device, pCreateInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetPipelineIndirectMemoryRequirements(this NVDeviceGeneratedCommandsCompute thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetPipelineIndirectMemoryRequirements(device, in pCreateInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetPipelineIndirectMemoryRequirements(this NVDeviceGeneratedCommandsCompute thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetPipelineIndirectMemoryRequirements(device, in pCreateInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

    }
}

