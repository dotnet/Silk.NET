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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrViewConfigurationView")]
    public unsafe partial struct ViewConfigurationView
    {
        public ViewConfigurationView
        (
            StructureType? type = StructureType.TypeViewConfigurationView,
            void* next = null,
            uint? recommendedImageRectWidth = null,
            uint? maxImageRectWidth = null,
            uint? recommendedImageRectHeight = null,
            uint? maxImageRectHeight = null,
            uint? recommendedSwapchainSampleCount = null,
            uint? maxSwapchainSampleCount = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (recommendedImageRectWidth is not null)
            {
                RecommendedImageRectWidth = recommendedImageRectWidth.Value;
            }

            if (maxImageRectWidth is not null)
            {
                MaxImageRectWidth = maxImageRectWidth.Value;
            }

            if (recommendedImageRectHeight is not null)
            {
                RecommendedImageRectHeight = recommendedImageRectHeight.Value;
            }

            if (maxImageRectHeight is not null)
            {
                MaxImageRectHeight = maxImageRectHeight.Value;
            }

            if (recommendedSwapchainSampleCount is not null)
            {
                RecommendedSwapchainSampleCount = recommendedSwapchainSampleCount.Value;
            }

            if (maxSwapchainSampleCount is not null)
            {
                MaxSwapchainSampleCount = maxSwapchainSampleCount.Value;
            }
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
