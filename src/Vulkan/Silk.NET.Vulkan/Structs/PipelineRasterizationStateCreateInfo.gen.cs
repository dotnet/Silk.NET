// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineRasterizationStateCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public Bool32 DepthClampEnable;
/// <summary></summary>
        public Bool32 RasterizerDiscardEnable;
/// <summary></summary>
        public PolygonMode PolygonMode;
/// <summary></summary>
        public CullModeFlags CullMode;
/// <summary></summary>
        public FrontFace FrontFace;
/// <summary></summary>
        public Bool32 DepthBiasEnable;
/// <summary></summary>
        public float DepthBiasConstantFactor;
/// <summary></summary>
        public float DepthBiasClamp;
/// <summary></summary>
        public float DepthBiasSlopeFactor;
/// <summary></summary>
        public float LineWidth;
    }
}
