// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_ID")]
    public enum InformationalStringID : int
    {
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE")]
        CopyrightNotice = 0x1,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS")]
        VersionStrings = 0x2,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_TRADEMARK")]
        Trademark = 0x3,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_MANUFACTURER")]
        Manufacturer = 0x4,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_DESIGNER")]
        Designer = 0x5,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_DESIGNER_URL")]
        DesignerUrl = 0x6,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_DESCRIPTION")]
        Description = 0x7,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL")]
        FontVendorUrl = 0x8,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION")]
        LicenseDescription = 0x9,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL")]
        LicenseInfoUrl = 0xA,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES")]
        Win32FamilyNames = 0xB,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES")]
        Win32SubfamilyNames = 0xC,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES")]
        TypographicFamilyNames = 0xD,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES")]
        TypographicSubfamilyNames = 0xE,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT")]
        SampleText = 0xF,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_FULL_NAME")]
        FullName = 0x10,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME")]
        PostscriptName = 0x11,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME")]
        PostscriptCidName = 0x12,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME")]
        WeightStretchStyleFamilyName = 0x13,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_DESIGN_SCRIPT_LANGUAGE_TAG")]
        DesignScriptLanguageTag = 0x14,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_SUPPORTED_SCRIPT_LANGUAGE_TAG")]
        SupportedScriptLanguageTag = 0x15,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES")]
        PreferredFamilyNames = 0xD,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES")]
        PreferredSubfamilyNames = 0xE,
        [NativeName("Name", "DWRITE_INFORMATIONAL_STRING_WWS_FAMILY_NAME")]
        WwsFamilyName = 0x13,
    }
}
