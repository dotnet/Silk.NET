// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("04DE169F-BA02-4850-8B55-D82D03BA6D7F")]
[NativeTypeName("struct ICoreInputViewTransferringXYFocusEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputViewTransferringXYFocusEventArgs
    : ICoreInputViewTransferringXYFocusEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputViewTransferringXYFocusEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Origin([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, Rect*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Direction(
        [NativeTypeName(
            "ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection *"
        )]
            CoreInputViewXYFocusTransferDirection* value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreInputViewTransferringXYFocusEventArgs,
                CoreInputViewXYFocusTransferDirection*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TransferHandled([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, byte, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TransferHandled([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, byte*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_KeepPrimaryViewVisible([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, byte, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_KeepPrimaryViewVisible([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<ICoreInputViewTransferringXYFocusEventArgs, byte*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Origin([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(7)]
        HRESULT get_Direction(
            [NativeTypeName(
                "ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection *"
            )]
                CoreInputViewXYFocusTransferDirection* value
        );

        [VtblIndex(8)]
        HRESULT put_TransferHandled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_TransferHandled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_KeepPrimaryViewVisible([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_KeepPrimaryViewVisible([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_Origin;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::Core::CoreInputViewXYFocusTransferDirection *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreInputViewXYFocusTransferDirection*,
            int> get_Direction;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_TransferHandled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_TransferHandled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_KeepPrimaryViewVisible;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_KeepPrimaryViewVisible;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreInputViewTransferringXYFocusEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreInputViewTransferringXYFocusEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICoreInputViewTransferringXYFocusEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICoreInputViewTransferringXYFocusEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreInputViewTransferringXYFocusEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICoreInputViewTransferringXYFocusEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreInputViewTransferringXYFocusEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICoreInputViewTransferringXYFocusEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
