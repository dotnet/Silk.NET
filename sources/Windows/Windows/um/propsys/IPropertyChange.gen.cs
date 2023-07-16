// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPropertyChange.xml' path='doc/member[@name="IPropertyChange"]/*'/>
[Guid("F917BC8A-1BBA-4478-A245-1BDE03EB9431")]
[NativeTypeName("struct IPropertyChange : IObjectWithPropertyKey")]
[NativeInheritance("IObjectWithPropertyKey")]
public unsafe partial struct IPropertyChange : IPropertyChange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyChange));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyChange*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyChange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyChange*, uint> )(lpVtbl[1]))((IPropertyChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyChange*, uint> )(lpVtbl[2]))((IPropertyChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IObjectWithPropertyKey.SetPropertyKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int> )(lpVtbl[3]))((IPropertyChange*)Unsafe.AsPointer(ref this), key);
    }

    /// <inheritdoc cref = "IObjectWithPropertyKey.GetPropertyKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyChange*, PROPERTYKEY*, int> )(lpVtbl[4]))((IPropertyChange*)Unsafe.AsPointer(ref this), pkey);
    }

    /// <include file='IPropertyChange.xml' path='doc/member[@name="IPropertyChange.ApplyToPropVariant"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ApplyToPropVariant([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, PROPVARIANT* ppropvarOut)
    {
        return ((delegate* unmanaged<IPropertyChange*, PROPVARIANT*, PROPVARIANT*, int> )(lpVtbl[5]))((IPropertyChange*)Unsafe.AsPointer(ref this), propvarIn, ppropvarOut);
    }

    public interface Interface : IObjectWithPropertyKey.Interface
    {
        [VtblIndex(5)]
        HRESULT ApplyToPropVariant([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, PROPVARIANT* ppropvarOut);
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
        [NativeTypeName("HRESULT (const PROPVARIANT &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, PROPVARIANT*, int> ApplyToPropVariant;
    }
}