// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SS
{
    [NativeTypeName("#define SS_LEFT 0x00000000L")]
    public const int SS_LEFT = 0x00000000;

    [NativeTypeName("#define SS_CENTER 0x00000001L")]
    public const int SS_CENTER = 0x00000001;

    [NativeTypeName("#define SS_RIGHT 0x00000002L")]
    public const int SS_RIGHT = 0x00000002;

    [NativeTypeName("#define SS_ICON 0x00000003L")]
    public const int SS_ICON = 0x00000003;

    [NativeTypeName("#define SS_BLACKRECT 0x00000004L")]
    public const int SS_BLACKRECT = 0x00000004;

    [NativeTypeName("#define SS_GRAYRECT 0x00000005L")]
    public const int SS_GRAYRECT = 0x00000005;

    [NativeTypeName("#define SS_WHITERECT 0x00000006L")]
    public const int SS_WHITERECT = 0x00000006;

    [NativeTypeName("#define SS_BLACKFRAME 0x00000007L")]
    public const int SS_BLACKFRAME = 0x00000007;

    [NativeTypeName("#define SS_GRAYFRAME 0x00000008L")]
    public const int SS_GRAYFRAME = 0x00000008;

    [NativeTypeName("#define SS_WHITEFRAME 0x00000009L")]
    public const int SS_WHITEFRAME = 0x00000009;

    [NativeTypeName("#define SS_USERITEM 0x0000000AL")]
    public const int SS_USERITEM = 0x0000000A;

    [NativeTypeName("#define SS_SIMPLE 0x0000000BL")]
    public const int SS_SIMPLE = 0x0000000B;

    [NativeTypeName("#define SS_LEFTNOWORDWRAP 0x0000000CL")]
    public const int SS_LEFTNOWORDWRAP = 0x0000000C;

    [NativeTypeName("#define SS_OWNERDRAW 0x0000000DL")]
    public const int SS_OWNERDRAW = 0x0000000D;

    [NativeTypeName("#define SS_BITMAP 0x0000000EL")]
    public const int SS_BITMAP = 0x0000000E;

    [NativeTypeName("#define SS_ENHMETAFILE 0x0000000FL")]
    public const int SS_ENHMETAFILE = 0x0000000F;

    [NativeTypeName("#define SS_ETCHEDHORZ 0x00000010L")]
    public const int SS_ETCHEDHORZ = 0x00000010;

    [NativeTypeName("#define SS_ETCHEDVERT 0x00000011L")]
    public const int SS_ETCHEDVERT = 0x00000011;

    [NativeTypeName("#define SS_ETCHEDFRAME 0x00000012L")]
    public const int SS_ETCHEDFRAME = 0x00000012;

    [NativeTypeName("#define SS_TYPEMASK 0x0000001FL")]
    public const int SS_TYPEMASK = 0x0000001F;

    [NativeTypeName("#define SS_REALSIZECONTROL 0x00000040L")]
    public const int SS_REALSIZECONTROL = 0x00000040;

    [NativeTypeName("#define SS_NOPREFIX 0x00000080L")]
    public const int SS_NOPREFIX = 0x00000080;

    [NativeTypeName("#define SS_NOTIFY 0x00000100L")]
    public const int SS_NOTIFY = 0x00000100;

    [NativeTypeName("#define SS_CENTERIMAGE 0x00000200L")]
    public const int SS_CENTERIMAGE = 0x00000200;

    [NativeTypeName("#define SS_RIGHTJUST 0x00000400L")]
    public const int SS_RIGHTJUST = 0x00000400;

    [NativeTypeName("#define SS_REALSIZEIMAGE 0x00000800L")]
    public const int SS_REALSIZEIMAGE = 0x00000800;

    [NativeTypeName("#define SS_SUNKEN 0x00001000L")]
    public const int SS_SUNKEN = 0x00001000;

    [NativeTypeName("#define SS_EDITCONTROL 0x00002000L")]
    public const int SS_EDITCONTROL = 0x00002000;

    [NativeTypeName("#define SS_ENDELLIPSIS 0x00004000L")]
    public const int SS_ENDELLIPSIS = 0x00004000;

    [NativeTypeName("#define SS_PATHELLIPSIS 0x00008000L")]
    public const int SS_PATHELLIPSIS = 0x00008000;

    [NativeTypeName("#define SS_WORDELLIPSIS 0x0000C000L")]
    public const int SS_WORDELLIPSIS = 0x0000C000;

    [NativeTypeName("#define SS_ELLIPSISMASK 0x0000C000L")]
    public const int SS_ELLIPSISMASK = 0x0000C000;
}
