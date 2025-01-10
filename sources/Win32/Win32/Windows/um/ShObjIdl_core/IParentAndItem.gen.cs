// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B3A4B685-B685-4805-99D9-5DEAD2873236")]
[NativeTypeName("struct IParentAndItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IParentAndItem : IParentAndItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IParentAndItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IParentAndItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IParentAndItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IParentAndItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetParentAndItem(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent,
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild
    )
    {
        return (
            (delegate* unmanaged<IParentAndItem, ITEMIDLIST*, IShellFolder, ITEMIDLIST*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pidlParent, psf, pidlChild);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetParentAndItem(
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlParent,
        IShellFolder* ppsf,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlChild
    )
    {
        return (
            (delegate* unmanaged<IParentAndItem, ITEMIDLIST**, IShellFolder*, ITEMIDLIST**, int>)(
                (*lpVtbl)[4]
            )
        )(this, ppidlParent, ppsf, ppidlChild);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetParentAndItem(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent,
            IShellFolder psf,
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild
        );

        [VtblIndex(4)]
        HRESULT GetParentAndItem(
            [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlParent,
            IShellFolder* ppsf,
            [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlChild
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
            "HRESULT (LPCITEMIDLIST, IShellFolder *, LPCITEMIDLIST) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITEMIDLIST*,
            IShellFolder,
            ITEMIDLIST*,
            int> SetParentAndItem;

        [NativeTypeName(
            "HRESULT (LPITEMIDLIST *, IShellFolder **, LPITEMIDLIST *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITEMIDLIST**,
            IShellFolder*,
            ITEMIDLIST**,
            int> GetParentAndItem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IParentAndItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IParentAndItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IParentAndItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IParentAndItem(Silk.NET.Windows.IUnknown value)
    {
        return new IParentAndItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IParentAndItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IParentAndItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IParentAndItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
