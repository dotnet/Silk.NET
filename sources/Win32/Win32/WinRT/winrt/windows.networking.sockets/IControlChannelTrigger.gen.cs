// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7D1431A7-EE96-40E8-A199-8703CD969EC3")]
[NativeTypeName("struct IControlChannelTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IControlChannelTrigger : IControlChannelTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IControlChannelTrigger));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IControlChannelTrigger, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IControlChannelTrigger, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IControlChannelTrigger, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ControlChannelTriggerId(HSTRING* value)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, uint*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, uint, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, uint*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TransportObject(IInspectable* value)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, IInspectable*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_KeepAliveTrigger(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")]
            IBackgroundTrigger* trigger
    )
    {
        return (
            (delegate* unmanaged<IControlChannelTrigger, IBackgroundTrigger*, int>)((*lpVtbl)[11])
        )(this, trigger);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PushNotificationTrigger(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")]
            IBackgroundTrigger* trigger
    )
    {
        return (
            (delegate* unmanaged<IControlChannelTrigger, IBackgroundTrigger*, int>)((*lpVtbl)[12])
        )(this, trigger);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UsingTransport(IInspectable transport)
    {
        return ((delegate* unmanaged<IControlChannelTrigger, IInspectable, int>)((*lpVtbl)[13]))(
            this,
            transport
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WaitForPushEnabled(
        [NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerStatus *")]
            ControlChannelTriggerStatus* channelTriggerStatus
    )
    {
        return (
            (delegate* unmanaged<IControlChannelTrigger, ControlChannelTriggerStatus*, int>)(
                (*lpVtbl)[14]
            )
        )(this, channelTriggerStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DecreaseNetworkKeepAliveInterval()
    {
        return ((delegate* unmanaged<IControlChannelTrigger, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FlushTransport()
    {
        return ((delegate* unmanaged<IControlChannelTrigger, int>)((*lpVtbl)[16]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ControlChannelTriggerId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT put_ServerKeepAliveIntervalInMinutes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_CurrentKeepAliveIntervalInMinutes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT get_TransportObject(IInspectable* value);

        [VtblIndex(11)]
        HRESULT get_KeepAliveTrigger(
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")]
                IBackgroundTrigger* trigger
        );

        [VtblIndex(12)]
        HRESULT get_PushNotificationTrigger(
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")]
                IBackgroundTrigger* trigger
        );

        [VtblIndex(13)]
        HRESULT UsingTransport(IInspectable transport);

        [VtblIndex(14)]
        HRESULT WaitForPushEnabled(
            [NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerStatus *")]
                ControlChannelTriggerStatus* channelTriggerStatus
        );

        [VtblIndex(15)]
        HRESULT DecreaseNetworkKeepAliveInterval();

        [VtblIndex(16)]
        HRESULT FlushTransport();
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ControlChannelTriggerId;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ServerKeepAliveIntervalInMinutes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_ServerKeepAliveIntervalInMinutes;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CurrentKeepAliveIntervalInMinutes;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, int> get_TransportObject;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTrigger*, int> get_KeepAliveTrigger;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTrigger*, int> get_PushNotificationTrigger;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable, int> UsingTransport;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::ControlChannelTriggerStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ControlChannelTriggerStatus*, int> WaitForPushEnabled;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DecreaseNetworkKeepAliveInterval;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FlushTransport;
    }

    /// <summary>Initializes a new instance of the <see cref = "IControlChannelTrigger"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IControlChannelTrigger(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IControlChannelTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IControlChannelTrigger(Silk.NET.WinRT.IInspectable value)
    {
        return new IControlChannelTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IControlChannelTrigger"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IControlChannelTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IControlChannelTrigger value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IControlChannelTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IControlChannelTrigger(Silk.NET.Windows.IUnknown value)
    {
        return new IControlChannelTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IControlChannelTrigger"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IControlChannelTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IControlChannelTrigger value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
