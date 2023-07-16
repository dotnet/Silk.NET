// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PSP
{
    [NativeTypeName("#define PSP_DEFAULT 0x00000000")]
    public const int PSP_DEFAULT = 0x00000000;
    [NativeTypeName("#define PSP_DLGINDIRECT 0x00000001")]
    public const int PSP_DLGINDIRECT = 0x00000001;
    [NativeTypeName("#define PSP_USEHICON 0x00000002")]
    public const int PSP_USEHICON = 0x00000002;
    [NativeTypeName("#define PSP_USEICONID 0x00000004")]
    public const int PSP_USEICONID = 0x00000004;
    [NativeTypeName("#define PSP_USETITLE 0x00000008")]
    public const int PSP_USETITLE = 0x00000008;
    [NativeTypeName("#define PSP_RTLREADING 0x00000010")]
    public const int PSP_RTLREADING = 0x00000010;
    [NativeTypeName("#define PSP_HASHELP 0x00000020")]
    public const int PSP_HASHELP = 0x00000020;
    [NativeTypeName("#define PSP_USEREFPARENT 0x00000040")]
    public const int PSP_USEREFPARENT = 0x00000040;
    [NativeTypeName("#define PSP_USECALLBACK 0x00000080")]
    public const int PSP_USECALLBACK = 0x00000080;
    [NativeTypeName("#define PSP_PREMATURE 0x00000400")]
    public const int PSP_PREMATURE = 0x00000400;
    [NativeTypeName("#define PSP_HIDEHEADER 0x00000800")]
    public const int PSP_HIDEHEADER = 0x00000800;
    [NativeTypeName("#define PSP_USEHEADERTITLE 0x00001000")]
    public const int PSP_USEHEADERTITLE = 0x00001000;
    [NativeTypeName("#define PSP_USEHEADERSUBTITLE 0x00002000")]
    public const int PSP_USEHEADERSUBTITLE = 0x00002000;
    [NativeTypeName("#define PSP_USEFUSIONCONTEXT 0x00004000")]
    public const int PSP_USEFUSIONCONTEXT = 0x00004000;
}