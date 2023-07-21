// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GWLP
{
    [NativeTypeName("#define GWLP_WNDPROC (-4)")]
    public const int GWLP_WNDPROC = (-4);

    [NativeTypeName("#define GWLP_HINSTANCE (-6)")]
    public const int GWLP_HINSTANCE = (-6);

    [NativeTypeName("#define GWLP_HWNDPARENT (-8)")]
    public const int GWLP_HWNDPARENT = (-8);

    [NativeTypeName("#define GWLP_USERDATA (-21)")]
    public const int GWLP_USERDATA = (-21);

    [NativeTypeName("#define GWLP_ID (-12)")]
    public const int GWLP_ID = (-12);
}
