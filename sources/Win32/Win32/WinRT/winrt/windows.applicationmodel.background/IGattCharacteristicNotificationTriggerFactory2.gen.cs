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

[Guid("5998E91F-8A53-4E9F-A32C-23CD33664CEE")]
[NativeTypeName("struct IGattCharacteristicNotificationTriggerFactory2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristicNotificationTriggerFactory2
    : IGattCharacteristicNotificationTriggerFactory2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IGattCharacteristicNotificationTriggerFactory2)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IGattCharacteristicNotificationTriggerFactory2,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IGattCharacteristicNotificationTriggerFactory2, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IGattCharacteristicNotificationTriggerFactory2, uint>)(
                (*lpVtbl)[2]
            )
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
            (delegate* unmanaged<
                IGattCharacteristicNotificationTriggerFactory2,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IGattCharacteristicNotificationTriggerFactory2, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IGattCharacteristicNotificationTriggerFactory2, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithEventTriggeringMode(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *"
        )]
            IGattCharacteristic characteristic,
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode"
        )]
            BluetoothEventTriggeringMode eventTriggeringMode,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IGattCharacteristicNotificationTrigger **"
        )]
            IGattCharacteristicNotificationTrigger* result
    )
    {
        return (
            (delegate* unmanaged<
                IGattCharacteristicNotificationTriggerFactory2,
                IGattCharacteristic,
                BluetoothEventTriggeringMode,
                IGattCharacteristicNotificationTrigger*,
                int>)((*lpVtbl)[6])
        )(this, characteristic, eventTriggeringMode, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithEventTriggeringMode(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *"
            )]
                IGattCharacteristic characteristic,
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode"
            )]
                BluetoothEventTriggeringMode eventTriggeringMode,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IGattCharacteristicNotificationTrigger **"
            )]
                IGattCharacteristicNotificationTrigger* result
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *, ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode, ABI::Windows::ApplicationModel::Background::IGattCharacteristicNotificationTrigger **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IGattCharacteristic,
            BluetoothEventTriggeringMode,
            IGattCharacteristicNotificationTrigger*,
            int> CreateWithEventTriggeringMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattCharacteristicNotificationTriggerFactory2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattCharacteristicNotificationTriggerFactory2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattCharacteristicNotificationTriggerFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattCharacteristicNotificationTriggerFactory2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IGattCharacteristicNotificationTriggerFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattCharacteristicNotificationTriggerFactory2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattCharacteristicNotificationTriggerFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IGattCharacteristicNotificationTriggerFactory2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattCharacteristicNotificationTriggerFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattCharacteristicNotificationTriggerFactory2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IGattCharacteristicNotificationTriggerFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattCharacteristicNotificationTriggerFactory2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattCharacteristicNotificationTriggerFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IGattCharacteristicNotificationTriggerFactory2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
