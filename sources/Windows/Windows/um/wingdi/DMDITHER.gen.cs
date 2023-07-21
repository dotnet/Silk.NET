// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DMDITHER
{
    [NativeTypeName("#define DMDITHER_NONE 1")]
    public const int DMDITHER_NONE = 1;

    [NativeTypeName("#define DMDITHER_COARSE 2")]
    public const int DMDITHER_COARSE = 2;

    [NativeTypeName("#define DMDITHER_FINE 3")]
    public const int DMDITHER_FINE = 3;

    [NativeTypeName("#define DMDITHER_LINEART 4")]
    public const int DMDITHER_LINEART = 4;

    [NativeTypeName("#define DMDITHER_ERRORDIFFUSION 5")]
    public const int DMDITHER_ERRORDIFFUSION = 5;

    [NativeTypeName("#define DMDITHER_RESERVED6 6")]
    public const int DMDITHER_RESERVED6 = 6;

    [NativeTypeName("#define DMDITHER_RESERVED7 7")]
    public const int DMDITHER_RESERVED7 = 7;

    [NativeTypeName("#define DMDITHER_RESERVED8 8")]
    public const int DMDITHER_RESERVED8 = 8;

    [NativeTypeName("#define DMDITHER_RESERVED9 9")]
    public const int DMDITHER_RESERVED9 = 9;

    [NativeTypeName("#define DMDITHER_GRAYSCALE 10")]
    public const int DMDITHER_GRAYSCALE = 10;

    [NativeTypeName("#define DMDITHER_USER 256")]
    public const int DMDITHER_USER = 256;
}
