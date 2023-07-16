// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ICurrentItem.xml' path='doc/member[@name="ICurrentItem"]/*'/>
[Guid("240A7174-D653-4A1D-A6D3-D4943CFBFE3D")]
[NativeTypeName("struct ICurrentItem : IRelatedItem")]
[NativeInheritance("IRelatedItem")]
public unsafe partial struct ICurrentItem : ICurrentItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICurrentItem));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICurrentItem*, Guid*, void**, int> )(lpVtbl[0]))((ICurrentItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICurrentItem*, uint> )(lpVtbl[1]))((ICurrentItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICurrentItem*, uint> )(lpVtbl[2]))((ICurrentItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IRelatedItem.GetItemIDList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<ICurrentItem*, ITEMIDLIST**, int> )(lpVtbl[3]))((ICurrentItem*)Unsafe.AsPointer(ref this), ppidl);
    }

    /// <inheritdoc cref = "IRelatedItem.GetItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItem(IShellItem** ppsi)
    {
        return ((delegate* unmanaged<ICurrentItem*, IShellItem**, int> )(lpVtbl[4]))((ICurrentItem*)Unsafe.AsPointer(ref this), ppsi);
    }

    public interface Interface : IRelatedItem.Interface
    {
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
        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetItemIDList;
        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem**, int> GetItem;
    }
}