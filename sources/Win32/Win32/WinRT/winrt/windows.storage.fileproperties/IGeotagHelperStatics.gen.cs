// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("41493244-2524-4655-86A6-ED16F5FC716B")]
[NativeTypeName("struct IGeotagHelperStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeotagHelperStatics : IGeotagHelperStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeotagHelperStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeotagHelperStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeotagHelperStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeotagHelperStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeotagHelperStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeotagHelperStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeotagHelperStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGeotagAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeopoint_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IGeotagHelperStatics,
                IStorageFile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, file, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetGeotagFromGeolocatorAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeolocator *")]
            IGeolocator geolocator,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IGeotagHelperStatics,
                IStorageFile,
                IGeolocator,
                IAsyncAction*,
                int>)((*lpVtbl)[7])
        )(this, file, geolocator, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetGeotagAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint *")] IGeopoint geopoint,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IGeotagHelperStatics,
                IStorageFile,
                IGeopoint,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(this, file, geopoint, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetGeotagAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeopoint_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT SetGeotagFromGeolocatorAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeolocator *")]
                IGeolocator geolocator,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(8)]
        HRESULT SetGeotagAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint *")] IGeopoint geopoint,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeopoint_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> GetGeotagAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Devices::Geolocation::IGeolocator *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IGeolocator,
            IAsyncAction*,
            int> SetGeotagFromGeolocatorAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Devices::Geolocation::IGeopoint *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IGeopoint,
            IAsyncAction*,
            int> SetGeotagAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeotagHelperStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeotagHelperStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeotagHelperStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeotagHelperStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeotagHelperStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeotagHelperStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeotagHelperStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeotagHelperStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeotagHelperStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeotagHelperStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IGeotagHelperStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeotagHelperStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeotagHelperStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeotagHelperStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
