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
    [NativeName("Name", "VkDepthBiasRepresentationInfoEXT")]
    public unsafe partial struct DepthBiasRepresentationInfoEXT : IExtendsChain<DepthBiasInfoEXT>, IExtendsChain<PipelineRasterizationStateCreateInfo>
    {
        public DepthBiasRepresentationInfoEXT
        (
            StructureType? sType = StructureType.DepthBiasRepresentationInfoExt,
            void* pNext = null,
            DepthBiasRepresentationEXT? depthBiasRepresentation = null,
            Bool32? depthBiasExact = null
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

            if (depthBiasRepresentation is not null)
            {
                DepthBiasRepresentation = depthBiasRepresentation.Value;
            }

            if (depthBiasExact is not null)
            {
                DepthBiasExact = depthBiasExact.Value;
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
        [NativeName("Type", "VkDepthBiasRepresentationEXT")]
        [NativeName("Type.Name", "VkDepthBiasRepresentationEXT")]
        [NativeName("Name", "depthBiasRepresentation")]
        public DepthBiasRepresentationEXT DepthBiasRepresentation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthBiasExact")]
        public Bool32 DepthBiasExact;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DepthBiasRepresentationInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
