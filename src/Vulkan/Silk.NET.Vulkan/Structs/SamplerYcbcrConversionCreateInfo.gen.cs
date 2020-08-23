// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerYcbcrConversionCreateInfo")]
    public unsafe partial struct SamplerYcbcrConversionCreateInfo
    {
        public SamplerYcbcrConversionCreateInfo
        (
            StructureType sType = StructureType.SamplerYcbcrConversionCreateInfo,
            void* pNext = default,
            Format format = default,
            SamplerYcbcrModelConversion ycbcrModel = default,
            SamplerYcbcrRange ycbcrRange = default,
            ComponentMapping components = default,
            ChromaLocation xChromaOffset = default,
            ChromaLocation yChromaOffset = default,
            Filter chromaFilter = default,
            Bool32 forceExplicitReconstruction = default
        )
        {
            SType = sType;
            PNext = pNext;
            Format = format;
            YcbcrModel = ycbcrModel;
            YcbcrRange = ycbcrRange;
            Components = components;
            XChromaOffset = xChromaOffset;
            YChromaOffset = yChromaOffset;
            ChromaFilter = chromaFilter;
            ForceExplicitReconstruction = forceExplicitReconstruction;
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
    }
}
