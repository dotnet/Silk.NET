// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AD11CEC7-19EA-4B21-874F-B91AED4A25DB")]
[NativeTypeName("struct IGpioControllerProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioControllerProvider
    : IGpioControllerProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioControllerProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGpioControllerProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGpioControllerProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGpioControllerProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGpioControllerProvider, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGpioControllerProvider, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGpioControllerProvider, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IGpioControllerProvider, int*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenPinProvider(
        [NativeTypeName("INT32")] int pin,
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode")]
            ProviderGpioSharingMode sharingMode,
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioPinProvider **")]
            IGpioPinProvider* gpioPinProvider
    )
    {
        return (
            (delegate* unmanaged<
                IGpioControllerProvider,
                int,
                ProviderGpioSharingMode,
                IGpioPinProvider*,
                int>)((*lpVtbl)[7])
        )(this, pin, sharingMode, gpioPinProvider);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT OpenPinProvider(
            [NativeTypeName("INT32")] int pin,
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode")]
                ProviderGpioSharingMode sharingMode,
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::IGpioPinProvider **")]
                IGpioPinProvider* gpioPinProvider
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PinCount;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode, ABI::Windows::Devices::Gpio::Provider::IGpioPinProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            ProviderGpioSharingMode,
            IGpioPinProvider*,
            int> OpenPinProvider;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGpioControllerProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGpioControllerProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGpioControllerProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGpioControllerProvider(Silk.NET.WinRT.IInspectable value)
    {
        return new IGpioControllerProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioControllerProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioControllerProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGpioControllerProvider value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGpioControllerProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGpioControllerProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IGpioControllerProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioControllerProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioControllerProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGpioControllerProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
