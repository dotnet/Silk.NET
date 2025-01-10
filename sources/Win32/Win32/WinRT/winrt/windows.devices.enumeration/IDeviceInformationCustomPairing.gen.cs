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

[Guid("85138C02-4EE6-4914-8370-107A39144C0E")]
[NativeTypeName("struct IDeviceInformationCustomPairing : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationCustomPairing
    : IDeviceInformationCustomPairing.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationCustomPairing));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDeviceInformationCustomPairing, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceInformationCustomPairing, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceInformationCustomPairing, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationCustomPairing, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IDeviceInformationCustomPairing, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDeviceInformationCustomPairing, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PairAsync(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")]
            DevicePairingKinds pairingKindsSupported,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationCustomPairing,
                DevicePairingKinds,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, pairingKindsSupported, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PairWithProtectionLevelAsync(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")]
            DevicePairingKinds pairingKindsSupported,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")]
            DevicePairingProtectionLevel minProtectionLevel,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationCustomPairing,
                DevicePairingKinds,
                DevicePairingProtectionLevel,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, pairingKindsSupported, minProtectionLevel, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PairWithProtectionLevelAndSettingsAsync(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")]
            DevicePairingKinds pairingKindsSupported,
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
                IDeviceInformationCustomPairing,
                DevicePairingKinds,
                DevicePairingProtectionLevel,
                IDevicePairingSettings,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, pairingKindsSupported, minProtectionLevel, devicePairingSettings, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PairingRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationCustomPairing,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PairingRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDeviceInformationCustomPairing, EventRegistrationToken, int>)(
                (*lpVtbl)[10]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PairAsync(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")]
                DevicePairingKinds pairingKindsSupported,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT PairWithProtectionLevelAsync(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")]
                DevicePairingKinds pairingKindsSupported,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")]
                DevicePairingProtectionLevel minProtectionLevel,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT PairWithProtectionLevelAndSettingsAsync(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")]
                DevicePairingKinds pairingKindsSupported,
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
        HRESULT add_PairingRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_PairingRequested(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DevicePairingKinds,
            IAsyncOperation<IntPtr>**,
            int> PairAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds, ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DevicePairingKinds,
            DevicePairingProtectionLevel,
            IAsyncOperation<IntPtr>**,
            int> PairWithProtectionLevelAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds, ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel, ABI::Windows::Devices::Enumeration::IDevicePairingSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DevicePairingKinds,
            DevicePairingProtectionLevel,
            IDevicePairingSettings,
            IAsyncOperation<IntPtr>**,
            int> PairWithProtectionLevelAndSettingsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PairingRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PairingRequested;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceInformationCustomPairing"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceInformationCustomPairing(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceInformationCustomPairing"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceInformationCustomPairing(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IDeviceInformationCustomPairing(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationCustomPairing"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationCustomPairing"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IDeviceInformationCustomPairing value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceInformationCustomPairing"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceInformationCustomPairing(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceInformationCustomPairing(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationCustomPairing"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationCustomPairing"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceInformationCustomPairing value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
