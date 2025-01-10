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

[Guid("AC7B7C05-B33C-47CF-990F-6B8F5577DF71")]
[NativeTypeName("struct IGattDeviceService : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceService : IGattDeviceService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceService));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGattDeviceService, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGattDeviceService, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattDeviceService, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGattDeviceService, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattDeviceService, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGattDeviceService, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN."
    )]
    public HRESULT GetCharacteristics(
        Guid characteristicUuid,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService, Guid, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, characteristicUuid, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN."
    )]
    public HRESULT GetIncludedServices(
        Guid serviceUuid,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IGattDeviceService, Guid, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, serviceUuid, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<IGattDeviceService, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged<IGattDeviceService, Guid*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IGattDeviceService, ushort*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN."
        )]
        HRESULT GetCharacteristics(
            Guid characteristicUuid,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(7)]
        [Obsolete(
            "Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN."
        )]
        HRESULT GetIncludedServices(
            Guid serviceUuid,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(10)]
        HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value);
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
            "HRESULT (GUID, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Guid, IVectorView<IntPtr>**, int> GetCharacteristics;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Guid, IVectorView<IntPtr>**, int> GetIncludedServices;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_AttributeHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattDeviceService"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattDeviceService(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattDeviceService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattDeviceService(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattDeviceService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceService"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceService"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattDeviceService value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattDeviceService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattDeviceService(Silk.NET.Windows.IUnknown value)
    {
        return new IGattDeviceService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattDeviceService"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattDeviceService"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattDeviceService value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
