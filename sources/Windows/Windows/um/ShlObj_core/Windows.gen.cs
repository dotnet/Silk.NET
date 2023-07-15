// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.SHARD;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetMalloc"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetMalloc(IMalloc** ppMalloc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAlloc"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void* SHAlloc([NativeTypeName("SIZE_T")] nuint cb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFree"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHFree(void* pv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetIconOverlayIndexA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHGetIconOverlayIndexA([NativeTypeName("LPCSTR")] sbyte* pszIconPath, int iIconIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetIconOverlayIndexW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHGetIconOverlayIndexW([NativeTypeName("LPCWSTR")] ushort* pszIconPath, int iIconIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILClone"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILClone([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILCloneFirst"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCloneFirst([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILCombine"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCombine([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILFree"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void ILFree([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILGetNext"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILGetNext([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILGetSize"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint ILGetSize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILFindChild"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILFindChild([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILFindLastID"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILFindLastID([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILRemoveLastID"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ILRemoveLastID([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILIsEqual"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ILIsEqual([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILIsParent"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ILIsParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2, BOOL fImmediate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILSaveToStream"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT ILSaveToStream(IStream* pstm, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILLoadFromStreamEx"]/*'/>
    [DllImport("windows.storage.dll", ExactSpelling = true)]
    public static extern HRESULT ILLoadFromStreamEx(IStream* pstm, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILCreateFromPathA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCreateFromPathA([NativeTypeName("PCSTR")] sbyte* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILCreateFromPathW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILCreateFromPathW([NativeTypeName("PCWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHILCreateFromPath"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHILCreateFromPath([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("DWORD *")] uint* rgfInOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILAppendID"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* ILAppendID([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCSHITEMID")] SHITEMID* pmkid, BOOL fAppend);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPathFromIDListEx"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetPathFromIDListEx([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint cchPath, [NativeTypeName("GPFIDL_FLAGS")] int uOpts);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPathFromIDListA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetPathFromIDListA([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPSTR")] sbyte* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPathFromIDListW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetPathFromIDListW([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDirectory"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHCreateDirectory(HWND hwnd, [NativeTypeName("PCWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDirectoryExA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHCreateDirectoryExA(HWND hwnd, [NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* psa);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDirectoryExW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHCreateDirectoryExW(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* psa);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenFolderAndSelectItems"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHOpenFolderAndSelectItems([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItem"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psfParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IShellItem** ppsi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetSpecialFolderLocation"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetSpecialFolderLocation(HWND hwnd, int csidl, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCloneSpecialIDList"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHCloneSpecialIDList(HWND hwnd, int csidl, BOOL fCreate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetSpecialFolderPathA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetSpecialFolderPathA(HWND hwnd, [NativeTypeName("LPSTR")] sbyte* pszPath, int csidl, BOOL fCreate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetSpecialFolderPathW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetSpecialFolderPathW(HWND hwnd, [NativeTypeName("LPWSTR")] ushort* pszPath, int csidl, BOOL fCreate);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFlushSFCache"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHFlushSFCache();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetFolderPathA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathA(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetFolderPathW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathW(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetFolderLocation"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderLocation(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetFolderPathA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetFolderPathA(int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetFolderPathW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetFolderPathW(int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetFolderPathAndSubDirA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathAndSubDirA(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* pszSubDir, [NativeTypeName("LPSTR")] sbyte* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetFolderPathAndSubDirW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetFolderPathAndSubDirW(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszSubDir, [NativeTypeName("LPWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetKnownFolderIDList"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetKnownFolderIDList([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hToken, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetKnownFolderPath"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetKnownFolderPath([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hToken, [NativeTypeName("PCWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetKnownFolderPath"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetKnownFolderPath([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hToken, [NativeTypeName("PWSTR *")] ushort** ppszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetKnownFolderItem"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetKnownFolderItem([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, KNOWN_FOLDER_FLAG flags, HANDLE hToken, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetSetFolderCustomSettings"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetSetFolderCustomSettings([NativeTypeName("LPSHFOLDERCUSTOMSETTINGS")] SHFOLDERCUSTOMSETTINGS* pfcs, [NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint dwReadWrite);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHBrowseForFolderA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHBrowseForFolderA([NativeTypeName("LPBROWSEINFOA")] BROWSEINFOA* lpbi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHBrowseForFolderW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHBrowseForFolderW([NativeTypeName("LPBROWSEINFOW")] BROWSEINFOW* lpbi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLoadInProc"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHLoadInProc([NativeTypeName("const IID &")] Guid* rclsid);
    public const int ISHCUTCMDID_DOWNLOADICON = 0;
    public const int ISHCUTCMDID_INTSHORTCUTCREATE = 1;
    public const int ISHCUTCMDID_COMMITHISTORY = 2;
    public const int ISHCUTCMDID_SETUSERAWURL = 3;
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetDesktopFolder"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDesktopFolder(IShellFolder** ppshf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHChangeNotify"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHChangeNotify([NativeTypeName("LONG")] int wEventId, uint uFlags, [NativeTypeName("LPCVOID")] void* dwItem1, [NativeTypeName("LPCVOID")] void* dwItem2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAddToRecentDocs"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHAddToRecentDocs(uint uFlags, [NativeTypeName("LPCVOID")] void* pv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHHandleUpdateImage"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHHandleUpdateImage([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlExtra);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHUpdateImageA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHUpdateImageA([NativeTypeName("LPCSTR")] sbyte* pszHashItem, int iIndex, uint uFlags, int iImageIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHUpdateImageW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHUpdateImageW([NativeTypeName("LPCWSTR")] ushort* pszHashItem, int iIndex, uint uFlags, int iImageIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHChangeNotifyRegister"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint SHChangeNotifyRegister(HWND hwnd, int fSources, [NativeTypeName("LONG")] int fEvents, uint wMsg, int cEntries, [NativeTypeName("const SHChangeNotifyEntry *")] SHChangeNotifyEntry* pshcne);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHChangeNotifyDeregister"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHChangeNotifyDeregister([NativeTypeName("ULONG")] uint ulID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHChangeNotification_Lock"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HANDLE SHChangeNotification_Lock(HANDLE hChange, [NativeTypeName("DWORD")] uint dwProcId, [NativeTypeName("LPITEMIDLIST **")] ITEMIDLIST*** pppidl, [NativeTypeName("LONG *")] int* plEvent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHChangeNotification_Unlock"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHChangeNotification_Unlock(HANDLE hLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetRealIDL"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetRealIDL(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlSimple, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlReal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetInstanceExplorer"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetInstanceExplorer(IUnknown** ppunk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetDataFromIDListA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDataFromIDListA(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int nFormat, void* pv, int cb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetDataFromIDListW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDataFromIDListW(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int nFormat, void* pv, int cb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RestartDialog"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int RestartDialog(HWND hwnd, [NativeTypeName("PCWSTR")] ushort* pszPrompt, [NativeTypeName("DWORD")] uint dwReturn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RestartDialogEx"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int RestartDialogEx(HWND hwnd, [NativeTypeName("PCWSTR")] ushort* pszPrompt, [NativeTypeName("DWORD")] uint dwReturn, [NativeTypeName("DWORD")] uint dwReasonCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCoCreateInstance"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCoCreateInstance([NativeTypeName("PCWSTR")] ushort* pszCLSID, [NativeTypeName("const CLSID *")] Guid* pclsid, IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDataObject"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDataObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IDataObject* pdtInner, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CIDLData_CreateFromIDArray"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT CIDLData_CreateFromIDArray([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IDataObject** ppdtobj);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateStdEnumFmtEtc"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateStdEnumFmtEtc(uint cfmt, [NativeTypeName("const FORMATETC[]")] FORMATETC* afmt, IEnumFORMATETC** ppenumFormatEtc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDoDragDrop"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHDoDragDrop(HWND hwnd, IDataObject* pdata, IDropSource* pdsrc, [NativeTypeName("DWORD")] uint dwEffect, [NativeTypeName("DWORD *")] uint* pdwEffect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DAD_SetDragImage"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_SetDragImage(HIMAGELIST him, POINT* pptOffset);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DAD_DragEnterEx"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragEnterEx(HWND hwndTarget, [NativeTypeName("const POINT")] POINT ptStart);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DAD_DragEnterEx2"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragEnterEx2(HWND hwndTarget, [NativeTypeName("const POINT")] POINT ptStart, IDataObject* pdtObject);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DAD_ShowDragImage"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_ShowDragImage(BOOL fShow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DAD_DragMove"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragMove(POINT pt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DAD_DragLeave"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_DragLeave();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DAD_AutoScroll"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DAD_AutoScroll(HWND hwnd, AUTO_SCROLL_DATA* pad, [NativeTypeName("const POINT *")] POINT* pptNow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadCabinetState"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL ReadCabinetState(CABINETSTATE* pcs, int cLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteCabinetState"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL WriteCabinetState(CABINETSTATE* pcs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMakeUniqueName"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathMakeUniqueName([NativeTypeName("PWSTR")] ushort* pszUniqueName, uint cchMax, [NativeTypeName("PCWSTR")] ushort* pszTemplate, [NativeTypeName("PCWSTR")] ushort* pszLongPlate, [NativeTypeName("PCWSTR")] ushort* pszDir);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsExe"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathIsExe([NativeTypeName("PCWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCleanupSpec"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PathCleanupSpec([NativeTypeName("PCWSTR")] ushort* pszDir, [NativeTypeName("PWSTR")] ushort* pszSpec);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathResolve"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int PathResolve([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("PZPCWSTR")] ushort** dirs, uint fFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileNameFromBrowse"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL GetFileNameFromBrowse(HWND hwnd, [NativeTypeName("PWSTR")] ushort* pszFilePath, uint cchFilePath, [NativeTypeName("PCWSTR")] ushort* pszWorkingDir, [NativeTypeName("PCWSTR")] ushort* pszDefExt, [NativeTypeName("PCWSTR")] ushort* pszFilters, [NativeTypeName("PCWSTR")] ushort* pszTitle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DriveType"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int DriveType(int iDrive);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RealDriveType"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int RealDriveType(int iDrive, BOOL fOKToHitNet);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsNetDrive"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int IsNetDrive(int iDrive);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Shell_MergeMenus"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint Shell_MergeMenus(HMENU hmDst, HMENU hmSrc, uint uInsert, uint uIDAdjust, uint uIDAdjustMax, [NativeTypeName("ULONG")] uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHObjectProperties"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHObjectProperties(HWND hwnd, [NativeTypeName("DWORD")] uint shopObjectType, [NativeTypeName("PCWSTR")] ushort* pszObjectName, [NativeTypeName("PCWSTR")] ushort* pszPropertyPage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFormatDrive"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SHFormatDrive(HWND hwnd, uint drive, uint fmtID, uint options);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDestroyPropSheetExtArray"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHDestroyPropSheetExtArray(HPSXA hpsxa);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAddFromPropSheetExtArray"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint SHAddFromPropSheetExtArray(HPSXA hpsxa, [NativeTypeName("LPFNADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> lpfnAddPage, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHReplaceFromPropSheetExtArray"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint SHReplaceFromPropSheetExtArray(HPSXA hpsxa, uint uPageID, [NativeTypeName("LPFNADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> lpfnReplaceWith, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenRegStream"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern IStream* OpenRegStream(HKEY hkey, [NativeTypeName("PCWSTR")] ushort* pszSubkey, [NativeTypeName("PCWSTR")] ushort* pszValue, [NativeTypeName("DWORD")] uint grfMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFindFiles"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHFindFiles([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlSaveFile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetShortPath"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void PathGetShortPath([NativeTypeName("PWSTR")] ushort* pszLongPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathYetAnotherMakeUniqueName"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathYetAnotherMakeUniqueName([NativeTypeName("PWSTR")] ushort* pszUniqueName, [NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("PCWSTR")] ushort* pszShort, [NativeTypeName("PCWSTR")] ushort* pszFileSpec);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Win32DeleteFile"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Win32DeleteFile([NativeTypeName("PCWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRestricted"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SHRestricted(RESTRICTIONS rest);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SignalFileOpen"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SignalFileOpen([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocGetDetailsOfPropKey"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT AssocGetDetailsOfPropKey(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* pkey, VARIANT* pv, BOOL* pfFoundPropKey);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHStartNetConnectionDialogW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHStartNetConnectionDialogW(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszRemoteName, [NativeTypeName("DWORD")] uint dwType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDefExtractIconA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHDefExtractIconA([NativeTypeName("LPCSTR")] sbyte* pszIconFile, int iIndex, uint uFlags, HICON* phiconLarge, HICON* phiconSmall, uint nIconSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDefExtractIconW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHDefExtractIconW([NativeTypeName("LPCWSTR")] ushort* pszIconFile, int iIndex, uint uFlags, HICON* phiconLarge, HICON* phiconSmall, uint nIconSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenWithDialog"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHOpenWithDialog(HWND hwndParent, [NativeTypeName("const OPENASINFO *")] OPENASINFO* poainfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Shell_GetImageLists"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Shell_GetImageLists(HIMAGELIST* phiml, HIMAGELIST* phimlSmall);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Shell_GetCachedImageIndexA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int Shell_GetCachedImageIndexA([NativeTypeName("LPCSTR")] sbyte* pszIconPath, int iIconIndex, uint uIconFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Shell_GetCachedImageIndexW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int Shell_GetCachedImageIndexW([NativeTypeName("LPCWSTR")] ushort* pszIconPath, int iIconIndex, uint uIconFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHValidateUNC"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHValidateUNC(HWND hwndOwner, [NativeTypeName("PWSTR")] ushort* pszFile, uint fConnect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PifMgr_OpenProperties"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HANDLE PifMgr_OpenProperties([NativeTypeName("PCWSTR")] ushort* pszApp, [NativeTypeName("PCWSTR")] ushort* pszPIF, uint hInf, uint flOpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PifMgr_GetProperties"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PifMgr_GetProperties(HANDLE hProps, [NativeTypeName("PCSTR")] sbyte* pszGroup, void* lpProps, int cbProps, uint flOpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PifMgr_SetProperties"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PifMgr_SetProperties(HANDLE hProps, [NativeTypeName("PCSTR")] sbyte* pszGroup, [NativeTypeName("const void *")] void* lpProps, int cbProps, uint flOpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PifMgr_CloseProperties"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HANDLE PifMgr_CloseProperties(HANDLE hProps, uint flOpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetInstanceExplorer"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHSetInstanceExplorer(IUnknown* punk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsUserAnAdmin"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL IsUserAnAdmin();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHShellFolderView_Message"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern LRESULT SHShellFolderView_Message(HWND hwndMain, uint uMsg, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellFolderView"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellFolderView([NativeTypeName("const SFV_CREATE *")] SFV_CREATE* pcsfv, IShellView** ppsv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDefFolderMenu_Create2"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT CDefFolderMenu_Create2([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HWND hwnd, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IShellFolder* psf, [NativeTypeName("LPFNDFMCALLBACK")] delegate* unmanaged<IShellFolder*, HWND, IDataObject*, uint, WPARAM, LPARAM, HRESULT> pfn, uint nKeys, [NativeTypeName("const HKEY *")] HKEY* ahkeys, IContextMenu** ppcm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDefaultContextMenu"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDefaultContextMenu([NativeTypeName("const DEFCONTEXTMENU *")] DEFCONTEXTMENU* pdcm, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFind_InitMenuPopup"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern IContextMenu* SHFind_InitMenuPopup(HMENU hmenu, HWND hwndOwner, uint idCmdFirst, uint idCmdLast);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellFolderViewEx"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellFolderViewEx(CSFV* pcsfv, IShellView** ppsv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetSetSettings"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHGetSetSettings([NativeTypeName("LPSHELLSTATEW")] SHELLSTATEW* lpss, [NativeTypeName("DWORD")] uint dwMask, BOOL bSet);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetSettings"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHGetSettings(SHELLFLAGSTATE* psfs, [NativeTypeName("DWORD")] uint dwMask);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHBindToParent"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHBindToFolderIDListParent"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToFolderIDListParent(IShellFolder* psfRoot, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHBindToFolderIDListParentEx"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToFolderIDListParentEx(IShellFolder* psfRoot, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* ppbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHBindToObject"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHBindToObject(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IDListContainerIsConsistent"]/*'/>
    public static BOOL IDListContainerIsConsistent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint cbAlloc)
    {
        uint cbPidl = 2;
        while (cbPidl <= cbAlloc && pidl->mkid.cb >= sizeof(ushort) && pidl->mkid.cb <= cbAlloc - unchecked(cbPidl))
        {
            unchecked(cbPidl) += pidl->mkid.cb;
            pidl = ((ITEMIDLIST*)((void*)(((byte*)((pidl))) + (((pidl)->mkid.cb)))));
        }

        return (cbPidl <= cbAlloc && 0 == pidl->mkid.cb) ? 1 : 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHParseDisplayName"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHParseDisplayName([NativeTypeName("PCWSTR")] ushort* pszName, IBindCtx* pbc, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("SFGAOF")] uint sfgaoIn, [NativeTypeName("SFGAOF *")] uint* psfgaoOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPathPrepareForWriteA"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPathPrepareForWriteA(HWND hwnd, IUnknown* punkEnableModless, [NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPathPrepareForWriteW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPathPrepareForWriteW(HWND hwnd, IUnknown* punkEnableModless, [NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPropStgCreate"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPropStgCreate(IPropertySetStorage* psstg, [NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("const CLSID *")] Guid* pclsid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint dwDisposition, IPropertyStorage** ppstg, uint* puCodePage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPropStgReadMultiple"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPropStgReadMultiple(IPropertyStorage* pps, uint uCodePage, [NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgvar);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHPropStgWriteMultiple"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHPropStgWriteMultiple(IPropertyStorage* pps, uint* puCodePage, [NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgvar, [NativeTypeName("PROPID")] uint propidNameFirst);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateFileExtractIconW"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateFileExtractIconW([NativeTypeName("LPCWSTR")] ushort* pszFile, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLimitInputEdit"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHLimitInputEdit(HWND hwndEdit, IShellFolder* psf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetAttributesFromDataObject"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetAttributesFromDataObject(IDataObject* pdo, [NativeTypeName("DWORD")] uint dwAttributeMask, [NativeTypeName("DWORD *")] uint* pdwAttributes, uint* pcItems);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHMapPIDLToSystemImageListIndex"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int SHMapPIDLToSystemImageListIndex(IShellFolder* pshf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int* piIndexSel);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCLSIDFromString"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCLSIDFromString([NativeTypeName("PCWSTR")] ushort* psz, [NativeTypeName("CLSID *")] Guid* pclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PickIconDlg"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int PickIconDlg(HWND hwnd, [NativeTypeName("PWSTR")] ushort* pszIconPath, uint cchIconPath, int* piIconIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgMakeUniqueName"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT StgMakeUniqueName(IStorage* pstgParent, [NativeTypeName("PCWSTR")] ushort* pszFileSpec, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
    public static delegate*<ushort*, int, int> SHGetIconOverlayIndex => &SHGetIconOverlayIndexW;

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
    public static delegate*<ushort*, ITEMIDLIST*> ILCreateFromPath => &ILCreateFromPathW;

    [NativeTypeName("#define ILCloneFull ILClone")]
    public static delegate*<ITEMIDLIST*, ITEMIDLIST*> ILCloneFull => &ILClone;

    [NativeTypeName("#define ILCloneChild ILCloneFirst")]
    public static delegate*<ITEMIDLIST*, ITEMIDLIST*> ILCloneChild => &ILCloneFirst;

    [NativeTypeName("#define SHGetPathFromIDList SHGetPathFromIDListW")]
    public static delegate*<ITEMIDLIST*, ushort*, BOOL> SHGetPathFromIDList => &SHGetPathFromIDListW;

    [NativeTypeName("#define SHCreateDirectoryEx SHCreateDirectoryExW")]
    public static delegate*<HWND, ushort*, SECURITY_ATTRIBUTES*, int> SHCreateDirectoryEx => &SHCreateDirectoryExW;

    [NativeTypeName("#define OFASI_EDIT 0x0001")]
    public const int OFASI_EDIT = 0x0001;
    [NativeTypeName("#define OFASI_OPENDESKTOP 0x0002")]
    public const int OFASI_OPENDESKTOP = 0x0002;
    [NativeTypeName("#define SHGetSpecialFolderPath SHGetSpecialFolderPathW")]
    public static delegate*<HWND, ushort*, int, BOOL, BOOL> SHGetSpecialFolderPath => &SHGetSpecialFolderPathW;

    [NativeTypeName("#define SHGetFolderPath SHGetFolderPathW")]
    public static delegate*<HWND, int, HANDLE, uint, ushort*, HRESULT> SHGetFolderPath => &SHGetFolderPathW;

    [NativeTypeName("#define SHSetFolderPath SHSetFolderPathW")]
    public static delegate*<int, HANDLE, uint, ushort*, HRESULT> SHSetFolderPath => &SHSetFolderPathW;

    [NativeTypeName("#define SHGetFolderPathAndSubDir SHGetFolderPathAndSubDirW")]
    public static delegate*<HWND, int, HANDLE, uint, ushort*, ushort*, HRESULT> SHGetFolderPathAndSubDir => &SHGetFolderPathAndSubDirW;

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
    public static delegate*<BROWSEINFOW*, ITEMIDLIST*> SHBrowseForFolder => &SHBrowseForFolderW;

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
    public static delegate*<ushort*, int, uint, int, void> SHUpdateImage => &SHUpdateImageW;

    [NativeTypeName("#define SHGDFIL_FINDDATA 1")]
    public const int SHGDFIL_FINDDATA = 1;
    [NativeTypeName("#define SHGDFIL_NETRESOURCE 2")]
    public const int SHGDFIL_NETRESOURCE = 2;
    [NativeTypeName("#define SHGDFIL_DESCRIPTIONID 3")]
    public const int SHGDFIL_DESCRIPTIONID = 3;
    [NativeTypeName("#define SHGetDataFromIDList SHGetDataFromIDListW")]
    public static delegate*<IShellFolder*, ITEMIDLIST*, int, void*, int, HRESULT> SHGetDataFromIDList => &SHGetDataFromIDListW;

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
    public static delegate*<HWND, ushort*, uint, HRESULT> SHStartNetConnectionDialog => &SHStartNetConnectionDialogW;

    [NativeTypeName("#define SHDefExtractIcon SHDefExtractIconW")]
    public static delegate*<ushort*, int, uint, HICON*, HICON*, uint, HRESULT> SHDefExtractIcon => &SHDefExtractIconW;

    [NativeTypeName("#define Shell_GetCachedImageIndex Shell_GetCachedImageIndexW")]
    public static delegate*<ushort*, int, uint, int> Shell_GetCachedImageIndex => &Shell_GetCachedImageIndexW;

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
    [NativeTypeName("#define SHELLSTATE_SIZE_WIN95 FIELD_OFFSET(SHELLSTATE,lParamSort)")]
    public static int SHELLSTATE_SIZE_WIN95 => ((int)(Marshal.OffsetOf<SHELLSTATEW>("lParamSort")));

    [NativeTypeName("#define SHELLSTATE_SIZE_NT4 FIELD_OFFSET(SHELLSTATE,version)")]
    public static int SHELLSTATE_SIZE_NT4 => ((int)(Marshal.OffsetOf<SHELLSTATEW>("version")));

    [NativeTypeName("#define SHELLSTATE_SIZE_IE4 FIELD_OFFSET(SHELLSTATE,uNotUsed)")]
    public static int SHELLSTATE_SIZE_IE4 => ((int)(Marshal.OffsetOf<SHELLSTATEW>("uNotUsed")));

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
    public static delegate*<HWND, IUnknown*, ushort*, uint, HRESULT> SHPathPrepareForWrite => &SHPathPrepareForWriteW;

    [NativeTypeName("#define SHCreateFileExtractIcon SHCreateFileExtractIconW")]
    public static delegate*<ushort*, uint, Guid*, void**, HRESULT> SHCreateFileExtractIcon => &SHCreateFileExtractIconW;
}