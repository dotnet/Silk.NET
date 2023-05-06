// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_FILE_TYPE")]
    public enum FontFileType : int
    {
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_CFF")]
        Cff = 0x1,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_TRUETYPE")]
        Truetype = 0x2,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION")]
        OpentypeCollection = 0x3,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_TYPE1_PFM")]
        Type1Pfm = 0x4,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_TYPE1_PFB")]
        Type1Pfb = 0x5,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_VECTOR")]
        Vector = 0x6,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_BITMAP")]
        Bitmap = 0x7,
        [NativeName("Name", "DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION")]
        TruetypeCollection = 0x3,
    }
}
