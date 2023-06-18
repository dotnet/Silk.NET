// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct2D;

public unsafe static class D2D1PathGeometry1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PathGeometry1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1PathGeometry1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1PathGeometry1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1PathGeometry1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1PathGeometry1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransform, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1PathGeometry1> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1PathGeometry1> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillContainsPoint(this ComPtr<ID2D1PathGeometry1> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, contains);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1PathGeometry1> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Simplify(this ComPtr<ID2D1PathGeometry1> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Tessellate(this ComPtr<ID2D1PathGeometry1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1PathGeometry1> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Outline(this ComPtr<ID2D1PathGeometry1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeArea(this ComPtr<ID2D1PathGeometry1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* area)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransform, flatteningTolerance, area);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeLength(this ComPtr<ID2D1PathGeometry1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransform, flatteningTolerance, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1PathGeometry1> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVector);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1PathGeometry1> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID2D1PathGeometry1> thisVtbl, ID2D1GeometrySink** geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, ID2D1GeometrySink**, int>)@this->LpVtbl[17])(@this, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stream(this ComPtr<ID2D1PathGeometry1> thisVtbl, ID2D1GeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, ID2D1GeometrySink*, int>)@this->LpVtbl[18])(@this, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSegmentCount(this ComPtr<ID2D1PathGeometry1> thisVtbl, uint* count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, uint*, int>)@this->LpVtbl[19])(@this, count);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFigureCount(this ComPtr<ID2D1PathGeometry1> thisVtbl, uint* count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, uint*, int>)@this->LpVtbl[20])(@this, count);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAndSegmentAtLength(this ComPtr<ID2D1PathGeometry1> thisVtbl, float length, uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, PointDescription* pointDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PathGeometry1*, float, uint, Silk.NET.Maths.Matrix3X2<float>*, float, PointDescription*, int>)@this->LpVtbl[21])(@this, length, startSegment, worldTransform, flatteningTolerance, pointDescription);
        return ret;
    }

}
