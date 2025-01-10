// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AB6BF7F8-5450-4EF6-97F7-052B0431C0F0")]
[NativeTypeName("struct IWebTokenResponseFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebTokenResponseFactory
    : IWebTokenResponseFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebTokenResponseFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebTokenResponseFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWebTokenResponseFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebTokenResponseFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWebTokenResponseFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebTokenResponseFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebTokenResponseFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithToken(
        HSTRING token,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")]
            IWebTokenResponse* webTokenResponse
    )
    {
        return (
            (delegate* unmanaged<IWebTokenResponseFactory, HSTRING, IWebTokenResponse*, int>)(
                (*lpVtbl)[6]
            )
        )(this, token, webTokenResponse);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTokenAndAccount(
        HSTRING token,
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")]
            IWebTokenResponse* webTokenResponse
    )
    {
        return (
            (delegate* unmanaged<
                IWebTokenResponseFactory,
                HSTRING,
                IWebAccount,
                IWebTokenResponse*,
                int>)((*lpVtbl)[7])
        )(this, token, webAccount, webTokenResponse);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithTokenAccountAndError(
        HSTRING token,
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *")]
            IWebProviderError error,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")]
            IWebTokenResponse* webTokenResponse
    )
    {
        return (
            (delegate* unmanaged<
                IWebTokenResponseFactory,
                HSTRING,
                IWebAccount,
                IWebProviderError,
                IWebTokenResponse*,
                int>)((*lpVtbl)[8])
        )(this, token, webAccount, error, webTokenResponse);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithToken(
            HSTRING token,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **"
            )]
                IWebTokenResponse* webTokenResponse
        );

        [VtblIndex(7)]
        HRESULT CreateWithTokenAndAccount(
            HSTRING token,
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **"
            )]
                IWebTokenResponse* webTokenResponse
        );

        [VtblIndex(8)]
        HRESULT CreateWithTokenAccountAndError(
            HSTRING token,
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *"
            )]
                IWebProviderError error,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **"
            )]
                IWebTokenResponse* webTokenResponse
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
            "HRESULT (HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IWebTokenResponse*, int> CreateWithToken;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IWebAccount,
            IWebTokenResponse*,
            int> CreateWithTokenAndAccount;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *, ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IWebAccount,
            IWebProviderError,
            IWebTokenResponse*,
            int> CreateWithTokenAccountAndError;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebTokenResponseFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebTokenResponseFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebTokenResponseFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebTokenResponseFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebTokenResponseFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebTokenResponseFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebTokenResponseFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebTokenResponseFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebTokenResponseFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebTokenResponseFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IWebTokenResponseFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebTokenResponseFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebTokenResponseFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebTokenResponseFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
