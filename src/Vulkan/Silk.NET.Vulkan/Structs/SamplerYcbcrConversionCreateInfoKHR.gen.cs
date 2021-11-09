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
    [NativeName("Name", "VkSamplerYcbcrConversionCreateInfoKHR")]
    [NativeName("AliasOf", "VkSamplerYcbcrConversionCreateInfo")]
    public unsafe partial struct SamplerYcbcrConversionCreateInfoKHR : IChainStart
    {
        public SamplerYcbcrConversionCreateInfoKHR
        (
            StructureType? sType = StructureType.SamplerYcbcrConversionCreateInfo,
            void* pNext = null,
            Format? format = null,
            SamplerYcbcrModelConversion? ycbcrModel = null,
            SamplerYcbcrRange? ycbcrRange = null,
            ComponentMapping? components = null,
            ChromaLocation? xChromaOffset = null,
            ChromaLocation? yChromaOffset = null,
            Filter? chromaFilter = null,
            Bool32? forceExplicitReconstruction = null
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (ycbcrModel is not null)
            {
                YcbcrModel = ycbcrModel.Value;
            }

            if (ycbcrRange is not null)
            {
                YcbcrRange = ycbcrRange.Value;
            }

            if (components is not null)
            {
                Components = components.Value;
            }

            if (xChromaOffset is not null)
            {
                XChromaOffset = xChromaOffset.Value;
            }

            if (yChromaOffset is not null)
            {
                YChromaOffset = yChromaOffset.Value;
            }

            if (chromaFilter is not null)
            {
                ChromaFilter = chromaFilter.Value;
            }

            if (forceExplicitReconstruction is not null)
            {
                ForceExplicitReconstruction = forceExplicitReconstruction.Value;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkSamplerYcbcrModelConversion")]
        [NativeName("Type.Name", "VkSamplerYcbcrModelConversion")]
        [NativeName("Name", "ycbcrModel")]
        public SamplerYcbcrModelConversion YcbcrModel;
/// <summary></summary>
        [NativeName("Type", "VkSamplerYcbcrRange")]
        [NativeName("Type.Name", "VkSamplerYcbcrRange")]
        [NativeName("Name", "ycbcrRange")]
        public SamplerYcbcrRange YcbcrRange;
/// <summary></summary>
        [NativeName("Type", "VkComponentMapping")]
        [NativeName("Type.Name", "VkComponentMapping")]
        [NativeName("Name", "components")]
        public ComponentMapping Components;
/// <summary></summary>
        [NativeName("Type", "VkChromaLocation")]
        [NativeName("Type.Name", "VkChromaLocation")]
        [NativeName("Name", "xChromaOffset")]
        public ChromaLocation XChromaOffset;
/// <summary></summary>
        [NativeName("Type", "VkChromaLocation")]
        [NativeName("Type.Name", "VkChromaLocation")]
        [NativeName("Name", "yChromaOffset")]
        public ChromaLocation YChromaOffset;
/// <summary></summary>
        [NativeName("Type", "VkFilter")]
        [NativeName("Type.Name", "VkFilter")]
        [NativeName("Name", "chromaFilter")]
        public Filter ChromaFilter;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "forceExplicitReconstruction")]
        public Bool32 ForceExplicitReconstruction;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SamplerYcbcrConversionCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref SamplerYcbcrConversionCreateInfoKHR Chain(
            out SamplerYcbcrConversionCreateInfoKHR capture)
        {
            capture = new SamplerYcbcrConversionCreateInfoKHR(StructureType.SamplerYcbcrConversionCreateInfo);
            return ref capture;
        }
    }
}
