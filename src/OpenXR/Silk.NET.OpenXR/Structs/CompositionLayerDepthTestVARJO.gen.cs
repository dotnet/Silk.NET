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
    [NativeName("Name", "XrCompositionLayerDepthTestVARJO")]
    public unsafe partial struct CompositionLayerDepthTestVARJO
    {
        public CompositionLayerDepthTestVARJO
        (
            StructureType? type = StructureType.TypeCompositionLayerDepthTestVarjo,
            void* next = null,
            float? depthTestRangeNearZ = null,
            float? depthTestRangeFarZ = null
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

            if (depthTestRangeNearZ is not null)
            {
                DepthTestRangeNearZ = depthTestRangeNearZ.Value;
            }

            if (depthTestRangeFarZ is not null)
            {
                DepthTestRangeFarZ = depthTestRangeFarZ.Value;
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
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthTestRangeNearZ")]
        public float DepthTestRangeNearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthTestRangeFarZ")]
        public float DepthTestRangeFarZ;
    }
}
