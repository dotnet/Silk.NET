// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CBEM
{
    [NativeTypeName("#define CBEM_INSERTITEMA (WM_USER + 1)")]
    public const int CBEM_INSERTITEMA = (0x0400 + 1);
    [NativeTypeName("#define CBEM_SETIMAGELIST (WM_USER + 2)")]
    public const int CBEM_SETIMAGELIST = (0x0400 + 2);
    [NativeTypeName("#define CBEM_GETIMAGELIST (WM_USER + 3)")]
    public const int CBEM_GETIMAGELIST = (0x0400 + 3);
    [NativeTypeName("#define CBEM_GETITEMA (WM_USER + 4)")]
    public const int CBEM_GETITEMA = (0x0400 + 4);
    [NativeTypeName("#define CBEM_SETITEMA (WM_USER + 5)")]
    public const int CBEM_SETITEMA = (0x0400 + 5);
    [NativeTypeName("#define CBEM_DELETEITEM CB_DELETESTRING")]
    public const int CBEM_DELETEITEM = 0x0144;
    [NativeTypeName("#define CBEM_GETCOMBOCONTROL (WM_USER + 6)")]
    public const int CBEM_GETCOMBOCONTROL = (0x0400 + 6);
    [NativeTypeName("#define CBEM_GETEDITCONTROL (WM_USER + 7)")]
    public const int CBEM_GETEDITCONTROL = (0x0400 + 7);
    [NativeTypeName("#define CBEM_SETEXSTYLE (WM_USER + 8)")]
    public const int CBEM_SETEXSTYLE = (0x0400 + 8);
    [NativeTypeName("#define CBEM_SETEXTENDEDSTYLE (WM_USER + 14)")]
    public const int CBEM_SETEXTENDEDSTYLE = (0x0400 + 14);
    [NativeTypeName("#define CBEM_GETEXSTYLE (WM_USER + 9)")]
    public const int CBEM_GETEXSTYLE = (0x0400 + 9);
    [NativeTypeName("#define CBEM_GETEXTENDEDSTYLE (WM_USER + 9)")]
    public const int CBEM_GETEXTENDEDSTYLE = (0x0400 + 9);
    [NativeTypeName("#define CBEM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int CBEM_SETUNICODEFORMAT = (0x2000 + 5);
    [NativeTypeName("#define CBEM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int CBEM_GETUNICODEFORMAT = (0x2000 + 6);
    [NativeTypeName("#define CBEM_HASEDITCHANGED (WM_USER + 10)")]
    public const int CBEM_HASEDITCHANGED = (0x0400 + 10);
    [NativeTypeName("#define CBEM_INSERTITEMW (WM_USER + 11)")]
    public const int CBEM_INSERTITEMW = (0x0400 + 11);
    [NativeTypeName("#define CBEM_SETITEMW (WM_USER + 12)")]
    public const int CBEM_SETITEMW = (0x0400 + 12);
    [NativeTypeName("#define CBEM_GETITEMW (WM_USER + 13)")]
    public const int CBEM_GETITEMW = (0x0400 + 13);
    [NativeTypeName("#define CBEM_INSERTITEM CBEM_INSERTITEMW")]
    public const int CBEM_INSERTITEM = (0x0400 + 11);
    [NativeTypeName("#define CBEM_SETITEM CBEM_SETITEMW")]
    public const int CBEM_SETITEM = (0x0400 + 12);
    [NativeTypeName("#define CBEM_GETITEM CBEM_GETITEMW")]
    public const int CBEM_GETITEM = (0x0400 + 13);
    [NativeTypeName("#define CBEM_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
    public const int CBEM_SETWINDOWTHEME = (0x2000 + 0xb);
}