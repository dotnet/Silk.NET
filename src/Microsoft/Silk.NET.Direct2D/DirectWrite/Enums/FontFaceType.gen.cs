// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_FACE_TYPE")]
    public enum FontFaceType : int
    {
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_CFF")]
        Cff = 0x0,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_TRUETYPE")]
        Truetype = 0x1,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION")]
        OpentypeCollection = 0x2,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_TYPE1")]
        Type1 = 0x3,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_VECTOR")]
        Vector = 0x4,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_BITMAP")]
        Bitmap = 0x5,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_UNKNOWN")]
        Unknown = 0x6,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_RAW_CFF")]
        RawCff = 0x7,
        [NativeName("Name", "DWRITE_FONT_FACE_TYPE_TRUETYPE_COLLECTION")]
        TruetypeCollection = 0x2,
    }
}
