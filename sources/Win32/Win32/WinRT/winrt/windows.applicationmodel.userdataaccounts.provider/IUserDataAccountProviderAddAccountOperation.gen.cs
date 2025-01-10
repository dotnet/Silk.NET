// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdataaccounts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B9C72530-3F84-4B5D-8EAA-45E97AA842ED")]
[NativeTypeName("struct IUserDataAccountProviderAddAccountOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountProviderAddAccountOperation
    : IUserDataAccountProviderAddAccountOperation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountProviderAddAccountOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUserDataAccountProviderAddAccountOperation, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IUserDataAccountProviderAddAccountOperation, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IUserDataAccountProviderAddAccountOperation, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccountProviderAddAccountOperation, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IUserDataAccountProviderAddAccountOperation, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IUserDataAccountProviderAddAccountOperation, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentKinds(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds *"
        )]
            UserDataAccountContentKinds* value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataAccountProviderAddAccountOperation,
                UserDataAccountContentKinds*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PartnerAccountInfos(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CProvider__CUserDataAccountPartnerAccountInfo_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataAccountProviderAddAccountOperation,
                IVectorView<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReportCompleted(HSTRING userDataAccountId)
    {
        return (
            (delegate* unmanaged<IUserDataAccountProviderAddAccountOperation, HSTRING, int>)(
                (*lpVtbl)[8]
            )
        )(this, userDataAccountId);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentKinds(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds *"
            )]
                UserDataAccountContentKinds* value
        );

        [VtblIndex(7)]
        HRESULT get_PartnerAccountInfos(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CProvider__CUserDataAccountPartnerAccountInfo_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT ReportCompleted(HSTRING userDataAccountId);
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
            "HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserDataAccountContentKinds*, int> get_ContentKinds;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CProvider__CUserDataAccountPartnerAccountInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_PartnerAccountInfos;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ReportCompleted;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataAccountProviderAddAccountOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataAccountProviderAddAccountOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserDataAccountProviderAddAccountOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserDataAccountProviderAddAccountOperation(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IUserDataAccountProviderAddAccountOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataAccountProviderAddAccountOperation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataAccountProviderAddAccountOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IUserDataAccountProviderAddAccountOperation value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataAccountProviderAddAccountOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataAccountProviderAddAccountOperation(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IUserDataAccountProviderAddAccountOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataAccountProviderAddAccountOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataAccountProviderAddAccountOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IUserDataAccountProviderAddAccountOperation value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
