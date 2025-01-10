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

[Guid("18CE1C22-EBD5-4BFB-B690-5F4F27C4F0E8")]
[NativeTypeName("struct IContactStore2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactStore2 : IContactStore2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactStore2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactStore2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactStore2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactStore2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactStore2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactStore2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactStore2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeTracker(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")]
            IContactChangeTracker* value
    )
    {
        return ((delegate* unmanaged<IContactStore2, IContactChangeTracker*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_ContactChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactStore_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* returnValue
    )
    {
        return (
            (delegate* unmanaged<
                IContactStore2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[7])
        )(this, value, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_ContactChanged(EventRegistrationToken value)
    {
        return ((delegate* unmanaged<IContactStore2, EventRegistrationToken, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AggregateContactManager(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IAggregateContactManager **")]
            IAggregateContactManager* value
    )
    {
        return (
            (delegate* unmanaged<IContactStore2, IAggregateContactManager*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindContactListsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IContactStore2, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetContactListAsync(
        HSTRING contactListId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IContactStore2, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, contactListId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateContactListAsync(
        HSTRING displayName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IContactStore2, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, displayName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMeContactAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** meContact
    )
    {
        return (
            (delegate* unmanaged<IContactStore2, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[13])
        )(this, meContact);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetContactReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
            IContactReader* value
    )
    {
        return ((delegate* unmanaged<IContactStore2, IContactReader*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetContactReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")]
            IContactQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
            IContactReader* value
    )
    {
        return (
            (delegate* unmanaged<IContactStore2, IContactQueryOptions, IContactReader*, int>)(
                (*lpVtbl)[15]
            )
        )(this, options, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateContactListInAccountAsync(
        HSTRING displayName,
        HSTRING userDataAccountId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IContactStore2, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[16]
            )
        )(this, displayName, userDataAccountId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeTracker(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")]
                IContactChangeTracker* value
        );

        [VtblIndex(7)]
        HRESULT add_ContactChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactStore_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* returnValue
        );

        [VtblIndex(8)]
        HRESULT remove_ContactChanged(EventRegistrationToken value);

        [VtblIndex(9)]
        HRESULT get_AggregateContactManager(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::IAggregateContactManager **"
            )]
                IAggregateContactManager* value
        );

        [VtblIndex(10)]
        HRESULT FindContactListsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(11)]
        HRESULT GetContactListAsync(
            HSTRING contactListId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT CreateContactListAsync(
            HSTRING displayName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(13)]
        HRESULT GetMeContactAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** meContact
        );

        [VtblIndex(14)]
        HRESULT GetContactReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
                IContactReader* value
        );

        [VtblIndex(15)]
        HRESULT GetContactReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")]
                IContactQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
                IContactReader* value
        );

        [VtblIndex(16)]
        HRESULT CreateContactListInAccountAsync(
            HSTRING displayName,
            HSTRING userDataAccountId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **"
            )]
                IAsyncOperation<IntPtr>** value
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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContactChangeTracker*, int> get_ChangeTracker;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactStore_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ContactChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ContactChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IAggregateContactManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAggregateContactManager*,
            int> get_AggregateContactManager;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindContactListsAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetContactListAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateContactListAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetMeContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContactReader*, int> GetContactReader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *, ABI::Windows::ApplicationModel::Contacts::IContactReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContactQueryOptions,
            IContactReader*,
            int> GetContactReaderWithOptions;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateContactListInAccountAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactStore2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactStore2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactStore2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactStore2(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactStore2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactStore2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactStore2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactStore2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactStore2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactStore2(Silk.NET.Windows.IUnknown value)
    {
        return new IContactStore2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactStore2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactStore2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactStore2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
