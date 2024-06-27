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

public unsafe static class WICBitmapFrameDecodeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICBitmapFrameDecode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICBitmapFrameDecode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint* puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint* puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiHeightPtr = &puiHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref uint puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref uint puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormat(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Guid* pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref Guid pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pPixelFormatPtr = &pPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICBitmapFrameDecode> thisVtbl, double* pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICBitmapFrameDecode> thisVtbl, double* pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiYPtr = &pDpiY)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref double pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref double pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPalette(this ComPtr<IWICBitmapFrameDecode> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryReader(this ComPtr<IWICBitmapFrameDecode> thisVtbl, IWICMetadataQueryReader** ppIMetadataQueryReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryReader(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref IWICMetadataQueryReader* ppIMetadataQueryReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryReader** ppIMetadataQueryReaderPtr = &ppIMetadataQueryReader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcActualCountPtr = &pcActualCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
        {
            fixed (uint* pcActualCountPtr = &pcActualCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetThumbnail(this ComPtr<IWICBitmapFrameDecode> thisVtbl, IWICBitmapSource** ppIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetThumbnail(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref IWICBitmapSource* ppIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource** ppIThumbnailPtr = &ppIThumbnail)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnailPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICBitmapFrameDecode> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint* puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(puiWidth, ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<uint> puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), puiHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<Guid> pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormat(ref pPixelFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICBitmapFrameDecode> thisVtbl, double* pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(pDpiX, ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<double> pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), pDpiY);
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<double> pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette<TI0>(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICBitmapFrameDecode> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapFrameDecode> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataQueryReader<TI0>(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref ComPtr<TI0> ppIMetadataQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataQueryReader((IWICMetadataQueryReader**) ppIMetadataQueryReader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts<TI0>(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, Span<uint> pcActualCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorContexts(cCount, ppIColorContexts, ref pcActualCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetColorContexts<TI0>(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapFrameDecode> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, Span<uint> pcActualCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorContexts(cCount, ref ppIColorContexts, ref pcActualCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetThumbnail<TI0>(this ComPtr<IWICBitmapFrameDecode> thisVtbl, ref ComPtr<TI0> ppIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetThumbnail((IWICBitmapSource**) ppIThumbnail.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICBitmapFrameDecode> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
