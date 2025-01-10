// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DCB07FDC-3BB5-451C-90BE-966644FED7B0")]
[NativeTypeName("struct INewMenuClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INewMenuClient : INewMenuClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INewMenuClient));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INewMenuClient, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INewMenuClient, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INewMenuClient, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IncludeItems([NativeTypeName("NMCII_FLAGS *")] int* pflags)
    {
        return ((delegate* unmanaged<INewMenuClient, int*, int>)((*lpVtbl)[3]))(this, pflags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SelectAndEditItem(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem,
        [NativeTypeName("NMCSAEI_FLAGS")] int flags
    )
    {
        return ((delegate* unmanaged<INewMenuClient, ITEMIDLIST*, int, int>)((*lpVtbl)[4]))(
            this,
            pidlItem,
            flags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IncludeItems([NativeTypeName("NMCII_FLAGS *")] int* pflags);

        [VtblIndex(4)]
        HRESULT SelectAndEditItem(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem,
            [NativeTypeName("NMCSAEI_FLAGS")] int flags
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

        [NativeTypeName("HRESULT (NMCII_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> IncludeItems;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, NMCSAEI_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int, int> SelectAndEditItem;
    }

    /// <summary>Initializes a new instance of the <see cref = "INewMenuClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INewMenuClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INewMenuClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INewMenuClient(Silk.NET.Windows.IUnknown value)
    {
        return new INewMenuClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INewMenuClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INewMenuClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INewMenuClient value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
