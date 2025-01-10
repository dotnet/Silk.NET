// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebAuthenticationCoreManagerInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F4B8E804-811E-4436-B69C-44CB67B72084")]
[NativeTypeName("struct IWebAuthenticationCoreManagerInterop : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IWebAuthenticationCoreManagerInterop
    : IWebAuthenticationCoreManagerInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationCoreManagerInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationCoreManagerInterop, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IWebAuthenticationCoreManagerInterop, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationCoreManagerInterop, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWebAuthenticationCoreManagerInterop, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestTokenForWindowAsync(
        HWND appWindow,
        IInspectable request,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationCoreManagerInterop,
                HWND,
                IInspectable,
                Guid*,
                void**,
                int>)((*lpVtbl)[6])
        )(this, appWindow, request, riid, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestTokenWithWebAccountForWindowAsync(
        HWND appWindow,
        IInspectable request,
        IInspectable webAccount,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IWebAuthenticationCoreManagerInterop,
                HWND,
                IInspectable,
                IInspectable,
                Guid*,
                void**,
                int>)((*lpVtbl)[7])
        )(this, appWindow, request, webAccount, riid, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestTokenForWindowAsync(
            HWND appWindow,
            IInspectable request,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncInfo
        );

        [VtblIndex(7)]
        HRESULT RequestTokenWithWebAccountForWindowAsync(
            HWND appWindow,
            IInspectable request,
            IInspectable webAccount,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncInfo
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
            "HRESULT (HWND, IInspectable *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IInspectable,
            Guid*,
            void**,
            int> RequestTokenForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, IInspectable *, IInspectable *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IInspectable,
            IInspectable,
            Guid*,
            void**,
            int> RequestTokenWithWebAccountForWindowAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAuthenticationCoreManagerInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAuthenticationCoreManagerInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAuthenticationCoreManagerInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationCoreManagerInterop(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IWebAuthenticationCoreManagerInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationCoreManagerInterop"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationCoreManagerInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IWebAuthenticationCoreManagerInterop value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAuthenticationCoreManagerInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAuthenticationCoreManagerInterop(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWebAuthenticationCoreManagerInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAuthenticationCoreManagerInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAuthenticationCoreManagerInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWebAuthenticationCoreManagerInterop value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
