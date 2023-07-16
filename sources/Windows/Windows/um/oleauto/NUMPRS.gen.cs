// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class NUMPRS
{
    [NativeTypeName("#define NUMPRS_LEADING_WHITE 0x0001")]
    public const int NUMPRS_LEADING_WHITE = 0x0001;
    [NativeTypeName("#define NUMPRS_TRAILING_WHITE 0x0002")]
    public const int NUMPRS_TRAILING_WHITE = 0x0002;
    [NativeTypeName("#define NUMPRS_LEADING_PLUS 0x0004")]
    public const int NUMPRS_LEADING_PLUS = 0x0004;
    [NativeTypeName("#define NUMPRS_TRAILING_PLUS 0x0008")]
    public const int NUMPRS_TRAILING_PLUS = 0x0008;
    [NativeTypeName("#define NUMPRS_LEADING_MINUS 0x0010")]
    public const int NUMPRS_LEADING_MINUS = 0x0010;
    [NativeTypeName("#define NUMPRS_TRAILING_MINUS 0x0020")]
    public const int NUMPRS_TRAILING_MINUS = 0x0020;
    [NativeTypeName("#define NUMPRS_HEX_OCT 0x0040")]
    public const int NUMPRS_HEX_OCT = 0x0040;
    [NativeTypeName("#define NUMPRS_PARENS 0x0080")]
    public const int NUMPRS_PARENS = 0x0080;
    [NativeTypeName("#define NUMPRS_DECIMAL 0x0100")]
    public const int NUMPRS_DECIMAL = 0x0100;
    [NativeTypeName("#define NUMPRS_THOUSANDS 0x0200")]
    public const int NUMPRS_THOUSANDS = 0x0200;
    [NativeTypeName("#define NUMPRS_CURRENCY 0x0400")]
    public const int NUMPRS_CURRENCY = 0x0400;
    [NativeTypeName("#define NUMPRS_EXPONENT 0x0800")]
    public const int NUMPRS_EXPONENT = 0x0800;
    [NativeTypeName("#define NUMPRS_USE_ALL 0x1000")]
    public const int NUMPRS_USE_ALL = 0x1000;
    [NativeTypeName("#define NUMPRS_STD 0x1FFF")]
    public const int NUMPRS_STD = 0x1FFF;
    [NativeTypeName("#define NUMPRS_NEG 0x10000")]
    public const int NUMPRS_NEG = 0x10000;
    [NativeTypeName("#define NUMPRS_INEXACT 0x20000")]
    public const int NUMPRS_INEXACT = 0x20000;
}