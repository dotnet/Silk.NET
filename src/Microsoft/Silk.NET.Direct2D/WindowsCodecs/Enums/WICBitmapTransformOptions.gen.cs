// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICBitmapTransformOptions")]
    public enum WICBitmapTransformOptions : int
    {
        [Obsolete("Deprecated in favour of \"BitmapTransformRotate0\"")]
        [NativeName("Name", "WICBitmapTransformRotate0")]
        WicbitmapTransformRotate0 = 0x0,
        [Obsolete("Deprecated in favour of \"BitmapTransformRotate90\"")]
        [NativeName("Name", "WICBitmapTransformRotate90")]
        WicbitmapTransformRotate90 = 0x1,
        [Obsolete("Deprecated in favour of \"BitmapTransformRotate180\"")]
        [NativeName("Name", "WICBitmapTransformRotate180")]
        WicbitmapTransformRotate180 = 0x2,
        [Obsolete("Deprecated in favour of \"BitmapTransformRotate270\"")]
        [NativeName("Name", "WICBitmapTransformRotate270")]
        WicbitmapTransformRotate270 = 0x3,
        [Obsolete("Deprecated in favour of \"BitmapTransformFlipHorizontal\"")]
        [NativeName("Name", "WICBitmapTransformFlipHorizontal")]
        WicbitmapTransformFlipHorizontal = 0x8,
        [Obsolete("Deprecated in favour of \"BitmapTransformFlipVertical\"")]
        [NativeName("Name", "WICBitmapTransformFlipVertical")]
        WicbitmapTransformFlipVertical = 0x10,
        [Obsolete("Deprecated in favour of \"ItmaptransformoptionsForceDword\"")]
        [NativeName("Name", "WICBITMAPTRANSFORMOPTIONS_FORCE_DWORD")]
        WicbitmaptransformoptionsForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICBitmapTransformRotate0")]
        BitmapTransformRotate0 = 0x0,
        [NativeName("Name", "WICBitmapTransformRotate90")]
        BitmapTransformRotate90 = 0x1,
        [NativeName("Name", "WICBitmapTransformRotate180")]
        BitmapTransformRotate180 = 0x2,
        [NativeName("Name", "WICBitmapTransformRotate270")]
        BitmapTransformRotate270 = 0x3,
        [NativeName("Name", "WICBitmapTransformFlipHorizontal")]
        BitmapTransformFlipHorizontal = 0x8,
        [NativeName("Name", "WICBitmapTransformFlipVertical")]
        BitmapTransformFlipVertical = 0x10,
        [NativeName("Name", "WICBITMAPTRANSFORMOPTIONS_FORCE_DWORD")]
        ItmaptransformoptionsForceDword = 0x7FFFFFFF,
    }
}
