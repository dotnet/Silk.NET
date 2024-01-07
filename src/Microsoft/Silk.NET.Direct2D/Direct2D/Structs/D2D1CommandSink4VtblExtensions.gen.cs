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

public unsafe static class D2D1CommandSink4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1CommandSink4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1CommandSink4> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1CommandSink4> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1CommandSink4> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1CommandSink4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1CommandSink4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginDraw(this ComPtr<ID2D1CommandSink4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<ID2D1CommandSink4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAntialiasMode(this ComPtr<ID2D1CommandSink4> thisVtbl, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, AntialiasMode, int>)@this->LpVtbl[5])(@this, antialiasMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTags(this ComPtr<ID2D1CommandSink4> thisVtbl, ulong tag1, ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ulong, ulong, int>)@this->LpVtbl[6])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextAntialiasMode(this ComPtr<ID2D1CommandSink4> thisVtbl, TextAntialiasMode textAntialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, TextAntialiasMode, int>)@this->LpVtbl[7])(@this, textAntialiasMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTextRenderingParams(this ComPtr<ID2D1CommandSink4> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, IDWriteRenderingParams*, int>)@this->LpVtbl[8])(@this, textRenderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[9])(@this, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[9])(@this, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrimitiveBlend(this ComPtr<ID2D1CommandSink4> thisVtbl, PrimitiveBlend primitiveBlend)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, PrimitiveBlend, int>)@this->LpVtbl[10])(@this, primitiveBlend);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetUnitMode(this ComPtr<ID2D1CommandSink4> thisVtbl, UnitMode unitMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, UnitMode, int>)@this->LpVtbl[11])(@this, unitMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clear(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[12])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Clear(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[12])(@this, colorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteGlyphRunDescription*, ID2D1Brush*, DwriteMeasuringMode, int>)@this->LpVtbl[13])(@this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteGlyphRunDescription*, ID2D1Brush*, DwriteMeasuringMode, int>)@this->LpVtbl[13])(@this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrushPtr, measuringMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawLine(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brush, strokeWidth, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawLine(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brush, strokeWidth, strokeStylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawLine(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brushPtr, strokeWidth, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawLine(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brush, strokeWidth, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brush, strokeWidth, strokeStylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brushPtr, strokeWidth, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brush, strokeWidth, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometryPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStyle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle, perspectiveTransformPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransform);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    fixed (Silk.NET.Maths.Matrix4X4<float>* perspectiveTransformPtr = &perspectiveTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr, perspectiveTransformPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
        {
            fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Image* imagePtr = &image)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, imagePtr, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGdiMetafile(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafile, targetOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGdiMetafile(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafile, targetOffsetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGdiMetafile(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1GdiMetafile gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafilePtr, targetOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawGdiMetafile(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1GdiMetafile gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafilePtr, targetOffsetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, mesh, brush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Mesh* mesh, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, mesh, brushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Mesh mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Mesh* meshPtr = &mesh)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, meshPtr, brush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FillMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Mesh mesh, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Mesh* meshPtr = &mesh)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, meshPtr, brushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectangle, sourceRectangle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectangle, sourceRectanglePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectanglePtr, sourceRectangle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectanglePtr, sourceRectanglePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectangle, sourceRectangle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectangle, sourceRectanglePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectanglePtr, sourceRectangle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brushPtr, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectangle, sourceRectangle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectangle, sourceRectanglePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectanglePtr, sourceRectangle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brush, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectangle, sourceRectangle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectangle, sourceRectanglePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectanglePtr, sourceRectangle);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMaskPtr, brushPtr, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brush, opacityBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brush, opacityBrushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brushPtr, opacityBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brushPtr, opacityBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brush, opacityBrush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brush, opacityBrushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, opacityBrush);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* geometryPtr = &geometry)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometryPtr, brushPtr, opacityBrushPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rect, brush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rect, brushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rectPtr, brush);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FillRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rectPtr, brushPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushAxisAlignedClip(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, int>)@this->LpVtbl[24])(@this, clipRect, antialiasMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushAxisAlignedClip(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* clipRectPtr = &clipRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, int>)@this->LpVtbl[24])(@this, clipRectPtr, antialiasMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushLayer(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1, layer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushLayer(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ref ID2D1Layer layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Layer* layerPtr = &layer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1, layerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushLayer(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LayerParameters1 layerParameters1, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LayerParameters1* layerParameters1Ptr = &layerParameters1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1Ptr, layer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PushLayer(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LayerParameters1 layerParameters1, ref ID2D1Layer layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LayerParameters1* layerParameters1Ptr = &layerParameters1)
        {
            fixed (ID2D1Layer* layerPtr = &layer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1Ptr, layerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PopAxisAlignedClip(this ComPtr<ID2D1CommandSink4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PopLayer(this ComPtr<ID2D1CommandSink4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, int>)@this->LpVtbl[27])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrimitiveBlend1(this ComPtr<ID2D1CommandSink4> thisVtbl, PrimitiveBlend primitiveBlend)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, PrimitiveBlend, int>)@this->LpVtbl[28])(@this, primitiveBlend);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Ink* ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, ink, brush, inkStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Ink* ink, ID2D1Brush* brush, ref ID2D1InkStyle inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, ink, brush, inkStylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Ink* ink, ref ID2D1Brush brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, ink, brushPtr, inkStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Ink* ink, ref ID2D1Brush brush, ref ID2D1InkStyle inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, ink, brushPtr, inkStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Ink ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Ink* inkPtr = &ink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, inkPtr, brush, inkStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Ink ink, ID2D1Brush* brush, ref ID2D1InkStyle inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Ink* inkPtr = &ink)
        {
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, inkPtr, brush, inkStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Ink ink, ref ID2D1Brush brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Ink* inkPtr = &ink)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, inkPtr, brushPtr, inkStyle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Ink ink, ref ID2D1Brush brush, ref ID2D1InkStyle inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Ink* inkPtr = &ink)
        {
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, inkPtr, brushPtr, inkStylePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGradientMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1GradientMesh* gradientMesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GradientMesh*, int>)@this->LpVtbl[30])(@this, gradientMesh);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawGradientMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1GradientMesh gradientMesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GradientMesh* gradientMeshPtr = &gradientMesh)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1GradientMesh*, int>)@this->LpVtbl[30])(@this, gradientMeshPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawSpriteBatch(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, int>)@this->LpVtbl[32])(@this, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawSpriteBatch(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, ref ID2D1Bitmap bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, int>)@this->LpVtbl[32])(@this, spriteBatch, startIndex, spriteCount, bitmapPtr, interpolationMode, spriteOptions);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawSpriteBatch(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SpriteBatch* spriteBatchPtr = &spriteBatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, int>)@this->LpVtbl[32])(@this, spriteBatchPtr, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawSpriteBatch(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, ref ID2D1Bitmap bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SpriteBatch* spriteBatchPtr = &spriteBatch)
        {
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, int>)@this->LpVtbl[32])(@this, spriteBatchPtr, startIndex, spriteCount, bitmapPtr, interpolationMode, spriteOptions);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrimitiveBlend2(this ComPtr<ID2D1CommandSink4> thisVtbl, PrimitiveBlend primitiveBlend)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink4*, PrimitiveBlend, int>)@this->LpVtbl[33])(@this, primitiveBlend);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTransform(in transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Clear(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Clear(in color.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ComPtr<TI0> foregroundBrush, DwriteMeasuringMode measuringMode) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(baselineOrigin, glyphRun, glyphRunDescription, (ID2D1Brush*) foregroundBrush.Handle, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, Span<ID2D1Brush> foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOrigin, glyphRun, glyphRunDescription, ref foregroundBrush.GetPinnableReference(), measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static int DrawLine<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawLine(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawLine(point0, point1, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawLine<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawLine(point0, point1, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawLine(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawLine(point0, point1, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawLine<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawLine(point0, point1, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawLine(this ComPtr<ID2D1CommandSink4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawLine(point0, point1, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry<TI0, TI1, TI2>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ComPtr<TI2> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGeometry(geometry, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGeometry(geometry, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGeometry(geometry, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGeometry((ID2D1Geometry*) geometry.Handle, ref brush, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGeometry(ref geometry.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGeometry(ref geometry.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGeometry(ref geometry, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGeometry(ref geometry, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectangle(rect, brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawRectangle(rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectangle(rect, ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawRectangle(rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectangle(rect, ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectangle(in rect.GetPinnableReference(), brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectangle<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ComPtr<TI1> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawRectangle(in rect, (ID2D1Brush*) brush.Handle, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectangle(in rect.GetPinnableReference(), brush, strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectangle<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawRectangle(in rect, (ID2D1Brush*) brush.Handle, strokeWidth, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectangle(in rect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectangle<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawRectangle(in rect, ref brush, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectangle(in rect.GetPinnableReference(), ref brush.GetPinnableReference(), strokeWidth, ref strokeStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, sourceRectangle, in perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(bitmap, destinationRectangle, opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, in sourceRectangle, perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(bitmap, destinationRectangle, opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, destinationRectangle, opacity, interpolationMode, in sourceRectangle, in perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(bitmap, in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle, perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(bitmap, in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle, in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, sourceRectangle, in perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(bitmap, in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, in sourceRectangle, perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(bitmap, in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawBitmap<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix4X4<float> perspectiveTransform) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawBitmap((ID2D1Bitmap*) bitmap.Handle, in destinationRectangle, opacity, interpolationMode, in sourceRectangle, in perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, sourceRectangle, in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), destinationRectangle, opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle, perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, sourceRectangle, in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), perspectiveTransform);
    }

    /// <summary>To be documented.</summary>
    public static int DrawBitmap(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix4X4<float>> perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawBitmap(ref bitmap.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), opacity, interpolationMode, in sourceRectangle.GetPinnableReference(), in perspectiveTransform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawImage((ID2D1Image*) image.Handle, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawImage(image, targetOffset, in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawImage((ID2D1Image*) image.Handle, targetOffset, in imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawImage(image, in targetOffset.GetPinnableReference(), imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawImage((ID2D1Image*) image.Handle, in targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawImage(image, in targetOffset.GetPinnableReference(), in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static int DrawImage<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawImage((ID2D1Image*) image.Handle, in targetOffset, in imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawImage(ref image.GetPinnableReference(), targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawImage(ref image.GetPinnableReference(), targetOffset, in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawImage(ref image.GetPinnableReference(), in targetOffset.GetPinnableReference(), imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static int DrawImage(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawImage(ref image.GetPinnableReference(), in targetOffset.GetPinnableReference(), in imageRectangle.GetPinnableReference(), interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGdiMetafile<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGdiMetafile((ID2D1GdiMetafile*) gdiMetafile.Handle, targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGdiMetafile(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGdiMetafile(gdiMetafile, in targetOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawGdiMetafile<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> targetOffset) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGdiMetafile((ID2D1GdiMetafile*) gdiMetafile.Handle, in targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGdiMetafile(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1GdiMetafile> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGdiMetafile(ref gdiMetafile.GetPinnableReference(), targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGdiMetafile(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1GdiMetafile> gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> targetOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGdiMetafile(ref gdiMetafile.GetPinnableReference(), in targetOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillMesh<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> mesh, ComPtr<TI1> brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillMesh((ID2D1Mesh*) mesh.Handle, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Mesh* mesh, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillMesh(mesh, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillMesh<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> mesh, ref ID2D1Brush brush) where TI0 : unmanaged, IComVtbl<ID2D1Mesh>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillMesh((ID2D1Mesh*) mesh.Handle, ref brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Mesh> mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillMesh(ref mesh.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static int FillMesh<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Mesh mesh, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillMesh(ref mesh, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int FillMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Mesh> mesh, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillMesh(ref mesh.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(opacityMask, brush, destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(opacityMask, brush, in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, in destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(opacityMask, brush, in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillOpacityMask<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ComPtr<TI1> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, (ID2D1Brush*) brush.Handle, in destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, in destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Bitmap* opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(opacityMask, ref brush.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> opacityMask, ref ID2D1Brush brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask((ID2D1Bitmap*) opacityMask.Handle, ref brush, in destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, in destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), brush, in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillOpacityMask<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Bitmap opacityMask, ComPtr<TI0> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillOpacityMask(ref opacityMask, (ID2D1Brush*) brush.Handle, in destinationRectangle, in sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), destinationRectangle, in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static int FillOpacityMask(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Bitmap> opacityMask, Span<ID2D1Brush> brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillOpacityMask(ref opacityMask.GetPinnableReference(), ref brush.GetPinnableReference(), in destinationRectangle.GetPinnableReference(), in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry<TI0, TI1, TI2>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, ComPtr<TI2> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillGeometry(geometry, brush, ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ComPtr<TI1> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, (ID2D1Brush*) brush.Handle, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillGeometry(geometry, ref brush.GetPinnableReference(), opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Geometry* geometry, Span<ID2D1Brush> brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillGeometry(geometry, ref brush.GetPinnableReference(), ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillGeometry((ID2D1Geometry*) geometry.Handle, ref brush, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillGeometry(ref geometry.GetPinnableReference(), brush, opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, ComPtr<TI1> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, ID2D1Brush* brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillGeometry(ref geometry.GetPinnableReference(), brush, ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ComPtr<TI0> brush, ref ID2D1Brush opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillGeometry(ref geometry, (ID2D1Brush*) brush.Handle, ref opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Geometry geometry, ref ID2D1Brush brush, ComPtr<TI0> opacityBrush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillGeometry(ref geometry, ref brush, (ID2D1Brush*) opacityBrush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int FillGeometry(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Geometry> geometry, Span<ID2D1Brush> brush, Span<ID2D1Brush> opacityBrush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillGeometry(ref geometry.GetPinnableReference(), ref brush.GetPinnableReference(), ref opacityBrush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillRectangle<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillRectangle(rect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillRectangle(rect, ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillRectangle(in rect.GetPinnableReference(), brush);
    }

    /// <summary>To be documented.</summary>
    public static int FillRectangle<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rect, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FillRectangle(in rect, (ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int FillRectangle(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rect, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillRectangle(in rect.GetPinnableReference(), ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PushAxisAlignedClip(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushAxisAlignedClip(in clipRect.GetPinnableReference(), antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushLayer<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PushLayer(layerParameters1, (ID2D1Layer*) layer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushLayer(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, Span<ID2D1Layer> layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushLayer(layerParameters1, ref layer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushLayer(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LayerParameters1> layerParameters1, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushLayer(in layerParameters1.GetPinnableReference(), layer);
    }

    /// <summary>To be documented.</summary>
    public static int PushLayer<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LayerParameters1 layerParameters1, ComPtr<TI0> layer) where TI0 : unmanaged, IComVtbl<ID2D1Layer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PushLayer(in layerParameters1, (ID2D1Layer*) layer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int PushLayer(this ComPtr<ID2D1CommandSink4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LayerParameters1> layerParameters1, Span<ID2D1Layer> layer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PushLayer(in layerParameters1.GetPinnableReference(), ref layer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk<TI0, TI1, TI2>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> ink, ComPtr<TI1> brush, ComPtr<TI2> inkStyle) where TI0 : unmanaged, IComVtbl<ID2D1Ink>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInk((ID2D1Ink*) ink.Handle, (ID2D1Brush*) brush.Handle, (ID2D1InkStyle*) inkStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Ink* ink, ID2D1Brush* brush, Span<ID2D1InkStyle> inkStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInk(ink, brush, ref inkStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> ink, ComPtr<TI1> brush, ref ID2D1InkStyle inkStyle) where TI0 : unmanaged, IComVtbl<ID2D1Ink>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInk((ID2D1Ink*) ink.Handle, (ID2D1Brush*) brush.Handle, ref inkStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Ink* ink, Span<ID2D1Brush> brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInk(ink, ref brush.GetPinnableReference(), inkStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> ink, ref ID2D1Brush brush, ComPtr<TI1> inkStyle) where TI0 : unmanaged, IComVtbl<ID2D1Ink>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInk((ID2D1Ink*) ink.Handle, ref brush, (ID2D1InkStyle*) inkStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1Ink* ink, Span<ID2D1Brush> brush, Span<ID2D1InkStyle> inkStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInk(ink, ref brush.GetPinnableReference(), ref inkStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> ink, ref ID2D1Brush brush, ref ID2D1InkStyle inkStyle) where TI0 : unmanaged, IComVtbl<ID2D1Ink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInk((ID2D1Ink*) ink.Handle, ref brush, ref inkStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Ink> ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInk(ref ink.GetPinnableReference(), brush, inkStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Ink ink, ComPtr<TI0> brush, ComPtr<TI1> inkStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInk(ref ink, (ID2D1Brush*) brush.Handle, (ID2D1InkStyle*) inkStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Ink> ink, ID2D1Brush* brush, Span<ID2D1InkStyle> inkStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInk(ref ink.GetPinnableReference(), brush, ref inkStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Ink ink, ComPtr<TI0> brush, ref ID2D1InkStyle inkStyle) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInk(ref ink, (ID2D1Brush*) brush.Handle, ref inkStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Ink> ink, Span<ID2D1Brush> brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInk(ref ink.GetPinnableReference(), ref brush.GetPinnableReference(), inkStyle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1Ink ink, ref ID2D1Brush brush, ComPtr<TI0> inkStyle) where TI0 : unmanaged, IComVtbl<ID2D1InkStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawInk(ref ink, ref brush, (ID2D1InkStyle*) inkStyle.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawInk(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1Ink> ink, Span<ID2D1Brush> brush, Span<ID2D1InkStyle> inkStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawInk(ref ink.GetPinnableReference(), ref brush.GetPinnableReference(), ref inkStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawGradientMesh<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> gradientMesh) where TI0 : unmanaged, IComVtbl<ID2D1GradientMesh>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGradientMesh((ID2D1GradientMesh*) gradientMesh.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGradientMesh(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1GradientMesh> gradientMesh)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGradientMesh(ref gradientMesh.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawSpriteBatch<TI0, TI1>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> spriteBatch, uint startIndex, uint spriteCount, ComPtr<TI1> bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions) where TI0 : unmanaged, IComVtbl<ID2D1SpriteBatch>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawSpriteBatch((ID2D1SpriteBatch*) spriteBatch.Handle, startIndex, spriteCount, (ID2D1Bitmap*) bitmap.Handle, interpolationMode, spriteOptions);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawSpriteBatch(this ComPtr<ID2D1CommandSink4> thisVtbl, ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, Span<ID2D1Bitmap> bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawSpriteBatch(spriteBatch, startIndex, spriteCount, ref bitmap.GetPinnableReference(), interpolationMode, spriteOptions);
    }

    /// <summary>To be documented.</summary>
    public static int DrawSpriteBatch<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ComPtr<TI0> spriteBatch, uint startIndex, uint spriteCount, ref ID2D1Bitmap bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions) where TI0 : unmanaged, IComVtbl<ID2D1SpriteBatch>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawSpriteBatch((ID2D1SpriteBatch*) spriteBatch.Handle, startIndex, spriteCount, ref bitmap, interpolationMode, spriteOptions);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawSpriteBatch(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1SpriteBatch> spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawSpriteBatch(ref spriteBatch.GetPinnableReference(), startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
    }

    /// <summary>To be documented.</summary>
    public static int DrawSpriteBatch<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl, ref ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, ComPtr<TI0> bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawSpriteBatch(ref spriteBatch, startIndex, spriteCount, (ID2D1Bitmap*) bitmap.Handle, interpolationMode, spriteOptions);
    }

    /// <summary>To be documented.</summary>
    public static int DrawSpriteBatch(this ComPtr<ID2D1CommandSink4> thisVtbl, Span<ID2D1SpriteBatch> spriteBatch, uint startIndex, uint spriteCount, Span<ID2D1Bitmap> bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawSpriteBatch(ref spriteBatch.GetPinnableReference(), startIndex, spriteCount, ref bitmap.GetPinnableReference(), interpolationMode, spriteOptions);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1CommandSink4> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
