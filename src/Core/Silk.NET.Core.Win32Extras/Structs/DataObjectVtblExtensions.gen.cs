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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class DataObjectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataObject> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataObject> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataObject> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataObject> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDataObject> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDataObject> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetcIn, STGMEDIUM* pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcIn, pmedium);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetcIn, ref STGMEDIUM pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (STGMEDIUM* pmediumPtr = &pmedium)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcIn, pmediumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetcIn, STGMEDIUM* pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcInPtr = &pformatetcIn)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcInPtr, pmedium);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetData(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetcIn, ref STGMEDIUM pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcInPtr = &pformatetcIn)
        {
            fixed (STGMEDIUM* pmediumPtr = &pmedium)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcInPtr, pmediumPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataHere(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, STGMEDIUM* pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetc, pmedium);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataHere(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, ref STGMEDIUM pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (STGMEDIUM* pmediumPtr = &pmedium)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetc, pmediumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataHere(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, STGMEDIUM* pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetcPtr, pmedium);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDataHere(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, ref STGMEDIUM pmedium)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            fixed (STGMEDIUM* pmediumPtr = &pmedium)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetcPtr, pmediumPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryGetData(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, int>)@this->LpVtbl[5])(@this, pformatetc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryGetData(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, int>)@this->LpVtbl[5])(@this, pformatetcPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCanonicalFormatEtc(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatectIn, FORMATETC* pformatetcOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectIn, pformatetcOut);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCanonicalFormatEtc(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatectIn, ref FORMATETC pformatetcOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcOutPtr = &pformatetcOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectIn, pformatetcOutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCanonicalFormatEtc(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatectIn, FORMATETC* pformatetcOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatectInPtr = &pformatectIn)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectInPtr, pformatetcOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCanonicalFormatEtc(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatectIn, ref FORMATETC pformatetcOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatectInPtr = &pformatectIn)
        {
            fixed (FORMATETC* pformatetcOutPtr = &pformatetcOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectInPtr, pformatetcOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetData(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, STGMEDIUM* pmedium, Silk.NET.Core.Bool32 fRelease)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetc, pmedium, fRelease);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetData(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, ref STGMEDIUM pmedium, Silk.NET.Core.Bool32 fRelease)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (STGMEDIUM* pmediumPtr = &pmedium)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetc, pmediumPtr, fRelease);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetData(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, STGMEDIUM* pmedium, Silk.NET.Core.Bool32 fRelease)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetcPtr, pmedium, fRelease);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetData(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, ref STGMEDIUM pmedium, Silk.NET.Core.Bool32 fRelease)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            fixed (STGMEDIUM* pmediumPtr = &pmedium)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetcPtr, pmediumPtr, fRelease);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumFormatEtc(this ComPtr<IDataObject> thisVtbl, uint dwDirection, IEnumFORMATETC** ppenumFormatEtc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint, IEnumFORMATETC**, int>)@this->LpVtbl[8])(@this, dwDirection, ppenumFormatEtc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumFormatEtc(this ComPtr<IDataObject> thisVtbl, uint dwDirection, ref IEnumFORMATETC* ppenumFormatEtc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumFORMATETC** ppenumFormatEtcPtr = &ppenumFormatEtc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint, IEnumFORMATETC**, int>)@this->LpVtbl[8])(@this, dwDirection, ppenumFormatEtcPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, IAdviseSink* pAdvSink, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSink, pdwConnection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, IAdviseSink* pAdvSink, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwConnectionPtr = &pdwConnection)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSink, pdwConnectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, ref IAdviseSink pAdvSink, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSinkPtr, pdwConnection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, ref IAdviseSink pAdvSink, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
        {
            fixed (uint* pdwConnectionPtr = &pdwConnection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSinkPtr, pdwConnectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, uint advf, IAdviseSink* pAdvSink, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSink, pdwConnection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, uint advf, IAdviseSink* pAdvSink, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            fixed (uint* pdwConnectionPtr = &pdwConnection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSink, pdwConnectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, uint advf, ref IAdviseSink pAdvSink, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSinkPtr, pdwConnection);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DAdvise(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, uint advf, ref IAdviseSink pAdvSink, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pformatetcPtr = &pformatetc)
        {
            fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSinkPtr, pdwConnectionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DUnadvise(this ComPtr<IDataObject> thisVtbl, uint dwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint, int>)@this->LpVtbl[10])(@this, dwConnection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumDAdvise(this ComPtr<IDataObject> thisVtbl, IEnumSTATDATA** ppenumAdvise)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, IEnumSTATDATA**, int>)@this->LpVtbl[11])(@this, ppenumAdvise);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumDAdvise(this ComPtr<IDataObject> thisVtbl, ref IEnumSTATDATA* ppenumAdvise)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumSTATDATA** ppenumAdvisePtr = &ppenumAdvise)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, IEnumSTATDATA**, int>)@this->LpVtbl[11])(@this, ppenumAdvisePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDataObject> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataObject> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataObject> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetcIn, Span<STGMEDIUM> pmedium)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(pformatetcIn, ref pmedium.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetcIn, STGMEDIUM* pmedium)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(ref pformatetcIn.GetPinnableReference(), pmedium);
    }

    /// <summary>To be documented.</summary>
    public static int GetData(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetcIn, Span<STGMEDIUM> pmedium)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(ref pformatetcIn.GetPinnableReference(), ref pmedium.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataHere(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, Span<STGMEDIUM> pmedium)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDataHere(pformatetc, ref pmedium.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataHere(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, STGMEDIUM* pmedium)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDataHere(ref pformatetc.GetPinnableReference(), pmedium);
    }

    /// <summary>To be documented.</summary>
    public static int GetDataHere(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, Span<STGMEDIUM> pmedium)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDataHere(ref pformatetc.GetPinnableReference(), ref pmedium.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int QueryGetData(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryGetData(ref pformatetc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCanonicalFormatEtc(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatectIn, Span<FORMATETC> pformatetcOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCanonicalFormatEtc(pformatectIn, ref pformatetcOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCanonicalFormatEtc(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatectIn, FORMATETC* pformatetcOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCanonicalFormatEtc(ref pformatectIn.GetPinnableReference(), pformatetcOut);
    }

    /// <summary>To be documented.</summary>
    public static int GetCanonicalFormatEtc(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatectIn, Span<FORMATETC> pformatetcOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCanonicalFormatEtc(ref pformatectIn.GetPinnableReference(), ref pformatetcOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetData(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, Span<STGMEDIUM> pmedium, Silk.NET.Core.Bool32 fRelease)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetData(pformatetc, ref pmedium.GetPinnableReference(), fRelease);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetData(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, STGMEDIUM* pmedium, Silk.NET.Core.Bool32 fRelease)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetData(ref pformatetc.GetPinnableReference(), pmedium, fRelease);
    }

    /// <summary>To be documented.</summary>
    public static int SetData(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, Span<STGMEDIUM> pmedium, Silk.NET.Core.Bool32 fRelease)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetData(ref pformatetc.GetPinnableReference(), ref pmedium.GetPinnableReference(), fRelease);
    }

    /// <summary>To be documented.</summary>
    public static int EnumFormatEtc<TI0>(this ComPtr<IDataObject> thisVtbl, uint dwDirection, ref ComPtr<TI0> ppenumFormatEtc) where TI0 : unmanaged, IComVtbl<IEnumFORMATETC>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumFormatEtc(dwDirection, (IEnumFORMATETC**) ppenumFormatEtc.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise<TI0>(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, ComPtr<TI0> pAdvSink, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DAdvise(pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, IAdviseSink* pAdvSink, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DAdvise(pformatetc, advf, pAdvSink, ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise<TI0>(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, ComPtr<TI0> pAdvSink, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DAdvise(pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, Span<IAdviseSink> pAdvSink, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DAdvise(pformatetc, advf, ref pAdvSink.GetPinnableReference(), pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, FORMATETC* pformatetc, uint advf, Span<IAdviseSink> pAdvSink, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DAdvise(pformatetc, advf, ref pAdvSink.GetPinnableReference(), ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, uint advf, IAdviseSink* pAdvSink, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DAdvise(ref pformatetc.GetPinnableReference(), advf, pAdvSink, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise<TI0>(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, uint advf, ComPtr<TI0> pAdvSink, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DAdvise(ref pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, uint advf, IAdviseSink* pAdvSink, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DAdvise(ref pformatetc.GetPinnableReference(), advf, pAdvSink, ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DAdvise<TI0>(this ComPtr<IDataObject> thisVtbl, ref FORMATETC pformatetc, uint advf, ComPtr<TI0> pAdvSink, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DAdvise(ref pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DAdvise(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, uint advf, Span<IAdviseSink> pAdvSink, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DAdvise(ref pformatetc.GetPinnableReference(), advf, ref pAdvSink.GetPinnableReference(), pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static int DAdvise(this ComPtr<IDataObject> thisVtbl, Span<FORMATETC> pformatetc, uint advf, Span<IAdviseSink> pAdvSink, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DAdvise(ref pformatetc.GetPinnableReference(), advf, ref pAdvSink.GetPinnableReference(), ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumDAdvise<TI0>(this ComPtr<IDataObject> thisVtbl, ref ComPtr<TI0> ppenumAdvise) where TI0 : unmanaged, IComVtbl<IEnumSTATDATA>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumDAdvise((IEnumSTATDATA**) ppenumAdvise.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDataObject> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
