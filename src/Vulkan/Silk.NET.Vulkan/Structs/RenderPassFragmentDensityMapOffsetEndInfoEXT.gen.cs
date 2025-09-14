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
    [NativeName("Name", "VkRenderPassFragmentDensityMapOffsetEndInfoEXT")]
    [NativeName("Aliases", "VkSubpassFragmentDensityMapOffsetEndInfoQCOM")]
    public unsafe partial struct RenderPassFragmentDensityMapOffsetEndInfoEXT : IExtendsChain<SubpassEndInfo>, IExtendsChain<SubpassEndInfoKHR>, IExtendsChain<RenderingEndInfoEXT>
    {
        public RenderPassFragmentDensityMapOffsetEndInfoEXT
        (
            StructureType? sType = StructureType.RenderPassFragmentDensityMapOffsetEndInfoExt,
            void* pNext = null,
            uint? fragmentDensityOffsetCount = null,
            Offset2D* pFragmentDensityOffsets = null
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

            if (fragmentDensityOffsetCount is not null)
            {
                FragmentDensityOffsetCount = fragmentDensityOffsetCount.Value;
            }

            if (pFragmentDensityOffsets is not null)
            {
                PFragmentDensityOffsets = pFragmentDensityOffsets;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "fragmentDensityOffsetCount")]
        public uint FragmentDensityOffsetCount;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D*")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "pFragmentDensityOffsets")]
        public Offset2D* PFragmentDensityOffsets;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassFragmentDensityMapOffsetEndInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
