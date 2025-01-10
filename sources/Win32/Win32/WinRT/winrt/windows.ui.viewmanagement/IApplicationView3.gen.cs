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

[Guid("903C9CE5-793A-4FDF-A2B2-AF1AC21E3108")]
[NativeTypeName("struct IApplicationView3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationView3 : IApplicationView3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationView3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationView3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationView3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationView3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationView3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationView3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationView3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TitleBar(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::IApplicationViewTitleBar **")]
            IApplicationViewTitleBar* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationView3, IApplicationViewTitleBar*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FullScreenSystemOverlayMode(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode *")]
            FullScreenSystemOverlayMode* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationView3, FullScreenSystemOverlayMode*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_FullScreenSystemOverlayMode(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode")]
            FullScreenSystemOverlayMode value
    )
    {
        return (
            (delegate* unmanaged<IApplicationView3, FullScreenSystemOverlayMode, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsFullScreenMode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IApplicationView3, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryEnterFullScreenMode([NativeTypeName("boolean *")] byte* success)
    {
        return ((delegate* unmanaged<IApplicationView3, byte*, int>)((*lpVtbl)[10]))(this, success);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ExitFullScreenMode()
    {
        return ((delegate* unmanaged<IApplicationView3, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowStandardSystemOverlays()
    {
        return ((delegate* unmanaged<IApplicationView3, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT TryResizeView(
        [NativeTypeName("ABI::Windows::Foundation::Size")] Size value,
        [NativeTypeName("boolean *")] byte* success
    )
    {
        return ((delegate* unmanaged<IApplicationView3, Size, byte*, int>)((*lpVtbl)[13]))(
            this,
            value,
            success
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetPreferredMinSize(
        [NativeTypeName("ABI::Windows::Foundation::Size")] Size minSize
    )
    {
        return ((delegate* unmanaged<IApplicationView3, Size, int>)((*lpVtbl)[14]))(this, minSize);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TitleBar(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::IApplicationViewTitleBar **")]
                IApplicationViewTitleBar* value
        );

        [VtblIndex(7)]
        HRESULT get_FullScreenSystemOverlayMode(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode *")]
                FullScreenSystemOverlayMode* value
        );

        [VtblIndex(8)]
        HRESULT put_FullScreenSystemOverlayMode(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode")]
                FullScreenSystemOverlayMode value
        );

        [VtblIndex(9)]
        HRESULT get_IsFullScreenMode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT TryEnterFullScreenMode([NativeTypeName("boolean *")] byte* success);

        [VtblIndex(11)]
        HRESULT ExitFullScreenMode();

        [VtblIndex(12)]
        HRESULT ShowStandardSystemOverlays();

        [VtblIndex(13)]
        HRESULT TryResizeView(
            [NativeTypeName("ABI::Windows::Foundation::Size")] Size value,
            [NativeTypeName("boolean *")] byte* success
        );

        [VtblIndex(14)]
        HRESULT SetPreferredMinSize(
            [NativeTypeName("ABI::Windows::Foundation::Size")] Size minSize
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
            "HRESULT (ABI::Windows::UI::ViewManagement::IApplicationViewTitleBar **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IApplicationViewTitleBar*, int> get_TitleBar;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            FullScreenSystemOverlayMode*,
            int> get_FullScreenSystemOverlayMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::FullScreenSystemOverlayMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            FullScreenSystemOverlayMode,
            int> put_FullScreenSystemOverlayMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsFullScreenMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> TryEnterFullScreenMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ExitFullScreenMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShowStandardSystemOverlays;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Size, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Size, byte*, int> TryResizeView;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size, int> SetPreferredMinSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationView3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationView3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationView3(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationView3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationView3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationView3(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationView3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationView3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
