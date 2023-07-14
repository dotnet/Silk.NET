// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_PROPERTY_TYPE")]
    public enum PropertyType : int
    {
        [NativeName("Name", "D2D1_PROPERTY_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_STRING")]
        String = 0x1,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_BOOL")]
        Bool = 0x2,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_UINT32")]
        Uint32 = 0x3,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_INT32")]
        Int32 = 0x4,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_FLOAT")]
        Float = 0x5,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_VECTOR2")]
        Vector2 = 0x6,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_VECTOR3")]
        Vector3 = 0x7,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_VECTOR4")]
        Vector4 = 0x8,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_BLOB")]
        Blob = 0x9,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_IUNKNOWN")]
        Iunknown = 0xA,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_ENUM")]
        Enum = 0xB,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_ARRAY")]
        Array = 0xC,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_CLSID")]
        Clsid = 0xD,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_MATRIX_3X2")]
        Matrix3X2 = 0xE,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_MATRIX_4X3")]
        Matrix4X3 = 0xF,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_MATRIX_4X4")]
        Matrix4X4 = 0x10,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_MATRIX_5X4")]
        Matrix5X4 = 0x11,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_COLOR_CONTEXT")]
        ColorContext = 0x12,
        [NativeName("Name", "D2D1_PROPERTY_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
