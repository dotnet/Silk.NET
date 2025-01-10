// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B7F47116-A56F-4DC8-9E11-92031F4A87C2")]
[NativeTypeName("struct ISystemMediaTransportControlsButtonPressedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemMediaTransportControlsButtonPressedEventArgs
    : ISystemMediaTransportControlsButtonPressedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_ISystemMediaTransportControlsButtonPressedEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ISystemMediaTransportControlsButtonPressedEventArgs,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControlsButtonPressedEventArgs, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ISystemMediaTransportControlsButtonPressedEventArgs, uint>)(
                (*lpVtbl)[2]
            )
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
            (delegate* unmanaged<
                ISystemMediaTransportControlsButtonPressedEventArgs,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<
                ISystemMediaTransportControlsButtonPressedEventArgs,
                HSTRING*,
                int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                ISystemMediaTransportControlsButtonPressedEventArgs,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Button(
        [NativeTypeName("ABI::Windows::Media::SystemMediaTransportControlsButton *")]
            SystemMediaTransportControlsButton* value
    )
    {
        return (
            (delegate* unmanaged<
                ISystemMediaTransportControlsButtonPressedEventArgs,
                SystemMediaTransportControlsButton*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Button(
            [NativeTypeName("ABI::Windows::Media::SystemMediaTransportControlsButton *")]
                SystemMediaTransportControlsButton* value
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
            "HRESULT (ABI::Windows::Media::SystemMediaTransportControlsButton *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SystemMediaTransportControlsButton*, int> get_Button;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISystemMediaTransportControlsButtonPressedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISystemMediaTransportControlsButtonPressedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISystemMediaTransportControlsButtonPressedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISystemMediaTransportControlsButtonPressedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISystemMediaTransportControlsButtonPressedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemMediaTransportControlsButtonPressedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemMediaTransportControlsButtonPressedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISystemMediaTransportControlsButtonPressedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISystemMediaTransportControlsButtonPressedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISystemMediaTransportControlsButtonPressedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISystemMediaTransportControlsButtonPressedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemMediaTransportControlsButtonPressedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemMediaTransportControlsButtonPressedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISystemMediaTransportControlsButtonPressedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
