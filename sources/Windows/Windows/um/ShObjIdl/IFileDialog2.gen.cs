// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFileDialog2.xml' path='doc/member[@name="IFileDialog2"]/*'/>
[Guid("61744FC7-85B5-4791-A9B0-272276309B13")]
[NativeTypeName("struct IFileDialog2 : IFileDialog")]
[NativeInheritance("IFileDialog")]
public unsafe partial struct IFileDialog2 : IFileDialog2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileDialog2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileDialog2*, Guid*, void**, int> )(lpVtbl[0]))((IFileDialog2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileDialog2*, uint> )(lpVtbl[1]))((IFileDialog2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileDialog2*, uint> )(lpVtbl[2]))((IFileDialog2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IModalWindow.Show"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Show(HWND hwndOwner)
    {
        return ((delegate* unmanaged<IFileDialog2*, HWND, int> )(lpVtbl[3]))((IFileDialog2*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    /// <inheritdoc cref = "IFileDialog.SetFileTypes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFileTypes(uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec)
    {
        return ((delegate* unmanaged<IFileDialog2*, uint, COMDLG_FILTERSPEC*, int> )(lpVtbl[4]))((IFileDialog2*)Unsafe.AsPointer(ref this), cFileTypes, rgFilterSpec);
    }

    /// <inheritdoc cref = "IFileDialog.SetFileTypeIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFileTypeIndex(uint iFileType)
    {
        return ((delegate* unmanaged<IFileDialog2*, uint, int> )(lpVtbl[5]))((IFileDialog2*)Unsafe.AsPointer(ref this), iFileType);
    }

    /// <inheritdoc cref = "IFileDialog.GetFileTypeIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFileTypeIndex(uint* piFileType)
    {
        return ((delegate* unmanaged<IFileDialog2*, uint*, int> )(lpVtbl[6]))((IFileDialog2*)Unsafe.AsPointer(ref this), piFileType);
    }

    /// <inheritdoc cref = "IFileDialog.Advise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IFileDialog2*, IFileDialogEvents*, uint*, int> )(lpVtbl[7]))((IFileDialog2*)Unsafe.AsPointer(ref this), pfde, pdwCookie);
    }

    /// <inheritdoc cref = "IFileDialog.Unadvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IFileDialog2*, uint, int> )(lpVtbl[8]))((IFileDialog2*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <inheritdoc cref = "IFileDialog.SetOptions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
    {
        return ((delegate* unmanaged<IFileDialog2*, uint, int> )(lpVtbl[9]))((IFileDialog2*)Unsafe.AsPointer(ref this), fos);
    }

    /// <inheritdoc cref = "IFileDialog.GetOptions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
    {
        return ((delegate* unmanaged<IFileDialog2*, uint*, int> )(lpVtbl[10]))((IFileDialog2*)Unsafe.AsPointer(ref this), pfos);
    }

    /// <inheritdoc cref = "IFileDialog.SetDefaultFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDefaultFolder(IShellItem* psi)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItem*, int> )(lpVtbl[11]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi);
    }

    /// <inheritdoc cref = "IFileDialog.SetFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetFolder(IShellItem* psi)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItem*, int> )(lpVtbl[12]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi);
    }

    /// <inheritdoc cref = "IFileDialog.GetFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFolder(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItem**, int> )(lpVtbl[13]))((IFileDialog2*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <inheritdoc cref = "IFileDialog.GetCurrentSelection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentSelection(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItem**, int> )(lpVtbl[14]))((IFileDialog2*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <inheritdoc cref = "IFileDialog.SetFileName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IFileDialog2*, ushort*, int> )(lpVtbl[15]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <inheritdoc cref = "IFileDialog.GetFileName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName)
    {
        return ((delegate* unmanaged<IFileDialog2*, ushort**, int> )(lpVtbl[16]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <inheritdoc cref = "IFileDialog.SetTitle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
    {
        return ((delegate* unmanaged<IFileDialog2*, ushort*, int> )(lpVtbl[17]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszTitle);
    }

    /// <inheritdoc cref = "IFileDialog.SetOkButtonLabel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText)
    {
        return ((delegate* unmanaged<IFileDialog2*, ushort*, int> )(lpVtbl[18]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszText);
    }

    /// <inheritdoc cref = "IFileDialog.SetFileNameLabel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialog2*, ushort*, int> )(lpVtbl[19]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszLabel);
    }

    /// <inheritdoc cref = "IFileDialog.GetResult"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetResult(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItem**, int> )(lpVtbl[20]))((IFileDialog2*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <inheritdoc cref = "IFileDialog.AddPlace"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddPlace(IShellItem* psi, FDAP fdap)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItem*, FDAP, int> )(lpVtbl[21]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi, fdap);
    }

    /// <inheritdoc cref = "IFileDialog.SetDefaultExtension"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension)
    {
        return ((delegate* unmanaged<IFileDialog2*, ushort*, int> )(lpVtbl[22]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszDefaultExtension);
    }

    /// <inheritdoc cref = "IFileDialog.Close"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Close(HRESULT hr)
    {
        return ((delegate* unmanaged<IFileDialog2*, HRESULT, int> )(lpVtbl[23]))((IFileDialog2*)Unsafe.AsPointer(ref this), hr);
    }

    /// <inheritdoc cref = "IFileDialog.SetClientGuid"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged<IFileDialog2*, Guid*, int> )(lpVtbl[24]))((IFileDialog2*)Unsafe.AsPointer(ref this), guid);
    }

    /// <inheritdoc cref = "IFileDialog.ClearClientData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ClearClientData()
    {
        return ((delegate* unmanaged<IFileDialog2*, int> )(lpVtbl[25]))((IFileDialog2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IFileDialog.SetFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetFilter(IShellItemFilter* pFilter)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItemFilter*, int> )(lpVtbl[26]))((IFileDialog2*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='IFileDialog2.xml' path='doc/member[@name="IFileDialog2.SetCancelButtonLabel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetCancelButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileDialog2*, ushort*, int> )(lpVtbl[27]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszLabel);
    }

    /// <include file='IFileDialog2.xml' path='doc/member[@name="IFileDialog2.SetNavigationRoot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetNavigationRoot(IShellItem* psi)
    {
        return ((delegate* unmanaged<IFileDialog2*, IShellItem*, int> )(lpVtbl[28]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi);
    }

    public interface Interface : IFileDialog.Interface
    {
        [VtblIndex(27)]
        HRESULT SetCancelButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel);
        [VtblIndex(28)]
        HRESULT SetNavigationRoot(IShellItem* psi);
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
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetCancelButtonLabel;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> SetNavigationRoot;
    }
}