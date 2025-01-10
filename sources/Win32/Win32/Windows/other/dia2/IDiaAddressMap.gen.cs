// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B62A2E7A-067A-4EA3-B598-04C09717502C")]
[NativeTypeName("struct IDiaAddressMap : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaAddressMap : IDiaAddressMap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaAddressMap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaAddressMap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaAddressMap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaAddressMap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_addressMapEnabled(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaAddressMap, BOOL*, int>)((*lpVtbl)[3]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_addressMapEnabled(BOOL NewVal)
    {
        return ((delegate* unmanaged<IDiaAddressMap, BOOL, int>)((*lpVtbl)[4]))(this, NewVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_relativeVirtualAddressEnabled(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaAddressMap, BOOL*, int>)((*lpVtbl)[5]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_relativeVirtualAddressEnabled(BOOL NewVal)
    {
        return ((delegate* unmanaged<IDiaAddressMap, BOOL, int>)((*lpVtbl)[6]))(this, NewVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_imageAlign([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaAddressMap, uint*, int>)((*lpVtbl)[7]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_imageAlign([NativeTypeName("DWORD")] uint NewVal)
    {
        return ((delegate* unmanaged<IDiaAddressMap, uint, int>)((*lpVtbl)[8]))(this, NewVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT set_imageHeaders(
        [NativeTypeName("DWORD")] uint cbData,
        byte* pbData,
        BOOL originalHeaders
    )
    {
        return ((delegate* unmanaged<IDiaAddressMap, uint, byte*, BOOL, int>)((*lpVtbl)[9]))(
            this,
            cbData,
            pbData,
            originalHeaders
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT set_addressMap(
        [NativeTypeName("DWORD")] uint cData,
        [NativeTypeName("struct DiaAddressMapEntry *")] DiaAddressMapEntry* pData,
        BOOL imageToSymbols
    )
    {
        return (
            (delegate* unmanaged<IDiaAddressMap, uint, DiaAddressMapEntry*, BOOL, int>)(
                (*lpVtbl)[10]
            )
        )(this, cData, pData, imageToSymbols);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_addressMapEnabled(BOOL* pRetVal);

        [VtblIndex(4)]
        HRESULT put_addressMapEnabled(BOOL NewVal);

        [VtblIndex(5)]
        HRESULT get_relativeVirtualAddressEnabled(BOOL* pRetVal);

        [VtblIndex(6)]
        HRESULT put_relativeVirtualAddressEnabled(BOOL NewVal);

        [VtblIndex(7)]
        HRESULT get_imageAlign([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(8)]
        HRESULT put_imageAlign([NativeTypeName("DWORD")] uint NewVal);

        [VtblIndex(9)]
        HRESULT set_imageHeaders(
            [NativeTypeName("DWORD")] uint cbData,
            byte* pbData,
            BOOL originalHeaders
        );

        [VtblIndex(10)]
        HRESULT set_addressMap(
            [NativeTypeName("DWORD")] uint cData,
            [NativeTypeName("struct DiaAddressMapEntry *")] DiaAddressMapEntry* pData,
            BOOL imageToSymbols
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_addressMapEnabled;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_addressMapEnabled;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_relativeVirtualAddressEnabled;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_relativeVirtualAddressEnabled;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_imageAlign;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_imageAlign;

        [NativeTypeName("HRESULT (DWORD, BYTE *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, BOOL, int> set_imageHeaders;

        [NativeTypeName(
            "HRESULT (DWORD, struct DiaAddressMapEntry *, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DiaAddressMapEntry*, BOOL, int> set_addressMap;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaAddressMap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaAddressMap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaAddressMap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaAddressMap(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaAddressMap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaAddressMap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaAddressMap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaAddressMap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
