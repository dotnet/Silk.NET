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
    public unsafe struct AndroidHardwareBufferFormatPropertiesANDROID
    {
        public AndroidHardwareBufferFormatPropertiesANDROID
        (
            StructureType sType = StructureType.AndroidHardwareBufferFormatPropertiesAndroid,
            void* pNext = default,
            Format format = default,
            ulong externalFormat = default,
            FormatFeatureFlags formatFeatures = default,
            ComponentMapping samplerYcbcrConversionComponents = default,
            SamplerYcbcrModelConversion suggestedYcbcrModel = default,
            SamplerYcbcrRange suggestedYcbcrRange = default,
            ChromaLocation suggestedXChromaOffset = default,
            ChromaLocation suggestedYChromaOffset = default
        )
        {
           SType = sType;
           PNext = pNext;
           Format = format;
           ExternalFormat = externalFormat;
           FormatFeatures = formatFeatures;
           SamplerYcbcrConversionComponents = samplerYcbcrConversionComponents;
           SuggestedYcbcrModel = suggestedYcbcrModel;
           SuggestedYcbcrRange = suggestedYcbcrRange;
           SuggestedXChromaOffset = suggestedXChromaOffset;
           SuggestedYChromaOffset = suggestedYChromaOffset;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public ulong ExternalFormat;
/// <summary></summary>
        public FormatFeatureFlags FormatFeatures;
/// <summary></summary>
        public ComponentMapping SamplerYcbcrConversionComponents;
/// <summary></summary>
        public SamplerYcbcrModelConversion SuggestedYcbcrModel;
/// <summary></summary>
        public SamplerYcbcrRange SuggestedYcbcrRange;
/// <summary></summary>
        public ChromaLocation SuggestedXChromaOffset;
/// <summary></summary>
        public ChromaLocation SuggestedYChromaOffset;
    }
}
