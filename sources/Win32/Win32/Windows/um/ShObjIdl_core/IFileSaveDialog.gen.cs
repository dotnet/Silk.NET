// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("84BCCD23-5FDE-4CDB-AEA4-AF64B83D78AB")]
[NativeTypeName("struct IFileSaveDialog : IFileDialog")]
[NativeInheritance("IFileDialog")]
public unsafe partial struct IFileSaveDialog : IFileSaveDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSaveDialog));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSaveDialog, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSaveDialog, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSaveDialog, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Show(HWND hwndOwner)
    {
        return ((delegate* unmanaged<IFileSaveDialog, HWND, int>)((*lpVtbl)[3]))(this, hwndOwner);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFileTypes(
        uint cFileTypes,
        [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec
    )
    {
        return (
            (delegate* unmanaged<IFileSaveDialog, uint, COMDLG_FILTERSPEC*, int>)((*lpVtbl)[4])
        )(this, cFileTypes, rgFilterSpec);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFileTypeIndex(uint iFileType)
    {
        return ((delegate* unmanaged<IFileSaveDialog, uint, int>)((*lpVtbl)[5]))(this, iFileType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFileTypeIndex(uint* piFileType)
    {
        return ((delegate* unmanaged<IFileSaveDialog, uint*, int>)((*lpVtbl)[6]))(this, piFileType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Advise(IFileDialogEvents pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return (
            (delegate* unmanaged<IFileSaveDialog, IFileDialogEvents, uint*, int>)((*lpVtbl)[7])
        )(this, pfde, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IFileSaveDialog, uint, int>)((*lpVtbl)[8]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
    {
        return ((delegate* unmanaged<IFileSaveDialog, uint, int>)((*lpVtbl)[9]))(this, fos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
    {
        return ((delegate* unmanaged<IFileSaveDialog, uint*, int>)((*lpVtbl)[10]))(this, pfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDefaultFolder(IShellItem psi)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItem, int>)((*lpVtbl)[11]))(this, psi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetFolder(IShellItem psi)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItem, int>)((*lpVtbl)[12]))(this, psi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFolder(IShellItem* ppsi)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItem*, int>)((*lpVtbl)[13]))(
            this,
            ppsi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentSelection(IShellItem* ppsi)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItem*, int>)((*lpVtbl)[14]))(
            this,
            ppsi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IFileSaveDialog, ushort*, int>)((*lpVtbl)[15]))(this, pszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName)
    {
        return ((delegate* unmanaged<IFileSaveDialog, ushort**, int>)((*lpVtbl)[16]))(
            this,
            pszName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
    {
        return ((delegate* unmanaged<IFileSaveDialog, ushort*, int>)((*lpVtbl)[17]))(
            this,
            pszTitle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText)
    {
        return ((delegate* unmanaged<IFileSaveDialog, ushort*, int>)((*lpVtbl)[18]))(this, pszText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<IFileSaveDialog, ushort*, int>)((*lpVtbl)[19]))(
            this,
            pszLabel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetResult(IShellItem* ppsi)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItem*, int>)((*lpVtbl)[20]))(
            this,
            ppsi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddPlace(IShellItem psi, FDAP fdap)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItem, FDAP, int>)((*lpVtbl)[21]))(
            this,
            psi,
            fdap
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension)
    {
        return ((delegate* unmanaged<IFileSaveDialog, ushort*, int>)((*lpVtbl)[22]))(
            this,
            pszDefaultExtension
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Close(HRESULT hr)
    {
        return ((delegate* unmanaged<IFileSaveDialog, HRESULT, int>)((*lpVtbl)[23]))(this, hr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged<IFileSaveDialog, Guid*, int>)((*lpVtbl)[24]))(this, guid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ClearClientData()
    {
        return ((delegate* unmanaged<IFileSaveDialog, int>)((*lpVtbl)[25]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetFilter(IShellItemFilter pFilter)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItemFilter, int>)((*lpVtbl)[26]))(
            this,
            pFilter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetSaveAsItem(IShellItem psi)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IShellItem, int>)((*lpVtbl)[27]))(this, psi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetProperties(IPropertyStore pStore)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IPropertyStore, int>)((*lpVtbl)[28]))(
            this,
            pStore
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetCollectedProperties(IPropertyDescriptionList pList, BOOL fAppendDefault)
    {
        return (
            (delegate* unmanaged<IFileSaveDialog, IPropertyDescriptionList, BOOL, int>)(
                (*lpVtbl)[29]
            )
        )(this, pList, fAppendDefault);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetProperties(IPropertyStore* ppStore)
    {
        return ((delegate* unmanaged<IFileSaveDialog, IPropertyStore*, int>)((*lpVtbl)[30]))(
            this,
            ppStore
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT ApplyProperties(
        IShellItem psi,
        IPropertyStore pStore,
        HWND hwnd,
        IFileOperationProgressSink pSink
    )
    {
        return (
            (delegate* unmanaged<
                IFileSaveDialog,
                IShellItem,
                IPropertyStore,
                HWND,
                IFileOperationProgressSink,
                int>)((*lpVtbl)[31])
        )(this, psi, pStore, hwnd, pSink);
    }

    public interface Interface : IFileDialog.Interface
    {
        [VtblIndex(27)]
        HRESULT SetSaveAsItem(IShellItem psi);

        [VtblIndex(28)]
        HRESULT SetProperties(IPropertyStore pStore);

        [VtblIndex(29)]
        HRESULT SetCollectedProperties(IPropertyDescriptionList pList, BOOL fAppendDefault);

        [VtblIndex(30)]
        HRESULT GetProperties(IPropertyStore* ppStore);

        [VtblIndex(31)]
        HRESULT ApplyProperties(
            IShellItem psi,
            IPropertyStore pStore,
            HWND hwnd,
            IFileOperationProgressSink pSink
        );
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
        public delegate* unmanaged<TSelf*, IFileDialogEvents, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOptions;

        [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOptions;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> SetDefaultFolder;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> SetFolder;

        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> GetFolder;

        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> GetCurrentSelection;

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
        public delegate* unmanaged<TSelf*, IShellItem*, int> GetResult;

        [NativeTypeName("HRESULT (IShellItem *, FDAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, FDAP, int> AddPlace;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDefaultExtension;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> Close;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetClientGuid;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearClientData;

        [NativeTypeName("HRESULT (IShellItemFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemFilter, int> SetFilter;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> SetSaveAsItem;

        [NativeTypeName("HRESULT (IPropertyStore *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore, int> SetProperties;

        [NativeTypeName("HRESULT (IPropertyDescriptionList *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IPropertyDescriptionList,
            BOOL,
            int> SetCollectedProperties;

        [NativeTypeName("HRESULT (IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore*, int> GetProperties;

        [NativeTypeName(
            "HRESULT (IShellItem *, IPropertyStore *, HWND, IFileOperationProgressSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IPropertyStore,
            HWND,
            IFileOperationProgressSink,
            int> ApplyProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileSaveDialog"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileSaveDialog(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFileDialog"/> to <see cref = "IFileSaveDialog"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFileDialog"/> instance to be converted </param>
    public static explicit operator IFileSaveDialog(Silk.NET.Windows.IFileDialog value)
    {
        return new IFileSaveDialog(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSaveDialog"/> to <see cref = "Silk.NET.Windows.IFileDialog"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSaveDialog"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFileDialog(IFileSaveDialog value)
    {
        return new Silk.NET.Windows.IFileDialog(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IModalWindow"/> to <see cref = "IFileSaveDialog"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IModalWindow"/> instance to be converted </param>
    public static explicit operator IFileSaveDialog(Silk.NET.Windows.IModalWindow value)
    {
        return new IFileSaveDialog(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSaveDialog"/> to <see cref = "Silk.NET.Windows.IModalWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSaveDialog"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IModalWindow(IFileSaveDialog value)
    {
        return new Silk.NET.Windows.IModalWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileSaveDialog"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileSaveDialog(Silk.NET.Windows.IUnknown value)
    {
        return new IFileSaveDialog(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSaveDialog"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSaveDialog"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileSaveDialog value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
