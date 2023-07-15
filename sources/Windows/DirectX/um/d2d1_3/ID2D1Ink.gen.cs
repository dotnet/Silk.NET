// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink"]/*'/>
[Guid("B499923B-7029-478F-A8B3-432C7C5F5312")]
[NativeTypeName("struct ID2D1Ink : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1Ink : ID2D1Ink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Ink));

    public void** lpVtbl;
    public HRESULT StreamAsGeometry(ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return StreamAsGeometry(inkStyle, worldTransform, (0.25f), geometrySink);
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Ink*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1Ink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1Ink*, uint> )(lpVtbl[1]))((ID2D1Ink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Ink*, uint> )(lpVtbl[2]))((ID2D1Ink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1Ink*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1Ink*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.SetStartPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetStartPoint([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint)
    {
        ((delegate* unmanaged<ID2D1Ink*, D2D1_INK_POINT*, void> )(lpVtbl[4]))((ID2D1Ink*)Unsafe.AsPointer(ref this), startPoint);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.GetStartPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public D2D1_INK_POINT GetStartPoint()
    {
        D2D1_INK_POINT result;
        return *((delegate* unmanaged<ID2D1Ink*, D2D1_INK_POINT*, D2D1_INK_POINT*> )(lpVtbl[5]))((ID2D1Ink*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.AddSegments"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddSegments([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
    {
        return ((delegate* unmanaged<ID2D1Ink*, D2D1_INK_BEZIER_SEGMENT*, uint, int> )(lpVtbl[6]))((ID2D1Ink*)Unsafe.AsPointer(ref this), segments, segmentsCount);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.RemoveSegmentsAtEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveSegmentsAtEnd([NativeTypeName("UINT32")] uint segmentsCount)
    {
        return ((delegate* unmanaged<ID2D1Ink*, uint, int> )(lpVtbl[7]))((ID2D1Ink*)Unsafe.AsPointer(ref this), segmentsCount);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.SetSegments"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
    {
        return ((delegate* unmanaged<ID2D1Ink*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> )(lpVtbl[8]))((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.SetSegmentAtEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetSegmentAtEnd([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment)
    {
        return ((delegate* unmanaged<ID2D1Ink*, D2D1_INK_BEZIER_SEGMENT*, int> )(lpVtbl[9]))((ID2D1Ink*)Unsafe.AsPointer(ref this), segment);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.GetSegmentCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT32")]
    public uint GetSegmentCount()
    {
        return ((delegate* unmanaged<ID2D1Ink*, uint> )(lpVtbl[10]))((ID2D1Ink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.GetSegments"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSegments([NativeTypeName("UINT32")] uint startSegment, D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount)
    {
        return ((delegate* unmanaged<ID2D1Ink*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> )(lpVtbl[11]))((ID2D1Ink*)Unsafe.AsPointer(ref this), startSegment, segments, segmentsCount);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.StreamAsGeometry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StreamAsGeometry(ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<ID2D1Ink*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> )(lpVtbl[12]))((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, flatteningTolerance, geometrySink);
    }

    /// <include file='ID2D1Ink.xml' path='doc/member[@name="ID2D1Ink.GetBounds"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBounds(ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return ((delegate* unmanaged<ID2D1Ink*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int> )(lpVtbl[13]))((ID2D1Ink*)Unsafe.AsPointer(ref this), inkStyle, worldTransform, bounds);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        void SetStartPoint([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint);
        [VtblIndex(5)]
        D2D1_INK_POINT GetStartPoint();
        [VtblIndex(6)]
        HRESULT AddSegments([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount);
        [VtblIndex(7)]
        HRESULT RemoveSegmentsAtEnd([NativeTypeName("UINT32")] uint segmentsCount);
        [VtblIndex(8)]
        HRESULT SetSegments([NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount);
        [VtblIndex(9)]
        HRESULT SetSegmentAtEnd([NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment);
        [VtblIndex(10)]
        [return: NativeTypeName("UINT32")]
        uint GetSegmentCount();
        [VtblIndex(11)]
        HRESULT GetSegments([NativeTypeName("UINT32")] uint startSegment, D2D1_INK_BEZIER_SEGMENT* segments, [NativeTypeName("UINT32")] uint segmentsCount);
        [VtblIndex(12)]
        HRESULT StreamAsGeometry(ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);
        [VtblIndex(13)]
        HRESULT GetBounds(ID2D1InkStyle* inkStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);
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
        [NativeTypeName("void (const D2D1_INK_POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_INK_POINT*, void> SetStartPoint;
        [NativeTypeName("D2D1_INK_POINT () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_INK_POINT*, D2D1_INK_POINT*> GetStartPoint;
        [NativeTypeName("HRESULT (const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_INK_BEZIER_SEGMENT*, uint, int> AddSegments;
        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveSegmentsAtEnd;
        [NativeTypeName("HRESULT (UINT32, const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> SetSegments;
        [NativeTypeName("HRESULT (const D2D1_INK_BEZIER_SEGMENT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_INK_BEZIER_SEGMENT*, int> SetSegmentAtEnd;
        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetSegmentCount;
        [NativeTypeName("HRESULT (UINT32, D2D1_INK_BEZIER_SEGMENT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> GetSegments;
        [NativeTypeName("HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, float, ID2D1SimplifiedGeometrySink*, int> StreamAsGeometry1;
        [NativeTypeName("HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1InkStyle*, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int> GetBounds;
    }
}