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

namespace Silk.NET.DirectWrite
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "DWRITE_PANOSE")]
    public unsafe partial struct Panose
    {
        public Panose
        (
            byte? familyKind = null,
            PanoseText? text = null,
            PanoseScript? script = null,
            PanoseDecorative? decorative = null,
            PanoseSymbol? symbol = null
        ) : this()
        {
            if (familyKind is not null)
            {
                FamilyKind = familyKind.Value;
            }

            if (text is not null)
            {
                Text = text.Value;
            }

            if (script is not null)
            {
                Script = script.Value;
            }

            if (decorative is not null)
            {
                Decorative = decorative.Value;
            }

            if (symbol is not null)
            {
                Symbol = symbol.Value;
            }
        }

        [FieldOffset(0)]
        [NativeName("Type", "UINT8[10]")]
        [NativeName("Type.Name", "UINT8[10]")]
        [NativeName("Name", "values")]
        public fixed byte Values[10];

        [FieldOffset(0)]
        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "familyKind")]
        public byte FamilyKind;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at dwrite_1.h:758:5)")]
        [NativeName("Type.Name", "struct (unnamed struct at dwrite_1.h:758:5)")]
        [NativeName("Name", "text")]
        public PanoseText Text;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at dwrite_1.h:772:5)")]
        [NativeName("Type.Name", "struct (unnamed struct at dwrite_1.h:772:5)")]
        [NativeName("Name", "script")]
        public PanoseScript Script;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at dwrite_1.h:786:5)")]
        [NativeName("Type.Name", "struct (unnamed struct at dwrite_1.h:786:5)")]
        [NativeName("Name", "decorative")]
        public PanoseDecorative Decorative;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at dwrite_1.h:800:5)")]
        [NativeName("Type.Name", "struct (unnamed struct at dwrite_1.h:800:5)")]
        [NativeName("Name", "symbol")]
        public PanoseSymbol Symbol;
    }
}
