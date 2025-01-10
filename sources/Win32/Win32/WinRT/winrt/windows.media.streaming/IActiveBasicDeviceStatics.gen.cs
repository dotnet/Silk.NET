// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6D33255D-3642-4618-9DB6-43524F4DEADC")]
[NativeTypeName("struct IActiveBasicDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IActiveBasicDeviceStatics
    : IActiveBasicDeviceStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveBasicDeviceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActiveBasicDeviceStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IActiveBasicDeviceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveBasicDeviceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IActiveBasicDeviceStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IActiveBasicDeviceStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IActiveBasicDeviceStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBasicDeviceAsync(
        HSTRING deviceIdentifier,
        [NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes")] DeviceTypes type,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IActiveBasicDeviceStatics,
                HSTRING,
                DeviceTypes,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, deviceIdentifier, type, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CloneBasicDeviceAsync(
        [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice basicDevice,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IActiveBasicDeviceStatics,
                IBasicDevice,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, basicDevice, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDevicesOnMatchingNetworkAsync(
        [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")]
            IActiveBasicDevice server,
        [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")]
            IActiveBasicDevice renderer,
        [NativeTypeName("boolean")] byte optimizeForProxying,
        [NativeTypeName("boolean")] byte allowChangeRendererNetwork,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IActiveBasicDeviceStatics,
                IActiveBasicDevice,
                IActiveBasicDevice,
                byte,
                byte,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, server, renderer, optimizeForProxying, allowChangeRendererNetwork, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDevicesOnMatchingNetworkAsync(
        HSTRING serverUDN,
        [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")]
            IActiveBasicDevice renderer,
        [NativeTypeName("boolean")] byte optimizeForProxying,
        [NativeTypeName("boolean")] byte allowChangeRendererNetwork,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IActiveBasicDeviceStatics,
                HSTRING,
                IActiveBasicDevice,
                byte,
                byte,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, serverUDN, renderer, optimizeForProxying, allowChangeRendererNetwork, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateBasicDeviceAsync(
            HSTRING deviceIdentifier,
            [NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes")] DeviceTypes type,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT CloneBasicDeviceAsync(
            [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")]
                IBasicDevice basicDevice,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT GetDevicesOnMatchingNetworkAsync(
            [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")]
                IActiveBasicDevice server,
            [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")]
                IActiveBasicDevice renderer,
            [NativeTypeName("boolean")] byte optimizeForProxying,
            [NativeTypeName("boolean")] byte allowChangeRendererNetwork,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT CreateDevicesOnMatchingNetworkAsync(
            HSTRING serverUDN,
            [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")]
                IActiveBasicDevice renderer,
            [NativeTypeName("boolean")] byte optimizeForProxying,
            [NativeTypeName("boolean")] byte allowChangeRendererNetwork,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (HSTRING, ABI::Windows::Media::Streaming::DeviceTypes, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            DeviceTypes,
            IAsyncOperation<IntPtr>**,
            int> CreateBasicDeviceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IBasicDevice *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBasicDevice,
            IAsyncOperation<IntPtr>**,
            int> CloneBasicDeviceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IActiveBasicDevice *, ABI::Windows::Media::Streaming::IActiveBasicDevice *, ::boolean, ::boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IActiveBasicDevice,
            IActiveBasicDevice,
            byte,
            byte,
            IAsyncOperation<IntPtr>**,
            int> GetDevicesOnMatchingNetworkAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Media::Streaming::IActiveBasicDevice *, ::boolean, ::boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IActiveBasicDevice,
            byte,
            byte,
            IAsyncOperation<IntPtr>**,
            int> CreateDevicesOnMatchingNetworkAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IActiveBasicDeviceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IActiveBasicDeviceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IActiveBasicDeviceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IActiveBasicDeviceStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IActiveBasicDeviceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActiveBasicDeviceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IActiveBasicDeviceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IActiveBasicDeviceStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IActiveBasicDeviceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IActiveBasicDeviceStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IActiveBasicDeviceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActiveBasicDeviceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IActiveBasicDeviceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IActiveBasicDeviceStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
