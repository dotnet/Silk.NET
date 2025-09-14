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
    [NativeName("Name", "XrFacialExpressionClientCreateInfoML")]
    public unsafe partial struct FacialExpressionClientCreateInfoML
    {
        public FacialExpressionClientCreateInfoML
        (
            StructureType? type = StructureType.TypeFacialExpressionClientCreateInfoML,
            void* next = null,
            uint? requestedCount = null,
            FacialBlendShapeML* requestedFacialBlendShapes = null
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

            if (requestedCount is not null)
            {
                RequestedCount = requestedCount.Value;
            }

            if (requestedFacialBlendShapes is not null)
            {
                RequestedFacialBlendShapes = requestedFacialBlendShapes;
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
        [NativeName("Name", "requestedCount")]
        public uint RequestedCount;
/// <summary></summary>
        [NativeName("Type", "XrFacialBlendShapeML*")]
        [NativeName("Type.Name", "XrFacialBlendShapeML")]
        [NativeName("Name", "requestedFacialBlendShapes")]
        public FacialBlendShapeML* RequestedFacialBlendShapes;
    }
}
