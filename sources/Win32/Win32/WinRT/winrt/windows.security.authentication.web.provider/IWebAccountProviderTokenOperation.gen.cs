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

[Guid("95C613BE-2034-4C38-9434-D26C14B2B4B2")]
[NativeTypeName("struct IWebAccountProviderTokenOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountProviderTokenOperation
    : IWebAccountProviderTokenOperation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountProviderTokenOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWebAccountProviderTokenOperation, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAccountProviderTokenOperation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAccountProviderTokenOperation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWebAccountProviderTokenOperation, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IWebAccountProviderTokenOperation, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWebAccountProviderTokenOperation, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProviderRequest(
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Provider::IWebProviderTokenRequest **"
        )]
            IWebProviderTokenRequest* webTokenRequest
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountProviderTokenOperation,
                IWebProviderTokenRequest*,
                int>)((*lpVtbl)[6])
        )(this, webTokenRequest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProviderResponses(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebProviderTokenResponse_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IWebAccountProviderTokenOperation, IVector<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CacheExpirationTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
    )
    {
        return (
            (delegate* unmanaged<IWebAccountProviderTokenOperation, WinRTDateTime, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CacheExpirationTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return (
            (delegate* unmanaged<IWebAccountProviderTokenOperation, WinRTDateTime*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProviderRequest(
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Provider::IWebProviderTokenRequest **"
            )]
                IWebProviderTokenRequest* webTokenRequest
        );

        [VtblIndex(7)]
        HRESULT get_ProviderResponses(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebProviderTokenResponse_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT put_CacheExpirationTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
        );

        [VtblIndex(9)]
        HRESULT get_CacheExpirationTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
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
            "HRESULT (ABI::Windows::Security::Authentication::Web::Provider::IWebProviderTokenRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWebProviderTokenRequest*, int> get_ProviderRequest;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebProviderTokenResponse_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_ProviderResponses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime, int> put_CacheExpirationTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_CacheExpirationTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAccountProviderTokenOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAccountProviderTokenOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAccountProviderTokenOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAccountProviderTokenOperation(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWebAccountProviderTokenOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountProviderTokenOperation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountProviderTokenOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWebAccountProviderTokenOperation value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAccountProviderTokenOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAccountProviderTokenOperation(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWebAccountProviderTokenOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountProviderTokenOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountProviderTokenOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWebAccountProviderTokenOperation value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
