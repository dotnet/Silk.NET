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

[Guid("7A431780-CD4F-4E57-A84A-5B0A53D6BB96")]
[NativeTypeName("struct IHttpCookieManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCookieManager : IHttpCookieManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCookieManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpCookieManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpCookieManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpCookieManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpCookieManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpCookieManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpCookieManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCookie(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie cookie,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return ((delegate* unmanaged<IHttpCookieManager, IHttpCookie, byte*, int>)((*lpVtbl)[6]))(
            this,
            cookie,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCookieWithThirdParty(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie cookie,
        [NativeTypeName("boolean")] byte thirdParty,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IHttpCookieManager, IHttpCookie, byte, byte*, int>)((*lpVtbl)[7])
        )(this, cookie, thirdParty, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteCookie(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie cookie
    )
    {
        return ((delegate* unmanaged<IHttpCookieManager, IHttpCookie, int>)((*lpVtbl)[8]))(
            this,
            cookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCookies(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IHttpCookieManager, IUriRuntimeClass, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, uri, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetCookie(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie cookie,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(7)]
        HRESULT SetCookieWithThirdParty(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie cookie,
            [NativeTypeName("boolean")] byte thirdParty,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(8)]
        HRESULT DeleteCookie(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie cookie
        );

        [VtblIndex(9)]
        HRESULT GetCookies(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t **"
            )]
                IVectorView<IntPtr>** result
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
            "HRESULT (ABI::Windows::Web::Http::IHttpCookie *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCookie, byte*, int> SetCookie;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpCookie *, boolean, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCookie, byte, byte*, int> SetCookieWithThirdParty;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpCookie *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpCookie, int> DeleteCookie;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, IVectorView<IntPtr>**, int> GetCookies;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpCookieManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpCookieManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpCookieManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpCookieManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpCookieManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpCookieManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpCookieManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpCookieManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpCookieManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpCookieManager(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpCookieManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpCookieManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpCookieManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpCookieManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
