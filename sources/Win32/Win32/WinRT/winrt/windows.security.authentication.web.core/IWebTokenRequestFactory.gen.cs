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

[Guid("6CF2141C-0FF0-4C67-B84F-99DDBE4A72C9")]
[NativeTypeName("struct IWebTokenRequestFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebTokenRequestFactory
    : IWebTokenRequestFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebTokenRequestFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebTokenRequestFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWebTokenRequestFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebTokenRequestFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWebTokenRequestFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebTokenRequestFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebTokenRequestFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
            IWebAccountProvider provider,
        HSTRING scope,
        HSTRING clientId,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")]
            IWebTokenRequest* webTokenRequest
    )
    {
        return (
            (delegate* unmanaged<
                IWebTokenRequestFactory,
                IWebAccountProvider,
                HSTRING,
                HSTRING,
                IWebTokenRequest*,
                int>)((*lpVtbl)[6])
        )(this, provider, scope, clientId, webTokenRequest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithPromptType(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
            IWebAccountProvider provider,
        HSTRING scope,
        HSTRING clientId,
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType"
        )]
            WebTokenRequestPromptType promptType,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")]
            IWebTokenRequest* webTokenRequest
    )
    {
        return (
            (delegate* unmanaged<
                IWebTokenRequestFactory,
                IWebAccountProvider,
                HSTRING,
                HSTRING,
                WebTokenRequestPromptType,
                IWebTokenRequest*,
                int>)((*lpVtbl)[7])
        )(this, provider, scope, clientId, promptType, webTokenRequest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithProvider(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
            IWebAccountProvider provider,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")]
            IWebTokenRequest* webTokenRequest
    )
    {
        return (
            (delegate* unmanaged<
                IWebTokenRequestFactory,
                IWebAccountProvider,
                IWebTokenRequest*,
                int>)((*lpVtbl)[8])
        )(this, provider, webTokenRequest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateWithScope(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
            IWebAccountProvider provider,
        HSTRING scope,
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")]
            IWebTokenRequest* webTokenRequest
    )
    {
        return (
            (delegate* unmanaged<
                IWebTokenRequestFactory,
                IWebAccountProvider,
                HSTRING,
                IWebTokenRequest*,
                int>)((*lpVtbl)[9])
        )(this, provider, scope, webTokenRequest);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
                IWebAccountProvider provider,
            HSTRING scope,
            HSTRING clientId,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **"
            )]
                IWebTokenRequest* webTokenRequest
        );

        [VtblIndex(7)]
        HRESULT CreateWithPromptType(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
                IWebAccountProvider provider,
            HSTRING scope,
            HSTRING clientId,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType"
            )]
                WebTokenRequestPromptType promptType,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **"
            )]
                IWebTokenRequest* webTokenRequest
        );

        [VtblIndex(8)]
        HRESULT CreateWithProvider(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
                IWebAccountProvider provider,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **"
            )]
                IWebTokenRequest* webTokenRequest
        );

        [VtblIndex(9)]
        HRESULT CreateWithScope(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")]
                IWebAccountProvider provider,
            HSTRING scope,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **"
            )]
                IWebTokenRequest* webTokenRequest
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
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccountProvider,
            HSTRING,
            HSTRING,
            IWebTokenRequest*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, HSTRING, ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccountProvider,
            HSTRING,
            HSTRING,
            WebTokenRequestPromptType,
            IWebTokenRequest*,
            int> CreateWithPromptType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccountProvider,
            IWebTokenRequest*,
            int> CreateWithProvider;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccountProvider,
            HSTRING,
            IWebTokenRequest*,
            int> CreateWithScope;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebTokenRequestFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebTokenRequestFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebTokenRequestFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebTokenRequestFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebTokenRequestFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebTokenRequestFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebTokenRequestFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebTokenRequestFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebTokenRequestFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebTokenRequestFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IWebTokenRequestFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebTokenRequestFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebTokenRequestFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebTokenRequestFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
