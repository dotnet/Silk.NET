// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000144-0000-0000-C000-000000000046")]
[NativeTypeName("struct IRpcOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRpcOptions : IRpcOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRpcOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Set(
        IUnknown pPrx,
        RPCOPT_PROPERTIES dwProperty,
        [NativeTypeName("ULONG_PTR")] nuint dwValue
    )
    {
        return (
            (delegate* unmanaged<IRpcOptions, IUnknown, RPCOPT_PROPERTIES, nuint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pPrx, dwProperty, dwValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Query(
        IUnknown pPrx,
        RPCOPT_PROPERTIES dwProperty,
        [NativeTypeName("ULONG_PTR *")] nuint* pdwValue
    )
    {
        return (
            (delegate* unmanaged<IRpcOptions, IUnknown, RPCOPT_PROPERTIES, nuint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pPrx, dwProperty, pdwValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Set(
            IUnknown pPrx,
            RPCOPT_PROPERTIES dwProperty,
            [NativeTypeName("ULONG_PTR")] nuint dwValue
        );

        [VtblIndex(4)]
        HRESULT Query(
            IUnknown pPrx,
            RPCOPT_PROPERTIES dwProperty,
            [NativeTypeName("ULONG_PTR *")] nuint* pdwValue
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
            "HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, RPCOPT_PROPERTIES, nuint, int> Set;

        [NativeTypeName(
            "HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, RPCOPT_PROPERTIES, nuint*, int> Query;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRpcOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRpcOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRpcOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRpcOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IRpcOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRpcOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRpcOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRpcOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
