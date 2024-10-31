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
    [NativeName("Name", "VkPipelineRasterizationConservativeStateCreateInfoEXT")]
    public unsafe partial struct PipelineRasterizationConservativeStateCreateInfoEXT : IExtendsChain<PipelineRasterizationStateCreateInfo>
    {
        public PipelineRasterizationConservativeStateCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineRasterizationConservativeStateCreateInfoExt,
            void* pNext = null,
            uint? flags = null,
            ConservativeRasterizationModeEXT? conservativeRasterizationMode = null,
            float? extraPrimitiveOverestimationSize = null
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

            if (conservativeRasterizationMode is not null)
            {
                ConservativeRasterizationMode = conservativeRasterizationMode.Value;
            }

            if (extraPrimitiveOverestimationSize is not null)
            {
                ExtraPrimitiveOverestimationSize = extraPrimitiveOverestimationSize.Value;
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
        [NativeName("Type", "VkPipelineRasterizationConservativeStateCreateFlagsEXT")]
        [NativeName("Type.Name", "VkPipelineRasterizationConservativeStateCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkConservativeRasterizationModeEXT")]
        [NativeName("Type.Name", "VkConservativeRasterizationModeEXT")]
        [NativeName("Name", "conservativeRasterizationMode")]
        public ConservativeRasterizationModeEXT ConservativeRasterizationMode;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "extraPrimitiveOverestimationSize")]
        public float ExtraPrimitiveOverestimationSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineRasterizationConservativeStateCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
