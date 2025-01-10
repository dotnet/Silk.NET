// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C29E8E2F-4E14-4477-AA1B-B8B47E5B7ECE")]
[NativeTypeName("struct IBluetoothDeviceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothDeviceStatics2
    : IBluetoothDeviceStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothDeviceStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBluetoothDeviceStatics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBluetoothDeviceStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothDeviceStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBluetoothDeviceStatics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBluetoothDeviceStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBluetoothDeviceStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelectorFromPairingState(
        [NativeTypeName("boolean")] byte pairingState,
        HSTRING* deviceSelector
    )
    {
        return ((delegate* unmanaged<IBluetoothDeviceStatics2, byte, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            pairingState,
            deviceSelector
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorFromConnectionStatus(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus")]
            BluetoothConnectionStatus connectionStatus,
        HSTRING* deviceSelector
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothDeviceStatics2,
                BluetoothConnectionStatus,
                HSTRING*,
                int>)((*lpVtbl)[7])
        )(this, connectionStatus, deviceSelector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorFromDeviceName(HSTRING deviceName, HSTRING* deviceSelector)
    {
        return (
            (delegate* unmanaged<IBluetoothDeviceStatics2, HSTRING, HSTRING*, int>)((*lpVtbl)[8])
        )(this, deviceName, deviceSelector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelectorFromBluetoothAddress(
        [NativeTypeName("UINT64")] ulong bluetoothAddress,
        HSTRING* deviceSelector
    )
    {
        return (
            (delegate* unmanaged<IBluetoothDeviceStatics2, ulong, HSTRING*, int>)((*lpVtbl)[9])
        )(this, bluetoothAddress, deviceSelector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceSelectorFromClassOfDevice(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice *")]
            IBluetoothClassOfDevice classOfDevice,
        HSTRING* deviceSelector
    )
    {
        return (
            (delegate* unmanaged<IBluetoothDeviceStatics2, IBluetoothClassOfDevice, HSTRING*, int>)(
                (*lpVtbl)[10]
            )
        )(this, classOfDevice, deviceSelector);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelectorFromPairingState(
            [NativeTypeName("boolean")] byte pairingState,
            HSTRING* deviceSelector
        );

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorFromConnectionStatus(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus")]
                BluetoothConnectionStatus connectionStatus,
            HSTRING* deviceSelector
        );

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorFromDeviceName(HSTRING deviceName, HSTRING* deviceSelector);

        [VtblIndex(9)]
        HRESULT GetDeviceSelectorFromBluetoothAddress(
            [NativeTypeName("UINT64")] ulong bluetoothAddress,
            HSTRING* deviceSelector
        );

        [VtblIndex(10)]
        HRESULT GetDeviceSelectorFromClassOfDevice(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice *")]
                IBluetoothClassOfDevice classOfDevice,
            HSTRING* deviceSelector
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

        [NativeTypeName("HRESULT (boolean, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, HSTRING*, int> GetDeviceSelectorFromPairingState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothConnectionStatus,
            HSTRING*,
            int> GetDeviceSelectorFromConnectionStatus;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING*, int> GetDeviceSelectorFromDeviceName;

        [NativeTypeName("HRESULT (UINT64, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            HSTRING*,
            int> GetDeviceSelectorFromBluetoothAddress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice *, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothClassOfDevice,
            HSTRING*,
            int> GetDeviceSelectorFromClassOfDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothDeviceStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothDeviceStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothDeviceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothDeviceStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new IBluetoothDeviceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothDeviceStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothDeviceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBluetoothDeviceStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothDeviceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothDeviceStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new IBluetoothDeviceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothDeviceStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothDeviceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBluetoothDeviceStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
