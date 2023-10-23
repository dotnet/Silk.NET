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

public unsafe static class AsyncIAdviseSink2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIAdviseSink2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIAdviseSink2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIAdviseSink2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIAdviseSink2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmed);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, FORMATETC* pFormatetc, ref STGMEDIUM pStgmed)
    {
        var @this = thisVtbl.Handle;
        fixed (STGMEDIUM* pStgmedPtr = &pStgmed)
        {
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmedPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, ref FORMATETC pFormatetc, STGMEDIUM* pStgmed)
    {
        var @this = thisVtbl.Handle;
        fixed (FORMATETC* pFormatetcPtr = &pFormatetc)
        {
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmed);
        }
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, ref FORMATETC pFormatetc, ref STGMEDIUM pStgmed)
    {
        var @this = thisVtbl.Handle;
        fixed (FORMATETC* pFormatetcPtr = &pFormatetc)
        {
            fixed (STGMEDIUM* pStgmedPtr = &pStgmed)
            {
                ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmedPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void FinishOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnViewChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, uint dwAspect, int lindex)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, uint, int, void>)@this->LpVtbl[5])(@this, dwAspect, lindex);
    }

    /// <summary>To be documented.</summary>
    public static void FinishOnViewChange(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[6])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginOnRename(this ComPtr<AsyncIAdviseSink2> thisVtbl, IMoniker* pmk)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[7])(@this, pmk);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnRename(this ComPtr<AsyncIAdviseSink2> thisVtbl, ref IMoniker pmk)
    {
        var @this = thisVtbl.Handle;
        fixed (IMoniker* pmkPtr = &pmk)
        {
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[7])(@this, pmkPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FinishOnRename(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[8])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnSave(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void FinishOnSave(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[10])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnClose(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[11])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void FinishOnClose(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[12])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginOnLinkSrcChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, IMoniker* pmk)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[13])(@this, pmk);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnLinkSrcChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, ref IMoniker pmk)
    {
        var @this = thisVtbl.Handle;
        fixed (IMoniker* pmkPtr = &pmk)
        {
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[13])(@this, pmkPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void FinishOnLinkSrcChange(this ComPtr<AsyncIAdviseSink2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[14])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<AsyncIAdviseSink2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIAdviseSink2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIAdviseSink2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, FORMATETC* pFormatetc, Span<STGMEDIUM> pStgmed)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginOnDataChange(pFormatetc, ref pStgmed.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, Span<FORMATETC> pFormatetc, STGMEDIUM* pStgmed)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginOnDataChange(ref pFormatetc.GetPinnableReference(), pStgmed);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnDataChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, Span<FORMATETC> pFormatetc, Span<STGMEDIUM> pStgmed)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginOnDataChange(ref pFormatetc.GetPinnableReference(), ref pStgmed.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnRename<TI0>(this ComPtr<AsyncIAdviseSink2> thisVtbl, ComPtr<TI0> pmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->BeginOnRename((IMoniker*) pmk.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnRename(this ComPtr<AsyncIAdviseSink2> thisVtbl, Span<IMoniker> pmk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginOnRename(ref pmk.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnLinkSrcChange<TI0>(this ComPtr<AsyncIAdviseSink2> thisVtbl, ComPtr<TI0> pmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->BeginOnLinkSrcChange((IMoniker*) pmk.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void BeginOnLinkSrcChange(this ComPtr<AsyncIAdviseSink2> thisVtbl, Span<IMoniker> pmk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginOnLinkSrcChange(ref pmk.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<AsyncIAdviseSink2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
