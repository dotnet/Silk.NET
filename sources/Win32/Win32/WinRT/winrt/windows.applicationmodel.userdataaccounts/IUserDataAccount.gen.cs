// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B9C4367E-B348-4910-BE94-4AD4BBA6DEA7")]
[NativeTypeName("struct IUserDataAccount : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccount : IUserDataAccount.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccount));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserDataAccount, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUserDataAccount, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataAccount, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUserDataAccount, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserDataAccount, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserDataAccount, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataAccount, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UserDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataAccount, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_UserDisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IUserDataAccount, HSTRING, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_OtherAppReadAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess *"
        )]
            UserDataAccountOtherAppReadAccess* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccount, UserDataAccountOtherAppReadAccess*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_OtherAppReadAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess"
        )]
            UserDataAccountOtherAppReadAccess value
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccount, UserDataAccountOtherAppReadAccess, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Icon(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccount, IRandomAccessStreamReference*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DeviceAccountTypeId(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataAccount, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged<IUserDataAccount, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SaveAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IUserDataAccount, IAsyncAction*, int>)((*lpVtbl)[14]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IUserDataAccount, IAsyncAction*, int>)((*lpVtbl)[15]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FindAppointmentCalendarsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccount, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[16])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT FindEmailMailboxesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccount, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[17])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FindContactListsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccount, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[18])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FindContactAnnotationListsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccount, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[19])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_UserDisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_UserDisplayName(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess *"
            )]
                UserDataAccountOtherAppReadAccess* value
        );

        [VtblIndex(10)]
        HRESULT put_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess"
            )]
                UserDataAccountOtherAppReadAccess value
        );

        [VtblIndex(11)]
        HRESULT get_Icon(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(12)]
        HRESULT get_DeviceAccountTypeId(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_PackageFamilyName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT SaveAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(15)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(16)]
        HRESULT FindAppointmentCalendarsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(17)]
        HRESULT FindEmailMailboxesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(18)]
        HRESULT FindContactListsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(19)]
        HRESULT FindContactAnnotationListsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **"
            )]
                IAsyncOperation<IntPtr>** result
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserDisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_UserDisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UserDataAccountOtherAppReadAccess*,
            int> get_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UserDataAccountOtherAppReadAccess,
            int> put_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_Icon;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceAccountTypeId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PackageFamilyName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> SaveAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> FindAppointmentCalendarsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindEmailMailboxesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindContactListsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> FindContactAnnotationListsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataAccount"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataAccount(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserDataAccount"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserDataAccount(Silk.NET.WinRT.IInspectable value)
    {
        return new IUserDataAccount(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataAccount"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataAccount"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUserDataAccount value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataAccount"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataAccount(Silk.NET.Windows.IUnknown value)
    {
        return new IUserDataAccount(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataAccount"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataAccount"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserDataAccount value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
