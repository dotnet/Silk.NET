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

public unsafe static class WICMetadataBlockWriterVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICMetadataBlockWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICMetadataBlockWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormat(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Guid* pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ref Guid pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCount(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint* pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint*, int>)@this->LpVtbl[4])(@this, pcCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCount(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ref uint pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcCountPtr = &pcCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint*, int>)@this->LpVtbl[4])(@this, pcCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReaderByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, IWICMetadataReader** ppIMetadataReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)@this->LpVtbl[5])(@this, nIndex, ppIMetadataReader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReaderByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, ref IWICMetadataReader* ppIMetadataReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataReader** ppIMetadataReaderPtr = &ppIMetadataReader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)@this->LpVtbl[5])(@this, nIndex, ppIMetadataReaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadata);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ref Silk.NET.Core.Win32Extras.IEnumUnknown* ppIEnumMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumMetadataPtr = &ppIEnumMetadata)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromBlockReader(this ComPtr<IWICMetadataBlockWriter> thisVtbl, IWICMetadataBlockReader* pIMDBlockReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)@this->LpVtbl[7])(@this, pIMDBlockReader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromBlockReader(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ref IWICMetadataBlockReader pIMDBlockReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataBlockReader* pIMDBlockReaderPtr = &pIMDBlockReader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)@this->LpVtbl[7])(@this, pIMDBlockReaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWriterByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, IWICMetadataWriter** ppIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[8])(@this, nIndex, ppIMetadataWriter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWriterByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, ref IWICMetadataWriter* ppIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataWriter** ppIMetadataWriterPtr = &ppIMetadataWriter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[8])(@this, nIndex, ppIMetadataWriterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddWriter(this ComPtr<IWICMetadataBlockWriter> thisVtbl, IWICMetadataWriter* pIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)@this->LpVtbl[9])(@this, pIMetadataWriter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddWriter(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ref IWICMetadataWriter pIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataWriter* pIMetadataWriterPtr = &pIMetadataWriter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)@this->LpVtbl[9])(@this, pIMetadataWriterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetWriterByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, IWICMetadataWriter* pIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)@this->LpVtbl[10])(@this, nIndex, pIMetadataWriter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWriterByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, ref IWICMetadataWriter pIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataWriter* pIMetadataWriterPtr = &pIMetadataWriter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)@this->LpVtbl[10])(@this, nIndex, pIMetadataWriterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveWriterByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, int>)@this->LpVtbl[11])(@this, nIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICMetadataBlockWriter> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Span<Guid> pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormat(ref pguidContainerFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCount(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Span<uint> pcCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCount(ref pcCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetReaderByIndex<TI0>(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, ref ComPtr<TI0> ppIMetadataReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetReaderByIndex(nIndex, (IWICMetadataReader**) ppIMetadataReader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromBlockReader<TI0>(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ComPtr<TI0> pIMDBlockReader) where TI0 : unmanaged, IComVtbl<IWICMetadataBlockReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InitializeFromBlockReader((IWICMetadataBlockReader*) pIMDBlockReader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromBlockReader(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Span<IWICMetadataBlockReader> pIMDBlockReader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromBlockReader(ref pIMDBlockReader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetWriterByIndex<TI0>(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, ref ComPtr<TI0> ppIMetadataWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetWriterByIndex(nIndex, (IWICMetadataWriter**) ppIMetadataWriter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int AddWriter<TI0>(this ComPtr<IWICMetadataBlockWriter> thisVtbl, ComPtr<TI0> pIMetadataWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddWriter((IWICMetadataWriter*) pIMetadataWriter.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddWriter(this ComPtr<IWICMetadataBlockWriter> thisVtbl, Span<IWICMetadataWriter> pIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddWriter(ref pIMetadataWriter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetWriterByIndex<TI0>(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, ComPtr<TI0> pIMetadataWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetWriterByIndex(nIndex, (IWICMetadataWriter*) pIMetadataWriter.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetWriterByIndex(this ComPtr<IWICMetadataBlockWriter> thisVtbl, uint nIndex, Span<IWICMetadataWriter> pIMetadataWriter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetWriterByIndex(nIndex, ref pIMetadataWriter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICMetadataBlockWriter> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
