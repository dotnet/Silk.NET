// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("36149969-0A8F-49C8-8B00-4AECB20222FB")]
[NativeTypeName("struct IPreviewItem : IRelatedItem")]
[NativeInheritance("IRelatedItem")]
public unsafe partial struct IPreviewItem : IPreviewItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPreviewItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPreviewItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPreviewItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPreviewItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IPreviewItem, ITEMIDLIST**, int>)((*lpVtbl)[3]))(this, ppidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItem(IShellItem* ppsi)
    {
        return ((delegate* unmanaged<IPreviewItem, IShellItem*, int>)((*lpVtbl)[4]))(this, ppsi);
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

    /// <summary>Initializes a new instance of the <see cref = "IPreviewItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPreviewItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IRelatedItem"/> to <see cref = "IPreviewItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IRelatedItem"/> instance to be converted </param>
    public static explicit operator IPreviewItem(Silk.NET.Windows.IRelatedItem value)
    {
        return new IPreviewItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPreviewItem"/> to <see cref = "Silk.NET.Windows.IRelatedItem"/>.</summary>
    /// <param name = "value">The <see cref = "IPreviewItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IRelatedItem(IPreviewItem value)
    {
        return new Silk.NET.Windows.IRelatedItem(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPreviewItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPreviewItem(Silk.NET.Windows.IUnknown value)
    {
        return new IPreviewItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPreviewItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPreviewItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPreviewItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
