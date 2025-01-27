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

public unsafe static class WICBitmapEncoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICBitmapEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICBitmapEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICBitmapEncoder> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, BitmapEncoderCacheOption cacheOption)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Silk.NET.Core.Win32Extras.IStream*, BitmapEncoderCacheOption, int>)@this->LpVtbl[3])(@this, pIStream, cacheOption);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICBitmapEncoder> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, BitmapEncoderCacheOption cacheOption)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Silk.NET.Core.Win32Extras.IStream*, BitmapEncoderCacheOption, int>)@this->LpVtbl[3])(@this, pIStreamPtr, cacheOption);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormat(this ComPtr<IWICBitmapEncoder> thisVtbl, Guid* pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, int>)@this->LpVtbl[4])(@this, pguidContainerFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICBitmapEncoder> thisVtbl, ref Guid pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, Guid*, int>)@this->LpVtbl[4])(@this, pguidContainerFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoderInfo(this ComPtr<IWICBitmapEncoder> thisVtbl, IWICBitmapEncoderInfo** ppIEncoderInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapEncoderInfo**, int>)@this->LpVtbl[5])(@this, ppIEncoderInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoderInfo(this ComPtr<IWICBitmapEncoder> thisVtbl, ref IWICBitmapEncoderInfo* ppIEncoderInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapEncoderInfo** ppIEncoderInfoPtr = &ppIEncoderInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapEncoderInfo**, int>)@this->LpVtbl[5])(@this, ppIEncoderInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetColorContexts(this ComPtr<IWICBitmapEncoder> thisVtbl, uint cCount, IWICColorContext** ppIColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint, IWICColorContext**, int>)@this->LpVtbl[6])(@this, cCount, ppIColorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetColorContexts(this ComPtr<IWICBitmapEncoder> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextPtr = &ppIColorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, uint, IWICColorContext**, int>)@this->LpVtbl[6])(@this, cCount, ppIColorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPalette(this ComPtr<IWICBitmapEncoder> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPalette(this ComPtr<IWICBitmapEncoder> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetThumbnail(this ComPtr<IWICBitmapEncoder> thisVtbl, IWICBitmapSource* pIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[8])(@this, pIThumbnail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetThumbnail(this ComPtr<IWICBitmapEncoder> thisVtbl, ref IWICBitmapSource pIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIThumbnailPtr = &pIThumbnail)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[8])(@this, pIThumbnailPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPreview(this ComPtr<IWICBitmapEncoder> thisVtbl, IWICBitmapSource* pIPreview)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIPreview);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPreview(this ComPtr<IWICBitmapEncoder> thisVtbl, ref IWICBitmapSource pIPreview)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIPreviewPtr = &pIPreview)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapSource*, int>)@this->LpVtbl[9])(@this, pIPreviewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICBitmapEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, Silk.NET.Core.Win32Extras.IPropertyBag2** ppIEncoderOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[10])(@this, ppIFrameEncode, ppIEncoderOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICBitmapEncoder> thisVtbl, IWICBitmapFrameEncode** ppIFrameEncode, ref Silk.NET.Core.Win32Extras.IPropertyBag2* ppIEncoderOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IPropertyBag2** ppIEncoderOptionsPtr = &ppIEncoderOptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[10])(@this, ppIFrameEncode, ppIEncoderOptionsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICBitmapEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, Silk.NET.Core.Win32Extras.IPropertyBag2** ppIEncoderOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[10])(@this, ppIFrameEncodePtr, ppIEncoderOptions);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame(this ComPtr<IWICBitmapEncoder> thisVtbl, ref IWICBitmapFrameEncode* ppIFrameEncode, ref Silk.NET.Core.Win32Extras.IPropertyBag2* ppIEncoderOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
        {
            fixed (Silk.NET.Core.Win32Extras.IPropertyBag2** ppIEncoderOptionsPtr = &ppIEncoderOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICBitmapFrameEncode**, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[10])(@this, ppIFrameEncodePtr, ppIEncoderOptionsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IWICBitmapEncoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, int>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryWriter(this ComPtr<IWICBitmapEncoder> thisVtbl, IWICMetadataQueryWriter** ppIMetadataQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[12])(@this, ppIMetadataQueryWriter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryWriter(this ComPtr<IWICBitmapEncoder> thisVtbl, ref IWICMetadataQueryWriter* ppIMetadataQueryWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryWriter** ppIMetadataQueryWriterPtr = &ppIMetadataQueryWriter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoder*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[12])(@this, ppIMetadataQueryWriterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ComPtr<TI0> pIStream, BitmapEncoderCacheOption cacheOption) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, cacheOption);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICBitmapEncoder> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, BitmapEncoderCacheOption cacheOption)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIStream.GetPinnableReference(), cacheOption);
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICBitmapEncoder> thisVtbl, Span<Guid> pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormat(ref pguidContainerFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetEncoderInfo<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ref ComPtr<TI0> ppIEncoderInfo) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoderInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEncoderInfo((IWICBitmapEncoderInfo**) ppIEncoderInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetColorContexts<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetColorContexts(cCount, (IWICColorContext**) ppIColorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetPalette<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPalette(this ComPtr<IWICBitmapEncoder> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetThumbnail<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ComPtr<TI0> pIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetThumbnail((IWICBitmapSource*) pIThumbnail.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetThumbnail(this ComPtr<IWICBitmapEncoder> thisVtbl, Span<IWICBitmapSource> pIThumbnail)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetThumbnail(ref pIThumbnail.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetPreview<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ComPtr<TI0> pIPreview) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPreview((IWICBitmapSource*) pIPreview.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPreview(this ComPtr<IWICBitmapEncoder> thisVtbl, Span<IWICBitmapSource> pIPreview)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPreview(ref pIPreview.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, Silk.NET.Core.Win32Extras.IPropertyBag2** ppIEncoderOptions) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ppIEncoderOptions);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNewFrame<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ref ComPtr<TI0> ppIFrameEncode, ref Silk.NET.Core.Win32Extras.IPropertyBag2* ppIEncoderOptions) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref ppIEncoderOptions);
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataQueryWriter<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl, ref ComPtr<TI0> ppIMetadataQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataQueryWriter((IWICMetadataQueryWriter**) ppIMetadataQueryWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICBitmapEncoder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
