// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StorageProvider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IStorageProviderPropertyHandler.xml' path='doc/member[@name="IStorageProviderPropertyHandler"]/*'/>
[Guid("301DFBE5-524C-4B0F-8B2D-21C40B3A2988")]
[NativeTypeName("struct IStorageProviderPropertyHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderPropertyHandler : IStorageProviderPropertyHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderPropertyHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageProviderPropertyHandler*, Guid*, void**, int> )(lpVtbl[0]))((IStorageProviderPropertyHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageProviderPropertyHandler*, uint> )(lpVtbl[1]))((IStorageProviderPropertyHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderPropertyHandler*, uint> )(lpVtbl[2]))((IStorageProviderPropertyHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStorageProviderPropertyHandler.xml' path='doc/member[@name="IStorageProviderPropertyHandler.RetrieveProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RetrieveProperties([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* propertiesToRetrieve, [NativeTypeName("ULONG")] uint propertiesToRetrieveCount, IPropertyStore** retrievedProperties)
    {
        return ((delegate* unmanaged<IStorageProviderPropertyHandler*, PROPERTYKEY*, uint, IPropertyStore**, int> )(lpVtbl[3]))((IStorageProviderPropertyHandler*)Unsafe.AsPointer(ref this), propertiesToRetrieve, propertiesToRetrieveCount, retrievedProperties);
    }

    /// <include file='IStorageProviderPropertyHandler.xml' path='doc/member[@name="IStorageProviderPropertyHandler.SaveProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SaveProperties(IPropertyStore* propertiesToSave)
    {
        return ((delegate* unmanaged<IStorageProviderPropertyHandler*, IPropertyStore*, int> )(lpVtbl[4]))((IStorageProviderPropertyHandler*)Unsafe.AsPointer(ref this), propertiesToSave);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RetrieveProperties([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* propertiesToRetrieve, [NativeTypeName("ULONG")] uint propertiesToRetrieveCount, IPropertyStore** retrievedProperties);
        [VtblIndex(4)]
        HRESULT SaveProperties(IPropertyStore* propertiesToSave);
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
        [NativeTypeName("HRESULT (const PROPERTYKEY *, ULONG, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, uint, IPropertyStore**, int> RetrieveProperties;
        [NativeTypeName("HRESULT (IPropertyStore *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore*, int> SaveProperties;
    }
}