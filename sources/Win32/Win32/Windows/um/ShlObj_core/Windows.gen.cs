// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.ISHCUTCMDID;
using static Silk.NET.Windows.SHARD;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetMalloc(IMalloc* ppMalloc);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void* SHAlloc([NativeTypeName("SIZE_T")] nuint cb);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHFree(void* pv);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHGetIconOverlayIndexA(
        [NativeTypeName("LPCSTR")] sbyte* pszIconPath,
        int iIconIndex
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHGetIconOverlayIndexW(
        [NativeTypeName("LPCWSTR")] ushort* pszIconPath,
        int iIconIndex
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILClone([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCloneFirst(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCombine(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void ILFree([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl);

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILGetNext([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint ILGetSize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILFindChild(
        [NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlParent,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILFindLastID(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ILRemoveLastID([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ILIsEqual(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ILIsParent(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2,
        BOOL fImmediate
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT ILSaveToStream(
        IStream pstm,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl
    );

    [DllImport("windows.storage.dll", ExactSpelling = true)]
    public static extern HRESULT ILLoadFromStreamEx(
        IStream pstm,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** pidl
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCreateFromPathA([NativeTypeName("PCSTR")] sbyte* pszPath);

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCreateFromPathW([NativeTypeName("PCWSTR")] ushort* pszPath);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHILCreateFromPath(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl,
        [NativeTypeName("DWORD *")] uint* rgfInOut
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILAppendID(
        [NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPCSHITEMID")] SHITEMID* pmkid,
        BOOL fAppend
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetPathFromIDListEx(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD")] uint cchPath,
        [NativeTypeName("GPFIDL_FLAGS")] int uOpts
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetPathFromIDListA(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPSTR")] sbyte* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetPathFromIDListW(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPWSTR")] ushort* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHCreateDirectory(
        HWND hwnd,
        [NativeTypeName("PCWSTR")] ushort* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHCreateDirectoryExA(
        HWND hwnd,
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* psa
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHCreateDirectoryExW(
        HWND hwnd,
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* psa
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHOpenFolderAndSelectItems(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        uint cidl,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItem(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent,
        IShellFolder psfParent,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        IShellItem* ppsi
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetSpecialFolderLocation(
        HWND hwnd,
        int csidl,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHCloneSpecialIDList(HWND hwnd, int csidl, BOOL fCreate);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetSpecialFolderPathA(
        HWND hwnd,
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        int csidl,
        BOOL fCreate
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetSpecialFolderPathW(
        HWND hwnd,
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        int csidl,
        BOOL fCreate
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHFlushSFCache();

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathA(
        HWND hwnd,
        int csidl,
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPSTR")] sbyte* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathW(
        HWND hwnd,
        int csidl,
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderLocation(
        HWND hwnd,
        int csidl,
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetFolderPathA(
        int csidl,
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCSTR")] sbyte* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetFolderPathW(
        int csidl,
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathAndSubDirA(
        HWND hwnd,
        int csidl,
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCSTR")] sbyte* pszSubDir,
        [NativeTypeName("LPSTR")] sbyte* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathAndSubDirW(
        HWND hwnd,
        int csidl,
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pszSubDir,
        [NativeTypeName("LPWSTR")] ushort* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetKnownFolderIDList(
        [NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hToken,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetKnownFolderPath(
        [NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hToken,
        [NativeTypeName("PCWSTR")] ushort* pszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetKnownFolderPath(
        [NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hToken,
        [NativeTypeName("PWSTR *")] ushort** ppszPath
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetKnownFolderItem(
        [NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid,
        KNOWN_FOLDER_FLAG flags,
        HANDLE hToken,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetSetFolderCustomSettings(
        [NativeTypeName("LPSHFOLDERCUSTOMSETTINGS")] SHFOLDERCUSTOMSETTINGS* pfcs,
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD")] uint dwReadWrite
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHBrowseForFolderA(
        [NativeTypeName("LPBROWSEINFOA")] BROWSEINFOA* lpbi
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHBrowseForFolderW(
        [NativeTypeName("LPBROWSEINFOW")] BROWSEINFOW* lpbi
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHLoadInProc([NativeTypeName("const IID &")] Guid* rclsid);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDesktopFolder(IShellFolder* ppshf);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHChangeNotify(
        [NativeTypeName("LONG")] int wEventId,
        uint uFlags,
        [NativeTypeName("LPCVOID")] void* dwItem1,
        [NativeTypeName("LPCVOID")] void* dwItem2
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHAddToRecentDocs(uint uFlags, [NativeTypeName("LPCVOID")] void* pv);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHHandleUpdateImage(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlExtra
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHUpdateImageA(
        [NativeTypeName("LPCSTR")] sbyte* pszHashItem,
        int iIndex,
        uint uFlags,
        int iImageIndex
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHUpdateImageW(
        [NativeTypeName("LPCWSTR")] ushort* pszHashItem,
        int iIndex,
        uint uFlags,
        int iImageIndex
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint SHChangeNotifyRegister(
        HWND hwnd,
        int fSources,
        [NativeTypeName("LONG")] int fEvents,
        uint wMsg,
        int cEntries,
        [NativeTypeName("const SHChangeNotifyEntry *")] SHChangeNotifyEntry* pshcne
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHChangeNotifyDeregister([NativeTypeName("ULONG")] uint ulID);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HANDLE SHChangeNotification_Lock(
        HANDLE hChange,
        [NativeTypeName("DWORD")] uint dwProcId,
        [NativeTypeName("LPITEMIDLIST **")] ITEMIDLIST*** pppidl,
        [NativeTypeName("LONG *")] int* plEvent
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHChangeNotification_Unlock(HANDLE hLock);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetRealIDL(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlSimple,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlReal
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetInstanceExplorer(IUnknown* ppunk);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDataFromIDListA(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        int nFormat,
        void* pv,
        int cb
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDataFromIDListW(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        int nFormat,
        void* pv,
        int cb
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int RestartDialog(
        HWND hwnd,
        [NativeTypeName("PCWSTR")] ushort* pszPrompt,
        [NativeTypeName("DWORD")] uint dwReturn
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int RestartDialogEx(
        HWND hwnd,
        [NativeTypeName("PCWSTR")] ushort* pszPrompt,
        [NativeTypeName("DWORD")] uint dwReturn,
        [NativeTypeName("DWORD")] uint dwReasonCode
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCoCreateInstance(
        [NativeTypeName("PCWSTR")] ushort* pszCLSID,
        [NativeTypeName("const CLSID *")] Guid* pclsid,
        IUnknown pUnkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDataObject(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        uint cidl,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl,
        IDataObject pdtInner,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT CIDLData_CreateFromIDArray(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        uint cidl,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl,
        IDataObject* ppdtobj
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateStdEnumFmtEtc(
        uint cfmt,
        [NativeTypeName("const FORMATETC[]")] FORMATETC* afmt,
        IEnumFORMATETC* ppenumFormatEtc
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHDoDragDrop(
        HWND hwnd,
        IDataObject pdata,
        IDropSource pdsrc,
        [NativeTypeName("DWORD")] uint dwEffect,
        [NativeTypeName("DWORD *")] uint* pdwEffect
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_SetDragImage(HIMAGELIST him, POINT* pptOffset);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragEnterEx(
        HWND hwndTarget,
        [NativeTypeName("const POINT")] POINT ptStart
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragEnterEx2(
        HWND hwndTarget,
        [NativeTypeName("const POINT")] POINT ptStart,
        IDataObject pdtObject
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_ShowDragImage(BOOL fShow);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragMove(POINT pt);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragLeave();

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_AutoScroll(
        HWND hwnd,
        AUTO_SCROLL_DATA* pad,
        [NativeTypeName("const POINT *")] POINT* pptNow
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ReadCabinetState(CABINETSTATE* pcs, int cLength);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL WriteCabinetState(CABINETSTATE* pcs);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathMakeUniqueName(
        [NativeTypeName("PWSTR")] ushort* pszUniqueName,
        uint cchMax,
        [NativeTypeName("PCWSTR")] ushort* pszTemplate,
        [NativeTypeName("PCWSTR")] ushort* pszLongPlate,
        [NativeTypeName("PCWSTR")] ushort* pszDir
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathIsExe([NativeTypeName("PCWSTR")] ushort* pszPath);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PathCleanupSpec(
        [NativeTypeName("PCWSTR")] ushort* pszDir,
        [NativeTypeName("PWSTR")] ushort* pszSpec
    );

    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int PathResolve(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("PZPCWSTR")] ushort** dirs,
        uint fFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL GetFileNameFromBrowse(
        HWND hwnd,
        [NativeTypeName("PWSTR")] ushort* pszFilePath,
        uint cchFilePath,
        [NativeTypeName("PCWSTR")] ushort* pszWorkingDir,
        [NativeTypeName("PCWSTR")] ushort* pszDefExt,
        [NativeTypeName("PCWSTR")] ushort* pszFilters,
        [NativeTypeName("PCWSTR")] ushort* pszTitle
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int DriveType(int iDrive);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int RealDriveType(int iDrive, BOOL fOKToHitNet);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int IsNetDrive(int iDrive);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint Shell_MergeMenus(
        HMENU hmDst,
        HMENU hmSrc,
        uint uInsert,
        uint uIDAdjust,
        uint uIDAdjustMax,
        [NativeTypeName("ULONG")] uint uFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHObjectProperties(
        HWND hwnd,
        [NativeTypeName("DWORD")] uint shopObjectType,
        [NativeTypeName("PCWSTR")] ushort* pszObjectName,
        [NativeTypeName("PCWSTR")] ushort* pszPropertyPage
    );

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SHFormatDrive(HWND hwnd, uint drive, uint fmtID, uint options);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHDestroyPropSheetExtArray(HPSXA hpsxa);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint SHAddFromPropSheetExtArray(
        HPSXA hpsxa,
        [NativeTypeName("LPFNADDPROPSHEETPAGE")]
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> lpfnAddPage,
        LPARAM lParam
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint SHReplaceFromPropSheetExtArray(
        HPSXA hpsxa,
        uint uPageID,
        [NativeTypeName("LPFNADDPROPSHEETPAGE")]
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> lpfnReplaceWith,
        LPARAM lParam
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern IStream OpenRegStream(
        HKEY hkey,
        [NativeTypeName("PCWSTR")] ushort* pszSubkey,
        [NativeTypeName("PCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD")] uint grfMode
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHFindFiles(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlSaveFile
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void PathGetShortPath([NativeTypeName("PWSTR")] ushort* pszLongPath);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathYetAnotherMakeUniqueName(
        [NativeTypeName("PWSTR")] ushort* pszUniqueName,
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("PCWSTR")] ushort* pszShort,
        [NativeTypeName("PCWSTR")] ushort* pszFileSpec
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Win32DeleteFile([NativeTypeName("PCWSTR")] ushort* pszPath);

    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SHRestricted(RESTRICTIONS rest);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SignalFileOpen([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT AssocGetDetailsOfPropKey(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* pkey,
        VARIANT* pv,
        BOOL* pfFoundPropKey
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHStartNetConnectionDialogW(
        HWND hwnd,
        [NativeTypeName("LPCWSTR")] ushort* pszRemoteName,
        [NativeTypeName("DWORD")] uint dwType
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHDefExtractIconA(
        [NativeTypeName("LPCSTR")] sbyte* pszIconFile,
        int iIndex,
        uint uFlags,
        HICON* phiconLarge,
        HICON* phiconSmall,
        uint nIconSize
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHDefExtractIconW(
        [NativeTypeName("LPCWSTR")] ushort* pszIconFile,
        int iIndex,
        uint uFlags,
        HICON* phiconLarge,
        HICON* phiconSmall,
        uint nIconSize
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHOpenWithDialog(
        HWND hwndParent,
        [NativeTypeName("const OPENASINFO *")] OPENASINFO* poainfo
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Shell_GetImageLists(HIMAGELIST* phiml, HIMAGELIST* phimlSmall);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int Shell_GetCachedImageIndexA(
        [NativeTypeName("LPCSTR")] sbyte* pszIconPath,
        int iIconIndex,
        uint uIconFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int Shell_GetCachedImageIndexW(
        [NativeTypeName("LPCWSTR")] ushort* pszIconPath,
        int iIconIndex,
        uint uIconFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHValidateUNC(
        HWND hwndOwner,
        [NativeTypeName("PWSTR")] ushort* pszFile,
        uint fConnect
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HANDLE PifMgr_OpenProperties(
        [NativeTypeName("PCWSTR")] ushort* pszApp,
        [NativeTypeName("PCWSTR")] ushort* pszPIF,
        uint hInf,
        uint flOpt
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PifMgr_GetProperties(
        HANDLE hProps,
        [NativeTypeName("PCSTR")] sbyte* pszGroup,
        void* lpProps,
        int cbProps,
        uint flOpt
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PifMgr_SetProperties(
        HANDLE hProps,
        [NativeTypeName("PCSTR")] sbyte* pszGroup,
        [NativeTypeName("const void *")] void* lpProps,
        int cbProps,
        uint flOpt
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HANDLE PifMgr_CloseProperties(HANDLE hProps, uint flOpt);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHSetInstanceExplorer(IUnknown punk);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL IsUserAnAdmin();

    [DllImport("shell32", ExactSpelling = true)]
    public static extern LRESULT SHShellFolderView_Message(HWND hwndMain, uint uMsg, LPARAM lParam);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellFolderView(
        [NativeTypeName("const SFV_CREATE *")] SFV_CREATE* pcsfv,
        IShellView* ppsv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT CDefFolderMenu_Create2(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        HWND hwnd,
        uint cidl,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl,
        IShellFolder psf,
        [NativeTypeName("LPFNDFMCALLBACK")]
            delegate* unmanaged<IShellFolder, HWND, IDataObject, uint, WPARAM, LPARAM, HRESULT> pfn,
        uint nKeys,
        [NativeTypeName("const HKEY *")] HKEY* ahkeys,
        IContextMenu* ppcm
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDefaultContextMenu(
        [NativeTypeName("const DEFCONTEXTMENU *")] DEFCONTEXTMENU* pdcm,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern IContextMenu SHFind_InitMenuPopup(
        HMENU hmenu,
        HWND hwndOwner,
        uint idCmdFirst,
        uint idCmdLast
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellFolderViewEx(CSFV* pcsfv, IShellView* ppsv);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHGetSetSettings(
        [NativeTypeName("LPSHELLSTATEW")] SHELLSTATEW* lpss,
        [NativeTypeName("DWORD")] uint dwMask,
        BOOL bSet
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHGetSettings(
        SHELLFLAGSTATE* psfs,
        [NativeTypeName("DWORD")] uint dwMask
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToParent(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToFolderIDListParent(
        IShellFolder psfRoot,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToFolderIDListParentEx(
        IShellFolder psfRoot,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        IBindCtx ppbc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToObject(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        IBindCtx pbc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    public static BOOL IDListContainerIsConsistent(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        uint cbAlloc
    )
    {
        uint cbPidl = 2;
        while (
            unchecked(cbPidl <= cbAlloc && pidl->mkid.cb >= sizeof(ushort))
            && unchecked(pidl->mkid.cb <= cbAlloc - cbPidl)
        )
        {
            unchecked(cbPidl) += pidl->mkid.cb;
            pidl = ((ITEMIDLIST*)((void*)(((byte*)((pidl))) + (((pidl)->mkid.cb)))));
        }
        return (unchecked(cbPidl <= cbAlloc) && 0 == pidl->mkid.cb) ? 1 : 0;
    }

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHParseDisplayName(
        [NativeTypeName("PCWSTR")] ushort* pszName,
        IBindCtx pbc,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl,
        [NativeTypeName("SFGAOF")] uint sfgaoIn,
        [NativeTypeName("SFGAOF *")] uint* psfgaoOut
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPathPrepareForWriteA(
        HWND hwnd,
        IUnknown punkEnableModless,
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPathPrepareForWriteW(
        HWND hwnd,
        IUnknown punkEnableModless,
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPropStgCreate(
        IPropertySetStorage psstg,
        [NativeTypeName("const IID &")] Guid* fmtid,
        [NativeTypeName("const CLSID *")] Guid* pclsid,
        [NativeTypeName("DWORD")] uint grfFlags,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint dwDisposition,
        IPropertyStorage* ppstg,
        uint* puCodePage
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPropStgReadMultiple(
        IPropertyStorage pps,
        uint uCodePage,
        [NativeTypeName("ULONG")] uint cpspec,
        [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec,
        [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgvar
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPropStgWriteMultiple(
        IPropertyStorage pps,
        uint* puCodePage,
        [NativeTypeName("ULONG")] uint cpspec,
        [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec,
        [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgvar,
        [NativeTypeName("PROPID")] uint propidNameFirst
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateFileExtractIconW(
        [NativeTypeName("LPCWSTR")] ushort* pszFile,
        [NativeTypeName("DWORD")] uint dwFileAttributes,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHLimitInputEdit(HWND hwndEdit, IShellFolder psf);

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetAttributesFromDataObject(
        IDataObject pdo,
        [NativeTypeName("DWORD")] uint dwAttributeMask,
        [NativeTypeName("DWORD *")] uint* pdwAttributes,
        uint* pcItems
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHMapPIDLToSystemImageListIndex(
        IShellFolder pshf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        int* piIndexSel
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCLSIDFromString(
        [NativeTypeName("PCWSTR")] ushort* psz,
        [NativeTypeName("CLSID *")] Guid* pclsid
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PickIconDlg(
        HWND hwnd,
        [NativeTypeName("PWSTR")] ushort* pszIconPath,
        uint cchIconPath,
        int* piIconIndex
    );

    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT StgMakeUniqueName(
        IStorage pstgParent,
        [NativeTypeName("PCWSTR")] ushort* pszFileSpec,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [NativeTypeName("#define SIOM_OVERLAYINDEX 0x1")]
    public const int SIOM_OVERLAYINDEX = 0x1;

    [NativeTypeName("#define SIOM_ICONINDEX 0x2")]
    public const int SIOM_ICONINDEX = 0x2;

    [NativeTypeName("#define SIOM_RESERVED_SHARED 0")]
    public const int SIOM_RESERVED_SHARED = 0;

    [NativeTypeName("#define SIOM_RESERVED_LINK 1")]
    public const int SIOM_RESERVED_LINK = 1;

    [NativeTypeName("#define SIOM_RESERVED_SLOWFILE 2")]
    public const int SIOM_RESERVED_SLOWFILE = 2;

    [NativeTypeName("#define SIOM_RESERVED_DEFAULT 3")]
    public const int SIOM_RESERVED_DEFAULT = 3;

    [NativeTypeName("#define OI_DEFAULT 0x00000000")]
    public const int OI_DEFAULT = 0x00000000;

    [NativeTypeName("#define OI_ASYNC 0xFFFFEEEE")]
    public const uint OI_ASYNC = 0xFFFFEEEE;

    [NativeTypeName("#define IDO_SHGIOI_SHARE 0x0FFFFFFF")]
    public const int IDO_SHGIOI_SHARE = 0x0FFFFFFF;

    [NativeTypeName("#define IDO_SHGIOI_LINK 0x0FFFFFFE")]
    public const int IDO_SHGIOI_LINK = 0x0FFFFFFE;

    [NativeTypeName("#define IDO_SHGIOI_SLOWFILE 0x0FFFFFFFD")]
    public const uint IDO_SHGIOI_SLOWFILE = 0x0FFFFFFFD;

    [NativeTypeName("#define IDO_SHGIOI_DEFAULT 0x0FFFFFFFC")]
    public const uint IDO_SHGIOI_DEFAULT = 0x0FFFFFFFC;

    [NativeTypeName("#define SHGetIconOverlayIndex SHGetIconOverlayIndexW")]
    public static delegate* <ushort*, int, int> SHGetIconOverlayIndex => &SHGetIconOverlayIndexW;

    [NativeTypeName("#define NT_CONSOLE_PROPS_SIG 0xA0000002")]
    public const uint NT_CONSOLE_PROPS_SIG = 0xA0000002;

    [NativeTypeName("#define NT_FE_CONSOLE_PROPS_SIG 0xA0000004")]
    public const uint NT_FE_CONSOLE_PROPS_SIG = 0xA0000004;

    [NativeTypeName("#define EXP_DARWIN_ID_SIG 0xA0000006")]
    public const uint EXP_DARWIN_ID_SIG = 0xA0000006;

    [NativeTypeName("#define EXP_SPECIAL_FOLDER_SIG 0xA0000005")]
    public const uint EXP_SPECIAL_FOLDER_SIG = 0xA0000005;

    [NativeTypeName("#define EXP_SZ_LINK_SIG 0xA0000001")]
    public const uint EXP_SZ_LINK_SIG = 0xA0000001;

    [NativeTypeName("#define EXP_SZ_ICON_SIG 0xA0000007")]
    public const uint EXP_SZ_ICON_SIG = 0xA0000007;

    [NativeTypeName("#define EXP_PROPERTYSTORAGE_SIG 0xA0000009")]
    public const uint EXP_PROPERTYSTORAGE_SIG = 0xA0000009;

    [NativeTypeName("#define ILCreateFromPath ILCreateFromPathW")]
    public static delegate* <ushort*, ITEMIDLIST*> ILCreateFromPath => &ILCreateFromPathW;

    [NativeTypeName("#define ILCloneFull ILClone")]
    public static delegate* <ITEMIDLIST*, ITEMIDLIST*> ILCloneFull => &ILClone;

    [NativeTypeName("#define ILCloneChild ILCloneFirst")]
    public static delegate* <ITEMIDLIST*, ITEMIDLIST*> ILCloneChild => &ILCloneFirst;

    [NativeTypeName("#define SHGetPathFromIDList SHGetPathFromIDListW")]
    public static delegate* <ITEMIDLIST*, ushort*, BOOL> SHGetPathFromIDList =>
        &SHGetPathFromIDListW;

    [NativeTypeName("#define SHCreateDirectoryEx SHCreateDirectoryExW")]
    public static delegate* <HWND, ushort*, SECURITY_ATTRIBUTES*, int> SHCreateDirectoryEx =>
        &SHCreateDirectoryExW;

    [NativeTypeName("#define OFASI_EDIT 0x0001")]
    public const int OFASI_EDIT = 0x0001;

    [NativeTypeName("#define OFASI_OPENDESKTOP 0x0002")]
    public const int OFASI_OPENDESKTOP = 0x0002;

    [NativeTypeName("#define SHGetSpecialFolderPath SHGetSpecialFolderPathW")]
    public static delegate* <HWND, ushort*, int, BOOL, BOOL> SHGetSpecialFolderPath =>
        &SHGetSpecialFolderPathW;

    [NativeTypeName("#define SHGetFolderPath SHGetFolderPathW")]
    public static delegate* <HWND, int, HANDLE, uint, ushort*, HRESULT> SHGetFolderPath =>
        &SHGetFolderPathW;

    [NativeTypeName("#define SHSetFolderPath SHSetFolderPathW")]
    public static delegate* <int, HANDLE, uint, ushort*, HRESULT> SHSetFolderPath =>
        &SHSetFolderPathW;

    [NativeTypeName("#define SHGetFolderPathAndSubDir SHGetFolderPathAndSubDirW")]
    public static delegate* <
        HWND,
        int,
        HANDLE,
        uint,
        ushort*,
        ushort*,
        HRESULT> SHGetFolderPathAndSubDir => &SHGetFolderPathAndSubDirW;

    [NativeTypeName("#define FCS_READ 0x00000001")]
    public const int FCS_READ = 0x00000001;

    [NativeTypeName("#define FCS_FORCEWRITE 0x00000002")]
    public const int FCS_FORCEWRITE = 0x00000002;

    [NativeTypeName("#define FCS_WRITE (FCS_READ | FCS_FORCEWRITE)")]
    public const int FCS_WRITE = (0x00000001 | 0x00000002);

    [NativeTypeName("#define FCS_FLAG_DRAGDROP 2")]
    public const int FCS_FLAG_DRAGDROP = 2;

    [NativeTypeName("#define FCSM_VIEWID 0x00000001")]
    public const int FCSM_VIEWID = 0x00000001;

    [NativeTypeName("#define FCSM_WEBVIEWTEMPLATE 0x00000002")]
    public const int FCSM_WEBVIEWTEMPLATE = 0x00000002;

    [NativeTypeName("#define FCSM_INFOTIP 0x00000004")]
    public const int FCSM_INFOTIP = 0x00000004;

    [NativeTypeName("#define FCSM_CLSID 0x00000008")]
    public const int FCSM_CLSID = 0x00000008;

    [NativeTypeName("#define FCSM_ICONFILE 0x00000010")]
    public const int FCSM_ICONFILE = 0x00000010;

    [NativeTypeName("#define FCSM_LOGO 0x00000020")]
    public const int FCSM_LOGO = 0x00000020;

    [NativeTypeName("#define FCSM_FLAGS 0x00000040")]
    public const int FCSM_FLAGS = 0x00000040;

    [NativeTypeName("#define SHBrowseForFolder SHBrowseForFolderW")]
    public static delegate* <BROWSEINFOW*, ITEMIDLIST*> SHBrowseForFolder => &SHBrowseForFolderW;

    [NativeTypeName("#define CMDID_INTSHORTCUTCREATE ISHCUTCMDID_INTSHORTCUTCREATE")]
    public const int CMDID_INTSHORTCUTCREATE = ISHCUTCMDID_INTSHORTCUTCREATE;

    [NativeTypeName("#define PROGDLG_NORMAL 0x00000000")]
    public const int PROGDLG_NORMAL = 0x00000000;

    [NativeTypeName("#define PROGDLG_MODAL 0x00000001")]
    public const int PROGDLG_MODAL = 0x00000001;

    [NativeTypeName("#define PROGDLG_AUTOTIME 0x00000002")]
    public const int PROGDLG_AUTOTIME = 0x00000002;

    [NativeTypeName("#define PROGDLG_NOTIME 0x00000004")]
    public const int PROGDLG_NOTIME = 0x00000004;

    [NativeTypeName("#define PROGDLG_NOMINIMIZE 0x00000008")]
    public const int PROGDLG_NOMINIMIZE = 0x00000008;

    [NativeTypeName("#define PROGDLG_NOPROGRESSBAR 0x00000010")]
    public const int PROGDLG_NOPROGRESSBAR = 0x00000010;

    [NativeTypeName("#define PROGDLG_MARQUEEPROGRESS 0x00000020")]
    public const int PROGDLG_MARQUEEPROGRESS = 0x00000020;

    [NativeTypeName("#define PROGDLG_NOCANCEL 0x00000040")]
    public const int PROGDLG_NOCANCEL = 0x00000040;

    [NativeTypeName("#define PDTIMER_RESET 0x00000001")]
    public const int PDTIMER_RESET = 0x00000001;

    [NativeTypeName("#define PDTIMER_PAUSE 0x00000002")]
    public const int PDTIMER_PAUSE = 0x00000002;

    [NativeTypeName("#define PDTIMER_RESUME 0x00000003")]
    public const int PDTIMER_RESUME = 0x00000003;

    [NativeTypeName("#define DVASPECT_SHORTNAME 2")]
    public const int DVASPECT_SHORTNAME = 2;

    [NativeTypeName("#define DVASPECT_COPY 3")]
    public const int DVASPECT_COPY = 3;

    [NativeTypeName("#define DVASPECT_LINK 4")]
    public const int DVASPECT_LINK = 4;

    [NativeTypeName("#define SHCNRF_InterruptLevel 0x0001")]
    public const int SHCNRF_InterruptLevel = 0x0001;

    [NativeTypeName("#define SHCNRF_ShellLevel 0x0002")]
    public const int SHCNRF_ShellLevel = 0x0002;

    [NativeTypeName("#define SHCNRF_RecursiveInterrupt 0x1000")]
    public const int SHCNRF_RecursiveInterrupt = 0x1000;

    [NativeTypeName("#define SHCNRF_NewDelivery 0x8000")]
    public const int SHCNRF_NewDelivery = 0x8000;

    [NativeTypeName("#define SHCNEE_ORDERCHANGED 2L")]
    public const int SHCNEE_ORDERCHANGED = 2;

    [NativeTypeName("#define SHCNEE_MSI_CHANGE 4L")]
    public const int SHCNEE_MSI_CHANGE = 4;

    [NativeTypeName("#define SHCNEE_MSI_UNINSTALL 5L")]
    public const int SHCNEE_MSI_UNINSTALL = 5;

    [NativeTypeName("#define QITIPF_DEFAULT 0x00000000")]
    public const int QITIPF_DEFAULT = 0x00000000;

    [NativeTypeName("#define QITIPF_USENAME 0x00000001")]
    public const int QITIPF_USENAME = 0x00000001;

    [NativeTypeName("#define QITIPF_LINKNOTARGET 0x00000002")]
    public const int QITIPF_LINKNOTARGET = 0x00000002;

    [NativeTypeName("#define QITIPF_LINKUSETARGET 0x00000004")]
    public const int QITIPF_LINKUSETARGET = 0x00000004;

    [NativeTypeName("#define QITIPF_USESLOWTIP 0x00000008")]
    public const int QITIPF_USESLOWTIP = 0x00000008;

    [NativeTypeName("#define QITIPF_SINGLELINE 0x00000010")]
    public const int QITIPF_SINGLELINE = 0x00000010;

    [NativeTypeName("#define QIF_CACHED 0x00000001")]
    public const int QIF_CACHED = 0x00000001;

    [NativeTypeName("#define QIF_DONTEXPANDFOLDER 0x00000002")]
    public const int QIF_DONTEXPANDFOLDER = 0x00000002;

    [NativeTypeName("#define SHARD_PATH SHARD_PATHW")]
    public const SHARD SHARD_PATH = SHARD_PATHW;

    [NativeTypeName("#define SHUpdateImage SHUpdateImageW")]
    public static delegate* <ushort*, int, uint, int, void> SHUpdateImage => &SHUpdateImageW;

    [NativeTypeName("#define SHGDFIL_FINDDATA 1")]
    public const int SHGDFIL_FINDDATA = 1;

    [NativeTypeName("#define SHGDFIL_NETRESOURCE 2")]
    public const int SHGDFIL_NETRESOURCE = 2;

    [NativeTypeName("#define SHGDFIL_DESCRIPTIONID 3")]
    public const int SHGDFIL_DESCRIPTIONID = 3;

    [NativeTypeName("#define SHGetDataFromIDList SHGetDataFromIDListW")]
    public static delegate* <
        IShellFolder,
        ITEMIDLIST*,
        int,
        void*,
        int,
        HRESULT> SHGetDataFromIDList => &SHGetDataFromIDListW;

    [NativeTypeName("#define NUM_POINTS 3")]
    public const int NUM_POINTS = 3;

    [NativeTypeName("#define CABINETSTATE_VERSION 2")]
    public const int CABINETSTATE_VERSION = 2;

    [NativeTypeName("#define PCS_FATAL 0x80000000")]
    public const uint PCS_FATAL = 0x80000000;

    [NativeTypeName("#define PCS_REPLACEDCHAR 0x00000001")]
    public const int PCS_REPLACEDCHAR = 0x00000001;

    [NativeTypeName("#define PCS_REMOVEDCHAR 0x00000002")]
    public const int PCS_REMOVEDCHAR = 0x00000002;

    [NativeTypeName("#define PCS_TRUNCATED 0x00000004")]
    public const int PCS_TRUNCATED = 0x00000004;

    [NativeTypeName("#define PCS_PATHTOOLONG 0x00000008")]
    public const int PCS_PATHTOOLONG = 0x00000008;

    [NativeTypeName("#define SHOP_PRINTERNAME 0x00000001")]
    public const int SHOP_PRINTERNAME = 0x00000001;

    [NativeTypeName("#define SHOP_FILEPATH 0x00000002")]
    public const int SHOP_FILEPATH = 0x00000002;

    [NativeTypeName("#define SHOP_VOLUMEGUID 0x00000004")]
    public const int SHOP_VOLUMEGUID = 0x00000004;

    [NativeTypeName("#define SHFMT_ID_DEFAULT 0xFFFF")]
    public const int SHFMT_ID_DEFAULT = 0xFFFF;

    [NativeTypeName("#define SHFMT_OPT_FULL 0x0001")]
    public const int SHFMT_OPT_FULL = 0x0001;

    [NativeTypeName("#define SHFMT_OPT_SYSONLY 0x0002")]
    public const int SHFMT_OPT_SYSONLY = 0x0002;

    [NativeTypeName("#define SHFMT_ERROR 0xFFFFFFFFL")]
    public const uint SHFMT_ERROR = 0xFFFFFFFF;

    [NativeTypeName("#define SHFMT_CANCEL 0xFFFFFFFEL")]
    public const uint SHFMT_CANCEL = 0xFFFFFFFE;

    [NativeTypeName("#define SHFMT_NOFORMAT 0xFFFFFFFDL")]
    public const uint SHFMT_NOFORMAT = 0xFFFFFFFD;

    [NativeTypeName("#define SHStartNetConnectionDialog SHStartNetConnectionDialogW")]
    public static delegate* <HWND, ushort*, uint, HRESULT> SHStartNetConnectionDialog =>
        &SHStartNetConnectionDialogW;

    [NativeTypeName("#define SHDefExtractIcon SHDefExtractIconW")]
    public static delegate* <ushort*, int, uint, HICON*, HICON*, uint, HRESULT> SHDefExtractIcon =>
        &SHDefExtractIconW;

    [NativeTypeName("#define Shell_GetCachedImageIndex Shell_GetCachedImageIndexW")]
    public static delegate* <ushort*, int, uint, int> Shell_GetCachedImageIndex =>
        &Shell_GetCachedImageIndexW;

    [NativeTypeName("#define VALIDATEUNC_CONNECT 0x0001")]
    public const int VALIDATEUNC_CONNECT = 0x0001;

    [NativeTypeName("#define VALIDATEUNC_NOUI 0x0002")]
    public const int VALIDATEUNC_NOUI = 0x0002;

    [NativeTypeName("#define VALIDATEUNC_PRINT 0x0004")]
    public const int VALIDATEUNC_PRINT = 0x0004;

    [NativeTypeName("#define VALIDATEUNC_PERSIST 0x0008")]
    public const int VALIDATEUNC_PERSIST = 0x0008;

    [NativeTypeName("#define VALIDATEUNC_VALID 0x000F")]
    public const int VALIDATEUNC_VALID = 0x000F;

    [NativeTypeName("#define PIFNAMESIZE 30")]
    public const int PIFNAMESIZE = 30;

    [NativeTypeName("#define PIFSTARTLOCSIZE 63")]
    public const int PIFSTARTLOCSIZE = 63;

    [NativeTypeName("#define PIFDEFPATHSIZE 64")]
    public const int PIFDEFPATHSIZE = 64;

    [NativeTypeName("#define PIFPARAMSSIZE 64")]
    public const int PIFPARAMSSIZE = 64;

    [NativeTypeName("#define PIFSHPROGSIZE 64")]
    public const int PIFSHPROGSIZE = 64;

    [NativeTypeName("#define PIFSHDATASIZE 64")]
    public const int PIFSHDATASIZE = 64;

    [NativeTypeName("#define PIFDEFFILESIZE 80")]
    public const int PIFDEFFILESIZE = 80;

    [NativeTypeName("#define PIFMAXFILEPATH 260")]
    public const int PIFMAXFILEPATH = 260;

    [NativeTypeName("#define QCMINFO_PLACE_BEFORE 0")]
    public const int QCMINFO_PLACE_BEFORE = 0;

    [NativeTypeName("#define QCMINFO_PLACE_AFTER 1")]
    public const int QCMINFO_PLACE_AFTER = 1;

    [NativeTypeName("#define SFVSOC_INVALIDATE_ALL 0x00000001")]
    public const int SFVSOC_INVALIDATE_ALL = 0x00000001;

    [NativeTypeName("#define SFVSOC_NOSCROLL LVSICF_NOSCROLL")]
    public const int SFVSOC_NOSCROLL = 0x00000002;

    [NativeTypeName("#define SFVS_SELECT_NONE 0x0")]
    public const int SFVS_SELECT_NONE = 0x0;

    [NativeTypeName("#define SFVS_SELECT_ALLITEMS 0x1")]
    public const int SFVS_SELECT_ALLITEMS = 0x1;

    [NativeTypeName("#define SFVS_SELECT_INVERT 0x2")]
    public const int SFVS_SELECT_INVERT = 0x2;

    [NativeTypeName("#define PIDISF_RECENTLYCHANGED 0x00000001")]
    public const int PIDISF_RECENTLYCHANGED = 0x00000001;

    [NativeTypeName("#define PIDISF_CACHEDSTICKY 0x00000002")]
    public const int PIDISF_CACHEDSTICKY = 0x00000002;

    [NativeTypeName("#define PIDISF_CACHEIMAGES 0x00000010")]
    public const int PIDISF_CACHEIMAGES = 0x00000010;

    [NativeTypeName("#define PIDISF_FOLLOWALLLINKS 0x00000020")]
    public const int PIDISF_FOLLOWALLLINKS = 0x00000020;

    [NativeTypeName("#define PIDISM_GLOBAL 0")]
    public const int PIDISM_GLOBAL = 0;

    [NativeTypeName("#define PIDISM_WATCH 1")]
    public const int PIDISM_WATCH = 1;

    [NativeTypeName("#define PIDISM_DONTWATCH 2")]
    public const int PIDISM_DONTWATCH = 2;

    [NativeTypeName("#define PIDISR_UP_TO_DATE 0")]
    public const int PIDISR_UP_TO_DATE = 0;

    [NativeTypeName("#define PIDISR_NEEDS_ADD 1")]
    public const int PIDISR_NEEDS_ADD = 1;

    [NativeTypeName("#define PIDISR_NEEDS_UPDATE 2")]
    public const int PIDISR_NEEDS_UPDATE = 2;

    [NativeTypeName("#define PIDISR_NEEDS_DELETE 3")]
    public const int PIDISR_NEEDS_DELETE = 3;

    [NativeTypeName("#define SHELLSTATEVERSION_IE4 9")]
    public const int SHELLSTATEVERSION_IE4 = 9;

    [NativeTypeName("#define SHELLSTATEVERSION_WIN2K 10")]
    public const int SHELLSTATEVERSION_WIN2K = 10;

    [NativeTypeName("#define SHELLSTATE_SIZE_WIN2K sizeof(SHELLSTATE)")]
    public const uint SHELLSTATE_SIZE_WIN2K = 32;

    [NativeTypeName("#define SHPPFW_NONE 0x00000000")]
    public const int SHPPFW_NONE = 0x00000000;

    [NativeTypeName("#define SHPPFW_DEFAULT SHPPFW_DIRCREATE")]
    public const int SHPPFW_DEFAULT = 0x00000001;

    [NativeTypeName("#define SHPPFW_DIRCREATE 0x00000001")]
    public const int SHPPFW_DIRCREATE = 0x00000001;

    [NativeTypeName("#define SHPPFW_ASKDIRCREATE 0x00000002")]
    public const int SHPPFW_ASKDIRCREATE = 0x00000002;

    [NativeTypeName("#define SHPPFW_IGNOREFILENAME 0x00000004")]
    public const int SHPPFW_IGNOREFILENAME = 0x00000004;

    [NativeTypeName("#define SHPPFW_NOWRITECHECK 0x00000008")]
    public const int SHPPFW_NOWRITECHECK = 0x00000008;

    [NativeTypeName("#define SHPPFW_MEDIACHECKONLY 0x00000010")]
    public const int SHPPFW_MEDIACHECKONLY = 0x00000010;

    [NativeTypeName("#define SHPathPrepareForWrite SHPathPrepareForWriteW")]
    public static delegate* <HWND, IUnknown, ushort*, uint, HRESULT> SHPathPrepareForWrite =>
        &SHPathPrepareForWriteW;

    [NativeTypeName("#define SHCreateFileExtractIcon SHCreateFileExtractIconW")]
    public static delegate* <ushort*, uint, Guid*, void**, HRESULT> SHCreateFileExtractIcon =>
        &SHCreateFileExtractIconW;
}
