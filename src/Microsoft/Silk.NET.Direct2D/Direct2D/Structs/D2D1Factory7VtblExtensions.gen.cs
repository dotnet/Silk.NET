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

public unsafe static class D2D1Factory7VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Factory7> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Factory7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Factory7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReloadSystemMetrics(this ComPtr<ID2D1Factory7> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDesktopDpi(this ComPtr<ID2D1Factory7> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleGeometry(this ComPtr<ID2D1Factory7> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRoundedRectangleGeometry(this ComPtr<ID2D1Factory7> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipseGeometry(this ComPtr<ID2D1Factory7> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGeometryGroup(this ComPtr<ID2D1Factory7> thisVtbl, FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedGeometry(this ComPtr<ID2D1Factory7> thisVtbl, ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathGeometry(this ComPtr<ID2D1Factory7> thisVtbl, ID2D1PathGeometry** pathGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometry);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokeStyle(this ComPtr<ID2D1Factory7> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDrawingStateBlock(this ComPtr<ID2D1Factory7> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlock);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWicBitmapRenderTarget(this ComPtr<ID2D1Factory7> thisVtbl, IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHwndRenderTarget(this ComPtr<ID2D1Factory7> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDxgiSurfaceRenderTarget(this ComPtr<ID2D1Factory7> thisVtbl, Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDCRenderTarget(this ComPtr<ID2D1Factory7> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID2D1Factory7> thisVtbl, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevice, d2dDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiMetafile(this ComPtr<ID2D1Factory7> thisVtbl, Silk.NET.Core.Win32Extras.IStream* metafileStream, ID2D1GdiMetafile** metafile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStream, metafile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromStream(this ComPtr<ID2D1Factory7> thisVtbl, Guid* classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterEffectFromString(this ComPtr<ID2D1Factory7> thisVtbl, Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterEffect(this ComPtr<ID2D1Factory7> thisVtbl, Guid* classId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Guid*, int>)@this->LpVtbl[24])(@this, classId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegisteredEffects(this ComPtr<ID2D1Factory7> thisVtbl, Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturned, effectsRegistered);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectProperties(this ComPtr<ID2D1Factory7> thisVtbl, Guid* effectId, ID2D1Properties** properties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory7*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectId, properties);
        return ret;
    }

}
