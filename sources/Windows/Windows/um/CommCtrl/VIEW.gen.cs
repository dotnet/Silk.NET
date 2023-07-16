// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class VIEW
{
    [NativeTypeName("#define VIEW_LARGEICONS 0")]
    public const int VIEW_LARGEICONS = 0;
    [NativeTypeName("#define VIEW_SMALLICONS 1")]
    public const int VIEW_SMALLICONS = 1;
    [NativeTypeName("#define VIEW_LIST 2")]
    public const int VIEW_LIST = 2;
    [NativeTypeName("#define VIEW_DETAILS 3")]
    public const int VIEW_DETAILS = 3;
    [NativeTypeName("#define VIEW_SORTNAME 4")]
    public const int VIEW_SORTNAME = 4;
    [NativeTypeName("#define VIEW_SORTSIZE 5")]
    public const int VIEW_SORTSIZE = 5;
    [NativeTypeName("#define VIEW_SORTDATE 6")]
    public const int VIEW_SORTDATE = 6;
    [NativeTypeName("#define VIEW_SORTTYPE 7")]
    public const int VIEW_SORTTYPE = 7;
    [NativeTypeName("#define VIEW_PARENTFOLDER 8")]
    public const int VIEW_PARENTFOLDER = 8;
    [NativeTypeName("#define VIEW_NETCONNECT 9")]
    public const int VIEW_NETCONNECT = 9;
    [NativeTypeName("#define VIEW_NETDISCONNECT 10")]
    public const int VIEW_NETDISCONNECT = 10;
    [NativeTypeName("#define VIEW_NEWFOLDER 11")]
    public const int VIEW_NEWFOLDER = 11;
    [NativeTypeName("#define VIEW_VIEWMENU 12")]
    public const int VIEW_VIEWMENU = 12;
}