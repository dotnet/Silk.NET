// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngItxtProperties")]
    public enum PngItxtProperties : int
    {
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
