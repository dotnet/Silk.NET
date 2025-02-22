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
    [NativeName("Name", "XrGlobalDimmerFrameEndInfoML")]
    public unsafe partial struct GlobalDimmerFrameEndInfoML
    {
        public GlobalDimmerFrameEndInfoML
        (
            StructureType? type = StructureType.TypeGlobalDimmerFrameEndInfoML,
            void* next = null,
            float? dimmerValue = null,
            GlobalDimmerFrameEndInfoFlagsML? flags = null
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

            if (dimmerValue is not null)
            {
                DimmerValue = dimmerValue.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Name", "dimmerValue")]
        public float DimmerValue;
/// <summary></summary>
        [NativeName("Type", "XrGlobalDimmerFrameEndInfoFlagsML")]
        [NativeName("Type.Name", "XrGlobalDimmerFrameEndInfoFlagsML")]
        [NativeName("Name", "flags")]
        public GlobalDimmerFrameEndInfoFlagsML Flags;
    }
}
