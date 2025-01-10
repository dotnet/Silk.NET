// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E8FA446F-3A1B-48A4-8E90-1E59CA6F54DB")]
[NativeTypeName("struct IWebAccountMapManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountMapManagerStatics
    : IWebAccountMapManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountMapManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWebAccountMapManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAccountMapManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAccountMapManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWebAccountMapManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebAccountMapManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWebAccountMapManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddWebAccountWithScopeAndMapAsync(
        HSTRING webAccountId,
        HSTRING webAccountUserName,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")]
            IMapView<HSTRING, HSTRING>* props,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")]
            WebAccountScope scope,
        HSTRING perUserWebAccountId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountMapManagerStatics,
                HSTRING,
                HSTRING,
                IMapView<HSTRING, HSTRING>*,
                WebAccountScope,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, webAccountId, webAccountUserName, props, scope, perUserWebAccountId, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPerAppToPerUserAccountAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount perAppAccount,
        HSTRING perUserWebAccountId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountMapManagerStatics,
                IWebAccount,
                HSTRING,
                IAsyncAction*,
                int>)((*lpVtbl)[7])
        )(this, perAppAccount, perUserWebAccountId, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPerUserFromPerAppAccountAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount perAppAccount,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountMapManagerStatics,
                IWebAccount,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, perAppAccount, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearPerUserFromPerAppAccountAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount perAppAccount,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWebAccountMapManagerStatics, IWebAccount, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, perAppAccount, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddWebAccountWithScopeAndMapAsync(
            HSTRING webAccountId,
            HSTRING webAccountUserName,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *"
            )]
                IMapView<HSTRING, HSTRING>* props,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope"
            )]
                WebAccountScope scope,
            HSTRING perUserWebAccountId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(7)]
        HRESULT SetPerAppToPerUserAccountAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount perAppAccount,
            HSTRING perUserWebAccountId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(8)]
        HRESULT GetPerUserFromPerAppAccountAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount perAppAccount,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(9)]
        HRESULT ClearPerUserFromPerAppAccountAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount perAppAccount,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
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
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IMapView<HSTRING, HSTRING>*,
            WebAccountScope,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> AddWebAccountWithScopeAndMapAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            HSTRING,
            IAsyncAction*,
            int> SetPerAppToPerUserAccountAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IAsyncOperation<IntPtr>**,
            int> GetPerUserFromPerAppAccountAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IAsyncAction*,
            int> ClearPerUserFromPerAppAccountAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAccountMapManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAccountMapManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAccountMapManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAccountMapManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebAccountMapManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountMapManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountMapManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebAccountMapManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAccountMapManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAccountMapManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IWebAccountMapManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountMapManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountMapManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebAccountMapManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
