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

[Guid("64002B4B-EDE9-470A-A5CD-0323FAF6E262")]
[NativeTypeName("struct IWebAuthenticationResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationResult
    : IWebAuthenticationResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebAuthenticationResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWebAuthenticationResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAuthenticationResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWebAuthenticationResult, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebAuthenticationResult, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebAuthenticationResult, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResponseData(HSTRING* value)
    {
        return ((delegate* unmanaged<IWebAuthenticationResult, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResponseStatus(
        [NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationStatus *")]
            WebAuthenticationStatus* value
    )
    {
        return (
            (delegate* unmanaged<IWebAuthenticationResult, WebAuthenticationStatus*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseErrorDetail([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IWebAuthenticationResult, uint*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResponseData(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ResponseStatus(
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::WebAuthenticationStatus *"
            )]
                WebAuthenticationStatus* value
        );

        [VtblIndex(8)]
        HRESULT get_ResponseErrorDetail([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ResponseData;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Authentication::Web::WebAuthenticationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, WebAuthenticationStatus*, int> get_ResponseStatus;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ResponseErrorDetail;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAuthenticationResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAuthenticationResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAuthenticationResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationResult(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebAuthenticationResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebAuthenticationResult value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAuthenticationResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationResult(Silk.NET.Windows.IUnknown value)
    {
        return new IWebAuthenticationResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebAuthenticationResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
