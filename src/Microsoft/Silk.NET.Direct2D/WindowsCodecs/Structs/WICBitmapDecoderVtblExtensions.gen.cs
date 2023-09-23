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

public unsafe static class WICBitmapDecoderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapDecoder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapDecoder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapDecoder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapDecoder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICBitmapDecoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICBitmapDecoder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryCapability(this ComPtr<IWICBitmapDecoder> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, uint* pdwCapability)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStream, pdwCapability);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryCapability(this ComPtr<IWICBitmapDecoder> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, ref uint pdwCapability)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCapabilityPtr = &pdwCapability)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStream, pdwCapabilityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryCapability(this ComPtr<IWICBitmapDecoder> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, uint* pdwCapability)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStreamPtr, pdwCapability);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryCapability(this ComPtr<IWICBitmapDecoder> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref uint pdwCapability)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            fixed (uint* pdwCapabilityPtr = &pdwCapability)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, uint*, int>)@this->LpVtbl[3])(@this, pIStreamPtr, pdwCapabilityPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICBitmapDecoder> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, DecodeOptions cacheOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, DecodeOptions, int>)@this->LpVtbl[4])(@this, pIStream, cacheOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICBitmapDecoder> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, DecodeOptions cacheOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Silk.NET.Core.Win32Extras.IStream*, DecodeOptions, int>)@this->LpVtbl[4])(@this, pIStreamPtr, cacheOptions);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormat(this ComPtr<IWICBitmapDecoder> thisVtbl, Guid* pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, int>)@this->LpVtbl[5])(@this, pguidContainerFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICBitmapDecoder> thisVtbl, ref Guid pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, int>)@this->LpVtbl[5])(@this, pguidContainerFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderInfo(this ComPtr<IWICBitmapDecoder> thisVtbl, IWICBitmapDecoderInfo** ppIDecoderInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int>)@this->LpVtbl[6])(@this, ppIDecoderInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderInfo(this ComPtr<IWICBitmapDecoder> thisVtbl, ref IWICBitmapDecoderInfo* ppIDecoderInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapDecoderInfo** ppIDecoderInfoPtr = &ppIDecoderInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int>)@this->LpVtbl[6])(@this, ppIDecoderInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPalette(this ComPtr<IWICBitmapDecoder> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICBitmapDecoder> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICPalette*, int>)@this->LpVtbl[7])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryReader(this ComPtr<IWICBitmapDecoder> thisVtbl, IWICMetadataQueryReader** ppIMetadataQueryReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryReader(this ComPtr<IWICBitmapDecoder> thisVtbl, ref IWICMetadataQueryReader* ppIMetadataQueryReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryReader** ppIMetadataQueryReaderPtr = &ppIMetadataQueryReader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreview(this ComPtr<IWICBitmapDecoder> thisVtbl, IWICBitmapSource** ppIBitmapSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[9])(@this, ppIBitmapSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPreview(this ComPtr<IWICBitmapDecoder> thisVtbl, ref IWICBitmapSource* ppIBitmapSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource** ppIBitmapSourcePtr = &ppIBitmapSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[9])(@this, ppIBitmapSourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContexts, pcActualCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcActualCountPtr = &pcActualCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContexts, pcActualCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContextsPtr, pcActualCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
        {
            fixed (uint* pcActualCountPtr = &pcActualCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[10])(@this, cCount, ppIColorContextsPtr, pcActualCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetThumbnail(this ComPtr<IWICBitmapDecoder> thisVtbl, IWICBitmapSource** ppIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[11])(@this, ppIThumbnail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetThumbnail(this ComPtr<IWICBitmapDecoder> thisVtbl, ref IWICBitmapSource* ppIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource** ppIThumbnailPtr = &ppIThumbnail)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)@this->LpVtbl[11])(@this, ppIThumbnailPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameCount(this ComPtr<IWICBitmapDecoder> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint*, int>)@this->LpVtbl[12])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameCount(this ComPtr<IWICBitmapDecoder> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint*, int>)@this->LpVtbl[12])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrame(this ComPtr<IWICBitmapDecoder> thisVtbl, uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[13])(@this, index, ppIBitmapFrame);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrame(this ComPtr<IWICBitmapDecoder> thisVtbl, uint index, ref IWICBitmapFrameDecode* ppIBitmapFrame)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapFrameDecode** ppIBitmapFramePtr = &ppIBitmapFrame)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[13])(@this, index, ppIBitmapFramePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryCapability<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ComPtr<TI0> pIStream, uint* pdwCapability) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->QueryCapability((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pdwCapability);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryCapability(this ComPtr<IWICBitmapDecoder> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, Span<uint> pdwCapability)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryCapability(pIStream, ref pdwCapability.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int QueryCapability<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ComPtr<TI0> pIStream, ref uint pdwCapability) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->QueryCapability((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pdwCapability);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryCapability(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, uint* pdwCapability)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryCapability(ref pIStream.GetPinnableReference(), pdwCapability);
    }

    /// <summary>To be documented.</summary>
    public static int QueryCapability(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Span<uint> pdwCapability)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryCapability(ref pIStream.GetPinnableReference(), ref pdwCapability.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ComPtr<TI0> pIStream, DecodeOptions cacheOptions) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, cacheOptions);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, DecodeOptions cacheOptions)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIStream.GetPinnableReference(), cacheOptions);
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<Guid> pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormat(ref pguidContainerFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDecoderInfo<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ref ComPtr<TI0> ppIDecoderInfo) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDecoderInfo((IWICBitmapDecoderInfo**) ppIDecoderInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataQueryReader<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ref ComPtr<TI0> ppIMetadataQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataQueryReader((IWICMetadataQueryReader**) ppIMetadataQueryReader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetPreview<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ref ComPtr<TI0> ppIBitmapSource) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPreview((IWICBitmapSource**) ppIBitmapSource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, Span<uint> pcActualCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorContexts(cCount, ppIColorContexts, ref pcActualCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetColorContexts<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICBitmapDecoder> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, Span<uint> pcActualCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorContexts(cCount, ref ppIColorContexts, ref pcActualCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetThumbnail<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, ref ComPtr<TI0> ppIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetThumbnail((IWICBitmapSource**) ppIThumbnail.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameCount(this ComPtr<IWICBitmapDecoder> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrame<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl, uint index, ref ComPtr<TI0> ppIBitmapFrame) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFrame(index, (IWICBitmapFrameDecode**) ppIBitmapFrame.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICBitmapDecoder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
