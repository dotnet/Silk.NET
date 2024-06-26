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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICFormatConverterVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICFormatConverter> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICFormatConverter> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICFormatConverter> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICFormatConverter> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICFormatConverter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICFormatConverter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICFormatConverter> thisVtbl, uint* puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICFormatConverter> thisVtbl, uint* puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiHeightPtr = &puiHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICFormatConverter> thisVtbl, ref uint puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICFormatConverter> thisVtbl, ref uint puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormat(this ComPtr<IWICFormatConverter> thisVtbl, Guid* pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICFormatConverter> thisVtbl, ref Guid pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pPixelFormatPtr = &pPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICFormatConverter> thisVtbl, double* pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICFormatConverter> thisVtbl, double* pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiYPtr = &pDpiY)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICFormatConverter> thisVtbl, ref double pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICFormatConverter> thisVtbl, ref double pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPalette(this ComPtr<IWICFormatConverter> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICFormatConverter> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, IWICBitmapSource* pISource, Guid* dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, IWICBitmapSource* pISource, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormat, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, IWICBitmapSource* pISource, ref Guid dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* dstFormatPtr = &dstFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormatPtr, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, IWICBitmapSource* pISource, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* dstFormatPtr = &dstFormat)
        {
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISource, dstFormatPtr, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, ref IWICBitmapSource pISource, Guid* dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pISourcePtr = &pISource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, ref IWICBitmapSource pISource, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pISourcePtr = &pISource)
        {
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormat, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, ref IWICBitmapSource pISource, ref Guid dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pISourcePtr = &pISource)
        {
            fixed (Guid* dstFormatPtr = &dstFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormatPtr, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, ref IWICBitmapSource pISource, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pISourcePtr = &pISource)
        {
            fixed (Guid* dstFormatPtr = &dstFormat)
            {
                fixed (IWICPalette* pIPalettePtr = &pIPalette)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, IWICBitmapSource*, Guid*, BitmapDitherType, IWICPalette*, double, BitmapPaletteType, int>)@this->LpVtbl[8])(@this, pISourcePtr, dstFormatPtr, dither, pIPalettePtr, alphaThresholdPercent, paletteTranslate);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Guid* srcPixelFormat, Guid* dstPixelFormat, int* pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormat, pfCanConvert);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Guid* srcPixelFormat, Guid* dstPixelFormat, ref int pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfCanConvertPtr = &pfCanConvert)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormat, pfCanConvertPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Guid* srcPixelFormat, ref Guid dstPixelFormat, int* pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormatPtr, pfCanConvert);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Guid* srcPixelFormat, ref Guid dstPixelFormat, ref int pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
        {
            fixed (int* pfCanConvertPtr = &pfCanConvert)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormat, dstPixelFormatPtr, pfCanConvertPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, ref Guid srcPixelFormat, Guid* dstPixelFormat, int* pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormat, pfCanConvert);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, ref Guid srcPixelFormat, Guid* dstPixelFormat, ref int pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
        {
            fixed (int* pfCanConvertPtr = &pfCanConvert)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormat, pfCanConvertPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, ref Guid srcPixelFormat, ref Guid dstPixelFormat, int* pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
        {
            fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormatPtr, pfCanConvert);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, ref Guid srcPixelFormat, ref Guid dstPixelFormat, ref int pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* srcPixelFormatPtr = &srcPixelFormat)
        {
            fixed (Guid* dstPixelFormatPtr = &dstPixelFormat)
            {
                fixed (int* pfCanConvertPtr = &pfCanConvert)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICFormatConverter*, Guid*, Guid*, int*, int>)@this->LpVtbl[9])(@this, srcPixelFormatPtr, dstPixelFormatPtr, pfCanConvertPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICFormatConverter> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICFormatConverter> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICFormatConverter> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICFormatConverter> thisVtbl, uint* puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(puiWidth, ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICFormatConverter> thisVtbl, Span<uint> puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), puiHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICFormatConverter> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICFormatConverter> thisVtbl, Span<Guid> pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormat(ref pPixelFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICFormatConverter> thisVtbl, double* pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(pDpiX, ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICFormatConverter> thisVtbl, Span<double> pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), pDpiY);
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICFormatConverter> thisVtbl, Span<double> pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette<TI0>(this ComPtr<IWICFormatConverter> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICFormatConverter> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICFormatConverter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0, TI1>(this ComPtr<IWICFormatConverter> thisVtbl, ComPtr<TI0> pISource, Guid* dstFormat, BitmapDitherType dither, ComPtr<TI1> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pISource.Handle, dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, IWICBitmapSource* pISource, Guid* dstFormat, BitmapDitherType dither, Span<IWICPalette> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pISource, dstFormat, dither, ref pIPalette.GetPinnableReference(), alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0>(this ComPtr<IWICFormatConverter> thisVtbl, ComPtr<TI0> pISource, Guid* dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pISource.Handle, dstFormat, dither, ref pIPalette, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, IWICBitmapSource* pISource, Span<Guid> dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pISource, ref dstFormat.GetPinnableReference(), dither, pIPalette, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0, TI1>(this ComPtr<IWICFormatConverter> thisVtbl, ComPtr<TI0> pISource, ref Guid dstFormat, BitmapDitherType dither, ComPtr<TI1> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pISource.Handle, ref dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, IWICBitmapSource* pISource, Span<Guid> dstFormat, BitmapDitherType dither, Span<IWICPalette> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pISource, ref dstFormat.GetPinnableReference(), dither, ref pIPalette.GetPinnableReference(), alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<IWICFormatConverter> thisVtbl, ComPtr<TI0> pISource, ref Guid dstFormat, BitmapDitherType dither, ref IWICPalette pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pISource.Handle, ref dstFormat, dither, ref pIPalette, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, Span<IWICBitmapSource> pISource, Guid* dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pISource.GetPinnableReference(), dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0>(this ComPtr<IWICFormatConverter> thisVtbl, ref IWICBitmapSource pISource, Guid* dstFormat, BitmapDitherType dither, ComPtr<TI0> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pISource, dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, Span<IWICBitmapSource> pISource, Guid* dstFormat, BitmapDitherType dither, Span<IWICPalette> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pISource.GetPinnableReference(), dstFormat, dither, ref pIPalette.GetPinnableReference(), alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, Span<IWICBitmapSource> pISource, Span<Guid> dstFormat, BitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pISource.GetPinnableReference(), ref dstFormat.GetPinnableReference(), dither, pIPalette, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<IWICFormatConverter> thisVtbl, ref IWICBitmapSource pISource, ref Guid dstFormat, BitmapDitherType dither, ComPtr<TI0> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pISource, ref dstFormat, dither, (IWICPalette*) pIPalette.Handle, alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICFormatConverter> thisVtbl, Span<IWICBitmapSource> pISource, Span<Guid> dstFormat, BitmapDitherType dither, Span<IWICPalette> pIPalette, double alphaThresholdPercent, BitmapPaletteType paletteTranslate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pISource.GetPinnableReference(), ref dstFormat.GetPinnableReference(), dither, ref pIPalette.GetPinnableReference(), alphaThresholdPercent, paletteTranslate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Guid* srcPixelFormat, Guid* dstPixelFormat, Span<int> pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanConvert(srcPixelFormat, dstPixelFormat, ref pfCanConvert.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Guid* srcPixelFormat, Span<Guid> dstPixelFormat, int* pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanConvert(srcPixelFormat, ref dstPixelFormat.GetPinnableReference(), pfCanConvert);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Guid* srcPixelFormat, Span<Guid> dstPixelFormat, Span<int> pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanConvert(srcPixelFormat, ref dstPixelFormat.GetPinnableReference(), ref pfCanConvert.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Span<Guid> srcPixelFormat, Guid* dstPixelFormat, int* pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanConvert(ref srcPixelFormat.GetPinnableReference(), dstPixelFormat, pfCanConvert);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Span<Guid> srcPixelFormat, Guid* dstPixelFormat, Span<int> pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanConvert(ref srcPixelFormat.GetPinnableReference(), dstPixelFormat, ref pfCanConvert.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Span<Guid> srcPixelFormat, Span<Guid> dstPixelFormat, int* pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanConvert(ref srcPixelFormat.GetPinnableReference(), ref dstPixelFormat.GetPinnableReference(), pfCanConvert);
    }

    /// <summary>To be documented.</summary>
    public static int CanConvert(this ComPtr<IWICFormatConverter> thisVtbl, Span<Guid> srcPixelFormat, Span<Guid> dstPixelFormat, Span<int> pfCanConvert)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanConvert(ref srcPixelFormat.GetPinnableReference(), ref dstPixelFormat.GetPinnableReference(), ref pfCanConvert.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICFormatConverter> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
