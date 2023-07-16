// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog"]/*'/>
[Guid("42F85136-DB7E-439C-85F1-E4075D135FC8")]
[NativeTypeName("struct IFileDialog : IModalWindow")]
[NativeInheritance("IModalWindow")]
public unsafe partial struct IFileDialog : IFileDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileDialog));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileDialog*, Guid*, void**, int> )(lpVtbl[0]))((IFileDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileDialog*, uint> )(lpVtbl[1]))((IFileDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileDialog*, uint> )(lpVtbl[2]))((IFileDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IModalWindow.Show"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Show(HWND hwndOwner)
    {
        return ((delegate* unmanaged<IFileDialog*, HWND, int> )(lpVtbl[3]))((IFileDialog*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetFileTypes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFileTypes(uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec)
    {
        return ((delegate* unmanaged<IFileDialog*, uint, COMDLG_FILTERSPEC*, int> )(lpVtbl[4]))((IFileDialog*)Unsafe.AsPointer(ref this), cFileTypes, rgFilterSpec);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetFileTypeIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFileTypeIndex(uint iFileType)
    {
        return ((delegate* unmanaged<IFileDialog*, uint, int> )(lpVtbl[5]))((IFileDialog*)Unsafe.AsPointer(ref this), iFileType);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.GetFileTypeIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFileTypeIndex(uint* piFileType)
    {
        return ((delegate* unmanaged<IFileDialog*, uint*, int> )(lpVtbl[6]))((IFileDialog*)Unsafe.AsPointer(ref this), piFileType);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.Advise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IFileDialog*, IFileDialogEvents*, uint*, int> )(lpVtbl[7]))((IFileDialog*)Unsafe.AsPointer(ref this), pfde, pdwCookie);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.Unadvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IFileDialog*, uint, int> )(lpVtbl[8]))((IFileDialog*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
    {
        return ((delegate* unmanaged<IFileDialog*, uint, int> )(lpVtbl[9]))((IFileDialog*)Unsafe.AsPointer(ref this), fos);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.GetOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
    {
        return ((delegate* unmanaged<IFileDialog*, uint*, int> )(lpVtbl[10]))((IFileDialog*)Unsafe.AsPointer(ref this), pfos);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetDefaultFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDefaultFolder(IShellItem* psi)
    {
        return ((delegate* unmanaged<IFileDialog*, IShellItem*, int> )(lpVtbl[11]))((IFileDialog*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetFolder(IShellItem* psi)
    {
        return ((delegate* unmanaged<IFileDialog*, IShellItem*, int> )(lpVtbl[12]))((IFileDialog*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.GetFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFolder(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IFileDialog*, IShellItem**, int> )(lpVtbl[13]))((IFileDialog*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.GetCurrentSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentSelection(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IFileDialog*, IShellItem**, int> )(lpVtbl[14]))((IFileDialog*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IFileDialog*, ushort*, int> )(lpVtbl[15]))((IFileDialog*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.GetFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName)
    {
        return ((delegate* unmanaged<IFileDialog*, ushort**, int> )(lpVtbl[16]))((IFileDialog*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetTitle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
    {
        return ((delegate* unmanaged<IFileDialog*, ushort*, int> )(lpVtbl[17]))((IFileDialog*)Unsafe.AsPointer(ref this), pszTitle);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetOkButtonLabel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText)
    {
        return ((delegate* unmanaged<IFileDialog*, ushort*, int> )(lpVtbl[18]))((IFileDialog*)Unsafe.AsPointer(ref this), pszText);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetFileNameLabel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialog*, ushort*, int> )(lpVtbl[19]))((IFileDialog*)Unsafe.AsPointer(ref this), pszLabel);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.GetResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetResult(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IFileDialog*, IShellItem**, int> )(lpVtbl[20]))((IFileDialog*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.AddPlace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddPlace(IShellItem* psi, FDAP fdap)
    {
        return ((delegate* unmanaged<IFileDialog*, IShellItem*, FDAP, int> )(lpVtbl[21]))((IFileDialog*)Unsafe.AsPointer(ref this), psi, fdap);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetDefaultExtension"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension)
    {
        return ((delegate* unmanaged<IFileDialog*, ushort*, int> )(lpVtbl[22]))((IFileDialog*)Unsafe.AsPointer(ref this), pszDefaultExtension);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Close(HRESULT hr)
    {
        return ((delegate* unmanaged<IFileDialog*, HRESULT, int> )(lpVtbl[23]))((IFileDialog*)Unsafe.AsPointer(ref this), hr);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetClientGuid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged<IFileDialog*, Guid*, int> )(lpVtbl[24]))((IFileDialog*)Unsafe.AsPointer(ref this), guid);
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.ClearClientData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ClearClientData()
    {
        return ((delegate* unmanaged<IFileDialog*, int> )(lpVtbl[25]))((IFileDialog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileDialog.xml' path='doc/member[@name="IFileDialog.SetFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetFilter(IShellItemFilter* pFilter)
    {
        return ((delegate* unmanaged<IFileDialog*, IShellItemFilter*, int> )(lpVtbl[26]))((IFileDialog*)Unsafe.AsPointer(ref this), pFilter);
    }

    public interface Interface : IModalWindow.Interface
    {
        [VtblIndex(4)]
        HRESULT SetFileTypes(uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec);
        [VtblIndex(5)]
        HRESULT SetFileTypeIndex(uint iFileType);
        [VtblIndex(6)]
        HRESULT GetFileTypeIndex(uint* piFileType);
        [VtblIndex(7)]
        HRESULT Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(8)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);
        [VtblIndex(9)]
        HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos);
        [VtblIndex(10)]
        HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos);
        [VtblIndex(11)]
        HRESULT SetDefaultFolder(IShellItem* psi);
        [VtblIndex(12)]
        HRESULT SetFolder(IShellItem* psi);
        [VtblIndex(13)]
        HRESULT GetFolder(IShellItem** ppsi);
        [VtblIndex(14)]
        HRESULT GetCurrentSelection(IShellItem** ppsi);
        [VtblIndex(15)]
        HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName);
        [VtblIndex(16)]
        HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName);
        [VtblIndex(17)]
        HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle);
        [VtblIndex(18)]
        HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText);
        [VtblIndex(19)]
        HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel);
        [VtblIndex(20)]
        HRESULT GetResult(IShellItem** ppsi);
        [VtblIndex(21)]
        HRESULT AddPlace(IShellItem* psi, FDAP fdap);
        [VtblIndex(22)]
        HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension);
        [VtblIndex(23)]
        HRESULT Close(HRESULT hr);
        [VtblIndex(24)]
        HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid);
        [VtblIndex(25)]
        HRESULT ClearClientData();
        [VtblIndex(26)]
        HRESULT SetFilter(IShellItemFilter* pFilter);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Show;
        [NativeTypeName("HRESULT (UINT, const COMDLG_FILTERSPEC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, COMDLG_FILTERSPEC*, int> SetFileTypes;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetFileTypeIndex;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFileTypeIndex;
        [NativeTypeName("HRESULT (IFileDialogEvents *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialogEvents*, uint*, int> Advise;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;
        [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOptions;
        [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOptions;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> SetDefaultFolder;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> SetFolder;
        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem**, int> GetFolder;
        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem**, int> GetCurrentSelection;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetFileName;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetFileName;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetTitle;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetOkButtonLabel;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetFileNameLabel;
        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem**, int> GetResult;
        [NativeTypeName("HRESULT (IShellItem *, FDAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, FDAP, int> AddPlace;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDefaultExtension;
        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> Close;
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetClientGuid;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearClientData;
        [NativeTypeName("HRESULT (IShellItemFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemFilter*, int> SetFilter;
    }
}