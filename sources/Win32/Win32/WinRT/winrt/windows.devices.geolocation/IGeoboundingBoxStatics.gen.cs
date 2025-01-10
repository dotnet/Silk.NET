// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("67B80708-E61A-4CD0-841B-93233792B5CA")]
[NativeTypeName("struct IGeoboundingBoxStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeoboundingBoxStatics : IGeoboundingBoxStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeoboundingBoxStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeoboundingBoxStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeoboundingBoxStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeoboundingBoxStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeoboundingBoxStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeoboundingBoxStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeoboundingBoxStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCompute(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *"
        )]
            IIterable<BasicGeoposition>* positions,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
            IGeoboundingBox* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeoboundingBoxStatics,
                IIterable<BasicGeoposition>*,
                IGeoboundingBox*,
                int>)((*lpVtbl)[6])
        )(this, positions, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryComputeWithAltitudeReference(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *"
        )]
            IIterable<BasicGeoposition>* positions,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
            AltitudeReferenceSystem altitudeRefSystem,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
            IGeoboundingBox* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeoboundingBoxStatics,
                IIterable<BasicGeoposition>*,
                AltitudeReferenceSystem,
                IGeoboundingBox*,
                int>)((*lpVtbl)[7])
        )(this, positions, altitudeRefSystem, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryComputeWithAltitudeReferenceAndSpatialReference(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *"
        )]
            IIterable<BasicGeoposition>* positions,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
            AltitudeReferenceSystem altitudeRefSystem,
        [NativeTypeName("UINT32")] uint spatialReferenceId,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
            IGeoboundingBox* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeoboundingBoxStatics,
                IIterable<BasicGeoposition>*,
                AltitudeReferenceSystem,
                uint,
                IGeoboundingBox*,
                int>)((*lpVtbl)[8])
        )(this, positions, altitudeRefSystem, spatialReferenceId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCompute(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *"
            )]
                IIterable<BasicGeoposition>* positions,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
                IGeoboundingBox* value
        );

        [VtblIndex(7)]
        HRESULT TryComputeWithAltitudeReference(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *"
            )]
                IIterable<BasicGeoposition>* positions,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
                AltitudeReferenceSystem altitudeRefSystem,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
                IGeoboundingBox* value
        );

        [VtblIndex(8)]
        HRESULT TryComputeWithAltitudeReferenceAndSpatialReference(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *"
            )]
                IIterable<BasicGeoposition>* positions,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
                AltitudeReferenceSystem altitudeRefSystem,
            [NativeTypeName("UINT32")] uint spatialReferenceId,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
                IGeoboundingBox* value
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<BasicGeoposition>*,
            IGeoboundingBox*,
            int> TryCompute;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<BasicGeoposition>*,
            AltitudeReferenceSystem,
            IGeoboundingBox*,
            int> TryComputeWithAltitudeReference;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, UINT32, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<BasicGeoposition>*,
            AltitudeReferenceSystem,
            uint,
            IGeoboundingBox*,
            int> TryComputeWithAltitudeReferenceAndSpatialReference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeoboundingBoxStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeoboundingBoxStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeoboundingBoxStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeoboundingBoxStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeoboundingBoxStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeoboundingBoxStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeoboundingBoxStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeoboundingBoxStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeoboundingBoxStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeoboundingBoxStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IGeoboundingBoxStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeoboundingBoxStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeoboundingBoxStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeoboundingBoxStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
