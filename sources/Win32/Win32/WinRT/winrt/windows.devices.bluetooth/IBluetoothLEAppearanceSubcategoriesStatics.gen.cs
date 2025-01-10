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

[Guid("E57BA606-2144-415A-8312-71CCF291F8D1")]
[NativeTypeName("struct IBluetoothLEAppearanceSubcategoriesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAppearanceSubcategoriesStatics
    : IBluetoothLEAppearanceSubcategoriesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAppearanceSubcategoriesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Generic([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SportsWatch([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ThermometerEar([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HeartRateBelt([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BloodPressureArm([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_BloodPressureWrist([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Keyboard([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Mouse([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Joystick([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Gamepad([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DigitizerTablet([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CardReader([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DigitalPen([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BarcodeScanner([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_RunningWalkingInShoe([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[20]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_RunningWalkingOnShoe([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_RunningWalkingOnHip([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[22]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CyclingComputer([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[23]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_CyclingSpeedSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[24]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_CyclingCadenceSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[25]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_CyclingPowerSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[26]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_CyclingSpeedCadenceSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[27]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_OximeterFingertip([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[28]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_OximeterWristWorn([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[29]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_LocationDisplay([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[30]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_LocationNavigationDisplay([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[31]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_LocationPod([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[32]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_LocationNavigationPod([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceSubcategoriesStatics, ushort*, int>)(
                (*lpVtbl)[33]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Generic([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_SportsWatch([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_ThermometerEar([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(9)]
        HRESULT get_HeartRateBelt([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(10)]
        HRESULT get_BloodPressureArm([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT get_BloodPressureWrist([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(12)]
        HRESULT get_Keyboard([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_Mouse([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(14)]
        HRESULT get_Joystick([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(15)]
        HRESULT get_Gamepad([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(16)]
        HRESULT get_DigitizerTablet([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(17)]
        HRESULT get_CardReader([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(18)]
        HRESULT get_DigitalPen([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(19)]
        HRESULT get_BarcodeScanner([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(20)]
        HRESULT get_RunningWalkingInShoe([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(21)]
        HRESULT get_RunningWalkingOnShoe([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(22)]
        HRESULT get_RunningWalkingOnHip([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(23)]
        HRESULT get_CyclingComputer([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(24)]
        HRESULT get_CyclingSpeedSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(25)]
        HRESULT get_CyclingCadenceSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(26)]
        HRESULT get_CyclingPowerSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(27)]
        HRESULT get_CyclingSpeedCadenceSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(28)]
        HRESULT get_OximeterFingertip([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(29)]
        HRESULT get_OximeterWristWorn([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(30)]
        HRESULT get_LocationDisplay([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(31)]
        HRESULT get_LocationNavigationDisplay([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(32)]
        HRESULT get_LocationPod([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(33)]
        HRESULT get_LocationNavigationPod([NativeTypeName("UINT16 *")] ushort* value);
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

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Generic;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_SportsWatch;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_ThermometerEar;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_HeartRateBelt;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BloodPressureArm;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BloodPressureWrist;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Keyboard;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Mouse;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Joystick;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Gamepad;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_DigitizerTablet;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_CardReader;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_DigitalPen;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BarcodeScanner;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_RunningWalkingInShoe;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_RunningWalkingOnShoe;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_RunningWalkingOnHip;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_CyclingComputer;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_CyclingSpeedSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_CyclingCadenceSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_CyclingPowerSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_CyclingSpeedCadenceSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_OximeterFingertip;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_OximeterWristWorn;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_LocationDisplay;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_LocationNavigationDisplay;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_LocationPod;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_LocationNavigationPod;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAppearanceSubcategoriesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAppearanceSubcategoriesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAppearanceSubcategoriesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAppearanceSubcategoriesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBluetoothLEAppearanceSubcategoriesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAppearanceSubcategoriesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAppearanceSubcategoriesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBluetoothLEAppearanceSubcategoriesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAppearanceSubcategoriesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAppearanceSubcategoriesStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBluetoothLEAppearanceSubcategoriesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAppearanceSubcategoriesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAppearanceSubcategoriesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBluetoothLEAppearanceSubcategoriesStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
