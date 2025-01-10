// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("50A6BD5D-66EF-4CD3-9579-9E660507DC3F")]
[NativeTypeName("struct IAdaptiveMediaSourceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceStatics
    : IAdaptiveMediaSourceStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdaptiveMediaSourceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdaptiveMediaSourceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSourceStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAdaptiveMediaSourceStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsContentTypeSupported(
        HSTRING contentType,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceStatics, HSTRING, byte*, int>)((*lpVtbl)[6])
        )(this, contentType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromUriAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceStatics,
                IUriRuntimeClass,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, uri, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromUriWithDownloaderAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient httpClient,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceStatics,
                IUriRuntimeClass,
                IHttpClient,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, uri, httpClient, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream stream,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        HSTRING contentType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceStatics,
                IInputStream,
                IUriRuntimeClass,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, stream, uri, contentType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFromStreamWithDownloaderAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream stream,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        HSTRING contentType,
        [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient httpClient,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceStatics,
                IInputStream,
                IUriRuntimeClass,
                HSTRING,
                IHttpClient,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, stream, uri, contentType, httpClient, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsContentTypeSupported(
            HSTRING contentType,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(7)]
        HRESULT CreateFromUriAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT CreateFromUriWithDownloaderAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient httpClient,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT CreateFromStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream stream,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            HSTRING contentType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT CreateFromStreamWithDownloaderAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream stream,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            HSTRING contentType,
            [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient httpClient,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
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

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsContentTypeSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperation<IntPtr>**,
            int> CreateFromUriAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpClient *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IHttpClient,
            IAsyncOperation<IntPtr>**,
            int> CreateFromUriWithDownloaderAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IUriRuntimeClass,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFromStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Web::Http::IHttpClient *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IUriRuntimeClass,
            HSTRING,
            IHttpClient,
            IAsyncOperation<IntPtr>**,
            int> CreateFromStreamWithDownloaderAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdaptiveMediaSourceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdaptiveMediaSourceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdaptiveMediaSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IAdaptiveMediaSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAdaptiveMediaSourceStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdaptiveMediaSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IAdaptiveMediaSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAdaptiveMediaSourceStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
