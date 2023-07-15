// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IGlobalOptions.xml' path='doc/member[@name="IGlobalOptions"]/*'/>
[Guid("0000015B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IGlobalOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGlobalOptions : IGlobalOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalOptions));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGlobalOptions*, Guid*, void**, int> )(lpVtbl[0]))((IGlobalOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGlobalOptions*, uint> )(lpVtbl[1]))((IGlobalOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGlobalOptions*, uint> )(lpVtbl[2]))((IGlobalOptions*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGlobalOptions.xml' path='doc/member[@name="IGlobalOptions.Set"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Set(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
    {
        return ((delegate* unmanaged<IGlobalOptions*, GLOBALOPT_PROPERTIES, nuint, int> )(lpVtbl[3]))((IGlobalOptions*)Unsafe.AsPointer(ref this), dwProperty, dwValue);
    }

    /// <include file='IGlobalOptions.xml' path='doc/member[@name="IGlobalOptions.Query"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Query(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue)
    {
        return ((delegate* unmanaged<IGlobalOptions*, GLOBALOPT_PROPERTIES, nuint*, int> )(lpVtbl[4]))((IGlobalOptions*)Unsafe.AsPointer(ref this), dwProperty, pdwValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Set(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue);
        [VtblIndex(4)]
        HRESULT Query(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue);
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
        [NativeTypeName("HRESULT (GLOBALOPT_PROPERTIES, ULONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, GLOBALOPT_PROPERTIES, nuint, int> Set;
        [NativeTypeName("HRESULT (GLOBALOPT_PROPERTIES, ULONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, GLOBALOPT_PROPERTIES, nuint*, int> Query;
    }
}