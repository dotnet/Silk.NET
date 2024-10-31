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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineRasterizationStateCreateInfo")]
    public unsafe partial struct PipelineRasterizationStateCreateInfo : IChainStart
    {
        public PipelineRasterizationStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineRasterizationStateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            Bool32? depthClampEnable = null,
            Bool32? rasterizerDiscardEnable = null,
            PolygonMode? polygonMode = null,
            CullModeFlags? cullMode = null,
            FrontFace? frontFace = null,
            Bool32? depthBiasEnable = null,
            float? depthBiasConstantFactor = null,
            float? depthBiasClamp = null,
            float? depthBiasSlopeFactor = null,
            float? lineWidth = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (depthClampEnable is not null)
            {
                DepthClampEnable = depthClampEnable.Value;
            }

            if (rasterizerDiscardEnable is not null)
            {
                RasterizerDiscardEnable = rasterizerDiscardEnable.Value;
            }

            if (polygonMode is not null)
            {
                PolygonMode = polygonMode.Value;
            }

            if (cullMode is not null)
            {
                CullMode = cullMode.Value;
            }

            if (frontFace is not null)
            {
                FrontFace = frontFace.Value;
            }

            if (depthBiasEnable is not null)
            {
                DepthBiasEnable = depthBiasEnable.Value;
            }

            if (depthBiasConstantFactor is not null)
            {
                DepthBiasConstantFactor = depthBiasConstantFactor.Value;
            }

            if (depthBiasClamp is not null)
            {
                DepthBiasClamp = depthBiasClamp.Value;
            }

            if (depthBiasSlopeFactor is not null)
            {
                DepthBiasSlopeFactor = depthBiasSlopeFactor.Value;
            }

            if (lineWidth is not null)
            {
                LineWidth = lineWidth.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRasterizationStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineRasterizationStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthClampEnable")]
        public Bool32 DepthClampEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rasterizerDiscardEnable")]
        public Bool32 RasterizerDiscardEnable;
/// <summary></summary>
        [NativeName("Type", "VkPolygonMode")]
        [NativeName("Type.Name", "VkPolygonMode")]
        [NativeName("Name", "polygonMode")]
        public PolygonMode PolygonMode;
/// <summary></summary>
        [NativeName("Type", "VkCullModeFlags")]
        [NativeName("Type.Name", "VkCullModeFlags")]
        [NativeName("Name", "cullMode")]
        public CullModeFlags CullMode;
/// <summary></summary>
        [NativeName("Type", "VkFrontFace")]
        [NativeName("Type.Name", "VkFrontFace")]
        [NativeName("Name", "frontFace")]
        public FrontFace FrontFace;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthBiasEnable")]
        public Bool32 DepthBiasEnable;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasConstantFactor")]
        public float DepthBiasConstantFactor;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasClamp")]
        public float DepthBiasClamp;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasSlopeFactor")]
        public float DepthBiasSlopeFactor;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "lineWidth")]
        public float LineWidth;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineRasterizationStateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref PipelineRasterizationStateCreateInfo Chain(
            out PipelineRasterizationStateCreateInfo capture)
        {
            capture = new PipelineRasterizationStateCreateInfo(StructureType.PipelineRasterizationStateCreateInfo);
            return ref capture;
        }
    }
}
