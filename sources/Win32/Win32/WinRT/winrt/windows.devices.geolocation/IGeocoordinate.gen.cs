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

[Guid("EE21A3AA-976A-4C70-803D-083EA55BCBC4")]
[NativeTypeName("struct IGeocoordinate : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeocoordinate : IGeocoordinate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeocoordinate));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeocoordinate, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeocoordinate, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeocoordinate, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeocoordinate, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeocoordinate, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeocoordinate, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude"
    )]
    public HRESULT get_Latitude(double* value)
    {
        return ((delegate* unmanaged<IGeocoordinate, double*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude"
    )]
    public HRESULT get_Longitude(double* value)
    {
        return ((delegate* unmanaged<IGeocoordinate, double*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude"
    )]
    public HRESULT get_Altitude(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
            IReference<double>** value
    )
    {
        return ((delegate* unmanaged<IGeocoordinate, IReference<double>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Accuracy(double* value)
    {
        return ((delegate* unmanaged<IGeocoordinate, double*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AltitudeAccuracy(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
            IReference<double>** value
    )
    {
        return ((delegate* unmanaged<IGeocoordinate, IReference<double>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Heading(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
            IReference<double>** value
    )
    {
        return ((delegate* unmanaged<IGeocoordinate, IReference<double>**, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Speed(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
            IReference<double>** value
    )
    {
        return ((delegate* unmanaged<IGeocoordinate, IReference<double>**, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Timestamp(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IGeocoordinate, WinRTDateTime*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude"
        )]
        HRESULT get_Latitude(double* value);

        [VtblIndex(7)]
        [Obsolete(
            "Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude"
        )]
        HRESULT get_Longitude(double* value);

        [VtblIndex(8)]
        [Obsolete(
            "Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude"
        )]
        HRESULT get_Altitude(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
                IReference<double>** value
        );

        [VtblIndex(9)]
        HRESULT get_Accuracy(double* value);

        [VtblIndex(10)]
        HRESULT get_AltitudeAccuracy(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
                IReference<double>** value
        );

        [VtblIndex(11)]
        HRESULT get_Heading(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
                IReference<double>** value
        );

        [VtblIndex(12)]
        HRESULT get_Speed(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
                IReference<double>** value
        );

        [VtblIndex(13)]
        HRESULT get_Timestamp(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete(
            "Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude"
        )]
        public delegate* unmanaged<TSelf*, double*, int> get_Latitude;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete(
            "Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude"
        )]
        public delegate* unmanaged<TSelf*, double*, int> get_Longitude;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>**, int> get_Altitude;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Accuracy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>**, int> get_AltitudeAccuracy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>**, int> get_Heading;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>**, int> get_Speed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_Timestamp;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeocoordinate"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeocoordinate(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeocoordinate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeocoordinate(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeocoordinate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeocoordinate"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeocoordinate"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeocoordinate value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeocoordinate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeocoordinate(Silk.NET.Windows.IUnknown value)
    {
        return new IGeocoordinate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeocoordinate"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeocoordinate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeocoordinate value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
