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
    [NativeName("Name", "__AnonymousRecord_dwrite_1_L772_C5")]
    public unsafe partial struct PanoseScript
    {
        public PanoseScript
        (
            byte? familyKind = null,
            byte? toolKind = null,
            byte? weight = null,
            byte? spacing = null,
            byte? aspectRatio = null,
            byte? contrast = null,
            byte? scriptTopology = null,
            byte? scriptForm = null,
            byte? finials = null,
            byte? xAscent = null
        ) : this()
        {
            if (familyKind is not null)
            {
                FamilyKind = familyKind.Value;
            }

            if (toolKind is not null)
            {
                ToolKind = toolKind.Value;
            }

            if (weight is not null)
            {
                Weight = weight.Value;
            }

            if (spacing is not null)
            {
                Spacing = spacing.Value;
            }

            if (aspectRatio is not null)
            {
                AspectRatio = aspectRatio.Value;
            }

            if (contrast is not null)
            {
                Contrast = contrast.Value;
            }

            if (scriptTopology is not null)
            {
                ScriptTopology = scriptTopology.Value;
            }

            if (scriptForm is not null)
            {
                ScriptForm = scriptForm.Value;
            }

            if (finials is not null)
            {
                Finials = finials.Value;
            }

            if (xAscent is not null)
            {
                XAscent = xAscent.Value;
            }
        }


        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "familyKind")]
        public byte FamilyKind;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "toolKind")]
        public byte ToolKind;

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
        [NativeName("Name", "aspectRatio")]
        public byte AspectRatio;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "contrast")]
        public byte Contrast;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "scriptTopology")]
        public byte ScriptTopology;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "scriptForm")]
        public byte ScriptForm;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "finials")]
        public byte Finials;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "xAscent")]
        public byte XAscent;
    }
}
