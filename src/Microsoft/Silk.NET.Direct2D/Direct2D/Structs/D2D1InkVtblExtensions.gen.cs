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
    public static unsafe int QueryInterface(this ComPtr<ID2D1Ink> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Ink> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Ink> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe void GetFactory(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetStartPoint(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkPoint* startPoint)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, void>)@this->LpVtbl[4])(@this, startPoint);
    }

    /// <summary>To be documented.</summary>
    public static void SetStartPoint(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkPoint startPoint)
    {
        var @this = thisVtbl.Handle;
        fixed (InkPoint* startPointPtr = &startPoint)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkPoint*, void>)@this->LpVtbl[4])(@this, startPointPtr);
        }
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
    public static int AddSegments(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkBezierSegment segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkBezierSegment* segmentsPtr = &segments)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, uint, int>)@this->LpVtbl[6])(@this, segmentsPtr, segmentsCount);
        }
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
    public static int SetSegments(this ComPtr<ID2D1Ink> thisVtbl, uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkBezierSegment segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkBezierSegment* segmentsPtr = &segments)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[8])(@this, startSegment, segmentsPtr, segmentsCount);
        }
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
    public static int SetSegmentAtEnd(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkBezierSegment segment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkBezierSegment* segmentPtr = &segment)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, InkBezierSegment*, int>)@this->LpVtbl[9])(@this, segmentPtr);
        }
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
    public static int GetSegments(this ComPtr<ID2D1Ink> thisVtbl, uint startSegment, ref InkBezierSegment segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkBezierSegment* segmentsPtr = &segments)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, uint, InkBezierSegment*, uint, int>)@this->LpVtbl[11])(@this, startSegment, segmentsPtr, segmentsCount);
        }
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
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransform, flatteningTolerance, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransformPtr, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStyle, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransform, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransformPtr, flatteningTolerance, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, inkStylePtr, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransform, boundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransformPtr, bounds);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStyle, worldTransformPtr, boundsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransform, bounds);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransform, boundsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransformPtr, bounds);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Ink*, ID2D1InkStyle*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[13])(@this, inkStylePtr, worldTransformPtr, boundsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Ink> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Ink> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Ink> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetStartPoint(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkPoint> startPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetStartPoint(in startPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddSegments(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkBezierSegment> segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSegments(in segments.GetPinnableReference(), segmentsCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetSegments(this ComPtr<ID2D1Ink> thisVtbl, uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkBezierSegment> segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSegments(startSegment, in segments.GetPinnableReference(), segmentsCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetSegmentAtEnd(this ComPtr<ID2D1Ink> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkBezierSegment> segment)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSegmentAtEnd(in segment.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSegments(this ComPtr<ID2D1Ink> thisVtbl, uint startSegment, Span<InkBezierSegment> segments, uint segmentsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSegments(startSegment, ref segments.GetPinnableReference(), segmentsCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry<TI0, TI1>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StreamAsGeometry(inkStyle, worldTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, worldTransform, flatteningTolerance, ref geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StreamAsGeometry(inkStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int StreamAsGeometry<TI0, TI1>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StreamAsGeometry(inkStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int StreamAsGeometry<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StreamAsGeometry((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, flatteningTolerance, ref geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StreamAsGeometry(ref inkStyle.GetPinnableReference(), worldTransform, flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StreamAsGeometry(ref inkStyle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StreamAsGeometry(ref inkStyle.GetPinnableReference(), worldTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StreamAsGeometry(ref inkStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int StreamAsGeometry<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ref ID2D1InkStyle inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StreamAsGeometry(ref inkStyle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int StreamAsGeometry(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StreamAsGeometry(ref inkStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, worldTransform, bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(inkStyle, worldTransform, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, worldTransform, ref bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(inkStyle, in worldTransform.GetPinnableReference(), bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, ID2D1InkStyle* inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(inkStyle, in worldTransform.GetPinnableReference(), ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBounds<TI0>(this ComPtr<ID2D1Ink> thisVtbl, ComPtr<TI0> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBounds((ID2D1InkStyle*) inkStyle.Handle, in worldTransform, ref bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(ref inkStyle.GetPinnableReference(), worldTransform, bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(ref inkStyle.GetPinnableReference(), worldTransform, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(ref inkStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), bounds);
    }

    /// <summary>To be documented.</summary>
    public static int GetBounds(this ComPtr<ID2D1Ink> thisVtbl, Span<ID2D1InkStyle> inkStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(ref inkStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Ink> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
