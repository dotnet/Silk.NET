// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ES
{
    [NativeTypeName("#define ES_LEFT 0x0000L")]
    public const int ES_LEFT = 0x0000;

    [NativeTypeName("#define ES_CENTER 0x0001L")]
    public const int ES_CENTER = 0x0001;

    [NativeTypeName("#define ES_RIGHT 0x0002L")]
    public const int ES_RIGHT = 0x0002;

    [NativeTypeName("#define ES_MULTILINE 0x0004L")]
    public const int ES_MULTILINE = 0x0004;

    [NativeTypeName("#define ES_UPPERCASE 0x0008L")]
    public const int ES_UPPERCASE = 0x0008;

    [NativeTypeName("#define ES_LOWERCASE 0x0010L")]
    public const int ES_LOWERCASE = 0x0010;

    [NativeTypeName("#define ES_PASSWORD 0x0020L")]
    public const int ES_PASSWORD = 0x0020;

    [NativeTypeName("#define ES_AUTOVSCROLL 0x0040L")]
    public const int ES_AUTOVSCROLL = 0x0040;

    [NativeTypeName("#define ES_AUTOHSCROLL 0x0080L")]
    public const int ES_AUTOHSCROLL = 0x0080;

    [NativeTypeName("#define ES_NOHIDESEL 0x0100L")]
    public const int ES_NOHIDESEL = 0x0100;

    [NativeTypeName("#define ES_OEMCONVERT 0x0400L")]
    public const int ES_OEMCONVERT = 0x0400;

    [NativeTypeName("#define ES_READONLY 0x0800L")]
    public const int ES_READONLY = 0x0800;

    [NativeTypeName("#define ES_WANTRETURN 0x1000L")]
    public const int ES_WANTRETURN = 0x1000;

    [NativeTypeName("#define ES_NUMBER 0x2000L")]
    public const int ES_NUMBER = 0x2000;
}
