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

[Guid("9AC4AAF6-3473-465E-96D5-36281A2C57AF")]
[NativeTypeName("struct ILowLevelDevicesAggregateProviderFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLevelDevicesAggregateProviderFactory
    : ILowLevelDevicesAggregateProviderFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILowLevelDevicesAggregateProviderFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProviderFactory, Guid*, void**, int>)(
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
            (delegate* unmanaged<ILowLevelDevicesAggregateProviderFactory, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProviderFactory, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<ILowLevelDevicesAggregateProviderFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProviderFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ILowLevelDevicesAggregateProviderFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider *")]
            IAdcControllerProvider adc,
        [NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider *")]
            IPwmControllerProvider pwm,
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider *")]
            IGpioControllerProvider gpio,
        [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider *")]
            II2cControllerProvider i2c,
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider *")]
            ISpiControllerProvider spi,
        [NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **")]
            ILowLevelDevicesAggregateProvider* value
    )
    {
        return (
            (delegate* unmanaged<
                ILowLevelDevicesAggregateProviderFactory,
                IAdcControllerProvider,
                IPwmControllerProvider,
                IGpioControllerProvider,
                II2cControllerProvider,
                ISpiControllerProvider,
                ILowLevelDevicesAggregateProvider*,
                int>)((*lpVtbl)[6])
        )(this, adc, pwm, gpio, i2c, spi, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider *")]
                IAdcControllerProvider adc,
            [NativeTypeName("ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider *")]
                IPwmControllerProvider pwm,
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider *")]
                IGpioControllerProvider gpio,
            [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cControllerProvider *")]
                II2cControllerProvider i2c,
            [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider *")]
                ISpiControllerProvider spi,
            [NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **")]
                ILowLevelDevicesAggregateProvider* value
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
            "HRESULT (ABI::Windows::Devices::Adc::Provider::IAdcControllerProvider *, ABI::Windows::Devices::Pwm::Provider::IPwmControllerProvider *, ABI::Windows::Devices::Gpio::Provider::IGpioControllerProvider *, ABI::Windows::Devices::I2c::Provider::II2cControllerProvider *, ABI::Windows::Devices::Spi::Provider::ISpiControllerProvider *, ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAdcControllerProvider,
            IPwmControllerProvider,
            IGpioControllerProvider,
            II2cControllerProvider,
            ISpiControllerProvider,
            ILowLevelDevicesAggregateProvider*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILowLevelDevicesAggregateProviderFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILowLevelDevicesAggregateProviderFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILowLevelDevicesAggregateProviderFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILowLevelDevicesAggregateProviderFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ILowLevelDevicesAggregateProviderFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILowLevelDevicesAggregateProviderFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILowLevelDevicesAggregateProviderFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ILowLevelDevicesAggregateProviderFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILowLevelDevicesAggregateProviderFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILowLevelDevicesAggregateProviderFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ILowLevelDevicesAggregateProviderFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILowLevelDevicesAggregateProviderFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILowLevelDevicesAggregateProviderFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ILowLevelDevicesAggregateProviderFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
