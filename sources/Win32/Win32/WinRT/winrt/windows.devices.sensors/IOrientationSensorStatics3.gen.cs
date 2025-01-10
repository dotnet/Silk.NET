// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D82CE920-2777-40FF-9F59-D654B085F12F")]
[NativeTypeName("struct IOrientationSensorStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOrientationSensorStatics3
    : IOrientationSensorStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOrientationSensorStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IOrientationSensorStatics3, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOrientationSensorStatics3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOrientationSensorStatics3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IOrientationSensorStatics3, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IOrientationSensorStatics3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IOrientationSensorStatics3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultWithSensorReadingType(
        [NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")]
            SensorReadingType sensorReadingtype,
        [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")]
            IOrientationSensor* result
    )
    {
        return (
            (delegate* unmanaged<
                IOrientationSensorStatics3,
                SensorReadingType,
                IOrientationSensor*,
                int>)((*lpVtbl)[6])
        )(this, sensorReadingtype, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal(
        [NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")]
            SensorReadingType sensorReadingType,
        [NativeTypeName("ABI::Windows::Devices::Sensors::SensorOptimizationGoal")]
            SensorOptimizationGoal optimizationGoal,
        [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")]
            IOrientationSensor* result
    )
    {
        return (
            (delegate* unmanaged<
                IOrientationSensorStatics3,
                SensorReadingType,
                SensorOptimizationGoal,
                IOrientationSensor*,
                int>)((*lpVtbl)[7])
        )(this, sensorReadingType, optimizationGoal, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultWithSensorReadingType(
            [NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")]
                SensorReadingType sensorReadingtype,
            [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")]
                IOrientationSensor* result
        );

        [VtblIndex(7)]
        HRESULT GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal(
            [NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType")]
                SensorReadingType sensorReadingType,
            [NativeTypeName("ABI::Windows::Devices::Sensors::SensorOptimizationGoal")]
                SensorOptimizationGoal optimizationGoal,
            [NativeTypeName("ABI::Windows::Devices::Sensors::IOrientationSensor **")]
                IOrientationSensor* result
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
            "HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType, ABI::Windows::Devices::Sensors::IOrientationSensor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SensorReadingType,
            IOrientationSensor*,
            int> GetDefaultWithSensorReadingType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType, ABI::Windows::Devices::Sensors::SensorOptimizationGoal, ABI::Windows::Devices::Sensors::IOrientationSensor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SensorReadingType,
            SensorOptimizationGoal,
            IOrientationSensor*,
            int> GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOrientationSensorStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOrientationSensorStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IOrientationSensorStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IOrientationSensorStatics3(Silk.NET.WinRT.IInspectable value)
    {
        return new IOrientationSensorStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOrientationSensorStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IOrientationSensorStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IOrientationSensorStatics3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOrientationSensorStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOrientationSensorStatics3(Silk.NET.Windows.IUnknown value)
    {
        return new IOrientationSensorStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOrientationSensorStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOrientationSensorStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOrientationSensorStatics3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
