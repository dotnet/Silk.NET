// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct ViewConfigurationView
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint RecommendedImageRectWidth;
/// <summary></summary>
        public uint MaxImageRectWidth;
/// <summary></summary>
        public uint RecommendedImageRectHeight;
/// <summary></summary>
        public uint MaxImageRectHeight;
/// <summary></summary>
        public uint RecommendedSwapchainSampleCount;
/// <summary></summary>
        public uint MaxSwapchainSampleCount;
    }
}
