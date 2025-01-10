// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ISFB
{
    [NativeTypeName("#define ISFB_MASK_STATE 0x00000001")]
    public const int ISFB_MASK_STATE = 0x00000001;

    [NativeTypeName("#define ISFB_MASK_BKCOLOR 0x00000002")]
    public const int ISFB_MASK_BKCOLOR = 0x00000002;

    [NativeTypeName("#define ISFB_MASK_VIEWMODE 0x00000004")]
    public const int ISFB_MASK_VIEWMODE = 0x00000004;

    [NativeTypeName("#define ISFB_MASK_SHELLFOLDER 0x00000008")]
    public const int ISFB_MASK_SHELLFOLDER = 0x00000008;

    [NativeTypeName("#define ISFB_MASK_IDLIST 0x00000010")]
    public const int ISFB_MASK_IDLIST = 0x00000010;

    [NativeTypeName("#define ISFB_MASK_COLORS 0x00000020")]
    public const int ISFB_MASK_COLORS = 0x00000020;

    [NativeTypeName("#define ISFB_STATE_DEFAULT 0x00000000")]
    public const int ISFB_STATE_DEFAULT = 0x00000000;

    [NativeTypeName("#define ISFB_STATE_DEBOSSED 0x00000001")]
    public const int ISFB_STATE_DEBOSSED = 0x00000001;

    [NativeTypeName("#define ISFB_STATE_ALLOWRENAME 0x00000002")]
    public const int ISFB_STATE_ALLOWRENAME = 0x00000002;

    [NativeTypeName("#define ISFB_STATE_NOSHOWTEXT 0x00000004")]
    public const int ISFB_STATE_NOSHOWTEXT = 0x00000004;

    [NativeTypeName("#define ISFB_STATE_CHANNELBAR 0x00000010")]
    public const int ISFB_STATE_CHANNELBAR = 0x00000010;

    [NativeTypeName("#define ISFB_STATE_QLINKSMODE 0x00000020")]
    public const int ISFB_STATE_QLINKSMODE = 0x00000020;

    [NativeTypeName("#define ISFB_STATE_FULLOPEN 0x00000040")]
    public const int ISFB_STATE_FULLOPEN = 0x00000040;

    [NativeTypeName("#define ISFB_STATE_NONAMESORT 0x00000080")]
    public const int ISFB_STATE_NONAMESORT = 0x00000080;

    [NativeTypeName("#define ISFB_STATE_BTNMINSIZE 0x00000100")]
    public const int ISFB_STATE_BTNMINSIZE = 0x00000100;
}
