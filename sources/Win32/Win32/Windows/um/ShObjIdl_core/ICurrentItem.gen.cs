// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("240A7174-D653-4A1D-A6D3-D4943CFBFE3D")]
[NativeTypeName("struct ICurrentItem : IRelatedItem")]
[NativeInheritance("IRelatedItem")]
public unsafe partial struct ICurrentItem : ICurrentItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICurrentItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICurrentItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICurrentItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICurrentItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<ICurrentItem, ITEMIDLIST**, int>)((*lpVtbl)[3]))(this, ppidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItem(IShellItem* ppsi)
    {
        return ((delegate* unmanaged<ICurrentItem, IShellItem*, int>)((*lpVtbl)[4]))(this, ppsi);
    }

    public interface Interface : IRelatedItem.Interface { }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetItemIDList;

        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> GetItem;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICurrentItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICurrentItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IRelatedItem"/> to <see cref = "ICurrentItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IRelatedItem"/> instance to be converted </param>
    public static explicit operator ICurrentItem(Silk.NET.Windows.IRelatedItem value)
    {
        return new ICurrentItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICurrentItem"/> to <see cref = "Silk.NET.Windows.IRelatedItem"/>.</summary>
    /// <param name = "value">The <see cref = "ICurrentItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IRelatedItem(ICurrentItem value)
    {
        return new Silk.NET.Windows.IRelatedItem(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICurrentItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICurrentItem(Silk.NET.Windows.IUnknown value)
    {
        return new ICurrentItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICurrentItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICurrentItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICurrentItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
