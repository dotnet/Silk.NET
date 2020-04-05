// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct SamplerYcbcrConversionCreateInfoKHR
    {
        public SamplerYcbcrConversionCreateInfoKHR
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public SamplerYcbcrModelConversion YcbcrModel;
/// <summary></summary>
        public SamplerYcbcrRange YcbcrRange;
/// <summary></summary>
        public ComponentMapping Components;
/// <summary></summary>
        public ChromaLocation XChromaOffset;
/// <summary></summary>
        public ChromaLocation YChromaOffset;
/// <summary></summary>
        public Filter ChromaFilter;
/// <summary></summary>
        public Bool32 ForceExplicitReconstruction;
    }
}
