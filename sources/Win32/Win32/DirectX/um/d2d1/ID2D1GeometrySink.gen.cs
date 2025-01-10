// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("2CD9069F-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1GeometrySink : ID2D1SimplifiedGeometrySink")]
[NativeInheritance("ID2D1SimplifiedGeometrySink")]
public unsafe partial struct ID2D1GeometrySink : ID2D1GeometrySink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GeometrySink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1GeometrySink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1GeometrySink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GeometrySink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetFillMode(D2D1_FILL_MODE fillMode)
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D1_FILL_MODE, void>)((*lpVtbl)[3]))(
            this,
            fillMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags)
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D1_PATH_SEGMENT, void>)((*lpVtbl)[4]))(
            this,
            vertexFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void BeginFigure(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint,
        D2D1_FIGURE_BEGIN figureBegin
    )
    {
        (
            (delegate* unmanaged<ID2D1GeometrySink, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void>)(
                (*lpVtbl)[5]
            )
        )(this, startPoint, figureBegin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void AddLines(
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points,
        [NativeTypeName("UINT32")] uint pointsCount
    )
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D_POINT_2F*, uint, void>)((*lpVtbl)[6]))(
            this,
            points,
            pointsCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void AddBeziers(
        [NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers,
        [NativeTypeName("UINT32")] uint beziersCount
    )
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D1_BEZIER_SEGMENT*, uint, void>)((*lpVtbl)[7]))(
            this,
            beziers,
            beziersCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void EndFigure(D2D1_FIGURE_END figureEnd)
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D1_FIGURE_END, void>)((*lpVtbl)[8]))(
            this,
            figureEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID2D1GeometrySink, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void AddLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point)
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D_POINT_2F, void>)((*lpVtbl)[10]))(this, point);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void AddBezier(
        [NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* bezier
    )
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D1_BEZIER_SEGMENT*, void>)((*lpVtbl)[11]))(
            this,
            bezier
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void AddQuadraticBezier(
        [NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")]
            D2D1_QUADRATIC_BEZIER_SEGMENT* bezier
    )
    {
        (
            (delegate* unmanaged<ID2D1GeometrySink, D2D1_QUADRATIC_BEZIER_SEGMENT*, void>)(
                (*lpVtbl)[12]
            )
        )(this, bezier);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void AddQuadraticBeziers(
        [NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")]
            D2D1_QUADRATIC_BEZIER_SEGMENT* beziers,
        [NativeTypeName("UINT32")] uint beziersCount
    )
    {
        (
            (delegate* unmanaged<ID2D1GeometrySink, D2D1_QUADRATIC_BEZIER_SEGMENT*, uint, void>)(
                (*lpVtbl)[13]
            )
        )(this, beziers, beziersCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void AddArc([NativeTypeName("const D2D1_ARC_SEGMENT *")] D2D1_ARC_SEGMENT* arc)
    {
        ((delegate* unmanaged<ID2D1GeometrySink, D2D1_ARC_SEGMENT*, void>)((*lpVtbl)[14]))(
            this,
            arc
        );
    }

    public interface Interface : ID2D1SimplifiedGeometrySink.Interface
    {
        [VtblIndex(10)]
        void AddLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point);

        [VtblIndex(11)]
        void AddBezier([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* bezier);

        [VtblIndex(12)]
        void AddQuadraticBezier(
            [NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")]
                D2D1_QUADRATIC_BEZIER_SEGMENT* bezier
        );

        [VtblIndex(13)]
        void AddQuadraticBeziers(
            [NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")]
                D2D1_QUADRATIC_BEZIER_SEGMENT* beziers,
            [NativeTypeName("UINT32")] uint beziersCount
        );

        [VtblIndex(14)]
        void AddArc([NativeTypeName("const D2D1_ARC_SEGMENT *")] D2D1_ARC_SEGMENT* arc);
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

        [NativeTypeName("void (D2D1_FILL_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_FILL_MODE, void> SetFillMode;

        [NativeTypeName(
            "void (D2D1_PATH_SEGMENT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PATH_SEGMENT, void> SetSegmentFlags;

        [NativeTypeName(
            "void (D2D1_POINT_2F, D2D1_FIGURE_BEGIN) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void> BeginFigure;

        [NativeTypeName(
            "void (const D2D1_POINT_2F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, uint, void> AddLines;

        [NativeTypeName(
            "void (const D2D1_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_BEZIER_SEGMENT*, uint, void> AddBeziers;

        [NativeTypeName("void (D2D1_FIGURE_END) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_FIGURE_END, void> EndFigure;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;

        [NativeTypeName("void (D2D1_POINT_2F) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, void> AddLine;

        [NativeTypeName(
            "void (const D2D1_BEZIER_SEGMENT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_BEZIER_SEGMENT*, void> AddBezier;

        [NativeTypeName(
            "void (const D2D1_QUADRATIC_BEZIER_SEGMENT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_QUADRATIC_BEZIER_SEGMENT*, void> AddQuadraticBezier;

        [NativeTypeName(
            "void (const D2D1_QUADRATIC_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_QUADRATIC_BEZIER_SEGMENT*,
            uint,
            void> AddQuadraticBeziers;

        [NativeTypeName(
            "void (const D2D1_ARC_SEGMENT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_ARC_SEGMENT*, void> AddArc;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1GeometrySink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1GeometrySink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1SimplifiedGeometrySink"/> to <see cref = "ID2D1GeometrySink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1SimplifiedGeometrySink"/> instance to be converted </param>
    public static explicit operator ID2D1GeometrySink(
        Silk.NET.DirectX.ID2D1SimplifiedGeometrySink value
    )
    {
        return new ID2D1GeometrySink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GeometrySink"/> to <see cref = "Silk.NET.DirectX.ID2D1SimplifiedGeometrySink"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GeometrySink"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1SimplifiedGeometrySink(
        ID2D1GeometrySink value
    )
    {
        return new Silk.NET.DirectX.ID2D1SimplifiedGeometrySink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1GeometrySink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1GeometrySink(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1GeometrySink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GeometrySink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GeometrySink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1GeometrySink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
