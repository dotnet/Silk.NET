// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmInstallIMEA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HKL ImmInstallIMEA([NativeTypeName("LPCSTR")] sbyte* lpszIMEFileName, [NativeTypeName("LPCSTR")] sbyte* lpszLayoutText);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmInstallIMEW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HKL ImmInstallIMEW([NativeTypeName("LPCWSTR")] ushort* lpszIMEFileName, [NativeTypeName("LPCWSTR")] ushort* lpszLayoutText);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetDefaultIMEWnd"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HWND ImmGetDefaultIMEWnd(HWND param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetDescriptionA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmGetDescriptionA(HKL param0, [NativeTypeName("LPSTR")] sbyte* lpszDescription, uint uBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetDescriptionW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmGetDescriptionW(HKL param0, [NativeTypeName("LPWSTR")] ushort* lpszDescription, uint uBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetIMEFileNameA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmGetIMEFileNameA(HKL param0, [NativeTypeName("LPSTR")] sbyte* lpszFileName, uint uBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetIMEFileNameW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmGetIMEFileNameW(HKL param0, [NativeTypeName("LPWSTR")] ushort* lpszFileName, uint uBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetProperty"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetProperty(HKL param0, [NativeTypeName("DWORD")] uint param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmIsIME"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmIsIME(HKL param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSimulateHotKey"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSimulateHotKey(HWND param0, [NativeTypeName("DWORD")] uint param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmCreateContext"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HIMC ImmCreateContext();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmDestroyContext"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmDestroyContext(HIMC param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetContext"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HIMC ImmGetContext(HWND param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmReleaseContext"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmReleaseContext(HWND param0, HIMC param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmAssociateContext"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HIMC ImmAssociateContext(HWND param0, HIMC param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmAssociateContextEx"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmAssociateContextEx(HWND param0, HIMC param1, [NativeTypeName("DWORD")] uint param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCompositionStringA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int ImmGetCompositionStringA(HIMC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPVOID")] void* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCompositionStringW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int ImmGetCompositionStringW(HIMC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPVOID")] void* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetCompositionStringA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetCompositionStringA(HIMC param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* lpComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* lpRead, [NativeTypeName("DWORD")] uint dwReadLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetCompositionStringW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetCompositionStringW(HIMC param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* lpComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* lpRead, [NativeTypeName("DWORD")] uint dwReadLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCandidateListCountA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetCandidateListCountA(HIMC param0, [NativeTypeName("LPDWORD")] uint* lpdwListCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCandidateListCountW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetCandidateListCountW(HIMC param0, [NativeTypeName("LPDWORD")] uint* lpdwListCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCandidateListA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetCandidateListA(HIMC param0, [NativeTypeName("DWORD")] uint deIndex, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpCandList, [NativeTypeName("DWORD")] uint dwBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCandidateListW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetCandidateListW(HIMC param0, [NativeTypeName("DWORD")] uint deIndex, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpCandList, [NativeTypeName("DWORD")] uint dwBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetGuideLineA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetGuideLineA(HIMC param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetGuideLineW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetGuideLineW(HIMC param0, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpBuf, [NativeTypeName("DWORD")] uint dwBufLen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetConversionStatus"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetConversionStatus(HIMC param0, [NativeTypeName("LPDWORD")] uint* lpfdwConversion, [NativeTypeName("LPDWORD")] uint* lpfdwSentence);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetConversionStatus"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetConversionStatus(HIMC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetOpenStatus"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetOpenStatus(HIMC param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetOpenStatus"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetOpenStatus(HIMC param0, BOOL param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCompositionFontA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetCompositionFontA(HIMC param0, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lplf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCompositionFontW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetCompositionFontW(HIMC param0, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lplf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetCompositionFontA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetCompositionFontA(HIMC param0, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lplf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetCompositionFontW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetCompositionFontW(HIMC param0, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lplf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmConfigureIMEA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmConfigureIMEA(HKL param0, HWND param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPVOID")] void* param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmConfigureIMEW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmConfigureIMEW(HKL param0, HWND param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPVOID")] void* param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmEscapeA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern LRESULT ImmEscapeA(HKL param0, HIMC param1, uint param2, [NativeTypeName("LPVOID")] void* param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmEscapeW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern LRESULT ImmEscapeW(HKL param0, HIMC param1, uint param2, [NativeTypeName("LPVOID")] void* param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetConversionListA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetConversionListA(HKL param0, HIMC param1, [NativeTypeName("LPCSTR")] sbyte* lpSrc, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpDst, [NativeTypeName("DWORD")] uint dwBufLen, uint uFlag);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetConversionListW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetConversionListW(HKL param0, HIMC param1, [NativeTypeName("LPCWSTR")] ushort* lpSrc, [NativeTypeName("LPCANDIDATELIST")] CANDIDATELIST* lpDst, [NativeTypeName("DWORD")] uint dwBufLen, uint uFlag);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmNotifyIME"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmNotifyIME(HIMC param0, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetStatusWindowPos"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetStatusWindowPos(HIMC param0, [NativeTypeName("LPPOINT")] POINT* lpptPos);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetStatusWindowPos"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetStatusWindowPos(HIMC param0, [NativeTypeName("LPPOINT")] POINT* lpptPos);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCompositionWindow"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetCompositionWindow(HIMC param0, [NativeTypeName("LPCOMPOSITIONFORM")] COMPOSITIONFORM* lpCompForm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetCompositionWindow"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetCompositionWindow(HIMC param0, [NativeTypeName("LPCOMPOSITIONFORM")] COMPOSITIONFORM* lpCompForm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetCandidateWindow"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetCandidateWindow(HIMC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPCANDIDATEFORM")] CANDIDATEFORM* lpCandidate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetCandidateWindow"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetCandidateWindow(HIMC param0, [NativeTypeName("LPCANDIDATEFORM")] CANDIDATEFORM* lpCandidate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmIsUIMessageA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmIsUIMessageA(HWND param0, uint param1, WPARAM param2, LPARAM param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmIsUIMessageW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmIsUIMessageW(HWND param0, uint param1, WPARAM param2, LPARAM param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetVirtualKey"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmGetVirtualKey(HWND param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmRegisterWordA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmRegisterWordA(HKL param0, [NativeTypeName("LPCSTR")] sbyte* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCSTR")] sbyte* lpszRegister);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmRegisterWordW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmRegisterWordW(HKL param0, [NativeTypeName("LPCWSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCWSTR")] ushort* lpszRegister);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmUnregisterWordA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmUnregisterWordA(HKL param0, [NativeTypeName("LPCSTR")] sbyte* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCSTR")] sbyte* lpszUnregister);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmUnregisterWordW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmUnregisterWordW(HKL param0, [NativeTypeName("LPCWSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPCWSTR")] ushort* lpszUnregister);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetRegisterWordStyleA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmGetRegisterWordStyleA(HKL param0, uint nItem, [NativeTypeName("LPSTYLEBUFA")] STYLEBUFA* lpStyleBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetRegisterWordStyleW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmGetRegisterWordStyleW(HKL param0, uint nItem, [NativeTypeName("LPSTYLEBUFW")] STYLEBUFW* lpStyleBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmEnumRegisterWordA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmEnumRegisterWordA(HKL param0, [NativeTypeName("REGISTERWORDENUMPROCA")] delegate* unmanaged<sbyte*, uint, sbyte*, void*, int> param1, [NativeTypeName("LPCSTR")] sbyte* lpszReading, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPCSTR")] sbyte* lpszRegister, [NativeTypeName("LPVOID")] void* param5);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmEnumRegisterWordW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern uint ImmEnumRegisterWordW(HKL param0, [NativeTypeName("REGISTERWORDENUMPROCW")] delegate* unmanaged<ushort*, uint, ushort*, void*, int> param1, [NativeTypeName("LPCWSTR")] ushort* lpszReading, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPCWSTR")] ushort* lpszRegister, [NativeTypeName("LPVOID")] void* param5);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmDisableIME"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmDisableIME([NativeTypeName("DWORD")] uint param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmEnumInputContext"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmEnumInputContext([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("IMCENUMPROC")] delegate* unmanaged<HIMC, LPARAM, BOOL> lpfn, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetImeMenuItemsA"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetImeMenuItemsA(HIMC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPIMEMENUITEMINFOA")] IMEMENUITEMINFOA* lpImeParentMenu, [NativeTypeName("LPIMEMENUITEMINFOA")] IMEMENUITEMINFOA* lpImeMenu, [NativeTypeName("DWORD")] uint dwSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetImeMenuItemsW"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetImeMenuItemsW(HIMC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPIMEMENUITEMINFOW")] IMEMENUITEMINFOW* lpImeParentMenu, [NativeTypeName("LPIMEMENUITEMINFOW")] IMEMENUITEMINFOW* lpImeMenu, [NativeTypeName("DWORD")] uint dwSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmDisableTextFrameService"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmDisableTextFrameService([NativeTypeName("DWORD")] uint idThread);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmDisableLegacyIME"]/*'/>
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmDisableLegacyIME();
    [NativeTypeName("#define STYLE_DESCRIPTION_SIZE 32")]
    public const int STYLE_DESCRIPTION_SIZE = 32;
    [NativeTypeName("#define IMEMENUITEM_STRING_SIZE 80")]
    public const int IMEMENUITEM_STRING_SIZE = 80;
    [NativeTypeName("#define ImmInstallIME ImmInstallIMEW")]
    public static delegate*<ushort*, ushort*, HKL> ImmInstallIME => &ImmInstallIMEW;

    [NativeTypeName("#define ImmGetDescription ImmGetDescriptionW")]
    public static delegate*<HKL, ushort*, uint, uint> ImmGetDescription => &ImmGetDescriptionW;

    [NativeTypeName("#define ImmGetIMEFileName ImmGetIMEFileNameW")]
    public static delegate*<HKL, ushort*, uint, uint> ImmGetIMEFileName => &ImmGetIMEFileNameW;

    [NativeTypeName("#define ImmGetCompositionString ImmGetCompositionStringW")]
    public static delegate*<HIMC, uint, void*, uint, int> ImmGetCompositionString => &ImmGetCompositionStringW;

    [NativeTypeName("#define ImmSetCompositionString ImmSetCompositionStringW")]
    public static delegate*<HIMC, uint, void*, uint, void*, uint, BOOL> ImmSetCompositionString => &ImmSetCompositionStringW;

    [NativeTypeName("#define ImmGetCandidateListCount ImmGetCandidateListCountW")]
    public static delegate*<HIMC, uint*, uint> ImmGetCandidateListCount => &ImmGetCandidateListCountW;

    [NativeTypeName("#define ImmGetCandidateList ImmGetCandidateListW")]
    public static delegate*<HIMC, uint, CANDIDATELIST*, uint, uint> ImmGetCandidateList => &ImmGetCandidateListW;

    [NativeTypeName("#define ImmGetGuideLine ImmGetGuideLineW")]
    public static delegate*<HIMC, uint, ushort*, uint, uint> ImmGetGuideLine => &ImmGetGuideLineW;

    [NativeTypeName("#define ImmGetCompositionFont ImmGetCompositionFontW")]
    public static delegate*<HIMC, LOGFONTW*, BOOL> ImmGetCompositionFont => &ImmGetCompositionFontW;

    [NativeTypeName("#define ImmSetCompositionFont ImmSetCompositionFontW")]
    public static delegate*<HIMC, LOGFONTW*, BOOL> ImmSetCompositionFont => &ImmSetCompositionFontW;

    [NativeTypeName("#define ImmConfigureIME ImmConfigureIMEW")]
    public static delegate*<HKL, HWND, uint, void*, BOOL> ImmConfigureIME => &ImmConfigureIMEW;

    [NativeTypeName("#define ImmEscape ImmEscapeW")]
    public static delegate*<HKL, HIMC, uint, void*, LRESULT> ImmEscape => &ImmEscapeW;

    [NativeTypeName("#define ImmGetConversionList ImmGetConversionListW")]
    public static delegate*<HKL, HIMC, ushort*, CANDIDATELIST*, uint, uint, uint> ImmGetConversionList => &ImmGetConversionListW;

    [NativeTypeName("#define ImmIsUIMessage ImmIsUIMessageW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, BOOL> ImmIsUIMessage => &ImmIsUIMessageW;

    [NativeTypeName("#define ImmRegisterWord ImmRegisterWordW")]
    public static delegate*<HKL, ushort*, uint, ushort*, BOOL> ImmRegisterWord => &ImmRegisterWordW;

    [NativeTypeName("#define ImmUnregisterWord ImmUnregisterWordW")]
    public static delegate*<HKL, ushort*, uint, ushort*, BOOL> ImmUnregisterWord => &ImmUnregisterWordW;

    [NativeTypeName("#define ImmGetRegisterWordStyle ImmGetRegisterWordStyleW")]
    public static delegate*<HKL, uint, STYLEBUFW*, uint> ImmGetRegisterWordStyle => &ImmGetRegisterWordStyleW;

    [NativeTypeName("#define ImmEnumRegisterWord ImmEnumRegisterWordW")]
    public static delegate*<HKL, delegate* unmanaged<ushort*, uint, ushort*, void*, int> , ushort*, uint, ushort*, void*, uint> ImmEnumRegisterWord => &ImmEnumRegisterWordW;

    [NativeTypeName("#define ImmGetImeMenuItems ImmGetImeMenuItemsW")]
    public static delegate*<HIMC, uint, uint, IMEMENUITEMINFOW*, IMEMENUITEMINFOW*, uint, uint> ImmGetImeMenuItems => &ImmGetImeMenuItemsW;

    [NativeTypeName("#define ISC_SHOWUICANDIDATEWINDOW 0x00000001")]
    public const int ISC_SHOWUICANDIDATEWINDOW = 0x00000001;
    [NativeTypeName("#define ISC_SHOWUICOMPOSITIONWINDOW 0x80000000")]
    public const uint ISC_SHOWUICOMPOSITIONWINDOW = 0x80000000;
    [NativeTypeName("#define ISC_SHOWUIGUIDELINE 0x40000000")]
    public const int ISC_SHOWUIGUIDELINE = 0x40000000;
    [NativeTypeName("#define ISC_SHOWUIALLCANDIDATEWINDOW 0x0000000F")]
    public const int ISC_SHOWUIALLCANDIDATEWINDOW = 0x0000000F;
    [NativeTypeName("#define ISC_SHOWUIALL 0xC000000F")]
    public const uint ISC_SHOWUIALL = 0xC000000F;
    [NativeTypeName("#define CPS_COMPLETE 0x0001")]
    public const int CPS_COMPLETE = 0x0001;
    [NativeTypeName("#define CPS_CONVERT 0x0002")]
    public const int CPS_CONVERT = 0x0002;
    [NativeTypeName("#define CPS_REVERT 0x0003")]
    public const int CPS_REVERT = 0x0003;
    [NativeTypeName("#define CPS_CANCEL 0x0004")]
    public const int CPS_CANCEL = 0x0004;
    [NativeTypeName("#define IMEVER_0310 0x0003000A")]
    public const int IMEVER_0310 = 0x0003000A;
    [NativeTypeName("#define IMEVER_0400 0x00040000")]
    public const int IMEVER_0400 = 0x00040000;
    [NativeTypeName("#define SELECT_CAP_CONVERSION 0x00000001")]
    public const int SELECT_CAP_CONVERSION = 0x00000001;
    [NativeTypeName("#define SELECT_CAP_SENTENCE 0x00000002")]
    public const int SELECT_CAP_SENTENCE = 0x00000002;
    [NativeTypeName("#define GGL_LEVEL 0x00000001")]
    public const int GGL_LEVEL = 0x00000001;
    [NativeTypeName("#define GGL_INDEX 0x00000002")]
    public const int GGL_INDEX = 0x00000002;
    [NativeTypeName("#define GGL_STRING 0x00000003")]
    public const int GGL_STRING = 0x00000003;
    [NativeTypeName("#define GGL_PRIVATE 0x00000004")]
    public const int GGL_PRIVATE = 0x00000004;
    [NativeTypeName("#define IGP_GETIMEVERSION (DWORD)(-4)")]
    public const uint IGP_GETIMEVERSION = unchecked((uint)(-4));
    [NativeTypeName("#define IGP_PROPERTY 0x00000004")]
    public const int IGP_PROPERTY = 0x00000004;
    [NativeTypeName("#define IGP_CONVERSION 0x00000008")]
    public const int IGP_CONVERSION = 0x00000008;
    [NativeTypeName("#define IGP_SENTENCE 0x0000000c")]
    public const int IGP_SENTENCE = 0x0000000c;
    [NativeTypeName("#define IGP_UI 0x00000010")]
    public const int IGP_UI = 0x00000010;
    [NativeTypeName("#define IGP_SETCOMPSTR 0x00000014")]
    public const int IGP_SETCOMPSTR = 0x00000014;
    [NativeTypeName("#define IGP_SELECT 0x00000018")]
    public const int IGP_SELECT = 0x00000018;
    [NativeTypeName("#define ATTR_INPUT 0x00")]
    public const int ATTR_INPUT = 0x00;
    [NativeTypeName("#define ATTR_TARGET_CONVERTED 0x01")]
    public const int ATTR_TARGET_CONVERTED = 0x01;
    [NativeTypeName("#define ATTR_CONVERTED 0x02")]
    public const int ATTR_CONVERTED = 0x02;
    [NativeTypeName("#define ATTR_TARGET_NOTCONVERTED 0x03")]
    public const int ATTR_TARGET_NOTCONVERTED = 0x03;
    [NativeTypeName("#define ATTR_INPUT_ERROR 0x04")]
    public const int ATTR_INPUT_ERROR = 0x04;
    [NativeTypeName("#define ATTR_FIXEDCONVERTED 0x05")]
    public const int ATTR_FIXEDCONVERTED = 0x05;
    [NativeTypeName("#define CFS_DEFAULT 0x0000")]
    public const int CFS_DEFAULT = 0x0000;
    [NativeTypeName("#define CFS_RECT 0x0001")]
    public const int CFS_RECT = 0x0001;
    [NativeTypeName("#define CFS_POINT 0x0002")]
    public const int CFS_POINT = 0x0002;
    [NativeTypeName("#define CFS_FORCE_POSITION 0x0020")]
    public const int CFS_FORCE_POSITION = 0x0020;
    [NativeTypeName("#define CFS_CANDIDATEPOS 0x0040")]
    public const int CFS_CANDIDATEPOS = 0x0040;
    [NativeTypeName("#define CFS_EXCLUDE 0x0080")]
    public const int CFS_EXCLUDE = 0x0080;
    [NativeTypeName("#define IMR_COMPOSITIONWINDOW 0x0001")]
    public const int IMR_COMPOSITIONWINDOW = 0x0001;
    [NativeTypeName("#define IMR_CANDIDATEWINDOW 0x0002")]
    public const int IMR_CANDIDATEWINDOW = 0x0002;
    [NativeTypeName("#define IMR_COMPOSITIONFONT 0x0003")]
    public const int IMR_COMPOSITIONFONT = 0x0003;
    [NativeTypeName("#define IMR_RECONVERTSTRING 0x0004")]
    public const int IMR_RECONVERTSTRING = 0x0004;
    [NativeTypeName("#define IMR_CONFIRMRECONVERTSTRING 0x0005")]
    public const int IMR_CONFIRMRECONVERTSTRING = 0x0005;
    [NativeTypeName("#define IMR_QUERYCHARPOSITION 0x0006")]
    public const int IMR_QUERYCHARPOSITION = 0x0006;
    [NativeTypeName("#define IMR_DOCUMENTFEED 0x0007")]
    public const int IMR_DOCUMENTFEED = 0x0007;
    [NativeTypeName("#define IMM_ERROR_NODATA (-1)")]
    public const int IMM_ERROR_NODATA = (-1);
    [NativeTypeName("#define IMM_ERROR_GENERAL (-2)")]
    public const int IMM_ERROR_GENERAL = (-2);
    [NativeTypeName("#define IACE_CHILDREN 0x0001")]
    public const int IACE_CHILDREN = 0x0001;
    [NativeTypeName("#define IACE_DEFAULT 0x0010")]
    public const int IACE_DEFAULT = 0x0010;
    [NativeTypeName("#define IACE_IGNORENOCONTEXT 0x0020")]
    public const int IACE_IGNORENOCONTEXT = 0x0020;
    [NativeTypeName("#define IGIMIF_RIGHTMENU 0x0001")]
    public const int IGIMIF_RIGHTMENU = 0x0001;
    [NativeTypeName("#define IGIMII_CMODE 0x0001")]
    public const int IGIMII_CMODE = 0x0001;
    [NativeTypeName("#define IGIMII_SMODE 0x0002")]
    public const int IGIMII_SMODE = 0x0002;
    [NativeTypeName("#define IGIMII_CONFIGURE 0x0004")]
    public const int IGIMII_CONFIGURE = 0x0004;
    [NativeTypeName("#define IGIMII_TOOLS 0x0008")]
    public const int IGIMII_TOOLS = 0x0008;
    [NativeTypeName("#define IGIMII_HELP 0x0010")]
    public const int IGIMII_HELP = 0x0010;
    [NativeTypeName("#define IGIMII_OTHER 0x0020")]
    public const int IGIMII_OTHER = 0x0020;
    [NativeTypeName("#define IGIMII_INPUTTOOLS 0x0040")]
    public const int IGIMII_INPUTTOOLS = 0x0040;
    [NativeTypeName("#define IMFT_RADIOCHECK 0x00001")]
    public const int IMFT_RADIOCHECK = 0x00001;
    [NativeTypeName("#define IMFT_SEPARATOR 0x00002")]
    public const int IMFT_SEPARATOR = 0x00002;
    [NativeTypeName("#define IMFT_SUBMENU 0x00004")]
    public const int IMFT_SUBMENU = 0x00004;
    [NativeTypeName("#define IMFS_GRAYED MFS_GRAYED")]
    public const int IMFS_GRAYED = 0x00000003;
    [NativeTypeName("#define IMFS_DISABLED MFS_DISABLED")]
    public const int IMFS_DISABLED = 0x00000003;
    [NativeTypeName("#define IMFS_CHECKED MFS_CHECKED")]
    public const int IMFS_CHECKED = 0x00000008;
    [NativeTypeName("#define IMFS_HILITE MFS_HILITE")]
    public const int IMFS_HILITE = 0x00000080;
    [NativeTypeName("#define IMFS_ENABLED MFS_ENABLED")]
    public const int IMFS_ENABLED = 0x00000000;
    [NativeTypeName("#define IMFS_UNCHECKED MFS_UNCHECKED")]
    public const int IMFS_UNCHECKED = 0x00000000;
    [NativeTypeName("#define IMFS_UNHILITE MFS_UNHILITE")]
    public const int IMFS_UNHILITE = 0x00000000;
    [NativeTypeName("#define IMFS_DEFAULT MFS_DEFAULT")]
    public const int IMFS_DEFAULT = 0x00001000;
    [NativeTypeName("#define SOFTKEYBOARD_TYPE_T1 0x0001")]
    public const int SOFTKEYBOARD_TYPE_T1 = 0x0001;
    [NativeTypeName("#define SOFTKEYBOARD_TYPE_C1 0x0002")]
    public const int SOFTKEYBOARD_TYPE_C1 = 0x0002;
}