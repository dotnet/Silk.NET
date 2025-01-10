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

[Guid("F2DB1307-AB6F-4639-A767-54536DC3460F")]
[NativeTypeName("struct II2cConnectionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cConnectionSettings : II2cConnectionSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cConnectionSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<II2cConnectionSettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<II2cConnectionSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<II2cConnectionSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<II2cConnectionSettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<II2cConnectionSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<II2cConnectionSettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SlaveAddress([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<II2cConnectionSettings, int*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SlaveAddress([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<II2cConnectionSettings, int, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BusSpeed(
        [NativeTypeName("ABI::Windows::Devices::I2c::I2cBusSpeed *")] I2cBusSpeed* value
    )
    {
        return ((delegate* unmanaged<II2cConnectionSettings, I2cBusSpeed*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BusSpeed(
        [NativeTypeName("ABI::Windows::Devices::I2c::I2cBusSpeed")] I2cBusSpeed value
    )
    {
        return ((delegate* unmanaged<II2cConnectionSettings, I2cBusSpeed, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SharingMode(
        [NativeTypeName("ABI::Windows::Devices::I2c::I2cSharingMode *")] I2cSharingMode* value
    )
    {
        return ((delegate* unmanaged<II2cConnectionSettings, I2cSharingMode*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SharingMode(
        [NativeTypeName("ABI::Windows::Devices::I2c::I2cSharingMode")] I2cSharingMode value
    )
    {
        return ((delegate* unmanaged<II2cConnectionSettings, I2cSharingMode, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SlaveAddress([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_SlaveAddress([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_BusSpeed(
            [NativeTypeName("ABI::Windows::Devices::I2c::I2cBusSpeed *")] I2cBusSpeed* value
        );

        [VtblIndex(9)]
        HRESULT put_BusSpeed(
            [NativeTypeName("ABI::Windows::Devices::I2c::I2cBusSpeed")] I2cBusSpeed value
        );

        [VtblIndex(10)]
        HRESULT get_SharingMode(
            [NativeTypeName("ABI::Windows::Devices::I2c::I2cSharingMode *")] I2cSharingMode* value
        );

        [VtblIndex(11)]
        HRESULT put_SharingMode(
            [NativeTypeName("ABI::Windows::Devices::I2c::I2cSharingMode")] I2cSharingMode value
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
        public delegate* unmanaged<TSelf*, int*, int> get_SlaveAddress;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SlaveAddress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::I2c::I2cBusSpeed *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, I2cBusSpeed*, int> get_BusSpeed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::I2c::I2cBusSpeed) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, I2cBusSpeed, int> put_BusSpeed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::I2c::I2cSharingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, I2cSharingMode*, int> get_SharingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::I2c::I2cSharingMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, I2cSharingMode, int> put_SharingMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "II2cConnectionSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public II2cConnectionSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "II2cConnectionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator II2cConnectionSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new II2cConnectionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "II2cConnectionSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "II2cConnectionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(II2cConnectionSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "II2cConnectionSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator II2cConnectionSettings(Silk.NET.Windows.IUnknown value)
    {
        return new II2cConnectionSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "II2cConnectionSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "II2cConnectionSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(II2cConnectionSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
