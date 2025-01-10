// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2A179EBA-A975-46E3-B56B-08FFD783A5FE")]
[NativeTypeName("struct IRfcommServiceIdStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommServiceIdStatics
    : IRfcommServiceIdStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommServiceIdStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRfcommServiceIdStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRfcommServiceIdStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRfcommServiceIdStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRfcommServiceIdStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRfcommServiceIdStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRfcommServiceIdStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromUuid(
        Guid uuid,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, Guid, IRfcommServiceId*, int>)(
                (*lpVtbl)[6]
            )
        )(this, uuid, serviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromShortId(
        [NativeTypeName("UINT32")] uint shortId,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, uint, IRfcommServiceId*, int>)(
                (*lpVtbl)[7]
            )
        )(this, shortId, serviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SerialPort(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, IRfcommServiceId*, int>)((*lpVtbl)[8])
        )(this, serviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ObexObjectPush(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, IRfcommServiceId*, int>)((*lpVtbl)[9])
        )(this, serviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ObexFileTransfer(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, IRfcommServiceId*, int>)((*lpVtbl)[10])
        )(this, serviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PhoneBookAccessPce(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, IRfcommServiceId*, int>)((*lpVtbl)[11])
        )(this, serviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PhoneBookAccessPse(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, IRfcommServiceId*, int>)((*lpVtbl)[12])
        )(this, serviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GenericFileTransfer(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* serviceId
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceIdStatics, IRfcommServiceId*, int>)((*lpVtbl)[13])
        )(this, serviceId);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromUuid(
            Guid uuid,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
        );

        [VtblIndex(7)]
        HRESULT FromShortId(
            [NativeTypeName("UINT32")] uint shortId,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
        );

        [VtblIndex(8)]
        HRESULT get_SerialPort(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
        );

        [VtblIndex(9)]
        HRESULT get_ObexObjectPush(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
        );

        [VtblIndex(10)]
        HRESULT get_ObexFileTransfer(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
        );

        [VtblIndex(11)]
        HRESULT get_PhoneBookAccessPce(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
        );

        [VtblIndex(12)]
        HRESULT get_PhoneBookAccessPse(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
        );

        [VtblIndex(13)]
        HRESULT get_GenericFileTransfer(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* serviceId
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
            "HRESULT (GUID, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid, IRfcommServiceId*, int> FromUuid;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IRfcommServiceId*, int> FromShortId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_SerialPort;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_ObexObjectPush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_ObexFileTransfer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_PhoneBookAccessPce;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_PhoneBookAccessPse;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_GenericFileTransfer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRfcommServiceIdStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRfcommServiceIdStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRfcommServiceIdStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRfcommServiceIdStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IRfcommServiceIdStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommServiceIdStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommServiceIdStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRfcommServiceIdStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRfcommServiceIdStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRfcommServiceIdStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IRfcommServiceIdStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommServiceIdStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommServiceIdStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRfcommServiceIdStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
