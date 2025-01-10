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

[Guid("54C076B8-ECFB-4944-B928-74FC504D47EE")]
[NativeTypeName("struct IProximitySensor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProximitySensor : IProximitySensor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProximitySensor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProximitySensor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IProximitySensor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProximitySensor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IProximitySensor, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProximitySensor, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProximitySensor, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<IProximitySensor, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxDistanceInMillimeters(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IProximitySensor, IReference<uint>**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinDistanceInMillimeters(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IProximitySensor, IReference<uint>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCurrentReading(
        [NativeTypeName("ABI::Windows::Devices::Sensors::IProximitySensorReading **")]
            IProximitySensorReading* value
    )
    {
        return (
            (delegate* unmanaged<IProximitySensor, IProximitySensorReading*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ReadingChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CProximitySensor_Windows__CDevices__CSensors__CProximitySensorReadingChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IProximitySensor,
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
            (delegate* unmanaged<IProximitySensor, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateDisplayOnOffController(
        [NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable* controller
    )
    {
        return ((delegate* unmanaged<IProximitySensor, IClosable*, int>)((*lpVtbl)[12]))(
            this,
            controller
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MaxDistanceInMillimeters(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(8)]
        HRESULT get_MinDistanceInMillimeters(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(9)]
        HRESULT GetCurrentReading(
            [NativeTypeName("ABI::Windows::Devices::Sensors::IProximitySensorReading **")]
                IProximitySensorReading* value
        );

        [VtblIndex(10)]
        HRESULT add_ReadingChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CProximitySensor_Windows__CDevices__CSensors__CProximitySensorReadingChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_ReadingChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT CreateDisplayOnOffController(
            [NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable* controller
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_MaxDistanceInMillimeters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_MinDistanceInMillimeters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::IProximitySensorReading **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IProximitySensorReading*, int> GetCurrentReading;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CProximitySensor_Windows__CDevices__CSensors__CProximitySensorReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IClosable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IClosable*, int> CreateDisplayOnOffController;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProximitySensor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProximitySensor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProximitySensor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProximitySensor(Silk.NET.WinRT.IInspectable value)
    {
        return new IProximitySensor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProximitySensor"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProximitySensor"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IProximitySensor value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProximitySensor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProximitySensor(Silk.NET.Windows.IUnknown value)
    {
        return new IProximitySensor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProximitySensor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProximitySensor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProximitySensor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
