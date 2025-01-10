// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AA8CB1C9-E78D-4BE4-8076-0A3D87A0A05F")]
[NativeTypeName("struct IRfcommDeviceServiceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommDeviceServiceStatics2
    : IRfcommDeviceServiceStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommDeviceServiceStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRfcommDeviceServiceStatics2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRfcommDeviceServiceStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRfcommDeviceServiceStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IRfcommDeviceServiceStatics2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRfcommDeviceServiceStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRfcommDeviceServiceStatics2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelectorForBluetoothDevice(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
            IBluetoothDevice bluetoothDevice,
        HSTRING* selector
    )
    {
        return (
            (delegate* unmanaged<IRfcommDeviceServiceStatics2, IBluetoothDevice, HSTRING*, int>)(
                (*lpVtbl)[6]
            )
        )(this, bluetoothDevice, selector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceWithCacheMode(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
            IBluetoothDevice bluetoothDevice,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        HSTRING* selector
    )
    {
        return (
            (delegate* unmanaged<
                IRfcommDeviceServiceStatics2,
                IBluetoothDevice,
                BluetoothCacheMode,
                HSTRING*,
                int>)((*lpVtbl)[7])
        )(this, bluetoothDevice, cacheMode, selector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceId(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
            IBluetoothDevice bluetoothDevice,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")]
            IRfcommServiceId serviceId,
        HSTRING* selector
    )
    {
        return (
            (delegate* unmanaged<
                IRfcommDeviceServiceStatics2,
                IBluetoothDevice,
                IRfcommServiceId,
                HSTRING*,
                int>)((*lpVtbl)[8])
        )(this, bluetoothDevice, serviceId, selector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
            IBluetoothDevice bluetoothDevice,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")]
            IRfcommServiceId serviceId,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        HSTRING* selector
    )
    {
        return (
            (delegate* unmanaged<
                IRfcommDeviceServiceStatics2,
                IBluetoothDevice,
                IRfcommServiceId,
                BluetoothCacheMode,
                HSTRING*,
                int>)((*lpVtbl)[9])
        )(this, bluetoothDevice, serviceId, cacheMode, selector);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelectorForBluetoothDevice(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
                IBluetoothDevice bluetoothDevice,
            HSTRING* selector
        );

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorForBluetoothDeviceWithCacheMode(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
                IBluetoothDevice bluetoothDevice,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            HSTRING* selector
        );

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceId(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
                IBluetoothDevice bluetoothDevice,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")]
                IRfcommServiceId serviceId,
            HSTRING* selector
        );

        [VtblIndex(9)]
        HRESULT GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice *")]
                IBluetoothDevice bluetoothDevice,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")]
                IRfcommServiceId serviceId,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            HSTRING* selector
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDevice,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDevice,
            BluetoothCacheMode,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDeviceWithCacheMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDevice,
            IRfcommServiceId,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDeviceAndServiceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice *, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDevice,
            IRfcommServiceId,
            BluetoothCacheMode,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRfcommDeviceServiceStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRfcommDeviceServiceStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRfcommDeviceServiceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRfcommDeviceServiceStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new IRfcommDeviceServiceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommDeviceServiceStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommDeviceServiceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRfcommDeviceServiceStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRfcommDeviceServiceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRfcommDeviceServiceStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new IRfcommDeviceServiceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommDeviceServiceStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommDeviceServiceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRfcommDeviceServiceStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
