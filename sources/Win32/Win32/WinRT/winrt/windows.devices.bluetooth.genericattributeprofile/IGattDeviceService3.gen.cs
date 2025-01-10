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

[Guid("B293A950-0C53-437C-A9B3-5C3210C6E569")]
[NativeTypeName("struct IGattDeviceService3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceService3 : IGattDeviceService3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceService3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGattDeviceService3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGattDeviceService3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattDeviceService3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGattDeviceService3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattDeviceService3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGattDeviceService3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceAccessInformation(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
            IDeviceAccessInformation* value
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService3, IDeviceAccessInformation*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Session(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSession **"
        )]
            IGattSession* value
    )
    {
        return ((delegate* unmanaged<IGattDeviceService3, IGattSession*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SharingMode(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode *"
        )]
            GattSharingMode* value
    )
    {
        return ((delegate* unmanaged<IGattDeviceService3, GattSharingMode*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **"
        )]
            IAsyncOperation<DeviceAccessStatus>** value
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService3, IAsyncOperation<DeviceAccessStatus>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenAsync(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode"
        )]
            GattSharingMode sharingMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattOpenStatus_t **"
        )]
            IAsyncOperation<GattOpenStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceService3,
                GattSharingMode,
                IAsyncOperation<GattOpenStatus>**,
                int>)((*lpVtbl)[10])
        )(this, sharingMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCharacteristicsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService3, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCharacteristicsWithCacheModeAsync(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceService3,
                BluetoothCacheMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, cacheMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCharacteristicsForUuidAsync(
        Guid characteristicUuid,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService3, Guid, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, characteristicUuid, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCharacteristicsForUuidWithCacheModeAsync(
        Guid characteristicUuid,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceService3,
                Guid,
                BluetoothCacheMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[14])
        )(this, characteristicUuid, cacheMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetIncludedServicesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService3, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetIncludedServicesWithCacheModeAsync(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceService3,
                BluetoothCacheMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[16])
        )(this, cacheMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetIncludedServicesForUuidAsync(
        Guid serviceUuid,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService3, Guid, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[17]
            )
        )(this, serviceUuid, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetIncludedServicesForUuidWithCacheModeAsync(
        Guid serviceUuid,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IGattDeviceService3,
                Guid,
                BluetoothCacheMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[18])
        )(this, serviceUuid, cacheMode, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceAccessInformation(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
                IDeviceAccessInformation* value
        );

        [VtblIndex(7)]
        HRESULT get_Session(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSession **"
            )]
                IGattSession* value
        );

        [VtblIndex(8)]
        HRESULT get_SharingMode(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode *"
            )]
                GattSharingMode* value
        );

        [VtblIndex(9)]
        HRESULT RequestAccessAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **"
            )]
                IAsyncOperation<DeviceAccessStatus>** value
        );

        [VtblIndex(10)]
        HRESULT OpenAsync(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode"
            )]
                GattSharingMode sharingMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattOpenStatus_t **"
            )]
                IAsyncOperation<GattOpenStatus>** operation
        );

        [VtblIndex(11)]
        HRESULT GetCharacteristicsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT GetCharacteristicsWithCacheModeAsync(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(13)]
        HRESULT GetCharacteristicsForUuidAsync(
            Guid characteristicUuid,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(14)]
        HRESULT GetCharacteristicsForUuidWithCacheModeAsync(
            Guid characteristicUuid,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(15)]
        HRESULT GetIncludedServicesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(16)]
        HRESULT GetIncludedServicesWithCacheModeAsync(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(17)]
        HRESULT GetIncludedServicesForUuidAsync(
            Guid serviceUuid,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(18)]
        HRESULT GetIncludedServicesForUuidWithCacheModeAsync(
            Guid serviceUuid,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDeviceAccessInformation*,
            int> get_DeviceAccessInformation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSession **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IGattSession*, int> get_Session;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattSharingMode*, int> get_SharingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<DeviceAccessStatus>**,
            int> RequestAccessAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSharingMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattOpenStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GattSharingMode,
            IAsyncOperation<GattOpenStatus>**,
            int> OpenAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetCharacteristicsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothCacheMode,
            IAsyncOperation<IntPtr>**,
            int> GetCharacteristicsWithCacheModeAsync;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            IAsyncOperation<IntPtr>**,
            int> GetCharacteristicsForUuidAsync;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            BluetoothCacheMode,
            IAsyncOperation<IntPtr>**,
            int> GetCharacteristicsForUuidWithCacheModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetIncludedServicesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothCacheMode,
            IAsyncOperation<IntPtr>**,
            int> GetIncludedServicesWithCacheModeAsync;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            IAsyncOperation<IntPtr>**,
            int> GetIncludedServicesForUuidAsync;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceServicesResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            BluetoothCacheMode,
            IAsyncOperation<IntPtr>**,
            int> GetIncludedServicesForUuidWithCacheModeAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattDeviceService3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattDeviceService3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattDeviceService3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattDeviceService3(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattDeviceService3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceService3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceService3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattDeviceService3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattDeviceService3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattDeviceService3(Silk.NET.Windows.IUnknown value)
    {
        return new IGattDeviceService3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceService3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceService3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattDeviceService3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
