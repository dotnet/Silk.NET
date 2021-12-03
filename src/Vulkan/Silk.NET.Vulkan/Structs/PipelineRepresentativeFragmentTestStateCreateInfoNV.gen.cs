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
    [NativeName("Name", "VkPipelineRepresentativeFragmentTestStateCreateInfoNV")]
    public unsafe partial struct PipelineRepresentativeFragmentTestStateCreateInfoNV : IExtendsChain<GraphicsPipelineCreateInfo>
    {
        public PipelineRepresentativeFragmentTestStateCreateInfoNV
        (
            StructureType? sType = StructureType.PipelineRepresentativeFragmentTestStateCreateInfoNV,
            void* pNext = null,
            Bool32? representativeFragmentTestEnable = null
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

            if (representativeFragmentTestEnable is not null)
            {
                RepresentativeFragmentTestEnable = representativeFragmentTestEnable.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "representativeFragmentTestEnable")]
        public Bool32 RepresentativeFragmentTestEnable;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineRepresentativeFragmentTestStateCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
