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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_extended_dynamic_state")]
    public unsafe partial class ExtExtendedDynamicState : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_extended_dynamic_state";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCullModeEXT")]
        public partial void CmdSetCullMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CullModeFlags cullMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT")]
        public partial void CmdSetDepthBoundsTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthBoundsTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthCompareOpEXT")]
        public partial void CmdSetDepthCompareOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CompareOp depthCompareOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthTestEnableEXT")]
        public partial void CmdSetDepthTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthWriteEnableEXT")]
        public partial void CmdSetDepthWriteEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthWriteEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFrontFaceEXT")]
        public partial void CmdSetFrontFace([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] FrontFace frontFace);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPrimitiveTopologyEXT")]
        public partial void CmdSetPrimitiveTopology([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PrimitiveTopology primitiveTopology);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissorWithCountEXT")]
        public unsafe partial void CmdSetScissorWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissorWithCountEXT")]
        public partial void CmdSetScissorWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(FlowDirection.In)] in Rect2D pScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilOpEXT")]
        public partial void CmdSetStencilOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] StencilOp failOp, [Count(Count = 0)] StencilOp passOp, [Count(Count = 0)] StencilOp depthFailOp, [Count(Count = 0)] CompareOp compareOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilTestEnableEXT")]
        public partial void CmdSetStencilTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 stencilTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWithCountEXT")]
        public unsafe partial void CmdSetViewportWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWithCountEXT")]
        public partial void CmdSetViewportWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(FlowDirection.In)] in Viewport pViewports);

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, pBuffers, pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pSizes.Length, pBuffers, pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, pBuffers, pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pOffsets.Length, pBuffers, in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, pBuffers, in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pSizes.Length, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pBuffers.Length, in pBuffers.GetPinnableReference(), pOffsets, pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, in pBuffers.GetPinnableReference(), pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pSizes.Length, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pOffsets.Length, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pSizes.Length, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers2(commandBuffer, firstBinding, (uint) pStrides.Length, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetScissorWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "scissorCount"), Flow(FlowDirection.In)] ReadOnlySpan<Rect2D> pScissors)
        {
            // ImplicitCountSpanOverloader
            CmdSetScissorWithCount(commandBuffer, (uint) pScissors.Length, in pScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetViewportWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "viewportCount"), Flow(FlowDirection.In)] ReadOnlySpan<Viewport> pViewports)
        {
            // ImplicitCountSpanOverloader
            CmdSetViewportWithCount(commandBuffer, (uint) pViewports.Length, in pViewports.GetPinnableReference());
        }

        public ExtExtendedDynamicState(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

