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

[Guid("59EBC2D2-F7DB-412F-BC3F-F2FEA04430B4")]
[NativeTypeName("struct IWebAccountManagerStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountManagerStatics4
    : IWebAccountManagerStatics4.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountManagerStatics4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWebAccountManagerStatics4, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWebAccountManagerStatics4, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics4, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebAccountManagerStatics4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InvalidateAppCacheForAllAccountsAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWebAccountManagerStatics4, IAsyncAction*, int>)((*lpVtbl)[6])
        )(this, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InvalidateAppCacheForAccountAsync(
        [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")]
            IWebAccount webAccount,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWebAccountManagerStatics4, IWebAccount, IAsyncAction*, int>)(
                (*lpVtbl)[7]
            )
        )(this, webAccount, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InvalidateAppCacheForAllAccountsAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(7)]
        HRESULT InvalidateAppCacheForAccountAsync(
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
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncAction*,
            int> InvalidateAppCacheForAllAccountsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWebAccount,
            IAsyncAction*,
            int> InvalidateAppCacheForAccountAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAccountManagerStatics4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAccountManagerStatics4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAccountManagerStatics4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAccountManagerStatics4(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebAccountManagerStatics4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountManagerStatics4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountManagerStatics4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebAccountManagerStatics4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAccountManagerStatics4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAccountManagerStatics4(Silk.NET.Windows.IUnknown value)
    {
        return new IWebAccountManagerStatics4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountManagerStatics4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountManagerStatics4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebAccountManagerStatics4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
