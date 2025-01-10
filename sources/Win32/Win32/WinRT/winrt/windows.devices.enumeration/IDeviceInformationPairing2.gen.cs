// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F68612FD-0AEE-4328-85CC-1C742BB1790D")]
[NativeTypeName("struct IDeviceInformationPairing2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationPairing2
    : IDeviceInformationPairing2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationPairing2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDeviceInformationPairing2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceInformationPairing2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceInformationPairing2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationPairing2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDeviceInformationPairing2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDeviceInformationPairing2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProtectionLevel(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *")]
            DevicePairingProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationPairing2, DevicePairingProtectionLevel*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Custom(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformationCustomPairing **")]
            IDeviceInformationCustomPairing* value
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationPairing2,
                IDeviceInformationCustomPairing*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PairWithProtectionLevelAndSettingsAsync(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")]
            DevicePairingProtectionLevel minProtectionLevel,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePairingSettings *")]
            IDevicePairingSettings devicePairingSettings,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationPairing2,
                DevicePairingProtectionLevel,
                IDevicePairingSettings,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, minProtectionLevel, devicePairingSettings, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnpairAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceUnpairingResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationPairing2, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProtectionLevel(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *")]
                DevicePairingProtectionLevel* value
        );

        [VtblIndex(7)]
        HRESULT get_Custom(
            [NativeTypeName(
                "ABI::Windows::Devices::Enumeration::IDeviceInformationCustomPairing **"
            )]
                IDeviceInformationCustomPairing* value
        );

        [VtblIndex(8)]
        HRESULT PairWithProtectionLevelAndSettingsAsync(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")]
                DevicePairingProtectionLevel minProtectionLevel,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePairingSettings *")]
                IDevicePairingSettings devicePairingSettings,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT UnpairAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceUnpairingResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
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
            "HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DevicePairingProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformationCustomPairing **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceInformationCustomPairing*, int> get_Custom;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel, ABI::Windows::Devices::Enumeration::IDevicePairingSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DevicePairingProtectionLevel,
            IDevicePairingSettings,
            IAsyncOperation<IntPtr>**,
            int> PairWithProtectionLevelAndSettingsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceUnpairingResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> UnpairAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceInformationPairing2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceInformationPairing2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceInformationPairing2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceInformationPairing2(Silk.NET.WinRT.IInspectable value)
    {
        return new IDeviceInformationPairing2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationPairing2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationPairing2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDeviceInformationPairing2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceInformationPairing2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceInformationPairing2(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceInformationPairing2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationPairing2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationPairing2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceInformationPairing2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
