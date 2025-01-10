// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AF40329B-B544-469B-86B9-AC3D466FEA36")]
[NativeTypeName("struct IHttpRequestHeaderCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpRequestHeaderCollection
    : IHttpRequestHeaderCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpRequestHeaderCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpRequestHeaderCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpRequestHeaderCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpRequestHeaderCollection, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Accept(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValueCollection **"
        )]
            IHttpMediaTypeWithQualityHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpMediaTypeWithQualityHeaderValueCollection*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AcceptEncoding(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValueCollection **"
        )]
            IHttpContentCodingWithQualityHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpContentCodingWithQualityHeaderValueCollection*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AcceptLanguage(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValueCollection **"
        )]
            IHttpLanguageRangeWithQualityHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpLanguageRangeWithQualityHeaderValueCollection*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Authorization(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")]
            IHttpCredentialsHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IHttpCredentialsHeaderValue*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Authorization(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")]
            IHttpCredentialsHeaderValue value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IHttpCredentialsHeaderValue, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CacheControl(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **"
        )]
            IHttpCacheDirectiveHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpCacheDirectiveHeaderValueCollection*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Connection(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **"
        )]
            IHttpConnectionOptionHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpConnectionOptionHeaderValueCollection*,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Cookie(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValueCollection **"
        )]
            IHttpCookiePairHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpCookiePairHeaderValueCollection*,
                int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Date(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<DateTime>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Date(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<DateTime>*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Expect(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValueCollection **"
        )]
            IHttpExpectationHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpExpectationHeaderValueCollection*,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_From(HSTRING* value)
    {
        return ((delegate* unmanaged<IHttpRequestHeaderCollection, HSTRING*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_From(HSTRING value)
    {
        return ((delegate* unmanaged<IHttpRequestHeaderCollection, HSTRING, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Host(
        [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IHostName*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_Host(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName value
    )
    {
        return ((delegate* unmanaged<IHttpRequestHeaderCollection, IHostName, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_IfModifiedSince(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<DateTime>**, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_IfModifiedSince(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<DateTime>*, int>)(
                (*lpVtbl)[22]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_IfUnmodifiedSince(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<DateTime>**, int>)(
                (*lpVtbl)[23]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_IfUnmodifiedSince(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<DateTime>*, int>)(
                (*lpVtbl)[24]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_MaxForwards(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<uint>**, int>)(
                (*lpVtbl)[25]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_MaxForwards(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IReference<uint>*, int>)(
                (*lpVtbl)[26]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ProxyAuthorization(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")]
            IHttpCredentialsHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IHttpCredentialsHeaderValue*, int>)(
                (*lpVtbl)[27]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_ProxyAuthorization(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")]
            IHttpCredentialsHeaderValue value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IHttpCredentialsHeaderValue, int>)(
                (*lpVtbl)[28]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Referer(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IUriRuntimeClass*, int>)(
                (*lpVtbl)[29]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_Referer(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, IUriRuntimeClass, int>)(
                (*lpVtbl)[30]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_TransferEncoding(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **"
        )]
            IHttpTransferCodingHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpTransferCodingHeaderValueCollection*,
                int>)((*lpVtbl)[31])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_UserAgent(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValueCollection **"
        )]
            IHttpProductInfoHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpRequestHeaderCollection,
                IHttpProductInfoHeaderValueCollection*,
                int>)((*lpVtbl)[32])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT Append(HSTRING name, HSTRING value)
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, HSTRING, HSTRING, int>)(
                (*lpVtbl)[33]
            )
        )(this, name, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT TryAppendWithoutValidation(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestHeaderCollection, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[34]
            )
        )(this, name, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Accept(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValueCollection **"
            )]
                IHttpMediaTypeWithQualityHeaderValueCollection* value
        );

        [VtblIndex(7)]
        HRESULT get_AcceptEncoding(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValueCollection **"
            )]
                IHttpContentCodingWithQualityHeaderValueCollection* value
        );

        [VtblIndex(8)]
        HRESULT get_AcceptLanguage(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValueCollection **"
            )]
                IHttpLanguageRangeWithQualityHeaderValueCollection* value
        );

        [VtblIndex(9)]
        HRESULT get_Authorization(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")]
                IHttpCredentialsHeaderValue* value
        );

        [VtblIndex(10)]
        HRESULT put_Authorization(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")]
                IHttpCredentialsHeaderValue value
        );

        [VtblIndex(11)]
        HRESULT get_CacheControl(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **"
            )]
                IHttpCacheDirectiveHeaderValueCollection* value
        );

        [VtblIndex(12)]
        HRESULT get_Connection(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **"
            )]
                IHttpConnectionOptionHeaderValueCollection* value
        );

        [VtblIndex(13)]
        HRESULT get_Cookie(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValueCollection **"
            )]
                IHttpCookiePairHeaderValueCollection* value
        );

        [VtblIndex(14)]
        HRESULT get_Date(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(15)]
        HRESULT put_Date(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(16)]
        HRESULT get_Expect(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValueCollection **"
            )]
                IHttpExpectationHeaderValueCollection* value
        );

        [VtblIndex(17)]
        HRESULT get_From(HSTRING* value);

        [VtblIndex(18)]
        HRESULT put_From(HSTRING value);

        [VtblIndex(19)]
        HRESULT get_Host(
            [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
        );

        [VtblIndex(20)]
        HRESULT put_Host([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName value);

        [VtblIndex(21)]
        HRESULT get_IfModifiedSince(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(22)]
        HRESULT put_IfModifiedSince(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(23)]
        HRESULT get_IfUnmodifiedSince(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(24)]
        HRESULT put_IfUnmodifiedSince(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(25)]
        HRESULT get_MaxForwards(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(26)]
        HRESULT put_MaxForwards(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* value
        );

        [VtblIndex(27)]
        HRESULT get_ProxyAuthorization(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")]
                IHttpCredentialsHeaderValue* value
        );

        [VtblIndex(28)]
        HRESULT put_ProxyAuthorization(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *")]
                IHttpCredentialsHeaderValue value
        );

        [VtblIndex(29)]
        HRESULT get_Referer(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(30)]
        HRESULT put_Referer(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(31)]
        HRESULT get_TransferEncoding(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **"
            )]
                IHttpTransferCodingHeaderValueCollection* value
        );

        [VtblIndex(32)]
        HRESULT get_UserAgent(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValueCollection **"
            )]
                IHttpProductInfoHeaderValueCollection* value
        );

        [VtblIndex(33)]
        HRESULT Append(HSTRING name, HSTRING value);

        [VtblIndex(34)]
        HRESULT TryAppendWithoutValidation(
            HSTRING name,
            HSTRING value,
            [NativeTypeName("boolean *")] byte* result
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
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpMediaTypeWithQualityHeaderValueCollection*,
            int> get_Accept;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpContentCodingWithQualityHeaderValueCollection*,
            int> get_AcceptEncoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpLanguageRangeWithQualityHeaderValueCollection*,
            int> get_AcceptLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCredentialsHeaderValue*, int> get_Authorization;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCredentialsHeaderValue, int> put_Authorization;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpCacheDirectiveHeaderValueCollection*,
            int> get_CacheControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpConnectionOptionHeaderValueCollection*,
            int> get_Connection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCookiePairHeaderValueCollection*, int> get_Cookie;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_Date;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_Date;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpExpectationHeaderValueCollection*, int> get_Expect;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_From;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_From;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName*, int> get_Host;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHostName, int> put_Host;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_IfModifiedSince;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_IfModifiedSince;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_IfUnmodifiedSince;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_IfUnmodifiedSince;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_MaxForwards;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>*, int> put_MaxForwards;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpCredentialsHeaderValue*,
            int> get_ProxyAuthorization;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCredentialsHeaderValue, int> put_ProxyAuthorization;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_Referer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_Referer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpTransferCodingHeaderValueCollection*,
            int> get_TransferEncoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpProductInfoHeaderValueCollection*,
            int> get_UserAgent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> Append;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> TryAppendWithoutValidation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpRequestHeaderCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpRequestHeaderCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpRequestHeaderCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpRequestHeaderCollection(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpRequestHeaderCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpRequestHeaderCollection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpRequestHeaderCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpRequestHeaderCollection value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpRequestHeaderCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpRequestHeaderCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpRequestHeaderCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpRequestHeaderCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpRequestHeaderCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpRequestHeaderCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
