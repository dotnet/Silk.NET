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

[Guid("F5762B3C-74D4-4811-B5DC-9F8B4E2F9ABF")]
[NativeTypeName("struct IHttpRequestMessage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpRequestMessage : IHttpRequestMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpRequestMessage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpRequestMessage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpRequestMessage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpRequestMessage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpRequestMessage, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpRequestMessage, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpRequestMessage, TrustLevel*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IHttpRequestMessage, IHttpContent*, int>)((*lpVtbl)[6]))(
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
        return ((delegate* unmanaged<IHttpRequestMessage, IHttpContent, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Headers(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")]
            IHttpRequestHeaderCollection* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestMessage, IHttpRequestHeaderCollection*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Method(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpRequestMessage, IHttpMethod*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Method(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod *")] IHttpMethod value
    )
    {
        return ((delegate* unmanaged<IHttpRequestMessage, IHttpMethod, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Properties(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **"
        )]
            IMap<HSTRING, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestMessage, IMap<HSTRING, IntPtr>**, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RequestUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return ((delegate* unmanaged<IHttpRequestMessage, IUriRuntimeClass*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RequestUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return ((delegate* unmanaged<IHttpRequestMessage, IUriRuntimeClass, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_TransportInformation(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpTransportInformation **")]
            IHttpTransportInformation* value
    )
    {
        return (
            (delegate* unmanaged<IHttpRequestMessage, IHttpTransportInformation*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
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
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")]
                IHttpRequestHeaderCollection* value
        );

        [VtblIndex(9)]
        HRESULT get_Method(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
        );

        [VtblIndex(10)]
        HRESULT put_Method(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod *")] IHttpMethod value
        );

        [VtblIndex(11)]
        HRESULT get_Properties(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **"
            )]
                IMap<HSTRING, IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT get_RequestUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(13)]
        HRESULT put_RequestUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(14)]
        HRESULT get_TransportInformation(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpTransportInformation **")]
                IHttpTransportInformation* value
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
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpRequestHeaderCollection*, int> get_Headers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Method;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod, int> put_Method;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, IntPtr>**, int> get_Properties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_RequestUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_RequestUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpTransportInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpTransportInformation*,
            int> get_TransportInformation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpRequestMessage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpRequestMessage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpRequestMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpRequestMessage(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpRequestMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpRequestMessage"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpRequestMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpRequestMessage value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpRequestMessage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpRequestMessage(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpRequestMessage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpRequestMessage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpRequestMessage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpRequestMessage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
