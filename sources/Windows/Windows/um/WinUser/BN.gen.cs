// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class BN
{
    [NativeTypeName("#define BN_CLICKED 0")]
    public const int BN_CLICKED = 0;
    [NativeTypeName("#define BN_PAINT 1")]
    public const int BN_PAINT = 1;
    [NativeTypeName("#define BN_HILITE 2")]
    public const int BN_HILITE = 2;
    [NativeTypeName("#define BN_UNHILITE 3")]
    public const int BN_UNHILITE = 3;
    [NativeTypeName("#define BN_DISABLE 4")]
    public const int BN_DISABLE = 4;
    [NativeTypeName("#define BN_DOUBLECLICKED 5")]
    public const int BN_DOUBLECLICKED = 5;
    [NativeTypeName("#define BN_PUSHED BN_HILITE")]
    public const int BN_PUSHED = 2;
    [NativeTypeName("#define BN_UNPUSHED BN_UNHILITE")]
    public const int BN_UNPUSHED = 3;
    [NativeTypeName("#define BN_DBLCLK BN_DOUBLECLICKED")]
    public const int BN_DBLCLK = 5;
    [NativeTypeName("#define BN_SETFOCUS 6")]
    public const int BN_SETFOCUS = 6;
    [NativeTypeName("#define BN_KILLFOCUS 7")]
    public const int BN_KILLFOCUS = 7;
}