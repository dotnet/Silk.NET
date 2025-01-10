// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GCS
{
    [NativeTypeName("#define GCS_COMPREADSTR 0x0001")]
    public const int GCS_COMPREADSTR = 0x0001;

    [NativeTypeName("#define GCS_COMPREADATTR 0x0002")]
    public const int GCS_COMPREADATTR = 0x0002;

    [NativeTypeName("#define GCS_COMPREADCLAUSE 0x0004")]
    public const int GCS_COMPREADCLAUSE = 0x0004;

    [NativeTypeName("#define GCS_COMPSTR 0x0008")]
    public const int GCS_COMPSTR = 0x0008;

    [NativeTypeName("#define GCS_COMPATTR 0x0010")]
    public const int GCS_COMPATTR = 0x0010;

    [NativeTypeName("#define GCS_COMPCLAUSE 0x0020")]
    public const int GCS_COMPCLAUSE = 0x0020;

    [NativeTypeName("#define GCS_CURSORPOS 0x0080")]
    public const int GCS_CURSORPOS = 0x0080;

    [NativeTypeName("#define GCS_DELTASTART 0x0100")]
    public const int GCS_DELTASTART = 0x0100;

    [NativeTypeName("#define GCS_RESULTREADSTR 0x0200")]
    public const int GCS_RESULTREADSTR = 0x0200;

    [NativeTypeName("#define GCS_RESULTREADCLAUSE 0x0400")]
    public const int GCS_RESULTREADCLAUSE = 0x0400;

    [NativeTypeName("#define GCS_RESULTSTR 0x0800")]
    public const int GCS_RESULTSTR = 0x0800;

    [NativeTypeName("#define GCS_RESULTCLAUSE 0x1000")]
    public const int GCS_RESULTCLAUSE = 0x1000;
}
