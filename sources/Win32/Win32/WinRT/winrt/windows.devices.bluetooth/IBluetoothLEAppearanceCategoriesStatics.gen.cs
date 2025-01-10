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

[Guid("6D4D54FE-046A-4185-AAB6-824CF0610861")]
[NativeTypeName("struct IBluetoothLEAppearanceCategoriesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAppearanceCategoriesStatics
    : IBluetoothLEAppearanceCategoriesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAppearanceCategoriesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Uncategorized([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Phone([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Computer([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Watch([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Clock([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Display([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RemoteControl([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_EyeGlasses([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Tag([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Keyring([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_MediaPlayer([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BarcodeScanner([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Thermometer([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_HeartRate([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_BloodPressure([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[20]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_HumanInterfaceDevice([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_GlucoseMeter([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[22]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_RunningWalking([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[23]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Cycling([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[24]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_PulseOximeter([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[25]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_WeightScale([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[26]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_OutdoorSportActivity([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceCategoriesStatics, ushort*, int>)(
                (*lpVtbl)[27]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Uncategorized([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_Phone([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_Computer([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(9)]
        HRESULT get_Watch([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(10)]
        HRESULT get_Clock([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT get_Display([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(12)]
        HRESULT get_RemoteControl([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_EyeGlasses([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(14)]
        HRESULT get_Tag([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(15)]
        HRESULT get_Keyring([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(16)]
        HRESULT get_MediaPlayer([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(17)]
        HRESULT get_BarcodeScanner([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(18)]
        HRESULT get_Thermometer([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(19)]
        HRESULT get_HeartRate([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(20)]
        HRESULT get_BloodPressure([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(21)]
        HRESULT get_HumanInterfaceDevice([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(22)]
        HRESULT get_GlucoseMeter([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(23)]
        HRESULT get_RunningWalking([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(24)]
        HRESULT get_Cycling([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(25)]
        HRESULT get_PulseOximeter([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(26)]
        HRESULT get_WeightScale([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(27)]
        HRESULT get_OutdoorSportActivity([NativeTypeName("UINT16 *")] ushort* value);
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
        public delegate* unmanaged<TSelf*, ushort*, int> get_Uncategorized;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Phone;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Computer;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Watch;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Clock;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Display;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_RemoteControl;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_EyeGlasses;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Tag;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Keyring;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_MediaPlayer;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BarcodeScanner;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Thermometer;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_HeartRate;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BloodPressure;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_HumanInterfaceDevice;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_GlucoseMeter;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_RunningWalking;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Cycling;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_PulseOximeter;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_WeightScale;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_OutdoorSportActivity;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAppearanceCategoriesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAppearanceCategoriesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAppearanceCategoriesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAppearanceCategoriesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBluetoothLEAppearanceCategoriesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAppearanceCategoriesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAppearanceCategoriesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBluetoothLEAppearanceCategoriesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAppearanceCategoriesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAppearanceCategoriesStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBluetoothLEAppearanceCategoriesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAppearanceCategoriesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAppearanceCategoriesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBluetoothLEAppearanceCategoriesStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
