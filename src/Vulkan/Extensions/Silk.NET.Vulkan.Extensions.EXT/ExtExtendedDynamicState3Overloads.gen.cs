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
    public static class ExtExtendedDynamicState3Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorBlendAdvance(this ExtExtendedDynamicState3 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorBlendAdvancedEXT> pColorBlendAdvanced)
        {
            // SpanOverloader
            thisApi.CmdSetColorBlendAdvance(commandBuffer, firstAttachment, attachmentCount, in pColorBlendAdvanced.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorBlendEnable(this ExtExtendedDynamicState3 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Bool32> pColorBlendEnables)
        {
            // SpanOverloader
            thisApi.CmdSetColorBlendEnable(commandBuffer, firstAttachment, attachmentCount, in pColorBlendEnables.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorBlendEquation(this ExtExtendedDynamicState3 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorBlendEquationEXT> pColorBlendEquations)
        {
            // SpanOverloader
            thisApi.CmdSetColorBlendEquation(commandBuffer, firstAttachment, attachmentCount, in pColorBlendEquations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorWriteMask(this ExtExtendedDynamicState3 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorComponentFlags> pColorWriteMasks)
        {
            // SpanOverloader
            thisApi.CmdSetColorWriteMask(commandBuffer, firstAttachment, attachmentCount, in pColorWriteMasks.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetCoverageModulationTable(this ExtExtendedDynamicState3 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint coverageModulationTableCount, [Count(Parameter = "coverageModulationTableCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pCoverageModulationTable)
        {
            // SpanOverloader
            thisApi.CmdSetCoverageModulationTable(commandBuffer, coverageModulationTableCount, in pCoverageModulationTable.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetSampleMask(this ExtExtendedDynamicState3 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SampleCountFlags samples, [Count(Computed = "latexmath:[\\lceil{\\mathit{samples} \\over 32}\\rceil]"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSampleMask)
        {
            // SpanOverloader
            thisApi.CmdSetSampleMask(commandBuffer, samples, in pSampleMask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetViewportSwizzle(this ExtExtendedDynamicState3 thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewportSwizzleNV> pViewportSwizzles)
        {
            // SpanOverloader
            thisApi.CmdSetViewportSwizzle(commandBuffer, firstViewport, viewportCount, in pViewportSwizzles.GetPinnableReference());
        }

    }
}

