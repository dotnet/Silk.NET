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
    public static class ExtShaderObjectOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindShaders(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint stageCount, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderStageFlags* pStages, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderEXT> pShaders)
        {
            // SpanOverloader
            thisApi.CmdBindShaders(commandBuffer, stageCount, pStages, in pShaders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindShaders(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint stageCount, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderStageFlags> pStages, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderEXT* pShaders)
        {
            // SpanOverloader
            thisApi.CmdBindShaders(commandBuffer, stageCount, in pStages.GetPinnableReference(), pShaders);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindShaders(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint stageCount, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderStageFlags> pStages, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderEXT> pShaders)
        {
            // SpanOverloader
            thisApi.CmdBindShaders(commandBuffer, stageCount, in pStages.GetPinnableReference(), in pShaders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorBlendAdvance(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorBlendAdvancedEXT> pColorBlendAdvanced)
        {
            // SpanOverloader
            thisApi.CmdSetColorBlendAdvance(commandBuffer, firstAttachment, attachmentCount, in pColorBlendAdvanced.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorBlendEnable(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Bool32> pColorBlendEnables)
        {
            // SpanOverloader
            thisApi.CmdSetColorBlendEnable(commandBuffer, firstAttachment, attachmentCount, in pColorBlendEnables.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorBlendEquation(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorBlendEquationEXT> pColorBlendEquations)
        {
            // SpanOverloader
            thisApi.CmdSetColorBlendEquation(commandBuffer, firstAttachment, attachmentCount, in pColorBlendEquations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorWriteMask(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorComponentFlags> pColorWriteMasks)
        {
            // SpanOverloader
            thisApi.CmdSetColorWriteMask(commandBuffer, firstAttachment, attachmentCount, in pColorWriteMasks.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetCoverageModulationTable(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint coverageModulationTableCount, [Count(Parameter = "coverageModulationTableCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pCoverageModulationTable)
        {
            // SpanOverloader
            thisApi.CmdSetCoverageModulationTable(commandBuffer, coverageModulationTableCount, in pCoverageModulationTable.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetDepthClampRange(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DepthClampModeEXT depthClampMode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DepthClampRangeEXT> pDepthClampRange)
        {
            // SpanOverloader
            thisApi.CmdSetDepthClampRange(commandBuffer, depthClampMode, in pDepthClampRange.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetSampleMask(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SampleCountFlags samples, [Count(Computed = "latexmath:[\\lceil{\\mathit{samples} \\over 32}\\rceil]"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSampleMask)
        {
            // SpanOverloader
            thisApi.CmdSetSampleMask(commandBuffer, samples, in pSampleMask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetScissorWithCount(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Rect2D> pScissors)
        {
            // SpanOverloader
            thisApi.CmdSetScissorWithCount(commandBuffer, scissorCount, in pScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetVertexInput(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputBindingDescription2EXT* pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputAttributeDescription2EXT> pVertexAttributeDescriptions)
        {
            // SpanOverloader
            thisApi.CmdSetVertexInput(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, in pVertexAttributeDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetVertexInput(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputBindingDescription2EXT> pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            // SpanOverloader
            thisApi.CmdSetVertexInput(commandBuffer, vertexBindingDescriptionCount, in pVertexBindingDescriptions.GetPinnableReference(), vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetVertexInput(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputBindingDescription2EXT> pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputAttributeDescription2EXT> pVertexAttributeDescriptions)
        {
            // SpanOverloader
            thisApi.CmdSetVertexInput(commandBuffer, vertexBindingDescriptionCount, in pVertexBindingDescriptions.GetPinnableReference(), vertexAttributeDescriptionCount, in pVertexAttributeDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetViewportSwizzle(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewportSwizzleNV> pViewportSwizzles)
        {
            // SpanOverloader
            thisApi.CmdSetViewportSwizzle(commandBuffer, firstViewport, viewportCount, in pViewportSwizzles.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetViewportWithCount(this ExtShaderObject thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Viewport> pViewports)
        {
            // SpanOverloader
            thisApi.CmdSetViewportWithCount(commandBuffer, viewportCount, in pViewports.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaders(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderCreateInfoEXT* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderEXT> pShaders)
        {
            // SpanOverloader
            return thisApi.CreateShaders(device, createInfoCount, pCreateInfos, pAllocator, out pShaders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaders(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderCreateInfoEXT* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderEXT* pShaders)
        {
            // SpanOverloader
            return thisApi.CreateShaders(device, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), pShaders);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaders(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderCreateInfoEXT* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderEXT> pShaders)
        {
            // SpanOverloader
            return thisApi.CreateShaders(device, createInfoCount, pCreateInfos, in pAllocator.GetPinnableReference(), out pShaders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaders(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderCreateInfoEXT> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderEXT* pShaders)
        {
            // SpanOverloader
            return thisApi.CreateShaders(device, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, pShaders);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaders(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderCreateInfoEXT> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderEXT> pShaders)
        {
            // SpanOverloader
            return thisApi.CreateShaders(device, createInfoCount, in pCreateInfos.GetPinnableReference(), pAllocator, out pShaders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaders(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderCreateInfoEXT> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderEXT* pShaders)
        {
            // SpanOverloader
            return thisApi.CreateShaders(device, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), pShaders);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateShaders(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderCreateInfoEXT> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShaderEXT> pShaders)
        {
            // SpanOverloader
            return thisApi.CreateShaders(device, createInfoCount, in pCreateInfos.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pShaders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyShader(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ShaderEXT shader, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyShader(device, shader, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetShaderBinaryData<T0>(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ShaderEXT shader, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetShaderBinaryData(device, shader, pDataSize, ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetShaderBinaryData(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ShaderEXT shader, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] void* pData)
        {
            // SpanOverloader
            return thisApi.GetShaderBinaryData(device, shader, ref pDataSize.GetPinnableReference(), pData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetShaderBinaryData<T0>(this ExtShaderObject thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ShaderEXT shader, [Count(Count = 0)] Span<nuint> pDataSize, [Count(Parameter = "pDataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetShaderBinaryData(device, shader, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
        }

    }
}

