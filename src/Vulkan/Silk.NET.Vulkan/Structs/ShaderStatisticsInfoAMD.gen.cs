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
        public ShaderStageFlags ShaderStageMask;
/// <summary></summary>
        public ShaderResourceUsageAMD ResourceUsage;
/// <summary></summary>
        public uint NumPhysicalVgprs;
/// <summary></summary>
        public uint NumPhysicalSgprs;
/// <summary></summary>
        public uint NumAvailableVgprs;
/// <summary></summary>
        public uint NumAvailableSgprs;
        /// <summary></summary>
       public fixed uint ComputeWorkGroupSize[3];
    }
}
