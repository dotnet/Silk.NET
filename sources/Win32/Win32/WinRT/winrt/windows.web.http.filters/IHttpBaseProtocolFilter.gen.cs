// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("71C89B09-E131-4B54-A53C-EB43FF37E9BB")]
[NativeTypeName("struct IHttpBaseProtocolFilter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpBaseProtocolFilter
    : IHttpBaseProtocolFilter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpBaseProtocolFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllowAutoRedirect([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllowAutoRedirect([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AllowUI([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AllowUI([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AutomaticDecompression([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AutomaticDecompression([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CacheControl(
        [NativeTypeName("ABI::Windows::Web::Http::Filters::IHttpCacheControl **")]
            IHttpCacheControl* value
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilter, IHttpCacheControl*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CookieManager(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpCookieManager **")] IHttpCookieManager* value
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilter, IHttpCookieManager*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ClientCertificate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")]
            ICertificate* value
    )
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, ICertificate*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ClientCertificate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
            ICertificate value
    )
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, ICertificate, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IgnorableServerCertificateErrors(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **"
        )]
            IVector<ChainValidationResult>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilter, IVector<ChainValidationResult>**, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_MaxConnectionsPerServer([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, uint*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_MaxConnectionsPerServer([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, uint, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ProxyCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
            IPasswordCredential* value
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilter, IPasswordCredential*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ProxyCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential value
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilter, IPasswordCredential, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ServerCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
            IPasswordCredential* value
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilter, IPasswordCredential*, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_ServerCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential value
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilter, IPasswordCredential, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_UseProxy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_UseProxy([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilter, byte, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllowAutoRedirect([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AllowAutoRedirect([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_AllowUI([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_AllowUI([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_AutomaticDecompression([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_AutomaticDecompression([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_CacheControl(
            [NativeTypeName("ABI::Windows::Web::Http::Filters::IHttpCacheControl **")]
                IHttpCacheControl* value
        );

        [VtblIndex(13)]
        HRESULT get_CookieManager(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpCookieManager **")]
                IHttpCookieManager* value
        );

        [VtblIndex(14)]
        HRESULT get_ClientCertificate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")]
                ICertificate* value
        );

        [VtblIndex(15)]
        HRESULT put_ClientCertificate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
                ICertificate value
        );

        [VtblIndex(16)]
        HRESULT get_IgnorableServerCertificateErrors(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **"
            )]
                IVector<ChainValidationResult>** value
        );

        [VtblIndex(17)]
        HRESULT get_MaxConnectionsPerServer([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(18)]
        HRESULT put_MaxConnectionsPerServer([NativeTypeName("UINT32")] uint value);

        [VtblIndex(19)]
        HRESULT get_ProxyCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
                IPasswordCredential* value
        );

        [VtblIndex(20)]
        HRESULT put_ProxyCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential value
        );

        [VtblIndex(21)]
        HRESULT get_ServerCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
                IPasswordCredential* value
        );

        [VtblIndex(22)]
        HRESULT put_ServerCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential value
        );

        [VtblIndex(23)]
        HRESULT get_UseProxy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(24)]
        HRESULT put_UseProxy([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllowAutoRedirect;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AllowAutoRedirect;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllowUI;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AllowUI;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AutomaticDecompression;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AutomaticDecompression;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Filters::IHttpCacheControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCacheControl*, int> get_CacheControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpCookieManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCookieManager*, int> get_CookieManager;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICertificate*, int> get_ClientCertificate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICertificate, int> put_ClientCertificate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVector<ChainValidationResult>**,
            int> get_IgnorableServerCertificateErrors;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MaxConnectionsPerServer;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_MaxConnectionsPerServer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential*, int> get_ProxyCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> put_ProxyCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential*, int> get_ServerCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> put_ServerCredential;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UseProxy;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_UseProxy;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpBaseProtocolFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpBaseProtocolFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpBaseProtocolFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpBaseProtocolFilter(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpBaseProtocolFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpBaseProtocolFilter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpBaseProtocolFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpBaseProtocolFilter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpBaseProtocolFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpBaseProtocolFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpBaseProtocolFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpBaseProtocolFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpBaseProtocolFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpBaseProtocolFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
