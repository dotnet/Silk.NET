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
    [NativeName("Name", "VkSamplerBorderColorComponentMappingCreateInfoEXT")]
    public unsafe partial struct SamplerBorderColorComponentMappingCreateInfoEXT : IExtendsChain<SamplerCreateInfo>
    {
        public SamplerBorderColorComponentMappingCreateInfoEXT
        (
            StructureType? sType = StructureType.SamplerBorderColorComponentMappingCreateInfoExt,
            void* pNext = null,
            ComponentMapping? components = null,
            Bool32? srgb = null
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

            if (components is not null)
            {
                Components = components.Value;
            }

            if (srgb is not null)
            {
                Srgb = srgb.Value;
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
        [NativeName("Type", "VkComponentMapping")]
        [NativeName("Type.Name", "VkComponentMapping")]
        [NativeName("Name", "components")]
        public ComponentMapping Components;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "srgb")]
        public Bool32 Srgb;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SamplerBorderColorComponentMappingCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
