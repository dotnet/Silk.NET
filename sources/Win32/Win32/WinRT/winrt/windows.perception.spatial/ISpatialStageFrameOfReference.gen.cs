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

[Guid("7A8A3464-AD0D-4590-AB86-33062B674926")]
[NativeTypeName("struct ISpatialStageFrameOfReference : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialStageFrameOfReference
    : ISpatialStageFrameOfReference.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialStageFrameOfReference));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialStageFrameOfReference, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialStageFrameOfReference, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialStageFrameOfReference, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISpatialStageFrameOfReference, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialStageFrameOfReference, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISpatialStageFrameOfReference, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CoordinateSystem(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
            ISpatialCoordinateSystem* value
    )
    {
        return (
            (delegate* unmanaged<ISpatialStageFrameOfReference, ISpatialCoordinateSystem*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MovementRange(
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialMovementRange *")]
            SpatialMovementRange* value
    )
    {
        return (
            (delegate* unmanaged<ISpatialStageFrameOfReference, SpatialMovementRange*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LookDirectionRange(
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLookDirectionRange *")]
            SpatialLookDirectionRange* value
    )
    {
        return (
            (delegate* unmanaged<ISpatialStageFrameOfReference, SpatialLookDirectionRange*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCoordinateSystemAtCurrentLocation(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocator *")]
            ISpatialLocator locator,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
            ISpatialCoordinateSystem* result
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialStageFrameOfReference,
                ISpatialLocator,
                ISpatialCoordinateSystem*,
                int>)((*lpVtbl)[9])
        )(this, locator, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryGetMovementBounds(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 **")] Vector3** value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialStageFrameOfReference,
                ISpatialCoordinateSystem,
                uint*,
                Vector3**,
                int>)((*lpVtbl)[10])
        )(this, coordinateSystem, valueLength, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CoordinateSystem(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
                ISpatialCoordinateSystem* value
        );

        [VtblIndex(7)]
        HRESULT get_MovementRange(
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialMovementRange *")]
                SpatialMovementRange* value
        );

        [VtblIndex(8)]
        HRESULT get_LookDirectionRange(
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLookDirectionRange *")]
                SpatialLookDirectionRange* value
        );

        [VtblIndex(9)]
        HRESULT GetCoordinateSystemAtCurrentLocation(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocator *")]
                ISpatialLocator locator,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
                ISpatialCoordinateSystem* result
        );

        [VtblIndex(10)]
        HRESULT TryGetMovementBounds(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 **")] Vector3** value
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
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpatialCoordinateSystem*, int> get_CoordinateSystem;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::SpatialMovementRange *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpatialMovementRange*, int> get_MovementRange;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::SpatialLookDirectionRange *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpatialLookDirectionRange*, int> get_LookDirectionRange;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialLocator *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialLocator,
            ISpatialCoordinateSystem*,
            int> GetCoordinateSystemAtCurrentLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, UINT32 *, ABI::Windows::Foundation::Numerics::Vector3 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialCoordinateSystem,
            uint*,
            Vector3**,
            int> TryGetMovementBounds;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialStageFrameOfReference"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialStageFrameOfReference(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialStageFrameOfReference"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialStageFrameOfReference(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialStageFrameOfReference(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialStageFrameOfReference"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialStageFrameOfReference"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialStageFrameOfReference value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialStageFrameOfReference"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialStageFrameOfReference(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialStageFrameOfReference(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialStageFrameOfReference"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialStageFrameOfReference"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialStageFrameOfReference value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
