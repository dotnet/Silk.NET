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

[Guid("C4CC3D42-7586-492A-930B-7BC138FC2139")]
[NativeTypeName("struct IContactManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactManagerStatics3
    : IContactManagerStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactManagerStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactManagerStatics3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactManagerStatics3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactManagerStatics3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactManagerStatics3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactManagerStatics3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactManagerStatics3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConvertContactToVCardAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
        )]
            IAsyncOperation<IntPtr>** vCard
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics3,
                IContact,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, contact, vCard);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConvertContactToVCardAsyncWithMaxBytes(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("UINT32")] uint maxBytes,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
        )]
            IAsyncOperation<IntPtr>** vCard
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics3,
                IContact,
                uint,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, contact, maxBytes, vCard);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertVCardToContactAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference vCard,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** contact
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics3,
                IRandomAccessStreamReference,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, vCard, contact);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestStoreAsyncWithAccessType(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")]
            ContactStoreAccessType accessType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **"
        )]
            IAsyncOperation<IntPtr>** store
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics3,
                ContactStoreAccessType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, accessType, store);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAnnotationStoreAsync(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType"
        )]
            ContactAnnotationStoreAccessType accessType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **"
        )]
            IAsyncOperation<IntPtr>** store
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics3,
                ContactAnnotationStoreAccessType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, accessType, store);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsShowContactCardSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IContactManagerStatics3, byte*, int>)((*lpVtbl)[11]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowContactCardWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")]
            IContactCardOptions contactCardOptions
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics3,
                IContact,
                Rect,
                Placement,
                IContactCardOptions,
                int>)((*lpVtbl)[12])
        )(this, contact, selection, preferredPlacement, contactCardOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsShowDelayLoadedContactCardSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IContactManagerStatics3, byte*, int>)((*lpVtbl)[13]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ShowDelayLoadedContactCardWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")]
            IContactCardOptions contactCardOptions,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **"
        )]
            IContactCardDelayedDataLoader* dataLoader
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerStatics3,
                IContact,
                Rect,
                Placement,
                IContactCardOptions,
                IContactCardDelayedDataLoader*,
                int>)((*lpVtbl)[14])
        )(this, contact, selection, preferredPlacement, contactCardOptions, dataLoader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ShowFullContactCard(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IFullContactCardOptions *")]
            IFullContactCardOptions fullContactCardOptions
    )
    {
        return (
            (delegate* unmanaged<IContactManagerStatics3, IContact, IFullContactCardOptions, int>)(
                (*lpVtbl)[15]
            )
        )(this, contact, fullContactCardOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SystemDisplayNameOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
            ContactNameOrder* value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerStatics3, ContactNameOrder*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_SystemDisplayNameOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
            ContactNameOrder value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerStatics3, ContactNameOrder, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SystemSortOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
            ContactNameOrder* value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerStatics3, ContactNameOrder*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_SystemSortOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
            ContactNameOrder value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerStatics3, ContactNameOrder, int>)((*lpVtbl)[19])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConvertContactToVCardAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
            )]
                IAsyncOperation<IntPtr>** vCard
        );

        [VtblIndex(7)]
        HRESULT ConvertContactToVCardAsyncWithMaxBytes(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("UINT32")] uint maxBytes,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
            )]
                IAsyncOperation<IntPtr>** vCard
        );

        [VtblIndex(8)]
        HRESULT ConvertVCardToContactAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference vCard,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** contact
        );

        [VtblIndex(9)]
        HRESULT RequestStoreAsyncWithAccessType(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")]
                ContactStoreAccessType accessType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **"
            )]
                IAsyncOperation<IntPtr>** store
        );

        [VtblIndex(10)]
        HRESULT RequestAnnotationStoreAsync(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType"
            )]
                ContactAnnotationStoreAccessType accessType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **"
            )]
                IAsyncOperation<IntPtr>** store
        );

        [VtblIndex(11)]
        HRESULT IsShowContactCardSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(12)]
        HRESULT ShowContactCardWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")]
                IContactCardOptions contactCardOptions
        );

        [VtblIndex(13)]
        HRESULT IsShowDelayLoadedContactCardSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT ShowDelayLoadedContactCardWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")]
                IContactCardOptions contactCardOptions,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **"
            )]
                IContactCardDelayedDataLoader* dataLoader
        );

        [VtblIndex(15)]
        HRESULT ShowFullContactCard(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IFullContactCardOptions *")]
                IFullContactCardOptions fullContactCardOptions
        );

        [VtblIndex(16)]
        HRESULT get_SystemDisplayNameOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
                ContactNameOrder* value
        );

        [VtblIndex(17)]
        HRESULT put_SystemDisplayNameOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
                ContactNameOrder value
        );

        [VtblIndex(18)]
        HRESULT get_SystemSortOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
                ContactNameOrder* value
        );

        [VtblIndex(19)]
        HRESULT put_SystemSortOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
                ContactNameOrder value
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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            IAsyncOperation<IntPtr>**,
            int> ConvertContactToVCardAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            uint,
            IAsyncOperation<IntPtr>**,
            int> ConvertContactToVCardAsyncWithMaxBytes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference,
            IAsyncOperation<IntPtr>**,
            int> ConvertVCardToContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ContactStoreAccessType,
            IAsyncOperation<IntPtr>**,
            int> RequestStoreAsyncWithAccessType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ContactAnnotationStoreAccessType,
            IAsyncOperation<IntPtr>**,
            int> RequestAnnotationStoreAsync;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> IsShowContactCardSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            Rect,
            Placement,
            IContactCardOptions,
            int> ShowContactCardWithOptions;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> IsShowDelayLoadedContactCardSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *, ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            Rect,
            Placement,
            IContactCardOptions,
            IContactCardDelayedDataLoader*,
            int> ShowDelayLoadedContactCardWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::IFullContactCardOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            IFullContactCardOptions,
            int> ShowFullContactCard;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactNameOrder*, int> get_SystemDisplayNameOrder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactNameOrder, int> put_SystemDisplayNameOrder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactNameOrder*, int> get_SystemSortOrder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactNameOrder, int> put_SystemSortOrder;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactManagerStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactManagerStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactManagerStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactManagerStatics3(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactManagerStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManagerStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManagerStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactManagerStatics3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactManagerStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactManagerStatics3(Silk.NET.Windows.IUnknown value)
    {
        return new IContactManagerStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManagerStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManagerStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactManagerStatics3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
