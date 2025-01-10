// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("05D5356D-11B6-4D39-84D5-95DFB4C9F2CE")]
[NativeTypeName("struct ISpiDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiDevice : ISpiDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpiDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpiDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpiDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpiDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpiDevice, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpiDevice, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpiDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<ISpiDevice, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionSettings(
        [NativeTypeName("ABI::Windows::Devices::Spi::ISpiConnectionSettings **")]
            ISpiConnectionSettings* value
    )
    {
        return ((delegate* unmanaged<ISpiDevice, ISpiConnectionSettings*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged<ISpiDevice, uint, byte*, int>)((*lpVtbl)[8]))(
            this,
            bufferLength,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged<ISpiDevice, uint, byte*, int>)((*lpVtbl)[9]))(
            this,
            bufferLength,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TransferSequential(
        [NativeTypeName("UINT32")] uint writeBufferLength,
        byte* writeBuffer,
        [NativeTypeName("UINT32")] uint readBufferLength,
        byte* readBuffer
    )
    {
        return ((delegate* unmanaged<ISpiDevice, uint, byte*, uint, byte*, int>)((*lpVtbl)[10]))(
            this,
            writeBufferLength,
            writeBuffer,
            readBufferLength,
            readBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TransferFullDuplex(
        [NativeTypeName("UINT32")] uint writeBufferLength,
        byte* writeBuffer,
        [NativeTypeName("UINT32")] uint readBufferLength,
        byte* readBuffer
    )
    {
        return ((delegate* unmanaged<ISpiDevice, uint, byte*, uint, byte*, int>)((*lpVtbl)[11]))(
            this,
            writeBufferLength,
            writeBuffer,
            readBufferLength,
            readBuffer
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ConnectionSettings(
            [NativeTypeName("ABI::Windows::Devices::Spi::ISpiConnectionSettings **")]
                ISpiConnectionSettings* value
        );

        [VtblIndex(8)]
        HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(9)]
        HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(10)]
        HRESULT TransferSequential(
            [NativeTypeName("UINT32")] uint writeBufferLength,
            byte* writeBuffer,
            [NativeTypeName("UINT32")] uint readBufferLength,
            byte* readBuffer
        );

        [VtblIndex(11)]
        HRESULT TransferFullDuplex(
            [NativeTypeName("UINT32")] uint writeBufferLength,
            byte* writeBuffer,
            [NativeTypeName("UINT32")] uint readBufferLength,
            byte* readBuffer
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
            "HRESULT (ABI::Windows::Devices::Spi::ISpiConnectionSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpiConnectionSettings*, int> get_ConnectionSettings;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> Write;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> Read;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, uint, byte*, int> TransferSequential;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, uint, byte*, int> TransferFullDuplex;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpiDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpiDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpiDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpiDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpiDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpiDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpiDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpiDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpiDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpiDevice(Silk.NET.Windows.IUnknown value)
    {
        return new ISpiDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpiDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpiDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpiDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
