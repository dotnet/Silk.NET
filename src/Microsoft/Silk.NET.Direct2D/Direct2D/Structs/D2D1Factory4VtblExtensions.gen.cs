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

public unsafe static class D2D1Factory4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory4> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Factory4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Factory4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReloadSystemMetrics(this ComPtr<ID2D1Factory4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory4> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory4> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiYPtr = &dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiYPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory4> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiY);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetDesktopDpi(this ComPtr<ID2D1Factory4> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiYPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
        {
            fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
        {
            fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory4> thisVtbl, FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory4> thisVtbl, FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroupPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory4> thisVtbl, FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry** geometriesPtr = &geometries)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroup);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory4> thisVtbl, FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry** geometriesPtr = &geometries)
        {
            fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroupPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometry);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometryPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ID2D1PathGeometry** pathGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ref ID2D1PathGeometry* pathGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1PathGeometry** pathGeometryPtr = &pathGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dashesPtr = &dashes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dashesPtr = &dashes)
        {
            fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStyle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            fixed (float* dashesPtr = &dashes)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStylePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlock);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlockPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlock);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
        {
            fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlockPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
        {
            fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevice, d2dDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ID2D1Device* d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevice, d2dDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ID2D1Device** d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevicePtr, d2dDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ID2D1Device* d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
        {
            fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevicePtr, d2dDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.Core.Win32Extras.IStream* metafileStream, ID2D1GdiMetafile** metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStream, metafile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.Core.Win32Extras.IStream* metafileStream, ref ID2D1GdiMetafile* metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStream, metafilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream metafileStream, ID2D1GdiMetafile** metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* metafileStreamPtr = &metafileStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStreamPtr, metafile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream metafileStream, ref ID2D1GdiMetafile* metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* metafileStreamPtr = &metafileStream)
        {
            fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStreamPtr, metafilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* propertyXmlPtr = &propertyXml)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        SilkMarshal.Free((nint)propertyXmlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (char* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid classId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
        var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        SilkMarshal.Free((nint)propertyXmlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterEffect(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, int>)@this->LpVtbl[24])(@this, classId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterEffect(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid classId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, int>)@this->LpVtbl[24])(@this, classIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturned, effectsRegistered);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* effectsRegisteredPtr = &effectsRegistered)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturned, effectsRegisteredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* effectsReturnedPtr = &effectsReturned)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegistered);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* effectsReturnedPtr = &effectsReturned)
        {
            fixed (uint* effectsRegisteredPtr = &effectsRegistered)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegistered);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            fixed (uint* effectsRegisteredPtr = &effectsRegistered)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegisteredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegistered);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effectId, ID2D1Properties** properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectId, properties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effectId, ref ID2D1Properties* properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Properties** propertiesPtr = &properties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectId, propertiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid effectId, ID2D1Properties** properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectIdPtr, properties);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid effectId, ref ID2D1Properties* properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            fixed (ID2D1Properties** propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectIdPtr, propertiesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory4> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesktopDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory4> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesktopDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static void GetDesktopDpi(this ComPtr<ID2D1Factory4> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesktopDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRectangleGeometry(rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRectangleGeometry(in rectangle.GetPinnableReference(), rectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRectangleGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRectangleGeometry(in rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRectangleGeometry(in rectangle.GetPinnableReference(), ref rectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRoundedRectangleGeometry(roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRoundedRectangleGeometry(in roundedRectangle.GetPinnableReference(), roundedRectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRoundedRectangleGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRoundedRectangleGeometry(in roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RoundedRect> roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRoundedRectangleGeometry(in roundedRectangle.GetPinnableReference(), ref roundedRectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEllipseGeometry(ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEllipseGeometry(in ellipse.GetPinnableReference(), ellipseGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEllipseGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEllipseGeometry(in ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Ellipse> ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEllipseGeometry(in ellipse.GetPinnableReference(), ref ellipseGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGeometryGroup<TI0, TI1>(this ComPtr<ID2D1Factory4> thisVtbl, FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ComPtr<TI1> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, ref geometryGroup);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ComPtr<TI0> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGeometryGroup(fillMode, ref geometries, geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0, TI1>(this ComPtr<ID2D1Factory4> thisVtbl, ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(sourceGeometry, in transform.GetPinnableReference(), transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransformedGeometry<TI0, TI1>(this ComPtr<ID2D1Factory4> thisVtbl, ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, in transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(sourceGeometry, in transform.GetPinnableReference(), ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, in transform, ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, Span<ID2D1Geometry> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), transform, transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, Span<ID2D1Geometry> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), transform, ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, Span<ID2D1Geometry> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), in transform.GetPinnableReference(), transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry, in transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory4> thisVtbl, Span<ID2D1Geometry> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), in transform.GetPinnableReference(), ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePathGeometry<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref ComPtr<TI0> pathGeometry) where TI0 : unmanaged, IComVtbl<ID2D1PathGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePathGeometry((ID2D1PathGeometry**) pathGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, in dashes.GetPinnableReference(), dashesCount, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, in dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, in dashes.GetPinnableReference(), dashesCount, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StrokeStyleProperties> strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(in strokeStyleProperties.GetPinnableReference(), dashes, dashesCount, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(in strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StrokeStyleProperties> strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(in strokeStyleProperties.GetPinnableReference(), dashes, dashesCount, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StrokeStyleProperties> strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(in strokeStyleProperties.GetPinnableReference(), in dashes.GetPinnableReference(), dashesCount, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(in strokeStyleProperties, in dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<StrokeStyleProperties> strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(in strokeStyleProperties.GetPinnableReference(), in dashes.GetPinnableReference(), dashesCount, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDrawingStateBlock(drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DrawingStateDescription> drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(in drawingStateDescription.GetPinnableReference(), textRenderingParams, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDrawingStateBlock(in drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DrawingStateDescription> drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(in drawingStateDescription.GetPinnableReference(), textRenderingParams, ref drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWicBitmapRenderTarget(target, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(target, in renderTargetProperties.GetPinnableReference(), renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWicBitmapRenderTarget(target, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(target, in renderTargetProperties.GetPinnableReference(), ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HwndRenderTargetProperties> hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, in hwndRenderTargetProperties.GetPinnableReference(), hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, in hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HwndRenderTargetProperties> hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, in hwndRenderTargetProperties.GetPinnableReference(), ref hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(in renderTargetProperties.GetPinnableReference(), hwndRenderTargetProperties, hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(in renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(in renderTargetProperties.GetPinnableReference(), hwndRenderTargetProperties, ref hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HwndRenderTargetProperties> hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(in renderTargetProperties.GetPinnableReference(), in hwndRenderTargetProperties.GetPinnableReference(), hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(in renderTargetProperties, in hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HwndRenderTargetProperties> hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(in renderTargetProperties.GetPinnableReference(), in hwndRenderTargetProperties.GetPinnableReference(), ref hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, in renderTargetProperties.GetPinnableReference(), renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, in renderTargetProperties.GetPinnableReference(), ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), renderTargetProperties, renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), renderTargetProperties, ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), in renderTargetProperties.GetPinnableReference(), renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), in renderTargetProperties.GetPinnableReference(), ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDCRenderTarget(renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDCRenderTarget(in renderTargetProperties.GetPinnableReference(), dcRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDCRenderTarget<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDCRenderTarget(in renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetProperties> renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDCRenderTarget(in renderTargetProperties.GetPinnableReference(), ref dcRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice(dxgiDevice, (ID2D1Device**) d2dDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, ID2D1Device** d2dDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref dxgiDevice.GetPinnableReference(), d2dDevice);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDevice<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice(ref dxgiDevice, (ID2D1Device**) d2dDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, ref ID2D1Device* d2dDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref dxgiDevice.GetPinnableReference(), ref d2dDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, Silk.NET.Core.Win32Extras.IStream* metafileStream, ref ComPtr<TI0> metafile) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiMetafile(metafileStream, (ID2D1GdiMetafile**) metafile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> metafileStream, ID2D1GdiMetafile** metafile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiMetafile(ref metafileStream.GetPinnableReference(), metafile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGdiMetafile<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream metafileStream, ref ComPtr<TI0> metafile) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiMetafile(ref metafileStream, (ID2D1GdiMetafile**) metafile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory4> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> metafileStream, ref ID2D1GdiMetafile* metafile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiMetafile(ref metafileStream.GetPinnableReference(), ref metafile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId, Span<Silk.NET.Core.Win32Extras.IStream> propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(classId, ref propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(ref classId.GetPinnableReference(), propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> classId, Span<Silk.NET.Core.Win32Extras.IStream> propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(ref classId.GetPinnableReference(), ref propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(classId, in propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), in propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> classId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterEffect(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> classId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnregisterEffect(ref classId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effects, uint effectsCount, uint* effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(effects, effectsCount, effectsReturned, ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effects, uint effectsCount, Span<uint> effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(effects, effectsCount, ref effectsReturned.GetPinnableReference(), effectsRegistered);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Guid* effects, uint effectsCount, Span<uint> effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(effects, effectsCount, ref effectsReturned.GetPinnableReference(), ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, effectsReturned, effectsRegistered);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> effects, uint effectsCount, uint* effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, effectsReturned, ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> effects, uint effectsCount, Span<uint> effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, ref effectsReturned.GetPinnableReference(), effectsRegistered);
    }

    /// <summary>To be documented.</summary>
    public static int GetRegisteredEffects(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> effects, uint effectsCount, Span<uint> effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, ref effectsReturned.GetPinnableReference(), ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectProperties<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, out ComPtr<TI0> properties) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        properties = default;
        return @this->GetEffectProperties(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1Properties**) properties.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> effectId, ID2D1Properties** properties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectProperties(ref effectId.GetPinnableReference(), properties);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectProperties<TI0>(this ComPtr<ID2D1Factory4> thisVtbl, ref Guid effectId, ref ComPtr<TI0> properties) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectProperties(ref effectId, (ID2D1Properties**) properties.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory4> thisVtbl, Span<Guid> effectId, ref ID2D1Properties* properties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectProperties(ref effectId.GetPinnableReference(), ref properties);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Factory4> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetEffectProperties<TI0>(this ComPtr<ID2D1Factory4> thisVtbl) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetEffectProperties(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
