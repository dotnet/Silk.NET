// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DCX
{
    [NativeTypeName("#define DCX_WINDOW 0x00000001L")]
    public const int DCX_WINDOW = 0x00000001;
    [NativeTypeName("#define DCX_CACHE 0x00000002L")]
    public const int DCX_CACHE = 0x00000002;
    [NativeTypeName("#define DCX_NORESETATTRS 0x00000004L")]
    public const int DCX_NORESETATTRS = 0x00000004;
    [NativeTypeName("#define DCX_CLIPCHILDREN 0x00000008L")]
    public const int DCX_CLIPCHILDREN = 0x00000008;
    [NativeTypeName("#define DCX_CLIPSIBLINGS 0x00000010L")]
    public const int DCX_CLIPSIBLINGS = 0x00000010;
    [NativeTypeName("#define DCX_PARENTCLIP 0x00000020L")]
    public const int DCX_PARENTCLIP = 0x00000020;
    [NativeTypeName("#define DCX_EXCLUDERGN 0x00000040L")]
    public const int DCX_EXCLUDERGN = 0x00000040;
    [NativeTypeName("#define DCX_INTERSECTRGN 0x00000080L")]
    public const int DCX_INTERSECTRGN = 0x00000080;
    [NativeTypeName("#define DCX_EXCLUDEUPDATE 0x00000100L")]
    public const int DCX_EXCLUDEUPDATE = 0x00000100;
    [NativeTypeName("#define DCX_INTERSECTUPDATE 0x00000200L")]
    public const int DCX_INTERSECTUPDATE = 0x00000200;
    [NativeTypeName("#define DCX_LOCKWINDOWUPDATE 0x00000400L")]
    public const int DCX_LOCKWINDOWUPDATE = 0x00000400;
    [NativeTypeName("#define DCX_VALIDATE 0x00200000L")]
    public const int DCX_VALIDATE = 0x00200000;
}