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
    [NativeName("Name", "VkSamplerReductionModeCreateInfoEXT")]
    [NativeName("AliasOf", "VkSamplerReductionModeCreateInfo")]
    public unsafe partial struct SamplerReductionModeCreateInfoEXT : IExtendsChain<SamplerCreateInfo>
    {
        public SamplerReductionModeCreateInfoEXT
        (
            StructureType? sType = StructureType.SamplerReductionModeCreateInfo,
            void* pNext = null,
            SamplerReductionMode? reductionMode = null
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

            if (reductionMode is not null)
            {
                ReductionMode = reductionMode.Value;
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
        [NativeName("Type", "VkSamplerReductionMode")]
        [NativeName("Type.Name", "VkSamplerReductionMode")]
        [NativeName("Name", "reductionMode")]
        public SamplerReductionMode ReductionMode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SamplerReductionModeCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
