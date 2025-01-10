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

[Guid("CDE820F9-D9FA-43D6-A264-DDD8B7DA8B78")]
[NativeTypeName("struct IBluetoothLEAdvertisementPublisher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementPublisher
    : IBluetoothLEAdvertisementPublisher.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementPublisher));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementPublisher, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementPublisher, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementPublisher, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementPublisher, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementPublisher, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementPublisher, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPublisherStatus *"
        )]
            BluetoothLEAdvertisementPublisherStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementPublisher,
                BluetoothLEAdvertisementPublisherStatus*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Advertisement(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **"
        )]
            IBluetoothLEAdvertisement* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementPublisher,
                IBluetoothLEAdvertisement*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementPublisher, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementPublisher, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_StatusChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisherStatusChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementPublisher,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_StatusChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementPublisher, EventRegistrationToken, int>)(
                (*lpVtbl)[11]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPublisherStatus *"
            )]
                BluetoothLEAdvertisementPublisherStatus* value
        );

        [VtblIndex(7)]
        HRESULT get_Advertisement(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **"
            )]
                IBluetoothLEAdvertisement* value
        );

        [VtblIndex(8)]
        HRESULT Start();

        [VtblIndex(9)]
        HRESULT Stop();

        [VtblIndex(10)]
        HRESULT add_StatusChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisherStatusChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_StatusChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::BluetoothLEAdvertisementPublisherStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothLEAdvertisementPublisherStatus*,
            int> get_Status;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBluetoothLEAdvertisement*, int> get_Advertisement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisher_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementPublisherStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_StatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_StatusChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAdvertisementPublisher"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAdvertisementPublisher(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAdvertisementPublisher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementPublisher(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBluetoothLEAdvertisementPublisher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementPublisher"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementPublisher"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBluetoothLEAdvertisementPublisher value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAdvertisementPublisher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementPublisher(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBluetoothLEAdvertisementPublisher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementPublisher"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementPublisher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBluetoothLEAdvertisementPublisher value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
