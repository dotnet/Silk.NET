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
    public static class NVDeviceGeneratedCommandsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdExecuteGeneratedCommands(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsInfoNV> pGeneratedCommandsInfo)
        {
            // SpanOverloader
            thisApi.CmdExecuteGeneratedCommands(commandBuffer, isPreprocessed, in pGeneratedCommandsInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPreprocessGeneratedCommands(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsInfoNV> pGeneratedCommandsInfo)
        {
            // SpanOverloader
            thisApi.CmdPreprocessGeneratedCommands(commandBuffer, in pGeneratedCommandsInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutNV> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, pCreateInfo, pAllocator, out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), pIndirectCommandsLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutNV> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, pIndirectCommandsLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutNV> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pIndirectCommandsLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoNV> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutNV> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyIndirectCommandsLayout(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyIndirectCommandsLayout(device, indirectCommandsLayout, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetGeneratedCommandsMemoryRequirements(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetGeneratedCommandsMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetGeneratedCommandsMemoryRequirements(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsMemoryRequirementsInfoNV> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetGeneratedCommandsMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetGeneratedCommandsMemoryRequirements(this NVDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsMemoryRequirementsInfoNV> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetGeneratedCommandsMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

    }
}

