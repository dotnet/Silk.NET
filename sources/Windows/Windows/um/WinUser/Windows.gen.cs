// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wvsprintfA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int wvsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("va_list")] sbyte* arglist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wvsprintfW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int wvsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("va_list")] sbyte* arglist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wsprintfA"]/*'/>
    [DllImport("user32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int wsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1, __arglist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wsprintfW"]/*'/>
    [DllImport("user32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int wsprintfW([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1, __arglist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadKeyboardLayoutA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HKL LoadKeyboardLayoutA([NativeTypeName("LPCSTR")] sbyte* pwszKLID, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadKeyboardLayoutW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HKL LoadKeyboardLayoutW([NativeTypeName("LPCWSTR")] ushort* pwszKLID, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ActivateKeyboardLayout"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HKL ActivateKeyboardLayout(HKL hkl, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ToUnicodeEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, uint wFlags, HKL dwhkl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnloadKeyboardLayout"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL UnloadKeyboardLayout(HKL hkl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyboardLayoutNameA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetKeyboardLayoutNameA([NativeTypeName("LPSTR")] sbyte* pwszKLID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyboardLayoutNameW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetKeyboardLayoutNameW([NativeTypeName("LPWSTR")] ushort* pwszKLID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyboardLayoutList"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetKeyboardLayoutList(int nBuff, HKL* lpList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyboardLayout"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HKL GetKeyboardLayout([NativeTypeName("DWORD")] uint idThread);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMouseMovePointsEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetMouseMovePointsEx(uint cbSize, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lppt, [NativeTypeName("LPMOUSEMOVEPOINT")] MOUSEMOVEPOINT* lpptBuf, int nBufPoints, [NativeTypeName("DWORD")] uint resolution);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDesktopA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK CreateDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDesktopW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK CreateDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDesktopExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK CreateDesktopExA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, DEVMODEA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDesktopExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK CreateDesktopExW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("LPCWSTR")] ushort* lpszDevice, DEVMODEW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenDesktopA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK OpenDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenDesktopW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK OpenDesktopW([NativeTypeName("LPCWSTR")] ushort* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenInputDesktop"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK OpenInputDesktop([NativeTypeName("DWORD")] uint dwFlags, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDesktopsA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumDesktopsA(HWINSTA hwinsta, [NativeTypeName("DESKTOPENUMPROCA")] delegate* unmanaged<sbyte*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDesktopsW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumDesktopsW(HWINSTA hwinsta, [NativeTypeName("DESKTOPENUMPROCW")] delegate* unmanaged<ushort*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDesktopWindows"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumDesktopWindows(HDESK hDesktop, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpfn, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SwitchDesktop"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SwitchDesktop(HDESK hDesktop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadDesktop"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadDesktop(HDESK hDesktop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseDesktop"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseDesktop(HDESK hDesktop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadDesktop"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDESK GetThreadDesktop([NativeTypeName("DWORD")] uint dwThreadId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWindowStationA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWINSTA CreateWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWindowStationW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWINSTA CreateWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpsa);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenWindowStationA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWINSTA OpenWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpszWinSta, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenWindowStationW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWINSTA OpenWindowStationW([NativeTypeName("LPCWSTR")] ushort* lpszWinSta, BOOL fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumWindowStationsA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumWindowStationsA([NativeTypeName("WINSTAENUMPROCA")] delegate* unmanaged<sbyte*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumWindowStationsW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumWindowStationsW([NativeTypeName("WINSTAENUMPROCW")] delegate* unmanaged<ushort*, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseWindowStation"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseWindowStation(HWINSTA hWinSta);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessWindowStation"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessWindowStation(HWINSTA hWinSta);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessWindowStation"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWINSTA GetProcessWindowStation();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetUserObjectSecurity"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetUserObjectSecurity(HANDLE hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUserObjectSecurity"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserObjectSecurity(HANDLE hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUserObjectInformationA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserObjectInformationA(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUserObjectInformationW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserObjectInformationW(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetUserObjectInformationA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetUserObjectInformationA(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetUserObjectInformationW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetUserObjectInformationW(HANDLE hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsHungAppWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsHungAppWindow(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisableProcessWindowsGhosting"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void DisableProcessWindowsGhosting();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterWindowMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint RegisterWindowMessageA([NativeTypeName("LPCSTR")] sbyte* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterWindowMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint RegisterWindowMessageW([NativeTypeName("LPCWSTR")] ushort* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TrackMouseEvent"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawEdge"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DrawEdge(HDC hdc, [NativeTypeName("LPRECT")] RECT* qrc, uint edge, uint grfFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawFrameControl"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DrawFrameControl(HDC param0, [NativeTypeName("LPRECT")] RECT* param1, uint param2, uint param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawCaption"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DrawCaption(HWND hwnd, HDC hdc, [NativeTypeName("const RECT *")] RECT* lprect, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawAnimatedRects"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DrawAnimatedRects(HWND hwnd, int idAni, [NativeTypeName("const RECT *")] RECT* lprcFrom, [NativeTypeName("const RECT *")] RECT* lprcTo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateMessage"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL TranslateMessage([NativeTypeName("const MSG *")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DispatchMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DispatchMessageA([NativeTypeName("const MSG *")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DispatchMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DispatchMessageW([NativeTypeName("const MSG *")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMessageQueue"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetMessageQueue(int cMessagesMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PeekMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL PeekMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PeekMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL PeekMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterHotKey"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterHotKey(HWND hWnd, int id, uint fsModifiers, uint vk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterHotKey"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterHotKey(HWND hWnd, int id);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExitWindowsEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ExitWindowsEx(uint uFlags, [NativeTypeName("DWORD")] uint dwReason);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SwapMouseButton"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SwapMouseButton(BOOL fSwap);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMessagePos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetMessagePos();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMessageTime"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetMessageTime();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMessageExtraInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LPARAM GetMessageExtraInfo();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUnpredictedMessagePos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint GetUnpredictedMessagePos();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWow64Message"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsWow64Message();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMessageExtraInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LPARAM SetMessageExtraInfo(LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT SendMessageA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT SendMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendMessageTimeoutA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern LRESULT SendMessageTimeoutA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, uint fuFlags, uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendMessageTimeoutW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern LRESULT SendMessageTimeoutW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, uint fuFlags, uint uTimeout, [NativeTypeName("PDWORD_PTR")] nuint* lpdwResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendNotifyMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SendNotifyMessageA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendNotifyMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SendNotifyMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendMessageCallbackA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SendMessageCallbackA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged<HWND, uint, nuint, LRESULT, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendMessageCallbackW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SendMessageCallbackW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged<HWND, uint, nuint, LRESULT, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] nuint dwData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BroadcastSystemMessageExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("long")]
    public static extern int BroadcastSystemMessageExA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BroadcastSystemMessageExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("long")]
    public static extern int BroadcastSystemMessageExW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BroadcastSystemMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("long")]
    public static extern int BroadcastSystemMessageA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BroadcastSystemMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("long")]
    public static extern int BroadcastSystemMessageW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDeviceNotificationA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDEVNOTIFY RegisterDeviceNotificationA(HANDLE hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterDeviceNotificationW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDEVNOTIFY RegisterDeviceNotificationW(HANDLE hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterDeviceNotification"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterDeviceNotification(HDEVNOTIFY Handle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterPowerSettingNotification"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HPOWERNOTIFY RegisterPowerSettingNotification(HANDLE hRecipient, [NativeTypeName("LPCGUID")] Guid* PowerSettingGuid, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterPowerSettingNotification"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterPowerSettingNotification(HPOWERNOTIFY Handle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterSuspendResumeNotification"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern HPOWERNOTIFY RegisterSuspendResumeNotification(HANDLE hRecipient, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterSuspendResumeNotification"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL UnregisterSuspendResumeNotification(HPOWERNOTIFY Handle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PostMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PostMessageA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PostMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PostMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PostThreadMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PostThreadMessageA([NativeTypeName("DWORD")] uint idThread, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PostThreadMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PostThreadMessageW([NativeTypeName("DWORD")] uint idThread, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AttachThreadInput"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AttachThreadInput([NativeTypeName("DWORD")] uint idAttach, [NativeTypeName("DWORD")] uint idAttachTo, BOOL fAttach);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReplyMessage"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ReplyMessage(LRESULT lResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitMessage"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WaitMessage();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForInputIdle"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WaitForInputIdle(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwMilliseconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefWindowProcA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefWindowProcA(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefWindowProcW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefWindowProcW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PostQuitMessage"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void PostQuitMessage(int nExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CallWindowProcA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT CallWindowProcA([NativeTypeName("WNDPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpPrevWndFunc, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CallWindowProcW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT CallWindowProcW([NativeTypeName("WNDPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpPrevWndFunc, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InSendMessage"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL InSendMessage();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InSendMessageEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint InSendMessageEx([NativeTypeName("LPVOID")] void* lpReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDoubleClickTime"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint GetDoubleClickTime();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDoubleClickTime"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDoubleClickTime(uint param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterClassA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort RegisterClassA([NativeTypeName("const WNDCLASSA *")] WNDCLASSA* lpWndClass);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterClassW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort RegisterClassW([NativeTypeName("const WNDCLASSW *")] WNDCLASSW* lpWndClass);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterClassA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterClassA([NativeTypeName("LPCSTR")] sbyte* lpClassName, HINSTANCE hInstance);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterClassW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterClassW([NativeTypeName("LPCWSTR")] ushort* lpClassName, HINSTANCE hInstance);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassInfoA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetClassInfoA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPWNDCLASSA")] WNDCLASSA* lpWndClass);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassInfoW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetClassInfoW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPWNDCLASSW")] WNDCLASSW* lpWndClass);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterClassExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort RegisterClassExA([NativeTypeName("const WNDCLASSEXA *")] WNDCLASSEXA* param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterClassExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort RegisterClassExW([NativeTypeName("const WNDCLASSEXW *")] WNDCLASSEXW* param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassInfoExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetClassInfoExA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPWNDCLASSEXA")] WNDCLASSEXA* lpwcx);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassInfoExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetClassInfoExW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPWNDCLASSEXW")] WNDCLASSEXW* lpwcx);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWindowExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateWindowExA([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWindowExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateWindowExW([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsWindow(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsMenu(HMENU hMenu);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsChild"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsChild(HWND hWndParent, HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyWindow(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ShowWindow(HWND hWnd, int nCmdShow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AnimateWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL AnimateWindow(HWND hWnd, [NativeTypeName("DWORD")] uint dwTime, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateLayeredWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UpdateLayeredWindow(HWND hWnd, HDC hdcDst, POINT* pptDst, SIZE* psize, HDC hdcSrc, POINT* pptSrc, COLORREF crKey, BLENDFUNCTION* pblend, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateLayeredWindowIndirect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL UpdateLayeredWindowIndirect(HWND hWnd, [NativeTypeName("const UPDATELAYEREDWINDOWINFO *")] UPDATELAYEREDWINDOWINFO* pULWInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLayeredWindowAttributes"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetLayeredWindowAttributes(HWND hwnd, COLORREF* pcrKey, byte* pbAlpha, [NativeTypeName("DWORD *")] uint* pdwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrintWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL PrintWindow(HWND hwnd, HDC hdcBlt, uint nFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetLayeredWindowAttributes"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetLayeredWindowAttributes(HWND hwnd, COLORREF crKey, byte bAlpha, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowWindowAsync"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ShowWindowAsync(HWND hWnd, int nCmdShow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlashWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL FlashWindow(HWND hWnd, BOOL bInvert);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlashWindowEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL FlashWindowEx([NativeTypeName("PFLASHWINFO")] FLASHWINFO* pfwi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowOwnedPopups"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShowOwnedPopups(HWND hWnd, BOOL fShow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenIcon"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OpenIcon(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseWindow(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveWindow(HWND hWnd, int X, int Y, int nWidth, int nHeight, BOOL bRepaint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWindowPos(HWND hWnd, HWND hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowPlacement"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetWindowPlacement(HWND hWnd, WINDOWPLACEMENT* lpwndpl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowPlacement"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWindowPlacement(HWND hWnd, [NativeTypeName("const WINDOWPLACEMENT *")] WINDOWPLACEMENT* lpwndpl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowDisplayAffinity"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetWindowDisplayAffinity(HWND hWnd, [NativeTypeName("DWORD *")] uint* pdwAffinity);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowDisplayAffinity"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWindowDisplayAffinity(HWND hWnd, [NativeTypeName("DWORD")] uint dwAffinity);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginDeferWindowPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDWP BeginDeferWindowPos(int nNumWindows);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeferWindowPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDWP DeferWindowPos(HDWP hWinPosInfo, HWND hWnd, HWND hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndDeferWindowPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EndDeferWindowPos(HDWP hWinPosInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWindowVisible"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsWindowVisible(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsIconic"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsIconic(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AnyPopup"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL AnyPopup();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BringWindowToTop"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BringWindowToTop(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsZoomed"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsZoomed(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDialogParamA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateDialogParamA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDialogParamW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateDialogParamW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDialogIndirectParamA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateDialogIndirectParamA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDialogIndirectParamW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateDialogIndirectParamW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DialogBoxParamA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("INT_PTR")]
    public static extern nint DialogBoxParamA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DialogBoxParamW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("INT_PTR")]
    public static extern nint DialogBoxParamW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplateName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DialogBoxIndirectParamA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("INT_PTR")]
    public static extern nint DialogBoxIndirectParamA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* hDialogTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DialogBoxIndirectParamW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("INT_PTR")]
    public static extern nint DialogBoxIndirectParamW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* hDialogTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc, LPARAM dwInitParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndDialog"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EndDialog(HWND hDlg, [NativeTypeName("INT_PTR")] nint nResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDlgItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetDlgItem(HWND hDlg, int nIDDlgItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDlgItemInt"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDlgItemInt(HWND hDlg, int nIDDlgItem, uint uValue, BOOL bSigned);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDlgItemInt"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetDlgItemInt(HWND hDlg, int nIDDlgItem, BOOL* lpTranslated, BOOL bSigned);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDlgItemTextA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDlgItemTextA(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPCSTR")] sbyte* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDlgItemTextW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDlgItemTextW(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPCWSTR")] ushort* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDlgItemTextA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetDlgItemTextA(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDlgItemTextW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetDlgItemTextW(HWND hDlg, int nIDDlgItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckDlgButton"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckDlgButton(HWND hDlg, int nIDButton, uint uCheck);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckRadioButton"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckRadioButton(HWND hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsDlgButtonChecked"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint IsDlgButtonChecked(HWND hDlg, int nIDButton);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendDlgItemMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT SendDlgItemMessageA(HWND hDlg, int nIDDlgItem, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendDlgItemMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT SendDlgItemMessageW(HWND hDlg, int nIDDlgItem, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNextDlgGroupItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetNextDlgGroupItem(HWND hDlg, HWND hCtl, BOOL bPrevious);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNextDlgTabItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetNextDlgTabItem(HWND hDlg, HWND hCtl, BOOL bPrevious);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDlgCtrlID"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetDlgCtrlID(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDialogBaseUnits"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int GetDialogBaseUnits();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefDlgProcA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefDlgProcA(HWND hDlg, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefDlgProcW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefDlgProcW(HWND hDlg, uint Msg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDialogControlDpiChangeBehavior"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetDialogControlDpiChangeBehavior(HWND hWnd, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDialogControlDpiChangeBehavior"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDialogDpiChangeBehavior"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern BOOL SetDialogDpiChangeBehavior(HWND hDlg, DIALOG_DPI_CHANGE_BEHAVIORS mask, DIALOG_DPI_CHANGE_BEHAVIORS values);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDialogDpiChangeBehavior"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior(HWND hDlg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CallMsgFilterA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL CallMsgFilterA([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CallMsgFilterW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL CallMsgFilterW([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenClipboard"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OpenClipboard(HWND hWndNewOwner);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseClipboard"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseClipboard();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipboardSequenceNumber"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetClipboardSequenceNumber();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipboardOwner"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetClipboardOwner();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetClipboardViewer"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND SetClipboardViewer(HWND hWndNewViewer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipboardViewer"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetClipboardViewer();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeClipboardChain"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ChangeClipboardChain(HWND hWndRemove, HWND hWndNewNext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetClipboardData"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE SetClipboardData(uint uFormat, HANDLE hMem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipboardData"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE GetClipboardData(uint uFormat);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipboardMetadata"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern BOOL GetClipboardMetadata(uint format, [NativeTypeName("PGETCLIPBMETADATA")] GETCLIPBMETADATA* metadata);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterClipboardFormatA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint RegisterClipboardFormatA([NativeTypeName("LPCSTR")] sbyte* lpszFormat);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterClipboardFormatW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint RegisterClipboardFormatW([NativeTypeName("LPCWSTR")] ushort* lpszFormat);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CountClipboardFormats"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int CountClipboardFormats();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumClipboardFormats"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint EnumClipboardFormats(uint format);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipboardFormatNameA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetClipboardFormatNameA(uint format, [NativeTypeName("LPSTR")] sbyte* lpszFormatName, int cchMaxCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipboardFormatNameW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetClipboardFormatNameW(uint format, [NativeTypeName("LPWSTR")] ushort* lpszFormatName, int cchMaxCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EmptyClipboard"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EmptyClipboard();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsClipboardFormatAvailable"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsClipboardFormatAvailable(uint format);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPriorityClipboardFormat"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetPriorityClipboardFormat(uint* paFormatPriorityList, int cFormats);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetOpenClipboardWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetOpenClipboardWindow();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddClipboardFormatListener"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddClipboardFormatListener(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveClipboardFormatListener"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveClipboardFormatListener(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUpdatedClipboardFormats"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUpdatedClipboardFormats([NativeTypeName("PUINT")] uint* lpuiFormats, uint cFormats, [NativeTypeName("PUINT")] uint* pcFormatsOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharToOemA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CharToOemA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharToOemW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CharToOemW([NativeTypeName("LPCWSTR")] ushort* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OemToCharA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OemToCharA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OemToCharW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OemToCharW([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPWSTR")] ushort* pDst);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharToOemBuffA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CharToOemBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharToOemBuffW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CharToOemBuffW([NativeTypeName("LPCWSTR")] ushort* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OemToCharBuffA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OemToCharBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OemToCharBuffW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OemToCharBuffW([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPWSTR")] ushort* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharUpperA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* CharUpperA([NativeTypeName("LPSTR")] sbyte* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharUpperW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* CharUpperW([NativeTypeName("LPWSTR")] ushort* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharUpperBuffA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CharUpperBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharUpperBuffW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CharUpperBuffW([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharLowerA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* CharLowerA([NativeTypeName("LPSTR")] sbyte* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharLowerW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* CharLowerW([NativeTypeName("LPWSTR")] ushort* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharLowerBuffA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CharLowerBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharLowerBuffW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CharLowerBuffW([NativeTypeName("LPWSTR")] ushort* lpsz, [NativeTypeName("DWORD")] uint cchLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharNextA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* CharNextA([NativeTypeName("LPCSTR")] sbyte* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharNextW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* CharNextW([NativeTypeName("LPCWSTR")] ushort* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharPrevA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* CharPrevA([NativeTypeName("LPCSTR")] sbyte* lpszStart, [NativeTypeName("LPCSTR")] sbyte* lpszCurrent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharPrevW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* CharPrevW([NativeTypeName("LPCWSTR")] ushort* lpszStart, [NativeTypeName("LPCWSTR")] ushort* lpszCurrent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharNextExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* CharNextExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CharPrevExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* CharPrevExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpStart, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharAlphaA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharAlphaA([NativeTypeName("CHAR")] sbyte ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharAlphaW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharAlphaW([NativeTypeName("WCHAR")] ushort ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharAlphaNumericA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharAlphaNumericA([NativeTypeName("CHAR")] sbyte ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharAlphaNumericW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharAlphaNumericW([NativeTypeName("WCHAR")] ushort ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharUpperA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharUpperA([NativeTypeName("CHAR")] sbyte ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharUpperW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharUpperW([NativeTypeName("WCHAR")] ushort ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharLowerA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharLowerA([NativeTypeName("CHAR")] sbyte ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharLowerW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsCharLowerW([NativeTypeName("WCHAR")] ushort ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFocus"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND SetFocus(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetActiveWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetActiveWindow();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFocus"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetFocus();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKBCodePage"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint GetKBCodePage();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyState"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern short GetKeyState(int nVirtKey);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAsyncKeyState"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern short GetAsyncKeyState(int vKey);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyboardState"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetKeyboardState([NativeTypeName("PBYTE")] byte* lpKeyState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetKeyboardState"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetKeyboardState([NativeTypeName("LPBYTE")] byte* lpKeyState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyNameTextA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetKeyNameTextA([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPSTR")] sbyte* lpString, int cchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyNameTextW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetKeyNameTextW([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPWSTR")] ushort* lpString, int cchSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKeyboardType"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetKeyboardType(int nTypeFlag);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ToAscii"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int ToAscii(uint uVirtKey, uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ToAsciiEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, uint uFlags, HKL dwhkl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ToUnicode"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int ToUnicode(uint wVirtKey, uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] ushort* pwszBuff, int cchBuff, uint wFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OemKeyScan"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint OemKeyScan([NativeTypeName("WORD")] ushort wOemChar);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VkKeyScanA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern short VkKeyScanA([NativeTypeName("CHAR")] sbyte ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VkKeyScanW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern short VkKeyScanW([NativeTypeName("WCHAR")] ushort ch);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VkKeyScanExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern short VkKeyScanExA([NativeTypeName("CHAR")] sbyte ch, HKL dwhkl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VkKeyScanExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern short VkKeyScanExW([NativeTypeName("WCHAR")] ushort ch, HKL dwhkl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.keybd_event"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void keybd_event(byte bVk, byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.mouse_event"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void mouse_event([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dx, [NativeTypeName("DWORD")] uint dy, [NativeTypeName("DWORD")] uint dwData, [NativeTypeName("ULONG_PTR")] nuint dwExtraInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SendInput"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SendInput(uint cInputs, [NativeTypeName("LPINPUT")] INPUT* pInputs, int cbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTouchInputInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTouchInputInfo(HTOUCHINPUT hTouchInput, uint cInputs, [NativeTypeName("PTOUCHINPUT")] TOUCHINPUT* pInputs, int cbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseTouchInputHandle"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseTouchInputHandle(HTOUCHINPUT hTouchInput);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterTouchWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterTouchWindow(HWND hwnd, [NativeTypeName("ULONG")] uint ulFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterTouchWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterTouchWindow(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsTouchWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsTouchWindow(HWND hwnd, [NativeTypeName("PULONG")] uint* pulFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeTouchInjection"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL InitializeTouchInjection([NativeTypeName("UINT32")] uint maxCount, [NativeTypeName("DWORD")] uint dwMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InjectTouchInput"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL InjectTouchInput([NativeTypeName("UINT32")] uint count, [NativeTypeName("const POINTER_TOUCH_INFO *")] POINTER_TOUCH_INFO* contacts);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerType"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerType([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INPUT_TYPE *")] uint* pointerType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerCursorId"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerCursorId([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* cursorId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerInfo([NativeTypeName("UINT32")] uint pointerId, POINTER_INFO* pointerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerInfoHistory"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, POINTER_INFO* pointerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerFrameInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerFrameInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_INFO* pointerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerFrameInfoHistory"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerFrameInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_INFO* pointerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerTouchInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerTouchInfo([NativeTypeName("UINT32")] uint pointerId, POINTER_TOUCH_INFO* touchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerTouchInfoHistory"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, POINTER_TOUCH_INFO* touchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerFrameTouchInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerFrameTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_TOUCH_INFO* touchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerFrameTouchInfoHistory"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerFrameTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_TOUCH_INFO* touchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerPenInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerPenInfo([NativeTypeName("UINT32")] uint pointerId, POINTER_PEN_INFO* penInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerPenInfoHistory"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerPenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, POINTER_PEN_INFO* penInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerFramePenInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerFramePenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_PEN_INFO* penInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerFramePenInfoHistory"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerFramePenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, POINTER_PEN_INFO* penInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SkipPointerFrameMessages"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SkipPointerFrameMessages([NativeTypeName("UINT32")] uint pointerId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterPointerInputTarget"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL RegisterPointerInputTarget(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterPointerInputTarget"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL UnregisterPointerInputTarget(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterPointerInputTargetEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL RegisterPointerInputTargetEx(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, BOOL fObserve);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterPointerInputTargetEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL UnregisterPointerInputTargetEx(HWND hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSyntheticPointerDevice"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HSYNTHETICPOINTERDEVICE CreateSyntheticPointerDevice([NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("ULONG")] uint maxCount, POINTER_FEEDBACK_MODE mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InjectSyntheticPointerInput"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern BOOL InjectSyntheticPointerInput(HSYNTHETICPOINTERDEVICE device, [NativeTypeName("const POINTER_TYPE_INFO *")] POINTER_TYPE_INFO* pointerInfo, [NativeTypeName("UINT32")] uint count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroySyntheticPointerDevice"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern void DestroySyntheticPointerDevice(HSYNTHETICPOINTERDEVICE device);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableMouseInPointer"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL EnableMouseInPointer(BOOL fEnable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsMouseInPointerEnabled"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL IsMouseInPointerEnabled();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterTouchHitTestingWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL RegisterTouchHitTestingWindow(HWND hwnd, [NativeTypeName("ULONG")] uint value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EvaluateProximityToRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL EvaluateProximityToRect([NativeTypeName("const RECT *")] RECT* controlBoundingBox, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EvaluateProximityToPolygon"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint numVertices, [NativeTypeName("const POINT *")] POINT* controlPolygon, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PackTouchHitTestingProximityEvaluation"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern LRESULT PackTouchHitTestingProximityEvaluation([NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] TOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("const TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] TOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowFeedbackSetting"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetWindowFeedbackSetting(HWND hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32 *")] uint* pSize, void* config);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowFeedbackSetting"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetWindowFeedbackSetting(HWND hwnd, FEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32")] uint size, [NativeTypeName("const void *")] void* configuration);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerInputTransform"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL GetPointerInputTransform([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, INPUT_TRANSFORM* inputTransform);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLastInputInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetLastInputInfo([NativeTypeName("PLASTINPUTINFO")] LASTINPUTINFO* plii);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapVirtualKeyA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint MapVirtualKeyA(uint uCode, uint uMapType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapVirtualKeyW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint MapVirtualKeyW(uint uCode, uint uMapType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapVirtualKeyExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint MapVirtualKeyExA(uint uCode, uint uMapType, HKL dwhkl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapVirtualKeyExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint MapVirtualKeyExW(uint uCode, uint uMapType, HKL dwhkl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetInputState"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetInputState();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetQueueStatus"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetQueueStatus(uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCapture"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetCapture();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCapture"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND SetCapture(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseCapture"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReleaseCapture();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsgWaitForMultipleObjects"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint MsgWaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] HANDLE* pHandles, BOOL fWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsgWaitForMultipleObjectsEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint MsgWaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] HANDLE* pHandles, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTimer"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("UINT_PTR")]
    public static extern nuint SetTimer(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged<HWND, uint, nuint, uint, void> lpTimerFunc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCoalescableTimer"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("UINT_PTR")]
    [SupportedOSPlatform("windows6.2")]
    public static extern nuint SetCoalescableTimer(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint nIDEvent, uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged<HWND, uint, nuint, uint, void> lpTimerFunc, [NativeTypeName("ULONG")] uint uToleranceDelay);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.KillTimer"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL KillTimer(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint uIDEvent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWindowUnicode"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsWindowUnicode(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnableWindow(HWND hWnd, BOOL bEnable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWindowEnabled"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsWindowEnabled(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadAcceleratorsA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HACCEL LoadAcceleratorsA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTableName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadAcceleratorsW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HACCEL LoadAcceleratorsW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTableName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAcceleratorTableA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HACCEL CreateAcceleratorTableA([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateAcceleratorTableW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HACCEL CreateAcceleratorTableW([NativeTypeName("LPACCEL")] ACCEL* paccel, int cAccel);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyAcceleratorTable"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DestroyAcceleratorTable(HACCEL hAccel);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyAcceleratorTableA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int CopyAcceleratorTableA(HACCEL hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyAcceleratorTableW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int CopyAcceleratorTableW(HACCEL hAccelSrc, [NativeTypeName("LPACCEL")] ACCEL* lpAccelDst, int cAccelEntries);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateAcceleratorA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int TranslateAcceleratorA(HWND hWnd, HACCEL hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateAcceleratorW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int TranslateAcceleratorW(HWND hWnd, HACCEL hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemMetrics"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetSystemMetrics(int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemMetricsForDpi"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern int GetSystemMetricsForDpi(int nIndex, uint dpi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadMenuA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMENU LoadMenuA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpMenuName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadMenuW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMENU LoadMenuW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpMenuName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadMenuIndirectA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMENU LoadMenuIndirectA([NativeTypeName("const MENUTEMPLATEA *")] void* lpMenuTemplate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadMenuIndirectW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMENU LoadMenuIndirectW([NativeTypeName("const MENUTEMPLATEW *")] void* lpMenuTemplate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HMENU GetMenu(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMenu(HWND hWnd, HMENU hMenu);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeMenuA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ChangeMenuA(HMENU hMenu, uint cmd, [NativeTypeName("LPCSTR")] sbyte* lpszNewItem, uint cmdInsert, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeMenuW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ChangeMenuW(HMENU hMenu, uint cmd, [NativeTypeName("LPCWSTR")] ushort* lpszNewItem, uint cmdInsert, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HiliteMenuItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL HiliteMenuItem(HWND hWnd, HMENU hMenu, uint uIDHiliteItem, uint uHilite);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuStringA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int GetMenuStringA(HMENU hMenu, uint uIDItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuStringW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int GetMenuStringW(HMENU hMenu, uint uIDItem, [NativeTypeName("LPWSTR")] ushort* lpString, int cchMax, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuState"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint GetMenuState(HMENU hMenu, uint uId, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawMenuBar"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DrawMenuBar(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HMENU GetSystemMenu(HWND hWnd, BOOL bRevert);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMENU CreateMenu();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePopupMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMENU CreatePopupMenu();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyMenu(HMENU hMenu);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckMenuItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CheckMenuItem(HMENU hMenu, uint uIDCheckItem, uint uCheck);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableMenuItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnableMenuItem(HMENU hMenu, uint uIDEnableItem, uint uEnable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSubMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HMENU GetSubMenu(HMENU hMenu, int nPos);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuItemID"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint GetMenuItemID(HMENU hMenu, int nPos);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuItemCount"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetMenuItemCount(HMENU hMenu);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InsertMenuA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InsertMenuA(HMENU hMenu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InsertMenuW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InsertMenuW(HMENU hMenu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppendMenuA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AppendMenuA(HMENU hMenu, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AppendMenuW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AppendMenuW(HMENU hMenu, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ModifyMenuA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ModifyMenuA(HMENU hMnu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ModifyMenuW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ModifyMenuW(HMENU hMnu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] nuint uIDNewItem, [NativeTypeName("LPCWSTR")] ushort* lpNewItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveMenu(HMENU hMenu, uint uPosition, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteMenu(HMENU hMenu, uint uPosition, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMenuItemBitmaps"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMenuItemBitmaps(HMENU hMenu, uint uPosition, uint uFlags, HBITMAP hBitmapUnchecked, HBITMAP hBitmapChecked);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuCheckMarkDimensions"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetMenuCheckMarkDimensions();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TrackPopupMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TrackPopupMenu(HMENU hMenu, uint uFlags, int x, int y, int nReserved, HWND hWnd, [NativeTypeName("const RECT *")] RECT* prcRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TrackPopupMenuEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TrackPopupMenuEx(HMENU hMenu, uint uFlags, int x, int y, HWND hwnd, [NativeTypeName("LPTPMPARAMS")] TPMPARAMS* lptpm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CalculatePopupWindowPosition"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CalculatePopupWindowPosition([NativeTypeName("const POINT *")] POINT* anchorPoint, [NativeTypeName("const SIZE *")] SIZE* windowSize, uint flags, RECT* excludeRect, RECT* popupWindowPosition);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMenuInfo(HMENU param0, [NativeTypeName("LPMENUINFO")] MENUINFO* param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMenuInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMenuInfo(HMENU param0, [NativeTypeName("LPCMENUINFO")] MENUINFO* param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndMenu"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EndMenu();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InsertMenuItemA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InsertMenuItemA(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InsertMenuItemW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InsertMenuItemW(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuItemInfoA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMenuItemInfoA(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPMENUITEMINFOA")] MENUITEMINFOA* lpmii);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuItemInfoW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMenuItemInfoW(HMENU hmenu, uint item, BOOL fByPosition, [NativeTypeName("LPMENUITEMINFOW")] MENUITEMINFOW* lpmii);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMenuItemInfoA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMenuItemInfoA(HMENU hmenu, uint item, BOOL fByPositon, [NativeTypeName("LPCMENUITEMINFOA")] MENUITEMINFOA* lpmii);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMenuItemInfoW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMenuItemInfoW(HMENU hmenu, uint item, BOOL fByPositon, [NativeTypeName("LPCMENUITEMINFOW")] MENUITEMINFOW* lpmii);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuDefaultItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetMenuDefaultItem(HMENU hMenu, uint fByPos, uint gmdiFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMenuDefaultItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMenuDefaultItem(HMENU hMenu, uint uItem, uint fByPos);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuItemRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMenuItemRect(HWND hWnd, HMENU hMenu, uint uItem, [NativeTypeName("LPRECT")] RECT* lprcItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MenuItemFromPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int MenuItemFromPoint(HWND hWnd, HMENU hMenu, POINT ptScreen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DragObject"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DragObject(HWND hwndParent, HWND hwndFrom, uint fmt, [NativeTypeName("ULONG_PTR")] nuint data, HCURSOR hcur);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DragDetect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DragDetect(HWND hwnd, POINT pt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawIcon"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DrawIcon(HDC hDC, int X, int Y, HICON hIcon);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawTextA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int DrawTextA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawTextW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int DrawTextW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawTextExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int DrawTextExA(HDC hdc, [NativeTypeName("LPSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawTextExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int DrawTextExW(HDC hdc, [NativeTypeName("LPWSTR")] ushort* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] DRAWTEXTPARAMS* lpdtp);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GrayStringA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GrayStringA(HDC hDC, HBRUSH hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged<HDC, LPARAM, int, BOOL> lpOutputFunc, LPARAM lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GrayStringW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GrayStringW(HDC hDC, HBRUSH hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged<HDC, LPARAM, int, BOOL> lpOutputFunc, LPARAM lpData, int nCount, int X, int Y, int nWidth, int nHeight);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawStateA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DrawStateA(HDC hdc, HBRUSH hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged<HDC, LPARAM, WPARAM, int, int, BOOL> qfnCallBack, LPARAM lData, WPARAM wData, int x, int y, int cx, int cy, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawStateW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DrawStateW(HDC hdc, HBRUSH hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged<HDC, LPARAM, WPARAM, int, int, BOOL> qfnCallBack, LPARAM lData, WPARAM wData, int x, int y, int cx, int cy, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TabbedTextOutA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int TabbedTextOutA(HDC hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TabbedTextOutW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int TabbedTextOutW(HDC hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTabbedTextExtentA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTabbedTextExtentA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTabbedTextExtentW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTabbedTextExtentW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL UpdateWindow(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetActiveWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND SetActiveWindow(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetForegroundWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetForegroundWindow();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PaintDesktop"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL PaintDesktop(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SwitchToThisWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void SwitchToThisWindow(HWND hwnd, BOOL fUnknown);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetForegroundWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetForegroundWindow(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AllowSetForegroundWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllowSetForegroundWindow([NativeTypeName("DWORD")] uint dwProcessId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LockSetForegroundWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LockSetForegroundWindow(uint uLockCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WindowFromDC"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND WindowFromDC(HDC hDC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDC"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HDC GetDC(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDCEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HDC GetDCEx(HWND hWnd, HRGN hrgnClip, [NativeTypeName("DWORD")] uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowDC"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HDC GetWindowDC(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseDC"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int ReleaseDC(HWND hWnd, HDC hDC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginPaint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HDC BeginPaint(HWND hWnd, [NativeTypeName("LPPAINTSTRUCT")] PAINTSTRUCT* lpPaint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndPaint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EndPaint(HWND hWnd, [NativeTypeName("const PAINTSTRUCT *")] PAINTSTRUCT* lpPaint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUpdateRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetUpdateRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lpRect, BOOL bErase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUpdateRgn"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int GetUpdateRgn(HWND hWnd, HRGN hRgn, BOOL bErase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowRgn"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int SetWindowRgn(HWND hWnd, HRGN hRgn, BOOL bRedraw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowRgn"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int GetWindowRgn(HWND hWnd, HRGN hRgn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowRgnBox"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int GetWindowRgnBox(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lprc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExcludeUpdateRgn"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int ExcludeUpdateRgn(HDC hDC, HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InvalidateRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL InvalidateRect(HWND hWnd, [NativeTypeName("const RECT *")] RECT* lpRect, BOOL bErase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ValidateRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ValidateRect(HWND hWnd, [NativeTypeName("const RECT *")] RECT* lpRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InvalidateRgn"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL InvalidateRgn(HWND hWnd, HRGN hRgn, BOOL bErase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ValidateRgn"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ValidateRgn(HWND hWnd, HRGN hRgn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RedrawWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL RedrawWindow(HWND hWnd, [NativeTypeName("const RECT *")] RECT* lprcUpdate, HRGN hrgnUpdate, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LockWindowUpdate"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL LockWindowUpdate(HWND hWndLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ScrollWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ScrollWindow(HWND hWnd, int XAmount, int YAmount, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("const RECT *")] RECT* lpClipRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ScrollDC"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ScrollDC(HDC hDC, int dx, int dy, [NativeTypeName("const RECT *")] RECT* lprcScroll, [NativeTypeName("const RECT *")] RECT* lprcClip, HRGN hrgnUpdate, [NativeTypeName("LPRECT")] RECT* lprcUpdate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ScrollWindowEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int ScrollWindowEx(HWND hWnd, int dx, int dy, [NativeTypeName("const RECT *")] RECT* prcScroll, [NativeTypeName("const RECT *")] RECT* prcClip, HRGN hrgnUpdate, [NativeTypeName("LPRECT")] RECT* prcUpdate, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetScrollPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int SetScrollPos(HWND hWnd, int nBar, int nPos, BOOL bRedraw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetScrollPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetScrollPos(HWND hWnd, int nBar);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetScrollRange"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetScrollRange(HWND hWnd, int nBar, int nMinPos, int nMaxPos, BOOL bRedraw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetScrollRange"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetScrollRange(HWND hWnd, int nBar, [NativeTypeName("LPINT")] int* lpMinPos, [NativeTypeName("LPINT")] int* lpMaxPos);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowScrollBar"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShowScrollBar(HWND hWnd, int wBar, BOOL bShow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableScrollBar"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnableScrollBar(HWND hWnd, uint wSBflags, uint wArrows);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPropA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPropA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString, HANDLE hData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPropW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPropW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString, HANDLE hData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPropA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HANDLE GetPropA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPropW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HANDLE GetPropW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemovePropA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HANDLE RemovePropA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemovePropW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HANDLE RemovePropW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumPropsExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int EnumPropsExA(HWND hWnd, [NativeTypeName("PROPENUMPROCEXA")] delegate* unmanaged<HWND, sbyte*, HANDLE, nuint, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumPropsExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int EnumPropsExW(HWND hWnd, [NativeTypeName("PROPENUMPROCEXW")] delegate* unmanaged<HWND, ushort*, HANDLE, nuint, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumPropsA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int EnumPropsA(HWND hWnd, [NativeTypeName("PROPENUMPROCA")] delegate* unmanaged<HWND, sbyte*, HANDLE, BOOL> lpEnumFunc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumPropsW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int EnumPropsW(HWND hWnd, [NativeTypeName("PROPENUMPROCW")] delegate* unmanaged<HWND, ushort*, HANDLE, BOOL> lpEnumFunc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowTextA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWindowTextA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowTextW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWindowTextW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowTextA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetWindowTextA(HWND hWnd, [NativeTypeName("LPSTR")] sbyte* lpString, int nMaxCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowTextW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetWindowTextW(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* lpString, int nMaxCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowTextLengthA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetWindowTextLengthA(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowTextLengthW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetWindowTextLengthW(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClientRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetClientRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetWindowRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AdjustWindowRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AdjustWindowRect([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, BOOL bMenu);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AdjustWindowRectEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AdjustWindowRectEx([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, BOOL bMenu, [NativeTypeName("DWORD")] uint dwExStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AdjustWindowRectExForDpi"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern BOOL AdjustWindowRectExForDpi([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, BOOL bMenu, [NativeTypeName("DWORD")] uint dwExStyle, uint dpi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowContextHelpId"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWindowContextHelpId(HWND param0, [NativeTypeName("DWORD")] uint param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowContextHelpId"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetWindowContextHelpId(HWND param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMenuContextHelpId"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMenuContextHelpId(HMENU param0, [NativeTypeName("DWORD")] uint param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuContextHelpId"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetMenuContextHelpId(HMENU param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MessageBoxA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int MessageBoxA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, uint uType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MessageBoxW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int MessageBoxW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, uint uType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MessageBoxExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int MessageBoxExA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, uint uType, [NativeTypeName("WORD")] ushort wLanguageId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MessageBoxExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int MessageBoxExW(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpText, [NativeTypeName("LPCWSTR")] ushort* lpCaption, uint uType, [NativeTypeName("WORD")] ushort wLanguageId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MessageBoxIndirectA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int MessageBoxIndirectA([NativeTypeName("const MSGBOXPARAMSA *")] MSGBOXPARAMSA* lpmbp);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MessageBoxIndirectW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int MessageBoxIndirectW([NativeTypeName("const MSGBOXPARAMSW *")] MSGBOXPARAMSW* lpmbp);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MessageBeep"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MessageBeep(uint uType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int ShowCursor(BOOL bShow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCursorPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCursorPos(int X, int Y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPhysicalCursorPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetPhysicalCursorPos(int X, int Y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HCURSOR SetCursor(HCURSOR hCursor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCursorPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPhysicalCursorPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetPhysicalCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetClipCursor([NativeTypeName("LPRECT")] RECT* lpRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HCURSOR GetCursor();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateCaret"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateCaret(HWND hWnd, HBITMAP hBitmap, int nWidth, int nHeight);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCaretBlinkTime"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetCaretBlinkTime();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCaretBlinkTime"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCaretBlinkTime(uint uMSeconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyCaret"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyCaret();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HideCaret"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HideCaret(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowCaret"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShowCaret(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCaretPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCaretPos(int X, int Y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCaretPos"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCaretPos([NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClientToScreen"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ClientToScreen(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ScreenToClient"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL ScreenToClient(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LogicalToPhysicalPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL LogicalToPhysicalPoint(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PhysicalToLogicalPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL PhysicalToLogicalPoint(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LogicalToPhysicalPointForPerMonitorDPI"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL LogicalToPhysicalPointForPerMonitorDPI(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PhysicalToLogicalPointForPerMonitorDPI"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL PhysicalToLogicalPointForPerMonitorDPI(HWND hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapWindowPoints"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int MapWindowPoints(HWND hWndFrom, HWND hWndTo, [NativeTypeName("LPPOINT")] POINT* lpPoints, uint cPoints);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WindowFromPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND WindowFromPoint(POINT Point);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WindowFromPhysicalPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND WindowFromPhysicalPoint(POINT Point);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChildWindowFromPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND ChildWindowFromPoint(HWND hWndParent, POINT Point);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClipCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClipCursor([NativeTypeName("const RECT *")] RECT* lpRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChildWindowFromPointEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND ChildWindowFromPointEx(HWND hwnd, POINT pt, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSysColor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SuppressGCTransition]
    public static extern uint GetSysColor(int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSysColorBrush"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HBRUSH GetSysColorBrush(int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSysColors"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSysColors(int cElements, [NativeTypeName("const INT *")] int* lpaElements, [NativeTypeName("const COLORREF *")] COLORREF* lpaRgbValues);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawFocusRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DrawFocusRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FillRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int FillRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc, HBRUSH hbr);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FrameRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int FrameRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc, HBRUSH hbr);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InvertRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL InvertRect(HDC hDC, [NativeTypeName("const RECT *")] RECT* lprc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetRect([NativeTypeName("LPRECT")] RECT* lprc, int xLeft, int yTop, int xRight, int yBottom);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetRectEmpty"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetRectEmpty([NativeTypeName("LPRECT")] RECT* lprc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL CopyRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InflateRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL InflateRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntersectRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IntersectRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnionRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL UnionRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SubtractRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SubtractRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OffsetRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL OffsetRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsRectEmpty"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsRectEmpty([NativeTypeName("const RECT *")] RECT* lprc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EqualRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EqualRect([NativeTypeName("const RECT *")] RECT* lprc1, [NativeTypeName("const RECT *")] RECT* lprc2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtInRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL PtInRect([NativeTypeName("const RECT *")] RECT* lprc, POINT pt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowWord"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort GetWindowWord(HWND hWnd, int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowWord"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort SetWindowWord(HWND hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowLongA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int GetWindowLongA(HWND hWnd, int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowLongW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int GetWindowLongW(HWND hWnd, int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowLongA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int SetWindowLongA(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowLongW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int SetWindowLongW(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassWord"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("WORD")]
    public static extern ushort GetClassWord(HWND hWnd, int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetClassWord"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("WORD")]
    public static extern ushort SetClassWord(HWND hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassLongA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetClassLongA(HWND hWnd, int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassLongW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetClassLongW(HWND hWnd, int nIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetClassLongA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetClassLongA(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetClassLongW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetClassLongW(HWND hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessDefaultLayout"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessDefaultLayout([NativeTypeName("DWORD *")] uint* pdwDefaultLayout);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDefaultLayout"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessDefaultLayout([NativeTypeName("DWORD")] uint dwDefaultLayout);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDesktopWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetDesktopWindow();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetParent"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetParent(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetParent"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND SetParent(HWND hWndChild, HWND hWndNewParent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumChildWindows"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumChildWindows(HWND hWndParent, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindWindowA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND FindWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindWindowW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND FindWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindWindowExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND FindWindowExA(HWND hWndParent, HWND hWndChildAfter, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPCSTR")] sbyte* lpszWindow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindWindowExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND FindWindowExW(HWND hWndParent, HWND hWndChildAfter, [NativeTypeName("LPCWSTR")] ushort* lpszClass, [NativeTypeName("LPCWSTR")] ushort* lpszWindow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetShellWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetShellWindow();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterShellHookWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL RegisterShellHookWindow(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeregisterShellHookWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL DeregisterShellHookWindow(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumWindows"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumWindows([NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpEnumFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumThreadWindows"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumThreadWindows([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpfn, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassNameA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetClassNameA(HWND hWnd, [NativeTypeName("LPSTR")] sbyte* lpClassName, int nMaxCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClassNameW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetClassNameW(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* lpClassName, int nMaxCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTopWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetTopWindow(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowThreadProcessId"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetWindowThreadProcessId(HWND hWnd, [NativeTypeName("LPDWORD")] uint* lpdwProcessId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsGUIThread"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsGUIThread(BOOL bConvert);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLastActivePopup"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetLastActivePopup(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND GetWindow(HWND hWnd, uint uCmd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowsHookA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HHOOK SetWindowsHookA(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> pfnFilterProc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowsHookW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HHOOK SetWindowsHookW(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> pfnFilterProc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnhookWindowsHook"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL UnhookWindowsHook(int nCode, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> pfnFilterProc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowsHookExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HHOOK SetWindowsHookExA(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> lpfn, HINSTANCE hmod, [NativeTypeName("DWORD")] uint dwThreadId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowsHookExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HHOOK SetWindowsHookExW(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> lpfn, HINSTANCE hmod, [NativeTypeName("DWORD")] uint dwThreadId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnhookWindowsHookEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnhookWindowsHookEx(HHOOK hhk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CallNextHookEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT CallNextHookEx(HHOOK hhk, int nCode, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckMenuRadioItem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckMenuRadioItem(HMENU hmenu, uint first, uint last, uint check, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadBitmapA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HBITMAP LoadBitmapA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpBitmapName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadBitmapW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HBITMAP LoadBitmapW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpBitmapName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadCursorA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCURSOR LoadCursorA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpCursorName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadCursorW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCURSOR LoadCursorW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpCursorName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadCursorFromFileA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCURSOR LoadCursorFromFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadCursorFromFileW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCURSOR LoadCursorFromFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCURSOR CreateCursor(HINSTANCE hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [NativeTypeName("const void *")] void* pvANDPlane, [NativeTypeName("const void *")] void* pvXORPlane);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyCursor(HCURSOR hCursor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSystemCursor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSystemCursor(HCURSOR hcur, [NativeTypeName("DWORD")] uint id);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadIconA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HICON LoadIconA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpIconName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadIconW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HICON LoadIconW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpIconName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrivateExtractIconsA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint PrivateExtractIconsA([NativeTypeName("LPCSTR")] sbyte* szFileName, int nIconIndex, int cxIcon, int cyIcon, HICON* phicon, uint* piconid, uint nIcons, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrivateExtractIconsW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint PrivateExtractIconsW([NativeTypeName("LPCWSTR")] ushort* szFileName, int nIconIndex, int cxIcon, int cyIcon, HICON* phicon, uint* piconid, uint nIcons, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateIcon"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HICON CreateIcon(HINSTANCE hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, [NativeTypeName("const BYTE *")] byte* lpbANDbits, [NativeTypeName("const BYTE *")] byte* lpbXORbits);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyIcon"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DestroyIcon(HICON hIcon);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupIconIdFromDirectory"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int LookupIconIdFromDirectory([NativeTypeName("PBYTE")] byte* presbits, BOOL fIcon);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupIconIdFromDirectoryEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int LookupIconIdFromDirectoryEx([NativeTypeName("PBYTE")] byte* presbits, BOOL fIcon, int cxDesired, int cyDesired, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateIconFromResource"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HICON CreateIconFromResource([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, BOOL fIcon, [NativeTypeName("DWORD")] uint dwVer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateIconFromResourceEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HICON CreateIconFromResourceEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, BOOL fIcon, [NativeTypeName("DWORD")] uint dwVer, int cxDesired, int cyDesired, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadCursorCreationScaling"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint SetThreadCursorCreationScaling(uint cursorDpi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadImageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE LoadImageA(HINSTANCE hInst, [NativeTypeName("LPCSTR")] sbyte* name, uint type, int cx, int cy, uint fuLoad);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadImageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE LoadImageW(HINSTANCE hInst, [NativeTypeName("LPCWSTR")] ushort* name, uint type, int cx, int cy, uint fuLoad);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyImage"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CopyImage(HANDLE h, uint type, int cx, int cy, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawIconEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DrawIconEx(HDC hdc, int xLeft, int yTop, HICON hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, HBRUSH hbrFlickerFreeDraw, uint diFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateIconIndirect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HICON CreateIconIndirect([NativeTypeName("PICONINFO")] ICONINFO* piconinfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyIcon"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HICON CopyIcon(HICON hIcon);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetIconInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetIconInfo(HICON hIcon, [NativeTypeName("PICONINFO")] ICONINFO* piconinfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetIconInfoExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetIconInfoExA(HICON hicon, [NativeTypeName("PICONINFOEXA")] ICONINFOEXA* piconinfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetIconInfoExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetIconInfoExW(HICON hicon, [NativeTypeName("PICONINFOEXW")] ICONINFOEXW* piconinfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsDialogMessageA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsDialogMessageA(HWND hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsDialogMessageW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsDialogMessageW(HWND hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapDialogRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MapDialogRect(HWND hDlg, [NativeTypeName("LPRECT")] RECT* lpRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirListA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int DlgDirListA(HWND hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirListW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int DlgDirListW(HWND hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirSelectExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DlgDirSelectExA(HWND hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int chCount, int idListBox);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirSelectExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DlgDirSelectExW(HWND hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int chCount, int idListBox);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirListComboBoxA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int DlgDirListComboBoxA(HWND hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirListComboBoxW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int DlgDirListComboBoxW(HWND hDlg, [NativeTypeName("LPWSTR")] ushort* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirSelectComboBoxExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DlgDirSelectComboBoxExA(HWND hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int cchOut, int idComboBox);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DlgDirSelectComboBoxExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DlgDirSelectComboBoxExW(HWND hwndDlg, [NativeTypeName("LPWSTR")] ushort* lpString, int cchOut, int idComboBox);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetScrollInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern int SetScrollInfo(HWND hwnd, int nBar, [NativeTypeName("LPCSCROLLINFO")] SCROLLINFO* lpsi, BOOL redraw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetScrollInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetScrollInfo(HWND hwnd, int nBar, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* lpsi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefFrameProcA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefFrameProcA(HWND hWnd, HWND hWndMDIClient, uint uMsg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefFrameProcW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefFrameProcW(HWND hWnd, HWND hWndMDIClient, uint uMsg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefMDIChildProcA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefMDIChildProcA(HWND hWnd, uint uMsg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefMDIChildProcW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefMDIChildProcW(HWND hWnd, uint uMsg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateMDISysAccel"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL TranslateMDISysAccel(HWND hWndClient, [NativeTypeName("LPMSG")] MSG* lpMsg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ArrangeIconicWindows"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint ArrangeIconicWindows(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMDIWindowA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateMDIWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HINSTANCE hInstance, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMDIWindowW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateMDIWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HINSTANCE hInstance, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TileWindows"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("WORD")]
    public static extern ushort TileWindows(HWND hwndParent, uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, uint cKids, [NativeTypeName("const HWND *")] HWND* lpKids);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CascadeWindows"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("WORD")]
    public static extern ushort CascadeWindows(HWND hwndParent, uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, uint cKids, [NativeTypeName("const HWND *")] HWND* lpKids);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WinHelpA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHelpA(HWND hWndMain, [NativeTypeName("LPCSTR")] sbyte* lpszHelp, uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WinHelpW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHelpW(HWND hWndMain, [NativeTypeName("LPCWSTR")] ushort* lpszHelp, uint uCommand, [NativeTypeName("ULONG_PTR")] nuint dwData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGuiResources"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetGuiResources(HANDLE hProcess, [NativeTypeName("DWORD")] uint uiFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeDisplaySettingsA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int ChangeDisplaySettingsA(DEVMODEA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeDisplaySettingsW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int ChangeDisplaySettingsW(DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeDisplaySettingsExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int ChangeDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, DEVMODEA* lpDevMode, HWND hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeDisplaySettingsExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int ChangeDisplaySettingsExW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, DEVMODEW* lpDevMode, HWND hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDisplaySettingsA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumDisplaySettingsA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEA* lpDevMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDisplaySettingsW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumDisplaySettingsW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEW* lpDevMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDisplaySettingsExA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDisplaySettingsExW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumDisplaySettingsExW([NativeTypeName("LPCWSTR")] ushort* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, DEVMODEW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDisplayDevicesA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumDisplayDevicesA([NativeTypeName("LPCSTR")] sbyte* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEA")] DISPLAY_DEVICEA* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDisplayDevicesW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumDisplayDevicesW([NativeTypeName("LPCWSTR")] ushort* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEW")] DISPLAY_DEVICEW* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDisplayConfigBufferSizes"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetDisplayConfigBufferSizes([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDisplayConfig"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int SetDisplayConfig([NativeTypeName("UINT32")] uint numPathArrayElements, DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32")] uint numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO* modeInfoArray, [NativeTypeName("UINT32")] uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryDisplayConfig"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int QueryDisplayConfig([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO* modeInfoArray, DISPLAYCONFIG_TOPOLOGY_ID* currentTopologyId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisplayConfigGetDeviceInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int DisplayConfigGetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER* requestPacket);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisplayConfigSetDeviceInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int DisplayConfigSetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER* setPacket);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SystemParametersInfoA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SystemParametersInfoA(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SystemParametersInfoW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SystemParametersInfoW(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SystemParametersInfoForDpi"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern BOOL SystemParametersInfoForDpi(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni, uint dpi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SoundSentry"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SoundSentry();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDebugErrorLevel"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void SetDebugErrorLevel([NativeTypeName("DWORD")] uint dwLevel);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetLastErrorEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void SetLastErrorEx([NativeTypeName("DWORD")] uint dwErrCode, [NativeTypeName("DWORD")] uint dwType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InternalGetWindowText"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int InternalGetWindowText(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* pString, int cchMaxCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelShutdown"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL CancelShutdown();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MonitorFromPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HMONITOR MonitorFromPoint(POINT pt, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MonitorFromRect"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HMONITOR MonitorFromRect([NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MonitorFromWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HMONITOR MonitorFromWindow(HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMonitorInfoA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetMonitorInfoA(HMONITOR hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMonitorInfoW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetMonitorInfoW(HMONITOR hMonitor, [NativeTypeName("LPMONITORINFO")] MONITORINFO* lpmi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDisplayMonitors"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL EnumDisplayMonitors(HDC hdc, [NativeTypeName("LPCRECT")] RECT* lprcClip, [NativeTypeName("MONITORENUMPROC")] delegate* unmanaged<HMONITOR, HDC, RECT*, LPARAM, BOOL> lpfnEnum, LPARAM dwData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NotifyWinEvent"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern void NotifyWinEvent([NativeTypeName("DWORD")] uint @event, HWND hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idChild);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWinEventHook"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWINEVENTHOOK SetWinEventHook([NativeTypeName("DWORD")] uint eventMin, [NativeTypeName("DWORD")] uint eventMax, HMODULE hmodWinEventProc, [NativeTypeName("WINEVENTPROC")] delegate* unmanaged<HWINEVENTHOOK, uint, HWND, int, int, uint, uint, void> pfnWinEventProc, [NativeTypeName("DWORD")] uint idProcess, [NativeTypeName("DWORD")] uint idThread, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWinEventHookInstalled"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsWinEventHookInstalled([NativeTypeName("DWORD")] uint @event);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnhookWinEvent"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL UnhookWinEvent(HWINEVENTHOOK hWinEventHook);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGUIThreadInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetGUIThreadInfo([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("PGUITHREADINFO")] GUITHREADINFO* pgui);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BlockInput"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BlockInput(BOOL fBlockIt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDPIAware"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetProcessDPIAware();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsProcessDPIAware"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL IsProcessDPIAware();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadDpiAwarenessContext"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern DPI_AWARENESS_CONTEXT SetThreadDpiAwarenessContext(DPI_AWARENESS_CONTEXT dpiContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadDpiAwarenessContext"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern DPI_AWARENESS_CONTEXT GetThreadDpiAwarenessContext();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowDpiAwarenessContext"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern DPI_AWARENESS_CONTEXT GetWindowDpiAwarenessContext(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAwarenessFromDpiAwarenessContext"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDpiFromDpiAwarenessContext"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern uint GetDpiFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AreDpiAwarenessContextsEqual"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern BOOL AreDpiAwarenessContextsEqual(DPI_AWARENESS_CONTEXT dpiContextA, DPI_AWARENESS_CONTEXT dpiContextB);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsValidDpiAwarenessContext"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern BOOL IsValidDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDpiForWindow"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern uint GetDpiForWindow(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDpiForSystem"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern uint GetDpiForSystem();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemDpiForProcess"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern uint GetSystemDpiForProcess(HANDLE hProcess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableNonClientDpiScaling"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern BOOL EnableNonClientDpiScaling(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InheritWindowMonitor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL InheritWindowMonitor(HWND hwnd, HWND hwndInherit);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDpiAwarenessContext"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern BOOL SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDpiAwarenessContextForProcess"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern DPI_AWARENESS_CONTEXT GetDpiAwarenessContextForProcess(HANDLE hProcess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadDpiHostingBehavior"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(DPI_HOSTING_BEHAVIOR value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadDpiHostingBehavior"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowDpiHostingBehavior"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern DPI_HOSTING_BEHAVIOR GetWindowDpiHostingBehavior(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowModuleFileNameA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint GetWindowModuleFileNameA(HWND hwnd, [NativeTypeName("LPSTR")] sbyte* pszFileName, uint cchFileNameMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowModuleFileNameW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint GetWindowModuleFileNameW(HWND hwnd, [NativeTypeName("LPWSTR")] ushort* pszFileName, uint cchFileNameMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCursorInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCursorInfo([NativeTypeName("PCURSORINFO")] CURSORINFO* pci);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetWindowInfo(HWND hwnd, [NativeTypeName("PWINDOWINFO")] WINDOWINFO* pwi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTitleBarInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTitleBarInfo(HWND hwnd, [NativeTypeName("PTITLEBARINFO")] TITLEBARINFO* pti);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuBarInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMenuBarInfo(HWND hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idItem, [NativeTypeName("PMENUBARINFO")] MENUBARINFO* pmbi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetScrollBarInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetScrollBarInfo(HWND hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("PSCROLLBARINFO")] SCROLLBARINFO* psbi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetComboBoxInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetComboBoxInfo(HWND hwndCombo, [NativeTypeName("PCOMBOBOXINFO")] COMBOBOXINFO* pcbi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAncestor"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND GetAncestor(HWND hwnd, uint gaFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RealChildWindowFromPoint"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern HWND RealChildWindowFromPoint(HWND hwndParent, POINT ptParentClientCoords);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RealGetWindowClassA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint RealGetWindowClassA(HWND hwnd, [NativeTypeName("LPSTR")] sbyte* ptszClassName, uint cchClassNameMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RealGetWindowClassW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint RealGetWindowClassW(HWND hwnd, [NativeTypeName("LPWSTR")] ushort* ptszClassName, uint cchClassNameMax);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAltTabInfoA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAltTabInfoA(HWND hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPSTR")] sbyte* pszItemText, uint cchItemText);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAltTabInfoW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetAltTabInfoW(HWND hwnd, int iItem, [NativeTypeName("PALTTABINFO")] ALTTABINFO* pati, [NativeTypeName("LPWSTR")] ushort* pszItemText, uint cchItemText);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetListBoxInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetListBoxInfo(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LockWorkStation"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LockWorkStation();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UserHandleGrantAccess"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UserHandleGrantAccess(HANDLE hUserHandle, HANDLE hJob, BOOL bGrant);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRawInputData"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern uint GetRawInputData(HRAWINPUT hRawInput, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize, uint cbSizeHeader);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRawInputDeviceInfoA"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetRawInputDeviceInfoA(HANDLE hDevice, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRawInputDeviceInfoW"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetRawInputDeviceInfoW(HANDLE hDevice, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRawInputBuffer"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetRawInputBuffer([NativeTypeName("PRAWINPUT")] RAWINPUT* pData, [NativeTypeName("PUINT")] uint* pcbSize, uint cbSizeHeader);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterRawInputDevices"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterRawInputDevices([NativeTypeName("PCRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, uint uiNumDevices, uint cbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRegisteredRawInputDevices"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetRegisteredRawInputDevices([NativeTypeName("PRAWINPUTDEVICE")] RAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("PUINT")] uint* puiNumDevices, uint cbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRawInputDeviceList"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetRawInputDeviceList([NativeTypeName("PRAWINPUTDEVICELIST")] RAWINPUTDEVICELIST* pRawInputDeviceList, [NativeTypeName("PUINT")] uint* puiNumDevices, uint cbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefRawInputProc"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern LRESULT DefRawInputProc([NativeTypeName("PRAWINPUT *")] RAWINPUT** paRawInput, int nInput, uint cbSizeHeader);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerDevices"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerDevices([NativeTypeName("UINT32 *")] uint* deviceCount, POINTER_DEVICE_INFO* pointerDevices);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerDevice"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerDevice(HANDLE device, POINTER_DEVICE_INFO* pointerDevice);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerDeviceProperties"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerDeviceProperties(HANDLE device, [NativeTypeName("UINT32 *")] uint* propertyCount, POINTER_DEVICE_PROPERTY* pointerProperties);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterPointerDeviceNotifications"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL RegisterPointerDeviceNotifications(HWND window, BOOL notifyRange);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerDeviceRects"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerDeviceRects(HANDLE device, RECT* pointerDeviceRect, RECT* displayRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPointerDeviceCursors"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetPointerDeviceCursors(HANDLE device, [NativeTypeName("UINT32 *")] uint* cursorCount, POINTER_DEVICE_CURSOR_INFO* deviceCursors);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRawPointerDeviceData"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetRawPointerDeviceData([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("UINT32")] uint propertiesCount, POINTER_DEVICE_PROPERTY* pProperties, [NativeTypeName("LONG *")] int* pValues);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeWindowMessageFilter"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ChangeWindowMessageFilter(uint message, [NativeTypeName("DWORD")] uint dwFlag);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChangeWindowMessageFilterEx"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ChangeWindowMessageFilterEx(HWND hwnd, uint message, [NativeTypeName("DWORD")] uint action, [NativeTypeName("PCHANGEFILTERSTRUCT")] CHANGEFILTERSTRUCT* pChangeFilterStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGestureInfo"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetGestureInfo(HGESTUREINFO hGestureInfo, [NativeTypeName("PGESTUREINFO")] GESTUREINFO* pGestureInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGestureExtraArgs"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetGestureExtraArgs(HGESTUREINFO hGestureInfo, uint cbExtraArgs, [NativeTypeName("PBYTE")] byte* pExtraArgs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseGestureInfoHandle"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseGestureInfoHandle(HGESTUREINFO hGestureInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetGestureConfig"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetGestureConfig(HWND hwnd, [NativeTypeName("DWORD")] uint dwReserved, uint cIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, uint cbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGestureConfig"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetGestureConfig(HWND hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PUINT")] uint* pcIDs, [NativeTypeName("PGESTURECONFIG")] GESTURECONFIG* pGestureConfig, uint cbSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShutdownBlockReasonCreate"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShutdownBlockReasonCreate(HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* pwszReason);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShutdownBlockReasonQuery"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShutdownBlockReasonQuery(HWND hWnd, [NativeTypeName("LPWSTR")] ushort* pwszBuff, [NativeTypeName("DWORD *")] uint* pcchBuff);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShutdownBlockReasonDestroy"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShutdownBlockReasonDestroy(HWND hWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentInputMessageSource"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetCurrentInputMessageSource(INPUT_MESSAGE_SOURCE* inputMessageSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCIMSSM"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetCIMSSM(INPUT_MESSAGE_SOURCE* inputMessageSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAutoRotationState"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL GetAutoRotationState([NativeTypeName("PAR_STATE")] AR_STATE* pState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDisplayAutoRotationPreferences"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE* pOrientation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDisplayAutoRotationPreferences"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    public static extern BOOL SetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE orientation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsImmersiveProcess"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL IsImmersiveProcess(HANDLE hProcess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessRestrictionExemption"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetProcessRestrictionExemption(BOOL fEnableExemption);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetAdditionalForegroundBoostProcesses"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern BOOL SetAdditionalForegroundBoostProcesses(HWND topLevelWindow, [NativeTypeName("DWORD")] uint processHandleCount, HANDLE* processHandleArray);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterForTooltipDismissNotification"]/*'/>
    [DllImport("user32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern BOOL RegisterForTooltipDismissNotification(HWND hWnd, TOOLTIP_DISMISS_FLAGS tdFlags);
    [NativeTypeName("#define DIFFERENCE 11")]
    public const int DIFFERENCE = 11;
    [NativeTypeName("#define CREATEPROCESS_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1)")]
    public static ushort* CREATEPROCESS_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(1))));

    [NativeTypeName("#define ISOLATIONAWARE_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(2)")]
    public static ushort* ISOLATIONAWARE_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(2))));

    [NativeTypeName("#define ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(3)")]
    public static ushort* ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(3))));

    [NativeTypeName("#define ISOLATIONPOLICY_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(4)")]
    public static ushort* ISOLATIONPOLICY_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(4))));

    [NativeTypeName("#define ISOLATIONPOLICY_BROWSER_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(5)")]
    public static ushort* ISOLATIONPOLICY_BROWSER_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(5))));

    [NativeTypeName("#define MINIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE( 1 /*inclusive*/)")]
    public static ushort* MINIMUM_RESERVED_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(1))));

    [NativeTypeName("#define wvsprintf wvsprintfW")]
    public static delegate*<ushort*, ushort*, sbyte*, int> wvsprintf => &wvsprintfW;

    [NativeTypeName("#define SETWALLPAPER_DEFAULT ((LPWSTR)-1)")]
    public static ushort* SETWALLPAPER_DEFAULT => unchecked((ushort*)(-1));

    [NativeTypeName("#define HIDE_WINDOW 0")]
    public const int HIDE_WINDOW = 0;
    [NativeTypeName("#define SHOW_OPENWINDOW 1")]
    public const int SHOW_OPENWINDOW = 1;
    [NativeTypeName("#define SHOW_ICONWINDOW 2")]
    public const int SHOW_ICONWINDOW = 2;
    [NativeTypeName("#define SHOW_FULLSCREEN 3")]
    public const int SHOW_FULLSCREEN = 3;
    [NativeTypeName("#define SHOW_OPENNOACTIVATE 4")]
    public const int SHOW_OPENNOACTIVATE = 4;
    [NativeTypeName("#define AW_HOR_POSITIVE 0x00000001")]
    public const int AW_HOR_POSITIVE = 0x00000001;
    [NativeTypeName("#define AW_HOR_NEGATIVE 0x00000002")]
    public const int AW_HOR_NEGATIVE = 0x00000002;
    [NativeTypeName("#define AW_VER_POSITIVE 0x00000004")]
    public const int AW_VER_POSITIVE = 0x00000004;
    [NativeTypeName("#define AW_VER_NEGATIVE 0x00000008")]
    public const int AW_VER_NEGATIVE = 0x00000008;
    [NativeTypeName("#define AW_CENTER 0x00000010")]
    public const int AW_CENTER = 0x00000010;
    [NativeTypeName("#define AW_HIDE 0x00010000")]
    public const int AW_HIDE = 0x00010000;
    [NativeTypeName("#define AW_ACTIVATE 0x00020000")]
    public const int AW_ACTIVATE = 0x00020000;
    [NativeTypeName("#define AW_SLIDE 0x00040000")]
    public const int AW_SLIDE = 0x00040000;
    [NativeTypeName("#define AW_BLEND 0x00080000")]
    public const int AW_BLEND = 0x00080000;
    [NativeTypeName("#define KF_EXTENDED 0x0100")]
    public const int KF_EXTENDED = 0x0100;
    [NativeTypeName("#define KF_DLGMODE 0x0800")]
    public const int KF_DLGMODE = 0x0800;
    [NativeTypeName("#define KF_MENUMODE 0x1000")]
    public const int KF_MENUMODE = 0x1000;
    [NativeTypeName("#define KF_ALTDOWN 0x2000")]
    public const int KF_ALTDOWN = 0x2000;
    [NativeTypeName("#define KF_REPEAT 0x4000")]
    public const int KF_REPEAT = 0x4000;
    [NativeTypeName("#define KF_UP 0x8000")]
    public const int KF_UP = 0x8000;
    [NativeTypeName("#define HC_ACTION 0")]
    public const int HC_ACTION = 0;
    [NativeTypeName("#define HC_GETNEXT 1")]
    public const int HC_GETNEXT = 1;
    [NativeTypeName("#define HC_SKIP 2")]
    public const int HC_SKIP = 2;
    [NativeTypeName("#define HC_NOREMOVE 3")]
    public const int HC_NOREMOVE = 3;
    [NativeTypeName("#define HC_NOREM HC_NOREMOVE")]
    public const int HC_NOREM = 3;
    [NativeTypeName("#define HC_SYSMODALON 4")]
    public const int HC_SYSMODALON = 4;
    [NativeTypeName("#define HC_SYSMODALOFF 5")]
    public const int HC_SYSMODALOFF = 5;
    [NativeTypeName("#define FAPPCOMMAND_MOUSE 0x8000")]
    public const int FAPPCOMMAND_MOUSE = 0x8000;
    [NativeTypeName("#define FAPPCOMMAND_KEY 0")]
    public const int FAPPCOMMAND_KEY = 0;
    [NativeTypeName("#define FAPPCOMMAND_OEM 0x1000")]
    public const int FAPPCOMMAND_OEM = 0x1000;
    [NativeTypeName("#define FAPPCOMMAND_MASK 0xF000")]
    public const int FAPPCOMMAND_MASK = 0xF000;
    [NativeTypeName("#define LLKHF_EXTENDED (KF_EXTENDED >> 8)")]
    public const int LLKHF_EXTENDED = (0x0100 >> 8);
    [NativeTypeName("#define LLKHF_INJECTED 0x00000010")]
    public const int LLKHF_INJECTED = 0x00000010;
    [NativeTypeName("#define LLKHF_ALTDOWN (KF_ALTDOWN >> 8)")]
    public const int LLKHF_ALTDOWN = (0x2000 >> 8);
    [NativeTypeName("#define LLKHF_UP (KF_UP >> 8)")]
    public const int LLKHF_UP = (0x8000 >> 8);
    [NativeTypeName("#define LLKHF_LOWER_IL_INJECTED 0x00000002")]
    public const int LLKHF_LOWER_IL_INJECTED = 0x00000002;
    [NativeTypeName("#define LLMHF_INJECTED 0x00000001")]
    public const int LLMHF_INJECTED = 0x00000001;
    [NativeTypeName("#define LLMHF_LOWER_IL_INJECTED 0x00000002")]
    public const int LLMHF_LOWER_IL_INJECTED = 0x00000002;
    [NativeTypeName("#define HKL_PREV 0")]
    public const int HKL_PREV = 0;
    [NativeTypeName("#define HKL_NEXT 1")]
    public const int HKL_NEXT = 1;
    [NativeTypeName("#define KLF_ACTIVATE 0x00000001")]
    public const int KLF_ACTIVATE = 0x00000001;
    [NativeTypeName("#define KLF_SUBSTITUTE_OK 0x00000002")]
    public const int KLF_SUBSTITUTE_OK = 0x00000002;
    [NativeTypeName("#define KLF_REORDER 0x00000008")]
    public const int KLF_REORDER = 0x00000008;
    [NativeTypeName("#define KLF_REPLACELANG 0x00000010")]
    public const int KLF_REPLACELANG = 0x00000010;
    [NativeTypeName("#define KLF_NOTELLSHELL 0x00000080")]
    public const int KLF_NOTELLSHELL = 0x00000080;
    [NativeTypeName("#define KLF_SETFORPROCESS 0x00000100")]
    public const int KLF_SETFORPROCESS = 0x00000100;
    [NativeTypeName("#define KLF_SHIFTLOCK 0x00010000")]
    public const int KLF_SHIFTLOCK = 0x00010000;
    [NativeTypeName("#define KLF_RESET 0x40000000")]
    public const int KLF_RESET = 0x40000000;
    [NativeTypeName("#define INPUTLANGCHANGE_SYSCHARSET 0x0001")]
    public const int INPUTLANGCHANGE_SYSCHARSET = 0x0001;
    [NativeTypeName("#define INPUTLANGCHANGE_FORWARD 0x0002")]
    public const int INPUTLANGCHANGE_FORWARD = 0x0002;
    [NativeTypeName("#define INPUTLANGCHANGE_BACKWARD 0x0004")]
    public const int INPUTLANGCHANGE_BACKWARD = 0x0004;
    [NativeTypeName("#define KL_NAMELENGTH 9")]
    public const int KL_NAMELENGTH = 9;
    [NativeTypeName("#define LoadKeyboardLayout LoadKeyboardLayoutW")]
    public static delegate*<ushort*, uint, HKL> LoadKeyboardLayout => &LoadKeyboardLayoutW;

    [NativeTypeName("#define GetKeyboardLayoutName GetKeyboardLayoutNameW")]
    public static delegate*<ushort*, BOOL> GetKeyboardLayoutName => &GetKeyboardLayoutNameW;

    [NativeTypeName("#define GMMP_USE_DISPLAY_POINTS 1")]
    public const int GMMP_USE_DISPLAY_POINTS = 1;
    [NativeTypeName("#define GMMP_USE_HIGH_RESOLUTION_POINTS 2")]
    public const int GMMP_USE_HIGH_RESOLUTION_POINTS = 2;
    [NativeTypeName("#define DF_ALLOWOTHERACCOUNTHOOK 0x0001L")]
    public const int DF_ALLOWOTHERACCOUNTHOOK = 0x0001;
    [NativeTypeName("#define CreateDesktop CreateDesktopW")]
    public static delegate*<ushort*, ushort*, DEVMODEW*, uint, uint, SECURITY_ATTRIBUTES*, HDESK> CreateDesktop => &CreateDesktopW;

    [NativeTypeName("#define CreateDesktopEx CreateDesktopExW")]
    public static delegate*<ushort*, ushort*, DEVMODEW*, uint, uint, SECURITY_ATTRIBUTES*, uint, void*, HDESK> CreateDesktopEx => &CreateDesktopExW;

    [NativeTypeName("#define OpenDesktop OpenDesktopW")]
    public static delegate*<ushort*, uint, BOOL, uint, HDESK> OpenDesktop => &OpenDesktopW;

    [NativeTypeName("#define EnumDesktops EnumDesktopsW")]
    public static delegate*<HWINSTA, delegate* unmanaged<ushort*, LPARAM, BOOL> , LPARAM, BOOL> EnumDesktops => &EnumDesktopsW;

    [NativeTypeName("#define CWF_CREATE_ONLY 0x00000001")]
    public const int CWF_CREATE_ONLY = 0x00000001;
    [NativeTypeName("#define WSF_VISIBLE 0x0001L")]
    public const int WSF_VISIBLE = 0x0001;
    [NativeTypeName("#define CreateWindowStation CreateWindowStationW")]
    public static delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, HWINSTA> CreateWindowStation => &CreateWindowStationW;

    [NativeTypeName("#define OpenWindowStation OpenWindowStationW")]
    public static delegate*<ushort*, BOOL, uint, HWINSTA> OpenWindowStation => &OpenWindowStationW;

    [NativeTypeName("#define EnumWindowStations EnumWindowStationsW")]
    public static delegate*<delegate* unmanaged<ushort*, LPARAM, BOOL> , LPARAM, BOOL> EnumWindowStations => &EnumWindowStationsW;

    [NativeTypeName("#define UOI_FLAGS 1")]
    public const int UOI_FLAGS = 1;
    [NativeTypeName("#define UOI_NAME 2")]
    public const int UOI_NAME = 2;
    [NativeTypeName("#define UOI_TYPE 3")]
    public const int UOI_TYPE = 3;
    [NativeTypeName("#define UOI_USER_SID 4")]
    public const int UOI_USER_SID = 4;
    [NativeTypeName("#define UOI_HEAPSIZE 5")]
    public const int UOI_HEAPSIZE = 5;
    [NativeTypeName("#define UOI_IO 6")]
    public const int UOI_IO = 6;
    [NativeTypeName("#define UOI_TIMERPROC_EXCEPTION_SUPPRESSION 7")]
    public const int UOI_TIMERPROC_EXCEPTION_SUPPRESSION = 7;
    [NativeTypeName("#define GetUserObjectInformation GetUserObjectInformationW")]
    public static delegate*<HANDLE, int, void*, uint, uint*, BOOL> GetUserObjectInformation => &GetUserObjectInformationW;

    [NativeTypeName("#define SetUserObjectInformation SetUserObjectInformationW")]
    public static delegate*<HANDLE, int, void*, uint, BOOL> SetUserObjectInformation => &SetUserObjectInformationW;

    [NativeTypeName("#define GCW_ATOM (-32)")]
    public const int GCW_ATOM = (-32);
    [NativeTypeName("#define GCLP_MENUNAME (-8)")]
    public const int GCLP_MENUNAME = (-8);
    [NativeTypeName("#define GCLP_HBRBACKGROUND (-10)")]
    public const int GCLP_HBRBACKGROUND = (-10);
    [NativeTypeName("#define GCLP_HCURSOR (-12)")]
    public const int GCLP_HCURSOR = (-12);
    [NativeTypeName("#define GCLP_HICON (-14)")]
    public const int GCLP_HICON = (-14);
    [NativeTypeName("#define GCLP_HMODULE (-16)")]
    public const int GCLP_HMODULE = (-16);
    [NativeTypeName("#define GCLP_WNDPROC (-24)")]
    public const int GCLP_WNDPROC = (-24);
    [NativeTypeName("#define GCLP_HICONSM (-34)")]
    public const int GCLP_HICONSM = (-34);
    [NativeTypeName("#define WA_INACTIVE 0")]
    public const int WA_INACTIVE = 0;
    [NativeTypeName("#define WA_ACTIVE 1")]
    public const int WA_ACTIVE = 1;
    [NativeTypeName("#define WA_CLICKACTIVE 2")]
    public const int WA_CLICKACTIVE = 2;
    [NativeTypeName("#define PWR_OK 1")]
    public const int PWR_OK = 1;
    [NativeTypeName("#define PWR_FAIL (-1)")]
    public const int PWR_FAIL = (-1);
    [NativeTypeName("#define PWR_SUSPENDREQUEST 1")]
    public const int PWR_SUSPENDREQUEST = 1;
    [NativeTypeName("#define PWR_SUSPENDRESUME 2")]
    public const int PWR_SUSPENDRESUME = 2;
    [NativeTypeName("#define PWR_CRITICALRESUME 3")]
    public const int PWR_CRITICALRESUME = 3;
    [NativeTypeName("#define NFR_ANSI 1")]
    public const int NFR_ANSI = 1;
    [NativeTypeName("#define NFR_UNICODE 2")]
    public const int NFR_UNICODE = 2;
    [NativeTypeName("#define NF_QUERY 3")]
    public const int NF_QUERY = 3;
    [NativeTypeName("#define NF_REQUERY 4")]
    public const int NF_REQUERY = 4;
    [NativeTypeName("#define UNICODE_NOCHAR 0xFFFF")]
    public const int UNICODE_NOCHAR = 0xFFFF;
    [NativeTypeName("#define UIS_SET 1")]
    public const int UIS_SET = 1;
    [NativeTypeName("#define UIS_CLEAR 2")]
    public const int UIS_CLEAR = 2;
    [NativeTypeName("#define UIS_INITIALIZE 3")]
    public const int UIS_INITIALIZE = 3;
    [NativeTypeName("#define UISF_HIDEFOCUS 0x1")]
    public const int UISF_HIDEFOCUS = 0x1;
    [NativeTypeName("#define UISF_HIDEACCEL 0x2")]
    public const int UISF_HIDEACCEL = 0x2;
    [NativeTypeName("#define UISF_ACTIVE 0x4")]
    public const int UISF_ACTIVE = 0x4;
    [NativeTypeName("#define MN_GETHMENU 0x01E1")]
    public const int MN_GETHMENU = 0x01E1;
    [NativeTypeName("#define WHEEL_DELTA 120")]
    public const int WHEEL_DELTA = 120;
    [NativeTypeName("#define WHEEL_PAGESCROLL (UINT_MAX)")]
    public const uint WHEEL_PAGESCROLL = (0xffffffff);
    [NativeTypeName("#define XBUTTON1 0x0001")]
    public const int XBUTTON1 = 0x0001;
    [NativeTypeName("#define XBUTTON2 0x0002")]
    public const int XBUTTON2 = 0x0002;
    [NativeTypeName("#define PBTF_APMRESUMEFROMFAILURE 0x00000001")]
    public const int PBTF_APMRESUMEFROMFAILURE = 0x00000001;
    [NativeTypeName("#define HTERROR (-2)")]
    public const int HTERROR = (-2);
    [NativeTypeName("#define HTTRANSPARENT (-1)")]
    public const int HTTRANSPARENT = (-1);
    [NativeTypeName("#define HTNOWHERE 0")]
    public const int HTNOWHERE = 0;
    [NativeTypeName("#define HTCLIENT 1")]
    public const int HTCLIENT = 1;
    [NativeTypeName("#define HTCAPTION 2")]
    public const int HTCAPTION = 2;
    [NativeTypeName("#define HTSYSMENU 3")]
    public const int HTSYSMENU = 3;
    [NativeTypeName("#define HTGROWBOX 4")]
    public const int HTGROWBOX = 4;
    [NativeTypeName("#define HTSIZE HTGROWBOX")]
    public const int HTSIZE = 4;
    [NativeTypeName("#define HTMENU 5")]
    public const int HTMENU = 5;
    [NativeTypeName("#define HTHSCROLL 6")]
    public const int HTHSCROLL = 6;
    [NativeTypeName("#define HTVSCROLL 7")]
    public const int HTVSCROLL = 7;
    [NativeTypeName("#define HTMINBUTTON 8")]
    public const int HTMINBUTTON = 8;
    [NativeTypeName("#define HTMAXBUTTON 9")]
    public const int HTMAXBUTTON = 9;
    [NativeTypeName("#define HTLEFT 10")]
    public const int HTLEFT = 10;
    [NativeTypeName("#define HTRIGHT 11")]
    public const int HTRIGHT = 11;
    [NativeTypeName("#define HTTOP 12")]
    public const int HTTOP = 12;
    [NativeTypeName("#define HTTOPLEFT 13")]
    public const int HTTOPLEFT = 13;
    [NativeTypeName("#define HTTOPRIGHT 14")]
    public const int HTTOPRIGHT = 14;
    [NativeTypeName("#define HTBOTTOM 15")]
    public const int HTBOTTOM = 15;
    [NativeTypeName("#define HTBOTTOMLEFT 16")]
    public const int HTBOTTOMLEFT = 16;
    [NativeTypeName("#define HTBOTTOMRIGHT 17")]
    public const int HTBOTTOMRIGHT = 17;
    [NativeTypeName("#define HTBORDER 18")]
    public const int HTBORDER = 18;
    [NativeTypeName("#define HTREDUCE HTMINBUTTON")]
    public const int HTREDUCE = 8;
    [NativeTypeName("#define HTZOOM HTMAXBUTTON")]
    public const int HTZOOM = 9;
    [NativeTypeName("#define HTSIZEFIRST HTLEFT")]
    public const int HTSIZEFIRST = 10;
    [NativeTypeName("#define HTSIZELAST HTBOTTOMRIGHT")]
    public const int HTSIZELAST = 17;
    [NativeTypeName("#define HTOBJECT 19")]
    public const int HTOBJECT = 19;
    [NativeTypeName("#define HTCLOSE 20")]
    public const int HTCLOSE = 20;
    [NativeTypeName("#define HTHELP 21")]
    public const int HTHELP = 21;
    [NativeTypeName("#define SMTO_NORMAL 0x0000")]
    public const int SMTO_NORMAL = 0x0000;
    [NativeTypeName("#define SMTO_BLOCK 0x0001")]
    public const int SMTO_BLOCK = 0x0001;
    [NativeTypeName("#define SMTO_ABORTIFHUNG 0x0002")]
    public const int SMTO_ABORTIFHUNG = 0x0002;
    [NativeTypeName("#define SMTO_NOTIMEOUTIFNOTHUNG 0x0008")]
    public const int SMTO_NOTIMEOUTIFNOTHUNG = 0x0008;
    [NativeTypeName("#define SMTO_ERRORONEXIT 0x0020")]
    public const int SMTO_ERRORONEXIT = 0x0020;
    [NativeTypeName("#define ICON_SMALL 0")]
    public const int ICON_SMALL = 0;
    [NativeTypeName("#define ICON_BIG 1")]
    public const int ICON_BIG = 1;
    [NativeTypeName("#define ICON_SMALL2 2")]
    public const int ICON_SMALL2 = 2;
    [NativeTypeName("#define RegisterWindowMessage RegisterWindowMessageW")]
    public static delegate*<ushort*, uint> RegisterWindowMessage => &RegisterWindowMessageW;

    [NativeTypeName("#define SIZE_RESTORED 0")]
    public const int SIZE_RESTORED = 0;
    [NativeTypeName("#define SIZE_MINIMIZED 1")]
    public const int SIZE_MINIMIZED = 1;
    [NativeTypeName("#define SIZE_MAXIMIZED 2")]
    public const int SIZE_MAXIMIZED = 2;
    [NativeTypeName("#define SIZE_MAXSHOW 3")]
    public const int SIZE_MAXSHOW = 3;
    [NativeTypeName("#define SIZE_MAXHIDE 4")]
    public const int SIZE_MAXHIDE = 4;
    [NativeTypeName("#define SIZENORMAL SIZE_RESTORED")]
    public const int SIZENORMAL = 0;
    [NativeTypeName("#define SIZEICONIC SIZE_MINIMIZED")]
    public const int SIZEICONIC = 1;
    [NativeTypeName("#define SIZEFULLSCREEN SIZE_MAXIMIZED")]
    public const int SIZEFULLSCREEN = 2;
    [NativeTypeName("#define SIZEZOOMSHOW SIZE_MAXSHOW")]
    public const int SIZEZOOMSHOW = 3;
    [NativeTypeName("#define SIZEZOOMHIDE SIZE_MAXHIDE")]
    public const int SIZEZOOMHIDE = 4;
    [NativeTypeName("#define HOVER_DEFAULT 0xFFFFFFFF")]
    public const uint HOVER_DEFAULT = 0xFFFFFFFF;
    [NativeTypeName("#define BDR_RAISEDOUTER 0x0001")]
    public const int BDR_RAISEDOUTER = 0x0001;
    [NativeTypeName("#define BDR_SUNKENOUTER 0x0002")]
    public const int BDR_SUNKENOUTER = 0x0002;
    [NativeTypeName("#define BDR_RAISEDINNER 0x0004")]
    public const int BDR_RAISEDINNER = 0x0004;
    [NativeTypeName("#define BDR_SUNKENINNER 0x0008")]
    public const int BDR_SUNKENINNER = 0x0008;
    [NativeTypeName("#define BDR_OUTER (BDR_RAISEDOUTER | BDR_SUNKENOUTER)")]
    public const int BDR_OUTER = (0x0001 | 0x0002);
    [NativeTypeName("#define BDR_INNER (BDR_RAISEDINNER | BDR_SUNKENINNER)")]
    public const int BDR_INNER = (0x0004 | 0x0008);
    [NativeTypeName("#define BDR_RAISED (BDR_RAISEDOUTER | BDR_RAISEDINNER)")]
    public const int BDR_RAISED = (0x0001 | 0x0004);
    [NativeTypeName("#define BDR_SUNKEN (BDR_SUNKENOUTER | BDR_SUNKENINNER)")]
    public const int BDR_SUNKEN = (0x0002 | 0x0008);
    [NativeTypeName("#define EDGE_RAISED (BDR_RAISEDOUTER | BDR_RAISEDINNER)")]
    public const int EDGE_RAISED = (0x0001 | 0x0004);
    [NativeTypeName("#define EDGE_SUNKEN (BDR_SUNKENOUTER | BDR_SUNKENINNER)")]
    public const int EDGE_SUNKEN = (0x0002 | 0x0008);
    [NativeTypeName("#define EDGE_ETCHED (BDR_SUNKENOUTER | BDR_RAISEDINNER)")]
    public const int EDGE_ETCHED = (0x0002 | 0x0004);
    [NativeTypeName("#define EDGE_BUMP (BDR_RAISEDOUTER | BDR_SUNKENINNER)")]
    public const int EDGE_BUMP = (0x0001 | 0x0008);
    [NativeTypeName("#define DFC_CAPTION 1")]
    public const int DFC_CAPTION = 1;
    [NativeTypeName("#define DFC_MENU 2")]
    public const int DFC_MENU = 2;
    [NativeTypeName("#define DFC_SCROLL 3")]
    public const int DFC_SCROLL = 3;
    [NativeTypeName("#define DFC_BUTTON 4")]
    public const int DFC_BUTTON = 4;
    [NativeTypeName("#define DFC_POPUPMENU 5")]
    public const int DFC_POPUPMENU = 5;
    [NativeTypeName("#define IDANI_OPEN 1")]
    public const int IDANI_OPEN = 1;
    [NativeTypeName("#define IDANI_CAPTION 3")]
    public const int IDANI_CAPTION = 3;
    [NativeTypeName("#define FVIRTKEY TRUE")]
    public const int FVIRTKEY = 1;
    [NativeTypeName("#define FNOINVERT 0x02")]
    public const int FNOINVERT = 0x02;
    [NativeTypeName("#define FSHIFT 0x04")]
    public const int FSHIFT = 0x04;
    [NativeTypeName("#define FCONTROL 0x08")]
    public const int FCONTROL = 0x08;
    [NativeTypeName("#define FALT 0x10")]
    public const int FALT = 0x10;
    [NativeTypeName("#define WPF_SETMINPOSITION 0x0001")]
    public const int WPF_SETMINPOSITION = 0x0001;
    [NativeTypeName("#define WPF_RESTORETOMAXIMIZED 0x0002")]
    public const int WPF_RESTORETOMAXIMIZED = 0x0002;
    [NativeTypeName("#define WPF_ASYNCWINDOWPLACEMENT 0x0004")]
    public const int WPF_ASYNCWINDOWPLACEMENT = 0x0004;
    [NativeTypeName("#define ODT_MENU 1")]
    public const int ODT_MENU = 1;
    [NativeTypeName("#define ODT_LISTBOX 2")]
    public const int ODT_LISTBOX = 2;
    [NativeTypeName("#define ODT_COMBOBOX 3")]
    public const int ODT_COMBOBOX = 3;
    [NativeTypeName("#define ODT_BUTTON 4")]
    public const int ODT_BUTTON = 4;
    [NativeTypeName("#define ODT_STATIC 5")]
    public const int ODT_STATIC = 5;
    [NativeTypeName("#define ODA_DRAWENTIRE 0x0001")]
    public const int ODA_DRAWENTIRE = 0x0001;
    [NativeTypeName("#define ODA_SELECT 0x0002")]
    public const int ODA_SELECT = 0x0002;
    [NativeTypeName("#define ODA_FOCUS 0x0004")]
    public const int ODA_FOCUS = 0x0004;
    [NativeTypeName("#define GetMessage GetMessageW")]
    public static delegate*<MSG*, HWND, uint, uint, BOOL> GetMessage => &GetMessageW;

    [NativeTypeName("#define DispatchMessage DispatchMessageW")]
    public static delegate*<MSG*, LRESULT> DispatchMessage => &DispatchMessageW;

    [NativeTypeName("#define PeekMessage PeekMessageW")]
    public static delegate*<MSG*, HWND, uint, uint, uint, BOOL> PeekMessage => &PeekMessageW;

    [NativeTypeName("#define IDHOT_SNAPWINDOW (-1)")]
    public const int IDHOT_SNAPWINDOW = (-1);
    [NativeTypeName("#define IDHOT_SNAPDESKTOP (-2)")]
    public const int IDHOT_SNAPDESKTOP = (-2);
    [NativeTypeName("#define ENDSESSION_CLOSEAPP 0x00000001")]
    public const int ENDSESSION_CLOSEAPP = 0x00000001;
    [NativeTypeName("#define ENDSESSION_CRITICAL 0x40000000")]
    public const int ENDSESSION_CRITICAL = 0x40000000;
    [NativeTypeName("#define ENDSESSION_LOGOFF 0x80000000")]
    public const uint ENDSESSION_LOGOFF = 0x80000000;
    [NativeTypeName("#define SendMessage SendMessageW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> SendMessage => &SendMessageW;

    [NativeTypeName("#define SendMessageTimeout SendMessageTimeoutW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, uint, uint, nuint*, LRESULT> SendMessageTimeout => &SendMessageTimeoutW;

    [NativeTypeName("#define SendNotifyMessage SendNotifyMessageW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, BOOL> SendNotifyMessage => &SendNotifyMessageW;

    [NativeTypeName("#define SendMessageCallback SendMessageCallbackW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, delegate* unmanaged<HWND, uint, nuint, LRESULT, void> , nuint, BOOL> SendMessageCallback => &SendMessageCallbackW;

    [NativeTypeName("#define BroadcastSystemMessageEx BroadcastSystemMessageExW")]
    public static delegate*<uint, uint*, uint, WPARAM, LPARAM, BSMINFO*, int> BroadcastSystemMessageEx => &BroadcastSystemMessageExW;

    [NativeTypeName("#define BroadcastSystemMessage BroadcastSystemMessageW")]
    public static delegate*<uint, uint*, uint, WPARAM, LPARAM, int> BroadcastSystemMessage => &BroadcastSystemMessageW;

    [NativeTypeName("#define BSM_ALLCOMPONENTS 0x00000000")]
    public const int BSM_ALLCOMPONENTS = 0x00000000;
    [NativeTypeName("#define BSM_VXDS 0x00000001")]
    public const int BSM_VXDS = 0x00000001;
    [NativeTypeName("#define BSM_NETDRIVER 0x00000002")]
    public const int BSM_NETDRIVER = 0x00000002;
    [NativeTypeName("#define BSM_INSTALLABLEDRIVERS 0x00000004")]
    public const int BSM_INSTALLABLEDRIVERS = 0x00000004;
    [NativeTypeName("#define BSM_APPLICATIONS 0x00000008")]
    public const int BSM_APPLICATIONS = 0x00000008;
    [NativeTypeName("#define BSM_ALLDESKTOPS 0x00000010")]
    public const int BSM_ALLDESKTOPS = 0x00000010;
    [NativeTypeName("#define BROADCAST_QUERY_DENY 0x424D5144")]
    public const int BROADCAST_QUERY_DENY = 0x424D5144;
    [NativeTypeName("#define RegisterDeviceNotification RegisterDeviceNotificationW")]
    public static delegate*<HANDLE, void*, uint, HDEVNOTIFY> RegisterDeviceNotification => &RegisterDeviceNotificationW;

    [NativeTypeName("#define PostMessage PostMessageW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, BOOL> PostMessage => &PostMessageW;

    [NativeTypeName("#define PostThreadMessage PostThreadMessageW")]
    public static delegate*<uint, uint, WPARAM, LPARAM, BOOL> PostThreadMessage => &PostThreadMessageW;

    [NativeTypeName("#define DefWindowProc DefWindowProcW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> DefWindowProc => &DefWindowProcW;

    [NativeTypeName("#define CallWindowProc CallWindowProcW")]
    public static delegate*<delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> , HWND, uint, WPARAM, LPARAM, LRESULT> CallWindowProc => &CallWindowProcW;

    [NativeTypeName("#define ISMEX_NOSEND 0x00000000")]
    public const int ISMEX_NOSEND = 0x00000000;
    [NativeTypeName("#define ISMEX_SEND 0x00000001")]
    public const int ISMEX_SEND = 0x00000001;
    [NativeTypeName("#define ISMEX_NOTIFY 0x00000002")]
    public const int ISMEX_NOTIFY = 0x00000002;
    [NativeTypeName("#define ISMEX_CALLBACK 0x00000004")]
    public const int ISMEX_CALLBACK = 0x00000004;
    [NativeTypeName("#define ISMEX_REPLIED 0x00000008")]
    public const int ISMEX_REPLIED = 0x00000008;
    [NativeTypeName("#define RegisterClass RegisterClassW")]
    public static delegate*<WNDCLASSW*, ushort> RegisterClass => &RegisterClassW;

    [NativeTypeName("#define UnregisterClass UnregisterClassW")]
    public static delegate*<ushort*, HINSTANCE, BOOL> UnregisterClass => &UnregisterClassW;

    [NativeTypeName("#define GetClassInfo GetClassInfoW")]
    public static delegate*<HINSTANCE, ushort*, WNDCLASSW*, BOOL> GetClassInfo => &GetClassInfoW;

    [NativeTypeName("#define RegisterClassEx RegisterClassExW")]
    public static delegate*<WNDCLASSEXW*, ushort> RegisterClassEx => &RegisterClassExW;

    [NativeTypeName("#define GetClassInfoEx GetClassInfoExW")]
    public static delegate*<HINSTANCE, ushort*, WNDCLASSEXW*, BOOL> GetClassInfoEx => &GetClassInfoExW;

    [NativeTypeName("#define CW_USEDEFAULT ((int)0x80000000)")]
    public const int CW_USEDEFAULT = unchecked((int)(0x80000000));
    [NativeTypeName("#define CreateWindowEx CreateWindowExW")]
    public static delegate*<uint, ushort*, ushort*, uint, int, int, int, int, HWND, HMENU, HINSTANCE, void*, HWND> CreateWindowEx => &CreateWindowExW;

    [NativeTypeName("#define PW_CLIENTONLY 0x00000001")]
    public const int PW_CLIENTONLY = 0x00000001;
    [NativeTypeName("#define PW_RENDERFULLCONTENT 0x00000002")]
    public const int PW_RENDERFULLCONTENT = 0x00000002;
    [NativeTypeName("#define ULW_COLORKEY 0x00000001")]
    public const int ULW_COLORKEY = 0x00000001;
    [NativeTypeName("#define ULW_ALPHA 0x00000002")]
    public const int ULW_ALPHA = 0x00000002;
    [NativeTypeName("#define ULW_OPAQUE 0x00000004")]
    public const int ULW_OPAQUE = 0x00000004;
    [NativeTypeName("#define ULW_EX_NORESIZE 0x00000008")]
    public const int ULW_EX_NORESIZE = 0x00000008;
    [NativeTypeName("#define FLASHW_STOP 0")]
    public const int FLASHW_STOP = 0;
    [NativeTypeName("#define FLASHW_CAPTION 0x00000001")]
    public const int FLASHW_CAPTION = 0x00000001;
    [NativeTypeName("#define FLASHW_TRAY 0x00000002")]
    public const int FLASHW_TRAY = 0x00000002;
    [NativeTypeName("#define FLASHW_ALL (FLASHW_CAPTION | FLASHW_TRAY)")]
    public const int FLASHW_ALL = (0x00000001 | 0x00000002);
    [NativeTypeName("#define FLASHW_TIMER 0x00000004")]
    public const int FLASHW_TIMER = 0x00000004;
    [NativeTypeName("#define FLASHW_TIMERNOFG 0x0000000C")]
    public const int FLASHW_TIMERNOFG = 0x0000000C;
    [NativeTypeName("#define WDA_NONE 0x00000000")]
    public const int WDA_NONE = 0x00000000;
    [NativeTypeName("#define WDA_MONITOR 0x00000001")]
    public const int WDA_MONITOR = 0x00000001;
    [NativeTypeName("#define WDA_EXCLUDEFROMCAPTURE 0x00000011")]
    public const int WDA_EXCLUDEFROMCAPTURE = 0x00000011;
    [NativeTypeName("#define CreateDialogParam CreateDialogParamW")]
    public static delegate*<HINSTANCE, ushort*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> , LPARAM, HWND> CreateDialogParam => &CreateDialogParamW;

    [NativeTypeName("#define CreateDialogIndirectParam CreateDialogIndirectParamW")]
    public static delegate*<HINSTANCE, DLGTEMPLATE*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> , LPARAM, HWND> CreateDialogIndirectParam => &CreateDialogIndirectParamW;

    [NativeTypeName("#define DialogBoxParam DialogBoxParamW")]
    public static delegate*<HINSTANCE, ushort*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> , LPARAM, nint> DialogBoxParam => &DialogBoxParamW;

    [NativeTypeName("#define DialogBoxIndirectParam DialogBoxIndirectParamW")]
    public static delegate*<HINSTANCE, DLGTEMPLATE*, HWND, delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> , LPARAM, nint> DialogBoxIndirectParam => &DialogBoxIndirectParamW;

    [NativeTypeName("#define SetDlgItemText SetDlgItemTextW")]
    public static delegate*<HWND, int, ushort*, BOOL> SetDlgItemText => &SetDlgItemTextW;

    [NativeTypeName("#define GetDlgItemText GetDlgItemTextW")]
    public static delegate*<HWND, int, ushort*, int, uint> GetDlgItemText => &GetDlgItemTextW;

    [NativeTypeName("#define SendDlgItemMessage SendDlgItemMessageW")]
    public static delegate*<HWND, int, uint, WPARAM, LPARAM, LRESULT> SendDlgItemMessage => &SendDlgItemMessageW;

    [NativeTypeName("#define DefDlgProc DefDlgProcW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> DefDlgProc => &DefDlgProcW;

    [NativeTypeName("#define DLGWINDOWEXTRA 30")]
    public const int DLGWINDOWEXTRA = 30;
    [NativeTypeName("#define CallMsgFilter CallMsgFilterW")]
    public static delegate*<MSG*, int, BOOL> CallMsgFilter => &CallMsgFilterW;

    [NativeTypeName("#define RegisterClipboardFormat RegisterClipboardFormatW")]
    public static delegate*<ushort*, uint> RegisterClipboardFormat => &RegisterClipboardFormatW;

    [NativeTypeName("#define GetClipboardFormatName GetClipboardFormatNameW")]
    public static delegate*<uint, ushort*, int, int> GetClipboardFormatName => &GetClipboardFormatNameW;

    [NativeTypeName("#define CharToOem CharToOemW")]
    public static delegate*<ushort*, sbyte*, BOOL> CharToOem => &CharToOemW;

    [NativeTypeName("#define OemToChar OemToCharW")]
    public static delegate*<sbyte*, ushort*, BOOL> OemToChar => &OemToCharW;

    [NativeTypeName("#define CharToOemBuff CharToOemBuffW")]
    public static delegate*<ushort*, sbyte*, uint, BOOL> CharToOemBuff => &CharToOemBuffW;

    [NativeTypeName("#define OemToCharBuff OemToCharBuffW")]
    public static delegate*<sbyte*, ushort*, uint, BOOL> OemToCharBuff => &OemToCharBuffW;

    [NativeTypeName("#define CharUpper CharUpperW")]
    public static delegate*<ushort*, ushort*> CharUpper => &CharUpperW;

    [NativeTypeName("#define CharUpperBuff CharUpperBuffW")]
    public static delegate*<ushort*, uint, uint> CharUpperBuff => &CharUpperBuffW;

    [NativeTypeName("#define CharLower CharLowerW")]
    public static delegate*<ushort*, ushort*> CharLower => &CharLowerW;

    [NativeTypeName("#define CharLowerBuff CharLowerBuffW")]
    public static delegate*<ushort*, uint, uint> CharLowerBuff => &CharLowerBuffW;

    [NativeTypeName("#define CharNext CharNextW")]
    public static delegate*<ushort*, ushort*> CharNext => &CharNextW;

    [NativeTypeName("#define CharPrev CharPrevW")]
    public static delegate*<ushort*, ushort*, ushort*> CharPrev => &CharPrevW;

    [NativeTypeName("#define AnsiToOem CharToOemA")]
    public static delegate*<sbyte*, sbyte*, BOOL> AnsiToOem => &CharToOemA;

    [NativeTypeName("#define OemToAnsi OemToCharA")]
    public static delegate*<sbyte*, sbyte*, BOOL> OemToAnsi => &OemToCharA;

    [NativeTypeName("#define AnsiToOemBuff CharToOemBuffA")]
    public static delegate*<sbyte*, sbyte*, uint, BOOL> AnsiToOemBuff => &CharToOemBuffA;

    [NativeTypeName("#define OemToAnsiBuff OemToCharBuffA")]
    public static delegate*<sbyte*, sbyte*, uint, BOOL> OemToAnsiBuff => &OemToCharBuffA;

    [NativeTypeName("#define AnsiUpper CharUpperA")]
    public static delegate*<sbyte*, sbyte*> AnsiUpper => &CharUpperA;

    [NativeTypeName("#define AnsiUpperBuff CharUpperBuffA")]
    public static delegate*<sbyte*, uint, uint> AnsiUpperBuff => &CharUpperBuffA;

    [NativeTypeName("#define AnsiLower CharLowerA")]
    public static delegate*<sbyte*, sbyte*> AnsiLower => &CharLowerA;

    [NativeTypeName("#define AnsiLowerBuff CharLowerBuffA")]
    public static delegate*<sbyte*, uint, uint> AnsiLowerBuff => &CharLowerBuffA;

    [NativeTypeName("#define AnsiNext CharNextA")]
    public static delegate*<sbyte*, sbyte*> AnsiNext => &CharNextA;

    [NativeTypeName("#define AnsiPrev CharPrevA")]
    public static delegate*<sbyte*, sbyte*, sbyte*> AnsiPrev => &CharPrevA;

    [NativeTypeName("#define IsCharAlpha IsCharAlphaW")]
    public static delegate*<ushort, BOOL> IsCharAlpha => &IsCharAlphaW;

    [NativeTypeName("#define IsCharAlphaNumeric IsCharAlphaNumericW")]
    public static delegate*<ushort, BOOL> IsCharAlphaNumeric => &IsCharAlphaNumericW;

    [NativeTypeName("#define IsCharUpper IsCharUpperW")]
    public static delegate*<ushort, BOOL> IsCharUpper => &IsCharUpperW;

    [NativeTypeName("#define IsCharLower IsCharLowerW")]
    public static delegate*<ushort, BOOL> IsCharLower => &IsCharLowerW;

    [NativeTypeName("#define GetKeyNameText GetKeyNameTextW")]
    public static delegate*<int, ushort*, int, int> GetKeyNameText => &GetKeyNameTextW;

    [NativeTypeName("#define VkKeyScan VkKeyScanW")]
    public static delegate*<ushort, short> VkKeyScan => &VkKeyScanW;

    [NativeTypeName("#define VkKeyScanEx VkKeyScanExW")]
    public static delegate*<ushort, HKL, short> VkKeyScanEx => &VkKeyScanExW;

    [NativeTypeName("#define KEYEVENTF_EXTENDEDKEY 0x0001")]
    public const int KEYEVENTF_EXTENDEDKEY = 0x0001;
    [NativeTypeName("#define KEYEVENTF_KEYUP 0x0002")]
    public const int KEYEVENTF_KEYUP = 0x0002;
    [NativeTypeName("#define KEYEVENTF_UNICODE 0x0004")]
    public const int KEYEVENTF_UNICODE = 0x0004;
    [NativeTypeName("#define KEYEVENTF_SCANCODE 0x0008")]
    public const int KEYEVENTF_SCANCODE = 0x0008;
    [NativeTypeName("#define TOUCHEVENTF_MOVE 0x0001")]
    public const int TOUCHEVENTF_MOVE = 0x0001;
    [NativeTypeName("#define TOUCHEVENTF_DOWN 0x0002")]
    public const int TOUCHEVENTF_DOWN = 0x0002;
    [NativeTypeName("#define TOUCHEVENTF_UP 0x0004")]
    public const int TOUCHEVENTF_UP = 0x0004;
    [NativeTypeName("#define TOUCHEVENTF_INRANGE 0x0008")]
    public const int TOUCHEVENTF_INRANGE = 0x0008;
    [NativeTypeName("#define TOUCHEVENTF_PRIMARY 0x0010")]
    public const int TOUCHEVENTF_PRIMARY = 0x0010;
    [NativeTypeName("#define TOUCHEVENTF_NOCOALESCE 0x0020")]
    public const int TOUCHEVENTF_NOCOALESCE = 0x0020;
    [NativeTypeName("#define TOUCHEVENTF_PEN 0x0040")]
    public const int TOUCHEVENTF_PEN = 0x0040;
    [NativeTypeName("#define TOUCHEVENTF_PALM 0x0080")]
    public const int TOUCHEVENTF_PALM = 0x0080;
    [NativeTypeName("#define TOUCHINPUTMASKF_TIMEFROMSYSTEM 0x0001")]
    public const int TOUCHINPUTMASKF_TIMEFROMSYSTEM = 0x0001;
    [NativeTypeName("#define TOUCHINPUTMASKF_EXTRAINFO 0x0002")]
    public const int TOUCHINPUTMASKF_EXTRAINFO = 0x0002;
    [NativeTypeName("#define TOUCHINPUTMASKF_CONTACTAREA 0x0004")]
    public const int TOUCHINPUTMASKF_CONTACTAREA = 0x0004;
    [NativeTypeName("#define TWF_FINETOUCH (0x00000001)")]
    public const int TWF_FINETOUCH = (0x00000001);
    [NativeTypeName("#define TWF_WANTPALM (0x00000002)")]
    public const int TWF_WANTPALM = (0x00000002);
    [NativeTypeName("#define PEN_FLAG_NONE 0x00000000")]
    public const int PEN_FLAG_NONE = 0x00000000;
    [NativeTypeName("#define PEN_FLAG_BARREL 0x00000001")]
    public const int PEN_FLAG_BARREL = 0x00000001;
    [NativeTypeName("#define PEN_FLAG_INVERTED 0x00000002")]
    public const int PEN_FLAG_INVERTED = 0x00000002;
    [NativeTypeName("#define PEN_FLAG_ERASER 0x00000004")]
    public const int PEN_FLAG_ERASER = 0x00000004;
    [NativeTypeName("#define PEN_MASK_NONE 0x00000000")]
    public const int PEN_MASK_NONE = 0x00000000;
    [NativeTypeName("#define PEN_MASK_PRESSURE 0x00000001")]
    public const int PEN_MASK_PRESSURE = 0x00000001;
    [NativeTypeName("#define PEN_MASK_ROTATION 0x00000002")]
    public const int PEN_MASK_ROTATION = 0x00000002;
    [NativeTypeName("#define PEN_MASK_TILT_X 0x00000004")]
    public const int PEN_MASK_TILT_X = 0x00000004;
    [NativeTypeName("#define PEN_MASK_TILT_Y 0x00000008")]
    public const int PEN_MASK_TILT_Y = 0x00000008;
    [NativeTypeName("#define GWFS_INCLUDE_ANCESTORS 0x00000001")]
    public const int GWFS_INCLUDE_ANCESTORS = 0x00000001;
    [NativeTypeName("#define MapVirtualKey MapVirtualKeyW")]
    public static delegate*<uint, uint, uint> MapVirtualKey => &MapVirtualKeyW;

    [NativeTypeName("#define MapVirtualKeyEx MapVirtualKeyExW")]
    public static delegate*<uint, uint, HKL, uint> MapVirtualKeyEx => &MapVirtualKeyExW;

    [NativeTypeName("#define MAPVK_VK_TO_VSC (0)")]
    public const int MAPVK_VK_TO_VSC = (0);
    [NativeTypeName("#define MAPVK_VSC_TO_VK (1)")]
    public const int MAPVK_VSC_TO_VK = (1);
    [NativeTypeName("#define MAPVK_VK_TO_CHAR (2)")]
    public const int MAPVK_VK_TO_CHAR = (2);
    [NativeTypeName("#define MAPVK_VSC_TO_VK_EX (3)")]
    public const int MAPVK_VSC_TO_VK_EX = (3);
    [NativeTypeName("#define MAPVK_VK_TO_VSC_EX (4)")]
    public const int MAPVK_VK_TO_VSC_EX = (4);
    [NativeTypeName("#define USER_TIMER_MAXIMUM 0x7FFFFFFF")]
    public const int USER_TIMER_MAXIMUM = 0x7FFFFFFF;
    [NativeTypeName("#define USER_TIMER_MINIMUM 0x0000000A")]
    public const int USER_TIMER_MINIMUM = 0x0000000A;
    [NativeTypeName("#define TIMERV_DEFAULT_COALESCING (0)")]
    public const int TIMERV_DEFAULT_COALESCING = (0);
    [NativeTypeName("#define TIMERV_NO_COALESCING (0xFFFFFFFF)")]
    public const uint TIMERV_NO_COALESCING = (0xFFFFFFFF);
    [NativeTypeName("#define TIMERV_COALESCING_MIN (1)")]
    public const int TIMERV_COALESCING_MIN = (1);
    [NativeTypeName("#define TIMERV_COALESCING_MAX (0x7FFFFFF5)")]
    public const int TIMERV_COALESCING_MAX = (0x7FFFFFF5);
    [NativeTypeName("#define LoadAccelerators LoadAcceleratorsW")]
    public static delegate*<HINSTANCE, ushort*, HACCEL> LoadAccelerators => &LoadAcceleratorsW;

    [NativeTypeName("#define CreateAcceleratorTable CreateAcceleratorTableW")]
    public static delegate*<ACCEL*, int, HACCEL> CreateAcceleratorTable => &CreateAcceleratorTableW;

    [NativeTypeName("#define CopyAcceleratorTable CopyAcceleratorTableW")]
    public static delegate*<HACCEL, ACCEL*, int, int> CopyAcceleratorTable => &CopyAcceleratorTableW;

    [NativeTypeName("#define TranslateAccelerator TranslateAcceleratorW")]
    public static delegate*<HWND, HACCEL, MSG*, int> TranslateAccelerator => &TranslateAcceleratorW;

    [NativeTypeName("#define LoadMenu LoadMenuW")]
    public static delegate*<HINSTANCE, ushort*, HMENU> LoadMenu => &LoadMenuW;

    [NativeTypeName("#define LoadMenuIndirect LoadMenuIndirectW")]
    public static delegate*<void*, HMENU> LoadMenuIndirect => &LoadMenuIndirectW;

    [NativeTypeName("#define ChangeMenu ChangeMenuW")]
    public static delegate*<HMENU, uint, ushort*, uint, uint, BOOL> ChangeMenu => &ChangeMenuW;

    [NativeTypeName("#define GetMenuString GetMenuStringW")]
    public static delegate*<HMENU, uint, ushort*, int, uint, int> GetMenuString => &GetMenuStringW;

    [NativeTypeName("#define PMB_ACTIVE 0x00000001")]
    public const int PMB_ACTIVE = 0x00000001;
    [NativeTypeName("#define InsertMenu InsertMenuW")]
    public static delegate*<HMENU, uint, uint, nuint, ushort*, BOOL> InsertMenu => &InsertMenuW;

    [NativeTypeName("#define AppendMenu AppendMenuW")]
    public static delegate*<HMENU, uint, nuint, ushort*, BOOL> AppendMenu => &AppendMenuW;

    [NativeTypeName("#define ModifyMenu ModifyMenuW")]
    public static delegate*<HMENU, uint, uint, nuint, ushort*, BOOL> ModifyMenu => &ModifyMenuW;

    [NativeTypeName("#define MNC_IGNORE 0")]
    public const int MNC_IGNORE = 0;
    [NativeTypeName("#define MNC_CLOSE 1")]
    public const int MNC_CLOSE = 1;
    [NativeTypeName("#define MNC_EXECUTE 2")]
    public const int MNC_EXECUTE = 2;
    [NativeTypeName("#define MNC_SELECT 3")]
    public const int MNC_SELECT = 3;
    [NativeTypeName("#define MNS_NOCHECK 0x80000000")]
    public const uint MNS_NOCHECK = 0x80000000;
    [NativeTypeName("#define MNS_MODELESS 0x40000000")]
    public const int MNS_MODELESS = 0x40000000;
    [NativeTypeName("#define MNS_DRAGDROP 0x20000000")]
    public const int MNS_DRAGDROP = 0x20000000;
    [NativeTypeName("#define MNS_AUTODISMISS 0x10000000")]
    public const int MNS_AUTODISMISS = 0x10000000;
    [NativeTypeName("#define MNS_NOTIFYBYPOS 0x08000000")]
    public const int MNS_NOTIFYBYPOS = 0x08000000;
    [NativeTypeName("#define MNS_CHECKORBMP 0x04000000")]
    public const int MNS_CHECKORBMP = 0x04000000;
    [NativeTypeName("#define MND_CONTINUE 0")]
    public const int MND_CONTINUE = 0;
    [NativeTypeName("#define MND_ENDMENU 1")]
    public const int MND_ENDMENU = 1;
    [NativeTypeName("#define MNGOF_TOPGAP 0x00000001")]
    public const int MNGOF_TOPGAP = 0x00000001;
    [NativeTypeName("#define MNGOF_BOTTOMGAP 0x00000002")]
    public const int MNGOF_BOTTOMGAP = 0x00000002;
    [NativeTypeName("#define MNGO_NOINTERFACE 0x00000000")]
    public const int MNGO_NOINTERFACE = 0x00000000;
    [NativeTypeName("#define MNGO_NOERROR 0x00000001")]
    public const int MNGO_NOERROR = 0x00000001;
    [NativeTypeName("#define MIIM_STATE 0x00000001")]
    public const int MIIM_STATE = 0x00000001;
    [NativeTypeName("#define MIIM_ID 0x00000002")]
    public const int MIIM_ID = 0x00000002;
    [NativeTypeName("#define MIIM_SUBMENU 0x00000004")]
    public const int MIIM_SUBMENU = 0x00000004;
    [NativeTypeName("#define MIIM_CHECKMARKS 0x00000008")]
    public const int MIIM_CHECKMARKS = 0x00000008;
    [NativeTypeName("#define MIIM_TYPE 0x00000010")]
    public const int MIIM_TYPE = 0x00000010;
    [NativeTypeName("#define MIIM_DATA 0x00000020")]
    public const int MIIM_DATA = 0x00000020;
    [NativeTypeName("#define MIIM_STRING 0x00000040")]
    public const int MIIM_STRING = 0x00000040;
    [NativeTypeName("#define MIIM_BITMAP 0x00000080")]
    public const int MIIM_BITMAP = 0x00000080;
    [NativeTypeName("#define MIIM_FTYPE 0x00000100")]
    public const int MIIM_FTYPE = 0x00000100;
    [NativeTypeName("#define InsertMenuItem InsertMenuItemW")]
    public static delegate*<HMENU, uint, BOOL, MENUITEMINFOW*, BOOL> InsertMenuItem => &InsertMenuItemW;

    [NativeTypeName("#define GetMenuItemInfo GetMenuItemInfoW")]
    public static delegate*<HMENU, uint, BOOL, MENUITEMINFOW*, BOOL> GetMenuItemInfo => &GetMenuItemInfoW;

    [NativeTypeName("#define SetMenuItemInfo SetMenuItemInfoW")]
    public static delegate*<HMENU, uint, BOOL, MENUITEMINFOW*, BOOL> SetMenuItemInfo => &SetMenuItemInfoW;

    [NativeTypeName("#define GMDI_USEDISABLED 0x0001L")]
    public const int GMDI_USEDISABLED = 0x0001;
    [NativeTypeName("#define GMDI_GOINTOPOPUPS 0x0002L")]
    public const int GMDI_GOINTOPOPUPS = 0x0002;
    [NativeTypeName("#define DOF_EXECUTABLE 0x8001")]
    public const int DOF_EXECUTABLE = 0x8001;
    [NativeTypeName("#define DOF_DOCUMENT 0x8002")]
    public const int DOF_DOCUMENT = 0x8002;
    [NativeTypeName("#define DOF_DIRECTORY 0x8003")]
    public const int DOF_DIRECTORY = 0x8003;
    [NativeTypeName("#define DOF_MULTIPLE 0x8004")]
    public const int DOF_MULTIPLE = 0x8004;
    [NativeTypeName("#define DOF_PROGMAN 0x0001")]
    public const int DOF_PROGMAN = 0x0001;
    [NativeTypeName("#define DOF_SHELLDATA 0x0002")]
    public const int DOF_SHELLDATA = 0x0002;
    [NativeTypeName("#define DO_DROPFILE 0x454C4946L")]
    public const int DO_DROPFILE = 0x454C4946;
    [NativeTypeName("#define DO_PRINTFILE 0x544E5250L")]
    public const int DO_PRINTFILE = 0x544E5250;
    [NativeTypeName("#define DrawText DrawTextW")]
    public static delegate*<HDC, ushort*, int, RECT*, uint, int> DrawText => &DrawTextW;

    [NativeTypeName("#define DrawTextEx DrawTextExW")]
    public static delegate*<HDC, ushort*, int, RECT*, uint, DRAWTEXTPARAMS*, int> DrawTextEx => &DrawTextExW;

    [NativeTypeName("#define GrayString GrayStringW")]
    public static delegate*<HDC, HBRUSH, delegate* unmanaged<HDC, LPARAM, int, BOOL> , LPARAM, int, int, int, int, int, BOOL> GrayString => &GrayStringW;

    [NativeTypeName("#define DST_COMPLEX 0x0000")]
    public const int DST_COMPLEX = 0x0000;
    [NativeTypeName("#define DST_TEXT 0x0001")]
    public const int DST_TEXT = 0x0001;
    [NativeTypeName("#define DST_PREFIXTEXT 0x0002")]
    public const int DST_PREFIXTEXT = 0x0002;
    [NativeTypeName("#define DST_ICON 0x0003")]
    public const int DST_ICON = 0x0003;
    [NativeTypeName("#define DST_BITMAP 0x0004")]
    public const int DST_BITMAP = 0x0004;
    [NativeTypeName("#define DSS_NORMAL 0x0000")]
    public const int DSS_NORMAL = 0x0000;
    [NativeTypeName("#define DSS_UNION 0x0010")]
    public const int DSS_UNION = 0x0010;
    [NativeTypeName("#define DSS_DISABLED 0x0020")]
    public const int DSS_DISABLED = 0x0020;
    [NativeTypeName("#define DSS_MONO 0x0080")]
    public const int DSS_MONO = 0x0080;
    [NativeTypeName("#define DSS_HIDEPREFIX 0x0200")]
    public const int DSS_HIDEPREFIX = 0x0200;
    [NativeTypeName("#define DSS_PREFIXONLY 0x0400")]
    public const int DSS_PREFIXONLY = 0x0400;
    [NativeTypeName("#define DSS_RIGHT 0x8000")]
    public const int DSS_RIGHT = 0x8000;
    [NativeTypeName("#define DrawState DrawStateW")]
    public static delegate*<HDC, HBRUSH, delegate* unmanaged<HDC, LPARAM, WPARAM, int, int, BOOL> , LPARAM, WPARAM, int, int, int, int, uint, BOOL> DrawState => &DrawStateW;

    [NativeTypeName("#define TabbedTextOut TabbedTextOutW")]
    public static delegate*<HDC, int, int, ushort*, int, int, int*, int, int> TabbedTextOut => &TabbedTextOutW;

    [NativeTypeName("#define GetTabbedTextExtent GetTabbedTextExtentW")]
    public static delegate*<HDC, ushort*, int, int, int*, uint> GetTabbedTextExtent => &GetTabbedTextExtentW;

    [NativeTypeName("#define ASFW_ANY ((DWORD)-1)")]
    public const uint ASFW_ANY = unchecked((uint)(-1));
    [NativeTypeName("#define LSFW_LOCK 1")]
    public const int LSFW_LOCK = 1;
    [NativeTypeName("#define LSFW_UNLOCK 2")]
    public const int LSFW_UNLOCK = 2;
    [NativeTypeName("#define ESB_ENABLE_BOTH 0x0000")]
    public const int ESB_ENABLE_BOTH = 0x0000;
    [NativeTypeName("#define ESB_DISABLE_BOTH 0x0003")]
    public const int ESB_DISABLE_BOTH = 0x0003;
    [NativeTypeName("#define ESB_DISABLE_LEFT 0x0001")]
    public const int ESB_DISABLE_LEFT = 0x0001;
    [NativeTypeName("#define ESB_DISABLE_RIGHT 0x0002")]
    public const int ESB_DISABLE_RIGHT = 0x0002;
    [NativeTypeName("#define ESB_DISABLE_UP 0x0001")]
    public const int ESB_DISABLE_UP = 0x0001;
    [NativeTypeName("#define ESB_DISABLE_DOWN 0x0002")]
    public const int ESB_DISABLE_DOWN = 0x0002;
    [NativeTypeName("#define ESB_DISABLE_LTUP ESB_DISABLE_LEFT")]
    public const int ESB_DISABLE_LTUP = 0x0001;
    [NativeTypeName("#define ESB_DISABLE_RTDN ESB_DISABLE_RIGHT")]
    public const int ESB_DISABLE_RTDN = 0x0002;
    [NativeTypeName("#define SetProp SetPropW")]
    public static delegate*<HWND, ushort*, HANDLE, BOOL> SetProp => &SetPropW;

    [NativeTypeName("#define GetProp GetPropW")]
    public static delegate*<HWND, ushort*, HANDLE> GetProp => &GetPropW;

    [NativeTypeName("#define RemoveProp RemovePropW")]
    public static delegate*<HWND, ushort*, HANDLE> RemoveProp => &RemovePropW;

    [NativeTypeName("#define EnumPropsEx EnumPropsExW")]
    public static delegate*<HWND, delegate* unmanaged<HWND, ushort*, HANDLE, nuint, BOOL> , LPARAM, int> EnumPropsEx => &EnumPropsExW;

    [NativeTypeName("#define EnumProps EnumPropsW")]
    public static delegate*<HWND, delegate* unmanaged<HWND, ushort*, HANDLE, BOOL> , int> EnumProps => &EnumPropsW;

    [NativeTypeName("#define SetWindowText SetWindowTextW")]
    public static delegate*<HWND, ushort*, BOOL> SetWindowText => &SetWindowTextW;

    [NativeTypeName("#define GetWindowText GetWindowTextW")]
    public static delegate*<HWND, ushort*, int, int> GetWindowText => &GetWindowTextW;

    [NativeTypeName("#define GetWindowTextLength GetWindowTextLengthW")]
    public static delegate*<HWND, int> GetWindowTextLength => &GetWindowTextLengthW;

    [NativeTypeName("#define HELPINFO_WINDOW 0x0001")]
    public const int HELPINFO_WINDOW = 0x0001;
    [NativeTypeName("#define HELPINFO_MENUITEM 0x0002")]
    public const int HELPINFO_MENUITEM = 0x0002;
    [NativeTypeName("#define MessageBox MessageBoxW")]
    public static delegate*<HWND, ushort*, ushort*, uint, int> MessageBox => &MessageBoxW;

    [NativeTypeName("#define MessageBoxEx MessageBoxExW")]
    public static delegate*<HWND, ushort*, ushort*, uint, ushort, int> MessageBoxEx => &MessageBoxExW;

    [NativeTypeName("#define MessageBoxIndirect MessageBoxIndirectW")]
    public static delegate*<MSGBOXPARAMSW*, int> MessageBoxIndirect => &MessageBoxIndirectW;

    [NativeTypeName("#define CWP_ALL 0x0000")]
    public const int CWP_ALL = 0x0000;
    [NativeTypeName("#define CWP_SKIPINVISIBLE 0x0001")]
    public const int CWP_SKIPINVISIBLE = 0x0001;
    [NativeTypeName("#define CWP_SKIPDISABLED 0x0002")]
    public const int CWP_SKIPDISABLED = 0x0002;
    [NativeTypeName("#define CWP_SKIPTRANSPARENT 0x0004")]
    public const int CWP_SKIPTRANSPARENT = 0x0004;
    [NativeTypeName("#define CTLCOLOR_MSGBOX 0")]
    public const int CTLCOLOR_MSGBOX = 0;
    [NativeTypeName("#define CTLCOLOR_EDIT 1")]
    public const int CTLCOLOR_EDIT = 1;
    [NativeTypeName("#define CTLCOLOR_LISTBOX 2")]
    public const int CTLCOLOR_LISTBOX = 2;
    [NativeTypeName("#define CTLCOLOR_BTN 3")]
    public const int CTLCOLOR_BTN = 3;
    [NativeTypeName("#define CTLCOLOR_DLG 4")]
    public const int CTLCOLOR_DLG = 4;
    [NativeTypeName("#define CTLCOLOR_SCROLLBAR 5")]
    public const int CTLCOLOR_SCROLLBAR = 5;
    [NativeTypeName("#define CTLCOLOR_STATIC 6")]
    public const int CTLCOLOR_STATIC = 6;
    [NativeTypeName("#define CTLCOLOR_MAX 7")]
    public const int CTLCOLOR_MAX = 7;
    [NativeTypeName("#define GetWindowLong GetWindowLongW")]
    public static delegate*<HWND, int, int> GetWindowLong => &GetWindowLongW;

    [NativeTypeName("#define SetWindowLong SetWindowLongW")]
    public static delegate*<HWND, int, int, int> SetWindowLong => &SetWindowLongW;

    [NativeTypeName("#define GetClassLong GetClassLongW")]
    public static delegate*<HWND, int, uint> GetClassLong => &GetClassLongW;

    [NativeTypeName("#define SetClassLong SetClassLongW")]
    public static delegate*<HWND, int, int, uint> SetClassLong => &SetClassLongW;

    [NativeTypeName("#define FindWindow FindWindowW")]
    public static delegate*<ushort*, ushort*, HWND> FindWindow => &FindWindowW;

    [NativeTypeName("#define FindWindowEx FindWindowExW")]
    public static delegate*<HWND, HWND, ushort*, ushort*, HWND> FindWindowEx => &FindWindowExW;

    [NativeTypeName("#define GetClassName GetClassNameW")]
    public static delegate*<HWND, ushort*, int, int> GetClassName => &GetClassNameW;

    [NativeTypeName("#define GW_HWNDFIRST 0")]
    public const int GW_HWNDFIRST = 0;
    [NativeTypeName("#define GW_HWNDLAST 1")]
    public const int GW_HWNDLAST = 1;
    [NativeTypeName("#define GW_HWNDNEXT 2")]
    public const int GW_HWNDNEXT = 2;
    [NativeTypeName("#define GW_HWNDPREV 3")]
    public const int GW_HWNDPREV = 3;
    [NativeTypeName("#define GW_OWNER 4")]
    public const int GW_OWNER = 4;
    [NativeTypeName("#define GW_CHILD 5")]
    public const int GW_CHILD = 5;
    [NativeTypeName("#define GW_ENABLEDPOPUP 6")]
    public const int GW_ENABLEDPOPUP = 6;
    [NativeTypeName("#define GW_MAX 6")]
    public const int GW_MAX = 6;
    [NativeTypeName("#define SetWindowsHook SetWindowsHookW")]
    public static delegate*<int, delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> , HHOOK> SetWindowsHook => &SetWindowsHookW;

    [NativeTypeName("#define SetWindowsHookEx SetWindowsHookExW")]
    public static delegate*<int, delegate* unmanaged<int, WPARAM, LPARAM, LRESULT> , HINSTANCE, uint, HHOOK> SetWindowsHookEx => &SetWindowsHookExW;

    [NativeTypeName("#define MFS_GRAYED 0x00000003L")]
    public const int MFS_GRAYED = 0x00000003;
    [NativeTypeName("#define MFS_DISABLED MFS_GRAYED")]
    public const int MFS_DISABLED = 0x00000003;
    [NativeTypeName("#define MFS_CHECKED MF_CHECKED")]
    public const int MFS_CHECKED = 0x00000008;
    [NativeTypeName("#define MFS_HILITE MF_HILITE")]
    public const int MFS_HILITE = 0x00000080;
    [NativeTypeName("#define MFS_ENABLED MF_ENABLED")]
    public const int MFS_ENABLED = 0x00000000;
    [NativeTypeName("#define MFS_UNCHECKED MF_UNCHECKED")]
    public const int MFS_UNCHECKED = 0x00000000;
    [NativeTypeName("#define MFS_UNHILITE MF_UNHILITE")]
    public const int MFS_UNHILITE = 0x00000000;
    [NativeTypeName("#define MFS_DEFAULT MF_DEFAULT")]
    public const int MFS_DEFAULT = 0x00001000;
    [NativeTypeName("#define SCF_ISSECURE 0x00000001")]
    public const int SCF_ISSECURE = 0x00000001;
    [NativeTypeName("#define LoadBitmap LoadBitmapW")]
    public static delegate*<HINSTANCE, ushort*, HBITMAP> LoadBitmap => &LoadBitmapW;

    [NativeTypeName("#define LoadCursor LoadCursorW")]
    public static delegate*<HINSTANCE, ushort*, HCURSOR> LoadCursor => &LoadCursorW;

    [NativeTypeName("#define LoadCursorFromFile LoadCursorFromFileW")]
    public static delegate*<ushort*, HCURSOR> LoadCursorFromFile => &LoadCursorFromFileW;

    [NativeTypeName("#define LoadIcon LoadIconW")]
    public static delegate*<HINSTANCE, ushort*, HICON> LoadIcon => &LoadIconW;

    [NativeTypeName("#define PrivateExtractIcons PrivateExtractIconsW")]
    public static delegate*<ushort*, int, int, int, HICON*, uint*, uint, uint, uint> PrivateExtractIcons => &PrivateExtractIconsW;

    [NativeTypeName("#define CURSOR_CREATION_SCALING_NONE 1")]
    public const int CURSOR_CREATION_SCALING_NONE = 1;
    [NativeTypeName("#define CURSOR_CREATION_SCALING_DEFAULT 2")]
    public const int CURSOR_CREATION_SCALING_DEFAULT = 2;
    [NativeTypeName("#define LoadImage LoadImageW")]
    public static delegate*<HINSTANCE, ushort*, uint, int, int, uint, HANDLE> LoadImage => &LoadImageW;

    [NativeTypeName("#define GetIconInfoEx GetIconInfoExW")]
    public static delegate*<HICON, ICONINFOEXW*, BOOL> GetIconInfoEx => &GetIconInfoExW;

    [NativeTypeName("#define RES_ICON 1")]
    public const int RES_ICON = 1;
    [NativeTypeName("#define RES_CURSOR 2")]
    public const int RES_CURSOR = 2;
    [NativeTypeName("#define ORD_LANGDRIVER 1")]
    public const int ORD_LANGDRIVER = 1;
    [NativeTypeName("#define IDOK 1")]
    public const int IDOK = 1;
    [NativeTypeName("#define IDCANCEL 2")]
    public const int IDCANCEL = 2;
    [NativeTypeName("#define IDABORT 3")]
    public const int IDABORT = 3;
    [NativeTypeName("#define IDRETRY 4")]
    public const int IDRETRY = 4;
    [NativeTypeName("#define IDIGNORE 5")]
    public const int IDIGNORE = 5;
    [NativeTypeName("#define IDYES 6")]
    public const int IDYES = 6;
    [NativeTypeName("#define IDNO 7")]
    public const int IDNO = 7;
    [NativeTypeName("#define IDCLOSE 8")]
    public const int IDCLOSE = 8;
    [NativeTypeName("#define IDHELP 9")]
    public const int IDHELP = 9;
    [NativeTypeName("#define IDTRYAGAIN 10")]
    public const int IDTRYAGAIN = 10;
    [NativeTypeName("#define IDCONTINUE 11")]
    public const int IDCONTINUE = 11;
    [NativeTypeName("#define IDTIMEOUT 32000")]
    public const int IDTIMEOUT = 32000;
    [NativeTypeName("#define EMSIS_COMPOSITIONSTRING 0x0001")]
    public const int EMSIS_COMPOSITIONSTRING = 0x0001;
    [NativeTypeName("#define EIMES_GETCOMPSTRATONCE 0x0001")]
    public const int EIMES_GETCOMPSTRATONCE = 0x0001;
    [NativeTypeName("#define EIMES_CANCELCOMPSTRINFOCUS 0x0002")]
    public const int EIMES_CANCELCOMPSTRINFOCUS = 0x0002;
    [NativeTypeName("#define EIMES_COMPLETECOMPSTRKILLFOCUS 0x0004")]
    public const int EIMES_COMPLETECOMPSTRKILLFOCUS = 0x0004;
    [NativeTypeName("#define WB_LEFT 0")]
    public const int WB_LEFT = 0;
    [NativeTypeName("#define WB_RIGHT 1")]
    public const int WB_RIGHT = 1;
    [NativeTypeName("#define WB_ISDELIMITER 2")]
    public const int WB_ISDELIMITER = 2;
    [NativeTypeName("#define BM_GETCHECK 0x00F0")]
    public const int BM_GETCHECK = 0x00F0;
    [NativeTypeName("#define BM_SETCHECK 0x00F1")]
    public const int BM_SETCHECK = 0x00F1;
    [NativeTypeName("#define BM_GETSTATE 0x00F2")]
    public const int BM_GETSTATE = 0x00F2;
    [NativeTypeName("#define BM_SETSTATE 0x00F3")]
    public const int BM_SETSTATE = 0x00F3;
    [NativeTypeName("#define BM_SETSTYLE 0x00F4")]
    public const int BM_SETSTYLE = 0x00F4;
    [NativeTypeName("#define BM_CLICK 0x00F5")]
    public const int BM_CLICK = 0x00F5;
    [NativeTypeName("#define BM_GETIMAGE 0x00F6")]
    public const int BM_GETIMAGE = 0x00F6;
    [NativeTypeName("#define BM_SETIMAGE 0x00F7")]
    public const int BM_SETIMAGE = 0x00F7;
    [NativeTypeName("#define BM_SETDONTCLICK 0x00F8")]
    public const int BM_SETDONTCLICK = 0x00F8;
    [NativeTypeName("#define BST_UNCHECKED 0x0000")]
    public const int BST_UNCHECKED = 0x0000;
    [NativeTypeName("#define BST_CHECKED 0x0001")]
    public const int BST_CHECKED = 0x0001;
    [NativeTypeName("#define BST_INDETERMINATE 0x0002")]
    public const int BST_INDETERMINATE = 0x0002;
    [NativeTypeName("#define BST_PUSHED 0x0004")]
    public const int BST_PUSHED = 0x0004;
    [NativeTypeName("#define BST_FOCUS 0x0008")]
    public const int BST_FOCUS = 0x0008;
    [NativeTypeName("#define STM_SETICON 0x0170")]
    public const int STM_SETICON = 0x0170;
    [NativeTypeName("#define STM_GETICON 0x0171")]
    public const int STM_GETICON = 0x0171;
    [NativeTypeName("#define STM_SETIMAGE 0x0172")]
    public const int STM_SETIMAGE = 0x0172;
    [NativeTypeName("#define STM_GETIMAGE 0x0173")]
    public const int STM_GETIMAGE = 0x0173;
    [NativeTypeName("#define STN_CLICKED 0")]
    public const int STN_CLICKED = 0;
    [NativeTypeName("#define STN_DBLCLK 1")]
    public const int STN_DBLCLK = 1;
    [NativeTypeName("#define STN_ENABLE 2")]
    public const int STN_ENABLE = 2;
    [NativeTypeName("#define STN_DISABLE 3")]
    public const int STN_DISABLE = 3;
    [NativeTypeName("#define STM_MSGMAX 0x0174")]
    public const int STM_MSGMAX = 0x0174;
    [NativeTypeName("#define DWL_MSGRESULT 0")]
    public const int DWL_MSGRESULT = 0;
    [NativeTypeName("#define DWL_DLGPROC 4")]
    public const int DWL_DLGPROC = 4;
    [NativeTypeName("#define DWL_USER 8")]
    public const int DWL_USER = 8;
    [NativeTypeName("#define DWLP_MSGRESULT 0")]
    public const int DWLP_MSGRESULT = 0;
    [NativeTypeName("#define DWLP_DLGPROC DWLP_MSGRESULT + sizeof(LRESULT)")]
    public static uint DWLP_DLGPROC => unchecked(0 + (uint)(sizeof(LRESULT)));

    [NativeTypeName("#define DWLP_USER DWLP_DLGPROC + sizeof(DLGPROC)")]
    public static uint DWLP_USER => unchecked(0 + (uint)(sizeof(LRESULT)) + (uint)(sizeof(delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> )));

    [NativeTypeName("#define IsDialogMessage IsDialogMessageW")]
    public static delegate*<HWND, MSG*, BOOL> IsDialogMessage => &IsDialogMessageW;

    [NativeTypeName("#define DlgDirList DlgDirListW")]
    public static delegate*<HWND, ushort*, int, int, uint, int> DlgDirList => &DlgDirListW;

    [NativeTypeName("#define DDL_READWRITE 0x0000")]
    public const int DDL_READWRITE = 0x0000;
    [NativeTypeName("#define DDL_READONLY 0x0001")]
    public const int DDL_READONLY = 0x0001;
    [NativeTypeName("#define DDL_HIDDEN 0x0002")]
    public const int DDL_HIDDEN = 0x0002;
    [NativeTypeName("#define DDL_SYSTEM 0x0004")]
    public const int DDL_SYSTEM = 0x0004;
    [NativeTypeName("#define DDL_DIRECTORY 0x0010")]
    public const int DDL_DIRECTORY = 0x0010;
    [NativeTypeName("#define DDL_ARCHIVE 0x0020")]
    public const int DDL_ARCHIVE = 0x0020;
    [NativeTypeName("#define DDL_POSTMSGS 0x2000")]
    public const int DDL_POSTMSGS = 0x2000;
    [NativeTypeName("#define DDL_DRIVES 0x4000")]
    public const int DDL_DRIVES = 0x4000;
    [NativeTypeName("#define DDL_EXCLUSIVE 0x8000")]
    public const int DDL_EXCLUSIVE = 0x8000;
    [NativeTypeName("#define DlgDirSelectEx DlgDirSelectExW")]
    public static delegate*<HWND, ushort*, int, int, BOOL> DlgDirSelectEx => &DlgDirSelectExW;

    [NativeTypeName("#define DlgDirListComboBox DlgDirListComboBoxW")]
    public static delegate*<HWND, ushort*, int, int, uint, int> DlgDirListComboBox => &DlgDirListComboBoxW;

    [NativeTypeName("#define DlgDirSelectComboBoxEx DlgDirSelectComboBoxExW")]
    public static delegate*<HWND, ushort*, int, int, BOOL> DlgDirSelectComboBoxEx => &DlgDirSelectComboBoxExW;

    [NativeTypeName("#define LBN_ERRSPACE (-2)")]
    public const int LBN_ERRSPACE = (-2);
    [NativeTypeName("#define LBN_SELCHANGE 1")]
    public const int LBN_SELCHANGE = 1;
    [NativeTypeName("#define LBN_DBLCLK 2")]
    public const int LBN_DBLCLK = 2;
    [NativeTypeName("#define LBN_SELCANCEL 3")]
    public const int LBN_SELCANCEL = 3;
    [NativeTypeName("#define LBN_SETFOCUS 4")]
    public const int LBN_SETFOCUS = 4;
    [NativeTypeName("#define LBN_KILLFOCUS 5")]
    public const int LBN_KILLFOCUS = 5;
    [NativeTypeName("#define SBM_SETPOS 0x00E0")]
    public const int SBM_SETPOS = 0x00E0;
    [NativeTypeName("#define SBM_GETPOS 0x00E1")]
    public const int SBM_GETPOS = 0x00E1;
    [NativeTypeName("#define SBM_SETRANGE 0x00E2")]
    public const int SBM_SETRANGE = 0x00E2;
    [NativeTypeName("#define SBM_SETRANGEREDRAW 0x00E6")]
    public const int SBM_SETRANGEREDRAW = 0x00E6;
    [NativeTypeName("#define SBM_GETRANGE 0x00E3")]
    public const int SBM_GETRANGE = 0x00E3;
    [NativeTypeName("#define SBM_ENABLE_ARROWS 0x00E4")]
    public const int SBM_ENABLE_ARROWS = 0x00E4;
    [NativeTypeName("#define SBM_SETSCROLLINFO 0x00E9")]
    public const int SBM_SETSCROLLINFO = 0x00E9;
    [NativeTypeName("#define SBM_GETSCROLLINFO 0x00EA")]
    public const int SBM_GETSCROLLINFO = 0x00EA;
    [NativeTypeName("#define SBM_GETSCROLLBARINFO 0x00EB")]
    public const int SBM_GETSCROLLBARINFO = 0x00EB;
    [NativeTypeName("#define SIF_RANGE 0x0001")]
    public const int SIF_RANGE = 0x0001;
    [NativeTypeName("#define SIF_PAGE 0x0002")]
    public const int SIF_PAGE = 0x0002;
    [NativeTypeName("#define SIF_POS 0x0004")]
    public const int SIF_POS = 0x0004;
    [NativeTypeName("#define SIF_DISABLENOSCROLL 0x0008")]
    public const int SIF_DISABLENOSCROLL = 0x0008;
    [NativeTypeName("#define SIF_TRACKPOS 0x0010")]
    public const int SIF_TRACKPOS = 0x0010;
    [NativeTypeName("#define SIF_ALL (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS)")]
    public const int SIF_ALL = (0x0001 | 0x0002 | 0x0004 | 0x0010);
    [NativeTypeName("#define MDIS_ALLCHILDSTYLES 0x0001")]
    public const int MDIS_ALLCHILDSTYLES = 0x0001;
    [NativeTypeName("#define MDITILE_VERTICAL 0x0000")]
    public const int MDITILE_VERTICAL = 0x0000;
    [NativeTypeName("#define MDITILE_HORIZONTAL 0x0001")]
    public const int MDITILE_HORIZONTAL = 0x0001;
    [NativeTypeName("#define MDITILE_SKIPDISABLED 0x0002")]
    public const int MDITILE_SKIPDISABLED = 0x0002;
    [NativeTypeName("#define MDITILE_ZORDER 0x0004")]
    public const int MDITILE_ZORDER = 0x0004;
    [NativeTypeName("#define DefFrameProc DefFrameProcW")]
    public static delegate*<HWND, HWND, uint, WPARAM, LPARAM, LRESULT> DefFrameProc => &DefFrameProcW;

    [NativeTypeName("#define DefMDIChildProc DefMDIChildProcW")]
    public static delegate*<HWND, uint, WPARAM, LPARAM, LRESULT> DefMDIChildProc => &DefMDIChildProcW;

    [NativeTypeName("#define CreateMDIWindow CreateMDIWindowW")]
    public static delegate*<ushort*, ushort*, uint, int, int, int, int, HWND, HINSTANCE, LPARAM, HWND> CreateMDIWindow => &CreateMDIWindowW;

    [NativeTypeName("#define IDH_NO_HELP 28440")]
    public const int IDH_NO_HELP = 28440;
    [NativeTypeName("#define IDH_MISSING_CONTEXT 28441")]
    public const int IDH_MISSING_CONTEXT = 28441;
    [NativeTypeName("#define IDH_GENERIC_HELP_BUTTON 28442")]
    public const int IDH_GENERIC_HELP_BUTTON = 28442;
    [NativeTypeName("#define IDH_OK 28443")]
    public const int IDH_OK = 28443;
    [NativeTypeName("#define IDH_CANCEL 28444")]
    public const int IDH_CANCEL = 28444;
    [NativeTypeName("#define IDH_HELP 28445")]
    public const int IDH_HELP = 28445;
    [NativeTypeName("#define WinHelp WinHelpW")]
    public static delegate*<HWND, ushort*, uint, nuint, BOOL> WinHelp => &WinHelpW;

    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_LATENCY 8")]
    public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_LATENCY = 8;
    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_SAMPLETIME 8")]
    public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_SAMPLETIME = 8;
    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_USE_HW_TIMESTAMP 1")]
    public const int TOUCHPREDICTIONPARAMETERS_DEFAULT_USE_HW_TIMESTAMP = 1;
    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_DELTA 0.001f")]
    public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_DELTA = 0.001f;
    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MIN 0.9f")]
    public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MIN = 0.9f;
    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MAX 0.999f")]
    public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_MAX = 0.999f;
    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_LEARNING_RATE 0.001f")]
    public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_LAMBDA_LEARNING_RATE = 0.001f;
    [NativeTypeName("#define TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_EXPO_SMOOTH_ALPHA 0.99f")]
    public const float TOUCHPREDICTIONPARAMETERS_DEFAULT_RLS_EXPO_SMOOTH_ALPHA = 0.99f;
    [NativeTypeName("#define MIN_LOGICALDPIOVERRIDE -2")]
    public const int MIN_LOGICALDPIOVERRIDE = -2;
    [NativeTypeName("#define FE_FONTSMOOTHINGSTANDARD 0x0001")]
    public const int FE_FONTSMOOTHINGSTANDARD = 0x0001;
    [NativeTypeName("#define FE_FONTSMOOTHINGCLEARTYPE 0x0002")]
    public const int FE_FONTSMOOTHINGCLEARTYPE = 0x0002;
    [NativeTypeName("#define FE_FONTSMOOTHINGORIENTATIONBGR 0x0000")]
    public const int FE_FONTSMOOTHINGORIENTATIONBGR = 0x0000;
    [NativeTypeName("#define FE_FONTSMOOTHINGORIENTATIONRGB 0x0001")]
    public const int FE_FONTSMOOTHINGORIENTATIONRGB = 0x0001;
    [NativeTypeName("#define CONTACTVISUALIZATION_OFF 0x0000")]
    public const int CONTACTVISUALIZATION_OFF = 0x0000;
    [NativeTypeName("#define CONTACTVISUALIZATION_ON 0x0001")]
    public const int CONTACTVISUALIZATION_ON = 0x0001;
    [NativeTypeName("#define CONTACTVISUALIZATION_PRESENTATIONMODE 0x0002")]
    public const int CONTACTVISUALIZATION_PRESENTATIONMODE = 0x0002;
    [NativeTypeName("#define GESTUREVISUALIZATION_OFF 0x0000")]
    public const int GESTUREVISUALIZATION_OFF = 0x0000;
    [NativeTypeName("#define GESTUREVISUALIZATION_ON 0x001F")]
    public const int GESTUREVISUALIZATION_ON = 0x001F;
    [NativeTypeName("#define GESTUREVISUALIZATION_TAP 0x0001")]
    public const int GESTUREVISUALIZATION_TAP = 0x0001;
    [NativeTypeName("#define GESTUREVISUALIZATION_DOUBLETAP 0x0002")]
    public const int GESTUREVISUALIZATION_DOUBLETAP = 0x0002;
    [NativeTypeName("#define GESTUREVISUALIZATION_PRESSANDTAP 0x0004")]
    public const int GESTUREVISUALIZATION_PRESSANDTAP = 0x0004;
    [NativeTypeName("#define GESTUREVISUALIZATION_PRESSANDHOLD 0x0008")]
    public const int GESTUREVISUALIZATION_PRESSANDHOLD = 0x0008;
    [NativeTypeName("#define GESTUREVISUALIZATION_RIGHTTAP 0x0010")]
    public const int GESTUREVISUALIZATION_RIGHTTAP = 0x0010;
    [NativeTypeName("#define MOUSEWHEEL_ROUTING_FOCUS 0")]
    public const int MOUSEWHEEL_ROUTING_FOCUS = 0;
    [NativeTypeName("#define MOUSEWHEEL_ROUTING_HYBRID 1")]
    public const int MOUSEWHEEL_ROUTING_HYBRID = 1;
    [NativeTypeName("#define MOUSEWHEEL_ROUTING_MOUSE_POS 2")]
    public const int MOUSEWHEEL_ROUTING_MOUSE_POS = 2;
    [NativeTypeName("#define PENVISUALIZATION_ON 0x0023")]
    public const int PENVISUALIZATION_ON = 0x0023;
    [NativeTypeName("#define PENVISUALIZATION_OFF 0x0000")]
    public const int PENVISUALIZATION_OFF = 0x0000;
    [NativeTypeName("#define PENVISUALIZATION_TAP 0x0001")]
    public const int PENVISUALIZATION_TAP = 0x0001;
    [NativeTypeName("#define PENVISUALIZATION_DOUBLETAP 0x0002")]
    public const int PENVISUALIZATION_DOUBLETAP = 0x0002;
    [NativeTypeName("#define PENVISUALIZATION_CURSOR 0x0020")]
    public const int PENVISUALIZATION_CURSOR = 0x0020;
    [NativeTypeName("#define PENARBITRATIONTYPE_NONE 0x0000")]
    public const int PENARBITRATIONTYPE_NONE = 0x0000;
    [NativeTypeName("#define PENARBITRATIONTYPE_WIN8 0x0001")]
    public const int PENARBITRATIONTYPE_WIN8 = 0x0001;
    [NativeTypeName("#define PENARBITRATIONTYPE_FIS 0x0002")]
    public const int PENARBITRATIONTYPE_FIS = 0x0002;
    [NativeTypeName("#define PENARBITRATIONTYPE_SPT 0x0003")]
    public const int PENARBITRATIONTYPE_SPT = 0x0003;
    [NativeTypeName("#define PENARBITRATIONTYPE_MAX 0x0004")]
    public const int PENARBITRATIONTYPE_MAX = 0x0004;
    [NativeTypeName("#define SPIF_UPDATEINIFILE 0x0001")]
    public const int SPIF_UPDATEINIFILE = 0x0001;
    [NativeTypeName("#define SPIF_SENDWININICHANGE 0x0002")]
    public const int SPIF_SENDWININICHANGE = 0x0002;
    [NativeTypeName("#define SPIF_SENDCHANGE SPIF_SENDWININICHANGE")]
    public const int SPIF_SENDCHANGE = 0x0002;
    [NativeTypeName("#define METRICS_USEDEFAULT -1")]
    public const int METRICS_USEDEFAULT = -1;
    [NativeTypeName("#define SERKF_SERIALKEYSON 0x00000001")]
    public const int SERKF_SERIALKEYSON = 0x00000001;
    [NativeTypeName("#define SERKF_AVAILABLE 0x00000002")]
    public const int SERKF_AVAILABLE = 0x00000002;
    [NativeTypeName("#define SERKF_INDICATOR 0x00000004")]
    public const int SERKF_INDICATOR = 0x00000004;
    [NativeTypeName("#define ChangeDisplaySettings ChangeDisplaySettingsW")]
    public static delegate*<DEVMODEW*, uint, int> ChangeDisplaySettings => &ChangeDisplaySettingsW;

    [NativeTypeName("#define ChangeDisplaySettingsEx ChangeDisplaySettingsExW")]
    public static delegate*<ushort*, DEVMODEW*, HWND, uint, void*, int> ChangeDisplaySettingsEx => &ChangeDisplaySettingsExW;

    [NativeTypeName("#define EnumDisplaySettings EnumDisplaySettingsW")]
    public static delegate*<ushort*, uint, DEVMODEW*, BOOL> EnumDisplaySettings => &EnumDisplaySettingsW;

    [NativeTypeName("#define EnumDisplaySettingsEx EnumDisplaySettingsExW")]
    public static delegate*<ushort*, uint, DEVMODEW*, uint, BOOL> EnumDisplaySettingsEx => &EnumDisplaySettingsExW;

    [NativeTypeName("#define EDS_RAWMODE 0x00000002")]
    public const int EDS_RAWMODE = 0x00000002;
    [NativeTypeName("#define EDS_ROTATEDMODE 0x00000004")]
    public const int EDS_ROTATEDMODE = 0x00000004;
    [NativeTypeName("#define EnumDisplayDevices EnumDisplayDevicesW")]
    public static delegate*<ushort*, uint, DISPLAY_DEVICEW*, uint, BOOL> EnumDisplayDevices => &EnumDisplayDevicesW;

    [NativeTypeName("#define EDD_GET_DEVICE_INTERFACE_NAME 0x00000001")]
    public const int EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001;
    [NativeTypeName("#define SystemParametersInfo SystemParametersInfoW")]
    public static delegate*<uint, uint, void*, uint, BOOL> SystemParametersInfo => &SystemParametersInfoW;

    [NativeTypeName("#define FKF_FILTERKEYSON 0x00000001")]
    public const int FKF_FILTERKEYSON = 0x00000001;
    [NativeTypeName("#define FKF_AVAILABLE 0x00000002")]
    public const int FKF_AVAILABLE = 0x00000002;
    [NativeTypeName("#define FKF_HOTKEYACTIVE 0x00000004")]
    public const int FKF_HOTKEYACTIVE = 0x00000004;
    [NativeTypeName("#define FKF_CONFIRMHOTKEY 0x00000008")]
    public const int FKF_CONFIRMHOTKEY = 0x00000008;
    [NativeTypeName("#define FKF_HOTKEYSOUND 0x00000010")]
    public const int FKF_HOTKEYSOUND = 0x00000010;
    [NativeTypeName("#define FKF_INDICATOR 0x00000020")]
    public const int FKF_INDICATOR = 0x00000020;
    [NativeTypeName("#define FKF_CLICKON 0x00000040")]
    public const int FKF_CLICKON = 0x00000040;
    [NativeTypeName("#define ATF_TIMEOUTON 0x00000001")]
    public const int ATF_TIMEOUTON = 0x00000001;
    [NativeTypeName("#define ATF_ONOFFFEEDBACK 0x00000002")]
    public const int ATF_ONOFFFEEDBACK = 0x00000002;
    [NativeTypeName("#define SSGF_NONE 0")]
    public const int SSGF_NONE = 0;
    [NativeTypeName("#define SSGF_DISPLAY 3")]
    public const int SSGF_DISPLAY = 3;
    [NativeTypeName("#define SSTF_NONE 0")]
    public const int SSTF_NONE = 0;
    [NativeTypeName("#define SSTF_CHARS 1")]
    public const int SSTF_CHARS = 1;
    [NativeTypeName("#define SSTF_BORDER 2")]
    public const int SSTF_BORDER = 2;
    [NativeTypeName("#define SSTF_DISPLAY 3")]
    public const int SSTF_DISPLAY = 3;
    [NativeTypeName("#define SSWF_NONE 0")]
    public const int SSWF_NONE = 0;
    [NativeTypeName("#define SSWF_TITLE 1")]
    public const int SSWF_TITLE = 1;
    [NativeTypeName("#define SSWF_WINDOW 2")]
    public const int SSWF_WINDOW = 2;
    [NativeTypeName("#define SSWF_DISPLAY 3")]
    public const int SSWF_DISPLAY = 3;
    [NativeTypeName("#define SSWF_CUSTOM 4")]
    public const int SSWF_CUSTOM = 4;
    [NativeTypeName("#define TKF_TOGGLEKEYSON 0x00000001")]
    public const int TKF_TOGGLEKEYSON = 0x00000001;
    [NativeTypeName("#define TKF_AVAILABLE 0x00000002")]
    public const int TKF_AVAILABLE = 0x00000002;
    [NativeTypeName("#define TKF_HOTKEYACTIVE 0x00000004")]
    public const int TKF_HOTKEYACTIVE = 0x00000004;
    [NativeTypeName("#define TKF_CONFIRMHOTKEY 0x00000008")]
    public const int TKF_CONFIRMHOTKEY = 0x00000008;
    [NativeTypeName("#define TKF_HOTKEYSOUND 0x00000010")]
    public const int TKF_HOTKEYSOUND = 0x00000010;
    [NativeTypeName("#define TKF_INDICATOR 0x00000020")]
    public const int TKF_INDICATOR = 0x00000020;
    [NativeTypeName("#define SLE_ERROR 0x00000001")]
    public const int SLE_ERROR = 0x00000001;
    [NativeTypeName("#define SLE_MINORERROR 0x00000002")]
    public const int SLE_MINORERROR = 0x00000002;
    [NativeTypeName("#define SLE_WARNING 0x00000003")]
    public const int SLE_WARNING = 0x00000003;
    [NativeTypeName("#define MONITORINFOF_PRIMARY 0x00000001")]
    public const int MONITORINFOF_PRIMARY = 0x00000001;
    [NativeTypeName("#define GetMonitorInfo GetMonitorInfoW")]
    public static delegate*<HMONITOR, MONITORINFO*, BOOL> GetMonitorInfo => &GetMonitorInfoW;

    [NativeTypeName("#define WINEVENT_OUTOFCONTEXT 0x0000")]
    public const int WINEVENT_OUTOFCONTEXT = 0x0000;
    [NativeTypeName("#define WINEVENT_SKIPOWNTHREAD 0x0001")]
    public const int WINEVENT_SKIPOWNTHREAD = 0x0001;
    [NativeTypeName("#define WINEVENT_SKIPOWNPROCESS 0x0002")]
    public const int WINEVENT_SKIPOWNPROCESS = 0x0002;
    [NativeTypeName("#define WINEVENT_INCONTEXT 0x0004")]
    public const int WINEVENT_INCONTEXT = 0x0004;
    [NativeTypeName("#define CHILDID_SELF 0")]
    public const int CHILDID_SELF = 0;
    [NativeTypeName("#define INDEXID_OBJECT 0")]
    public const int INDEXID_OBJECT = 0;
    [NativeTypeName("#define INDEXID_CONTAINER 0")]
    public const int INDEXID_CONTAINER = 0;
    [NativeTypeName("#define CSOUND_SYSTEM 16")]
    public const int CSOUND_SYSTEM = 16;
    [NativeTypeName("#define ALERT_SYSTEM_INFORMATIONAL 1")]
    public const int ALERT_SYSTEM_INFORMATIONAL = 1;
    [NativeTypeName("#define ALERT_SYSTEM_WARNING 2")]
    public const int ALERT_SYSTEM_WARNING = 2;
    [NativeTypeName("#define ALERT_SYSTEM_ERROR 3")]
    public const int ALERT_SYSTEM_ERROR = 3;
    [NativeTypeName("#define ALERT_SYSTEM_QUERY 4")]
    public const int ALERT_SYSTEM_QUERY = 4;
    [NativeTypeName("#define ALERT_SYSTEM_CRITICAL 5")]
    public const int ALERT_SYSTEM_CRITICAL = 5;
    [NativeTypeName("#define CALERT_SYSTEM 6")]
    public const int CALERT_SYSTEM = 6;
    [NativeTypeName("#define GUI_CARETBLINKING 0x00000001")]
    public const int GUI_CARETBLINKING = 0x00000001;
    [NativeTypeName("#define GUI_INMOVESIZE 0x00000002")]
    public const int GUI_INMOVESIZE = 0x00000002;
    [NativeTypeName("#define GUI_INMENUMODE 0x00000004")]
    public const int GUI_INMENUMODE = 0x00000004;
    [NativeTypeName("#define GUI_SYSTEMMENUMODE 0x00000008")]
    public const int GUI_SYSTEMMENUMODE = 0x00000008;
    [NativeTypeName("#define GUI_POPUPMENUMODE 0x00000010")]
    public const int GUI_POPUPMENUMODE = 0x00000010;
    [NativeTypeName("#define USER_DEFAULT_SCREEN_DPI 96")]
    public const int USER_DEFAULT_SCREEN_DPI = 96;
    [NativeTypeName("#define GetWindowModuleFileName GetWindowModuleFileNameW")]
    public static delegate*<HWND, ushort*, uint, uint> GetWindowModuleFileName => &GetWindowModuleFileNameW;

    [NativeTypeName("#define CCHILDREN_TITLEBAR 5")]
    public const int CCHILDREN_TITLEBAR = 5;
    [NativeTypeName("#define CCHILDREN_SCROLLBAR 5")]
    public const int CCHILDREN_SCROLLBAR = 5;
    [NativeTypeName("#define CURSOR_SHOWING 0x00000001")]
    public const int CURSOR_SHOWING = 0x00000001;
    [NativeTypeName("#define CURSOR_SUPPRESSED 0x00000002")]
    public const int CURSOR_SUPPRESSED = 0x00000002;
    [NativeTypeName("#define RealGetWindowClass RealGetWindowClassW")]
    public static delegate*<HWND, ushort*, uint, uint> RealGetWindowClass => &RealGetWindowClassW;

    [NativeTypeName("#define GetAltTabInfo GetAltTabInfoW")]
    public static delegate*<HWND, int, ALTTABINFO*, ushort*, uint, BOOL> GetAltTabInfo => &GetAltTabInfoW;

    [NativeTypeName("#define RIM_INPUT 0")]
    public const int RIM_INPUT = 0;
    [NativeTypeName("#define RIM_INPUTSINK 1")]
    public const int RIM_INPUTSINK = 1;
    [NativeTypeName("#define RIM_TYPEMOUSE 0")]
    public const int RIM_TYPEMOUSE = 0;
    [NativeTypeName("#define RIM_TYPEKEYBOARD 1")]
    public const int RIM_TYPEKEYBOARD = 1;
    [NativeTypeName("#define RIM_TYPEHID 2")]
    public const int RIM_TYPEHID = 2;
    [NativeTypeName("#define RIM_TYPEMAX 2")]
    public const int RIM_TYPEMAX = 2;
    [NativeTypeName("#define MOUSE_MOVE_RELATIVE 0")]
    public const int MOUSE_MOVE_RELATIVE = 0;
    [NativeTypeName("#define MOUSE_MOVE_ABSOLUTE 1")]
    public const int MOUSE_MOVE_ABSOLUTE = 1;
    [NativeTypeName("#define MOUSE_VIRTUAL_DESKTOP 0x02")]
    public const int MOUSE_VIRTUAL_DESKTOP = 0x02;
    [NativeTypeName("#define MOUSE_ATTRIBUTES_CHANGED 0x04")]
    public const int MOUSE_ATTRIBUTES_CHANGED = 0x04;
    [NativeTypeName("#define MOUSE_MOVE_NOCOALESCE 0x08")]
    public const int MOUSE_MOVE_NOCOALESCE = 0x08;
    [NativeTypeName("#define KEYBOARD_OVERRUN_MAKE_CODE 0xFF")]
    public const int KEYBOARD_OVERRUN_MAKE_CODE = 0xFF;
    [NativeTypeName("#define RID_INPUT 0x10000003")]
    public const int RID_INPUT = 0x10000003;
    [NativeTypeName("#define RID_HEADER 0x10000005")]
    public const int RID_HEADER = 0x10000005;
    [NativeTypeName("#define RIDI_PREPARSEDDATA 0x20000005")]
    public const int RIDI_PREPARSEDDATA = 0x20000005;
    [NativeTypeName("#define RIDI_DEVICENAME 0x20000007")]
    public const int RIDI_DEVICENAME = 0x20000007;
    [NativeTypeName("#define RIDI_DEVICEINFO 0x2000000b")]
    public const int RIDI_DEVICEINFO = 0x2000000b;
    [NativeTypeName("#define GetRawInputDeviceInfo GetRawInputDeviceInfoW")]
    public static delegate*<HANDLE, uint, void*, uint*, uint> GetRawInputDeviceInfo => &GetRawInputDeviceInfoW;

    [NativeTypeName("#define GIDC_ARRIVAL 1")]
    public const int GIDC_ARRIVAL = 1;
    [NativeTypeName("#define GIDC_REMOVAL 2")]
    public const int GIDC_REMOVAL = 2;
    [NativeTypeName("#define MSGFLT_ADD 1")]
    public const int MSGFLT_ADD = 1;
    [NativeTypeName("#define MSGFLT_REMOVE 2")]
    public const int MSGFLT_REMOVE = 2;
    [NativeTypeName("#define MSGFLTINFO_NONE (0)")]
    public const int MSGFLTINFO_NONE = (0);
    [NativeTypeName("#define MSGFLTINFO_ALREADYALLOWED_FORWND (1)")]
    public const int MSGFLTINFO_ALREADYALLOWED_FORWND = (1);
    [NativeTypeName("#define MSGFLTINFO_ALREADYDISALLOWED_FORWND (2)")]
    public const int MSGFLTINFO_ALREADYDISALLOWED_FORWND = (2);
    [NativeTypeName("#define MSGFLTINFO_ALLOWED_HIGHER (3)")]
    public const int MSGFLTINFO_ALLOWED_HIGHER = (3);
    [NativeTypeName("#define MSGFLT_RESET (0)")]
    public const int MSGFLT_RESET = (0);
    [NativeTypeName("#define MSGFLT_ALLOW (1)")]
    public const int MSGFLT_ALLOW = (1);
    [NativeTypeName("#define MSGFLT_DISALLOW (2)")]
    public const int MSGFLT_DISALLOW = (2);
    [NativeTypeName("#define GF_BEGIN 0x00000001")]
    public const int GF_BEGIN = 0x00000001;
    [NativeTypeName("#define GF_INERTIA 0x00000002")]
    public const int GF_INERTIA = 0x00000002;
    [NativeTypeName("#define GF_END 0x00000004")]
    public const int GF_END = 0x00000004;
    [NativeTypeName("#define GC_ALLGESTURES 0x00000001")]
    public const int GC_ALLGESTURES = 0x00000001;
    [NativeTypeName("#define GC_ZOOM 0x00000001")]
    public const int GC_ZOOM = 0x00000001;
    [NativeTypeName("#define GC_PAN 0x00000001")]
    public const int GC_PAN = 0x00000001;
    [NativeTypeName("#define GC_PAN_WITH_SINGLE_FINGER_VERTICALLY 0x00000002")]
    public const int GC_PAN_WITH_SINGLE_FINGER_VERTICALLY = 0x00000002;
    [NativeTypeName("#define GC_PAN_WITH_SINGLE_FINGER_HORIZONTALLY 0x00000004")]
    public const int GC_PAN_WITH_SINGLE_FINGER_HORIZONTALLY = 0x00000004;
    [NativeTypeName("#define GC_PAN_WITH_GUTTER 0x00000008")]
    public const int GC_PAN_WITH_GUTTER = 0x00000008;
    [NativeTypeName("#define GC_PAN_WITH_INERTIA 0x00000010")]
    public const int GC_PAN_WITH_INERTIA = 0x00000010;
    [NativeTypeName("#define GC_ROTATE 0x00000001")]
    public const int GC_ROTATE = 0x00000001;
    [NativeTypeName("#define GC_TWOFINGERTAP 0x00000001")]
    public const int GC_TWOFINGERTAP = 0x00000001;
    [NativeTypeName("#define GC_PRESSANDTAP 0x00000001")]
    public const int GC_PRESSANDTAP = 0x00000001;
    [NativeTypeName("#define GC_ROLLOVER GC_PRESSANDTAP")]
    public const int GC_ROLLOVER = 0x00000001;
    [NativeTypeName("#define GESTURECONFIGMAXCOUNT 256")]
    public const int GESTURECONFIGMAXCOUNT = 256;
    [NativeTypeName("#define GCF_INCLUDE_ANCESTORS 0x00000001")]
    public const int GCF_INCLUDE_ANCESTORS = 0x00000001;
    [NativeTypeName("#define NID_INTEGRATED_TOUCH 0x00000001")]
    public const int NID_INTEGRATED_TOUCH = 0x00000001;
    [NativeTypeName("#define NID_EXTERNAL_TOUCH 0x00000002")]
    public const int NID_EXTERNAL_TOUCH = 0x00000002;
    [NativeTypeName("#define NID_INTEGRATED_PEN 0x00000004")]
    public const int NID_INTEGRATED_PEN = 0x00000004;
    [NativeTypeName("#define NID_EXTERNAL_PEN 0x00000008")]
    public const int NID_EXTERNAL_PEN = 0x00000008;
    [NativeTypeName("#define NID_MULTI_INPUT 0x00000040")]
    public const int NID_MULTI_INPUT = 0x00000040;
    [NativeTypeName("#define NID_READY 0x00000080")]
    public const int NID_READY = 0x00000080;
}