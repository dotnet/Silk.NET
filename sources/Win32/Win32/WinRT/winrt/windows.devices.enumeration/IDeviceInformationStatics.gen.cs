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

[Guid("C17F100E-3A46-4A78-8013-769DC9B97390")]
[NativeTypeName("struct IDeviceInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationStatics
    : IDeviceInformationStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceInformationStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeviceInformationStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceInformationStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDeviceInformationStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDeviceInformationStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDeviceInformationStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromIdAsync(
        HSTRING deviceId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, deviceId, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromIdAsyncAdditionalProperties(
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* additionalProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics,
                HSTRING,
                IIterable<HSTRING>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, deviceId, additionalProperties, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAllAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationStatics, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindAllAsyncDeviceClass(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics,
                DeviceClass,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, deviceClass, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAllAsyncAqsFilter(
        HSTRING aqsFilter,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, aqsFilter, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindAllAsyncAqsFilterAndAdditionalProperties(
        HSTRING aqsFilter,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* additionalProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics,
                HSTRING,
                IIterable<HSTRING>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, aqsFilter, additionalProperties, asyncOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateWatcher(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
            IDeviceWatcher* watcher
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationStatics, IDeviceWatcher*, int>)((*lpVtbl)[12])
        )(this, watcher);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateWatcherDeviceClass(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
            IDeviceWatcher* watcher
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationStatics, DeviceClass, IDeviceWatcher*, int>)(
                (*lpVtbl)[13]
            )
        )(this, deviceClass, watcher);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateWatcherAqsFilter(
        HSTRING aqsFilter,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
            IDeviceWatcher* watcher
    )
    {
        return (
            (delegate* unmanaged<IDeviceInformationStatics, HSTRING, IDeviceWatcher*, int>)(
                (*lpVtbl)[14]
            )
        )(this, aqsFilter, watcher);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateWatcherAqsFilterAndAdditionalProperties(
        HSTRING aqsFilter,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* additionalProperties,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
            IDeviceWatcher* watcher
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceInformationStatics,
                HSTRING,
                IIterable<HSTRING>*,
                IDeviceWatcher*,
                int>)((*lpVtbl)[15])
        )(this, aqsFilter, additionalProperties, watcher);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromIdAsync(
            HSTRING deviceId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(7)]
        HRESULT CreateFromIdAsyncAdditionalProperties(
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* additionalProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(8)]
        HRESULT FindAllAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(9)]
        HRESULT FindAllAsyncDeviceClass(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")]
                DeviceClass deviceClass,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(10)]
        HRESULT FindAllAsyncAqsFilter(
            HSTRING aqsFilter,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(11)]
        HRESULT FindAllAsyncAqsFilterAndAdditionalProperties(
            HSTRING aqsFilter,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* additionalProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOp
        );

        [VtblIndex(12)]
        HRESULT CreateWatcher(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
                IDeviceWatcher* watcher
        );

        [VtblIndex(13)]
        HRESULT CreateWatcherDeviceClass(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")]
                DeviceClass deviceClass,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
                IDeviceWatcher* watcher
        );

        [VtblIndex(14)]
        HRESULT CreateWatcherAqsFilter(
            HSTRING aqsFilter,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
                IDeviceWatcher* watcher
        );

        [VtblIndex(15)]
        HRESULT CreateWatcherAqsFilterAndAdditionalProperties(
            HSTRING aqsFilter,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* additionalProperties,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceWatcher **")]
                IDeviceWatcher* watcher
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFromIdAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> CreateFromIdAsyncAdditionalProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindAllAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::DeviceClass, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DeviceClass,
            IAsyncOperation<IntPtr>**,
            int> FindAllAsyncDeviceClass;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FindAllAsyncAqsFilter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformationCollection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> FindAllAsyncAqsFilterAndAdditionalProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceWatcher*, int> CreateWatcher;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::DeviceClass, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DeviceClass,
            IDeviceWatcher*,
            int> CreateWatcherDeviceClass;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IDeviceWatcher*, int> CreateWatcherAqsFilter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Enumeration::IDeviceWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            IDeviceWatcher*,
            int> CreateWatcherAqsFilterAndAdditionalProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceInformationStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceInformationStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceInformationStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IDeviceInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDeviceInformationStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceInformationStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceInformationStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceInformationStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
