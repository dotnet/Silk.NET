// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CEB38218-C971-47BB-A703-F0BC99CCDB81")]
[NativeTypeName("struct INetworkFolderInternal : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INetworkFolderInternal : INetworkFolderInternal.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkFolderInternal));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INetworkFolderInternal, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INetworkFolderInternal, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INetworkFolderInternal, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResourceDisplayType(uint* displayType)
    {
        return ((delegate* unmanaged<INetworkFolderInternal, uint*, int>)((*lpVtbl)[3]))(
            this,
            displayType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** idList)
    {
        return ((delegate* unmanaged<INetworkFolderInternal, ITEMIDLIST**, int>)((*lpVtbl)[4]))(
            this,
            idList
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProvider(
        uint itemIdCount,
        [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** itemIds,
        uint providerMaxLength,
        [NativeTypeName("LPWSTR")] ushort* provider
    )
    {
        return (
            (delegate* unmanaged<INetworkFolderInternal, uint, ITEMIDLIST**, uint, ushort*, int>)(
                (*lpVtbl)[5]
            )
        )(this, itemIdCount, itemIds, providerMaxLength, provider);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetResourceDisplayType(uint* displayType);

        [VtblIndex(4)]
        HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** idList);

        [VtblIndex(5)]
        HRESULT GetProvider(
            uint itemIdCount,
            [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** itemIds,
            uint providerMaxLength,
            [NativeTypeName("LPWSTR")] ushort* provider
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetResourceDisplayType;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetIDList;

        [NativeTypeName("HRESULT (UINT, LPCITEMIDLIST *, UINT, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITEMIDLIST**, uint, ushort*, int> GetProvider;
    }

    /// <summary>Initializes a new instance of the <see cref = "INetworkFolderInternal"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INetworkFolderInternal(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INetworkFolderInternal"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INetworkFolderInternal(Silk.NET.Windows.IUnknown value)
    {
        return new INetworkFolderInternal(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INetworkFolderInternal"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INetworkFolderInternal"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INetworkFolderInternal value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
