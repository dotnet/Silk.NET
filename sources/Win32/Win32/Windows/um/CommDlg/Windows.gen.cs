// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL GetOpenFileNameA(
        [NativeTypeName("LPOPENFILENAMEA")] OPENFILENAMEA* param0
    );

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL GetOpenFileNameW(
        [NativeTypeName("LPOPENFILENAMEW")] OPENFILENAMEW* param0
    );

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL GetSaveFileNameA(
        [NativeTypeName("LPOPENFILENAMEA")] OPENFILENAMEA* param0
    );

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL GetSaveFileNameW(
        [NativeTypeName("LPOPENFILENAMEW")] OPENFILENAMEW* param0
    );

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern short GetFileTitleA(
        [NativeTypeName("LPCSTR")] sbyte* param0,
        [NativeTypeName("LPSTR")] sbyte* Buf,
        [NativeTypeName("WORD")] ushort cchSize
    );

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern short GetFileTitleW(
        [NativeTypeName("LPCWSTR")] ushort* param0,
        [NativeTypeName("LPWSTR")] ushort* Buf,
        [NativeTypeName("WORD")] ushort cchSize
    );

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL ChooseColorA([NativeTypeName("LPCHOOSECOLORA")] CHOOSECOLORA* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL ChooseColorW([NativeTypeName("LPCHOOSECOLORW")] CHOOSECOLORW* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern HWND FindTextA([NativeTypeName("LPFINDREPLACEA")] FINDREPLACEA* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern HWND FindTextW([NativeTypeName("LPFINDREPLACEW")] FINDREPLACEW* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern HWND ReplaceTextA([NativeTypeName("LPFINDREPLACEA")] FINDREPLACEA* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern HWND ReplaceTextW([NativeTypeName("LPFINDREPLACEW")] FINDREPLACEW* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL ChooseFontA([NativeTypeName("LPCHOOSEFONTA")] CHOOSEFONTA* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL ChooseFontW([NativeTypeName("LPCHOOSEFONTW")] CHOOSEFONTW* param0);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL PrintDlgA([NativeTypeName("LPPRINTDLGA")] PRINTDLGA* pPD);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL PrintDlgW([NativeTypeName("LPPRINTDLGW")] PRINTDLGW* pPD);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern HRESULT PrintDlgExA([NativeTypeName("LPPRINTDLGEXA")] PRINTDLGEXA* pPD);

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern HRESULT PrintDlgExW([NativeTypeName("LPPRINTDLGEXW")] PRINTDLGEXW* pPD);

    [DllImport("comdlg32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CommDlgExtendedError();

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL PageSetupDlgA(
        [NativeTypeName("LPPAGESETUPDLGA")] PAGESETUPDLGA* param0
    );

    [DllImport("comdlg32", ExactSpelling = true)]
    public static extern BOOL PageSetupDlgW(
        [NativeTypeName("LPPAGESETUPDLGW")] PAGESETUPDLGW* param0
    );

    [NativeTypeName("#define GetOpenFileName GetOpenFileNameW")]
    public static delegate* <OPENFILENAMEW*, BOOL> GetOpenFileName => &GetOpenFileNameW;

    [NativeTypeName("#define GetSaveFileName GetSaveFileNameW")]
    public static delegate* <OPENFILENAMEW*, BOOL> GetSaveFileName => &GetSaveFileNameW;

    [NativeTypeName("#define GetFileTitle GetFileTitleW")]
    public static delegate* <ushort*, ushort*, ushort, short> GetFileTitle => &GetFileTitleW;

    [NativeTypeName("#define ChooseColor ChooseColorW")]
    public static delegate* <CHOOSECOLORW*, BOOL> ChooseColor => &ChooseColorW;

    [NativeTypeName("#define FindText FindTextW")]
    public static delegate* <FINDREPLACEW*, HWND> FindText => &FindTextW;

    [NativeTypeName("#define ReplaceText ReplaceTextW")]
    public static delegate* <FINDREPLACEW*, HWND> ReplaceText => &ReplaceTextW;

    [NativeTypeName("#define ChooseFont ChooseFontW")]
    public static delegate* <CHOOSEFONTW*, BOOL> ChooseFont => &ChooseFontW;

    [NativeTypeName("#define SIMULATED_FONTTYPE 0x8000")]
    public const int SIMULATED_FONTTYPE = 0x8000;

    [NativeTypeName("#define PRINTER_FONTTYPE 0x4000")]
    public const int PRINTER_FONTTYPE = 0x4000;

    [NativeTypeName("#define SCREEN_FONTTYPE 0x2000")]
    public const int SCREEN_FONTTYPE = 0x2000;

    [NativeTypeName("#define BOLD_FONTTYPE 0x0100")]
    public const int BOLD_FONTTYPE = 0x0100;

    [NativeTypeName("#define ITALIC_FONTTYPE 0x0200")]
    public const int ITALIC_FONTTYPE = 0x0200;

    [NativeTypeName("#define REGULAR_FONTTYPE 0x0400")]
    public const int REGULAR_FONTTYPE = 0x0400;

    [NativeTypeName("#define TT_OPENTYPE_FONTTYPE 0x20000")]
    public const int TT_OPENTYPE_FONTTYPE = 0x20000;

    [NativeTypeName("#define TYPE1_FONTTYPE 0x40000")]
    public const int TYPE1_FONTTYPE = 0x40000;

    [NativeTypeName("#define SYMBOL_FONTTYPE 0x80000")]
    public const int SYMBOL_FONTTYPE = 0x80000;

    [NativeTypeName("#define LBSELCHSTRINGA \"commdlg_LBSelChangedNotify\"")]
    public static ReadOnlySpan<byte> LBSELCHSTRINGA => "commdlg_LBSelChangedNotify"u8;

    [NativeTypeName("#define SHAREVISTRINGA \"commdlg_ShareViolation\"")]
    public static ReadOnlySpan<byte> SHAREVISTRINGA => "commdlg_ShareViolation"u8;

    [NativeTypeName("#define FILEOKSTRINGA \"commdlg_FileNameOK\"")]
    public static ReadOnlySpan<byte> FILEOKSTRINGA => "commdlg_FileNameOK"u8;

    [NativeTypeName("#define COLOROKSTRINGA \"commdlg_ColorOK\"")]
    public static ReadOnlySpan<byte> COLOROKSTRINGA => "commdlg_ColorOK"u8;

    [NativeTypeName("#define SETRGBSTRINGA \"commdlg_SetRGBColor\"")]
    public static ReadOnlySpan<byte> SETRGBSTRINGA => "commdlg_SetRGBColor"u8;

    [NativeTypeName("#define HELPMSGSTRINGA \"commdlg_help\"")]
    public static ReadOnlySpan<byte> HELPMSGSTRINGA => "commdlg_help"u8;

    [NativeTypeName("#define FINDMSGSTRINGA \"commdlg_FindReplace\"")]
    public static ReadOnlySpan<byte> FINDMSGSTRINGA => "commdlg_FindReplace"u8;

    [NativeTypeName("#define LBSELCHSTRINGW L\"commdlg_LBSelChangedNotify\"")]
    public const string LBSELCHSTRINGW = "commdlg_LBSelChangedNotify";

    [NativeTypeName("#define SHAREVISTRINGW L\"commdlg_ShareViolation\"")]
    public const string SHAREVISTRINGW = "commdlg_ShareViolation";

    [NativeTypeName("#define FILEOKSTRINGW L\"commdlg_FileNameOK\"")]
    public const string FILEOKSTRINGW = "commdlg_FileNameOK";

    [NativeTypeName("#define COLOROKSTRINGW L\"commdlg_ColorOK\"")]
    public const string COLOROKSTRINGW = "commdlg_ColorOK";

    [NativeTypeName("#define SETRGBSTRINGW L\"commdlg_SetRGBColor\"")]
    public const string SETRGBSTRINGW = "commdlg_SetRGBColor";

    [NativeTypeName("#define HELPMSGSTRINGW L\"commdlg_help\"")]
    public const string HELPMSGSTRINGW = "commdlg_help";

    [NativeTypeName("#define FINDMSGSTRINGW L\"commdlg_FindReplace\"")]
    public const string FINDMSGSTRINGW = "commdlg_FindReplace";

    [NativeTypeName("#define LBSELCHSTRING LBSELCHSTRINGW")]
    public const string LBSELCHSTRING = "commdlg_LBSelChangedNotify";

    [NativeTypeName("#define SHAREVISTRING SHAREVISTRINGW")]
    public const string SHAREVISTRING = "commdlg_ShareViolation";

    [NativeTypeName("#define FILEOKSTRING FILEOKSTRINGW")]
    public const string FILEOKSTRING = "commdlg_FileNameOK";

    [NativeTypeName("#define COLOROKSTRING COLOROKSTRINGW")]
    public const string COLOROKSTRING = "commdlg_ColorOK";

    [NativeTypeName("#define SETRGBSTRING SETRGBSTRINGW")]
    public const string SETRGBSTRING = "commdlg_SetRGBColor";

    [NativeTypeName("#define HELPMSGSTRING HELPMSGSTRINGW")]
    public const string HELPMSGSTRING = "commdlg_help";

    [NativeTypeName("#define FINDMSGSTRING FINDMSGSTRINGW")]
    public const string FINDMSGSTRING = "commdlg_FindReplace";

    [NativeTypeName("#define PrintDlg PrintDlgW")]
    public static delegate* <PRINTDLGW*, BOOL> PrintDlg => &PrintDlgW;

    [NativeTypeName("#define PrintDlgEx PrintDlgExW")]
    public static delegate* <PRINTDLGEXW*, HRESULT> PrintDlgEx => &PrintDlgExW;

    [NativeTypeName("#define START_PAGE_GENERAL 0xffffffff")]
    public const uint START_PAGE_GENERAL = 0xffffffff;

    [NativeTypeName("#define DN_DEFAULTPRN 0x0001")]
    public const int DN_DEFAULTPRN = 0x0001;

    [NativeTypeName("#define PageSetupDlg PageSetupDlgW")]
    public static delegate* <PAGESETUPDLGW*, BOOL> PageSetupDlg => &PageSetupDlgW;
}
