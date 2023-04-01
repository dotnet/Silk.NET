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
    [NativeName("Name", "__AnonymousRecord_dwrite_1_L800_C5")]
    public unsafe partial struct PanoseSymbol
    {
        public PanoseSymbol
        (
            byte? familyKind = null,
            byte? symbolKind = null,
            byte? weight = null,
            byte? spacing = null,
            byte? aspectRatioAndContrast = null,
            byte? aspectRatio94 = null,
            byte? aspectRatio119 = null,
            byte? aspectRatio157 = null,
            byte? aspectRatio163 = null,
            byte? aspectRatio211 = null
        ) : this()
        {
            if (familyKind is not null)
            {
                FamilyKind = familyKind.Value;
            }

            if (symbolKind is not null)
            {
                SymbolKind = symbolKind.Value;
            }

            if (weight is not null)
            {
                Weight = weight.Value;
            }

            if (spacing is not null)
            {
                Spacing = spacing.Value;
            }

            if (aspectRatioAndContrast is not null)
            {
                AspectRatioAndContrast = aspectRatioAndContrast.Value;
            }

            if (aspectRatio94 is not null)
            {
                AspectRatio94 = aspectRatio94.Value;
            }

            if (aspectRatio119 is not null)
            {
                AspectRatio119 = aspectRatio119.Value;
            }

            if (aspectRatio157 is not null)
            {
                AspectRatio157 = aspectRatio157.Value;
            }

            if (aspectRatio163 is not null)
            {
                AspectRatio163 = aspectRatio163.Value;
            }

            if (aspectRatio211 is not null)
            {
                AspectRatio211 = aspectRatio211.Value;
            }
        }


        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "familyKind")]
        public byte FamilyKind;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "symbolKind")]
        public byte SymbolKind;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "weight")]
        public byte Weight;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "spacing")]
        public byte Spacing;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "aspectRatioAndContrast")]
        public byte AspectRatioAndContrast;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "aspectRatio94")]
        public byte AspectRatio94;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "aspectRatio119")]
        public byte AspectRatio119;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "aspectRatio157")]
        public byte AspectRatio157;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "aspectRatio163")]
        public byte AspectRatio163;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "aspectRatio211")]
        public byte AspectRatio211;
    }
}
