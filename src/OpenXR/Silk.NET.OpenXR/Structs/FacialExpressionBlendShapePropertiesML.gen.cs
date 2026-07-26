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
    [NativeName("Name", "XrFacialExpressionBlendShapePropertiesML")]
    public unsafe partial struct FacialExpressionBlendShapePropertiesML
    {
        public FacialExpressionBlendShapePropertiesML
        (
            StructureType? type = StructureType.TypeFacialExpressionBlendShapePropertiesML,
            void* next = null,
            FacialBlendShapeML? requestedFacialBlendShape = null,
            float? weight = null,
            FacialExpressionBlendShapePropertiesFlagsML? flags = null,
            long? time = null
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

            if (requestedFacialBlendShape is not null)
            {
                RequestedFacialBlendShape = requestedFacialBlendShape.Value;
            }

            if (weight is not null)
            {
                Weight = weight.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
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
        [NativeName("Type", "XrFacialBlendShapeML")]
        [NativeName("Type.Name", "XrFacialBlendShapeML")]
        [NativeName("Name", "requestedFacialBlendShape")]
        public FacialBlendShapeML RequestedFacialBlendShape;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "weight")]
        public float Weight;
/// <summary></summary>
        [NativeName("Type", "XrFacialExpressionBlendShapePropertiesFlagsML")]
        [NativeName("Type.Name", "XrFacialExpressionBlendShapePropertiesFlagsML")]
        [NativeName("Name", "flags")]
        public FacialExpressionBlendShapePropertiesFlagsML Flags;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
