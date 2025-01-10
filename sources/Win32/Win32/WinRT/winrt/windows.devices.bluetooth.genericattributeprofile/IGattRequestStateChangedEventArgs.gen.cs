// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E834D92C-27BE-44B3-9D0D-4FC6E808DD3F")]
[NativeTypeName("struct IGattRequestStateChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattRequestStateChangedEventArgs
    : IGattRequestStateChangedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattRequestStateChangedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattRequestStateChangedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGattRequestStateChangedEventArgs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattRequestStateChangedEventArgs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattRequestStateChangedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IGattRequestStateChangedEventArgs, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IGattRequestStateChangedEventArgs, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_State(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *"
        )]
            GattRequestState* value
    )
    {
        return (
            (delegate* unmanaged<IGattRequestStateChangedEventArgs, GattRequestState*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Error(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value
    )
    {
        return (
            (delegate* unmanaged<IGattRequestStateChangedEventArgs, BluetoothError*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_State(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *"
            )]
                GattRequestState* value
        );

        [VtblIndex(7)]
        HRESULT get_Error(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")]
                BluetoothError* value
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattRequestState*, int> get_State;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothError *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BluetoothError*, int> get_Error;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattRequestStateChangedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattRequestStateChangedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattRequestStateChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattRequestStateChangedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IGattRequestStateChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattRequestStateChangedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattRequestStateChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IGattRequestStateChangedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattRequestStateChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattRequestStateChangedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IGattRequestStateChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattRequestStateChangedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattRequestStateChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IGattRequestStateChangedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
