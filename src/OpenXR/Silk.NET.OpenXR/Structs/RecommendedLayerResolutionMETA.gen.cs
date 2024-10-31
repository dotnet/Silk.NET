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
    [NativeName("Name", "XrRecommendedLayerResolutionMETA")]
    public unsafe partial struct RecommendedLayerResolutionMETA
    {
        public RecommendedLayerResolutionMETA
        (
            StructureType? type = StructureType.TypeRecommendedLayerResolutionMeta,
            void* next = null,
            Extent2Di? recommendedImageDimensions = null,
            uint? isValid = null
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

            if (recommendedImageDimensions is not null)
            {
                RecommendedImageDimensions = recommendedImageDimensions.Value;
            }

            if (isValid is not null)
            {
                IsValid = isValid.Value;
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
        [NativeName("Type", "XrExtent2Di")]
        [NativeName("Type.Name", "XrExtent2Di")]
        [NativeName("Name", "recommendedImageDimensions")]
        public Extent2Di RecommendedImageDimensions;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isValid")]
        public uint IsValid;
    }
}
