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

[Guid("15E5CBEC-9E0F-46B5-BC3F-9BF653E74B5E")]
[NativeTypeName("struct IApplicationView4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationView4 : IApplicationView4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationView4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationView4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationView4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationView4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationView4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationView4, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationView4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ViewMode(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode *")]
            ApplicationViewMode* value
    )
    {
        return ((delegate* unmanaged<IApplicationView4, ApplicationViewMode*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsViewModeSupported(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
            ApplicationViewMode viewMode,
        [NativeTypeName("boolean *")] byte* isViewModeSupported
    )
    {
        return (
            (delegate* unmanaged<IApplicationView4, ApplicationViewMode, byte*, int>)((*lpVtbl)[7])
        )(this, viewMode, isViewModeSupported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryEnterViewModeAsync(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
            ApplicationViewMode viewMode,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationView4,
                ApplicationViewMode,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[8])
        )(this, viewMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryEnterViewModeWithPreferencesAsync(
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
                IApplicationView4,
                ApplicationViewMode,
                IViewModePreferences,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[9])
        )(this, viewMode, viewModePreferences, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryConsolidateAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<IApplicationView4, IAsyncOperation<byte>**, int>)((*lpVtbl)[10])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ViewMode(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode *")]
                ApplicationViewMode* value
        );

        [VtblIndex(7)]
        HRESULT IsViewModeSupported(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
                ApplicationViewMode viewMode,
            [NativeTypeName("boolean *")] byte* isViewModeSupported
        );

        [VtblIndex(8)]
        HRESULT TryEnterViewModeAsync(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
                ApplicationViewMode viewMode,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(9)]
        HRESULT TryEnterViewModeWithPreferencesAsync(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewMode")]
                ApplicationViewMode viewMode,
            [NativeTypeName("ABI::Windows::UI::ViewManagement::IViewModePreferences *")]
                IViewModePreferences viewModePreferences,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(10)]
        HRESULT TryConsolidateAsync(
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
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ApplicationViewMode*, int> get_ViewMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ApplicationViewMode, byte*, int> IsViewModeSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ApplicationViewMode,
            IAsyncOperation<byte>**,
            int> TryEnterViewModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewMode, ABI::Windows::UI::ViewManagement::IViewModePreferences *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ApplicationViewMode,
            IViewModePreferences,
            IAsyncOperation<byte>**,
            int> TryEnterViewModeWithPreferencesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<byte>**, int> TryConsolidateAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationView4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationView4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationView4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationView4(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationView4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationView4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationView4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationView4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationView4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationView4(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationView4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationView4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationView4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationView4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
