// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PSH
{
    [NativeTypeName("#define PSH_DEFAULT 0x00000000")]
    public const int PSH_DEFAULT = 0x00000000;

    [NativeTypeName("#define PSH_PROPTITLE 0x00000001")]
    public const int PSH_PROPTITLE = 0x00000001;

    [NativeTypeName("#define PSH_USEHICON 0x00000002")]
    public const int PSH_USEHICON = 0x00000002;

    [NativeTypeName("#define PSH_USEICONID 0x00000004")]
    public const int PSH_USEICONID = 0x00000004;

    [NativeTypeName("#define PSH_PROPSHEETPAGE 0x00000008")]
    public const int PSH_PROPSHEETPAGE = 0x00000008;

    [NativeTypeName("#define PSH_WIZARDHASFINISH 0x00000010")]
    public const int PSH_WIZARDHASFINISH = 0x00000010;

    [NativeTypeName("#define PSH_WIZARD 0x00000020")]
    public const int PSH_WIZARD = 0x00000020;

    [NativeTypeName("#define PSH_USEPSTARTPAGE 0x00000040")]
    public const int PSH_USEPSTARTPAGE = 0x00000040;

    [NativeTypeName("#define PSH_NOAPPLYNOW 0x00000080")]
    public const int PSH_NOAPPLYNOW = 0x00000080;

    [NativeTypeName("#define PSH_USECALLBACK 0x00000100")]
    public const int PSH_USECALLBACK = 0x00000100;

    [NativeTypeName("#define PSH_HASHELP 0x00000200")]
    public const int PSH_HASHELP = 0x00000200;

    [NativeTypeName("#define PSH_MODELESS 0x00000400")]
    public const int PSH_MODELESS = 0x00000400;

    [NativeTypeName("#define PSH_RTLREADING 0x00000800")]
    public const int PSH_RTLREADING = 0x00000800;

    [NativeTypeName("#define PSH_WIZARDCONTEXTHELP 0x00001000")]
    public const int PSH_WIZARDCONTEXTHELP = 0x00001000;

    [NativeTypeName("#define PSH_WIZARD97 0x01000000")]
    public const int PSH_WIZARD97 = 0x01000000;

    [NativeTypeName("#define PSH_WATERMARK 0x00008000")]
    public const int PSH_WATERMARK = 0x00008000;

    [NativeTypeName("#define PSH_USEHBMWATERMARK 0x00010000")]
    public const int PSH_USEHBMWATERMARK = 0x00010000;

    [NativeTypeName("#define PSH_USEHPLWATERMARK 0x00020000")]
    public const int PSH_USEHPLWATERMARK = 0x00020000;

    [NativeTypeName("#define PSH_STRETCHWATERMARK 0x00040000")]
    public const int PSH_STRETCHWATERMARK = 0x00040000;

    [NativeTypeName("#define PSH_HEADER 0x00080000")]
    public const int PSH_HEADER = 0x00080000;

    [NativeTypeName("#define PSH_USEHBMHEADER 0x00100000")]
    public const int PSH_USEHBMHEADER = 0x00100000;

    [NativeTypeName("#define PSH_USEPAGELANG 0x00200000")]
    public const int PSH_USEPAGELANG = 0x00200000;

    [NativeTypeName("#define PSH_WIZARD_LITE 0x00400000")]
    public const int PSH_WIZARD_LITE = 0x00400000;

    [NativeTypeName("#define PSH_NOCONTEXTHELP 0x02000000")]
    public const int PSH_NOCONTEXTHELP = 0x02000000;

    [NativeTypeName("#define PSH_AEROWIZARD 0x00004000")]
    public const int PSH_AEROWIZARD = 0x00004000;

    [NativeTypeName("#define PSH_RESIZABLE 0x04000000")]
    public const int PSH_RESIZABLE = 0x04000000;

    [NativeTypeName("#define PSH_HEADERBITMAP 0x08000000")]
    public const int PSH_HEADERBITMAP = 0x08000000;

    [NativeTypeName("#define PSH_NOMARGIN 0x10000000")]
    public const int PSH_NOMARGIN = 0x10000000;
}
