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

[Guid("7FDA1151-3574-4880-A8BA-E6B1E0061F3D")]
[NativeTypeName("struct IHttpClient : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpClient : IHttpClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpClient));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpClient, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpClient, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpClient, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpClient, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpClient, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpClient, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[6])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[7])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWithOptionAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")]
            HttpCompletionOption completionOption,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                HttpCompletionOption,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[8])
        )(this, uri, completionOption, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBufferAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[9])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInputStreamAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[10])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStringAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<HSTRING, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                IAsyncOperationWithProgress<HSTRING, HttpProgress>**,
                int>)((*lpVtbl)[11])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PostAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                IHttpContent,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[12])
        )(this, uri, content, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PutAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IUriRuntimeClass,
                IHttpContent,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[13])
        )(this, uri, content, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SendRequestAsync(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")]
            IHttpRequestMessage request,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IHttpRequestMessage,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[14])
        )(this, request, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SendRequestWithOptionAsync(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")]
            IHttpRequestMessage request,
        [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")]
            HttpCompletionOption completionOption,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpClient,
                IHttpRequestMessage,
                HttpCompletionOption,
                IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
                int>)((*lpVtbl)[15])
        )(this, request, completionOption, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DefaultRequestHeaders(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")]
            IHttpRequestHeaderCollection* value
    )
    {
        return (
            (delegate* unmanaged<IHttpClient, IHttpRequestHeaderCollection*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(7)]
        HRESULT GetAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(8)]
        HRESULT GetWithOptionAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")]
                HttpCompletionOption completionOption,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(9)]
        HRESULT GetBufferAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(10)]
        HRESULT GetInputStreamAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(11)]
        HRESULT GetStringAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<HSTRING, HttpProgress>** operation
        );

        [VtblIndex(12)]
        HRESULT PostAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(13)]
        HRESULT PutAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(14)]
        HRESULT SendRequestAsync(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")]
                IHttpRequestMessage request,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(15)]
        HRESULT SendRequestWithOptionAsync(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")]
                IHttpRequestMessage request,
            [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")]
                HttpCompletionOption completionOption,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, HttpProgress>** operation
        );

        [VtblIndex(16)]
        HRESULT get_DefaultRequestHeaders(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")]
                IHttpRequestHeaderCollection* value
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
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> GetAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::HttpCompletionOption, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            HttpCompletionOption,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> GetWithOptionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> GetBufferAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> GetInputStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperationWithProgress<HSTRING, HttpProgress>**,
            int> GetStringAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpContent *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IHttpContent,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> PostAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpContent *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IHttpContent,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> PutAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpRequestMessage,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> SendRequestAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *, ABI::Windows::Web::Http::HttpCompletionOption, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpRequestMessage,
            HttpCompletionOption,
            IAsyncOperationWithProgress<IntPtr, HttpProgress>**,
            int> SendRequestWithOptionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpRequestHeaderCollection*,
            int> get_DefaultRequestHeaders;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpClient(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpClient"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpClient value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpClient(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpClient value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
