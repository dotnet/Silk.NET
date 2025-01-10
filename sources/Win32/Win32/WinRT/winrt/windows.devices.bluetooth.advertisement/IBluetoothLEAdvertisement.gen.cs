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

[Guid("066FB2B7-33D1-4E7D-8367-CF81D0F79653")]
[NativeTypeName("struct IBluetoothLEAdvertisement : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisement
    : IBluetoothLEAdvertisement.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Flags(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t **"
        )]
            IReference<BluetoothLEAdvertisementFlags>** value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisement,
                IReference<BluetoothLEAdvertisementFlags>**,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Flags(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t *"
        )]
            IReference<BluetoothLEAdvertisementFlags>* value
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAdvertisement,
                IReference<BluetoothLEAdvertisementFlags>*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalName(HSTRING* value)
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LocalName(HSTRING value)
    {
        return ((delegate* unmanaged<IBluetoothLEAdvertisement, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServiceUuids(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_GUID_t **")]
            IVector<Guid>** value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisement, IVector<Guid>**, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ManufacturerData(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisement, IVector<IntPtr>**, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DataSections(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisement, IVector<IntPtr>**, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetManufacturerDataByCompanyId(
        [NativeTypeName("UINT16")] ushort companyId,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **"
        )]
            IVectorView<IntPtr>** dataList
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisement, ushort, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, companyId, dataList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSectionsByType(
        byte type,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **"
        )]
            IVectorView<IntPtr>** sectionList
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAdvertisement, byte, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, type, sectionList);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Flags(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t **"
            )]
                IReference<BluetoothLEAdvertisementFlags>** value
        );

        [VtblIndex(7)]
        HRESULT put_Flags(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t *"
            )]
                IReference<BluetoothLEAdvertisementFlags>* value
        );

        [VtblIndex(8)]
        HRESULT get_LocalName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_LocalName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ServiceUuids(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_GUID_t **")]
                IVector<Guid>** value
        );

        [VtblIndex(11)]
        HRESULT get_ManufacturerData(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT get_DataSections(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(13)]
        HRESULT GetManufacturerDataByCompanyId(
            [NativeTypeName("UINT16")] ushort companyId,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **"
            )]
                IVectorView<IntPtr>** dataList
        );

        [VtblIndex(14)]
        HRESULT GetSectionsByType(
            byte type,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **"
            )]
                IVectorView<IntPtr>** sectionList
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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<BluetoothLEAdvertisementFlags>**,
            int> get_Flags;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<BluetoothLEAdvertisementFlags>*,
            int> put_Flags;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_LocalName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_LocalName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_GUID_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<Guid>**, int> get_ServiceUuids;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_ManufacturerData;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_DataSections;

        [NativeTypeName(
            "HRESULT (UINT16, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort,
            IVectorView<IntPtr>**,
            int> GetManufacturerDataByCompanyId;

        [NativeTypeName(
            "HRESULT (BYTE, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte, IVectorView<IntPtr>**, int> GetSectionsByType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAdvertisement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAdvertisement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAdvertisement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisement(Silk.NET.WinRT.IInspectable value)
    {
        return new IBluetoothLEAdvertisement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisement"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisement"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBluetoothLEAdvertisement value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAdvertisement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAdvertisement(Silk.NET.Windows.IUnknown value)
    {
        return new IBluetoothLEAdvertisement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAdvertisement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAdvertisement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBluetoothLEAdvertisement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
