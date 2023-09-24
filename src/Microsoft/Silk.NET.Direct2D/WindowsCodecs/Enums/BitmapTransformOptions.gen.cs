// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICBitmapTransformOptions")]
    public enum BitmapTransformOptions : int
    {
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
