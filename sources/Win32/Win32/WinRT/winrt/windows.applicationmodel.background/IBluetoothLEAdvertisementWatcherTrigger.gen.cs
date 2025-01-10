// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1AAB1819-BCE1-48EB-A827-59FB7CEE52A6")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcherTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcherTrigger
    : IBluetoothLEAdvertisementWatcherTrigger.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementWatcherTrigger));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinSamplingInterval(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, TimeSpan*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxSamplingInterval(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, TimeSpan*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinOutOfRangeTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, TimeSpan*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxOutOfRangeTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherTrigger, TimeSpan*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SignalStrengthFilter(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")]
            IBluetoothSignalStrengthFilter* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcherTrigger,
                IBluetoothSignalStrengthFilter*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SignalStrengthFilter(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")]
            IBluetoothSignalStrengthFilter value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcherTrigger,
                IBluetoothSignalStrengthFilter,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AdvertisementFilter(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **"
        )]
            IBluetoothLEAdvertisementFilter* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcherTrigger,
                IBluetoothLEAdvertisementFilter*,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AdvertisementFilter(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *"
        )]
            IBluetoothLEAdvertisementFilter value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcherTrigger,
                IBluetoothLEAdvertisementFilter,
                int>)((*lpVtbl)[13])
        )(this, value);
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
        HRESULT get_SignalStrengthFilter(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter **")]
                IBluetoothSignalStrengthFilter* value
        );

        [VtblIndex(11)]
        HRESULT put_SignalStrengthFilter(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothSignalStrengthFilter *")]
                IBluetoothSignalStrengthFilter value
        );

        [VtblIndex(12)]
        HRESULT get_AdvertisementFilter(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter **"
            )]
                IBluetoothLEAdvertisementFilter* value
        );

        [VtblIndex(13)]
        HRESULT put_AdvertisementFilter(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *"
            )]
                IBluetoothLEAdvertisementFilter value
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MinSamplingInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MaxSamplingInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MinOutOfRangeTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MaxOutOfRangeTimeout;

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
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAdvertisementWatcherTrigger"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAdvertisementWatcherTrigger(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAdvertisementWatcherTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementWatcherTrigger(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBluetoothLEAdvertisementWatcherTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementWatcherTrigger"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementWatcherTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBluetoothLEAdvertisementWatcherTrigger value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAdvertisementWatcherTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementWatcherTrigger(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBluetoothLEAdvertisementWatcherTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementWatcherTrigger"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementWatcherTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBluetoothLEAdvertisementWatcherTrigger value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
