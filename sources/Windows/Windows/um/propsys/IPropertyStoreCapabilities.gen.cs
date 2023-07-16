// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPropertyStoreCapabilities.xml' path='doc/member[@name="IPropertyStoreCapabilities"]/*'/>
[Guid("C8E2D566-186E-4D49-BF41-6909EAD56ACC")]
[NativeTypeName("struct IPropertyStoreCapabilities : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyStoreCapabilities : IPropertyStoreCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyStoreCapabilities));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyStoreCapabilities*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyStoreCapabilities*, uint> )(lpVtbl[1]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyStoreCapabilities*, uint> )(lpVtbl[2]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyStoreCapabilities.xml' path='doc/member[@name="IPropertyStoreCapabilities.IsPropertyWritable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsPropertyWritable([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyStoreCapabilities*, PROPERTYKEY*, int> )(lpVtbl[3]))((IPropertyStoreCapabilities*)Unsafe.AsPointer(ref this), key);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsPropertyWritable([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);
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
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> IsPropertyWritable;
    }
}