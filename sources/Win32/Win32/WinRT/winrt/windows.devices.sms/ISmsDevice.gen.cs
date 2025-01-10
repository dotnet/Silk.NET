// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("091791ED-872B-4EEC-9C72-AB11627B34EC")]
[NativeTypeName("struct ISmsDevice : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
)]
public unsafe partial struct ISmsDevice : ISmsDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsDevice, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsDevice, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT SendMessageAsync(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessage *")] ISmsMessage message,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<ISmsDevice, ISmsMessage, IAsyncAction*, int>)((*lpVtbl)[6]))(
            this,
            message,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT CalculateLength(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage *")] ISmsTextMessage message,
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")]
            SmsEncodedLength* encodedLength
    )
    {
        return (
            (delegate* unmanaged<ISmsDevice, ISmsTextMessage, SmsEncodedLength*, int>)((*lpVtbl)[7])
        )(this, message, encodedLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT get_AccountPhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsDevice, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT get_CellularClass(
        [NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value
    )
    {
        return ((delegate* unmanaged<ISmsDevice, CellularClass*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT get_MessageStore(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceMessageStore **")]
            ISmsDeviceMessageStore* value
    )
    {
        return ((delegate* unmanaged<ISmsDevice, ISmsDeviceMessageStore*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT get_DeviceStatus(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value
    )
    {
        return ((delegate* unmanaged<ISmsDevice, SmsDeviceStatus*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT add_SmsMessageReceived(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventHandler *")]
            ISmsMessageReceivedEventHandler eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                ISmsDevice,
                ISmsMessageReceivedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT remove_SmsMessageReceived(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged<ISmsDevice, EventRegistrationToken, int>)((*lpVtbl)[13]))(
            this,
            eventCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT add_SmsDeviceStatusChanged(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceStatusChangedEventHandler *")]
            ISmsDeviceStatusChangedEventHandler eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                ISmsDevice,
                ISmsDeviceStatusChangedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public HRESULT remove_SmsDeviceStatusChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged<ISmsDevice, EventRegistrationToken, int>)((*lpVtbl)[15]))(
            this,
            eventCookie
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT SendMessageAsync(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessage *")] ISmsMessage message,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(7)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT CalculateLength(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage *")]
                ISmsTextMessage message,
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")]
                SmsEncodedLength* encodedLength
        );

        [VtblIndex(8)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT get_AccountPhoneNumber(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT get_CellularClass(
            [NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value
        );

        [VtblIndex(10)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT get_MessageStore(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceMessageStore **")]
                ISmsDeviceMessageStore* value
        );

        [VtblIndex(11)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT get_DeviceStatus(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value
        );

        [VtblIndex(12)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT add_SmsMessageReceived(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventHandler *")]
                ISmsMessageReceivedEventHandler eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(13)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT remove_SmsMessageReceived(EventRegistrationToken eventCookie);

        [VtblIndex(14)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT add_SmsDeviceStatusChanged(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDeviceStatusChangedEventHandler *")]
                ISmsDeviceStatusChangedEventHandler eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(15)]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        HRESULT remove_SmsDeviceStatusChanged(EventRegistrationToken eventCookie);
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
            "HRESULT (ABI::Windows::Devices::Sms::ISmsMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<TSelf*, ISmsMessage, IAsyncAction*, int> SendMessageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsTextMessage *, ABI::Windows::Devices::Sms::SmsEncodedLength *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<TSelf*, ISmsTextMessage, SmsEncodedLength*, int> CalculateLength;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AccountPhoneNumber;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsDeviceMessageStore **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<TSelf*, ISmsDeviceMessageStore*, int> get_MessageStore;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsDeviceStatus *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<TSelf*, SmsDeviceStatus*, int> get_DeviceStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsMessageReceivedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmsMessageReceivedEventHandler,
            EventRegistrationToken*,
            int> add_SmsMessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SmsMessageReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsDeviceStatusChangedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmsDeviceStatusChangedEventHandler,
            EventRegistrationToken*,
            int> add_SmsDeviceStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
        )]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_SmsDeviceStatusChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsDevice(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
