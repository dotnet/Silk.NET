// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8636C136-B9C5-4F70-9449-CC46DC6F57EB")]
[NativeTypeName("struct II2cDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cDevice : II2cDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<II2cDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<II2cDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<II2cDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<II2cDevice, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<II2cDevice, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<II2cDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<II2cDevice, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionSettings(
        [NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings **")]
            II2cConnectionSettings* value
    )
    {
        return ((delegate* unmanaged<II2cDevice, II2cConnectionSettings*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged<II2cDevice, uint, byte*, int>)((*lpVtbl)[8]))(
            this,
            bufferLength,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WritePartial(
        [NativeTypeName("UINT32")] uint bufferLength,
        byte* buffer,
        [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")]
            I2cTransferResult* result
    )
    {
        return (
            (delegate* unmanaged<II2cDevice, uint, byte*, I2cTransferResult*, int>)((*lpVtbl)[9])
        )(this, bufferLength, buffer, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged<II2cDevice, uint, byte*, int>)((*lpVtbl)[10]))(
            this,
            bufferLength,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReadPartial(
        [NativeTypeName("UINT32")] uint bufferLength,
        byte* buffer,
        [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")]
            I2cTransferResult* result
    )
    {
        return (
            (delegate* unmanaged<II2cDevice, uint, byte*, I2cTransferResult*, int>)((*lpVtbl)[11])
        )(this, bufferLength, buffer, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteRead(
        [NativeTypeName("UINT32")] uint writeBufferLength,
        byte* writeBuffer,
        [NativeTypeName("UINT32")] uint readBufferLength,
        byte* readBuffer
    )
    {
        return ((delegate* unmanaged<II2cDevice, uint, byte*, uint, byte*, int>)((*lpVtbl)[12]))(
            this,
            writeBufferLength,
            writeBuffer,
            readBufferLength,
            readBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteReadPartial(
        [NativeTypeName("UINT32")] uint writeBufferLength,
        byte* writeBuffer,
        [NativeTypeName("UINT32")] uint readBufferLength,
        byte* readBuffer,
        [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")]
            I2cTransferResult* result
    )
    {
        return (
            (delegate* unmanaged<II2cDevice, uint, byte*, uint, byte*, I2cTransferResult*, int>)(
                (*lpVtbl)[13]
            )
        )(this, writeBufferLength, writeBuffer, readBufferLength, readBuffer, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ConnectionSettings(
            [NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings **")]
                II2cConnectionSettings* value
        );

        [VtblIndex(8)]
        HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(9)]
        HRESULT WritePartial(
            [NativeTypeName("UINT32")] uint bufferLength,
            byte* buffer,
            [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")]
                I2cTransferResult* result
        );

        [VtblIndex(10)]
        HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(11)]
        HRESULT ReadPartial(
            [NativeTypeName("UINT32")] uint bufferLength,
            byte* buffer,
            [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")]
                I2cTransferResult* result
        );

        [VtblIndex(12)]
        HRESULT WriteRead(
            [NativeTypeName("UINT32")] uint writeBufferLength,
            byte* writeBuffer,
            [NativeTypeName("UINT32")] uint readBufferLength,
            byte* readBuffer
        );

        [VtblIndex(13)]
        HRESULT WriteReadPartial(
            [NativeTypeName("UINT32")] uint writeBufferLength,
            byte* writeBuffer,
            [NativeTypeName("UINT32")] uint readBufferLength,
            byte* readBuffer,
            [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")]
                I2cTransferResult* result
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::I2c::II2cConnectionSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, II2cConnectionSettings*, int> get_ConnectionSettings;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> Write;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::I2cTransferResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, byte*, I2cTransferResult*, int> WritePartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> Read;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::I2cTransferResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, byte*, I2cTransferResult*, int> ReadPartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, uint, byte*, int> WriteRead;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Devices::I2c::I2cTransferResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            uint,
            byte*,
            I2cTransferResult*,
            int> WriteReadPartial;
    }

    /// <summary>Initializes a new instance of the <see cref = "II2cDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public II2cDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "II2cDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator II2cDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new II2cDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "II2cDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "II2cDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(II2cDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "II2cDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator II2cDevice(Silk.NET.Windows.IUnknown value)
    {
        return new II2cDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "II2cDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "II2cDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(II2cDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
