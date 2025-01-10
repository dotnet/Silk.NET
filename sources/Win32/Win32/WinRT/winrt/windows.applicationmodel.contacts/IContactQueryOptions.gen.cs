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

[Guid("4408CC9E-7D7C-42F0-8AC7-F50733ECDBC1")]
[NativeTypeName("struct IContactQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactQueryOptions : IContactQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactQueryOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactQueryOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactQueryOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactQueryOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactQueryOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactQueryOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactQueryOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TextSearch(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryTextSearch **")]
            IContactQueryTextSearch* value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryOptions, IContactQueryTextSearch*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContactListIds(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IContactQueryOptions, IVector<HSTRING>**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IncludeContactsFromHiddenLists([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IContactQueryOptions, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IncludeContactsFromHiddenLists([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IContactQueryOptions, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DesiredFields(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields *")]
            ContactQueryDesiredFields* value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryOptions, ContactQueryDesiredFields*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DesiredFields(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields")]
            ContactQueryDesiredFields value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryOptions, ContactQueryDesiredFields, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DesiredOperations(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *")]
            ContactAnnotationOperations* value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryOptions, ContactAnnotationOperations*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DesiredOperations(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations")]
            ContactAnnotationOperations value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryOptions, ContactAnnotationOperations, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AnnotationListIds(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<IContactQueryOptions, IVector<HSTRING>**, int>)((*lpVtbl)[14])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TextSearch(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryTextSearch **")]
                IContactQueryTextSearch* value
        );

        [VtblIndex(7)]
        HRESULT get_ContactListIds(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(8)]
        HRESULT get_IncludeContactsFromHiddenLists([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IncludeContactsFromHiddenLists([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_DesiredFields(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields *"
            )]
                ContactQueryDesiredFields* value
        );

        [VtblIndex(11)]
        HRESULT put_DesiredFields(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields")]
                ContactQueryDesiredFields value
        );

        [VtblIndex(12)]
        HRESULT get_DesiredOperations(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *"
            )]
                ContactAnnotationOperations* value
        );

        [VtblIndex(13)]
        HRESULT put_DesiredOperations(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations"
            )]
                ContactAnnotationOperations value
        );

        [VtblIndex(14)]
        HRESULT get_AnnotationListIds(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactQueryTextSearch **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContactQueryTextSearch*, int> get_TextSearch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_ContactListIds;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IncludeContactsFromHiddenLists;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IncludeContactsFromHiddenLists;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactQueryDesiredFields*, int> get_DesiredFields;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactQueryDesiredFields, int> put_DesiredFields;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactAnnotationOperations*, int> get_DesiredOperations;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactAnnotationOperations, int> put_DesiredOperations;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_AnnotationListIds;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactQueryOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactQueryOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactQueryOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactQueryOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactQueryOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactQueryOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IContactQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactQueryOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactQueryOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
