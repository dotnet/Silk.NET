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
    [Extension("VK_EXT_extended_dynamic_state3")]
    public unsafe partial class ExtExtendedDynamicState3 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_extended_dynamic_state3";
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
        [NativeApi(EntryPoint = "vkCmdSetColorBlendAdvancedEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetColorBlendAdvance([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ColorBlendAdvancedEXT pColorBlendAdvanced);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorBlendEnableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorBlendEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Bool32* pColorBlendEnables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorBlendEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetColorBlendEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Bool32 pColorBlendEnables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorBlendEquationEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorBlendEquation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorBlendEquationEXT* pColorBlendEquations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorBlendEquationEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetColorBlendEquation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ColorBlendEquationEXT pColorBlendEquations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorComponentFlags* pColorWriteMasks);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetColorWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ColorComponentFlags pColorWriteMasks);

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
        [NativeApi(EntryPoint = "vkCmdSetCoverageModulationTableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCoverageModulationTable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint coverageModulationTableCount, [Count(Parameter = "coverageModulationTableCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pCoverageModulationTable);

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
        [NativeApi(EntryPoint = "vkCmdSetDepthClampEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthClampEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthClampEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthClipEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthClipEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 depthClipEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthClipNegativeOneToOneEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthClipNegativeOneToOne([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 negativeOneToOne);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetExtraPrimitiveOverestimationSizeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetExtraPrimitiveOverestimationSize([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float extraPrimitiveOverestimationSize);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineRasterizationModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLineRasterizationMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] LineRasterizationModeEXT lineRasterizationMode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineStippleEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLineStippleEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 stippledLineEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLogicOpEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLogicOpEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 logicOpEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetPolygonModeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetPolygonMode([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PolygonMode polygonMode);

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
        [NativeApi(EntryPoint = "vkCmdSetRepresentativeFragmentTestEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRepresentativeFragmentTestEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 representativeFragmentTestEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleLocationsEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetSampleLocationsEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 sampleLocationsEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleMaskEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetSampleMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SampleCountFlags samples, [Count(Computed = "latexmath:[\\lceil{\\mathit{samples} \\over 32}\\rceil]"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSampleMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetSampleMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetSampleMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SampleCountFlags samples, [Count(Computed = "latexmath:[\\lceil{\\mathit{samples} \\over 32}\\rceil]"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSampleMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetShadingRateImageEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetShadingRateImageEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 shadingRateImageEnable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetTessellationDomainOriginEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetTessellationDomainOrigin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] TessellationDomainOrigin domainOrigin);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportSwizzleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetViewportSwizzle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewportSwizzleNV* pViewportSwizzles);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportSwizzleNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetViewportSwizzle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewportSwizzleNV pViewportSwizzles);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingEnableNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetViewportWScalingEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 viewportWScalingEnable);

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetColorBlendAdvance([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorBlendAdvancedEXT> pColorBlendAdvanced)
        {
            // ImplicitCountSpanOverloader
            CmdSetColorBlendAdvance(commandBuffer, firstAttachment, (uint) pColorBlendAdvanced.Length, in pColorBlendAdvanced.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetColorBlendEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Bool32> pColorBlendEnables)
        {
            // ImplicitCountSpanOverloader
            CmdSetColorBlendEnable(commandBuffer, firstAttachment, (uint) pColorBlendEnables.Length, in pColorBlendEnables.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetColorBlendEquation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorBlendEquationEXT> pColorBlendEquations)
        {
            // ImplicitCountSpanOverloader
            CmdSetColorBlendEquation(commandBuffer, firstAttachment, (uint) pColorBlendEquations.Length, in pColorBlendEquations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetColorWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstAttachment, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorComponentFlags> pColorWriteMasks)
        {
            // ImplicitCountSpanOverloader
            CmdSetColorWriteMask(commandBuffer, firstAttachment, (uint) pColorWriteMasks.Length, in pColorWriteMasks.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetCoverageModulationTable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "coverageModulationTableCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pCoverageModulationTable)
        {
            // ImplicitCountSpanOverloader
            CmdSetCoverageModulationTable(commandBuffer, (uint) pCoverageModulationTable.Length, in pCoverageModulationTable.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetViewportSwizzle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewportSwizzleNV> pViewportSwizzles)
        {
            // ImplicitCountSpanOverloader
            CmdSetViewportSwizzle(commandBuffer, firstViewport, (uint) pViewportSwizzles.Length, in pViewportSwizzles.GetPinnableReference());
        }

        public ExtExtendedDynamicState3(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

