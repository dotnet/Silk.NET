// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("92059420-80A7-486D-B21F-C7A4A242A383")]
[NativeTypeName("struct IApplicationViewSwitcherStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationViewSwitcherStatics3
    : IApplicationViewSwitcherStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationViewSwitcherStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IApplicationViewSwitcherStatics3, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationViewSwitcherStatics3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationViewSwitcherStatics3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewSwitcherStatics3, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IApplicationViewSwitcherStatics3, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IApplicationViewSwitcherStatics3, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryShowAsViewModeAsync(
        [NativeTypeName("INT32")] int viewId,
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
            ApplicationViewMode viewMode,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationViewSwitcherStatics3,
                int,
                ApplicationViewMode,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[6])
        )(this, viewId, viewMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryShowAsViewModeWithPreferencesAsync(
        [NativeTypeName("INT32")] int viewId,
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
            ApplicationViewMode viewMode,
        [NativeTypeName("ABI::Windows::UI::ViewManagement::IViewModePreferences *")]
            IViewModePreferences viewModePreferences,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationViewSwitcherStatics3,
                int,
                ApplicationViewMode,
                IViewModePreferences,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, viewId, viewMode, viewModePreferences, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryShowAsViewModeAsync(
            [NativeTypeName("INT32")] int viewId,
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
                ApplicationViewMode viewMode,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(7)]
        HRESULT TryShowAsViewModeWithPreferencesAsync(
            [NativeTypeName("INT32")] int viewId,
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
                ApplicationViewMode viewMode,
            [NativeTypeName("ABI::Windows::UI::ViewManagement::IViewModePreferences *")]
                IViewModePreferences viewModePreferences,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
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
            "HRESULT (INT32, ABI::Windows::UI::ViewManagement::ApplicationViewMode, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            ApplicationViewMode,
            IAsyncOperation<byte>**,
            int> TryShowAsViewModeAsync;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::UI::ViewManagement::ApplicationViewMode, ABI::Windows::UI::ViewManagement::IViewModePreferences *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            ApplicationViewMode,
            IViewModePreferences,
            IAsyncOperation<byte>**,
            int> TryShowAsViewModeWithPreferencesAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationViewSwitcherStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationViewSwitcherStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationViewSwitcherStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationViewSwitcherStatics3(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IApplicationViewSwitcherStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationViewSwitcherStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationViewSwitcherStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IApplicationViewSwitcherStatics3 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationViewSwitcherStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationViewSwitcherStatics3(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IApplicationViewSwitcherStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationViewSwitcherStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationViewSwitcherStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IApplicationViewSwitcherStatics3 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
