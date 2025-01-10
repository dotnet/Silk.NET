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

[Guid("25F06279-9364-5A6C-8A54-5D4A6D3D922A")]
[NativeTypeName("struct IDeviceInformationStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationStatics3
    : IDeviceInformationStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDeviceInformationStatics3, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceInformationStatics3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceInformationStatics3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationStatics3, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDeviceInformationStatics3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDeviceInformationStatics3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromIdAsyncWithAdditionalPropertiesKindAndSettings(
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* additionalProperties,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")]
            DeviceInformationKind kind,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")]
            IDeviceEnumerationSettings settings,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics3,
                HSTRING,
                IIterable<HSTRING>*,
                DeviceInformationKind,
                IDeviceEnumerationSettings,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, deviceId, additionalProperties, kind, settings, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllAsyncWithAqsFilterAdditionalPropertiesKindAndSettings(
        HSTRING aqsFilter,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* additionalProperties,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")]
            DeviceInformationKind kind,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")]
            IDeviceEnumerationSettings settings,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics3,
                HSTRING,
                IIterable<HSTRING>*,
                DeviceInformationKind,
                IDeviceEnumerationSettings,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, aqsFilter, additionalProperties, kind, settings, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWatcherWithAqsFilterAdditionalPropertiesKindAndSettings(
        HSTRING aqsFilter,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* additionalProperties,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")]
            DeviceInformationKind kind,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")]
            IDeviceEnumerationSettings settings,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
            IDeviceWatcher* result
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics3,
                HSTRING,
                IIterable<HSTRING>*,
                DeviceInformationKind,
                IDeviceEnumerationSettings,
                IDeviceWatcher*,
                int>)((*lpVtbl)[8])
        )(this, aqsFilter, additionalProperties, kind, settings, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromIdAsyncWithAdditionalPropertiesKindAndSettings(
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* additionalProperties,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")]
                DeviceInformationKind kind,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")]
                IDeviceEnumerationSettings settings,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT FindAllAsyncWithAqsFilterAdditionalPropertiesKindAndSettings(
            HSTRING aqsFilter,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* additionalProperties,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")]
                DeviceInformationKind kind,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")]
                IDeviceEnumerationSettings settings,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT CreateWatcherWithAqsFilterAdditionalPropertiesKindAndSettings(
            HSTRING aqsFilter,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* additionalProperties,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceInformationKind")]
                DeviceInformationKind kind,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *")]
                IDeviceEnumerationSettings settings,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
                IDeviceWatcher* result
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            DeviceInformationKind,
            IDeviceEnumerationSettings,
            IAsyncOperation<IntPtr>**,
            int> CreateFromIdAsyncWithAdditionalPropertiesKindAndSettings;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            DeviceInformationKind,
            IDeviceEnumerationSettings,
            IAsyncOperation<IntPtr>**,
            int> FindAllAsyncWithAqsFilterAdditionalPropertiesKindAndSettings;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::DeviceInformationKind, ABI::Windows::Devices::Enumeration::IDeviceEnumerationSettings *, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            DeviceInformationKind,
            IDeviceEnumerationSettings,
            IDeviceWatcher*,
            int> CreateWatcherWithAqsFilterAdditionalPropertiesKindAndSettings;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceInformationStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceInformationStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceInformationStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceInformationStatics3(Silk.NET.WinRT.IInspectable value)
    {
        return new IDeviceInformationStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDeviceInformationStatics3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceInformationStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceInformationStatics3(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceInformationStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceInformationStatics3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
