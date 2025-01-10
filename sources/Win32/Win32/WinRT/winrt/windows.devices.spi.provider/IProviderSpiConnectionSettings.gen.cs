// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F6034550-A542-4EC0-9601-A4DD68F8697B")]
[NativeTypeName("struct IProviderSpiConnectionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProviderSpiConnectionSettings
    : IProviderSpiConnectionSettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProviderSpiConnectionSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProviderSpiConnectionSettings, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProviderSpiConnectionSettings, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProviderSpiConnectionSettings, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, int*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, int, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Mode(
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode *")]
            ProviderSpiMode* value
    )
    {
        return (
            (delegate* unmanaged<IProviderSpiConnectionSettings, ProviderSpiMode*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Mode(
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode")]
            ProviderSpiMode value
    )
    {
        return (
            (delegate* unmanaged<IProviderSpiConnectionSettings, ProviderSpiMode, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DataBitLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, int*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DataBitLength([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, int, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ClockFrequency([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, int*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ClockFrequency([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IProviderSpiConnectionSettings, int, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SharingMode(
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode *")]
            ProviderSpiSharingMode* value
    )
    {
        return (
            (delegate* unmanaged<IProviderSpiConnectionSettings, ProviderSpiSharingMode*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_SharingMode(
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode")]
            ProviderSpiSharingMode value
    )
    {
        return (
            (delegate* unmanaged<IProviderSpiConnectionSettings, ProviderSpiSharingMode, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_Mode(
            [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode *")]
                ProviderSpiMode* value
        );

        [VtblIndex(9)]
        HRESULT put_Mode(
            [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode")]
                ProviderSpiMode value
        );

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
            [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode *")]
                ProviderSpiSharingMode* value
        );

        [VtblIndex(15)]
        HRESULT put_SharingMode(
            [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode")]
                ProviderSpiSharingMode value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderSpiMode*, int> get_Mode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderSpiMode, int> put_Mode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DataBitLength;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DataBitLength;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ClockFrequency;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ClockFrequency;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderSpiSharingMode*, int> get_SharingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderSpiSharingMode, int> put_SharingMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProviderSpiConnectionSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProviderSpiConnectionSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProviderSpiConnectionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProviderSpiConnectionSettings(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProviderSpiConnectionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProviderSpiConnectionSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProviderSpiConnectionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProviderSpiConnectionSettings value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProviderSpiConnectionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProviderSpiConnectionSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IProviderSpiConnectionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProviderSpiConnectionSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProviderSpiConnectionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProviderSpiConnectionSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
