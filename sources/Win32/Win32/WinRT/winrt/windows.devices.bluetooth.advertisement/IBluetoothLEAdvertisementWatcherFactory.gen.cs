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

[Guid("9AAF2D56-39AC-453E-B32A-85C657E017F1")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcherFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcherFactory
    : IBluetoothLEAdvertisementWatcherFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementWatcherFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcherFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisementWatcherFactory, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisementWatcherFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *"
        )]
            IBluetoothLEAdvertisementFilter advertisementFilter,
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementWatcher **"
        )]
            IBluetoothLEAdvertisementWatcher* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisementWatcherFactory,
                IBluetoothLEAdvertisementFilter,
                IBluetoothLEAdvertisementWatcher*,
                int>)((*lpVtbl)[6])
        )(this, advertisementFilter, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *"
            )]
                IBluetoothLEAdvertisementFilter advertisementFilter,
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementWatcher **"
            )]
                IBluetoothLEAdvertisementWatcher* value
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementFilter *, ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothLEAdvertisementFilter,
            IBluetoothLEAdvertisementWatcher*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAdvertisementWatcherFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAdvertisementWatcherFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAdvertisementWatcherFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementWatcherFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBluetoothLEAdvertisementWatcherFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementWatcherFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementWatcherFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBluetoothLEAdvertisementWatcherFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAdvertisementWatcherFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisementWatcherFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBluetoothLEAdvertisementWatcherFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisementWatcherFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisementWatcherFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBluetoothLEAdvertisementWatcherFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
