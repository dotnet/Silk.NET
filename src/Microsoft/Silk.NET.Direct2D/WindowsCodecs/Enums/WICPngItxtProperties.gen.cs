// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngItxtProperties")]
    public enum WICPngItxtProperties : int
    {
        [Obsolete("Deprecated in favour of \"Keyword\"")]
        [NativeName("Name", "WICPngItxtKeyword")]
        WicpngItxtKeyword = 0x1,
        [Obsolete("Deprecated in favour of \"CompressionFlag\"")]
        [NativeName("Name", "WICPngItxtCompressionFlag")]
        WicpngItxtCompressionFlag = 0x2,
        [Obsolete("Deprecated in favour of \"LanguageTag\"")]
        [NativeName("Name", "WICPngItxtLanguageTag")]
        WicpngItxtLanguageTag = 0x3,
        [Obsolete("Deprecated in favour of \"TranslatedKeyword\"")]
        [NativeName("Name", "WICPngItxtTranslatedKeyword")]
        WicpngItxtTranslatedKeyword = 0x4,
        [Obsolete("Deprecated in favour of \"Text\"")]
        [NativeName("Name", "WICPngItxtText")]
        WicpngItxtText = 0x5,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngItxtProperties_FORCE_DWORD")]
        WicpngItxtPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngItxtKeyword")]
        Keyword = 0x1,
        [NativeName("Name", "WICPngItxtCompressionFlag")]
        CompressionFlag = 0x2,
        [NativeName("Name", "WICPngItxtLanguageTag")]
        LanguageTag = 0x3,
        [NativeName("Name", "WICPngItxtTranslatedKeyword")]
        TranslatedKeyword = 0x4,
        [NativeName("Name", "WICPngItxtText")]
        Text = 0x5,
        [NativeName("Name", "WICPngItxtProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
