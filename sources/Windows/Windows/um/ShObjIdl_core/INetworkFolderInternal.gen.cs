// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='INetworkFolderInternal.xml' path='doc/member[@name="INetworkFolderInternal"]/*' />
[Guid("CEB38218-C971-47BB-A703-F0BC99CCDB81")]
[NativeTypeName("struct INetworkFolderInternal : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INetworkFolderInternal : INetworkFolderInternal.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkFolderInternal));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INetworkFolderInternal*, Guid*, void**, int>)(lpVtbl[0]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INetworkFolderInternal*, uint>)(lpVtbl[1]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INetworkFolderInternal*, uint>)(lpVtbl[2]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INetworkFolderInternal.xml' path='doc/member[@name="INetworkFolderInternal.GetResourceDisplayType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResourceDisplayType(uint* displayType)
    {
        return ((delegate* unmanaged<INetworkFolderInternal*, uint*, int>)(lpVtbl[3]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), displayType);
    }

    /// <include file='INetworkFolderInternal.xml' path='doc/member[@name="INetworkFolderInternal.GetIDList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** idList)
    {
        return ((delegate* unmanaged<INetworkFolderInternal*, ITEMIDLIST**, int>)(lpVtbl[4]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), idList);
    }

    /// <include file='INetworkFolderInternal.xml' path='doc/member[@name="INetworkFolderInternal.GetProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProvider(uint itemIdCount, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** itemIds, uint providerMaxLength, [NativeTypeName("LPWSTR")] ushort* provider)
    {
        return ((delegate* unmanaged<INetworkFolderInternal*, uint, ITEMIDLIST**, uint, ushort*, int>)(lpVtbl[5]))((INetworkFolderInternal*)Unsafe.AsPointer(ref this), itemIdCount, itemIds, providerMaxLength, provider);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetResourceDisplayType(uint* displayType);

        [VtblIndex(4)]
        HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** idList);

        [VtblIndex(5)]
        HRESULT GetProvider(uint itemIdCount, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** itemIds, uint providerMaxLength, [NativeTypeName("LPWSTR")] ushort* provider);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetResourceDisplayType;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetIDList;

        [NativeTypeName("HRESULT (UINT, LPCITEMIDLIST *, UINT, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITEMIDLIST**, uint, ushort*, int> GetProvider;
    }
}
