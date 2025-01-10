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

[Guid("0379D5DD-DB5A-4FD3-B54E-4DF17917A212")]
[NativeTypeName("struct IAggregateContactManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAggregateContactManager
    : IAggregateContactManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAggregateContactManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAggregateContactManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAggregateContactManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAggregateContactManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAggregateContactManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAggregateContactManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAggregateContactManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindRawContactsAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAggregateContactManager,
                IContact,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, contact, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryLinkContactsAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
            IContact primaryContact,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
            IContact secondaryContact,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
        )]
            IAsyncOperation<IntPtr>** contact
    )
    {
        return (
            (delegate* unmanaged<
                IAggregateContactManager,
                IContact,
                IContact,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, primaryContact, secondaryContact, contact);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnlinkRawContactAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<IAggregateContactManager, IContact, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, contact, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TrySetPreferredSourceForPictureAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
            IContact aggregateContact,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
            IContact rawContact,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAggregateContactManager,
                IContact,
                IContact,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[9])
        )(this, aggregateContact, rawContact, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindRawContactsAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT TryLinkContactsAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact primaryContact,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact secondaryContact,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **"
            )]
                IAsyncOperation<IntPtr>** contact
        );

        [VtblIndex(8)]
        HRESULT UnlinkRawContactAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(9)]
        HRESULT TrySetPreferredSourceForPictureAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact aggregateContact,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact rawContact,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** value
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
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            IAsyncOperation<IntPtr>**,
            int> FindRawContactsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            IContact,
            IAsyncOperation<IntPtr>**,
            int> TryLinkContactsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContact, IAsyncAction*, int> UnlinkRawContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            IContact,
            IAsyncOperation<byte>**,
            int> TrySetPreferredSourceForPictureAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAggregateContactManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAggregateContactManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAggregateContactManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAggregateContactManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IAggregateContactManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAggregateContactManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAggregateContactManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAggregateContactManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAggregateContactManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAggregateContactManager(Silk.NET.Windows.IUnknown value)
    {
        return new IAggregateContactManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAggregateContactManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAggregateContactManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAggregateContactManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
