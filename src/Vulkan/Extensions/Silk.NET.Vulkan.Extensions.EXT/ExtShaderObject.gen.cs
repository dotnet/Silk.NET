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
    [Extension("VK_EXT_shader_object")]
    public unsafe partial class ExtShaderObject : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_shader_object";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindShadersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindShaders([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint stageCount, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderStageFlags* pStages, [Count(Parameter = "stageCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderEXT* pShaders);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBindVertexBuffers2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pOffsets, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSizes, [Count(Parameter = "bindingCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pStrides);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetAlphaToCoverageEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetAlphaToCoverageEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 alphaToCoverageEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetAlphaToOneEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetAlphaToOneEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 alphaToOneEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorBlendAdvancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorBlendAdvance([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorBlendAdvancedEXT* pColorBlendAdvanced);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorBlendEnableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorBlendEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Bool32* pColorBlendEnables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorBlendEquationEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorBlendEquation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorBlendEquationEXT* pColorBlendEquations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorComponentFlags* pColorWriteMasks);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetConservativeRasterizationModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetConservativeRasterizationMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ConservativeRasterizationModeEXT conservativeRasterizationMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoverageModulationModeNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCoverageModulationMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoverageModulationModeNV coverageModulationMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoverageModulationTableNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetCoverageModulationTable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint coverageModulationTableCount, [Count(Parameter = "coverageModulationTableCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pCoverageModulationTable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoverageModulationTableEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCoverageModulationTableEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 coverageModulationTableEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoverageReductionModeNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCoverageReductionMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoverageReductionModeNV coverageReductionMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoverageToColorEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCoverageToColorEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 coverageToColorEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoverageToColorLocationNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCoverageToColorLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint coverageToColorLocation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCullModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCullMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CullModeFlags cullMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBiasEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthBiasEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthBiasEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthBoundsTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthBoundsTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthClampEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthClampEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthClampEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthClipEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthClipEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthClipEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthClipNegativeOneToOneEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthClipNegativeOneToOne([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 negativeOneToOne);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthCompareOpEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthCompareOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CompareOp depthCompareOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthTestEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthWriteEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthWriteEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthWriteEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExtraPrimitiveOverestimationSizeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetExtraPrimitiveOverestimationSize([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float extraPrimitiveOverestimationSize);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFrontFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetFrontFace([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] FrontFace frontFace);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineRasterizationModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLineRasterizationMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] LineRasterizationModeEXT lineRasterizationMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineStippleEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLineStippleEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 stippledLineEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLogicOpEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLogicOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] LogicOp logicOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLogicOpEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLogicOpEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 logicOpEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPatchControlPointsEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPatchControlPoints([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint patchControlPoints);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPolygonModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPolygonMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PolygonMode polygonMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPrimitiveRestartEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPrimitiveRestartEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 primitiveRestartEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPrimitiveTopologyEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPrimitiveTopology([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PrimitiveTopology primitiveTopology);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetProvokingVertexModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetProvokingVertexMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ProvokingVertexModeEXT provokingVertexMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRasterizationSamplesEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRasterizationSamples([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SampleCountFlags rasterizationSamples);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRasterizationStreamEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRasterizationStream([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint rasterizationStream);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRasterizerDiscardEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRasterizerDiscardEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 rasterizerDiscardEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRepresentativeFragmentTestEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRepresentativeFragmentTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 representativeFragmentTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetSampleLocationsEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 sampleLocationsEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleMaskEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetSampleMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SampleCountFlags samples, [Count(Computed = "latexmath:[\\lceil{\\mathit{samples} \\over 32}\\rceil]"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSampleMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissorWithCountEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetScissorWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetShadingRateImageEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetShadingRateImageEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 shadingRateImageEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilOpEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetStencilOp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] StencilOp failOp, [Count(Count = 0)] StencilOp passOp, [Count(Count = 0)] StencilOp depthFailOp, [Count(Count = 0)] CompareOp compareOp);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilTestEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetStencilTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 stencilTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetTessellationDomainOriginEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetTessellationDomainOrigin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] TessellationDomainOrigin domainOrigin);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetVertexInputEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetVertexInput([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputBindingDescription2EXT* pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputAttributeDescription2EXT* pVertexAttributeDescriptions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportSwizzleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetViewportSwizzle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewportSwizzleNV* pViewportSwizzles);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWithCountEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetViewportWithCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetViewportWScalingEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 viewportWScalingEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShadersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateShaders([Count(Count = 0)] Device device, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderCreateInfoEXT* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShaderEXT* pShaders);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyShader([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderEXT shader, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetShaderBinaryDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetShaderBinaryData([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderEXT shader, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        public ExtShaderObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

