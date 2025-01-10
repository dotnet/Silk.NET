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

[Guid("BD8A5C13-E522-46CB-B8D5-9EAD30FB6C47")]
[NativeTypeName("struct ISmsDevice2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsDevice2 : ISmsDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDevice2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsDevice2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsDevice2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsDevice2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsDevice2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsDevice2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsDevice2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SmscAddress(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsDevice2, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SmscAddress(HSTRING value)
    {
        return ((delegate* unmanaged<ISmsDevice2, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsDevice2, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ParentDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsDevice2, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AccountPhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsDevice2, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CellularClass(
        [NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value
    )
    {
        return ((delegate* unmanaged<ISmsDevice2, CellularClass*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DeviceStatus(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value
    )
    {
        return ((delegate* unmanaged<ISmsDevice2, SmsDeviceStatus*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CalculateLength(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")] ISmsMessageBase message,
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")] SmsEncodedLength* value
    )
    {
        return (
            (delegate* unmanaged<ISmsDevice2, ISmsMessageBase, SmsEncodedLength*, int>)(
                (*lpVtbl)[13]
            )
        )(this, message, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SendMessageAndGetResultAsync(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")] ISmsMessageBase message,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsSendMessageResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<ISmsDevice2, ISmsMessageBase, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, message, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_DeviceStatusChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsDevice2_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                ISmsDevice2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_DeviceStatusChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged<ISmsDevice2, EventRegistrationToken, int>)((*lpVtbl)[16]))(
            this,
            eventCookie
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SmscAddress(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_SmscAddress(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_ParentDeviceId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_AccountPhoneNumber(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_CellularClass(
            [NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value
        );

        [VtblIndex(12)]
        HRESULT get_DeviceStatus(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsDeviceStatus *")] SmsDeviceStatus* value
        );

        [VtblIndex(13)]
        HRESULT CalculateLength(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")]
                ISmsMessageBase message,
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsEncodedLength *")]
                SmsEncodedLength* value
        );

        [VtblIndex(14)]
        HRESULT SendMessageAndGetResultAsync(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageBase *")]
                ISmsMessageBase message,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsSendMessageResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(15)]
        HRESULT add_DeviceStatusChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsDevice2_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(16)]
        HRESULT remove_DeviceStatusChanged(EventRegistrationToken eventCookie);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SmscAddress;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_SmscAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ParentDeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AccountPhoneNumber;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsDeviceStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmsDeviceStatus*, int> get_DeviceStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsMessageBase *, ABI::Windows::Devices::Sms::SmsEncodedLength *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsMessageBase, SmsEncodedLength*, int> CalculateLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsMessageBase *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsSendMessageResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmsMessageBase,
            IAsyncOperation<IntPtr>**,
            int> SendMessageAndGetResultAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsDevice2_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DeviceStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DeviceStatusChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsDevice2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsDevice2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsDevice2(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsDevice2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDevice2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDevice2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsDevice2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsDevice2(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsDevice2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDevice2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDevice2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsDevice2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
