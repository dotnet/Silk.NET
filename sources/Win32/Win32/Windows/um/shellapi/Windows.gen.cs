// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPWSTR *")]
    public static extern ushort** CommandLineToArgvW(
        [NativeTypeName("LPCWSTR")] ushort* lpCmdLine,
        int* pNumArgs
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint DragQueryFileA(
        HDROP hDrop,
        uint iFile,
        [NativeTypeName("LPSTR")] sbyte* lpszFile,
        uint cch
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint DragQueryFileW(
        HDROP hDrop,
        uint iFile,
        [NativeTypeName("LPWSTR")] ushort* lpszFile,
        uint cch
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DragQueryPoint(HDROP hDrop, POINT* ppt);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void DragFinish(HDROP hDrop);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void DragAcceptFiles(HWND hWnd, BOOL fAccept);

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINSTANCE ShellExecuteA(
        HWND hwnd,
        [NativeTypeName("LPCSTR")] sbyte* lpOperation,
        [NativeTypeName("LPCSTR")] sbyte* lpFile,
        [NativeTypeName("LPCSTR")] sbyte* lpParameters,
        [NativeTypeName("LPCSTR")] sbyte* lpDirectory,
        int nShowCmd
    );

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINSTANCE ShellExecuteW(
        HWND hwnd,
        [NativeTypeName("LPCWSTR")] ushort* lpOperation,
        [NativeTypeName("LPCWSTR")] ushort* lpFile,
        [NativeTypeName("LPCWSTR")] ushort* lpParameters,
        [NativeTypeName("LPCWSTR")] ushort* lpDirectory,
        int nShowCmd
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HINSTANCE FindExecutableA(
        [NativeTypeName("LPCSTR")] sbyte* lpFile,
        [NativeTypeName("LPCSTR")] sbyte* lpDirectory,
        [NativeTypeName("LPSTR")] sbyte* lpResult
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HINSTANCE FindExecutableW(
        [NativeTypeName("LPCWSTR")] ushort* lpFile,
        [NativeTypeName("LPCWSTR")] ushort* lpDirectory,
        [NativeTypeName("LPWSTR")] ushort* lpResult
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int ShellAboutA(
        HWND hWnd,
        [NativeTypeName("LPCSTR")] sbyte* szApp,
        [NativeTypeName("LPCSTR")] sbyte* szOtherStuff,
        HICON hIcon
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int ShellAboutW(
        HWND hWnd,
        [NativeTypeName("LPCWSTR")] ushort* szApp,
        [NativeTypeName("LPCWSTR")] ushort* szOtherStuff,
        HICON hIcon
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON DuplicateIcon(HINSTANCE hInst, HICON hIcon);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconA(
        HINSTANCE hInst,
        [NativeTypeName("LPSTR")] sbyte* pszIconPath,
        [NativeTypeName("WORD *")] ushort* piIcon
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconW(
        HINSTANCE hInst,
        [NativeTypeName("LPWSTR")] ushort* pszIconPath,
        [NativeTypeName("WORD *")] ushort* piIcon
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconExA(
        HINSTANCE hInst,
        [NativeTypeName("LPSTR")] sbyte* pszIconPath,
        [NativeTypeName("WORD *")] ushort* piIconIndex,
        [NativeTypeName("WORD *")] ushort* piIconId
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconExW(
        HINSTANCE hInst,
        [NativeTypeName("LPWSTR")] ushort* pszIconPath,
        [NativeTypeName("WORD *")] ushort* piIconIndex,
        [NativeTypeName("WORD *")] ushort* piIconId
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractIconA(
        HINSTANCE hInst,
        [NativeTypeName("LPCSTR")] sbyte* pszExeFileName,
        uint nIconIndex
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractIconW(
        HINSTANCE hInst,
        [NativeTypeName("LPCWSTR")] ushort* pszExeFileName,
        uint nIconIndex
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("UINT_PTR")]
    public static extern nuint SHAppBarMessage(
        [NativeTypeName("DWORD")] uint dwMessage,
        [NativeTypeName("PAPPBARDATA")] APPBARDATA* pData
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DoEnvironmentSubstA(
        [NativeTypeName("LPSTR")] sbyte* pszSrc,
        uint cchSrc
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DoEnvironmentSubstW(
        [NativeTypeName("LPWSTR")] ushort* pszSrc,
        uint cchSrc
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint ExtractIconExA(
        [NativeTypeName("LPCSTR")] sbyte* lpszFile,
        int nIconIndex,
        HICON* phiconLarge,
        HICON* phiconSmall,
        uint nIcons
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint ExtractIconExW(
        [NativeTypeName("LPCWSTR")] ushort* lpszFile,
        int nIconIndex,
        HICON* phiconLarge,
        HICON* phiconSmall,
        uint nIcons
    );

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int SHFileOperationA(
        [NativeTypeName("LPSHFILEOPSTRUCTA")] SHFILEOPSTRUCTA* lpFileOp
    );

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int SHFileOperationW(
        [NativeTypeName("LPSHFILEOPSTRUCTW")] SHFILEOPSTRUCTW* lpFileOp
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHFreeNameMappings(HANDLE hNameMappings);

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShellExecuteExA(SHELLEXECUTEINFOA* pExecInfo);

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShellExecuteExW(SHELLEXECUTEINFOW* pExecInfo);

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHCreateProcessAsUserW(
        [NativeTypeName("PSHCREATEPROCESSINFOW")] SHCREATEPROCESSINFOW* pscpi
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEvaluateSystemCommandTemplate(
        [NativeTypeName("PCWSTR")] ushort* pszCmdTemplate,
        [NativeTypeName("PWSTR *")] ushort** ppszApplication,
        [NativeTypeName("PWSTR *")] ushort** ppszCommandLine,
        [NativeTypeName("PWSTR *")] ushort** ppszParameters
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT AssocCreateForClasses(
        [NativeTypeName("const ASSOCIATIONELEMENT *")] ASSOCIATIONELEMENT* rgClasses,
        [NativeTypeName("ULONG")] uint cClasses,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHQueryRecycleBinA(
        [NativeTypeName("LPCSTR")] sbyte* pszRootPath,
        [NativeTypeName("LPSHQUERYRBINFO")] SHQUERYRBINFO* pSHQueryRBInfo
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHQueryRecycleBinW(
        [NativeTypeName("LPCWSTR")] ushort* pszRootPath,
        [NativeTypeName("LPSHQUERYRBINFO")] SHQUERYRBINFO* pSHQueryRBInfo
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEmptyRecycleBinA(
        HWND hwnd,
        [NativeTypeName("LPCSTR")] sbyte* pszRootPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEmptyRecycleBinW(
        HWND hwnd,
        [NativeTypeName("LPCWSTR")] ushort* pszRootPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHQueryUserNotificationState(QUERY_USER_NOTIFICATION_STATE* pquns);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetPropertyStoreForWindow(
        HWND hwnd,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Shell_NotifyIconA(
        [NativeTypeName("DWORD")] uint dwMessage,
        [NativeTypeName("PNOTIFYICONDATAA")] NOTIFYICONDATAA* lpData
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Shell_NotifyIconW(
        [NativeTypeName("DWORD")] uint dwMessage,
        [NativeTypeName("PNOTIFYICONDATAW")] NOTIFYICONDATAW* lpData
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT Shell_NotifyIconGetRect(
        [NativeTypeName("const NOTIFYICONIDENTIFIER *")] NOTIFYICONIDENTIFIER* identifier,
        RECT* iconLocation
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD_PTR")]
    public static extern nuint SHGetFileInfoA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("DWORD")] uint dwFileAttributes,
        SHFILEINFOA* psfi,
        uint cbFileInfo,
        uint uFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD_PTR")]
    public static extern nuint SHGetFileInfoW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD")] uint dwFileAttributes,
        SHFILEINFOW* psfi,
        uint cbFileInfo,
        uint uFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetStockIconInfo(
        SHSTOCKICONID siid,
        uint uFlags,
        SHSTOCKICONINFO* psii
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetDiskFreeSpaceExA(
        [NativeTypeName("LPCSTR")] sbyte* pszDirectoryName,
        ULARGE_INTEGER* pulFreeBytesAvailableToCaller,
        ULARGE_INTEGER* pulTotalNumberOfBytes,
        ULARGE_INTEGER* pulTotalNumberOfFreeBytes
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetDiskFreeSpaceExW(
        [NativeTypeName("LPCWSTR")] ushort* pszDirectoryName,
        ULARGE_INTEGER* pulFreeBytesAvailableToCaller,
        ULARGE_INTEGER* pulTotalNumberOfBytes,
        ULARGE_INTEGER* pulTotalNumberOfFreeBytes
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetNewLinkInfoA(
        [NativeTypeName("LPCSTR")] sbyte* pszLinkTo,
        [NativeTypeName("LPCSTR")] sbyte* pszDir,
        [NativeTypeName("LPSTR")] sbyte* pszName,
        BOOL* pfMustCopy,
        uint uFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetNewLinkInfoW(
        [NativeTypeName("LPCWSTR")] ushort* pszLinkTo,
        [NativeTypeName("LPCWSTR")] ushort* pszDir,
        [NativeTypeName("LPWSTR")] ushort* pszName,
        BOOL* pfMustCopy,
        uint uFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHInvokePrinterCommandA(
        HWND hwnd,
        uint uAction,
        [NativeTypeName("LPCSTR")] sbyte* lpBuf1,
        [NativeTypeName("LPCSTR")] sbyte* lpBuf2,
        BOOL fModal
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHInvokePrinterCommandW(
        HWND hwnd,
        uint uAction,
        [NativeTypeName("LPCWSTR")] ushort* lpBuf1,
        [NativeTypeName("LPCWSTR")] ushort* lpBuf2,
        BOOL fModal
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHLoadNonloadedIconOverlayIdentifiers();

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHIsFileAvailableOffline(
        [NativeTypeName("PCWSTR")] ushort* pwszPath,
        [NativeTypeName("DWORD *")] uint* pdwStatus
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetLocalizedName(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("PCWSTR")] ushort* pszResModule,
        int idsRes
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHRemoveLocalizedName([NativeTypeName("PCWSTR")] ushort* pszPath);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetLocalizedName(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("PWSTR")] ushort* pszResModule,
        uint cch,
        int* pidsRes
    );

    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int ShellMessageBoxA(
        HINSTANCE hAppInst,
        HWND hWnd,
        [NativeTypeName("LPCSTR")] sbyte* lpcText,
        [NativeTypeName("LPCSTR")] sbyte* lpcTitle,
        uint fuStyle,
        __arglist
    );

    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int ShellMessageBoxW(
        HINSTANCE hAppInst,
        HWND hWnd,
        [NativeTypeName("LPCWSTR")] ushort* lpcText,
        [NativeTypeName("LPCWSTR")] ushort* lpcTitle,
        uint fuStyle,
        __arglist
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL IsLFNDriveA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL IsLFNDriveW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEnumerateUnreadMailAccountsW(
        HKEY hKeyUser,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* pszMailAddress,
        int cchMailAddress
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetUnreadMailCountW(
        HKEY hKeyUser,
        [NativeTypeName("LPCWSTR")] ushort* pszMailAddress,
        [NativeTypeName("DWORD *")] uint* pdwCount,
        FILETIME* pFileTime,
        [NativeTypeName("LPWSTR")] ushort* pszShellExecuteCommand,
        int cchShellExecuteCommand
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetUnreadMailCountW(
        [NativeTypeName("LPCWSTR")] ushort* pszMailAddress,
        [NativeTypeName("DWORD")] uint dwCount,
        [NativeTypeName("LPCWSTR")] ushort* pszShellExecuteCommand
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHTestTokenMembership(
        HANDLE hToken,
        [NativeTypeName("ULONG")] uint ulRID
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetImageList(
        int iImageList,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL InitNetworkAddressControl();

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDriveMedia(
        [NativeTypeName("PCWSTR")] ushort* pszDrive,
        [NativeTypeName("DWORD *")] uint* pdwMediaContent
    );

    [NativeTypeName("#define DragQueryFile DragQueryFileW")]
    public static delegate* <HDROP, uint, ushort*, uint, uint> DragQueryFile => &DragQueryFileW;

    [NativeTypeName("#define ShellExecute ShellExecuteW")]
    public static delegate* <
        HWND,
        ushort*,
        ushort*,
        ushort*,
        ushort*,
        int,
        HINSTANCE> ShellExecute => &ShellExecuteW;

    [NativeTypeName("#define FindExecutable FindExecutableW")]
    public static delegate* <ushort*, ushort*, ushort*, HINSTANCE> FindExecutable =>
        &FindExecutableW;

    [NativeTypeName("#define ShellAbout ShellAboutW")]
    public static delegate* <HWND, ushort*, ushort*, HICON, int> ShellAbout => &ShellAboutW;

    [NativeTypeName("#define ExtractAssociatedIcon ExtractAssociatedIconW")]
    public static delegate* <HINSTANCE, ushort*, ushort*, HICON> ExtractAssociatedIcon =>
        &ExtractAssociatedIconW;

    [NativeTypeName("#define ExtractAssociatedIconEx ExtractAssociatedIconExW")]
    public static delegate* <HINSTANCE, ushort*, ushort*, ushort*, HICON> ExtractAssociatedIconEx =>
        &ExtractAssociatedIconExW;

    [NativeTypeName("#define ExtractIcon ExtractIconW")]
    public static delegate* <HINSTANCE, ushort*, uint, HICON> ExtractIcon => &ExtractIconW;

    [NativeTypeName("#define ABN_STATECHANGE 0x0000000")]
    public const int ABN_STATECHANGE = 0x0000000;

    [NativeTypeName("#define ABN_POSCHANGED 0x0000001")]
    public const int ABN_POSCHANGED = 0x0000001;

    [NativeTypeName("#define ABN_FULLSCREENAPP 0x0000002")]
    public const int ABN_FULLSCREENAPP = 0x0000002;

    [NativeTypeName("#define ABN_WINDOWARRANGE 0x0000003")]
    public const int ABN_WINDOWARRANGE = 0x0000003;

    [NativeTypeName("#define ABS_AUTOHIDE 0x0000001")]
    public const int ABS_AUTOHIDE = 0x0000001;

    [NativeTypeName("#define ABS_ALWAYSONTOP 0x0000002")]
    public const int ABS_ALWAYSONTOP = 0x0000002;

    [NativeTypeName("#define ABE_LEFT 0")]
    public const int ABE_LEFT = 0;

    [NativeTypeName("#define ABE_TOP 1")]
    public const int ABE_TOP = 1;

    [NativeTypeName("#define ABE_RIGHT 2")]
    public const int ABE_RIGHT = 2;

    [NativeTypeName("#define ABE_BOTTOM 3")]
    public const int ABE_BOTTOM = 3;

    [NativeTypeName("#define DoEnvironmentSubst DoEnvironmentSubstW")]
    public static delegate* <ushort*, uint, uint> DoEnvironmentSubst => &DoEnvironmentSubstW;

    [NativeTypeName("#define ExtractIconEx ExtractIconExW")]
    public static delegate* <ushort*, int, HICON*, HICON*, uint, uint> ExtractIconEx =>
        &ExtractIconExW;

    [NativeTypeName("#define FO_MOVE 0x0001")]
    public const int FO_MOVE = 0x0001;

    [NativeTypeName("#define FO_COPY 0x0002")]
    public const int FO_COPY = 0x0002;

    [NativeTypeName("#define FO_DELETE 0x0003")]
    public const int FO_DELETE = 0x0003;

    [NativeTypeName("#define FO_RENAME 0x0004")]
    public const int FO_RENAME = 0x0004;

    [NativeTypeName("#define PO_DELETE 0x0013")]
    public const int PO_DELETE = 0x0013;

    [NativeTypeName("#define PO_RENAME 0x0014")]
    public const int PO_RENAME = 0x0014;

    [NativeTypeName("#define PO_PORTCHANGE 0x0020")]
    public const int PO_PORTCHANGE = 0x0020;

    [NativeTypeName("#define PO_REN_PORT 0x0034")]
    public const int PO_REN_PORT = 0x0034;

    [NativeTypeName("#define SHFileOperation SHFileOperationW")]
    public static delegate* <SHFILEOPSTRUCTW*, int> SHFileOperation => &SHFileOperationW;

    [NativeTypeName("#define ShellExecuteEx ShellExecuteExW")]
    public static delegate* <SHELLEXECUTEINFOW*, BOOL> ShellExecuteEx => &ShellExecuteExW;

    [NativeTypeName("#define SHERB_NOCONFIRMATION 0x00000001")]
    public const int SHERB_NOCONFIRMATION = 0x00000001;

    [NativeTypeName("#define SHERB_NOPROGRESSUI 0x00000002")]
    public const int SHERB_NOPROGRESSUI = 0x00000002;

    [NativeTypeName("#define SHERB_NOSOUND 0x00000004")]
    public const int SHERB_NOSOUND = 0x00000004;

    [NativeTypeName("#define SHQueryRecycleBin SHQueryRecycleBinW")]
    public static delegate* <ushort*, SHQUERYRBINFO*, HRESULT> SHQueryRecycleBin =>
        &SHQueryRecycleBinW;

    [NativeTypeName("#define SHEmptyRecycleBin SHEmptyRecycleBinW")]
    public static delegate* <HWND, ushort*, uint, HRESULT> SHEmptyRecycleBin => &SHEmptyRecycleBinW;

    [NativeTypeName("#define NIN_SELECT (WM_USER + 0)")]
    public const int NIN_SELECT = (0x0400 + 0);

    [NativeTypeName("#define NINF_KEY 0x1")]
    public const int NINF_KEY = 0x1;

    [NativeTypeName("#define NIN_KEYSELECT (NIN_SELECT | NINF_KEY)")]
    public const int NIN_KEYSELECT = ((0x0400 + 0) | 0x1);

    [NativeTypeName("#define NIN_BALLOONSHOW (WM_USER + 2)")]
    public const int NIN_BALLOONSHOW = (0x0400 + 2);

    [NativeTypeName("#define NIN_BALLOONHIDE (WM_USER + 3)")]
    public const int NIN_BALLOONHIDE = (0x0400 + 3);

    [NativeTypeName("#define NIN_BALLOONTIMEOUT (WM_USER + 4)")]
    public const int NIN_BALLOONTIMEOUT = (0x0400 + 4);

    [NativeTypeName("#define NIN_BALLOONUSERCLICK (WM_USER + 5)")]
    public const int NIN_BALLOONUSERCLICK = (0x0400 + 5);

    [NativeTypeName("#define NIN_POPUPOPEN (WM_USER + 6)")]
    public const int NIN_POPUPOPEN = (0x0400 + 6);

    [NativeTypeName("#define NIN_POPUPCLOSE (WM_USER + 7)")]
    public const int NIN_POPUPCLOSE = (0x0400 + 7);

    [NativeTypeName("#define NIM_ADD 0x00000000")]
    public const int NIM_ADD = 0x00000000;

    [NativeTypeName("#define NIM_MODIFY 0x00000001")]
    public const int NIM_MODIFY = 0x00000001;

    [NativeTypeName("#define NIM_DELETE 0x00000002")]
    public const int NIM_DELETE = 0x00000002;

    [NativeTypeName("#define NIM_SETFOCUS 0x00000003")]
    public const int NIM_SETFOCUS = 0x00000003;

    [NativeTypeName("#define NIM_SETVERSION 0x00000004")]
    public const int NIM_SETVERSION = 0x00000004;

    [NativeTypeName("#define NOTIFYICON_VERSION 3")]
    public const int NOTIFYICON_VERSION = 3;

    [NativeTypeName("#define NOTIFYICON_VERSION_4 4")]
    public const int NOTIFYICON_VERSION_4 = 4;

    [NativeTypeName("#define NIF_MESSAGE 0x00000001")]
    public const int NIF_MESSAGE = 0x00000001;

    [NativeTypeName("#define NIF_ICON 0x00000002")]
    public const int NIF_ICON = 0x00000002;

    [NativeTypeName("#define NIF_TIP 0x00000004")]
    public const int NIF_TIP = 0x00000004;

    [NativeTypeName("#define NIF_STATE 0x00000008")]
    public const int NIF_STATE = 0x00000008;

    [NativeTypeName("#define NIF_INFO 0x00000010")]
    public const int NIF_INFO = 0x00000010;

    [NativeTypeName("#define NIF_GUID 0x00000020")]
    public const int NIF_GUID = 0x00000020;

    [NativeTypeName("#define NIF_REALTIME 0x00000040")]
    public const int NIF_REALTIME = 0x00000040;

    [NativeTypeName("#define NIF_SHOWTIP 0x00000080")]
    public const int NIF_SHOWTIP = 0x00000080;

    [NativeTypeName("#define NIS_HIDDEN 0x00000001")]
    public const int NIS_HIDDEN = 0x00000001;

    [NativeTypeName("#define NIS_SHAREDICON 0x00000002")]
    public const int NIS_SHAREDICON = 0x00000002;

    [NativeTypeName("#define Shell_NotifyIcon Shell_NotifyIconW")]
    public static delegate* <uint, NOTIFYICONDATAW*, BOOL> Shell_NotifyIcon => &Shell_NotifyIconW;

    [NativeTypeName("#define SHGetFileInfo SHGetFileInfoW")]
    public static delegate* <ushort*, uint, SHFILEINFOW*, uint, uint, nuint> SHGetFileInfo =>
        &SHGetFileInfoW;

    [NativeTypeName("#define SIID_INVALID ((SHSTOCKICONID)-1)")]
    public const SHSTOCKICONID SIID_INVALID = ((SHSTOCKICONID)(-1));

    [NativeTypeName("#define SHGetDiskFreeSpace SHGetDiskFreeSpaceEx")]
    public static delegate* <
        ushort*,
        ULARGE_INTEGER*,
        ULARGE_INTEGER*,
        ULARGE_INTEGER*,
        BOOL> SHGetDiskFreeSpace => &SHGetDiskFreeSpaceExW;

    [NativeTypeName("#define SHGetDiskFreeSpaceEx SHGetDiskFreeSpaceExW")]
    public static delegate* <
        ushort*,
        ULARGE_INTEGER*,
        ULARGE_INTEGER*,
        ULARGE_INTEGER*,
        BOOL> SHGetDiskFreeSpaceEx => &SHGetDiskFreeSpaceExW;

    [NativeTypeName("#define SHGetNewLinkInfo SHGetNewLinkInfoW")]
    public static delegate* <ushort*, ushort*, ushort*, BOOL*, uint, BOOL> SHGetNewLinkInfo =>
        &SHGetNewLinkInfoW;

    [NativeTypeName("#define SHGNLI_PIDL 0x000000001")]
    public const int SHGNLI_PIDL = 0x000000001;

    [NativeTypeName("#define SHGNLI_PREFIXNAME 0x000000002")]
    public const int SHGNLI_PREFIXNAME = 0x000000002;

    [NativeTypeName("#define SHGNLI_NOUNIQUE 0x000000004")]
    public const int SHGNLI_NOUNIQUE = 0x000000004;

    [NativeTypeName("#define SHGNLI_NOLNK 0x000000008")]
    public const int SHGNLI_NOLNK = 0x000000008;

    [NativeTypeName("#define SHGNLI_NOLOCNAME 0x000000010")]
    public const int SHGNLI_NOLOCNAME = 0x000000010;

    [NativeTypeName("#define SHGNLI_USEURLEXT 0x000000020")]
    public const int SHGNLI_USEURLEXT = 0x000000020;

    [NativeTypeName("#define PRINTACTION_OPEN 0")]
    public const int PRINTACTION_OPEN = 0;

    [NativeTypeName("#define PRINTACTION_PROPERTIES 1")]
    public const int PRINTACTION_PROPERTIES = 1;

    [NativeTypeName("#define PRINTACTION_NETINSTALL 2")]
    public const int PRINTACTION_NETINSTALL = 2;

    [NativeTypeName("#define PRINTACTION_NETINSTALLLINK 3")]
    public const int PRINTACTION_NETINSTALLLINK = 3;

    [NativeTypeName("#define PRINTACTION_TESTPAGE 4")]
    public const int PRINTACTION_TESTPAGE = 4;

    [NativeTypeName("#define PRINTACTION_OPENNETPRN 5")]
    public const int PRINTACTION_OPENNETPRN = 5;

    [NativeTypeName("#define PRINTACTION_DOCUMENTDEFAULTS 6")]
    public const int PRINTACTION_DOCUMENTDEFAULTS = 6;

    [NativeTypeName("#define PRINTACTION_SERVERPROPERTIES 7")]
    public const int PRINTACTION_SERVERPROPERTIES = 7;

    [NativeTypeName("#define SHInvokePrinterCommand SHInvokePrinterCommandW")]
    public static delegate* <HWND, uint, ushort*, ushort*, BOOL, BOOL> SHInvokePrinterCommand =>
        &SHInvokePrinterCommandW;

    [NativeTypeName("#define PRINT_PROP_FORCE_NAME 0x01")]
    public const int PRINT_PROP_FORCE_NAME = 0x01;

    [NativeTypeName("#define OFFLINE_STATUS_LOCAL 0x0001")]
    public const int OFFLINE_STATUS_LOCAL = 0x0001;

    [NativeTypeName("#define OFFLINE_STATUS_REMOTE 0x0002")]
    public const int OFFLINE_STATUS_REMOTE = 0x0002;

    [NativeTypeName("#define OFFLINE_STATUS_INCOMPLETE 0x0004")]
    public const int OFFLINE_STATUS_INCOMPLETE = 0x0004;

    [NativeTypeName("#define IsLFNDrive IsLFNDriveW")]
    public static delegate* <ushort*, BOOL> IsLFNDrive => &IsLFNDriveW;

    [NativeTypeName("#define SHEnumerateUnreadMailAccounts SHEnumerateUnreadMailAccountsW")]
    public static delegate* <HKEY, uint, ushort*, int, HRESULT> SHEnumerateUnreadMailAccounts =>
        &SHEnumerateUnreadMailAccountsW;

    [NativeTypeName("#define SHGetUnreadMailCount SHGetUnreadMailCountW")]
    public static delegate* <
        HKEY,
        ushort*,
        uint*,
        FILETIME*,
        ushort*,
        int,
        HRESULT> SHGetUnreadMailCount => &SHGetUnreadMailCountW;

    [NativeTypeName("#define SHSetUnreadMailCount SHSetUnreadMailCountW")]
    public static delegate* <ushort*, uint, ushort*, HRESULT> SHSetUnreadMailCount =>
        &SHSetUnreadMailCountW;

    [NativeTypeName("#define SHIL_LARGE 0")]
    public const int SHIL_LARGE = 0;

    [NativeTypeName("#define SHIL_SMALL 1")]
    public const int SHIL_SMALL = 1;

    [NativeTypeName("#define SHIL_EXTRALARGE 2")]
    public const int SHIL_EXTRALARGE = 2;

    [NativeTypeName("#define SHIL_SYSSMALL 3")]
    public const int SHIL_SYSSMALL = 3;

    [NativeTypeName("#define SHIL_JUMBO 4")]
    public const int SHIL_JUMBO = 4;

    [NativeTypeName("#define SHIL_LAST SHIL_JUMBO")]
    public const int SHIL_LAST = 4;

    [NativeTypeName("#define NCM_GETADDRESS (WM_USER+1)")]
    public const int NCM_GETADDRESS = (0x0400 + 1);

    [NativeTypeName("#define NCM_SETALLOWTYPE (WM_USER+2)")]
    public const int NCM_SETALLOWTYPE = (0x0400 + 2);

    [NativeTypeName("#define NCM_GETALLOWTYPE (WM_USER+3)")]
    public const int NCM_GETALLOWTYPE = (0x0400 + 3);

    [NativeTypeName("#define NCM_DISPLAYERRORTIP (WM_USER+4)")]
    public const int NCM_DISPLAYERRORTIP = (0x0400 + 4);
}
