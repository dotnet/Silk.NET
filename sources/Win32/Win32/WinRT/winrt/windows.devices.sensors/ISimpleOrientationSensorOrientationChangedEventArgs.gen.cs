// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BCD5C660-23D4-4B4C-A22E-BA81ADE0C601")]
[NativeTypeName("struct ISimpleOrientationSensorOrientationChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISimpleOrientationSensorOrientationChangedEventArgs
    : ISimpleOrientationSensorOrientationChangedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_ISimpleOrientationSensorOrientationChangedEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ISimpleOrientationSensorOrientationChangedEventArgs,
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
            (delegate* unmanaged<ISimpleOrientationSensorOrientationChangedEventArgs, uint>)(
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
            (delegate* unmanaged<ISimpleOrientationSensorOrientationChangedEventArgs, uint>)(
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
                ISimpleOrientationSensorOrientationChangedEventArgs,
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
                ISimpleOrientationSensorOrientationChangedEventArgs,
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
                ISimpleOrientationSensorOrientationChangedEventArgs,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return (
            (delegate* unmanaged<
                ISimpleOrientationSensorOrientationChangedEventArgs,
                WinRTDateTime*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Orientation(
        [NativeTypeName("ABI::Windows::Devices::Sensors::SimpleOrientation *")]
            SimpleOrientation* value
    )
    {
        return (
            (delegate* unmanaged<
                ISimpleOrientationSensorOrientationChangedEventArgs,
                SimpleOrientation*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(7)]
        HRESULT get_Orientation(
            [NativeTypeName("ABI::Windows::Devices::Sensors::SimpleOrientation *")]
                SimpleOrientation* value
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::SimpleOrientation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SimpleOrientation*, int> get_Orientation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISimpleOrientationSensorOrientationChangedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISimpleOrientationSensorOrientationChangedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISimpleOrientationSensorOrientationChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISimpleOrientationSensorOrientationChangedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISimpleOrientationSensorOrientationChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISimpleOrientationSensorOrientationChangedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISimpleOrientationSensorOrientationChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISimpleOrientationSensorOrientationChangedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISimpleOrientationSensorOrientationChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISimpleOrientationSensorOrientationChangedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISimpleOrientationSensorOrientationChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISimpleOrientationSensorOrientationChangedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISimpleOrientationSensorOrientationChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISimpleOrientationSensorOrientationChangedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
