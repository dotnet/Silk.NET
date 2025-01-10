// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9CC22886-DC8E-11D2-B1D0-00C04F8EEB3E")]
[NativeTypeName("struct IFolderFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFolderFilter : IFolderFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFolderFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFolderFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFolderFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFolderFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShouldShow(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem
    )
    {
        return (
            (delegate* unmanaged<IFolderFilter, IShellFolder, ITEMIDLIST*, ITEMIDLIST*, int>)(
                (*lpVtbl)[3]
            )
        )(this, psf, pidlFolder, pidlItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnumFlags(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        HWND* phwnd,
        [NativeTypeName("DWORD *")] uint* pgrfFlags
    )
    {
        return (
            (delegate* unmanaged<IFolderFilter, IShellFolder, ITEMIDLIST*, HWND*, uint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, psf, pidlFolder, phwnd, pgrfFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShouldShow(
            IShellFolder psf,
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem
        );

        [VtblIndex(4)]
        HRESULT GetEnumFlags(
            IShellFolder psf,
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
            HWND* phwnd,
            [NativeTypeName("DWORD *")] uint* pgrfFlags
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

        [NativeTypeName(
            "HRESULT (IShellFolder *, LPCITEMIDLIST, LPCITEMIDLIST) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellFolder, ITEMIDLIST*, ITEMIDLIST*, int> ShouldShow;

        [NativeTypeName(
            "HRESULT (IShellFolder *, LPCITEMIDLIST, HWND *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellFolder,
            ITEMIDLIST*,
            HWND*,
            uint*,
            int> GetEnumFlags;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFolderFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFolderFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFolderFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFolderFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IFolderFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFolderFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFolderFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFolderFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
