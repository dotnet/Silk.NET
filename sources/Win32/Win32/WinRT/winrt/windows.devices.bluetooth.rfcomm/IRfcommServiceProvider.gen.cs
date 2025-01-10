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

[Guid("EADBFDC4-B1F6-44FF-9F7C-E7A82AB86821")]
[NativeTypeName("struct IRfcommServiceProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommServiceProvider : IRfcommServiceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommServiceProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRfcommServiceProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRfcommServiceProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRfcommServiceProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRfcommServiceProvider, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRfcommServiceProvider, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRfcommServiceProvider, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ServiceId(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
            IRfcommServiceId* value
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceProvider, IRfcommServiceId*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SdpRawAttributes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **"
        )]
            IMap<uint, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceProvider, IMap<uint, IntPtr>**, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartAdvertising(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListener *")]
            IStreamSocketListener listener
    )
    {
        return (
            (delegate* unmanaged<IRfcommServiceProvider, IStreamSocketListener, int>)((*lpVtbl)[8])
        )(this, listener);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StopAdvertising()
    {
        return ((delegate* unmanaged<IRfcommServiceProvider, int>)((*lpVtbl)[9]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ServiceId(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")]
                IRfcommServiceId* value
        );

        [VtblIndex(7)]
        HRESULT get_SdpRawAttributes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **"
            )]
                IMap<uint, IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT StartAdvertising(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListener *")]
                IStreamSocketListener listener
        );

        [VtblIndex(9)]
        HRESULT StopAdvertising();
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRfcommServiceId*, int> get_ServiceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMap<uint, IntPtr>**, int> get_SdpRawAttributes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketListener *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocketListener, int> StartAdvertising;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopAdvertising;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRfcommServiceProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRfcommServiceProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRfcommServiceProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRfcommServiceProvider(Silk.NET.WinRT.IInspectable value)
    {
        return new IRfcommServiceProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommServiceProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommServiceProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRfcommServiceProvider value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRfcommServiceProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRfcommServiceProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IRfcommServiceProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRfcommServiceProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRfcommServiceProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRfcommServiceProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
