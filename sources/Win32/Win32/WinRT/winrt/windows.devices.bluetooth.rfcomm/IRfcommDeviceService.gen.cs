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

[Guid("AE81FF1F-C5A1-4C40-8C28-F3EFD69062F3")]
[NativeTypeName("struct IRfcommDeviceService : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommDeviceService : IRfcommDeviceService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommDeviceService));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRfcommDeviceService, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRfcommDeviceService, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRfcommDeviceService, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRfcommDeviceService, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRfcommDeviceService, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRfcommDeviceService, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConnectionHostName(
        [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
    )
    {
        return ((delegate* unmanaged<IRfcommDeviceService, IHostName*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged<IRfcommDeviceService, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServiceId(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* value
    )
    {
        return ((delegate* unmanaged<IRfcommDeviceService, IRfcommServiceId*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProtectionLevel(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")]
            SocketProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IRfcommDeviceService, SocketProtectionLevel*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxProtectionLevel(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")]
            SocketProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IRfcommDeviceService, SocketProtectionLevel*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSdpRawAttributesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<IRfcommDeviceService, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSdpRawAttributesWithCacheModeAsync(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IRfcommDeviceService,
                BluetoothCacheMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, cacheMode, asyncOp);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ConnectionHostName(
            [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
        );

        [VtblIndex(7)]
        HRESULT get_ConnectionServiceName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ServiceId(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* value
        );

        [VtblIndex(9)]
        HRESULT get_ProtectionLevel(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")]
                SocketProtectionLevel* value
        );

        [VtblIndex(10)]
        HRESULT get_MaxProtectionLevel(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")]
                SocketProtectionLevel* value
        );

        [VtblIndex(11)]
        HRESULT GetSdpRawAttributesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(12)]
        HRESULT GetSdpRawAttributesWithCacheModeAsync(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
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
            "HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName*, int> get_ConnectionHostName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ConnectionServiceName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_ServiceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SocketProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SocketProtectionLevel*, int> get_MaxProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetSdpRawAttributesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothCacheMode,
            IAsyncOperation<IntPtr>**,
            int> GetSdpRawAttributesWithCacheModeAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRfcommDeviceService"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRfcommDeviceService(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRfcommDeviceService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRfcommDeviceService(Silk.NET.WinRT.IInspectable value)
    {
        return new IRfcommDeviceService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommDeviceService"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommDeviceService"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRfcommDeviceService value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRfcommDeviceService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRfcommDeviceService(Silk.NET.Windows.IUnknown value)
    {
        return new IRfcommDeviceService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommDeviceService"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommDeviceService"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRfcommDeviceService value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
