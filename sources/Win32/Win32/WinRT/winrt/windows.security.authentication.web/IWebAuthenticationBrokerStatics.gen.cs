// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2F149F1A-E673-40B5-BC22-201A6864A37B")]
[NativeTypeName("struct IWebAuthenticationBrokerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationBrokerStatics
    : IWebAuthenticationBrokerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationBrokerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationBrokerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAuthenticationBrokerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAuthenticationBrokerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWebAuthenticationBrokerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationBrokerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationBrokerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AuthenticateWithCallbackUriAsync(
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")]
            WebAuthenticationOptions options,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass requestUri,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass callbackUri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationBrokerStatics,
                WebAuthenticationOptions,
                IUriRuntimeClass,
                IUriRuntimeClass,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, options, requestUri, callbackUri, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AuthenticateWithoutCallbackUriAsync(
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")]
            WebAuthenticationOptions options,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass requestUri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationBrokerStatics,
                WebAuthenticationOptions,
                IUriRuntimeClass,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, options, requestUri, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurrentApplicationCallbackUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
            IUriRuntimeClass* callbackUri
    )
    {
        return (
            (delegate* unmanaged<IWebAuthenticationBrokerStatics, IUriRuntimeClass*, int>)(
                (*lpVtbl)[8]
            )
        )(this, callbackUri);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AuthenticateWithCallbackUriAsync(
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions"
            )]
                WebAuthenticationOptions options,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass requestUri,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass callbackUri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(7)]
        HRESULT AuthenticateWithoutCallbackUriAsync(
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions"
            )]
                WebAuthenticationOptions options,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass requestUri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(8)]
        HRESULT GetCurrentApplicationCallbackUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* callbackUri
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
            "HRESULT (ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WebAuthenticationOptions,
            IUriRuntimeClass,
            IUriRuntimeClass,
            IAsyncOperation<IntPtr>**,
            int> AuthenticateWithCallbackUriAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WebAuthenticationOptions,
            IUriRuntimeClass,
            IAsyncOperation<IntPtr>**,
            int> AuthenticateWithoutCallbackUriAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> GetCurrentApplicationCallbackUri;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAuthenticationBrokerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAuthenticationBrokerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAuthenticationBrokerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationBrokerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWebAuthenticationBrokerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationBrokerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationBrokerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWebAuthenticationBrokerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAuthenticationBrokerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationBrokerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IWebAuthenticationBrokerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationBrokerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationBrokerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebAuthenticationBrokerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
