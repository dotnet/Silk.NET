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

[Guid("5283A37F-F935-4B9F-A7A7-3A7890AFA5CE")]
[NativeTypeName("struct ISpiConnectionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiConnectionSettings : ISpiConnectionSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpiConnectionSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpiConnectionSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, int*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, int, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Mode(
        [NativeTypeName("ABI::Windows::Devices::Spi::SpiMode *")] SpiMode* value
    )
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, SpiMode*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Devices::Spi::SpiMode")] SpiMode value)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, SpiMode, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DataBitLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, int*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DataBitLength([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, int, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ClockFrequency([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, int*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ClockFrequency([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, int, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SharingMode(
        [NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode *")] SpiSharingMode* value
    )
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, SpiSharingMode*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_SharingMode(
        [NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode")] SpiSharingMode value
    )
    {
        return ((delegate* unmanaged<ISpiConnectionSettings, SpiSharingMode, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Devices::Spi::SpiMode *")] SpiMode* value);

        [VtblIndex(9)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Devices::Spi::SpiMode")] SpiMode value);

        [VtblIndex(10)]
        HRESULT get_DataBitLength([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT put_DataBitLength([NativeTypeName("INT32")] int value);

        [VtblIndex(12)]
        HRESULT get_ClockFrequency([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_ClockFrequency([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_SharingMode(
            [NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode *")] SpiSharingMode* value
        );

        [VtblIndex(15)]
        HRESULT put_SharingMode(
            [NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode")] SpiSharingMode value
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ChipSelectLine;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ChipSelectLine;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::SpiMode *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpiMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::SpiMode) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpiMode, int> put_Mode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DataBitLength;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DataBitLength;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ClockFrequency;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ClockFrequency;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Spi::SpiSharingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpiSharingMode*, int> get_SharingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Spi::SpiSharingMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpiSharingMode, int> put_SharingMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpiConnectionSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpiConnectionSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpiConnectionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpiConnectionSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpiConnectionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpiConnectionSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpiConnectionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpiConnectionSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpiConnectionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpiConnectionSettings(Silk.NET.Windows.IUnknown value)
    {
        return new ISpiConnectionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpiConnectionSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpiConnectionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpiConnectionSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
