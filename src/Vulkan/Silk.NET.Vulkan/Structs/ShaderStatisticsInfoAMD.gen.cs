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
    [NativeName("Name", "VkShaderStatisticsInfoAMD")]
    public unsafe partial struct ShaderStatisticsInfoAMD
    {
        public ShaderStatisticsInfoAMD
        (
            ShaderStageFlags? shaderStageMask = null,
            ShaderResourceUsageAMD? resourceUsage = null,
            uint? numPhysicalVgprs = null,
            uint? numPhysicalSgprs = null,
            uint? numAvailableVgprs = null,
            uint? numAvailableSgprs = null
        ) : this()
        {
            if (shaderStageMask is not null)
            {
                ShaderStageMask = shaderStageMask.Value;
            }

            if (resourceUsage is not null)
            {
                ResourceUsage = resourceUsage.Value;
            }

            if (numPhysicalVgprs is not null)
            {
                NumPhysicalVgprs = numPhysicalVgprs.Value;
            }

            if (numPhysicalSgprs is not null)
            {
                NumPhysicalSgprs = numPhysicalSgprs.Value;
            }

            if (numAvailableVgprs is not null)
            {
                NumAvailableVgprs = numAvailableVgprs.Value;
            }

            if (numAvailableSgprs is not null)
            {
                NumAvailableSgprs = numAvailableSgprs.Value;
            }
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
