// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A73E561C-AAC1-4EC7-A852-479F7060D01F")]
[NativeTypeName("struct ILowLevelDevicesAggregateProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLevelDevicesAggregateProvider
    : ILowLevelDevicesAggregateProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILowLevelDevicesAggregateProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILowLevelDevicesAggregateProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILowLevelDevicesAggregateProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AdcControllerProvider(
        [NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider **")]
            IAdcControllerProvider* value
    )
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, IAdcControllerProvider*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PwmControllerProvider(
        [NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider **")]
            IPwmControllerProvider* value
    )
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, IPwmControllerProvider*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_GpioControllerProvider(
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider **")]
            IGpioControllerProvider* value
    )
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, IGpioControllerProvider*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_I2cControllerProvider(
        [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider **")]
            II2cControllerProvider* value
    )
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, II2cControllerProvider*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SpiControllerProvider(
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider **")]
            ISpiControllerProvider* value
    )
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProvider, ISpiControllerProvider*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AdcControllerProvider(
            [NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider **")]
                IAdcControllerProvider* value
        );

        [VtblIndex(7)]
        HRESULT get_PwmControllerProvider(
            [NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider **")]
                IPwmControllerProvider* value
        );

        [VtblIndex(8)]
        HRESULT get_GpioControllerProvider(
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider **")]
                IGpioControllerProvider* value
        );

        [VtblIndex(9)]
        HRESULT get_I2cControllerProvider(
            [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider **")]
                II2cControllerProvider* value
        );

        [VtblIndex(10)]
        HRESULT get_SpiControllerProvider(
            [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider **")]
                ISpiControllerProvider* value
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
            "HRESULT (ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAdcControllerProvider*, int> get_AdcControllerProvider;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPwmControllerProvider*, int> get_PwmControllerProvider;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IGpioControllerProvider*,
            int> get_GpioControllerProvider;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::I2c::Provider::II2cControllerProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, II2cControllerProvider*, int> get_I2cControllerProvider;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpiControllerProvider*, int> get_SpiControllerProvider;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILowLevelDevicesAggregateProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILowLevelDevicesAggregateProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILowLevelDevicesAggregateProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILowLevelDevicesAggregateProvider(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ILowLevelDevicesAggregateProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILowLevelDevicesAggregateProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILowLevelDevicesAggregateProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ILowLevelDevicesAggregateProvider value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILowLevelDevicesAggregateProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILowLevelDevicesAggregateProvider(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ILowLevelDevicesAggregateProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILowLevelDevicesAggregateProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILowLevelDevicesAggregateProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ILowLevelDevicesAggregateProvider value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
