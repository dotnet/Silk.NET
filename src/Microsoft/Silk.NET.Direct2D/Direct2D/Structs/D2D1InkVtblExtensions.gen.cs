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

public unsafe static class D2D1InkVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Ink> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Ink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Ink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Ink> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetStartPoint(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkPoint* startPoint)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, void>)@this->LpVtbl[4])(@this, startPoint);
    }

    /// <summary>To be documented.</summary>
    public static InkPoint GetStartPoint(this ComPtr<ID2D1Ink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        InkPoint silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        InkPoint* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, InkPoint*>)@this->LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSegments(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkBezierSegment* segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, uint, int>)@this->LpVtbl[6])(@this, segments, segmentsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveSegmentsAtEnd(this ComPtr<ID2D1Ink> thisVtbl, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, int>)@this->LpVtbl[7])(@this, segmentsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSegments(this ComPtr<ID2D1Ink> thisVtbl, uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkBezierSegment* segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[8])(@this, startSegment, segments, segmentsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSegmentAtEnd(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkBezierSegment* segment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, int>)@this->LpVtbl[9])(@this, segment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetSegmentCount(this ComPtr<ID2D1Ink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSegments(this ComPtr<ID2D1Ink> thisVtbl, uint startSegment, InkBezierSegment* segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[11])(@this, startSegment, segments, segmentsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransform, bounds);
        return ret;
    }

}
