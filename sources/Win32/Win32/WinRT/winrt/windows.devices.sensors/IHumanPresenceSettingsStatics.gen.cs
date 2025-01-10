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

[Guid("7F343202-E010-52C4-AF0C-04A8F1E033DA")]
[NativeTypeName("struct IHumanPresenceSettingsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSettingsStatics
    : IHumanPresenceSettingsStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSettingsStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHumanPresenceSettingsStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHumanPresenceSettingsStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHumanPresenceSettingsStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentSettingsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceSettings_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentSettings(
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings **")]
            IHumanPresenceSettings* result
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, IHumanPresenceSettings*, int>)(
                (*lpVtbl)[7]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UpdateSettingsAsync(
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")]
            IHumanPresenceSettings settings,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSettingsStatics,
                IHumanPresenceSettings,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(this, settings, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UpdateSettings(
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")]
            IHumanPresenceSettings settings
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, IHumanPresenceSettings, int>)(
                (*lpVtbl)[9]
            )
        )(this, settings);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSupportedFeaturesForSensorIdAsync(
        HSTRING sensorId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceFeatures_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSettingsStatics,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, sensorId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSupportedFeaturesForSensorId(
        HSTRING sensorId,
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceFeatures **")]
            IHumanPresenceFeatures* result
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSettingsStatics,
                HSTRING,
                IHumanPresenceFeatures*,
                int>)((*lpVtbl)[11])
        )(this, sensorId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSupportedLockOnLeaveTimeouts(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CTimeSpan_t **"
        )]
            IVectorView<TimeSpan>** result
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, IVectorView<TimeSpan>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_SettingsChanged(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSettingsStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_SettingsChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSettingsStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[14]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentSettingsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceSettings_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT GetCurrentSettings(
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings **")]
                IHumanPresenceSettings* result
        );

        [VtblIndex(8)]
        HRESULT UpdateSettingsAsync(
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")]
                IHumanPresenceSettings settings,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(9)]
        HRESULT UpdateSettings(
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSettings *")]
                IHumanPresenceSettings settings
        );

        [VtblIndex(10)]
        HRESULT GetSupportedFeaturesForSensorIdAsync(
            HSTRING sensorId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceFeatures_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        HRESULT GetSupportedFeaturesForSensorId(
            HSTRING sensorId,
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceFeatures **")]
                IHumanPresenceFeatures* result
        );

        [VtblIndex(12)]
        HRESULT GetSupportedLockOnLeaveTimeouts(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CTimeSpan_t **"
            )]
                IVectorView<TimeSpan>** result
        );

        [VtblIndex(13)]
        HRESULT add_SettingsChanged(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_SettingsChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceSettings_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetCurrentSettingsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHumanPresenceSettings*, int> GetCurrentSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSettings *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHumanPresenceSettings,
            IAsyncAction*,
            int> UpdateSettingsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHumanPresenceSettings, int> UpdateSettings;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHumanPresenceFeatures_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetSupportedFeaturesForSensorIdAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Sensors::IHumanPresenceFeatures **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IHumanPresenceFeatures*,
            int> GetSupportedFeaturesForSensorId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<TimeSpan>**,
            int> GetSupportedLockOnLeaveTimeouts;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_SettingsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SettingsChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHumanPresenceSettingsStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHumanPresenceSettingsStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHumanPresenceSettingsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSettingsStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IHumanPresenceSettingsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSettingsStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSettingsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHumanPresenceSettingsStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHumanPresenceSettingsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSettingsStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IHumanPresenceSettingsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSettingsStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSettingsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHumanPresenceSettingsStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
