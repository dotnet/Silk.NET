// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("B499923B-7029-478F-A8B3-432C7C5F5312")]
[NativeTypeName("struct ID2D1Ink : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1Ink : ID2D1Ink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Ink));
    public void*** lpVtbl;

    public HRESULT StreamAsGeometry(
        ID2D1InkStyle inkStyle,
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform,
        ID2D1SimplifiedGeometrySink geometrySink
    )
    {
        return StreamAsGeometry(inkStyle, worldTransform, (0.25f), geometrySink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Ink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1Ink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Ink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1Ink, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetStartPoint([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint)
    {
        ((delegate* unmanaged<ID2D1Ink, D2D1_INK_POINT*, void>)((*lpVtbl)[4]))(this, startPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public D2D1_INK_POINT GetStartPoint()
    {
        D2D1_INK_POINT result;
        return *((delegate* unmanaged<ID2D1Ink, D2D1_INK_POINT*, D2D1_INK_POINT*>)((*lpVtbl)[5]))(
            this,
            &result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddSegments(
        [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments,
        [NativeTypeName("UINT32")] uint segmentsCount
    )
    {
        return ((delegate* unmanaged<ID2D1Ink, D2D1_INK_BEZIER_SEGMENT*, uint, int>)((*lpVtbl)[6]))(
            this,
            segments,
            segmentsCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveSegmentsAtEnd([NativeTypeName("UINT32")] uint segmentsCount)
    {
        return ((delegate* unmanaged<ID2D1Ink, uint, int>)((*lpVtbl)[7]))(this, segmentsCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSegments(
        [NativeTypeName("UINT32")] uint startSegment,
        [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments,
        [NativeTypeName("UINT32")] uint segmentsCount
    )
    {
        return (
            (delegate* unmanaged<ID2D1Ink, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int>)((*lpVtbl)[8])
        )(this, startSegment, segments, segmentsCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetSegmentAtEnd(
        [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment
    )
    {
        return ((delegate* unmanaged<ID2D1Ink, D2D1_INK_BEZIER_SEGMENT*, int>)((*lpVtbl)[9]))(
            this,
            segment
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT32")]
    public uint GetSegmentCount()
    {
        return ((delegate* unmanaged<ID2D1Ink, uint>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSegments(
        [NativeTypeName("UINT32")] uint startSegment,
        D2D1_INK_BEZIER_SEGMENT* segments,
        [NativeTypeName("UINT32")] uint segmentsCount
    )
    {
        return (
            (delegate* unmanaged<ID2D1Ink, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, startSegment, segments, segmentsCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StreamAsGeometry(
        ID2D1InkStyle inkStyle,
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform,
        float flatteningTolerance,
        ID2D1SimplifiedGeometrySink geometrySink
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Ink,
                ID2D1InkStyle,
                D2D_MATRIX_3X2_F*,
                float,
                ID2D1SimplifiedGeometrySink,
                int>)((*lpVtbl)[12])
        )(this, inkStyle, worldTransform, flatteningTolerance, geometrySink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBounds(
        ID2D1InkStyle inkStyle,
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform,
        [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds
    )
    {
        return (
            (delegate* unmanaged<ID2D1Ink, ID2D1InkStyle, D2D_MATRIX_3X2_F*, D2D_RECT_F*, int>)(
                (*lpVtbl)[13]
            )
        )(this, inkStyle, worldTransform, bounds);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        void SetStartPoint([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint);

        [VtblIndex(5)]
        D2D1_INK_POINT GetStartPoint();

        [VtblIndex(6)]
        HRESULT AddSegments(
            [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments,
            [NativeTypeName("UINT32")] uint segmentsCount
        );

        [VtblIndex(7)]
        HRESULT RemoveSegmentsAtEnd([NativeTypeName("UINT32")] uint segmentsCount);

        [VtblIndex(8)]
        HRESULT SetSegments(
            [NativeTypeName("UINT32")] uint startSegment,
            [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segments,
            [NativeTypeName("UINT32")] uint segmentsCount
        );

        [VtblIndex(9)]
        HRESULT SetSegmentAtEnd(
            [NativeTypeName("const D2D1_INK_BEZIER_SEGMENT *")] D2D1_INK_BEZIER_SEGMENT* segment
        );

        [VtblIndex(10)]
        [return: NativeTypeName("UINT32")]
        uint GetSegmentCount();

        [VtblIndex(11)]
        HRESULT GetSegments(
            [NativeTypeName("UINT32")] uint startSegment,
            D2D1_INK_BEZIER_SEGMENT* segments,
            [NativeTypeName("UINT32")] uint segmentsCount
        );

        [VtblIndex(12)]
        HRESULT StreamAsGeometry(
            ID2D1InkStyle inkStyle,
            [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform,
            float flatteningTolerance,
            ID2D1SimplifiedGeometrySink geometrySink
        );

        [VtblIndex(13)]
        HRESULT GetBounds(
            ID2D1InkStyle inkStyle,
            [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform,
            [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds
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

        [NativeTypeName(
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName(
            "void (const D2D1_INK_POINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_INK_POINT*, void> SetStartPoint;

        [NativeTypeName(
            "D2D1_INK_POINT () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_INK_POINT*, D2D1_INK_POINT*> GetStartPoint;

        [NativeTypeName(
            "HRESULT (const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_INK_BEZIER_SEGMENT*, uint, int> AddSegments;

        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveSegmentsAtEnd;

        [NativeTypeName(
            "HRESULT (UINT32, const D2D1_INK_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> SetSegments;

        [NativeTypeName(
            "HRESULT (const D2D1_INK_BEZIER_SEGMENT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_INK_BEZIER_SEGMENT*, int> SetSegmentAtEnd;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetSegmentCount;

        [NativeTypeName(
            "HRESULT (UINT32, D2D1_INK_BEZIER_SEGMENT *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D2D1_INK_BEZIER_SEGMENT*, uint, int> GetSegments;

        [NativeTypeName(
            "HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, FLOAT, ID2D1SimplifiedGeometrySink *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1InkStyle,
            D2D_MATRIX_3X2_F*,
            float,
            ID2D1SimplifiedGeometrySink,
            int> StreamAsGeometry1;

        [NativeTypeName(
            "HRESULT (ID2D1InkStyle *, const D2D1_MATRIX_3X2_F *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1InkStyle,
            D2D_MATRIX_3X2_F*,
            D2D_RECT_F*,
            int> GetBounds;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1Ink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1Ink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1Ink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1Ink(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1Ink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Ink"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Ink"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1Ink value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1Ink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1Ink(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1Ink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Ink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Ink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1Ink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
