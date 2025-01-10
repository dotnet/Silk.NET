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

[Guid("2BCFCBD4-2657-4128-AD5F-E3877132BDB1")]
[NativeTypeName("struct ISmsMessageReceivedTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsMessageReceivedTriggerDetails
    : ISmsMessageReceivedTriggerDetails.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsMessageReceivedTriggerDetails));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedTriggerDetails, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedTriggerDetails, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MessageType(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, SmsMessageType*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TextMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage2 **")] ISmsTextMessage2* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, ISmsTextMessage2*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WapMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsWapMessage **")] ISmsWapMessage* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, ISmsWapMessage*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AppMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsAppMessage **")] ISmsAppMessage* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, ISmsAppMessage*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BroadcastMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsBroadcastMessage **")]
            ISmsBroadcastMessage* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, ISmsBroadcastMessage*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VoicemailMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsVoicemailMessage **")]
            ISmsVoicemailMessage* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, ISmsVoicemailMessage*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_StatusMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsStatusMessage **")]
            ISmsStatusMessage* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedTriggerDetails, ISmsStatusMessage*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Drop()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedTriggerDetails, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Accept()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedTriggerDetails, int>)((*lpVtbl)[14]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MessageType(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value
        );

        [VtblIndex(7)]
        HRESULT get_TextMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage2 **")]
                ISmsTextMessage2* value
        );

        [VtblIndex(8)]
        HRESULT get_WapMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsWapMessage **")] ISmsWapMessage* value
        );

        [VtblIndex(9)]
        HRESULT get_AppMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsAppMessage **")] ISmsAppMessage* value
        );

        [VtblIndex(10)]
        HRESULT get_BroadcastMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsBroadcastMessage **")]
                ISmsBroadcastMessage* value
        );

        [VtblIndex(11)]
        HRESULT get_VoicemailMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsVoicemailMessage **")]
                ISmsVoicemailMessage* value
        );

        [VtblIndex(12)]
        HRESULT get_StatusMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsStatusMessage **")]
                ISmsStatusMessage* value
        );

        [VtblIndex(13)]
        HRESULT Drop();

        [VtblIndex(14)]
        HRESULT Accept();
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
            "HRESULT (ABI::Windows::Devices::Sms::SmsMessageType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmsMessageType*, int> get_MessageType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsTextMessage2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsTextMessage2*, int> get_TextMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsWapMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsWapMessage*, int> get_WapMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsAppMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsAppMessage*, int> get_AppMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsBroadcastMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsBroadcastMessage*, int> get_BroadcastMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsVoicemailMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsVoicemailMessage*, int> get_VoicemailMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsStatusMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsStatusMessage*, int> get_StatusMessage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Drop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Accept;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsMessageReceivedTriggerDetails"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsMessageReceivedTriggerDetails(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsMessageReceivedTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsMessageReceivedTriggerDetails(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmsMessageReceivedTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsMessageReceivedTriggerDetails"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsMessageReceivedTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmsMessageReceivedTriggerDetails value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsMessageReceivedTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsMessageReceivedTriggerDetails(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmsMessageReceivedTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsMessageReceivedTriggerDetails"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsMessageReceivedTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmsMessageReceivedTriggerDetails value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
