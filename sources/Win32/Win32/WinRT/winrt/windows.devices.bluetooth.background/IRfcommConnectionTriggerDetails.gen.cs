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

[Guid("F922734D-2E3C-4EFC-AB59-FC5CF96F97E3")]
[NativeTypeName("struct IRfcommConnectionTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommConnectionTriggerDetails
    : IRfcommConnectionTriggerDetails.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommConnectionTriggerDetails));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRfcommConnectionTriggerDetails, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRfcommConnectionTriggerDetails, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRfcommConnectionTriggerDetails, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IRfcommConnectionTriggerDetails, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRfcommConnectionTriggerDetails, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRfcommConnectionTriggerDetails, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Socket(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocket **")] IStreamSocket* value
    )
    {
        return (
            (delegate* unmanaged<IRfcommConnectionTriggerDetails, IStreamSocket*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Incoming([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IRfcommConnectionTriggerDetails, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoteDevice(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice **")]
            IBluetoothDevice* value
    )
    {
        return (
            (delegate* unmanaged<IRfcommConnectionTriggerDetails, IBluetoothDevice*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Socket(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocket **")]
                IStreamSocket* value
        );

        [VtblIndex(7)]
        HRESULT get_Incoming([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_RemoteDevice(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDevice **")]
                IBluetoothDevice* value
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
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocket*, int> get_Socket;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Incoming;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDevice **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBluetoothDevice*, int> get_RemoteDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRfcommConnectionTriggerDetails"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRfcommConnectionTriggerDetails(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRfcommConnectionTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRfcommConnectionTriggerDetails(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRfcommConnectionTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommConnectionTriggerDetails"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommConnectionTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRfcommConnectionTriggerDetails value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRfcommConnectionTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRfcommConnectionTriggerDetails(Silk.NET.Windows.IUnknown value)
    {
        return new IRfcommConnectionTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommConnectionTriggerDetails"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommConnectionTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRfcommConnectionTriggerDetails value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
