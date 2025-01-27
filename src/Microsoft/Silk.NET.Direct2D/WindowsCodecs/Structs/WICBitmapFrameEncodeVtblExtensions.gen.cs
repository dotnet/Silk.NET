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

public unsafe static class WICBitmapFrameEncodeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICBitmapFrameEncode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICBitmapFrameEncode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Silk.NET.Core.Win32Extras.IPropertyBag2* pIEncoderOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Silk.NET.Core.Win32Extras.IPropertyBag2*, int>)@this->LpVtbl[3])(@this, pIEncoderOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref Silk.NET.Core.Win32Extras.IPropertyBag2 pIEncoderOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IPropertyBag2* pIEncoderOptionsPtr = &pIEncoderOptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Silk.NET.Core.Win32Extras.IPropertyBag2*, int>)@this->LpVtbl[3])(@this, pIEncoderOptionsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSize(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint uiWidth, uint uiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, int>)@this->LpVtbl[4])(@this, uiWidth, uiHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetResolution(this ComPtr<IWICBitmapFrameEncode> thisVtbl, double dpiX, double dpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, double, double, int>)@this->LpVtbl[5])(@this, dpiX, dpiY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelFormat(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Guid* pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelFormat(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref Guid pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pPixelFormatPtr = &pPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetColorContexts(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint cCount, IWICColorContext** ppIColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, IWICColorContext**, int>)@this->LpVtbl[7])(@this, cCount, ppIColorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetColorContexts(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextPtr = &ppIColorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, IWICColorContext**, int>)@this->LpVtbl[7])(@this, cCount, ppIColorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPalette(this ComPtr<IWICBitmapFrameEncode> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICPalette*, int>)@this->LpVtbl[8])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPalette(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICPalette*, int>)@this->LpVtbl[8])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetThumbnail(this ComPtr<IWICBitmapFrameEncode> thisVtbl, IWICBitmapSource* pIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIThumbnail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetThumbnail(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref IWICBitmapSource pIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIThumbnailPtr = &pIThumbnail)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIThumbnailPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePixels(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)@this->LpVtbl[10])(@this, lineCount, cbStride, cbBufferSize, pbPixels);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WritePixels(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint lineCount, uint cbStride, uint cbBufferSize, ref byte pbPixels)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbPixelsPtr = &pbPixels)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)@this->LpVtbl[10])(@this, lineCount, cbStride, cbBufferSize, pbPixelsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WritePixels(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint lineCount, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbPixels)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbPixelsPtr = (byte*) SilkMarshal.StringToPtr(pbPixels, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)@this->LpVtbl[10])(@this, lineCount, cbStride, cbBufferSize, pbPixelsPtr);
        SilkMarshal.Free((nint)pbPixelsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICBitmapFrameEncode> thisVtbl, IWICBitmapSource* pIBitmapSource, Silk.NET.Maths.Rectangle<int>* prc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSource, prc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICBitmapFrameEncode> thisVtbl, IWICBitmapSource* pIBitmapSource, ref Silk.NET.Maths.Rectangle<int> prc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSource, prcPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref IWICBitmapSource pIBitmapSource, Silk.NET.Maths.Rectangle<int>* prc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSourcePtr, prc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteSource(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref IWICBitmapSource pIBitmapSource, ref Silk.NET.Maths.Rectangle<int> prc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICBitmapSource*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[11])(@this, pIBitmapSourcePtr, prcPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IWICBitmapFrameEncode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, int>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryWriter(this ComPtr<IWICBitmapFrameEncode> thisVtbl, IWICMetadataQueryWriter** ppIMetadataQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[13])(@this, ppIMetadataQueryWriter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryWriter(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref IWICMetadataQueryWriter* ppIMetadataQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryWriter** ppIMetadataQueryWriterPtr = &ppIMetadataQueryWriter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[13])(@this, ppIMetadataQueryWriterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<Silk.NET.Core.Win32Extras.IPropertyBag2> pIEncoderOptions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIEncoderOptions.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelFormat(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<Guid> pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPixelFormat(ref pPixelFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetColorContexts<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetColorContexts(cCount, (IWICColorContext**) ppIColorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetPalette<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPalette(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetThumbnail<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ComPtr<TI0> pIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetThumbnail((IWICBitmapSource*) pIThumbnail.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetThumbnail(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<IWICBitmapSource> pIThumbnail)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetThumbnail(ref pIThumbnail.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WritePixels(this ComPtr<IWICBitmapFrameEncode> thisVtbl, uint lineCount, uint cbStride, uint cbBufferSize, Span<byte> pbPixels)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WritePixels(lineCount, cbStride, cbBufferSize, ref pbPixels.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ComPtr<TI0> pIBitmapSource, Silk.NET.Maths.Rectangle<int>* prc) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteSource((IWICBitmapSource*) pIBitmapSource.Handle, prc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICBitmapFrameEncode> thisVtbl, IWICBitmapSource* pIBitmapSource, Span<Silk.NET.Maths.Rectangle<int>> prc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteSource(pIBitmapSource, ref prc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WriteSource<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ComPtr<TI0> pIBitmapSource, ref Silk.NET.Maths.Rectangle<int> prc) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteSource((IWICBitmapSource*) pIBitmapSource.Handle, ref prc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, Silk.NET.Maths.Rectangle<int>* prc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteSource(ref pIBitmapSource.GetPinnableReference(), prc);
    }

    /// <summary>To be documented.</summary>
    public static int WriteSource(this ComPtr<IWICBitmapFrameEncode> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, Span<Silk.NET.Maths.Rectangle<int>> prc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteSource(ref pIBitmapSource.GetPinnableReference(), ref prc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataQueryWriter<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl, ref ComPtr<TI0> ppIMetadataQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataQueryWriter((IWICMetadataQueryWriter**) ppIMetadataQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICBitmapFrameEncode> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
