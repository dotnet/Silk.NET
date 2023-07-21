// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink"]/*' />
[Guid("2CD9069E-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1SimplifiedGeometrySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1SimplifiedGeometrySink : ID2D1SimplifiedGeometrySink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SimplifiedGeometrySink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, uint>)(lpVtbl[1]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, uint>)(lpVtbl[2]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink.SetFillMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetFillMode(D2D1_FILL_MODE fillMode)
    {
        ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_FILL_MODE, void>)(lpVtbl[3]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), fillMode);
    }

    /// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink.SetSegmentFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags)
    {
        ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_PATH_SEGMENT, void>)(lpVtbl[4]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), vertexFlags);
    }

    /// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink.BeginFigure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
    {
        ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void>)(lpVtbl[5]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), startPoint, figureBegin);
    }

    /// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink.AddLines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void AddLines([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount)
    {
        ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F*, uint, void>)(lpVtbl[6]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), points, pointsCount);
    }

    /// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink.AddBeziers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void AddBeziers([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount)
    {
        ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_BEZIER_SEGMENT*, uint, void>)(lpVtbl[7]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), beziers, beziersCount);
    }

    /// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink.EndFigure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void EndFigure(D2D1_FIGURE_END figureEnd)
    {
        ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_FIGURE_END, void>)(lpVtbl[8]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), figureEnd);
    }

    /// <include file='ID2D1SimplifiedGeometrySink.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[9]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetFillMode(D2D1_FILL_MODE fillMode);

        [VtblIndex(4)]
        void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags);

        [VtblIndex(5)]
        void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);

        [VtblIndex(6)]
        void AddLines([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount);

        [VtblIndex(7)]
        void AddBeziers([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount);

        [VtblIndex(8)]
        void EndFigure(D2D1_FIGURE_END figureEnd);

        [VtblIndex(9)]
        HRESULT Close();
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

        [NativeTypeName("void (D2D1_PATH_SEGMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_PATH_SEGMENT, void> SetSegmentFlags;

        [NativeTypeName("void (D2D1_POINT_2F, D2D1_FIGURE_BEGIN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void> BeginFigure;

        [NativeTypeName("void (const D2D1_POINT_2F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, uint, void> AddLines;

        [NativeTypeName("void (const D2D1_BEZIER_SEGMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_BEZIER_SEGMENT*, uint, void> AddBeziers;

        [NativeTypeName("void (D2D1_FIGURE_END) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_FIGURE_END, void> EndFigure;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}
