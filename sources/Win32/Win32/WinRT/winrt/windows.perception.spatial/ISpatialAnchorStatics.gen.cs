// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A9928642-0174-311C-AE79-0E5107669F16")]
[NativeTypeName("struct ISpatialAnchorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorStatics : ISpatialAnchorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAnchorStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialAnchorStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAnchorStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpatialAnchorStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialAnchorStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpatialAnchorStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCreateRelativeTo(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")]
            ISpatialAnchor* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorStatics,
                ISpatialCoordinateSystem,
                ISpatialAnchor*,
                int>)((*lpVtbl)[6])
        )(this, coordinateSystem, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryCreateWithPositionRelativeTo(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")]
            ISpatialAnchor* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorStatics,
                ISpatialCoordinateSystem,
                Vector3,
                ISpatialAnchor*,
                int>)((*lpVtbl)[7])
        )(this, coordinateSystem, position, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryCreateWithPositionAndOrientationRelativeTo(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion orientation,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")]
            ISpatialAnchor* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorStatics,
                ISpatialCoordinateSystem,
                Vector3,
                Quaternion,
                ISpatialAnchor*,
                int>)((*lpVtbl)[8])
        )(this, coordinateSystem, position, orientation, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCreateRelativeTo(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")]
                ISpatialAnchor* value
        );

        [VtblIndex(7)]
        HRESULT TryCreateWithPositionRelativeTo(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")]
                ISpatialAnchor* value
        );

        [VtblIndex(8)]
        HRESULT TryCreateWithPositionAndOrientationRelativeTo(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
                Quaternion orientation,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")]
                ISpatialAnchor* value
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
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::ISpatialAnchor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            ISpatialAnchor*,
            int> TryCreateRelativeTo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Perception::Spatial::ISpatialAnchor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            Vector3,
            ISpatialAnchor*,
            int> TryCreateWithPositionRelativeTo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, ABI::Windows::Perception::Spatial::ISpatialAnchor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            Vector3,
            Quaternion,
            ISpatialAnchor*,
            int> TryCreateWithPositionAndOrientationRelativeTo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAnchorStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAnchorStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialAnchorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialAnchorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialAnchorStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAnchorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAnchorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAnchorStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
