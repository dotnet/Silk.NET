// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
[NativeTypeName("struct IDiaEnumSymbolsByAddr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumSymbolsByAddr : IDiaEnumSymbolsByAddr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumSymbolsByAddr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumSymbolsByAddr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaEnumSymbolsByAddr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumSymbolsByAddr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT symbolByAddr(
        [NativeTypeName("DWORD")] uint isect,
        [NativeTypeName("DWORD")] uint offset,
        IDiaSymbol* ppSymbol
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumSymbolsByAddr, uint, uint, IDiaSymbol*, int>)((*lpVtbl)[3])
        )(this, isect, offset, ppSymbol);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT symbolByRVA(
        [NativeTypeName("DWORD")] uint relativeVirtualAddress,
        IDiaSymbol* ppSymbol
    )
    {
        return ((delegate* unmanaged<IDiaEnumSymbolsByAddr, uint, IDiaSymbol*, int>)((*lpVtbl)[4]))(
            this,
            relativeVirtualAddress,
            ppSymbol
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT symbolByVA(
        [NativeTypeName("ULONGLONG")] ulong virtualAddress,
        IDiaSymbol* ppSymbol
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumSymbolsByAddr, ulong, IDiaSymbol*, int>)((*lpVtbl)[5])
        )(this, virtualAddress, ppSymbol);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint celt,
        IDiaSymbol* rgelt,
        [NativeTypeName("ULONG *")] uint* pceltFetched
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumSymbolsByAddr, uint, IDiaSymbol*, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, celt, rgelt, pceltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Prev(
        [NativeTypeName("ULONG")] uint celt,
        IDiaSymbol* rgelt,
        [NativeTypeName("ULONG *")] uint* pceltFetched
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumSymbolsByAddr, uint, IDiaSymbol*, uint*, int>)(
                (*lpVtbl)[7]
            )
        )(this, celt, rgelt, pceltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clone(IDiaEnumSymbolsByAddr* ppenum)
    {
        return (
            (delegate* unmanaged<IDiaEnumSymbolsByAddr, IDiaEnumSymbolsByAddr*, int>)((*lpVtbl)[8])
        )(this, ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT symbolByAddr(
            [NativeTypeName("DWORD")] uint isect,
            [NativeTypeName("DWORD")] uint offset,
            IDiaSymbol* ppSymbol
        );

        [VtblIndex(4)]
        HRESULT symbolByRVA(
            [NativeTypeName("DWORD")] uint relativeVirtualAddress,
            IDiaSymbol* ppSymbol
        );

        [VtblIndex(5)]
        HRESULT symbolByVA(
            [NativeTypeName("ULONGLONG")] ulong virtualAddress,
            IDiaSymbol* ppSymbol
        );

        [VtblIndex(6)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint celt,
            IDiaSymbol* rgelt,
            [NativeTypeName("ULONG *")] uint* pceltFetched
        );

        [VtblIndex(7)]
        HRESULT Prev(
            [NativeTypeName("ULONG")] uint celt,
            IDiaSymbol* rgelt,
            [NativeTypeName("ULONG *")] uint* pceltFetched
        );

        [VtblIndex(8)]
        HRESULT Clone(IDiaEnumSymbolsByAddr* ppenum);
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

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDiaSymbol*, int> symbolByAddr;

        [NativeTypeName("HRESULT (DWORD, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSymbol*, int> symbolByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, IDiaSymbol*, int> symbolByVA;

        [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSymbol*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSymbol*, uint*, int> Prev;

        [NativeTypeName("HRESULT (IDiaEnumSymbolsByAddr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSymbolsByAddr*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaEnumSymbolsByAddr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaEnumSymbolsByAddr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaEnumSymbolsByAddr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaEnumSymbolsByAddr(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaEnumSymbolsByAddr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaEnumSymbolsByAddr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaEnumSymbolsByAddr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaEnumSymbolsByAddr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
