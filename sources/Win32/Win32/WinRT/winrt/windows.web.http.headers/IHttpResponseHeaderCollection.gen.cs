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

[Guid("7A990969-FA3F-41ED-AAC6-BF957975C16B")]
[NativeTypeName("struct IHttpResponseHeaderCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpResponseHeaderCollection
    : IHttpResponseHeaderCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpResponseHeaderCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpResponseHeaderCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpResponseHeaderCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpResponseHeaderCollection, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Age(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
        )]
            IReference<TimeSpan>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IReference<TimeSpan>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Age(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *"
        )]
            IReference<TimeSpan>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IReference<TimeSpan>*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Allow(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMethodHeaderValueCollection **")]
            IHttpMethodHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpResponseHeaderCollection,
                IHttpMethodHeaderValueCollection*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CacheControl(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **"
        )]
            IHttpCacheDirectiveHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpResponseHeaderCollection,
                IHttpCacheDirectiveHeaderValueCollection*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Connection(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **"
        )]
            IHttpConnectionOptionHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpResponseHeaderCollection,
                IHttpConnectionOptionHeaderValueCollection*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Date(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IReference<DateTime>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Date(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IReference<DateTime>*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Location(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IUriRuntimeClass*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Location(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IUriRuntimeClass, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ProxyAuthenticate(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **")]
            IHttpChallengeHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpResponseHeaderCollection,
                IHttpChallengeHeaderValueCollection*,
                int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RetryAfter(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")]
            IHttpDateOrDeltaHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IHttpDateOrDeltaHeaderValue*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_RetryAfter(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue *")]
            IHttpDateOrDeltaHeaderValue value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, IHttpDateOrDeltaHeaderValue, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_TransferEncoding(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **"
        )]
            IHttpTransferCodingHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpResponseHeaderCollection,
                IHttpTransferCodingHeaderValueCollection*,
                int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_WwwAuthenticate(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **")]
            IHttpChallengeHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpResponseHeaderCollection,
                IHttpChallengeHeaderValueCollection*,
                int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Append(HSTRING name, HSTRING value)
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, HSTRING, HSTRING, int>)(
                (*lpVtbl)[20]
            )
        )(this, name, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT TryAppendWithoutValidation(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseHeaderCollection, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[21]
            )
        )(this, name, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Age(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
            )]
                IReference<TimeSpan>** value
        );

        [VtblIndex(7)]
        HRESULT put_Age(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *"
            )]
                IReference<TimeSpan>* value
        );

        [VtblIndex(8)]
        HRESULT get_Allow(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpMethodHeaderValueCollection **"
            )]
                IHttpMethodHeaderValueCollection* value
        );

        [VtblIndex(9)]
        HRESULT get_CacheControl(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpCacheDirectiveHeaderValueCollection **"
            )]
                IHttpCacheDirectiveHeaderValueCollection* value
        );

        [VtblIndex(10)]
        HRESULT get_Connection(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpConnectionOptionHeaderValueCollection **"
            )]
                IHttpConnectionOptionHeaderValueCollection* value
        );

        [VtblIndex(11)]
        HRESULT get_Date(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(12)]
        HRESULT put_Date(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(13)]
        HRESULT get_Location(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(14)]
        HRESULT put_Location(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(15)]
        HRESULT get_ProxyAuthenticate(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **"
            )]
                IHttpChallengeHeaderValueCollection* value
        );

        [VtblIndex(16)]
        HRESULT get_RetryAfter(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")]
                IHttpDateOrDeltaHeaderValue* value
        );

        [VtblIndex(17)]
        HRESULT put_RetryAfter(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue *")]
                IHttpDateOrDeltaHeaderValue value
        );

        [VtblIndex(18)]
        HRESULT get_TransferEncoding(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **"
            )]
                IHttpTransferCodingHeaderValueCollection* value
        );

        [VtblIndex(19)]
        HRESULT get_WwwAuthenticate(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **"
            )]
                IHttpChallengeHeaderValueCollection* value
        );

        [VtblIndex(20)]
        HRESULT Append(HSTRING name, HSTRING value);

        [VtblIndex(21)]
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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>**, int> get_Age;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>*, int> put_Age;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpMethodHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethodHeaderValueCollection*, int> get_Allow;

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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_Date;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_Date;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_Location;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_Location;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpChallengeHeaderValueCollection*,
            int> get_ProxyAuthenticate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpDateOrDeltaHeaderValue*, int> get_RetryAfter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpDateOrDeltaHeaderValue, int> put_RetryAfter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpTransferCodingHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpTransferCodingHeaderValueCollection*,
            int> get_TransferEncoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpChallengeHeaderValueCollection*,
            int> get_WwwAuthenticate;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> Append;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> TryAppendWithoutValidation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpResponseHeaderCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpResponseHeaderCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpResponseHeaderCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpResponseHeaderCollection(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpResponseHeaderCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpResponseHeaderCollection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpResponseHeaderCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpResponseHeaderCollection value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpResponseHeaderCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpResponseHeaderCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpResponseHeaderCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpResponseHeaderCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpResponseHeaderCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpResponseHeaderCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
