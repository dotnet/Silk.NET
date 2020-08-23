// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineRasterizationStateCreateInfo")]
    public unsafe partial struct PipelineRasterizationStateCreateInfo
    {
        public PipelineRasterizationStateCreateInfo
        (
            StructureType sType = StructureType.PipelineRasterizationStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            Bool32 depthClampEnable = default,
            Bool32 rasterizerDiscardEnable = default,
            PolygonMode polygonMode = default,
            CullModeFlags cullMode = default,
            FrontFace frontFace = default,
            Bool32 depthBiasEnable = default,
            float depthBiasConstantFactor = default,
            float depthBiasClamp = default,
            float depthBiasSlopeFactor = default,
            float lineWidth = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            DepthClampEnable = depthClampEnable;
            RasterizerDiscardEnable = rasterizerDiscardEnable;
            PolygonMode = polygonMode;
            CullMode = cullMode;
            FrontFace = frontFace;
            DepthBiasEnable = depthBiasEnable;
            DepthBiasConstantFactor = depthBiasConstantFactor;
            DepthBiasClamp = depthBiasClamp;
            DepthBiasSlopeFactor = depthBiasSlopeFactor;
            LineWidth = lineWidth;
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
    }
}
