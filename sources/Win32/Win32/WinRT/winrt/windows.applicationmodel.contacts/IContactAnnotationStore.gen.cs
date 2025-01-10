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

[Guid("23ACF4AA-7A77-457D-8203-987F4B31AF09")]
[NativeTypeName("struct IContactAnnotationStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactAnnotationStore
    : IContactAnnotationStore.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactAnnotationStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactAnnotationStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactAnnotationStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactAnnotationStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactAnnotationStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactAnnotationStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactAnnotationStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindContactIdsByEmailAsync(
        HSTRING emailAddress,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
        )]
            IAsyncOperation<IntPtr>** contactIds
    )
    {
        return (
            (delegate* unmanaged<IContactAnnotationStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, emailAddress, contactIds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindContactIdsByPhoneNumberAsync(
        HSTRING phoneNumber,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
        )]
            IAsyncOperation<IntPtr>** contactIds
    )
    {
        return (
            (delegate* unmanaged<IContactAnnotationStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, phoneNumber, contactIds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAnnotationsForContactAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **"
        )]
            IAsyncOperation<IntPtr>** annotations
    )
    {
        return (
            (delegate* unmanaged<
                IContactAnnotationStore,
                IContact,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, contact, annotations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DisableAnnotationAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")]
            IContactAnnotation annotation,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<IContactAnnotationStore, IContactAnnotation, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, annotation, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateAnnotationListAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IContactAnnotationStore, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateAnnotationListInAccountAsync(
        HSTRING userDataAccountId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IContactAnnotationStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, userDataAccountId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAnnotationListAsync(
        HSTRING annotationListId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IContactAnnotationStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, annotationListId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT FindAnnotationListsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
        )]
            IAsyncOperation<IntPtr>** lists
    )
    {
        return (
            (delegate* unmanaged<IContactAnnotationStore, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, lists);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindContactIdsByEmailAsync(
            HSTRING emailAddress,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** contactIds
        );

        [VtblIndex(7)]
        HRESULT FindContactIdsByPhoneNumberAsync(
            HSTRING phoneNumber,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** contactIds
        );

        [VtblIndex(8)]
        HRESULT FindAnnotationsForContactAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **"
            )]
                IAsyncOperation<IntPtr>** annotations
        );

        [VtblIndex(9)]
        HRESULT DisableAnnotationAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")]
                IContactAnnotation annotation,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(10)]
        HRESULT CreateAnnotationListAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(11)]
        HRESULT CreateAnnotationListInAccountAsync(
            HSTRING userDataAccountId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT GetAnnotationListAsync(
            HSTRING annotationListId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(13)]
        HRESULT FindAnnotationListsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
            )]
                IAsyncOperation<IntPtr>** lists
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FindContactIdsByEmailAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FindContactIdsByPhoneNumberAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            IAsyncOperation<IntPtr>**,
            int> FindAnnotationsForContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContactAnnotation,
            IAsyncAction*,
            int> DisableAnnotationAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> CreateAnnotationListAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateAnnotationListInAccountAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetAnnotationListAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindAnnotationListsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactAnnotationStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactAnnotationStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactAnnotationStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactAnnotationStore(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactAnnotationStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactAnnotationStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactAnnotationStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactAnnotationStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactAnnotationStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactAnnotationStore(Silk.NET.Windows.IUnknown value)
    {
        return new IContactAnnotationStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactAnnotationStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactAnnotationStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactAnnotationStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
