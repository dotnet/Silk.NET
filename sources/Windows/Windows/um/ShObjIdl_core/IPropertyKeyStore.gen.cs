// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPropertyKeyStore.xml' path='doc/member[@name="IPropertyKeyStore"]/*'/>
[Guid("75BD59AA-F23B-4963-ABA4-0B355752A91B")]
[NativeTypeName("struct IPropertyKeyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyKeyStore : IPropertyKeyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyKeyStore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, uint> )(lpVtbl[1]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, uint> )(lpVtbl[2]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyKeyStore.xml' path='doc/member[@name="IPropertyKeyStore.GetKeyCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetKeyCount(int* keyCount)
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, int*, int> )(lpVtbl[3]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), keyCount);
    }

    /// <include file='IPropertyKeyStore.xml' path='doc/member[@name="IPropertyKeyStore.GetKeyAt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetKeyAt(int index, PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, int, PROPERTYKEY*, int> )(lpVtbl[4]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), index, pkey);
    }

    /// <include file='IPropertyKeyStore.xml' path='doc/member[@name="IPropertyKeyStore.AppendKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AppendKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, PROPERTYKEY*, int> )(lpVtbl[5]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), key);
    }

    /// <include file='IPropertyKeyStore.xml' path='doc/member[@name="IPropertyKeyStore.DeleteKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteKey(int index)
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, int, int> )(lpVtbl[6]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), index);
    }

    /// <include file='IPropertyKeyStore.xml' path='doc/member[@name="IPropertyKeyStore.IsKeyInStore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsKeyInStore([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, PROPERTYKEY*, int> )(lpVtbl[7]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), key);
    }

    /// <include file='IPropertyKeyStore.xml' path='doc/member[@name="IPropertyKeyStore.RemoveKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyKeyStore*, PROPERTYKEY*, int> )(lpVtbl[8]))((IPropertyKeyStore*)Unsafe.AsPointer(ref this), key);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetKeyCount(int* keyCount);
        [VtblIndex(4)]
        HRESULT GetKeyAt(int index, PROPERTYKEY* pkey);
        [VtblIndex(5)]
        HRESULT AppendKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);
        [VtblIndex(6)]
        HRESULT DeleteKey(int index);
        [VtblIndex(7)]
        HRESULT IsKeyInStore([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);
        [VtblIndex(8)]
        HRESULT RemoveKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);
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
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetKeyCount;
        [NativeTypeName("HRESULT (int, PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, PROPERTYKEY*, int> GetKeyAt;
        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> AppendKey;
        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> DeleteKey;
        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> IsKeyInStore;
        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> RemoveKey;
    }
}