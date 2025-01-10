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

[Guid("AFD6531F-72B1-4F7D-87CC-4ED4C9849C05")]
[NativeTypeName("struct IGeocircleFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeocircleFactory : IGeocircleFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeocircleFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeocircleFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeocircleFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeocircleFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeocircleFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeocircleFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeocircleFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition position,
        double radius,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle* value
    )
    {
        return (
            (delegate* unmanaged<IGeocircleFactory, BasicGeoposition, double, IGeocircle*, int>)(
                (*lpVtbl)[6]
            )
        )(this, position, radius, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithAltitudeReferenceSystem(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition position,
        double radius,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
            AltitudeReferenceSystem altitudeReferenceSystem,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeocircleFactory,
                BasicGeoposition,
                double,
                AltitudeReferenceSystem,
                IGeocircle*,
                int>)((*lpVtbl)[7])
        )(this, position, radius, altitudeReferenceSystem, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithAltitudeReferenceSystemAndSpatialReferenceId(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition position,
        double radius,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
            AltitudeReferenceSystem altitudeReferenceSystem,
        [NativeTypeName("UINT32")] uint spatialReferenceId,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeocircleFactory,
                BasicGeoposition,
                double,
                AltitudeReferenceSystem,
                uint,
                IGeocircle*,
                int>)((*lpVtbl)[8])
        )(this, position, radius, altitudeReferenceSystem, spatialReferenceId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition position,
            double radius,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle* value
        );

        [VtblIndex(7)]
        HRESULT CreateWithAltitudeReferenceSystem(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition position,
            double radius,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
                AltitudeReferenceSystem altitudeReferenceSystem,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle* value
        );

        [VtblIndex(8)]
        HRESULT CreateWithAltitudeReferenceSystemAndSpatialReferenceId(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition position,
            double radius,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
                AltitudeReferenceSystem altitudeReferenceSystem,
            [NativeTypeName("UINT32")] uint spatialReferenceId,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle* value
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
            "HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, DOUBLE, ABI::Windows::Devices::Geolocation::IGeocircle **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BasicGeoposition, double, IGeocircle*, int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, DOUBLE, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, ABI::Windows::Devices::Geolocation::IGeocircle **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BasicGeoposition,
            double,
            AltitudeReferenceSystem,
            IGeocircle*,
            int> CreateWithAltitudeReferenceSystem;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, DOUBLE, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, UINT32, ABI::Windows::Devices::Geolocation::IGeocircle **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BasicGeoposition,
            double,
            AltitudeReferenceSystem,
            uint,
            IGeocircle*,
            int> CreateWithAltitudeReferenceSystemAndSpatialReferenceId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeocircleFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeocircleFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeocircleFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeocircleFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeocircleFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeocircleFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeocircleFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeocircleFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeocircleFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeocircleFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IGeocircleFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeocircleFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeocircleFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeocircleFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
