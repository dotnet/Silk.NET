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

public unsafe static class D2D1Device5VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device5> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device5> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device5> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device5> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Device5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Device5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Device5> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Device5> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceContext(this ComPtr<ID2D1Device5> thisVtbl, DeviceContextOptions options, ID2D1DeviceContext** deviceContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, DeviceContextOptions, ID2D1DeviceContext**, int>)@this->LpVtbl[4])(@this, options, deviceContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceContext(this ComPtr<ID2D1Device5> thisVtbl, DeviceContextOptions options, ref ID2D1DeviceContext* deviceContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1DeviceContext** deviceContextPtr = &deviceContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, DeviceContextOptions, ID2D1DeviceContext**, int>)@this->LpVtbl[4])(@this, options, deviceContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrintControlProperties* printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1PrintControl** printControlPtr = &printControl)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrintControlProperties printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlPropertiesPtr, printControl);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrintControlProperties printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PrintControlProperties* printControlPropertiesPtr = &printControlProperties)
        {
            fixed (ID2D1PrintControl** printControlPtr = &printControl)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlPropertiesPtr, printControlPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMaximumTextureMemory(this ComPtr<ID2D1Device5> thisVtbl, ulong maximumInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ulong, void>)@this->LpVtbl[6])(@this, maximumInBytes);
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMaximumTextureMemory(this ComPtr<ID2D1Device5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ulong>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearResources(this ComPtr<ID2D1Device5> thisVtbl, uint millisecondsSinceUse)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device5*, uint, void>)@this->LpVtbl[8])(@this, millisecondsSinceUse);
    }

    /// <summary>To be documented.</summary>
    public static RenderingPriority GetRenderingPriority(this ComPtr<ID2D1Device5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        RenderingPriority ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, RenderingPriority>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetRenderingPriority(this ComPtr<ID2D1Device5> thisVtbl, RenderingPriority renderingPriority)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device5*, RenderingPriority, void>)@this->LpVtbl[10])(@this, renderingPriority);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FlushDeviceContexts(this ComPtr<ID2D1Device5> thisVtbl, ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ID2D1Bitmap*, void>)@this->LpVtbl[13])(@this, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static void FlushDeviceContexts(this ComPtr<ID2D1Device5> thisVtbl, ref ID2D1Bitmap bitmap)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ID2D1Bitmap*, void>)@this->LpVtbl[13])(@this, bitmapPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxgiDevice(this ComPtr<ID2D1Device5> thisVtbl, Silk.NET.DXGI.IDXGIDevice** dxgiDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, Silk.NET.DXGI.IDXGIDevice**, int>)@this->LpVtbl[14])(@this, dxgiDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxgiDevice(this ComPtr<ID2D1Device5> thisVtbl, ref Silk.NET.DXGI.IDXGIDevice* dxgiDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIDevice** dxgiDevicePtr = &dxgiDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, Silk.NET.DXGI.IDXGIDevice**, int>)@this->LpVtbl[14])(@this, dxgiDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMaximumColorGlyphCacheMemory(this ComPtr<ID2D1Device5> thisVtbl, ulong maximumInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ulong, void>)@this->LpVtbl[17])(@this, maximumInBytes);
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMaximumColorGlyphCacheMemory(this ComPtr<ID2D1Device5> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device5*, ulong>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Device5> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device5> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device5> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1Device5> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateDeviceContext<TI0>(this ComPtr<ID2D1Device5> thisVtbl, DeviceContextOptions options, ref ComPtr<TI0> deviceContext) where TI0 : unmanaged, IComVtbl<ID2D1DeviceContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDeviceContext(options, (ID2D1DeviceContext**) deviceContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrintControlProperties* printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrintControlProperties> printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, in printControlProperties.GetPinnableReference(), printControl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl<TI0>(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrintControlProperties printControlProperties, ref ComPtr<TI0> printControl) where TI0 : unmanaged, IComVtbl<ID2D1PrintControl>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, in printControlProperties, (ID2D1PrintControl**) printControl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device5> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrintControlProperties> printControlProperties, ref ID2D1PrintControl* printControl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePrintControl(wicFactory, documentTarget, in printControlProperties.GetPinnableReference(), ref printControl);
    }

    /// <summary>To be documented.</summary>
    public static void FlushDeviceContexts<TI0>(this ComPtr<ID2D1Device5> thisVtbl, ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->FlushDeviceContexts((ID2D1Bitmap*) bitmap.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void FlushDeviceContexts(this ComPtr<ID2D1Device5> thisVtbl, Span<ID2D1Bitmap> bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->FlushDeviceContexts(ref bitmap.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Device5> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
