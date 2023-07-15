// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPropertyStore.xml' path='doc/member[@name="IPropertyStore"]/*'/>
[Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
[NativeTypeName("struct IPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyStore : IPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyStore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyStore*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyStore*, uint> )(lpVtbl[1]))((IPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyStore*, uint> )(lpVtbl[2]))((IPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyStore.xml' path='doc/member[@name="IPropertyStore.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount([NativeTypeName("DWORD *")] uint* cProps)
    {
        return ((delegate* unmanaged<IPropertyStore*, uint*, int> )(lpVtbl[3]))((IPropertyStore*)Unsafe.AsPointer(ref this), cProps);
    }

    /// <include file='IPropertyStore.xml' path='doc/member[@name="IPropertyStore.GetAt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt([NativeTypeName("DWORD")] uint iProp, PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyStore*, uint, PROPERTYKEY*, int> )(lpVtbl[4]))((IPropertyStore*)Unsafe.AsPointer(ref this), iProp, pkey);
    }

    /// <include file='IPropertyStore.xml' path='doc/member[@name="IPropertyStore.GetValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* pv)
    {
        return ((delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int> )(lpVtbl[5]))((IPropertyStore*)Unsafe.AsPointer(ref this), key, pv);
    }

    /// <include file='IPropertyStore.xml' path='doc/member[@name="IPropertyStore.SetValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
    {
        return ((delegate* unmanaged<IPropertyStore*, PROPERTYKEY*, PROPVARIANT*, int> )(lpVtbl[6]))((IPropertyStore*)Unsafe.AsPointer(ref this), key, propvar);
    }

    /// <include file='IPropertyStore.xml' path='doc/member[@name="IPropertyStore.Commit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IPropertyStore*, int> )(lpVtbl[7]))((IPropertyStore*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount([NativeTypeName("DWORD *")] uint* cProps);
        [VtblIndex(4)]
        HRESULT GetAt([NativeTypeName("DWORD")] uint iProp, PROPERTYKEY* pkey);
        [VtblIndex(5)]
        HRESULT GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* pv);
        [VtblIndex(6)]
        HRESULT SetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);
        [VtblIndex(7)]
        HRESULT Commit();
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (DWORD, PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPERTYKEY*, int> GetAt;
        [NativeTypeName("HRESULT (const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, PROPVARIANT*, int> GetValue;
        [NativeTypeName("HRESULT (const PROPERTYKEY &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, PROPVARIANT*, int> SetValue;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;
    }
}