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
    [NativeName("Name", "XrVirtualKeyboardAnimationStateMETA")]
    public unsafe partial struct VirtualKeyboardAnimationStateMETA
    {
        public VirtualKeyboardAnimationStateMETA
        (
            StructureType? type = StructureType.TypeVirtualKeyboardAnimationStateMeta,
            void* next = null,
            int? animationIndex = null,
            float? fraction = null
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

            if (animationIndex is not null)
            {
                AnimationIndex = animationIndex.Value;
            }

            if (fraction is not null)
            {
                Fraction = fraction.Value;
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
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "animationIndex")]
        public int AnimationIndex;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "fraction")]
        public float Fraction;
    }
}
