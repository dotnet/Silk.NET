// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CA7190EF-0CAE-573C-A1CA-E1FC5BFC39E2")]
[NativeTypeName("struct IBluetoothLEDevice6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEDevice6 : IBluetoothLEDevice6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEDevice6));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBluetoothLEDevice6, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBluetoothLEDevice6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEDevice6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBluetoothLEDevice6, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBluetoothLEDevice6, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBluetoothLEDevice6, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetConnectionParameters(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionParameters **")]
            IBluetoothLEConnectionParameters* result
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEDevice6, IBluetoothLEConnectionParameters*, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetConnectionPhy(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhy **")]
            IBluetoothLEConnectionPhy* result
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEDevice6, IBluetoothLEConnectionPhy*, int>)(
                (*lpVtbl)[7]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestPreferredConnectionParameters(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParameters *"
        )]
            IBluetoothLEPreferredConnectionParameters preferredConnectionParameters,
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParametersRequest **"
        )]
            IBluetoothLEPreferredConnectionParametersRequest* result
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEDevice6,
                IBluetoothLEPreferredConnectionParameters,
                IBluetoothLEPreferredConnectionParametersRequest*,
                int>)((*lpVtbl)[8])
        )(this, preferredConnectionParameters, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_ConnectionParametersChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEDevice6,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_ConnectionParametersChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBluetoothLEDevice6, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ConnectionPhyChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEDevice6,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ConnectionPhyChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBluetoothLEDevice6, EventRegistrationToken, int>)((*lpVtbl)[12])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetConnectionParameters(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionParameters **"
            )]
                IBluetoothLEConnectionParameters* result
        );

        [VtblIndex(7)]
        HRESULT GetConnectionPhy(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhy **")]
                IBluetoothLEConnectionPhy* result
        );

        [VtblIndex(8)]
        HRESULT RequestPreferredConnectionParameters(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParameters *"
            )]
                IBluetoothLEPreferredConnectionParameters preferredConnectionParameters,
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParametersRequest **"
            )]
                IBluetoothLEPreferredConnectionParametersRequest* result
        );

        [VtblIndex(9)]
        HRESULT add_ConnectionParametersChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_ConnectionParametersChanged(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_ConnectionPhyChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_ConnectionPhyChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionParameters **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothLEConnectionParameters*,
            int> GetConnectionParameters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhy **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBluetoothLEConnectionPhy*, int> GetConnectionPhy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParameters *, ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParametersRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBluetoothLEPreferredConnectionParameters,
            IBluetoothLEPreferredConnectionParametersRequest*,
            int> RequestPreferredConnectionParameters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ConnectionParametersChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_ConnectionParametersChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ConnectionPhyChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ConnectionPhyChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEDevice6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEDevice6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEDevice6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEDevice6(Silk.NET.WinRT.IInspectable value)
    {
        return new IBluetoothLEDevice6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEDevice6"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEDevice6"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBluetoothLEDevice6 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEDevice6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEDevice6(Silk.NET.Windows.IUnknown value)
    {
        return new IBluetoothLEDevice6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEDevice6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEDevice6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBluetoothLEDevice6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
