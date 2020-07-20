// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrViewConfigurationView")]
    public unsafe partial struct ViewConfigurationView
    {
        public ViewConfigurationView
        (
            StructureType type = StructureType.TypeViewConfigurationView,
            void* next = default,
            uint recommendedImageRectWidth = default,
            uint maxImageRectWidth = default,
            uint recommendedImageRectHeight = default,
            uint maxImageRectHeight = default,
            uint recommendedSwapchainSampleCount = default,
            uint maxSwapchainSampleCount = default
        )
        {
            Type = type;
            Next = next;
            RecommendedImageRectWidth = recommendedImageRectWidth;
            MaxImageRectWidth = maxImageRectWidth;
            RecommendedImageRectHeight = recommendedImageRectHeight;
            MaxImageRectHeight = maxImageRectHeight;
            RecommendedSwapchainSampleCount = recommendedSwapchainSampleCount;
            MaxSwapchainSampleCount = maxSwapchainSampleCount;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "recommendedImageRectWidth")]
        public uint RecommendedImageRectWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageRectWidth")]
        public uint MaxImageRectWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "recommendedImageRectHeight")]
        public uint RecommendedImageRectHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageRectHeight")]
        public uint MaxImageRectHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "recommendedSwapchainSampleCount")]
        public uint RecommendedSwapchainSampleCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSwapchainSampleCount")]
        public uint MaxSwapchainSampleCount;
    }
}
