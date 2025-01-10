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

[Guid("59CB50C1-5934-4F68-A198-EB864FA44E6B")]
[NativeTypeName("struct IGattCharacteristic : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristic : IGattCharacteristic.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattCharacteristic));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGattCharacteristic, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGattCharacteristic, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattCharacteristic, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGattCharacteristic, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattCharacteristic, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGattCharacteristic, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN."
    )]
    public HRESULT GetDescriptors(
        Guid descriptorUuid,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IGattCharacteristic, Guid, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, descriptorUuid, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CharacteristicProperties(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *"
        )]
            GattCharacteristicProperties* value
    )
    {
        return (
            (delegate* unmanaged<IGattCharacteristic, GattCharacteristicProperties*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
        )]
            GattProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IGattCharacteristic, GattProtectionLevel*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel"
        )]
            GattProtectionLevel value
    )
    {
        return ((delegate* unmanaged<IGattCharacteristic, GattProtectionLevel, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UserDescription(HSTRING* value)
    {
        return ((delegate* unmanaged<IGattCharacteristic, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristic, Guid*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IGattCharacteristic, ushort*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PresentationFormats(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IGattCharacteristic, IVectorView<IntPtr>**, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReadValueAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IGattCharacteristic, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReadValueWithCacheModeAsync(
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
            BluetoothCacheMode cacheMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IGattCharacteristic,
                BluetoothCacheMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[15])
        )(this, cacheMode, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT WriteValueAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
        )]
            IAsyncOperation<GattCommunicationStatus>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IGattCharacteristic,
                IBuffer,
                IAsyncOperation<GattCommunicationStatus>**,
                int>)((*lpVtbl)[16])
        )(this, value, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteValueWithOptionAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value,
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption"
        )]
            GattWriteOption writeOption,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
        )]
            IAsyncOperation<GattCommunicationStatus>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IGattCharacteristic,
                IBuffer,
                GattWriteOption,
                IAsyncOperation<GattCommunicationStatus>**,
                int>)((*lpVtbl)[17])
        )(this, value, writeOption, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadClientCharacteristicConfigurationDescriptorAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadClientCharacteristicConfigurationDescriptorResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<IGattCharacteristic, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteClientCharacteristicConfigurationDescriptorAsync(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue"
        )]
            GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
        )]
            IAsyncOperation<GattCommunicationStatus>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IGattCharacteristic,
                GattClientCharacteristicConfigurationDescriptorValue,
                IAsyncOperation<GattCommunicationStatus>**,
                int>)((*lpVtbl)[19])
        )(this, clientCharacteristicConfigurationDescriptorValue, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_ValueChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* valueChangedHandler,
        EventRegistrationToken* valueChangedEventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IGattCharacteristic,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[20])
        )(this, valueChangedHandler, valueChangedEventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_ValueChanged(EventRegistrationToken valueChangedEventCookie)
    {
        return (
            (delegate* unmanaged<IGattCharacteristic, EventRegistrationToken, int>)((*lpVtbl)[21])
        )(this, valueChangedEventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN."
        )]
        HRESULT GetDescriptors(
            Guid descriptorUuid,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT get_CharacteristicProperties(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *"
            )]
                GattCharacteristicProperties* value
        );

        [VtblIndex(8)]
        HRESULT get_ProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
            )]
                GattProtectionLevel* value
        );

        [VtblIndex(9)]
        HRESULT put_ProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel"
            )]
                GattProtectionLevel value
        );

        [VtblIndex(10)]
        HRESULT get_UserDescription(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(12)]
        HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_PresentationFormats(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(14)]
        HRESULT ReadValueAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(15)]
        HRESULT ReadValueWithCacheModeAsync(
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")]
                BluetoothCacheMode cacheMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(16)]
        HRESULT WriteValueAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
            )]
                IAsyncOperation<GattCommunicationStatus>** asyncOp
        );

        [VtblIndex(17)]
        HRESULT WriteValueWithOptionAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value,
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption"
            )]
                GattWriteOption writeOption,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
            )]
                IAsyncOperation<GattCommunicationStatus>** asyncOp
        );

        [VtblIndex(18)]
        HRESULT ReadClientCharacteristicConfigurationDescriptorAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadClientCharacteristicConfigurationDescriptorResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(19)]
        HRESULT WriteClientCharacteristicConfigurationDescriptorAsync(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue"
            )]
                GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
            )]
                IAsyncOperation<GattCommunicationStatus>** asyncOp
        );

        [VtblIndex(20)]
        HRESULT add_ValueChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* valueChangedHandler,
            EventRegistrationToken* valueChangedEventCookie
        );

        [VtblIndex(21)]
        HRESULT remove_ValueChanged(EventRegistrationToken valueChangedEventCookie);
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
            "HRESULT (GUID, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Guid, IVectorView<IntPtr>**, int> GetDescriptors;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GattCharacteristicProperties*,
            int> get_CharacteristicProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel, int> put_ProtectionLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserDescription;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_AttributeHandle;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_PresentationFormats;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> ReadValueAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BluetoothCacheMode,
            IAsyncOperation<IntPtr>**,
            int> ReadValueWithCacheModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IAsyncOperation<GattCommunicationStatus>**,
            int> WriteValueAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            GattWriteOption,
            IAsyncOperation<GattCommunicationStatus>**,
            int> WriteValueWithOptionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadClientCharacteristicConfigurationDescriptorResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> ReadClientCharacteristicConfigurationDescriptorAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattClientCharacteristicConfigurationDescriptorValue, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GattClientCharacteristicConfigurationDescriptorValue,
            IAsyncOperation<GattCommunicationStatus>**,
            int> WriteClientCharacteristicConfigurationDescriptorAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattValueChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ValueChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ValueChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattCharacteristic"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattCharacteristic(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattCharacteristic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattCharacteristic(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattCharacteristic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattCharacteristic"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattCharacteristic"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattCharacteristic value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattCharacteristic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattCharacteristic(Silk.NET.Windows.IUnknown value)
    {
        return new IGattCharacteristic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattCharacteristic"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattCharacteristic"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattCharacteristic value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
