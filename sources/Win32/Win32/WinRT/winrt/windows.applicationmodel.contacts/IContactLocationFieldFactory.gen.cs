// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F79932D7-2FDF-43FE-8F18-41897390BCFE")]
[NativeTypeName("struct IContactLocationFieldFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactLocationFieldFactory
    : IContactLocationFieldFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactLocationFieldFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IContactLocationFieldFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContactLocationFieldFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactLocationFieldFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IContactLocationFieldFactory, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactLocationFieldFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IContactLocationFieldFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateLocation_Default(
        HSTRING unstructuredAddress,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")]
            IContactLocationField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactLocationFieldFactory,
                HSTRING,
                IContactLocationField*,
                int>)((*lpVtbl)[6])
        )(this, unstructuredAddress, field);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateLocation_Category(
        HSTRING unstructuredAddress,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
            ContactFieldCategory category,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")]
            IContactLocationField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactLocationFieldFactory,
                HSTRING,
                ContactFieldCategory,
                IContactLocationField*,
                int>)((*lpVtbl)[7])
        )(this, unstructuredAddress, category, field);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateLocation_All(
        HSTRING unstructuredAddress,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
            ContactFieldCategory category,
        HSTRING street,
        HSTRING city,
        HSTRING region,
        HSTRING country,
        HSTRING postalCode,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")]
            IContactLocationField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactLocationFieldFactory,
                HSTRING,
                ContactFieldCategory,
                HSTRING,
                HSTRING,
                HSTRING,
                HSTRING,
                HSTRING,
                IContactLocationField*,
                int>)((*lpVtbl)[8])
        )(this, unstructuredAddress, category, street, city, region, country, postalCode, field);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateLocation_Default(
            HSTRING unstructuredAddress,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")]
                IContactLocationField* field
        );

        [VtblIndex(7)]
        HRESULT CreateLocation_Category(
            HSTRING unstructuredAddress,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
                ContactFieldCategory category,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")]
                IContactLocationField* field
        );

        [VtblIndex(8)]
        HRESULT CreateLocation_All(
            HSTRING unstructuredAddress,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
                ContactFieldCategory category,
            HSTRING street,
            HSTRING city,
            HSTRING region,
            HSTRING country,
            HSTRING postalCode,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")]
                IContactLocationField* field
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::IContactLocationField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IContactLocationField*,
            int> CreateLocation_Default;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactLocationField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ContactFieldCategory,
            IContactLocationField*,
            int> CreateLocation_Category;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, HSTRING, HSTRING, HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Contacts::IContactLocationField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ContactFieldCategory,
            HSTRING,
            HSTRING,
            HSTRING,
            HSTRING,
            HSTRING,
            IContactLocationField*,
            int> CreateLocation_All;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactLocationFieldFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactLocationFieldFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactLocationFieldFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactLocationFieldFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactLocationFieldFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactLocationFieldFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactLocationFieldFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactLocationFieldFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactLocationFieldFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactLocationFieldFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IContactLocationFieldFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactLocationFieldFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactLocationFieldFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactLocationFieldFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
