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
    [NativeName("Name", "__AnonymousRecord_dwrite_1_L786_C5")]
    public unsafe partial struct PanoseDecorative
    {
        public PanoseDecorative
        (
            byte? familyKind = null,
            byte? decorativeClass = null,
            byte? weight = null,
            byte? aspect = null,
            byte? contrast = null,
            byte? serifVariant = null,
            byte? fill = null,
            byte? lining = null,
            byte? decorativeTopology = null,
            byte? characterRange = null
        ) : this()
        {
            if (familyKind is not null)
            {
                FamilyKind = familyKind.Value;
            }

            if (decorativeClass is not null)
            {
                DecorativeClass = decorativeClass.Value;
            }

            if (weight is not null)
            {
                Weight = weight.Value;
            }

            if (aspect is not null)
            {
                Aspect = aspect.Value;
            }

            if (contrast is not null)
            {
                Contrast = contrast.Value;
            }

            if (serifVariant is not null)
            {
                SerifVariant = serifVariant.Value;
            }

            if (fill is not null)
            {
                Fill = fill.Value;
            }

            if (lining is not null)
            {
                Lining = lining.Value;
            }

            if (decorativeTopology is not null)
            {
                DecorativeTopology = decorativeTopology.Value;
            }

            if (characterRange is not null)
            {
                CharacterRange = characterRange.Value;
            }
        }


        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "familyKind")]
        public byte FamilyKind;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "decorativeClass")]
        public byte DecorativeClass;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "weight")]
        public byte Weight;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "aspect")]
        public byte Aspect;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "contrast")]
        public byte Contrast;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "serifVariant")]
        public byte SerifVariant;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "fill")]
        public byte Fill;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "lining")]
        public byte Lining;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "decorativeTopology")]
        public byte DecorativeTopology;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "characterRange")]
        public byte CharacterRange;
    }
}
