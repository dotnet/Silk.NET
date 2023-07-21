// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1TransformedGeometry.xml' path='doc/member[@name="ID2D1TransformedGeometry"]/*' />
[Guid("2CD906BB-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1TransformedGeometry : ID2D1Geometry")]
[NativeInheritance("ID2D1Geometry")]
public unsafe partial struct ID2D1TransformedGeometry : ID2D1TransformedGeometry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1TransformedGeometry));

    public void** lpVtbl;

    public HRESULT GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return GetWidenedBounds(strokeWidth, strokeStyle, worldTransform, (0.25f), bounds);
    }

    public HRESULT StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, BOOL* contains)
    {
        return StrokeContainsPoint(point, strokeWidth, strokeStyle, worldTransform, (0.25f), contains);
    }

    public HRESULT FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, BOOL* contains)
    {
        return FillContainsPoint(point, worldTransform, (0.25f), contains);
    }

    public HRESULT CompareWithGeometry(ID2D1Geometry* inputGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, D2D1_GEOMETRY_RELATION* relation)
    {
        return CompareWithGeometry(inputGeometry, inputGeometryTransform, (0.25f), relation);
    }

    public HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return Simplify(simplificationOption, worldTransform, (0.25f), geometrySink);
    }

    public HRESULT Tessellate([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1TessellationSink* tessellationSink)
    {
        return Tessellate(worldTransform, (0.25f), tessellationSink);
    }

    public HRESULT CombineWithGeometry(ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return CombineWithGeometry(inputGeometry, combineMode, inputGeometryTransform, (0.25f), geometrySink);
    }

    public HRESULT Outline([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return Outline(worldTransform, (0.25f), geometrySink);
    }

    public HRESULT ComputeArea([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float* area)
    {
        return ComputeArea(worldTransform, (0.25f), area);
    }

    public HRESULT ComputeLength([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float* length)
    {
        return ComputeLength(worldTransform, (0.25f), length);
    }

    public HRESULT ComputePointAtLength(float length, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* point, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* unitTangentVector)
    {
        return ComputePointAtLength(length, worldTransform, (0.25f), point, unitTangentVector);
    }

    public HRESULT Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return Widen(strokeWidth, strokeStyle, worldTransform, (0.25f), geometrySink);
    }

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, uint>)(lpVtbl[1]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, uint>)(lpVtbl[2]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1TransformedGeometry*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref="ID2D1Geometry.GetBounds" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBounds([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int>)(lpVtbl[4]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), worldTransform, bounds);
    }

    /// <inheritdoc cref="ID2D1Geometry.GetWidenedBounds" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, D2D_RECT_F*, int>)(lpVtbl[5]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
    }

    /// <inheritdoc cref="ID2D1Geometry.StrokeContainsPoint" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, BOOL* contains)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, BOOL*, int>)(lpVtbl[6]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
    }

    /// <inheritdoc cref="ID2D1Geometry.FillContainsPoint" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, BOOL* contains)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_POINT_2F, D2D_MATRIX_3X2_F*, float, BOOL*, int>)(lpVtbl[7]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), point, worldTransform, flatteningTolerance, contains);
    }

    /// <inheritdoc cref="ID2D1Geometry.CompareWithGeometry" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CompareWithGeometry(ID2D1Geometry* inputGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, float flatteningTolerance, D2D1_GEOMETRY_RELATION* relation)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, float, D2D1_GEOMETRY_RELATION*, int>)(lpVtbl[8]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
    }

    /// <inheritdoc cref="ID2D1Geometry.Simplify" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D1_GEOMETRY_SIMPLIFICATION_OPTION, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[9]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), simplificationOption, worldTransform, flatteningTolerance, geometrySink);
    }

    /// <inheritdoc cref="ID2D1Geometry.Tessellate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Tessellate([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_MATRIX_3X2_F*, float, ID2D1TessellationSink*, int>)(lpVtbl[10]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, tessellationSink);
    }

    /// <inheritdoc cref="ID2D1Geometry.CombineWithGeometry" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CombineWithGeometry(ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, ID2D1Geometry*, D2D1_COMBINE_MODE, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[11]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
    }

    /// <inheritdoc cref="ID2D1Geometry.Outline" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Outline([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[12]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, geometrySink);
    }

    /// <inheritdoc cref="ID2D1Geometry.ComputeArea" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ComputeArea([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, float* area)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_MATRIX_3X2_F*, float, float*, int>)(lpVtbl[13]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, area);
    }

    /// <inheritdoc cref="ID2D1Geometry.ComputeLength" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ComputeLength([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, float* length)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_MATRIX_3X2_F*, float, float*, int>)(lpVtbl[14]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), worldTransform, flatteningTolerance, length);
    }

    /// <inheritdoc cref="ID2D1Geometry.ComputePointAtLength" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ComputePointAtLength(float length, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* point, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* unitTangentVector)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, float, D2D_MATRIX_3X2_F*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)(lpVtbl[15]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), length, worldTransform, flatteningTolerance, point, unitTangentVector);
    }

    /// <inheritdoc cref="ID2D1Geometry.Widen" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<ID2D1TransformedGeometry*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[16]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
    }

    /// <include file='ID2D1TransformedGeometry.xml' path='doc/member[@name="ID2D1TransformedGeometry.GetSourceGeometry"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void GetSourceGeometry(ID2D1Geometry** sourceGeometry)
    {
        ((delegate* unmanaged<ID2D1TransformedGeometry*, ID2D1Geometry**, void>)(lpVtbl[17]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), sourceGeometry);
    }

    /// <include file='ID2D1TransformedGeometry.xml' path='doc/member[@name="ID2D1TransformedGeometry.GetTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1TransformedGeometry*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[18]))((ID2D1TransformedGeometry*)Unsafe.AsPointer(ref this), transform);
    }

    public interface Interface : ID2D1Geometry.Interface
    {
        [VtblIndex(17)]
        void GetSourceGeometry(ID2D1Geometry** sourceGeometry);

        [VtblIndex(18)]
        void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int> GetBounds;

        [NativeTypeName("HRESULT (FLOAT, ID2D1StrokeStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, D2D_RECT_F*, int> GetWidenedBounds1;

        [NativeTypeName("HRESULT (D2D1_POINT_2F, FLOAT, ID2D1StrokeStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, BOOL *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, BOOL*, int> StrokeContainsPoint1;

        [NativeTypeName("HRESULT (D2D1_POINT_2F, const D2D1_MATRIX_3X2_F *, FLOAT, BOOL *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, D2D_MATRIX_3X2_F*, float, BOOL*, int> FillContainsPoint1;

        [NativeTypeName("HRESULT (ID2D1Geometry *, const D2D1_MATRIX_3X2_F *, FLOAT, D2D1_GEOMETRY_RELATION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, float, D2D1_GEOMETRY_RELATION*, int> CompareWithGeometry1;

        [NativeTypeName("HRESULT (D2D1_GEOMETRY_SIMPLIFICATION_OPTION, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_GEOMETRY_SIMPLIFICATION_OPTION, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> Simplify1;

        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1TessellationSink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, float, ID2D1TessellationSink*, int> Tessellate1;

        [NativeTypeName("HRESULT (ID2D1Geometry *, D2D1_COMBINE_MODE, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Geometry*, D2D1_COMBINE_MODE, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> CombineWithGeometry1;

        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> Outline1;

        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, float, float*, int> ComputeArea1;

        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *, FLOAT, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, float, float*, int> ComputeLength1;

        [NativeTypeName("HRESULT (FLOAT, const D2D1_MATRIX_3X2_F *, FLOAT, D2D1_POINT_2F *, D2D1_POINT_2F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, D2D_MATRIX_3X2_F*, float, D2D_POINT_2F*, D2D_POINT_2F*, int> ComputePointAtLength1;

        [NativeTypeName("HRESULT (FLOAT, ID2D1StrokeStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ID2D1StrokeStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> Widen1;

        [NativeTypeName("void (ID2D1Geometry **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Geometry**, void> GetSourceGeometry;

        [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> GetTransform;
    }
}
