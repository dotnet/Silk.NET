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

[Guid("FAF73DB4-4CFF-44C7-8445-040E6EAD0063")]
[NativeTypeName("struct IGattLocalCharacteristicParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalCharacteristicParameters
    : IGattLocalCharacteristicParameters.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattLocalCharacteristicParameters));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGattLocalCharacteristicParameters, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattLocalCharacteristicParameters, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_StaticValue(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, IBuffer, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StaticValue(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, IBuffer*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CharacteristicProperties(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties"
        )]
            GattCharacteristicProperties value
    )
    {
        return (
            (delegate* unmanaged<
                IGattLocalCharacteristicParameters,
                GattCharacteristicProperties,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CharacteristicProperties(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *"
        )]
            GattCharacteristicProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IGattLocalCharacteristicParameters,
                GattCharacteristicProperties*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ReadProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel"
        )]
            GattProtectionLevel value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, GattProtectionLevel, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ReadProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
        )]
            GattProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, GattProtectionLevel*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_WriteProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel"
        )]
            GattProtectionLevel value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, GattProtectionLevel, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_WriteProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
        )]
            GattProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, GattProtectionLevel*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_UserDescription(HSTRING value)
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, HSTRING, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_UserDescription(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, HSTRING*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_PresentationFormats(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalCharacteristicParameters, IVector<IntPtr>**, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_StaticValue(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
        );

        [VtblIndex(7)]
        HRESULT get_StaticValue(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(8)]
        HRESULT put_CharacteristicProperties(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties"
            )]
                GattCharacteristicProperties value
        );

        [VtblIndex(9)]
        HRESULT get_CharacteristicProperties(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *"
            )]
                GattCharacteristicProperties* value
        );

        [VtblIndex(10)]
        HRESULT put_ReadProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel"
            )]
                GattProtectionLevel value
        );

        [VtblIndex(11)]
        HRESULT get_ReadProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
            )]
                GattProtectionLevel* value
        );

        [VtblIndex(12)]
        HRESULT put_WriteProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel"
            )]
                GattProtectionLevel value
        );

        [VtblIndex(13)]
        HRESULT get_WriteProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
            )]
                GattProtectionLevel* value
        );

        [VtblIndex(14)]
        HRESULT put_UserDescription(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_UserDescription(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_PresentationFormats(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **"
            )]
                IVector<IntPtr>** value
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
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> put_StaticValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_StaticValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GattCharacteristicProperties,
            int> put_CharacteristicProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GattCharacteristicProperties*,
            int> get_CharacteristicProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel, int> put_ReadProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel*, int> get_ReadProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel, int> put_WriteProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel*, int> get_WriteProtectionLevel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_UserDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserDescription;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_PresentationFormats;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattLocalCharacteristicParameters"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattLocalCharacteristicParameters(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattLocalCharacteristicParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattLocalCharacteristicParameters(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IGattLocalCharacteristicParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattLocalCharacteristicParameters"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattLocalCharacteristicParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IGattLocalCharacteristicParameters value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattLocalCharacteristicParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattLocalCharacteristicParameters(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IGattLocalCharacteristicParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattLocalCharacteristicParameters"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattLocalCharacteristicParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IGattLocalCharacteristicParameters value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
