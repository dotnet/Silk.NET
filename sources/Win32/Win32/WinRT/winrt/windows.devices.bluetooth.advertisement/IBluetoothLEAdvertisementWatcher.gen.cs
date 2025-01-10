// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A6AC336F-F3D3-4297-8D6C-C81EA6623F40")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcher
    : IBluetoothLEAdvertisementWatcher.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementWatcher));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcher, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcher, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinSamplingInterval(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, TimeSpan*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxSamplingInterval(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, TimeSpan*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinOutOfRangeTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, TimeSpan*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxOutOfRangeTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, TimeSpan*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Status(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementWatcherStatus *"
        )]
            BluetoothLEAdvertisementWatcherStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcher,
                BluetoothLEAdvertisementWatcherStatus*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ScanningMode(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode *"
        )]
            BluetoothLEScanningMode* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, BluetoothLEScanningMode*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ScanningMode(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode")]
            BluetoothLEScanningMode value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, BluetoothLEScanningMode, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SignalStrengthFilter(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")]
            IBluetoothSignalStrengthFilter* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcher,
                IBluetoothSignalStrengthFilter*,
                int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_SignalStrengthFilter(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")]
            IBluetoothSignalStrengthFilter value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcher,
                IBluetoothSignalStrengthFilter,
                int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AdvertisementFilter(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **"
        )]
            IBluetoothLEAdvertisementFilter* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcher,
                IBluetoothLEAdvertisementFilter*,
                int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_AdvertisementFilter(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *"
        )]
            IBluetoothLEAdvertisementFilter value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcher,
                IBluetoothLEAdvertisementFilter,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcher, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcher, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_Received(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcher,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[19])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_Received(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, EventRegistrationToken, int>)(
                (*lpVtbl)[20]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_Stopped(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcherStoppedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcher,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[21])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_Stopped(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcher, EventRegistrationToken, int>)(
                (*lpVtbl)[22]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MinSamplingInterval(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(7)]
        HRESULT get_MaxSamplingInterval(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(8)]
        HRESULT get_MinOutOfRangeTimeout(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(9)]
        HRESULT get_MaxOutOfRangeTimeout(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(10)]
        HRESULT get_Status(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementWatcherStatus *"
            )]
                BluetoothLEAdvertisementWatcherStatus* value
        );

        [VtblIndex(11)]
        HRESULT get_ScanningMode(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode *"
            )]
                BluetoothLEScanningMode* value
        );

        [VtblIndex(12)]
        HRESULT put_ScanningMode(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode"
            )]
                BluetoothLEScanningMode value
        );

        [VtblIndex(13)]
        HRESULT get_SignalStrengthFilter(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")]
                IBluetoothSignalStrengthFilter* value
        );

        [VtblIndex(14)]
        HRESULT put_SignalStrengthFilter(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")]
                IBluetoothSignalStrengthFilter value
        );

        [VtblIndex(15)]
        HRESULT get_AdvertisementFilter(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **"
            )]
                IBluetoothLEAdvertisementFilter* value
        );

        [VtblIndex(16)]
        HRESULT put_AdvertisementFilter(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *"
            )]
                IBluetoothLEAdvertisementFilter value
        );

        [VtblIndex(17)]
        HRESULT Start();

        [VtblIndex(18)]
        HRESULT Stop();

        [VtblIndex(19)]
        HRESULT add_Received(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(20)]
        HRESULT remove_Received(EventRegistrationToken token);

        [VtblIndex(21)]
        HRESULT add_Stopped(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcherStoppedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(22)]
        HRESULT remove_Stopped(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MinSamplingInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MaxSamplingInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MinOutOfRangeTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MaxOutOfRangeTimeout;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementWatcherStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BluetoothLEAdvertisementWatcherStatus*, int> get_Status;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BluetoothLEScanningMode*, int> get_ScanningMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEScanningMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BluetoothLEScanningMode, int> put_ScanningMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothSignalStrengthFilter*,
            int> get_SignalStrengthFilter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothSignalStrengthFilter,
            int> put_SignalStrengthFilter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothLEAdvertisementFilter*,
            int> get_AdvertisementFilter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothLEAdvertisementFilter,
            int> put_AdvertisementFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Received;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Received;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementWatcherStoppedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Stopped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Stopped;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAdvertisementWatcher"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAdvertisementWatcher(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAdvertisementWatcher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementWatcher(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBluetoothLEAdvertisementWatcher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementWatcher"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementWatcher"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBluetoothLEAdvertisementWatcher value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAdvertisementWatcher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementWatcher(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBluetoothLEAdvertisementWatcher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementWatcher"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementWatcher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBluetoothLEAdvertisementWatcher value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
