// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_PROPERTY_ID")]
    public enum FontPropertyID : int
    {
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME")]
        WeightStretchStyleFamilyName = 0x1,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME")]
        TypographicFamilyName = 0x2,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FACE_NAME")]
        WeightStretchStyleFaceName = 0x3,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_FULL_NAME")]
        FullName = 0x4,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_WIN32_FAMILY_NAME")]
        Win32FamilyName = 0x5,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_POSTSCRIPT_NAME")]
        PostscriptName = 0x6,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG")]
        DesignScriptLanguageTag = 0x7,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_SUPPORTED_SCRIPT_LANGUAGE_TAG")]
        SupportedScriptLanguageTag = 0x8,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_SEMANTIC_TAG")]
        SemanticTag = 0x9,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_WEIGHT")]
        Weight = 0xA,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_STRETCH")]
        Stretch = 0xB,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_STYLE")]
        Style = 0xC,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME")]
        TypographicFaceName = 0xD,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_TOTAL")]
        Total = 0xD,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_TOTAL_RS3")]
        TotalRS3 = 0xE,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_PREFERRED_FAMILY_NAME")]
        PreferredFamilyName = 0x2,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_FAMILY_NAME")]
        FamilyName = 0x1,
        [NativeName("Name", "DWRITE_FONT_PROPERTY_ID_FACE_NAME")]
        FaceName = 0x3,
    }
}
