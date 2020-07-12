// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_extended_dynamic_state")]
    public abstract unsafe partial class ExtExtendedDynamicState : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_extended_dynamic_state";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public abstract unsafe void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public abstract void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref Buffer pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ref ulong pStrides);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCullModeEXT")]
        public abstract void CmdSetCullMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CullModeFlags cullMode);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT")]
        public abstract void CmdSetDepthBoundsTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthBoundsTestEnable);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthCompareOpEXT")]
        public abstract void CmdSetDepthCompareOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CompareOp depthCompareOp);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthTestEnableEXT")]
        public abstract void CmdSetDepthTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthTestEnable);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthWriteEnableEXT")]
        public abstract void CmdSetDepthWriteEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthWriteEnable);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFrontFaceEXT")]
        public abstract void CmdSetFrontFace([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] FrontFace frontFace);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPrimitiveTopologyEXT")]
        public abstract void CmdSetPrimitiveTopology([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PrimitiveTopology primitiveTopology);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissorWithCountEXT")]
        public abstract unsafe void CmdSetScissorWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissorWithCountEXT")]
        public abstract void CmdSetScissorWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] ref Rect2D pScissors);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilOpEXT")]
        public abstract void CmdSetStencilOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] StencilOp failOp, [Count(Count = 0)] StencilOp passOp, [Count(Count = 0)] StencilOp depthFailOp, [Count(Count = 0)] CompareOp compareOp);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilTestEnableEXT")]
        public abstract void CmdSetStencilTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 stencilTestEnable);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWithCountEXT")]
        public abstract unsafe void CmdSetViewportWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWithCountEXT")]
        public abstract void CmdSetViewportWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ref Viewport pViewports);

        public ExtExtendedDynamicState(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

