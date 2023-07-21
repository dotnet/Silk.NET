// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PGF
{
    [NativeTypeName("#define PGF_INVISIBLE 0")]
    public const int PGF_INVISIBLE = 0;

    [NativeTypeName("#define PGF_NORMAL 1")]
    public const int PGF_NORMAL = 1;

    [NativeTypeName("#define PGF_GRAYED 2")]
    public const int PGF_GRAYED = 2;

    [NativeTypeName("#define PGF_DEPRESSED 4")]
    public const int PGF_DEPRESSED = 4;

    [NativeTypeName("#define PGF_HOT 8")]
    public const int PGF_HOT = 8;

    [NativeTypeName("#define PGF_SCROLLUP 1")]
    public const int PGF_SCROLLUP = 1;

    [NativeTypeName("#define PGF_SCROLLDOWN 2")]
    public const int PGF_SCROLLDOWN = 2;

    [NativeTypeName("#define PGF_SCROLLLEFT 4")]
    public const int PGF_SCROLLLEFT = 4;

    [NativeTypeName("#define PGF_SCROLLRIGHT 8")]
    public const int PGF_SCROLLRIGHT = 8;

    [NativeTypeName("#define PGF_CALCWIDTH 1")]
    public const int PGF_CALCWIDTH = 1;

    [NativeTypeName("#define PGF_CALCHEIGHT 2")]
    public const int PGF_CALCHEIGHT = 2;
}
