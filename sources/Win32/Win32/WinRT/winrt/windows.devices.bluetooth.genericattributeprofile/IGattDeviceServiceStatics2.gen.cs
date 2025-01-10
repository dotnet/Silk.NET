// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0604186E-24A6-4B0D-A2F2-30CC01545D25")]
[NativeTypeName("struct IGattDeviceServiceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceServiceStatics2
    : IGattDeviceServiceStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceServiceStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattDeviceServiceStatics2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGattDeviceServiceStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattDeviceServiceStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceServiceStatics2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattDeviceServiceStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGattDeviceServiceStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdWithSharingModeAsync(
        HSTRING deviceId,
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode"
        )]
            GattSharingMode sharingMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceServiceStatics2,
                HSTRING,
                GattSharingMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, deviceId, sharingMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceId(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
            IBluetoothDeviceId bluetoothDeviceId,
        HSTRING* result
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceServiceStatics2, IBluetoothDeviceId, HSTRING*, int>)(
                (*lpVtbl)[7]
            )
        )(this, bluetoothDeviceId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceIdWithCacheMode(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
            IBluetoothDeviceId bluetoothDeviceId,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        HSTRING* result
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceServiceStatics2,
                IBluetoothDeviceId,
                BluetoothCacheMode,
                HSTRING*,
                int>)((*lpVtbl)[8])
        )(this, bluetoothDeviceId, cacheMode, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuid(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
            IBluetoothDeviceId bluetoothDeviceId,
        Guid serviceUuid,
        HSTRING* result
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceServiceStatics2,
                IBluetoothDeviceId,
                Guid,
                HSTRING*,
                int>)((*lpVtbl)[9])
        )(this, bluetoothDeviceId, serviceUuid, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
            IBluetoothDeviceId bluetoothDeviceId,
        Guid serviceUuid,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        HSTRING* result
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceServiceStatics2,
                IBluetoothDeviceId,
                Guid,
                BluetoothCacheMode,
                HSTRING*,
                int>)((*lpVtbl)[10])
        )(this, bluetoothDeviceId, serviceUuid, cacheMode, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdWithSharingModeAsync(
            HSTRING deviceId,
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode"
            )]
                GattSharingMode sharingMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorForBluetoothDeviceId(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
                IBluetoothDeviceId bluetoothDeviceId,
            HSTRING* result
        );

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorForBluetoothDeviceIdWithCacheMode(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
                IBluetoothDeviceId bluetoothDeviceId,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            HSTRING* result
        );

        [VtblIndex(9)]
        HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuid(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
                IBluetoothDeviceId bluetoothDeviceId,
            Guid serviceUuid,
            HSTRING* result
        );

        [VtblIndex(10)]
        HRESULT GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *")]
                IBluetoothDeviceId bluetoothDeviceId,
            Guid serviceUuid,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            HSTRING* result
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
            "HRESULT (HSTRING, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            GattSharingMode,
            IAsyncOperation<IntPtr>**,
            int> FromIdWithSharingModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDeviceId,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDeviceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDeviceId,
            BluetoothCacheMode,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDeviceIdWithCacheMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, GUID, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDeviceId,
            Guid,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDeviceIdAndUuid;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId *, GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothDeviceId,
            Guid,
            BluetoothCacheMode,
            HSTRING*,
            int> GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattDeviceServiceStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattDeviceServiceStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattDeviceServiceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattDeviceServiceStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattDeviceServiceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceServiceStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceServiceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattDeviceServiceStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattDeviceServiceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattDeviceServiceStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new IGattDeviceServiceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceServiceStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceServiceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattDeviceServiceStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
