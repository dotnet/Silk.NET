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

[Guid("B74BBA57-1076-4BEF-AEF3-54686D18387D")]
[NativeTypeName("struct IContactManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactManagerForUser : IContactManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactManagerForUser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactManagerForUser, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactManagerForUser, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactManagerForUser, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContactManagerForUser, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContactManagerForUser, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContactManagerForUser, TrustLevel*, int>)((*lpVtbl)[5]))(
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
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IContactManagerForUser, IContact, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, contact, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConvertContactToVCardAsyncWithMaxBytes(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("UINT32")] uint maxBytes,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerForUser,
                IContact,
                uint,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, contact, maxBytes, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertVCardToContactAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference vCard,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerForUser,
                IRandomAccessStreamReference,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, vCard, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestStoreAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")]
            ContactStoreAccessType accessType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerForUser,
                ContactStoreAccessType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, accessType, result);
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
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerForUser,
                ContactAnnotationStoreAccessType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, accessType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SystemDisplayNameOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
            ContactNameOrder* value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerForUser, ContactNameOrder*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SystemDisplayNameOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
            ContactNameOrder value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerForUser, ContactNameOrder, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SystemSortOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
            ContactNameOrder* value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerForUser, ContactNameOrder*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_SystemSortOrder(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
            ContactNameOrder value
    )
    {
        return (
            (delegate* unmanaged<IContactManagerForUser, ContactNameOrder, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value)
    {
        return ((delegate* unmanaged<IContactManagerForUser, IUser*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
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
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT ConvertContactToVCardAsyncWithMaxBytes(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("UINT32")] uint maxBytes,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT ConvertVCardToContactAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference vCard,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT RequestStoreAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")]
                ContactStoreAccessType accessType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **"
            )]
                IAsyncOperation<IntPtr>** result
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
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(11)]
        HRESULT get_SystemDisplayNameOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
                ContactNameOrder* value
        );

        [VtblIndex(12)]
        HRESULT put_SystemDisplayNameOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
                ContactNameOrder value
        );

        [VtblIndex(13)]
        HRESULT get_SystemSortOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")]
                ContactNameOrder* value
        );

        [VtblIndex(14)]
        HRESULT put_SystemSortOrder(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")]
                ContactNameOrder value
        );

        [VtblIndex(15)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value);
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
            int> RequestStoreAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ContactAnnotationStoreAccessType,
            IAsyncOperation<IntPtr>**,
            int> RequestAnnotationStoreAsync;

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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser*, int> get_User;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactManagerForUser"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactManagerForUser(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContactManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContactManagerForUser(Silk.NET.WinRT.IInspectable value)
    {
        return new IContactManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManagerForUser"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContactManagerForUser value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactManagerForUser(Silk.NET.Windows.IUnknown value)
    {
        return new IContactManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManagerForUser"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactManagerForUser value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
