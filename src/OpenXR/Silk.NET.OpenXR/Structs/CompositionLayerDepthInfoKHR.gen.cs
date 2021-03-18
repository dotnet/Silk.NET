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
    [NativeName("Name", "XrCompositionLayerDepthInfoKHR")]
    public unsafe partial struct CompositionLayerDepthInfoKHR
    {
        public CompositionLayerDepthInfoKHR
        (
            StructureType? type = StructureType.TypeCompositionLayerDepthInfoKhr,
            void* next = null,
            SwapchainSubImage? subImage = null,
            float? minDepth = null,
            float? maxDepth = null,
            float? nearZ = null,
            float? farZ = null
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

            if (subImage is not null)
            {
                SubImage = subImage.Value;
            }

            if (minDepth is not null)
            {
                MinDepth = minDepth.Value;
            }

            if (maxDepth is not null)
            {
                MaxDepth = maxDepth.Value;
            }

            if (nearZ is not null)
            {
                NearZ = nearZ.Value;
            }

            if (farZ is not null)
            {
                FarZ = farZ.Value;
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
        [NativeName("Type", "XrSwapchainSubImage")]
        [NativeName("Type.Name", "XrSwapchainSubImage")]
        [NativeName("Name", "subImage")]
        public SwapchainSubImage SubImage;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minDepth")]
        public float MinDepth;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxDepth")]
        public float MaxDepth;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "nearZ")]
        public float NearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "farZ")]
        public float FarZ;
    }
}
