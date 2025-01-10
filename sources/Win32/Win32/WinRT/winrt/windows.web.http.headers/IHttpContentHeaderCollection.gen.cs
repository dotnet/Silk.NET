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

[Guid("40612A44-47AE-4B7E-9124-69628B64AA18")]
[NativeTypeName("struct IHttpContentHeaderCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContentHeaderCollection
    : IHttpContentHeaderCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContentHeaderCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpContentHeaderCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpContentHeaderCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpContentHeaderCollection, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentDisposition(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentDispositionHeaderValue **")]
            IHttpContentDispositionHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContentHeaderCollection,
                IHttpContentDispositionHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ContentDisposition(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentDispositionHeaderValue *")]
            IHttpContentDispositionHeaderValue value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContentHeaderCollection,
                IHttpContentDispositionHeaderValue,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContentEncoding(
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpContentCodingHeaderValueCollection **"
        )]
            IHttpContentCodingHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContentHeaderCollection,
                IHttpContentCodingHeaderValueCollection*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ContentLanguage(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageHeaderValueCollection **")]
            IHttpLanguageHeaderValueCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContentHeaderCollection,
                IHttpLanguageHeaderValueCollection*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ContentLength(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IReference<ulong>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ContentLength(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
            IReference<ulong>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IReference<ulong>*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ContentLocation(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IUriRuntimeClass*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ContentLocation(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IUriRuntimeClass, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ContentMD5(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IHttpContentHeaderCollection, IBuffer*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ContentMD5(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
    )
    {
        return ((delegate* unmanaged<IHttpContentHeaderCollection, IBuffer, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ContentRange(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
            IHttpContentRangeHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IHttpContentRangeHeaderValue*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ContentRange(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue *")]
            IHttpContentRangeHeaderValue value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IHttpContentRangeHeaderValue, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ContentType(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeHeaderValue **")]
            IHttpMediaTypeHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IHttpMediaTypeHeaderValue*, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ContentType(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeHeaderValue *")]
            IHttpMediaTypeHeaderValue value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IHttpMediaTypeHeaderValue, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Expires(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IReference<DateTime>**, int>)(
                (*lpVtbl)[20]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Expires(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IReference<DateTime>*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_LastModified(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IReference<DateTime>**, int>)(
                (*lpVtbl)[22]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_LastModified(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, IReference<DateTime>*, int>)(
                (*lpVtbl)[23]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT Append(HSTRING name, HSTRING value)
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, HSTRING, HSTRING, int>)(
                (*lpVtbl)[24]
            )
        )(this, name, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT TryAppendWithoutValidation(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IHttpContentHeaderCollection, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[25]
            )
        )(this, name, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentDisposition(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpContentDispositionHeaderValue **"
            )]
                IHttpContentDispositionHeaderValue* value
        );

        [VtblIndex(7)]
        HRESULT put_ContentDisposition(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpContentDispositionHeaderValue *"
            )]
                IHttpContentDispositionHeaderValue value
        );

        [VtblIndex(8)]
        HRESULT get_ContentEncoding(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpContentCodingHeaderValueCollection **"
            )]
                IHttpContentCodingHeaderValueCollection* value
        );

        [VtblIndex(9)]
        HRESULT get_ContentLanguage(
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpLanguageHeaderValueCollection **"
            )]
                IHttpLanguageHeaderValueCollection* value
        );

        [VtblIndex(10)]
        HRESULT get_ContentLength(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(11)]
        HRESULT put_ContentLength(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
                IReference<ulong>* value
        );

        [VtblIndex(12)]
        HRESULT get_ContentLocation(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(13)]
        HRESULT put_ContentLocation(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(14)]
        HRESULT get_ContentMD5(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(15)]
        HRESULT put_ContentMD5(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
        );

        [VtblIndex(16)]
        HRESULT get_ContentRange(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
                IHttpContentRangeHeaderValue* value
        );

        [VtblIndex(17)]
        HRESULT put_ContentRange(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue *")]
                IHttpContentRangeHeaderValue value
        );

        [VtblIndex(18)]
        HRESULT get_ContentType(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeHeaderValue **")]
                IHttpMediaTypeHeaderValue* value
        );

        [VtblIndex(19)]
        HRESULT put_ContentType(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeHeaderValue *")]
                IHttpMediaTypeHeaderValue value
        );

        [VtblIndex(20)]
        HRESULT get_Expires(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(21)]
        HRESULT put_Expires(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(22)]
        HRESULT get_LastModified(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(23)]
        HRESULT put_LastModified(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(24)]
        HRESULT Append(HSTRING name, HSTRING value);

        [VtblIndex(25)]
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
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentDispositionHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpContentDispositionHeaderValue*,
            int> get_ContentDisposition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentDispositionHeaderValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpContentDispositionHeaderValue,
            int> put_ContentDisposition;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentCodingHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpContentCodingHeaderValueCollection*,
            int> get_ContentEncoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpLanguageHeaderValueCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpLanguageHeaderValueCollection*,
            int> get_ContentLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_ContentLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>*, int> put_ContentLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_ContentLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_ContentLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_ContentMD5;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> put_ContentMD5;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpContentRangeHeaderValue*, int> get_ContentRange;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpContentRangeHeaderValue, int> put_ContentRange;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpMediaTypeHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMediaTypeHeaderValue*, int> get_ContentType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpMediaTypeHeaderValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMediaTypeHeaderValue, int> put_ContentType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_Expires;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_Expires;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_LastModified;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_LastModified;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> Append;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> TryAppendWithoutValidation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpContentHeaderCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpContentHeaderCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpContentHeaderCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpContentHeaderCollection(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpContentHeaderCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpContentHeaderCollection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpContentHeaderCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpContentHeaderCollection value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpContentHeaderCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpContentHeaderCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpContentHeaderCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpContentHeaderCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpContentHeaderCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpContentHeaderCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
