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

[Guid("4DFBA589-0411-4ABC-B3B5-5BBCCB57D98C")]
[NativeTypeName("struct IGeoboundingBoxFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeoboundingBoxFactory : IGeoboundingBoxFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeoboundingBoxFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeoboundingBoxFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeoboundingBoxFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeoboundingBoxFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeoboundingBoxFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeoboundingBoxFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeoboundingBoxFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition northwestCorner,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition southeastCorner,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
            IGeoboundingBox* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeoboundingBoxFactory,
                BasicGeoposition,
                BasicGeoposition,
                IGeoboundingBox*,
                int>)((*lpVtbl)[6])
        )(this, northwestCorner, southeastCorner, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithAltitudeReference(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition northwestCorner,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition southeastCorner,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
            AltitudeReferenceSystem altitudeReferenceSystem,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
            IGeoboundingBox* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeoboundingBoxFactory,
                BasicGeoposition,
                BasicGeoposition,
                AltitudeReferenceSystem,
                IGeoboundingBox*,
                int>)((*lpVtbl)[7])
        )(this, northwestCorner, southeastCorner, altitudeReferenceSystem, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithAltitudeReferenceAndSpatialReference(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition northwestCorner,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
            BasicGeoposition southeastCorner,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
            AltitudeReferenceSystem altitudeReferenceSystem,
        [NativeTypeName("UINT32")] uint spatialReferenceId,
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
            IGeoboundingBox* value
    )
    {
        return (
            (delegate* unmanaged<
                IGeoboundingBoxFactory,
                BasicGeoposition,
                BasicGeoposition,
                AltitudeReferenceSystem,
                uint,
                IGeoboundingBox*,
                int>)((*lpVtbl)[8])
        )(
            this,
            northwestCorner,
            southeastCorner,
            altitudeReferenceSystem,
            spatialReferenceId,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition northwestCorner,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition southeastCorner,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
                IGeoboundingBox* value
        );

        [VtblIndex(7)]
        HRESULT CreateWithAltitudeReference(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition northwestCorner,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition southeastCorner,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
                AltitudeReferenceSystem altitudeReferenceSystem,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")]
                IGeoboundingBox* value
        );

        [VtblIndex(8)]
        HRESULT CreateWithAltitudeReferenceAndSpatialReference(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition northwestCorner,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")]
                BasicGeoposition southeastCorner,
            [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")]
                AltitudeReferenceSystem altitudeReferenceSystem,
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
            "HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BasicGeoposition,
            BasicGeoposition,
            IGeoboundingBox*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BasicGeoposition,
            BasicGeoposition,
            AltitudeReferenceSystem,
            IGeoboundingBox*,
            int> CreateWithAltitudeReference;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, UINT32, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BasicGeoposition,
            BasicGeoposition,
            AltitudeReferenceSystem,
            uint,
            IGeoboundingBox*,
            int> CreateWithAltitudeReferenceAndSpatialReference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeoboundingBoxFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeoboundingBoxFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeoboundingBoxFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeoboundingBoxFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeoboundingBoxFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeoboundingBoxFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeoboundingBoxFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeoboundingBoxFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeoboundingBoxFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeoboundingBoxFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IGeoboundingBoxFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeoboundingBoxFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeoboundingBoxFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeoboundingBoxFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
