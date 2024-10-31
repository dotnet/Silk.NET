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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtDeviceGeneratedCommandsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdExecuteGeneratedCommands(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsInfoEXT> pGeneratedCommandsInfo)
        {
            // SpanOverloader
            thisApi.CmdExecuteGeneratedCommands(commandBuffer, isPreprocessed, in pGeneratedCommandsInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdPreprocessGeneratedCommands(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsInfoEXT> pGeneratedCommandsInfo, [Count(Count = 0)] CommandBuffer stateCommandBuffer)
        {
            // SpanOverloader
            thisApi.CmdPreprocessGeneratedCommands(commandBuffer, in pGeneratedCommandsInfo.GetPinnableReference(), stateCommandBuffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutEXT> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, pCreateInfo, pAllocator, out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutEXT* pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), pIndirectCommandsLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutEXT> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutEXT* pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, pIndirectCommandsLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutEXT> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutEXT* pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pIndirectCommandsLayout);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectCommandsLayoutCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectCommandsLayoutEXT> pIndirectCommandsLayout)
        {
            // SpanOverloader
            return thisApi.CreateIndirectCommandsLayout(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pIndirectCommandsLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectExecutionSetCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectExecutionSetEXT> pIndirectExecutionSet)
        {
            // SpanOverloader
            return thisApi.CreateIndirectExecutionSet(device, pCreateInfo, pAllocator, out pIndirectExecutionSet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectExecutionSetCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectExecutionSetEXT* pIndirectExecutionSet)
        {
            // SpanOverloader
            return thisApi.CreateIndirectExecutionSet(device, pCreateInfo, in pAllocator.GetPinnableReference(), pIndirectExecutionSet);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectExecutionSetCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectExecutionSetEXT> pIndirectExecutionSet)
        {
            // SpanOverloader
            return thisApi.CreateIndirectExecutionSet(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pIndirectExecutionSet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectExecutionSetCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectExecutionSetEXT* pIndirectExecutionSet)
        {
            // SpanOverloader
            return thisApi.CreateIndirectExecutionSet(device, in pCreateInfo.GetPinnableReference(), pAllocator, pIndirectExecutionSet);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectExecutionSetCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectExecutionSetEXT> pIndirectExecutionSet)
        {
            // SpanOverloader
            return thisApi.CreateIndirectExecutionSet(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pIndirectExecutionSet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectExecutionSetCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectExecutionSetEXT* pIndirectExecutionSet)
        {
            // SpanOverloader
            return thisApi.CreateIndirectExecutionSet(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pIndirectExecutionSet);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IndirectExecutionSetCreateInfoEXT> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<IndirectExecutionSetEXT> pIndirectExecutionSet)
        {
            // SpanOverloader
            return thisApi.CreateIndirectExecutionSet(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pIndirectExecutionSet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyIndirectCommandsLayout(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutEXT indirectCommandsLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyIndirectCommandsLayout(device, indirectCommandsLayout, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyIndirectExecutionSet(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyIndirectExecutionSet(device, indirectExecutionSet, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetGeneratedCommandsMemoryRequirements(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoEXT* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetGeneratedCommandsMemoryRequirements(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetGeneratedCommandsMemoryRequirements(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsMemoryRequirementsInfoEXT> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetGeneratedCommandsMemoryRequirements(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetGeneratedCommandsMemoryRequirements(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeneratedCommandsMemoryRequirementsInfoEXT> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetGeneratedCommandsMemoryRequirements(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void UpdateIndirectExecutionSetPipeline(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0)] uint executionSetWriteCount, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WriteIndirectExecutionSetPipelineEXT> pExecutionSetWrites)
        {
            // SpanOverloader
            thisApi.UpdateIndirectExecutionSetPipeline(device, indirectExecutionSet, executionSetWriteCount, in pExecutionSetWrites.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void UpdateIndirectExecutionSetShader(this ExtDeviceGeneratedCommands thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] IndirectExecutionSetEXT indirectExecutionSet, [Count(Count = 0)] uint executionSetWriteCount, [Count(Parameter = "executionSetWriteCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WriteIndirectExecutionSetShaderEXT> pExecutionSetWrites)
        {
            // SpanOverloader
            thisApi.UpdateIndirectExecutionSetShader(device, indirectExecutionSet, executionSetWriteCount, in pExecutionSetWrites.GetPinnableReference());
        }

    }
}

