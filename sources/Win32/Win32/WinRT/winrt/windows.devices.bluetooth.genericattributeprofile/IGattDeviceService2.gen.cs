// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FC54520B-0B0D-4708-BAE0-9FFD9489BC59")]
[NativeTypeName("struct IGattDeviceService2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceService2 : IGattDeviceService2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceService2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGattDeviceService2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGattDeviceService2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattDeviceService2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGattDeviceService2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattDeviceService2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGattDeviceService2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use Session instead of Device property.  For more information, see MSDN.")]
    public HRESULT get_Device(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEDevice **")]
            IBluetoothLEDevice* value
    )
    {
        return ((delegate* unmanaged<IGattDeviceService2, IBluetoothLEDevice*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "ParentServices may be altered or unavailable in future releases.  For more information, see MSDN."
    )]
    public HRESULT get_ParentServices(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService2, IVectorView<IntPtr>**, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN."
    )]
    public HRESULT GetAllCharacteristics(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **"
        )]
            IVectorView<IntPtr>** characteristics
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService2, IVectorView<IntPtr>**, int>)((*lpVtbl)[8])
        )(this, characteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN."
    )]
    public HRESULT GetAllIncludedServices(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
        )]
            IVectorView<IntPtr>** includedServices
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService2, IVectorView<IntPtr>**, int>)((*lpVtbl)[9])
        )(this, includedServices);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use Session instead of Device property.  For more information, see MSDN.")]
        HRESULT get_Device(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEDevice **")]
                IBluetoothLEDevice* value
        );

        [VtblIndex(7)]
        [Obsolete(
            "ParentServices may be altered or unavailable in future releases.  For more information, see MSDN."
        )]
        HRESULT get_ParentServices(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(8)]
        [Obsolete(
            "Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN."
        )]
        HRESULT GetAllCharacteristics(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **"
            )]
                IVectorView<IntPtr>** characteristics
        );

        [VtblIndex(9)]
        [Obsolete(
            "Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN."
        )]
        HRESULT GetAllIncludedServices(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
            )]
                IVectorView<IntPtr>** includedServices
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEDevice **) __attribute__((stdcall))"
        )]
        [Obsolete("Use Session instead of Device property.  For more information, see MSDN.")]
        public delegate* unmanaged<TSelf*, IBluetoothLEDevice*, int> get_Device;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "ParentServices may be altered or unavailable in future releases.  For more information, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_ParentServices;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetAllCharacteristics;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetAllIncludedServices;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattDeviceService2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattDeviceService2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattDeviceService2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattDeviceService2(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattDeviceService2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceService2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceService2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattDeviceService2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattDeviceService2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattDeviceService2(Silk.NET.Windows.IUnknown value)
    {
        return new IGattDeviceService2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceService2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceService2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattDeviceService2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
