// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E2CC1366-CF66-43C4-A96A-A5A112DB4746")]
[NativeTypeName("struct IContactPickerUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactPickerUI : IContactPickerUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactPickerUI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactPickerUI, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactPickerUI, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactPickerUI, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactPickerUI, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactPickerUI, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactPickerUI, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID."
    )]
    public HRESULT AddContact(
        HSTRING id,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *")]
            AddContactResult* result
    )
    {
        return (
            (delegate* unmanaged<IContactPickerUI, HSTRING, IContact, AddContactResult*, int>)(
                (*lpVtbl)[6]
            )
        )(this, id, contact, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveContact(HSTRING id)
    {
        return ((delegate* unmanaged<IContactPickerUI, HSTRING, int>)((*lpVtbl)[7]))(this, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ContainsContact(HSTRING id, [NativeTypeName("boolean *")] byte* isContained)
    {
        return ((delegate* unmanaged<IContactPickerUI, HSTRING, byte*, int>)((*lpVtbl)[8]))(
            this,
            id,
            isContained
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType."
    )]
    public HRESULT get_DesiredFields(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IContactPickerUI, IVectorView<HSTRING>**, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SelectionMode(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")]
            ContactSelectionMode* value
    )
    {
        return ((delegate* unmanaged<IContactPickerUI, ContactSelectionMode*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ContactRemoved(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CProvider__CContactPickerUI_Windows__CApplicationModel__CContacts__CProvider__CContactRemovedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IContactPickerUI,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ContactRemoved(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IContactPickerUI, EventRegistrationToken, int>)((*lpVtbl)[12])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID."
        )]
        HRESULT AddContact(
            HSTRING id,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *"
            )]
                AddContactResult* result
        );

        [VtblIndex(7)]
        HRESULT RemoveContact(HSTRING id);

        [VtblIndex(8)]
        HRESULT ContainsContact(HSTRING id, [NativeTypeName("boolean *")] byte* isContained);

        [VtblIndex(9)]
        [Obsolete(
            "DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType."
        )]
        HRESULT get_DesiredFields(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** value
        );

        [VtblIndex(10)]
        HRESULT get_SelectionMode(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")]
                ContactSelectionMode* value
        );

        [VtblIndex(11)]
        HRESULT add_ContactRemoved(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CProvider__CContactPickerUI_Windows__CApplicationModel__CContacts__CProvider__CContactRemovedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_ContactRemoved(EventRegistrationToken token);
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
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IContact, AddContactResult*, int> AddContact;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> RemoveContact;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> ContainsContact;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType."
        )]
        public delegate* unmanaged<TSelf*, IVectorView<HSTRING>**, int> get_DesiredFields;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ContactSelectionMode*, int> get_SelectionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CProvider__CContactPickerUI_Windows__CApplicationModel__CContacts__CProvider__CContactRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ContactRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ContactRemoved;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactPickerUI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactPickerUI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactPickerUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactPickerUI(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactPickerUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactPickerUI"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactPickerUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactPickerUI value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactPickerUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactPickerUI(Silk.NET.Windows.IUnknown value)
    {
        return new IContactPickerUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactPickerUI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactPickerUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactPickerUI value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
