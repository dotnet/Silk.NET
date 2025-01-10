// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SORT
{
    [NativeTypeName("#define SORT_DEFAULT 0x0")]
    public const int SORT_DEFAULT = 0x0;

    [NativeTypeName("#define SORT_INVARIANT_MATH 0x1")]
    public const int SORT_INVARIANT_MATH = 0x1;

    [NativeTypeName("#define SORT_JAPANESE_XJIS 0x0")]
    public const int SORT_JAPANESE_XJIS = 0x0;

    [NativeTypeName("#define SORT_JAPANESE_UNICODE 0x1")]
    public const int SORT_JAPANESE_UNICODE = 0x1;

    [NativeTypeName("#define SORT_JAPANESE_RADICALSTROKE 0x4")]
    public const int SORT_JAPANESE_RADICALSTROKE = 0x4;

    [NativeTypeName("#define SORT_CHINESE_BIG5 0x0")]
    public const int SORT_CHINESE_BIG5 = 0x0;

    [NativeTypeName("#define SORT_CHINESE_PRCP 0x0")]
    public const int SORT_CHINESE_PRCP = 0x0;

    [NativeTypeName("#define SORT_CHINESE_UNICODE 0x1")]
    public const int SORT_CHINESE_UNICODE = 0x1;

    [NativeTypeName("#define SORT_CHINESE_PRC 0x2")]
    public const int SORT_CHINESE_PRC = 0x2;

    [NativeTypeName("#define SORT_CHINESE_BOPOMOFO 0x3")]
    public const int SORT_CHINESE_BOPOMOFO = 0x3;

    [NativeTypeName("#define SORT_CHINESE_RADICALSTROKE 0x4")]
    public const int SORT_CHINESE_RADICALSTROKE = 0x4;

    [NativeTypeName("#define SORT_KOREAN_KSC 0x0")]
    public const int SORT_KOREAN_KSC = 0x0;

    [NativeTypeName("#define SORT_KOREAN_UNICODE 0x1")]
    public const int SORT_KOREAN_UNICODE = 0x1;

    [NativeTypeName("#define SORT_GERMAN_PHONE_BOOK 0x1")]
    public const int SORT_GERMAN_PHONE_BOOK = 0x1;

    [NativeTypeName("#define SORT_HUNGARIAN_DEFAULT 0x0")]
    public const int SORT_HUNGARIAN_DEFAULT = 0x0;

    [NativeTypeName("#define SORT_HUNGARIAN_TECHNICAL 0x1")]
    public const int SORT_HUNGARIAN_TECHNICAL = 0x1;

    [NativeTypeName("#define SORT_GEORGIAN_TRADITIONAL 0x0")]
    public const int SORT_GEORGIAN_TRADITIONAL = 0x0;

    [NativeTypeName("#define SORT_GEORGIAN_MODERN 0x1")]
    public const int SORT_GEORGIAN_MODERN = 0x1;
}
