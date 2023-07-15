// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IRpcOptions.xml' path='doc/member[@name="IRpcOptions"]/*'/>
[Guid("00000144-0000-0000-C000-000000000046")]
[NativeTypeName("struct IRpcOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRpcOptions : IRpcOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcOptions));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcOptions*, Guid*, void**, int> )(lpVtbl[0]))((IRpcOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRpcOptions*, uint> )(lpVtbl[1]))((IRpcOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcOptions*, uint> )(lpVtbl[2]))((IRpcOptions*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRpcOptions.xml' path='doc/member[@name="IRpcOptions.Set"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Set(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
    {
        return ((delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint, int> )(lpVtbl[3]))((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, dwValue);
    }

    /// <include file='IRpcOptions.xml' path='doc/member[@name="IRpcOptions.Query"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Query(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue)
    {
        return ((delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint*, int> )(lpVtbl[4]))((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, pdwValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Set(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue);
        [VtblIndex(4)]
        HRESULT Query(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue);
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
        [NativeTypeName("HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, RPCOPT_PROPERTIES, nuint, int> Set;
        [NativeTypeName("HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, RPCOPT_PROPERTIES, nuint*, int> Query;
    }
}