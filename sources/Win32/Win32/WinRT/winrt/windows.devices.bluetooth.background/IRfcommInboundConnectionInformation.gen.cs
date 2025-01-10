// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6D3E75A8-5429-4059-92E3-1E8B65528707")]
[NativeTypeName("struct IRfcommInboundConnectionInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommInboundConnectionInformation
    : IRfcommInboundConnectionInformation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommInboundConnectionInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRfcommInboundConnectionInformation, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRfcommInboundConnectionInformation, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SdpRecord(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, IBuffer*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SdpRecord(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
    )
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, IBuffer, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalServiceId(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* value
    )
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, IRfcommServiceId*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LocalServiceId(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")]
            IRfcommServiceId value
    )
    {
        return (
            (delegate* unmanaged<IRfcommInboundConnectionInformation, IRfcommServiceId, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServiceCapabilities(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *")]
            BluetoothServiceCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<
                IRfcommInboundConnectionInformation,
                BluetoothServiceCapabilities*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ServiceCapabilities(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities")]
            BluetoothServiceCapabilities value
    )
    {
        return (
            (delegate* unmanaged<
                IRfcommInboundConnectionInformation,
                BluetoothServiceCapabilities,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SdpRecord(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(7)]
        HRESULT put_SdpRecord(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
        );

        [VtblIndex(8)]
        HRESULT get_LocalServiceId(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* value
        );

        [VtblIndex(9)]
        HRESULT put_LocalServiceId(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *")]
                IRfcommServiceId value
        );

        [VtblIndex(10)]
        HRESULT get_ServiceCapabilities(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *")]
                BluetoothServiceCapabilities* value
        );

        [VtblIndex(11)]
        HRESULT put_ServiceCapabilities(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities")]
                BluetoothServiceCapabilities value
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
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_SdpRecord;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> put_SdpRecord;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_LocalServiceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId, int> put_LocalServiceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothServiceCapabilities*,
            int> get_ServiceCapabilities;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothServiceCapabilities) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothServiceCapabilities,
            int> put_ServiceCapabilities;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRfcommInboundConnectionInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRfcommInboundConnectionInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRfcommInboundConnectionInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRfcommInboundConnectionInformation(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRfcommInboundConnectionInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommInboundConnectionInformation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommInboundConnectionInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRfcommInboundConnectionInformation value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRfcommInboundConnectionInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRfcommInboundConnectionInformation(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRfcommInboundConnectionInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommInboundConnectionInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommInboundConnectionInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRfcommInboundConnectionInformation value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
