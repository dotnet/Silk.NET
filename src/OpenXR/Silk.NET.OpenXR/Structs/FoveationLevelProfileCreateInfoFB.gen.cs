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
    [NativeName("Name", "XrFoveationLevelProfileCreateInfoFB")]
    public unsafe partial struct FoveationLevelProfileCreateInfoFB
    {
        public FoveationLevelProfileCreateInfoFB
        (
            StructureType? type = StructureType.TypeFoveationLevelProfileCreateInfoFB,
            void* next = null,
            FoveationLevelFB? level = null,
            float? verticalOffset = null,
            FoveationDynamicFB? dynamic = null
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

            if (level is not null)
            {
                Level = level.Value;
            }

            if (verticalOffset is not null)
            {
                VerticalOffset = verticalOffset.Value;
            }

            if (dynamic is not null)
            {
                Dynamic = dynamic.Value;
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
        [NativeName("Type", "XrFoveationLevelFB")]
        [NativeName("Type.Name", "XrFoveationLevelFB")]
        [NativeName("Name", "level")]
        public FoveationLevelFB Level;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "verticalOffset")]
        public float VerticalOffset;
/// <summary></summary>
        [NativeName("Type", "XrFoveationDynamicFB")]
        [NativeName("Type.Name", "XrFoveationDynamicFB")]
        [NativeName("Name", "dynamic")]
        public FoveationDynamicFB Dynamic;
    }
}
