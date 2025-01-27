// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagPictureAttributes")]
    public enum PictureAttributes : int
    {
        [Obsolete("Deprecated in favour of \"Scalable\"")]
        [NativeName("Name", "PICTURE_SCALABLE")]
        PictureScalable = 0x1,
        [Obsolete("Deprecated in favour of \"Transparent\"")]
        [NativeName("Name", "PICTURE_TRANSPARENT")]
        PictureTransparent = 0x2,
        [NativeName("Name", "PICTURE_SCALABLE")]
        Scalable = 0x1,
        [NativeName("Name", "PICTURE_TRANSPARENT")]
        Transparent = 0x2,
    }
}
