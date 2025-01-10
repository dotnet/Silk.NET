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

[Guid("16DDEC75-392C-4845-9DFB-51A3E7EF3E42")]
[NativeTypeName("struct IContactList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactList : IContactList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactList, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactList, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactList, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactList, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IContactList, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IContactList, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IContactList, HSTRING, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IContactList, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IContactList, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsHidden([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IContactList, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_OtherAppReadAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess *"
        )]
            ContactListOtherAppReadAccess* value
    )
    {
        return (
            (delegate* unmanaged<IContactList, ContactListOtherAppReadAccess*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_OtherAppReadAccess(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess")]
            ContactListOtherAppReadAccess value
    )
    {
        return (
            (delegate* unmanaged<IContactList, ContactListOtherAppReadAccess, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_OtherAppWriteAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess *"
        )]
            ContactListOtherAppWriteAccess* value
    )
    {
        return (
            (delegate* unmanaged<IContactList, ContactListOtherAppWriteAccess*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_OtherAppWriteAccess(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess")]
            ContactListOtherAppWriteAccess value
    )
    {
        return (
            (delegate* unmanaged<IContactList, ContactListOtherAppWriteAccess, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ChangeTracker(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")]
            IContactChangeTracker* value
    )
    {
        return ((delegate* unmanaged<IContactList, IContactChangeTracker*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SyncManager(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactListSyncManager **")]
            IContactListSyncManager* value
    )
    {
        return ((delegate* unmanaged<IContactList, IContactListSyncManager*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SupportsServerSearch([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IContactList, byte*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged<IContactList, HSTRING*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_ContactChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactList_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* returnValue
    )
    {
        return (
            (delegate* unmanaged<
                IContactList,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[20])
        )(this, value, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_ContactChanged(EventRegistrationToken value)
    {
        return ((delegate* unmanaged<IContactList, EventRegistrationToken, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SaveAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
    )
    {
        return ((delegate* unmanaged<IContactList, IAsyncAction*, int>)((*lpVtbl)[22]))(
            this,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
    )
    {
        return ((delegate* unmanaged<IContactList, IAsyncAction*, int>)((*lpVtbl)[23]))(
            this,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetContactFromRemoteIdAsync(
        HSTRING remoteId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** contact
    )
    {
        return (
            (delegate* unmanaged<IContactList, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[24]
            )
        )(this, remoteId, contact);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetMeContactAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** meContact
    )
    {
        return ((delegate* unmanaged<IContactList, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[25]))(
            this,
            meContact
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetContactReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
            IContactReader* value
    )
    {
        return ((delegate* unmanaged<IContactList, IContactReader*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetContactReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")]
            IContactQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
            IContactReader* value
    )
    {
        return (
            (delegate* unmanaged<IContactList, IContactQueryOptions, IContactReader*, int>)(
                (*lpVtbl)[27]
            )
        )(this, options, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SaveContactAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IContactList, IContact, IAsyncAction*, int>)((*lpVtbl)[28]))(
            this,
            contact,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT DeleteContactAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IContactList, IContact, IAsyncAction*, int>)((*lpVtbl)[29]))(
            this,
            contact,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetContactAsync(
        HSTRING contactId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** contacts
    )
    {
        return (
            (delegate* unmanaged<IContactList, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[30]
            )
        )(this, contactId, contacts);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsHidden([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess *"
            )]
                ContactListOtherAppReadAccess* value
        );

        [VtblIndex(13)]
        HRESULT put_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess"
            )]
                ContactListOtherAppReadAccess value
        );

        [VtblIndex(14)]
        HRESULT get_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess *"
            )]
                ContactListOtherAppWriteAccess* value
        );

        [VtblIndex(15)]
        HRESULT put_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess"
            )]
                ContactListOtherAppWriteAccess value
        );

        [VtblIndex(16)]
        HRESULT get_ChangeTracker(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")]
                IContactChangeTracker* value
        );

        [VtblIndex(17)]
        HRESULT get_SyncManager(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactListSyncManager **")]
                IContactListSyncManager* value
        );

        [VtblIndex(18)]
        HRESULT get_SupportsServerSearch([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(20)]
        HRESULT add_ContactChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactList_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* returnValue
        );

        [VtblIndex(21)]
        HRESULT remove_ContactChanged(EventRegistrationToken value);

        [VtblIndex(22)]
        HRESULT SaveAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
        );

        [VtblIndex(23)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
        );

        [VtblIndex(24)]
        HRESULT GetContactFromRemoteIdAsync(
            HSTRING remoteId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** contact
        );

        [VtblIndex(25)]
        HRESULT GetMeContactAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** meContact
        );

        [VtblIndex(26)]
        HRESULT GetContactReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
                IContactReader* value
        );

        [VtblIndex(27)]
        HRESULT GetContactReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")]
                IContactQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")]
                IContactReader* value
        );

        [VtblIndex(28)]
        HRESULT SaveContactAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(29)]
        HRESULT DeleteContactAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(30)]
        HRESULT GetContactAsync(
            HSTRING contactId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** contacts
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsHidden;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsHidden;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ContactListOtherAppReadAccess*,
            int> get_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ContactListOtherAppReadAccess,
            int> put_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ContactListOtherAppWriteAccess*,
            int> get_OtherAppWriteAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ContactListOtherAppWriteAccess,
            int> put_OtherAppWriteAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContactChangeTracker*, int> get_ChangeTracker;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactListSyncManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContactListSyncManager*, int> get_SyncManager;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SupportsServerSearch;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserDataAccountId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactList_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ContactChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ContactChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> SaveAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetContactFromRemoteIdAsync;

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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContact, IAsyncAction*, int> SaveContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContact, IAsyncAction*, int> DeleteContactAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetContactAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactList(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactList"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactList"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactList value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactList(Silk.NET.Windows.IUnknown value)
    {
        return new IContactList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
