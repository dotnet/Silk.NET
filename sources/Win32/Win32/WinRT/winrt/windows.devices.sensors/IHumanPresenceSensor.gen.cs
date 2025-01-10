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

[Guid("2116788B-E389-5CC3-9A97-CB17BE1008BD")]
[NativeTypeName("struct IHumanPresenceSensor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensor : IHumanPresenceSensor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSensor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHumanPresenceSensor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxDetectableDistanceInMillimeters(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, IReference<uint>**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinDetectableDistanceInMillimeters(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IHumanPresenceSensor, IReference<uint>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCurrentReading(
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading **")]
            IHumanPresenceSensorReading* result
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensor, IHumanPresenceSensorReading*, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ReadingChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CHumanPresenceSensor_Windows__CDevices__CSensors__CHumanPresenceSensorReadingChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSensor,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ReadingChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensor, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MaxDetectableDistanceInMillimeters(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(8)]
        HRESULT get_MinDetectableDistanceInMillimeters(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(9)]
        HRESULT GetCurrentReading(
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading **")]
                IHumanPresenceSensorReading* result
        );

        [VtblIndex(10)]
        HRESULT add_ReadingChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CHumanPresenceSensor_Windows__CDevices__CSensors__CHumanPresenceSensorReadingChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_ReadingChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<uint>**,
            int> get_MaxDetectableDistanceInMillimeters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<uint>**,
            int> get_MinDetectableDistanceInMillimeters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHumanPresenceSensorReading*, int> GetCurrentReading;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CHumanPresenceSensor_Windows__CDevices__CSensors__CHumanPresenceSensorReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHumanPresenceSensor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHumanPresenceSensor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHumanPresenceSensor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensor(Silk.NET.WinRT.IInspectable value)
    {
        return new IHumanPresenceSensor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensor"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensor"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHumanPresenceSensor value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHumanPresenceSensor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensor(Silk.NET.Windows.IUnknown value)
    {
        return new IHumanPresenceSensor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHumanPresenceSensor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
