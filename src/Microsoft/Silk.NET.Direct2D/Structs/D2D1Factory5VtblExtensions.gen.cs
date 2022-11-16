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

public unsafe static class D2D1Factory5VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory5> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory5> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Factory5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Factory5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReloadSystemMetrics(this ComPtr<ID2D1Factory5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory5> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory5> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiYPtr = &dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiYPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory5> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiY);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetDesktopDpi(this ComPtr<ID2D1Factory5> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiYPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.Maths.Box2D<float>* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.Maths.Box2D<float>* rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.Maths.Box2D<float> rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.Maths.Box2D<float> rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
        {
            fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, RoundedRect* roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref RoundedRect roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref RoundedRect roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
        {
            fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Ellipse* ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref Ellipse ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref Ellipse ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory5> thisVtbl, FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory5> thisVtbl, FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroupPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory5> thisVtbl, FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry** geometriesPtr = &geometries)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroup);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory5> thisVtbl, FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry** geometriesPtr = &geometries)
        {
            fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroupPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ID2D1Geometry* sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ID2D1Geometry* sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ID2D1Geometry* sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ID2D1Geometry* sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref ID2D1Geometry sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometry);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref ID2D1Geometry sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref ID2D1Geometry sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometry);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref ID2D1Geometry sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometryPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ID2D1PathGeometry** pathGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ref ID2D1PathGeometry* pathGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1PathGeometry** pathGeometryPtr = &pathGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, ref float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dashesPtr = &dashes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, ref float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dashesPtr = &dashes)
        {
            fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, ref StrokeStyleProperties strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStyle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, ref StrokeStyleProperties strokeStyleProperties, float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, ref StrokeStyleProperties strokeStyleProperties, ref float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStyle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, ref StrokeStyleProperties strokeStyleProperties, ref float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
        {
            fixed (float* dashesPtr = &dashes)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStylePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlock);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlockPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParamsPtr, drawingStateBlock);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
        {
            fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParamsPtr, drawingStateBlockPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, ref DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlock);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, ref DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
        {
            fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlockPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, ref DrawingStateDescription drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
        {
            fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParamsPtr, drawingStateBlock);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, ref DrawingStateDescription drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
        {
            fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
            {
                fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParamsPtr, drawingStateBlockPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref IWICBitmap target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap* targetPtr = &target)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, targetPtr, renderTargetProperties, renderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref IWICBitmap target, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap* targetPtr = &target)
        {
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, targetPtr, renderTargetProperties, renderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref IWICBitmap target, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap* targetPtr = &target)
        {
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, targetPtr, renderTargetPropertiesPtr, renderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref IWICBitmap target, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmap* targetPtr = &target)
        {
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, targetPtr, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
        {
            fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, ref RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, ref RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
        {
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
        {
            fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevice, d2dDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ID2D1Device* d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevice, d2dDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ID2D1Device** d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevicePtr, d2dDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ID2D1Device* d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
        {
            fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevicePtr, d2dDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.Core.Win32Extras.IStream* metafileStream, ID2D1GdiMetafile** metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[18])(@this, metafileStream, metafile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.Core.Win32Extras.IStream* metafileStream, ref ID2D1GdiMetafile* metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[18])(@this, metafileStream, metafilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream metafileStream, ID2D1GdiMetafile** metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* metafileStreamPtr = &metafileStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[18])(@this, metafileStreamPtr, metafile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream metafileStream, ref ID2D1GdiMetafile* metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* metafileStreamPtr = &metafileStream)
        {
            fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[18])(@this, metafileStreamPtr, metafilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropertyBinding* bindingsPtr = &bindings)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classId, propertyXml, bindingsPtr, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
        {
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classId, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classIdPtr, propertyXml, bindingsPtr, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
            {
                fixed (PropertyBinding* bindingsPtr = &bindings)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[19])(@this, classIdPtr, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, char* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, char* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropertyBinding* bindingsPtr = &bindings)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classId, propertyXml, bindingsPtr, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, ref char propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* propertyXmlPtr = &propertyXml)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, ref char propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* propertyXmlPtr = &propertyXml)
        {
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classId, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        SilkMarshal.Free((nint)propertyXmlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
        fixed (PropertyBinding* bindingsPtr = &bindings)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classId, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
        }
        SilkMarshal.Free((nint)propertyXmlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, char* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, char* propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classIdPtr, propertyXml, bindingsPtr, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, ref char propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (char* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, ref char propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            fixed (char* propertyXmlPtr = &propertyXml)
            {
                fixed (PropertyBinding* bindingsPtr = &bindings)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
        var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
        SilkMarshal.Free((nint)propertyXmlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, ref PropertyBinding bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
        var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
            fixed (PropertyBinding* bindingsPtr = &bindings)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[20])(@this, classIdPtr, propertyXmlPtr, bindingsPtr, bindingsCount, effectFactory);
            }
        SilkMarshal.Free((nint)propertyXmlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterEffect(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, int>)@this->LpVtbl[21])(@this, classId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterEffect(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid classId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* classIdPtr = &classId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, int>)@this->LpVtbl[21])(@this, classIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effects, effectsCount, effectsReturned, effectsRegistered);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* effectsRegisteredPtr = &effectsRegistered)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effects, effectsCount, effectsReturned, effectsRegisteredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* effectsReturnedPtr = &effectsReturned)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegistered);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* effectsReturnedPtr = &effectsReturned)
        {
            fixed (uint* effectsRegisteredPtr = &effectsRegistered)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegistered);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            fixed (uint* effectsRegisteredPtr = &effectsRegistered)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegisteredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegistered);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectsPtr = &effects)
        {
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[22])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effectId, ID2D1Properties** properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[23])(@this, effectId, properties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effectId, ref ID2D1Properties* properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Properties** propertiesPtr = &properties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[23])(@this, effectId, propertiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid effectId, ID2D1Properties** properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[23])(@this, effectIdPtr, properties);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid effectId, ref ID2D1Properties* properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* effectIdPtr = &effectId)
        {
            fixed (ID2D1Properties** propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory5*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[23])(@this, effectIdPtr, propertiesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory5> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesktopDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory5> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesktopDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static void GetDesktopDpi(this ComPtr<ID2D1Factory5> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDesktopDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.Maths.Box2D<float>* rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRectangleGeometry(rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRectangleGeometry(ref rectangle.GetPinnableReference(), rectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRectangleGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.Maths.Box2D<float> rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRectangleGeometry(ref rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRectangleGeometry(ref rectangle.GetPinnableReference(), ref rectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, RoundedRect* roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRoundedRectangleGeometry(roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<RoundedRect> roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRoundedRectangleGeometry(ref roundedRectangle.GetPinnableReference(), roundedRectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRoundedRectangleGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref RoundedRect roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRoundedRectangleGeometry(ref roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<RoundedRect> roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRoundedRectangleGeometry(ref roundedRectangle.GetPinnableReference(), ref roundedRectangleGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, Ellipse* ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEllipseGeometry(ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<Ellipse> ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEllipseGeometry(ref ellipse.GetPinnableReference(), ellipseGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEllipseGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref Ellipse ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEllipseGeometry(ref ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<Ellipse> ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEllipseGeometry(ref ellipse.GetPinnableReference(), ref ellipseGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGeometryGroup<TI0, TI1>(this ComPtr<ID2D1Factory5> thisVtbl, FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ComPtr<TI1> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, ref geometryGroup);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ComPtr<TI0> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGeometryGroup(fillMode, ref geometries, geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0, TI1>(this ComPtr<ID2D1Factory5> thisVtbl, ComPtr<TI0> sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ComPtr<TI0> sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ID2D1Geometry* sourceGeometry, Span<Silk.NET.Maths.Matrix3X2<float>> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(sourceGeometry, ref transform.GetPinnableReference(), transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransformedGeometry<TI0, TI1>(this ComPtr<ID2D1Factory5> thisVtbl, ComPtr<TI0> sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, ref transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, ID2D1Geometry* sourceGeometry, Span<Silk.NET.Maths.Matrix3X2<float>> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(sourceGeometry, ref transform.GetPinnableReference(), ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ComPtr<TI0> sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, ref transform, ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<ID2D1Geometry> sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), transform, transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref ID2D1Geometry sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<ID2D1Geometry> sourceGeometry, Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), transform, ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<ID2D1Geometry> sourceGeometry, Span<Silk.NET.Maths.Matrix3X2<float>> transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), ref transform.GetPinnableReference(), transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransformedGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref ID2D1Geometry sourceGeometry, ref Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry, ref transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory5> thisVtbl, Span<ID2D1Geometry> sourceGeometry, Span<Silk.NET.Maths.Matrix3X2<float>> transform, ref ID2D1TransformedGeometry* transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTransformedGeometry(ref sourceGeometry.GetPinnableReference(), ref transform.GetPinnableReference(), ref transformedGeometry);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePathGeometry<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref ComPtr<TI0> pathGeometry) where TI0 : unmanaged, IComVtbl<ID2D1PathGeometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePathGeometry((ID2D1PathGeometry**) pathGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, Span<float> dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, ref dashes.GetPinnableReference(), dashesCount, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, ref float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, ref dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, StrokeStyleProperties* strokeStyleProperties, Span<float> dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(strokeStyleProperties, ref dashes.GetPinnableReference(), dashesCount, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, Span<StrokeStyleProperties> strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(ref strokeStyleProperties.GetPinnableReference(), dashes, dashesCount, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref StrokeStyleProperties strokeStyleProperties, float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(ref strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, Span<StrokeStyleProperties> strokeStyleProperties, float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(ref strokeStyleProperties.GetPinnableReference(), dashes, dashesCount, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, Span<StrokeStyleProperties> strokeStyleProperties, Span<float> dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(ref strokeStyleProperties.GetPinnableReference(), ref dashes.GetPinnableReference(), dashesCount, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStrokeStyle<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref StrokeStyleProperties strokeStyleProperties, ref float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStrokeStyle(ref strokeStyleProperties, ref dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory5> thisVtbl, Span<StrokeStyleProperties> strokeStyleProperties, Span<float> dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStrokeStyle(ref strokeStyleProperties.GetPinnableReference(), ref dashes.GetPinnableReference(), dashesCount, ref strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDrawingStateBlock(drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, Span<IDWriteRenderingParams> textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(drawingStateDescription, ref textRenderingParams.GetPinnableReference(), drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDrawingStateBlock(drawingStateDescription, ref textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, DrawingStateDescription* drawingStateDescription, Span<IDWriteRenderingParams> textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(drawingStateDescription, ref textRenderingParams.GetPinnableReference(), ref drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, Span<DrawingStateDescription> drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(ref drawingStateDescription.GetPinnableReference(), textRenderingParams, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDrawingStateBlock(ref drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, Span<DrawingStateDescription> drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(ref drawingStateDescription.GetPinnableReference(), textRenderingParams, ref drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, Span<DrawingStateDescription> drawingStateDescription, Span<IDWriteRenderingParams> textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(ref drawingStateDescription.GetPinnableReference(), ref textRenderingParams.GetPinnableReference(), drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDrawingStateBlock<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref DrawingStateDescription drawingStateDescription, ref IDWriteRenderingParams textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDrawingStateBlock(ref drawingStateDescription, ref textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory5> thisVtbl, Span<DrawingStateDescription> drawingStateDescription, Span<IDWriteRenderingParams> textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDrawingStateBlock(ref drawingStateDescription.GetPinnableReference(), ref textRenderingParams.GetPinnableReference(), ref drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWicBitmapRenderTarget(target, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, Span<RenderTargetProperties> renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(target, ref renderTargetProperties.GetPinnableReference(), renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, ref RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWicBitmapRenderTarget(target, ref renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, IWICBitmap* target, Span<RenderTargetProperties> renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(target, ref renderTargetProperties.GetPinnableReference(), ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<IWICBitmap> target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(ref target.GetPinnableReference(), renderTargetProperties, renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref IWICBitmap target, RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWicBitmapRenderTarget(ref target, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<IWICBitmap> target, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(ref target.GetPinnableReference(), renderTargetProperties, ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<IWICBitmap> target, Span<RenderTargetProperties> renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(ref target.GetPinnableReference(), ref renderTargetProperties.GetPinnableReference(), renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateWicBitmapRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref IWICBitmap target, ref RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWicBitmapRenderTarget(ref target, ref renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<IWICBitmap> target, Span<RenderTargetProperties> renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWicBitmapRenderTarget(ref target.GetPinnableReference(), ref renderTargetProperties.GetPinnableReference(), ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, Span<HwndRenderTargetProperties> hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, ref hwndRenderTargetProperties.GetPinnableReference(), hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, ref hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, Span<HwndRenderTargetProperties> hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(renderTargetProperties, ref hwndRenderTargetProperties.GetPinnableReference(), ref hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<RenderTargetProperties> renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(ref renderTargetProperties.GetPinnableReference(), hwndRenderTargetProperties, hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(ref renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<RenderTargetProperties> renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(ref renderTargetProperties.GetPinnableReference(), hwndRenderTargetProperties, ref hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<RenderTargetProperties> renderTargetProperties, Span<HwndRenderTargetProperties> hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(ref renderTargetProperties.GetPinnableReference(), ref hwndRenderTargetProperties.GetPinnableReference(), hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateHwndRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, ref HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateHwndRenderTarget(ref renderTargetProperties, ref hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<RenderTargetProperties> renderTargetProperties, Span<HwndRenderTargetProperties> hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHwndRenderTarget(ref renderTargetProperties.GetPinnableReference(), ref hwndRenderTargetProperties.GetPinnableReference(), ref hwndRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, Span<RenderTargetProperties> renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, ref renderTargetProperties.GetPinnableReference(), renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, ref RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, ref renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, Span<RenderTargetProperties> renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, ref renderTargetProperties.GetPinnableReference(), ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), renderTargetProperties, renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), renderTargetProperties, ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, Span<RenderTargetProperties> renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), ref renderTargetProperties.GetPinnableReference(), renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDxgiSurfaceRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGISurface dxgiSurface, ref RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, ref renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> dxgiSurface, Span<RenderTargetProperties> renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface.GetPinnableReference(), ref renderTargetProperties.GetPinnableReference(), ref renderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDCRenderTarget(renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<RenderTargetProperties> renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDCRenderTarget(ref renderTargetProperties.GetPinnableReference(), dcRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDCRenderTarget<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDCRenderTarget(ref renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory5> thisVtbl, Span<RenderTargetProperties> renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDCRenderTarget(ref renderTargetProperties.GetPinnableReference(), ref dcRenderTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice(dxgiDevice, (ID2D1Device**) d2dDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, ID2D1Device** d2dDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref dxgiDevice.GetPinnableReference(), d2dDevice);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDevice<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice(ref dxgiDevice, (ID2D1Device**) d2dDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, ref ID2D1Device* d2dDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref dxgiDevice.GetPinnableReference(), ref d2dDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, Silk.NET.Core.Win32Extras.IStream* metafileStream, ref ComPtr<TI0> metafile) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiMetafile(metafileStream, (ID2D1GdiMetafile**) metafile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> metafileStream, ID2D1GdiMetafile** metafile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiMetafile(ref metafileStream.GetPinnableReference(), metafile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGdiMetafile<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream metafileStream, ref ComPtr<TI0> metafile) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiMetafile(ref metafileStream, (ID2D1GdiMetafile**) metafile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory5> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> metafileStream, ref ID2D1GdiMetafile* metafile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiMetafile(ref metafileStream.GetPinnableReference(), ref metafile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(classId, propertyXml, ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, Span<Silk.NET.Core.Win32Extras.IStream> propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(classId, ref propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, Span<Silk.NET.Core.Win32Extras.IStream> propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(classId, ref propertyXml.GetPinnableReference(), ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(ref classId.GetPinnableReference(), propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(ref classId.GetPinnableReference(), propertyXml, ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, Span<Silk.NET.Core.Win32Extras.IStream> propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(ref classId.GetPinnableReference(), ref propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterEffectFromStream(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, Span<Silk.NET.Core.Win32Extras.IStream> propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromStream(ref classId.GetPinnableReference(), ref propertyXml.GetPinnableReference(), ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, char* propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(classId, propertyXml, ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, Span<char> propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(classId, ref propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, Span<char> propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(classId, ref propertyXml.GetPinnableReference(), ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Guid* classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(classId, propertyXml, ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, char* propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, char* propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), propertyXml, ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, Span<char> propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), ref propertyXml.GetPinnableReference(), bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, Span<char> propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), ref propertyXml.GetPinnableReference(), ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterEffectFromString(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, Span<PropertyBinding> bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterEffectFromString(ref classId.GetPinnableReference(), propertyXml, ref bindings.GetPinnableReference(), bindingsCount, effectFactory);
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterEffect(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> classId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnregisterEffect(ref classId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effects, uint effectsCount, uint* effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(effects, effectsCount, effectsReturned, ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effects, uint effectsCount, Span<uint> effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(effects, effectsCount, ref effectsReturned.GetPinnableReference(), effectsRegistered);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Guid* effects, uint effectsCount, Span<uint> effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(effects, effectsCount, ref effectsReturned.GetPinnableReference(), ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, effectsReturned, effectsRegistered);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> effects, uint effectsCount, uint* effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, effectsReturned, ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> effects, uint effectsCount, Span<uint> effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, ref effectsReturned.GetPinnableReference(), effectsRegistered);
    }

    /// <summary>To be documented.</summary>
    public static int GetRegisteredEffects(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> effects, uint effectsCount, Span<uint> effectsReturned, Span<uint> effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRegisteredEffects(ref effects.GetPinnableReference(), effectsCount, ref effectsReturned.GetPinnableReference(), ref effectsRegistered.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectProperties<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, out ComPtr<TI0> properties) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        properties = default;
        return @this->GetEffectProperties(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1Properties**) properties.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> effectId, ID2D1Properties** properties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectProperties(ref effectId.GetPinnableReference(), properties);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectProperties<TI0>(this ComPtr<ID2D1Factory5> thisVtbl, ref Guid effectId, ref ComPtr<TI0> properties) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEffectProperties(ref effectId, (ID2D1Properties**) properties.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory5> thisVtbl, Span<Guid> effectId, ref ID2D1Properties* properties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectProperties(ref effectId.GetPinnableReference(), ref properties);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Factory5> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetEffectProperties<TI0>(this ComPtr<ID2D1Factory5> thisVtbl) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetEffectProperties(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
