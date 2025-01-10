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

[Guid("85E2913F-0E4A-4A3E-8994-406AE7ED646E")]
[NativeTypeName("struct IContactFieldFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactFieldFactory : IContactFieldFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactFieldFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactFieldFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContactFieldFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactFieldFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactFieldFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactFieldFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactFieldFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateField_Default(
        HSTRING value,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
            ContactFieldType type,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")]
            IContactField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactFieldFactory,
                HSTRING,
                ContactFieldType,
                IContactField*,
                int>)((*lpVtbl)[6])
        )(this, value, type, field);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateField_Category(
        HSTRING value,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
            ContactFieldType type,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
            ContactFieldCategory category,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")]
            IContactField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactFieldFactory,
                HSTRING,
                ContactFieldType,
                ContactFieldCategory,
                IContactField*,
                int>)((*lpVtbl)[7])
        )(this, value, type, category, field);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateField_Custom(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
            ContactFieldType type,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
            ContactFieldCategory category,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")]
            IContactField* field
    )
    {
        return (
            (delegate* unmanaged<
                IContactFieldFactory,
                HSTRING,
                HSTRING,
                ContactFieldType,
                ContactFieldCategory,
                IContactField*,
                int>)((*lpVtbl)[8])
        )(this, name, value, type, category, field);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateField_Default(
            HSTRING value,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
                ContactFieldType type,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")]
                IContactField* field
        );

        [VtblIndex(7)]
        HRESULT CreateField_Category(
            HSTRING value,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
                ContactFieldType type,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
                ContactFieldCategory category,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")]
                IContactField* field
        );

        [VtblIndex(8)]
        HRESULT CreateField_Custom(
            HSTRING name,
            HSTRING value,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")]
                ContactFieldType type,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")]
                ContactFieldCategory category,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")]
                IContactField* field
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
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType, ABI::Windows::ApplicationModel::Contacts::IContactField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ContactFieldType,
            IContactField*,
            int> CreateField_Default;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ContactFieldType,
            ContactFieldCategory,
            IContactField*,
            int> CreateField_Category;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactField **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            ContactFieldType,
            ContactFieldCategory,
            IContactField*,
            int> CreateField_Custom;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactFieldFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactFieldFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactFieldFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactFieldFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactFieldFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactFieldFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactFieldFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactFieldFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactFieldFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactFieldFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IContactFieldFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactFieldFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactFieldFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactFieldFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
