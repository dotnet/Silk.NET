// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HPROPSHEETPAGE CreatePropertySheetPageA(
        [NativeTypeName("LPCPROPSHEETPAGEA")] PROPSHEETPAGEA* constPropSheetPagePointer
    );

    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HPROPSHEETPAGE CreatePropertySheetPageW(
        [NativeTypeName("LPCPROPSHEETPAGEW")] PROPSHEETPAGEW* constPropSheetPagePointer
    );

    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL DestroyPropertySheetPage(HPROPSHEETPAGE param0);

    [DllImport("comctl32", ExactSpelling = true)]
    [return: NativeTypeName("INT_PTR")]
    public static extern nint PropertySheetA(
        [NativeTypeName("LPCPROPSHEETHEADERA")] PROPSHEETHEADERA_V2* param0
    );

    [DllImport("comctl32", ExactSpelling = true)]
    [return: NativeTypeName("INT_PTR")]
    public static extern nint PropertySheetW(
        [NativeTypeName("LPCPROPSHEETHEADERW")] PROPSHEETHEADERW_V2* param0
    );

    [NativeTypeName("#define SNDMSG ::SendMessage")]
    public static delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> SNDMSG => &SendMessageW;

    [NativeTypeName("#define PSTMSG ::PostMessage")]
    public static delegate* <HWND, uint, WPARAM, LPARAM, BOOL> PSTMSG => &PostMessageW;

    [NativeTypeName("#define MAXPROPPAGES 100")]
    public const int MAXPROPPAGES = 100;

    [NativeTypeName("#define PSPCB_ADDREF 0")]
    public const int PSPCB_ADDREF = 0;

    [NativeTypeName("#define PSPCB_RELEASE 1")]
    public const int PSPCB_RELEASE = 1;

    [NativeTypeName("#define PSPCB_CREATE 2")]
    public const int PSPCB_CREATE = 2;

    [NativeTypeName("#define PROPSHEETPAGEA_V1_SIZE sizeof(PROPSHEETPAGEA_V1)")]
    public static uint PROPSHEETPAGEA_V1_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA_V1))));

    [NativeTypeName("#define PROPSHEETPAGEW_V1_SIZE sizeof(PROPSHEETPAGEW_V1)")]
    public static uint PROPSHEETPAGEW_V1_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V1))));

    [NativeTypeName("#define PROPSHEETPAGEA_V2_SIZE sizeof(PROPSHEETPAGEA_V2)")]
    public static uint PROPSHEETPAGEA_V2_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA_V2))));

    [NativeTypeName("#define PROPSHEETPAGEW_V2_SIZE sizeof(PROPSHEETPAGEW_V2)")]
    public static uint PROPSHEETPAGEW_V2_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V2))));

    [NativeTypeName("#define PROPSHEETPAGEA_V3_SIZE sizeof(PROPSHEETPAGEA_V3)")]
    public static uint PROPSHEETPAGEA_V3_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA_V3))));

    [NativeTypeName("#define PROPSHEETPAGEW_V3_SIZE sizeof(PROPSHEETPAGEW_V3)")]
    public static uint PROPSHEETPAGEW_V3_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V3))));

    [NativeTypeName("#define PROPSHEETPAGEA_V4_SIZE sizeof(PROPSHEETPAGEA_V4)")]
    public static uint PROPSHEETPAGEA_V4_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEA))));

    [NativeTypeName("#define PROPSHEETPAGEW_V4_SIZE sizeof(PROPSHEETPAGEW_V4)")]
    public static uint PROPSHEETPAGEW_V4_SIZE => unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW))));

    [NativeTypeName("#define PROPSHEETPAGE_V1_SIZE PROPSHEETPAGEW_V1_SIZE")]
    public static uint PROPSHEETPAGE_V1_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V1))));

    [NativeTypeName("#define PROPSHEETPAGE_V2_SIZE PROPSHEETPAGEW_V2_SIZE")]
    public static uint PROPSHEETPAGE_V2_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETPAGEW_V2))));

    [NativeTypeName("#define PROPSHEETHEADERA_V1_SIZE sizeof(PROPSHEETHEADERA_V1)")]
    public static uint PROPSHEETHEADERA_V1_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETHEADERA_V1))));

    [NativeTypeName("#define PROPSHEETHEADERW_V1_SIZE sizeof(PROPSHEETHEADERW_V1)")]
    public static uint PROPSHEETHEADERW_V1_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V1))));

    [NativeTypeName("#define PROPSHEETHEADERA_V2_SIZE sizeof(PROPSHEETHEADERA_V2)")]
    public static uint PROPSHEETHEADERA_V2_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETHEADERA_V2))));

    [NativeTypeName("#define PROPSHEETHEADERW_V2_SIZE sizeof(PROPSHEETHEADERW_V2)")]
    public static uint PROPSHEETHEADERW_V2_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V2))));

    [NativeTypeName("#define PROPSHEETHEADER_V1_SIZE PROPSHEETHEADERW_V1_SIZE")]
    public static uint PROPSHEETHEADER_V1_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V1))));

    [NativeTypeName("#define PROPSHEETHEADER_V2_SIZE PROPSHEETHEADERW_V2_SIZE")]
    public static uint PROPSHEETHEADER_V2_SIZE =>
        unchecked((uint)((uint)(sizeof(PROPSHEETHEADERW_V2))));

    [NativeTypeName("#define PSCB_INITIALIZED 1")]
    public const int PSCB_INITIALIZED = 1;

    [NativeTypeName("#define PSCB_PRECREATE 2")]
    public const int PSCB_PRECREATE = 2;

    [NativeTypeName("#define PSCB_BUTTONPRESSED 3")]
    public const int PSCB_BUTTONPRESSED = 3;

    [NativeTypeName("#define CreatePropertySheetPage CreatePropertySheetPageW")]
    public static delegate* <PROPSHEETPAGEW*, HPROPSHEETPAGE> CreatePropertySheetPage =>
        &CreatePropertySheetPageW;

    [NativeTypeName("#define PropertySheet PropertySheetW")]
    public static delegate* <PROPSHEETHEADERW_V2*, nint> PropertySheet => &PropertySheetW;

    [NativeTypeName("#define PSNRET_NOERROR 0")]
    public const int PSNRET_NOERROR = 0;

    [NativeTypeName("#define PSNRET_INVALID 1")]
    public const int PSNRET_INVALID = 1;

    [NativeTypeName("#define PSNRET_INVALID_NOCHANGEPAGE 2")]
    public const int PSNRET_INVALID_NOCHANGEPAGE = 2;

    [NativeTypeName("#define PSNRET_MESSAGEHANDLED 3")]
    public const int PSNRET_MESSAGEHANDLED = 3;

    [NativeTypeName("#define PSWIZB_BACK 0x00000001")]
    public const int PSWIZB_BACK = 0x00000001;

    [NativeTypeName("#define PSWIZB_NEXT 0x00000002")]
    public const int PSWIZB_NEXT = 0x00000002;

    [NativeTypeName("#define PSWIZB_FINISH 0x00000004")]
    public const int PSWIZB_FINISH = 0x00000004;

    [NativeTypeName("#define PSWIZB_DISABLEDFINISH 0x00000008")]
    public const int PSWIZB_DISABLEDFINISH = 0x00000008;

    [NativeTypeName("#define PSWIZBF_ELEVATIONREQUIRED 0x00000001")]
    public const int PSWIZBF_ELEVATIONREQUIRED = 0x00000001;

    [NativeTypeName("#define PSWIZB_CANCEL 0x00000010")]
    public const int PSWIZB_CANCEL = 0x00000010;

    [NativeTypeName("#define PSBTN_BACK 0")]
    public const int PSBTN_BACK = 0;

    [NativeTypeName("#define PSBTN_NEXT 1")]
    public const int PSBTN_NEXT = 1;

    [NativeTypeName("#define PSBTN_FINISH 2")]
    public const int PSBTN_FINISH = 2;

    [NativeTypeName("#define PSBTN_OK 3")]
    public const int PSBTN_OK = 3;

    [NativeTypeName("#define PSBTN_APPLYNOW 4")]
    public const int PSBTN_APPLYNOW = 4;

    [NativeTypeName("#define PSBTN_CANCEL 5")]
    public const int PSBTN_CANCEL = 5;

    [NativeTypeName("#define PSBTN_HELP 6")]
    public const int PSBTN_HELP = 6;

    [NativeTypeName("#define PSBTN_MAX 6")]
    public const int PSBTN_MAX = 6;

    [NativeTypeName("#define PSWIZF_SETCOLOR ((UINT)(-1))")]
    public const uint PSWIZF_SETCOLOR = unchecked((uint)(-1));

    [NativeTypeName("#define PSWIZB_SHOW 0")]
    public const int PSWIZB_SHOW = 0;

    [NativeTypeName("#define PSWIZB_RESTORE 1")]
    public const int PSWIZB_RESTORE = 1;

    [NativeTypeName("#define WIZ_CXDLG 276")]
    public const int WIZ_CXDLG = 276;

    [NativeTypeName("#define WIZ_CYDLG 140")]
    public const int WIZ_CYDLG = 140;

    [NativeTypeName("#define WIZ_CXBMP 80")]
    public const int WIZ_CXBMP = 80;

    [NativeTypeName("#define WIZ_BODYX 92")]
    public const int WIZ_BODYX = 92;

    [NativeTypeName("#define WIZ_BODYCX 184")]
    public const int WIZ_BODYCX = 184;

    [NativeTypeName("#define PROP_SM_CXDLG 212")]
    public const int PROP_SM_CXDLG = 212;

    [NativeTypeName("#define PROP_SM_CYDLG 188")]
    public const int PROP_SM_CYDLG = 188;

    [NativeTypeName("#define PROP_MED_CXDLG 227")]
    public const int PROP_MED_CXDLG = 227;

    [NativeTypeName("#define PROP_MED_CYDLG 215")]
    public const int PROP_MED_CYDLG = 215;

    [NativeTypeName("#define PROP_LG_CXDLG 252")]
    public const int PROP_LG_CXDLG = 252;

    [NativeTypeName("#define PROP_LG_CYDLG 218")]
    public const int PROP_LG_CYDLG = 218;
}
