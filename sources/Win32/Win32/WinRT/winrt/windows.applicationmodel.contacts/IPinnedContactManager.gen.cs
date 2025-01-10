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

[Guid("FCBC740C-E1D6-45C3-B8B6-A35604E167A0")]
[NativeTypeName("struct IPinnedContactManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPinnedContactManager : IPinnedContactManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPinnedContactManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPinnedContactManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPinnedContactManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPinnedContactManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPinnedContactManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPinnedContactManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPinnedContactManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* user)
    {
        return ((delegate* unmanaged<IPinnedContactManager, IUser*, int>)((*lpVtbl)[6]))(
            this,
            user
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsPinSurfaceSupported(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
            PinnedContactSurface surface,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IPinnedContactManager, PinnedContactSurface, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, surface, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsContactPinned(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
            PinnedContactSurface surface,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<
                IPinnedContactManager,
                IContact,
                PinnedContactSurface,
                byte*,
                int>)((*lpVtbl)[8])
        )(this, contact, surface, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestPinContactAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
            PinnedContactSurface surface,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPinnedContactManager,
                IContact,
                PinnedContactSurface,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[9])
        )(this, contact, surface, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestPinContactsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CContacts__CContact_t *"
        )]
            IIterable<IntPtr>* contacts,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
            PinnedContactSurface surface,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPinnedContactManager,
                IIterable<IntPtr>*,
                PinnedContactSurface,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[10])
        )(this, contacts, surface, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestUnpinContactAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact,
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
            PinnedContactSurface surface,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPinnedContactManager,
                IContact,
                PinnedContactSurface,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[11])
        )(this, contact, surface, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SignalContactActivity(
        [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact contact
    )
    {
        return ((delegate* unmanaged<IPinnedContactManager, IContact, int>)((*lpVtbl)[12]))(
            this,
            contact
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPinnedContactIdsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CPinnedContactIdsQueryResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IPinnedContactManager, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* user);

        [VtblIndex(7)]
        HRESULT IsPinSurfaceSupported(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
                PinnedContactSurface surface,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(8)]
        HRESULT IsContactPinned(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
                PinnedContactSurface surface,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(9)]
        HRESULT RequestPinContactAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
                PinnedContactSurface surface,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(10)]
        HRESULT RequestPinContactsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CContacts__CContact_t *"
            )]
                IIterable<IntPtr>* contacts,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
                PinnedContactSurface surface,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(11)]
        HRESULT RequestUnpinContactAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact,
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface")]
                PinnedContactSurface surface,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(12)]
        HRESULT SignalContactActivity(
            [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")]
                IContact contact
        );

        [VtblIndex(13)]
        HRESULT GetPinnedContactIdsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CPinnedContactIdsQueryResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser*, int> get_User;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PinnedContactSurface, byte*, int> IsPinSurfaceSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            PinnedContactSurface,
            byte*,
            int> IsContactPinned;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            PinnedContactSurface,
            IAsyncOperation<byte>**,
            int> RequestPinContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CContacts__CContact_t *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            PinnedContactSurface,
            IAsyncOperation<byte>**,
            int> RequestPinContactsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::PinnedContactSurface, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContact,
            PinnedContactSurface,
            IAsyncOperation<byte>**,
            int> RequestUnpinContactAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContact, int> SignalContactActivity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CPinnedContactIdsQueryResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetPinnedContactIdsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPinnedContactManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPinnedContactManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPinnedContactManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPinnedContactManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IPinnedContactManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPinnedContactManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPinnedContactManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPinnedContactManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPinnedContactManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPinnedContactManager(Silk.NET.Windows.IUnknown value)
    {
        return new IPinnedContactManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPinnedContactManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPinnedContactManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPinnedContactManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
