// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B2E8E1A6-D49A-4032-84BF-1A2847747BF1")]
[NativeTypeName("struct IWebAccountManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountManagerStatics
    : IWebAccountManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWebAccountManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UpdateWebAccountPropertiesAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        HSTRING webAccountUserName,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")]
            IMapView<HSTRING, HSTRING>* additionalProperties,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountManagerStatics,
                IWebAccount,
                HSTRING,
                IMapView<HSTRING, HSTRING>*,
                IAsyncAction*,
                int>)((*lpVtbl)[6])
        )(this, webAccount, webAccountUserName, additionalProperties, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWebAccountAsync(
        HSTRING webAccountId,
        HSTRING webAccountUserName,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")]
            IMapView<HSTRING, HSTRING>* props,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountManagerStatics,
                HSTRING,
                HSTRING,
                IMapView<HSTRING, HSTRING>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, webAccountId, webAccountUserName, props, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteWebAccountAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWebAccountManagerStatics, IWebAccount, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, webAccount, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindAllProviderWebAccountsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWebAccountManagerStatics, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PushCookiesAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t *"
        )]
            IVectorView<IntPtr>* cookies,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountManagerStatics,
                IUriRuntimeClass,
                IVectorView<IntPtr>*,
                IAsyncAction*,
                int>)((*lpVtbl)[10])
        )(this, uri, cookies, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetViewAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView *"
        )]
            IWebAccountClientView view,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountManagerStatics,
                IWebAccount,
                IWebAccountClientView,
                IAsyncAction*,
                int>)((*lpVtbl)[11])
        )(this, webAccount, view, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ClearViewAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass applicationCallbackUri,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountManagerStatics,
                IWebAccount,
                IUriRuntimeClass,
                IAsyncAction*,
                int>)((*lpVtbl)[12])
        )(this, webAccount, applicationCallbackUri, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetViewsAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebAccountClientView_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountManagerStatics,
                IWebAccount,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, webAccount, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetWebAccountPictureAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream webAccountPicture,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountManagerStatics,
                IWebAccount,
                IRandomAccessStream,
                IAsyncAction*,
                int>)((*lpVtbl)[14])
        )(this, webAccount, webAccountPicture, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ClearWebAccountPictureAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWebAccountManagerStatics, IWebAccount, IAsyncAction*, int>)(
                (*lpVtbl)[15]
            )
        )(this, webAccount, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT UpdateWebAccountPropertiesAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            HSTRING webAccountUserName,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *"
            )]
                IMapView<HSTRING, HSTRING>* additionalProperties,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(7)]
        HRESULT AddWebAccountAsync(
            HSTRING webAccountId,
            HSTRING webAccountUserName,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *"
            )]
                IMapView<HSTRING, HSTRING>* props,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(8)]
        HRESULT DeleteWebAccountAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(9)]
        HRESULT FindAllProviderWebAccountsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(10)]
        HRESULT PushCookiesAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t *"
            )]
                IVectorView<IntPtr>* cookies,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(11)]
        HRESULT SetViewAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView *"
            )]
                IWebAccountClientView view,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(12)]
        HRESULT ClearViewAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass applicationCallbackUri,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(13)]
        HRESULT GetViewsAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebAccountClientView_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(14)]
        HRESULT SetWebAccountPictureAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream webAccountPicture,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(15)]
        HRESULT ClearWebAccountPictureAsync(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
                IWebAccount webAccount,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
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
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            HSTRING,
            IMapView<HSTRING, HSTRING>*,
            IAsyncAction*,
            int> UpdateWebAccountPropertiesAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IMapView<HSTRING, HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> AddWebAccountAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWebAccount, IAsyncAction*, int> DeleteWebAccountAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> FindAllProviderWebAccountsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IVectorView<IntPtr>*,
            IAsyncAction*,
            int> PushCookiesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IWebAccountClientView,
            IAsyncAction*,
            int> SetViewAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IUriRuntimeClass,
            IAsyncAction*,
            int> ClearViewAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebAccountClientView_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IAsyncOperation<IntPtr>**,
            int> GetViewsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IRandomAccessStream,
            IAsyncAction*,
            int> SetWebAccountPictureAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IAsyncAction*,
            int> ClearWebAccountPictureAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAccountManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAccountManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAccountManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAccountManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebAccountManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebAccountManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAccountManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAccountManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IWebAccountManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebAccountManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
