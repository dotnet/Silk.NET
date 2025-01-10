// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FEE200FB-8664-44E0-95D9-42696199BFFC")]
[NativeTypeName("struct IHttpResponseMessage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpResponseMessage : IHttpResponseMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpResponseMessage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpResponseMessage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpResponseMessage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpResponseMessage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpResponseMessage, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpResponseMessage, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpResponseMessage, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
    )
    {
        return ((delegate* unmanaged<IHttpResponseMessage, IHttpContent*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Content(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent value
    )
    {
        return ((delegate* unmanaged<IHttpResponseMessage, IHttpContent, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Headers(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpResponseHeaderCollection **")]
            IHttpResponseHeaderCollection* value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseMessage, IHttpResponseHeaderCollection*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsSuccessStatusCode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHttpResponseMessage, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ReasonPhrase(HSTRING* value)
    {
        return ((delegate* unmanaged<IHttpResponseMessage, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ReasonPhrase(HSTRING value)
    {
        return ((delegate* unmanaged<IHttpResponseMessage, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RequestMessage(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")]
            IHttpRequestMessage* value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseMessage, IHttpRequestMessage*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RequestMessage(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseMessage, IHttpRequestMessage, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Source(
        [NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource *")]
            HttpResponseMessageSource* value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseMessage, HttpResponseMessageSource*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Source(
        [NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource")]
            HttpResponseMessageSource value
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseMessage, HttpResponseMessageSource, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_StatusCode(
        [NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode *")] HttpStatusCode* value
    )
    {
        return ((delegate* unmanaged<IHttpResponseMessage, HttpStatusCode*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_StatusCode(
        [NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode")] HttpStatusCode value
    )
    {
        return ((delegate* unmanaged<IHttpResponseMessage, HttpStatusCode, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Version(
        [NativeTypeName("ABI::Windows::Web::Http::HttpVersion *")] HttpVersion* value
    )
    {
        return ((delegate* unmanaged<IHttpResponseMessage, HttpVersion*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Version(
        [NativeTypeName("ABI::Windows::Web::Http::HttpVersion")] HttpVersion value
    )
    {
        return ((delegate* unmanaged<IHttpResponseMessage, HttpVersion, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT EnsureSuccessStatusCode(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")]
            IHttpResponseMessage* result
    )
    {
        return (
            (delegate* unmanaged<IHttpResponseMessage, IHttpResponseMessage*, int>)((*lpVtbl)[20])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
        );

        [VtblIndex(7)]
        HRESULT put_Content(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent value
        );

        [VtblIndex(8)]
        HRESULT get_Headers(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpResponseHeaderCollection **")]
                IHttpResponseHeaderCollection* value
        );

        [VtblIndex(9)]
        HRESULT get_IsSuccessStatusCode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_ReasonPhrase(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_ReasonPhrase(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_RequestMessage(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")]
                IHttpRequestMessage* value
        );

        [VtblIndex(13)]
        HRESULT put_RequestMessage(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")]
                IHttpRequestMessage value
        );

        [VtblIndex(14)]
        HRESULT get_Source(
            [NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource *")]
                HttpResponseMessageSource* value
        );

        [VtblIndex(15)]
        HRESULT put_Source(
            [NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource")]
                HttpResponseMessageSource value
        );

        [VtblIndex(16)]
        HRESULT get_StatusCode(
            [NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode *")] HttpStatusCode* value
        );

        [VtblIndex(17)]
        HRESULT put_StatusCode(
            [NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode")] HttpStatusCode value
        );

        [VtblIndex(18)]
        HRESULT get_Version(
            [NativeTypeName("ABI::Windows::Web::Http::HttpVersion *")] HttpVersion* value
        );

        [VtblIndex(19)]
        HRESULT put_Version(
            [NativeTypeName("ABI::Windows::Web::Http::HttpVersion")] HttpVersion value
        );

        [VtblIndex(20)]
        HRESULT EnsureSuccessStatusCode(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")]
                IHttpResponseMessage* result
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
            "HRESULT (ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpContent*, int> get_Content;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpContent *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpContent, int> put_Content;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpResponseHeaderCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpResponseHeaderCollection*, int> get_Headers;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSuccessStatusCode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ReasonPhrase;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ReasonPhrase;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpRequestMessage*, int> get_RequestMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpRequestMessage, int> put_RequestMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::HttpResponseMessageSource *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpResponseMessageSource*, int> get_Source;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::HttpResponseMessageSource) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpResponseMessageSource, int> put_Source;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::HttpStatusCode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpStatusCode*, int> get_StatusCode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::HttpStatusCode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpStatusCode, int> put_StatusCode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::HttpVersion *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpVersion*, int> get_Version;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpVersion) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HttpVersion, int> put_Version;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpResponseMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpResponseMessage*, int> EnsureSuccessStatusCode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpResponseMessage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpResponseMessage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpResponseMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpResponseMessage(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpResponseMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpResponseMessage"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpResponseMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpResponseMessage value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpResponseMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpResponseMessage(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpResponseMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpResponseMessage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpResponseMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpResponseMessage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
