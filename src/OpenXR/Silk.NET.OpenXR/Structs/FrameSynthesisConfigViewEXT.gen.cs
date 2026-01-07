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
    [NativeName("Name", "XrFrameSynthesisConfigViewEXT")]
    public unsafe partial struct FrameSynthesisConfigViewEXT
    {
        public FrameSynthesisConfigViewEXT
        (
            StructureType? type = StructureType.TypeFrameSynthesisConfigViewExt,
            void* next = null,
            uint? recommendedMotionVectorImageRectWidth = null,
            uint? recommendedMotionVectorImageRectHeight = null
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

            if (recommendedMotionVectorImageRectWidth is not null)
            {
                RecommendedMotionVectorImageRectWidth = recommendedMotionVectorImageRectWidth.Value;
            }

            if (recommendedMotionVectorImageRectHeight is not null)
            {
                RecommendedMotionVectorImageRectHeight = recommendedMotionVectorImageRectHeight.Value;
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
        [NativeName("Name", "recommendedMotionVectorImageRectWidth")]
        public uint RecommendedMotionVectorImageRectWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "recommendedMotionVectorImageRectHeight")]
        public uint RecommendedMotionVectorImageRectHeight;
    }
}
