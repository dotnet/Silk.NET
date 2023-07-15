// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class HDM
{
    [NativeTypeName("#define HDM_FIRST 0x1200")]
    public const int HDM_FIRST = 0x1200;
    [NativeTypeName("#define HDM_GETITEMCOUNT (HDM_FIRST + 0)")]
    public const int HDM_GETITEMCOUNT = (0x1200 + 0);
    [NativeTypeName("#define HDM_INSERTITEMA (HDM_FIRST + 1)")]
    public const int HDM_INSERTITEMA = (0x1200 + 1);
    [NativeTypeName("#define HDM_INSERTITEMW (HDM_FIRST + 10)")]
    public const int HDM_INSERTITEMW = (0x1200 + 10);
    [NativeTypeName("#define HDM_INSERTITEM HDM_INSERTITEMW")]
    public const int HDM_INSERTITEM = (0x1200 + 10);
    [NativeTypeName("#define HDM_DELETEITEM (HDM_FIRST + 2)")]
    public const int HDM_DELETEITEM = (0x1200 + 2);
    [NativeTypeName("#define HDM_GETITEMA (HDM_FIRST + 3)")]
    public const int HDM_GETITEMA = (0x1200 + 3);
    [NativeTypeName("#define HDM_GETITEMW (HDM_FIRST + 11)")]
    public const int HDM_GETITEMW = (0x1200 + 11);
    [NativeTypeName("#define HDM_GETITEM HDM_GETITEMW")]
    public const int HDM_GETITEM = (0x1200 + 11);
    [NativeTypeName("#define HDM_SETITEMA (HDM_FIRST + 4)")]
    public const int HDM_SETITEMA = (0x1200 + 4);
    [NativeTypeName("#define HDM_SETITEMW (HDM_FIRST + 12)")]
    public const int HDM_SETITEMW = (0x1200 + 12);
    [NativeTypeName("#define HDM_SETITEM HDM_SETITEMW")]
    public const int HDM_SETITEM = (0x1200 + 12);
    [NativeTypeName("#define HDM_LAYOUT (HDM_FIRST + 5)")]
    public const int HDM_LAYOUT = (0x1200 + 5);
    [NativeTypeName("#define HDM_HITTEST (HDM_FIRST + 6)")]
    public const int HDM_HITTEST = (0x1200 + 6);
    [NativeTypeName("#define HDM_GETITEMRECT (HDM_FIRST + 7)")]
    public const int HDM_GETITEMRECT = (0x1200 + 7);
    [NativeTypeName("#define HDM_SETIMAGELIST (HDM_FIRST + 8)")]
    public const int HDM_SETIMAGELIST = (0x1200 + 8);
    [NativeTypeName("#define HDM_GETIMAGELIST (HDM_FIRST + 9)")]
    public const int HDM_GETIMAGELIST = (0x1200 + 9);
    [NativeTypeName("#define HDM_ORDERTOINDEX (HDM_FIRST + 15)")]
    public const int HDM_ORDERTOINDEX = (0x1200 + 15);
    [NativeTypeName("#define HDM_CREATEDRAGIMAGE (HDM_FIRST + 16)")]
    public const int HDM_CREATEDRAGIMAGE = (0x1200 + 16);
    [NativeTypeName("#define HDM_GETORDERARRAY (HDM_FIRST + 17)")]
    public const int HDM_GETORDERARRAY = (0x1200 + 17);
    [NativeTypeName("#define HDM_SETORDERARRAY (HDM_FIRST + 18)")]
    public const int HDM_SETORDERARRAY = (0x1200 + 18);
    [NativeTypeName("#define HDM_SETHOTDIVIDER (HDM_FIRST + 19)")]
    public const int HDM_SETHOTDIVIDER = (0x1200 + 19);
    [NativeTypeName("#define HDM_SETBITMAPMARGIN (HDM_FIRST + 20)")]
    public const int HDM_SETBITMAPMARGIN = (0x1200 + 20);
    [NativeTypeName("#define HDM_GETBITMAPMARGIN (HDM_FIRST + 21)")]
    public const int HDM_GETBITMAPMARGIN = (0x1200 + 21);
    [NativeTypeName("#define HDM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int HDM_SETUNICODEFORMAT = (0x2000 + 5);
    [NativeTypeName("#define HDM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int HDM_GETUNICODEFORMAT = (0x2000 + 6);
    [NativeTypeName("#define HDM_SETFILTERCHANGETIMEOUT (HDM_FIRST+22)")]
    public const int HDM_SETFILTERCHANGETIMEOUT = (0x1200 + 22);
    [NativeTypeName("#define HDM_EDITFILTER (HDM_FIRST+23)")]
    public const int HDM_EDITFILTER = (0x1200 + 23);
    [NativeTypeName("#define HDM_CLEARFILTER (HDM_FIRST+24)")]
    public const int HDM_CLEARFILTER = (0x1200 + 24);
    [NativeTypeName("#define HDM_GETITEMDROPDOWNRECT (HDM_FIRST+25)")]
    public const int HDM_GETITEMDROPDOWNRECT = (0x1200 + 25);
    [NativeTypeName("#define HDM_GETOVERFLOWRECT (HDM_FIRST+26)")]
    public const int HDM_GETOVERFLOWRECT = (0x1200 + 26);
    [NativeTypeName("#define HDM_GETFOCUSEDITEM (HDM_FIRST+27)")]
    public const int HDM_GETFOCUSEDITEM = (0x1200 + 27);
    [NativeTypeName("#define HDM_SETFOCUSEDITEM (HDM_FIRST+28)")]
    public const int HDM_SETFOCUSEDITEM = (0x1200 + 28);
}