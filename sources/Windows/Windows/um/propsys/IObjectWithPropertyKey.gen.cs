// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IObjectWithPropertyKey.xml' path='doc/member[@name="IObjectWithPropertyKey"]/*'/>
[Guid("FC0CA0A7-C316-4FD2-9031-3E628E6D4F23")]
[NativeTypeName("struct IObjectWithPropertyKey : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithPropertyKey : IObjectWithPropertyKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectWithPropertyKey));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectWithPropertyKey*, Guid*, void**, int> )(lpVtbl[0]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObjectWithPropertyKey*, uint> )(lpVtbl[1]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectWithPropertyKey*, uint> )(lpVtbl[2]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IObjectWithPropertyKey.xml' path='doc/member[@name="IObjectWithPropertyKey.SetPropertyKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int> )(lpVtbl[3]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), key);
    }

    /// <include file='IObjectWithPropertyKey.xml' path='doc/member[@name="IObjectWithPropertyKey.GetPropertyKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IObjectWithPropertyKey*, PROPERTYKEY*, int> )(lpVtbl[4]))((IObjectWithPropertyKey*)Unsafe.AsPointer(ref this), pkey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);
        [VtblIndex(4)]
        HRESULT GetPropertyKey(PROPERTYKEY* pkey);
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
        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> SetPropertyKey;
        [NativeTypeName("HRESULT (PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> GetPropertyKey;
    }
}