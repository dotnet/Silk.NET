// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7FB013E8-0BD8-542B-B486-8323163A4B85")]
[NativeTypeName("struct IWebAuthenticationAddAccountResponse : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationAddAccountResponse
    : IWebAuthenticationAddAccountResponse.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationAddAccountResponse));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationAddAccountResponse, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAuthenticationAddAccountResponse, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAuthenticationAddAccountResponse, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWebAuthenticationAddAccountResponse, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationAddAccountResponse, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationAddAccountResponse, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_WebAccount(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount **")] IWebAccount* value
    )
    {
        return (
            (delegate* unmanaged<IWebAuthenticationAddAccountResponse, IWebAccount*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Properties(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")]
            IMap<HSTRING, HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationAddAccountResponse,
                IMap<HSTRING, HSTRING>**,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_WebAccount(
            [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount **")]
                IWebAccount* value
        );

        [VtblIndex(7)]
        HRESULT get_Properties(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **"
            )]
                IMap<HSTRING, HSTRING>** value
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
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWebAccount*, int> get_WebAccount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, HSTRING>**, int> get_Properties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAuthenticationAddAccountResponse"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAuthenticationAddAccountResponse(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAuthenticationAddAccountResponse"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationAddAccountResponse(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWebAuthenticationAddAccountResponse(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationAddAccountResponse"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationAddAccountResponse"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWebAuthenticationAddAccountResponse value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAuthenticationAddAccountResponse"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationAddAccountResponse(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWebAuthenticationAddAccountResponse(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationAddAccountResponse"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationAddAccountResponse"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWebAuthenticationAddAccountResponse value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
