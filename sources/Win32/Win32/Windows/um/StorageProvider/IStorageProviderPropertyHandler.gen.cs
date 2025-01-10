// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StorageProvider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("301DFBE5-524C-4B0F-8B2D-21C40B3A2988")]
[NativeTypeName("struct IStorageProviderPropertyHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderPropertyHandler
    : IStorageProviderPropertyHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderPropertyHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageProviderPropertyHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageProviderPropertyHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderPropertyHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RetrieveProperties(
        [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* propertiesToRetrieve,
        [NativeTypeName("ULONG")] uint propertiesToRetrieveCount,
        IPropertyStore* retrievedProperties
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderPropertyHandler,
                PROPERTYKEY*,
                uint,
                IPropertyStore*,
                int>)((*lpVtbl)[3])
        )(this, propertiesToRetrieve, propertiesToRetrieveCount, retrievedProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SaveProperties(IPropertyStore propertiesToSave)
    {
        return (
            (delegate* unmanaged<IStorageProviderPropertyHandler, IPropertyStore, int>)(
                (*lpVtbl)[4]
            )
        )(this, propertiesToSave);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RetrieveProperties(
            [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* propertiesToRetrieve,
            [NativeTypeName("ULONG")] uint propertiesToRetrieveCount,
            IPropertyStore* retrievedProperties
        );

        [VtblIndex(4)]
        HRESULT SaveProperties(IPropertyStore propertiesToSave);
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
            "HRESULT (const PROPERTYKEY *, ULONG, IPropertyStore **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPERTYKEY*,
            uint,
            IPropertyStore*,
            int> RetrieveProperties;

        [NativeTypeName("HRESULT (IPropertyStore *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore, int> SaveProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderPropertyHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderPropertyHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderPropertyHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderPropertyHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageProviderPropertyHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderPropertyHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderPropertyHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageProviderPropertyHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
