// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class OBJID
{
    [NativeTypeName("#define OBJID_WINDOW ((LONG)0x00000000)")]
    public const int OBJID_WINDOW = ((int)(0x00000000));
    [NativeTypeName("#define OBJID_SYSMENU ((LONG)0xFFFFFFFF)")]
    public const int OBJID_SYSMENU = unchecked((int)(0xFFFFFFFF));
    [NativeTypeName("#define OBJID_TITLEBAR ((LONG)0xFFFFFFFE)")]
    public const int OBJID_TITLEBAR = unchecked((int)(0xFFFFFFFE));
    [NativeTypeName("#define OBJID_MENU ((LONG)0xFFFFFFFD)")]
    public const int OBJID_MENU = unchecked((int)(0xFFFFFFFD));
    [NativeTypeName("#define OBJID_CLIENT ((LONG)0xFFFFFFFC)")]
    public const int OBJID_CLIENT = unchecked((int)(0xFFFFFFFC));
    [NativeTypeName("#define OBJID_VSCROLL ((LONG)0xFFFFFFFB)")]
    public const int OBJID_VSCROLL = unchecked((int)(0xFFFFFFFB));
    [NativeTypeName("#define OBJID_HSCROLL ((LONG)0xFFFFFFFA)")]
    public const int OBJID_HSCROLL = unchecked((int)(0xFFFFFFFA));
    [NativeTypeName("#define OBJID_SIZEGRIP ((LONG)0xFFFFFFF9)")]
    public const int OBJID_SIZEGRIP = unchecked((int)(0xFFFFFFF9));
    [NativeTypeName("#define OBJID_CARET ((LONG)0xFFFFFFF8)")]
    public const int OBJID_CARET = unchecked((int)(0xFFFFFFF8));
    [NativeTypeName("#define OBJID_CURSOR ((LONG)0xFFFFFFF7)")]
    public const int OBJID_CURSOR = unchecked((int)(0xFFFFFFF7));
    [NativeTypeName("#define OBJID_ALERT ((LONG)0xFFFFFFF6)")]
    public const int OBJID_ALERT = unchecked((int)(0xFFFFFFF6));
    [NativeTypeName("#define OBJID_SOUND ((LONG)0xFFFFFFF5)")]
    public const int OBJID_SOUND = unchecked((int)(0xFFFFFFF5));
    [NativeTypeName("#define OBJID_QUERYCLASSNAMEIDX ((LONG)0xFFFFFFF4)")]
    public const int OBJID_QUERYCLASSNAMEIDX = unchecked((int)(0xFFFFFFF4));
    [NativeTypeName("#define OBJID_NATIVEOM ((LONG)0xFFFFFFF0)")]
    public const int OBJID_NATIVEOM = unchecked((int)(0xFFFFFFF0));
}