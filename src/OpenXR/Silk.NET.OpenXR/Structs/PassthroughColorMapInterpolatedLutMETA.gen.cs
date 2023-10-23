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
    [NativeName("Name", "XrPassthroughColorMapInterpolatedLutMETA")]
    public unsafe partial struct PassthroughColorMapInterpolatedLutMETA
    {
        public PassthroughColorMapInterpolatedLutMETA
        (
            StructureType? type = StructureType.TypePassthroughColorMapInterpolatedLutMeta,
            void* next = null,
            PassthroughColorLutMETA? sourceColorLut = null,
            PassthroughColorLutMETA? targetColorLut = null,
            float? weight = null
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

            if (sourceColorLut is not null)
            {
                SourceColorLut = sourceColorLut.Value;
            }

            if (targetColorLut is not null)
            {
                TargetColorLut = targetColorLut.Value;
            }

            if (weight is not null)
            {
                Weight = weight.Value;
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
        [NativeName("Type", "XrPassthroughColorLutMETA")]
        [NativeName("Type.Name", "XrPassthroughColorLutMETA")]
        [NativeName("Name", "sourceColorLut")]
        public PassthroughColorLutMETA SourceColorLut;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughColorLutMETA")]
        [NativeName("Type.Name", "XrPassthroughColorLutMETA")]
        [NativeName("Name", "targetColorLut")]
        public PassthroughColorLutMETA TargetColorLut;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "weight")]
        public float Weight;
    }
}
