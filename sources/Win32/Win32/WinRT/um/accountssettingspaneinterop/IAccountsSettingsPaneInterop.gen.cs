// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accountssettingspaneinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D3EE12AD-3865-4362-9746-B75A682DF0E6")]
[NativeTypeName("struct IAccountsSettingsPaneInterop : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IAccountsSettingsPaneInterop
    : IAccountsSettingsPaneInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccountsSettingsPaneInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAccountsSettingsPaneInterop, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAccountsSettingsPaneInterop, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAccountsSettingsPaneInterop, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForWindow(
        HWND appWindow,
        [NativeTypeName("const IID &")] Guid* riid,
        void** accountsSettingsPane
    )
    {
        return (
            (delegate* unmanaged<IAccountsSettingsPaneInterop, HWND, Guid*, void**, int>)(
                (*lpVtbl)[6]
            )
        )(this, appWindow, riid, accountsSettingsPane);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowManageAccountsForWindowAsync(
        HWND appWindow,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncAction
    )
    {
        return (
            (delegate* unmanaged<IAccountsSettingsPaneInterop, HWND, Guid*, void**, int>)(
                (*lpVtbl)[7]
            )
        )(this, appWindow, riid, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowAddAccountForWindowAsync(
        HWND appWindow,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncAction
    )
    {
        return (
            (delegate* unmanaged<IAccountsSettingsPaneInterop, HWND, Guid*, void**, int>)(
                (*lpVtbl)[8]
            )
        )(this, appWindow, riid, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForWindow(
            HWND appWindow,
            [NativeTypeName("const IID &")] Guid* riid,
            void** accountsSettingsPane
        );

        [VtblIndex(7)]
        HRESULT ShowManageAccountsForWindowAsync(
            HWND appWindow,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncAction
        );

        [VtblIndex(8)]
        HRESULT ShowAddAccountForWindowAsync(
            HWND appWindow,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncAction
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

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> GetForWindow;

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            Guid*,
            void**,
            int> ShowManageAccountsForWindowAsync;

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> ShowAddAccountForWindowAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAccountsSettingsPaneInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAccountsSettingsPaneInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAccountsSettingsPaneInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAccountsSettingsPaneInterop(Silk.NET.WinRT.IInspectable value)
    {
        return new IAccountsSettingsPaneInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccountsSettingsPaneInterop"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAccountsSettingsPaneInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAccountsSettingsPaneInterop value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAccountsSettingsPaneInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAccountsSettingsPaneInterop(Silk.NET.Windows.IUnknown value)
    {
        return new IAccountsSettingsPaneInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccountsSettingsPaneInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAccountsSettingsPaneInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAccountsSettingsPaneInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
