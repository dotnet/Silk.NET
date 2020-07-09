// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderStatisticsInfoAMD")]
    public unsafe struct ShaderStatisticsInfoAMD
    {
        public ShaderStatisticsInfoAMD
        (
            ShaderStageFlags shaderStageMask = default,
            ShaderResourceUsageAMD resourceUsage = default,
            uint numPhysicalVgprs = default,
            uint numPhysicalSgprs = default,
            uint numAvailableVgprs = default,
            uint numAvailableSgprs = default
        )
        {
           ShaderStageMask = shaderStageMask;
           ResourceUsage = resourceUsage;
           NumPhysicalVgprs = numPhysicalVgprs;
           NumPhysicalSgprs = numPhysicalSgprs;
           NumAvailableVgprs = numAvailableVgprs;
           NumAvailableSgprs = numAvailableSgprs;
        }

/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "shaderStageMask")]
        public ShaderStageFlags ShaderStageMask;
/// <summary></summary>
        [NativeName("Type", "VkShaderResourceUsageAMD")]
        [NativeName("Type.Name", "VkShaderResourceUsageAMD")]
        [NativeName("Name", "resourceUsage")]
        public ShaderResourceUsageAMD ResourceUsage;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numPhysicalVgprs")]
        public uint NumPhysicalVgprs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numPhysicalSgprs")]
        public uint NumPhysicalSgprs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numAvailableVgprs")]
        public uint NumAvailableVgprs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "numAvailableSgprs")]
        public uint NumAvailableSgprs;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "computeWorkGroupSize")]
       public fixed uint ComputeWorkGroupSize[3];
    }
}
