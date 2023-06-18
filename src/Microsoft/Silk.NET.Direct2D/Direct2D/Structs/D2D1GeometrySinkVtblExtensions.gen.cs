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

public unsafe static class D2D1GeometrySinkVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GeometrySink> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1GeometrySink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1GeometrySink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetFillMode(this ComPtr<ID2D1GeometrySink> thisVtbl, FillMode fillMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, FillMode, void>)@this->LpVtbl[3])(@this, fillMode);
    }

    /// <summary>To be documented.</summary>
    public static void SetSegmentFlags(this ComPtr<ID2D1GeometrySink> thisVtbl, PathSegment vertexFlags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, PathSegment, void>)@this->LpVtbl[4])(@this, vertexFlags);
    }

    /// <summary>To be documented.</summary>
    public static void BeginFigure(this ComPtr<ID2D1GeometrySink> thisVtbl, Silk.NET.Maths.Vector2D<float> startPoint, FigureBegin figureBegin)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Silk.NET.Maths.Vector2D<float>, FigureBegin, void>)@this->LpVtbl[5])(@this, startPoint, figureBegin);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddLines(this ComPtr<ID2D1GeometrySink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Silk.NET.Maths.Vector2D<float>*, uint, void>)@this->LpVtbl[6])(@this, points, pointsCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBeziers(this ComPtr<ID2D1GeometrySink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BezierSegment* beziers, uint beziersCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, BezierSegment*, uint, void>)@this->LpVtbl[7])(@this, beziers, beziersCount);
    }

    /// <summary>To be documented.</summary>
    public static void EndFigure(this ComPtr<ID2D1GeometrySink> thisVtbl, FigureEnd figureEnd)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, FigureEnd, void>)@this->LpVtbl[8])(@this, figureEnd);
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID2D1GeometrySink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void AddLine(this ComPtr<ID2D1GeometrySink> thisVtbl, Silk.NET.Maths.Vector2D<float> point)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Silk.NET.Maths.Vector2D<float>, void>)@this->LpVtbl[10])(@this, point);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddBezier(this ComPtr<ID2D1GeometrySink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BezierSegment* bezier)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, BezierSegment*, void>)@this->LpVtbl[11])(@this, bezier);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddQuadraticBezier(this ComPtr<ID2D1GeometrySink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QuadraticBezierSegment* bezier)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, QuadraticBezierSegment*, void>)@this->LpVtbl[12])(@this, bezier);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddQuadraticBeziers(this ComPtr<ID2D1GeometrySink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QuadraticBezierSegment* beziers, uint beziersCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, QuadraticBezierSegment*, uint, void>)@this->LpVtbl[13])(@this, beziers, beziersCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AddArc(this ComPtr<ID2D1GeometrySink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArcSegment* arc)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, ArcSegment*, void>)@this->LpVtbl[14])(@this, arc);
    }

}
