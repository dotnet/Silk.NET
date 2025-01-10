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

[Guid("DA4B7CF0-8D71-446F-88C3-B95184A2D6CD")]
[NativeTypeName("struct IControlChannelTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IControlChannelTriggerFactory
    : IControlChannelTriggerFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IControlChannelTriggerFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IControlChannelTriggerFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IControlChannelTriggerFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IControlChannelTriggerFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IControlChannelTriggerFactory, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IControlChannelTriggerFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IControlChannelTriggerFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateControlChannelTrigger(
        HSTRING channelId,
        [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes,
        [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")]
            IControlChannelTrigger* notificationChannel
    )
    {
        return (
            (delegate* unmanaged<
                IControlChannelTriggerFactory,
                HSTRING,
                uint,
                IControlChannelTrigger*,
                int>)((*lpVtbl)[6])
        )(this, channelId, serverKeepAliveIntervalInMinutes, notificationChannel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateControlChannelTriggerEx(
        HSTRING channelId,
        [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes,
        [NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerResourceType")]
            ControlChannelTriggerResourceType resourceRequestType,
        [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")]
            IControlChannelTrigger* notificationChannel
    )
    {
        return (
            (delegate* unmanaged<
                IControlChannelTriggerFactory,
                HSTRING,
                uint,
                ControlChannelTriggerResourceType,
                IControlChannelTrigger*,
                int>)((*lpVtbl)[7])
        )(
            this,
            channelId,
            serverKeepAliveIntervalInMinutes,
            resourceRequestType,
            notificationChannel
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateControlChannelTrigger(
            HSTRING channelId,
            [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes,
            [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")]
                IControlChannelTrigger* notificationChannel
        );

        [VtblIndex(7)]
        HRESULT CreateControlChannelTriggerEx(
            HSTRING channelId,
            [NativeTypeName("UINT32")] uint serverKeepAliveIntervalInMinutes,
            [NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerResourceType")]
                ControlChannelTriggerResourceType resourceRequestType,
            [NativeTypeName("ABI::Windows::Networking::Sockets::IControlChannelTrigger **")]
                IControlChannelTrigger* notificationChannel
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
            "HRESULT (HSTRING, UINT32, ABI::Windows::Networking::Sockets::IControlChannelTrigger **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            uint,
            IControlChannelTrigger*,
            int> CreateControlChannelTrigger;

        [NativeTypeName(
            "HRESULT (HSTRING, UINT32, ABI::Windows::Networking::Sockets::ControlChannelTriggerResourceType, ABI::Windows::Networking::Sockets::IControlChannelTrigger **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            uint,
            ControlChannelTriggerResourceType,
            IControlChannelTrigger*,
            int> CreateControlChannelTriggerEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IControlChannelTriggerFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IControlChannelTriggerFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IControlChannelTriggerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IControlChannelTriggerFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IControlChannelTriggerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IControlChannelTriggerFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IControlChannelTriggerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IControlChannelTriggerFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IControlChannelTriggerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IControlChannelTriggerFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IControlChannelTriggerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IControlChannelTriggerFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IControlChannelTriggerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IControlChannelTriggerFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
