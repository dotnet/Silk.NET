// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AD342654-57E8-453E-8329-D1E447D103A9")]
[NativeTypeName("struct II2cDeviceProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cDeviceProvider : II2cDeviceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cDeviceProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<II2cDeviceProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<II2cDeviceProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<II2cDeviceProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<II2cDeviceProvider, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<II2cDeviceProvider, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<II2cDeviceProvider, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<II2cDeviceProvider, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged<II2cDeviceProvider, uint, byte*, int>)((*lpVtbl)[7]))(
            this,
            bufferLength,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WritePartial(
        [NativeTypeName("UINT32")] uint bufferLength,
        byte* buffer,
        [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")]
            ProviderI2cTransferResult* result
    )
    {
        return (
            (delegate* unmanaged<II2cDeviceProvider, uint, byte*, ProviderI2cTransferResult*, int>)(
                (*lpVtbl)[8]
            )
        )(this, bufferLength, buffer, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged<II2cDeviceProvider, uint, byte*, int>)((*lpVtbl)[9]))(
            this,
            bufferLength,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReadPartial(
        [NativeTypeName("UINT32")] uint bufferLength,
        byte* buffer,
        [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")]
            ProviderI2cTransferResult* result
    )
    {
        return (
            (delegate* unmanaged<II2cDeviceProvider, uint, byte*, ProviderI2cTransferResult*, int>)(
                (*lpVtbl)[10]
            )
        )(this, bufferLength, buffer, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteRead(
        [NativeTypeName("UINT32")] uint writeBufferLength,
        byte* writeBuffer,
        [NativeTypeName("UINT32")] uint readBufferLength,
        byte* readBuffer
    )
    {
        return (
            (delegate* unmanaged<II2cDeviceProvider, uint, byte*, uint, byte*, int>)((*lpVtbl)[11])
        )(this, writeBufferLength, writeBuffer, readBufferLength, readBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteReadPartial(
        [NativeTypeName("UINT32")] uint writeBufferLength,
        byte* writeBuffer,
        [NativeTypeName("UINT32")] uint readBufferLength,
        byte* readBuffer,
        [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")]
            ProviderI2cTransferResult* result
    )
    {
        return (
            (delegate* unmanaged<
                II2cDeviceProvider,
                uint,
                byte*,
                uint,
                byte*,
                ProviderI2cTransferResult*,
                int>)((*lpVtbl)[12])
        )(this, writeBufferLength, writeBuffer, readBufferLength, readBuffer, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(8)]
        HRESULT WritePartial(
            [NativeTypeName("UINT32")] uint bufferLength,
            byte* buffer,
            [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")]
                ProviderI2cTransferResult* result
        );

        [VtblIndex(9)]
        HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(10)]
        HRESULT ReadPartial(
            [NativeTypeName("UINT32")] uint bufferLength,
            byte* buffer,
            [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")]
                ProviderI2cTransferResult* result
        );

        [VtblIndex(11)]
        HRESULT WriteRead(
            [NativeTypeName("UINT32")] uint writeBufferLength,
            byte* writeBuffer,
            [NativeTypeName("UINT32")] uint readBufferLength,
            byte* readBuffer
        );

        [VtblIndex(12)]
        HRESULT WriteReadPartial(
            [NativeTypeName("UINT32")] uint writeBufferLength,
            byte* writeBuffer,
            [NativeTypeName("UINT32")] uint readBufferLength,
            byte* readBuffer,
            [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")]
                ProviderI2cTransferResult* result
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> Write;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            ProviderI2cTransferResult*,
            int> WritePartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> Read;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            ProviderI2cTransferResult*,
            int> ReadPartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, uint, byte*, int> WriteRead;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            uint,
            byte*,
            ProviderI2cTransferResult*,
            int> WriteReadPartial;
    }

    /// <summary>Initializes a new instance of the <see cref = "II2cDeviceProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public II2cDeviceProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "II2cDeviceProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator II2cDeviceProvider(Silk.NET.WinRT.IInspectable value)
    {
        return new II2cDeviceProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "II2cDeviceProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "II2cDeviceProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(II2cDeviceProvider value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "II2cDeviceProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator II2cDeviceProvider(Silk.NET.Windows.IUnknown value)
    {
        return new II2cDeviceProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "II2cDeviceProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "II2cDeviceProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(II2cDeviceProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
