// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("912DBA18-6963-4533-B061-4694DAFB34E5")]
[NativeTypeName("struct IBluetoothLEManufacturerData : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEManufacturerData
    : IBluetoothLEManufacturerData.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEManufacturerData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEManufacturerData, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBluetoothLEManufacturerData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEManufacturerData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEManufacturerData, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBluetoothLEManufacturerData, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEManufacturerData, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CompanyId([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IBluetoothLEManufacturerData, ushort*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CompanyId([NativeTypeName("UINT16")] ushort value)
    {
        return ((delegate* unmanaged<IBluetoothLEManufacturerData, ushort, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Data(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IBluetoothLEManufacturerData, IBuffer*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Data(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
    )
    {
        return ((delegate* unmanaged<IBluetoothLEManufacturerData, IBuffer, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CompanyId([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT put_CompanyId([NativeTypeName("UINT16")] ushort value);

        [VtblIndex(8)]
        HRESULT get_Data(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(9)]
        HRESULT put_Data(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
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

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_CompanyId;

        [NativeTypeName("HRESULT (UINT16) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> put_CompanyId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_Data;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> put_Data;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEManufacturerData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEManufacturerData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEManufacturerData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEManufacturerData(Silk.NET.WinRT.IInspectable value)
    {
        return new IBluetoothLEManufacturerData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEManufacturerData"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEManufacturerData"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBluetoothLEManufacturerData value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEManufacturerData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEManufacturerData(Silk.NET.Windows.IUnknown value)
    {
        return new IBluetoothLEManufacturerData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEManufacturerData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEManufacturerData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBluetoothLEManufacturerData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
