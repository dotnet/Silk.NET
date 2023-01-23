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
    [NativeName("Name", "VkPipelineCoverageModulationStateCreateInfoNV")]
    public unsafe partial struct PipelineCoverageModulationStateCreateInfoNV : IExtendsChain<PipelineMultisampleStateCreateInfo>
    {
        public PipelineCoverageModulationStateCreateInfoNV
        (
            StructureType? sType = StructureType.PipelineCoverageModulationStateCreateInfoNV,
            void* pNext = null,
            uint? flags = null,
            CoverageModulationModeNV? coverageModulationMode = null,
            Bool32? coverageModulationTableEnable = null,
            uint? coverageModulationTableCount = null,
            float* pCoverageModulationTable = null
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

            if (coverageModulationMode is not null)
            {
                CoverageModulationMode = coverageModulationMode.Value;
            }

            if (coverageModulationTableEnable is not null)
            {
                CoverageModulationTableEnable = coverageModulationTableEnable.Value;
            }

            if (coverageModulationTableCount is not null)
            {
                CoverageModulationTableCount = coverageModulationTableCount.Value;
            }

            if (pCoverageModulationTable is not null)
            {
                PCoverageModulationTable = pCoverageModulationTable;
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
        [NativeName("Type", "VkPipelineCoverageModulationStateCreateFlagsNV")]
        [NativeName("Type.Name", "VkPipelineCoverageModulationStateCreateFlagsNV")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkCoverageModulationModeNV")]
        [NativeName("Type.Name", "VkCoverageModulationModeNV")]
        [NativeName("Name", "coverageModulationMode")]
        public CoverageModulationModeNV CoverageModulationMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "coverageModulationTableEnable")]
        public Bool32 CoverageModulationTableEnable;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "coverageModulationTableCount")]
        public uint CoverageModulationTableCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pCoverageModulationTable")]
        public float* PCoverageModulationTable;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineCoverageModulationStateCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
