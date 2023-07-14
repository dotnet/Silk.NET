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
    [NativeName("Name", "__AnonymousRecord_dwrite_1_L758_C5")]
    public unsafe partial struct PanoseText
    {
        public PanoseText
        (
            byte? familyKind = null,
            byte? serifStyle = null,
            byte? weight = null,
            byte? proportion = null,
            byte? contrast = null,
            byte? strokeVariation = null,
            byte? armStyle = null,
            byte? letterform = null,
            byte? midline = null,
            byte? xHeight = null
        ) : this()
        {
            if (familyKind is not null)
            {
                FamilyKind = familyKind.Value;
            }

            if (serifStyle is not null)
            {
                SerifStyle = serifStyle.Value;
            }

            if (weight is not null)
            {
                Weight = weight.Value;
            }

            if (proportion is not null)
            {
                Proportion = proportion.Value;
            }

            if (contrast is not null)
            {
                Contrast = contrast.Value;
            }

            if (strokeVariation is not null)
            {
                StrokeVariation = strokeVariation.Value;
            }

            if (armStyle is not null)
            {
                ArmStyle = armStyle.Value;
            }

            if (letterform is not null)
            {
                Letterform = letterform.Value;
            }

            if (midline is not null)
            {
                Midline = midline.Value;
            }

            if (xHeight is not null)
            {
                XHeight = xHeight.Value;
            }
        }


        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "familyKind")]
        public byte FamilyKind;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "serifStyle")]
        public byte SerifStyle;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "weight")]
        public byte Weight;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "proportion")]
        public byte Proportion;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "contrast")]
        public byte Contrast;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "strokeVariation")]
        public byte StrokeVariation;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "armStyle")]
        public byte ArmStyle;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "letterform")]
        public byte Letterform;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "midline")]
        public byte Midline;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "xHeight")]
        public byte XHeight;
    }
}
