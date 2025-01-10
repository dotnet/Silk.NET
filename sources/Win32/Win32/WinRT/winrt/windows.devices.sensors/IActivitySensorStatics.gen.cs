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

[Guid("A71E0E9D-EE8B-45D1-B25B-08CC0DF92AB6")]
[NativeTypeName("struct IActivitySensorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivitySensorStatics : IActivitySensorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivitySensorStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActivitySensorStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IActivitySensorStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActivitySensorStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IActivitySensorStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IActivitySensorStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IActivitySensorStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IActivitySensorStatics, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector(HSTRING* value)
    {
        return ((delegate* unmanaged<IActivitySensorStatics, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromIdAsync(
        HSTRING deviceId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IActivitySensorStatics, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, deviceId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSystemHistoryAsync(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IActivitySensorStatics,
                WinRTDateTime,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, fromTime, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSystemHistoryWithDurationAsync(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IActivitySensorStatics,
                WinRTDateTime,
                TimeSpan,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, fromTime, duration, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT GetDeviceSelector(HSTRING* value);

        [VtblIndex(8)]
        HRESULT FromIdAsync(
            HSTRING deviceId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT GetSystemHistoryAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT GetSystemHistoryWithDurationAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime fromTime,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **"
            )]
                IAsyncOperation<IntPtr>** result
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetDefaultAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CActivitySensor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> FromIdAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            IAsyncOperation<IntPtr>**,
            int> GetSystemHistoryAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSensors__CActivitySensorReading_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            TimeSpan,
            IAsyncOperation<IntPtr>**,
            int> GetSystemHistoryWithDurationAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IActivitySensorStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IActivitySensorStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IActivitySensorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IActivitySensorStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IActivitySensorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActivitySensorStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IActivitySensorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IActivitySensorStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IActivitySensorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IActivitySensorStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IActivitySensorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActivitySensorStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IActivitySensorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IActivitySensorStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
