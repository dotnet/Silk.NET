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

[Guid("5F16B627-04C4-5F0B-8683-8BAB58965656")]
[NativeTypeName("struct IWebAuthenticationTransferTokenRequestFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationTransferTokenRequestFactory
    : IWebAuthenticationTransferTokenRequestFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IWebAuthenticationTransferTokenRequestFactory)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationTransferTokenRequestFactory,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IWebAuthenticationTransferTokenRequestFactory, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IWebAuthenticationTransferTokenRequestFactory, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<
                IWebAuthenticationTransferTokenRequestFactory,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationTransferTokenRequestFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationTransferTokenRequestFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
            IWebAccountProvider provider,
        HSTRING transferToken,
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **"
        )]
            IWebAuthenticationTransferTokenRequest* value
    )
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationTransferTokenRequestFactory,
                IWebAccountProvider,
                HSTRING,
                IWebAuthenticationTransferTokenRequest*,
                int>)((*lpVtbl)[6])
        )(this, provider, transferToken, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithCorrelationId(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
            IWebAccountProvider provider,
        HSTRING transferToken,
        HSTRING correlationId,
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **"
        )]
            IWebAuthenticationTransferTokenRequest* value
    )
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationTransferTokenRequestFactory,
                IWebAccountProvider,
                HSTRING,
                HSTRING,
                IWebAuthenticationTransferTokenRequest*,
                int>)((*lpVtbl)[7])
        )(this, provider, transferToken, correlationId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
                IWebAccountProvider provider,
            HSTRING transferToken,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **"
            )]
                IWebAuthenticationTransferTokenRequest* value
        );

        [VtblIndex(7)]
        HRESULT CreateWithCorrelationId(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
                IWebAccountProvider provider,
            HSTRING transferToken,
            HSTRING correlationId,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **"
            )]
                IWebAuthenticationTransferTokenRequest* value
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
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccountProvider,
            HSTRING,
            IWebAuthenticationTransferTokenRequest*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccountProvider,
            HSTRING,
            HSTRING,
            IWebAuthenticationTransferTokenRequest*,
            int> CreateWithCorrelationId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAuthenticationTransferTokenRequestFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAuthenticationTransferTokenRequestFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAuthenticationTransferTokenRequestFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationTransferTokenRequestFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWebAuthenticationTransferTokenRequestFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationTransferTokenRequestFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationTransferTokenRequestFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWebAuthenticationTransferTokenRequestFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAuthenticationTransferTokenRequestFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationTransferTokenRequestFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWebAuthenticationTransferTokenRequestFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationTransferTokenRequestFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationTransferTokenRequestFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWebAuthenticationTransferTokenRequestFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
