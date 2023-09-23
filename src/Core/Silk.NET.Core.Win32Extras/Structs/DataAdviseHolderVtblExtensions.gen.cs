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

public unsafe static class DataAdviseHolderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataAdviseHolder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataAdviseHolder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataAdviseHolder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataAdviseHolder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDataAdviseHolder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDataAdviseHolder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvise, pdwConnection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwConnectionPtr = &pdwConnection)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvise, pdwConnectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IAdviseSink* pAdvisePtr = &pAdvise)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvisePtr, pdwConnection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IAdviseSink* pAdvisePtr = &pAdvise)
        {
            fixed (uint* pdwConnectionPtr = &pdwConnection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvisePtr, pdwConnectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pFetcPtr = &pFetc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvise, pdwConnection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pFetcPtr = &pFetc)
        {
            fixed (uint* pdwConnectionPtr = &pdwConnection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvise, pdwConnectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pFetcPtr = &pFetc)
        {
            fixed (IAdviseSink* pAdvisePtr = &pAdvise)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvisePtr, pdwConnection);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* pFetcPtr = &pFetc)
        {
            fixed (IAdviseSink* pAdvisePtr = &pAdvise)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvisePtr, pdwConnectionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvise, pdwConnection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            fixed (uint* pdwConnectionPtr = &pdwConnection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvise, pdwConnectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            fixed (IAdviseSink* pAdvisePtr = &pAdvise)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvisePtr, pdwConnection);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            fixed (IAdviseSink* pAdvisePtr = &pAdvise)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvisePtr, pdwConnectionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvise, pdwConnection);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvise, pdwConnectionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvisePtr, pdwConnection);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                {
                    fixed (uint* pdwConnectionPtr = &pdwConnection)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvisePtr, pdwConnectionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Unadvise(this ComPtr<IDataAdviseHolder> thisVtbl, uint dwConnection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, uint, int>)@this->LpVtbl[4])(@this, dwConnection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdvise(this ComPtr<IDataAdviseHolder> thisVtbl, IEnumSTATDATA** ppenumAdvise)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IEnumSTATDATA**, int>)@this->LpVtbl[5])(@this, ppenumAdvise);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdvise(this ComPtr<IDataAdviseHolder> thisVtbl, ref IEnumSTATDATA* ppenumAdvise)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumSTATDATA** ppenumAdvisePtr = &ppenumAdvise)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IEnumSTATDATA**, int>)@this->LpVtbl[5])(@this, ppenumAdvisePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendOnDataChange(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, uint dwReserved, uint advf)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, uint, uint, int>)@this->LpVtbl[6])(@this, pDataObject, dwReserved, advf);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SendOnDataChange(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, uint dwReserved, uint advf)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDataObject* pDataObjectPtr = &pDataObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, uint, uint, int>)@this->LpVtbl[6])(@this, pDataObjectPtr, dwReserved, advf);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataAdviseHolder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDataAdviseHolder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0, TI1>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI1> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pDataObject, pFetc, advf, pAdvise, ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0, TI1>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI1> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, FORMATETC* pFetc, uint advf, Span<IAdviseSink> pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pDataObject, pFetc, advf, ref pAdvise.GetPinnableReference(), pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, ref pAdvise, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, FORMATETC* pFetc, uint advf, Span<IAdviseSink> pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pDataObject, pFetc, advf, ref pAdvise.GetPinnableReference(), ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, ref pAdvise, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, Span<FORMATETC> pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pDataObject, ref pFetc.GetPinnableReference(), advf, pAdvise, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0, TI1>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI1> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, Span<FORMATETC> pFetc, uint advf, IAdviseSink* pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pDataObject, ref pFetc.GetPinnableReference(), advf, pAdvise, ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Advise<TI0, TI1>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI1> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, Span<FORMATETC> pFetc, uint advf, Span<IAdviseSink> pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pDataObject, ref pFetc.GetPinnableReference(), advf, ref pAdvise.GetPinnableReference(), pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, ref pAdvise, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, IDataObject* pDataObject, Span<FORMATETC> pFetc, uint advf, Span<IAdviseSink> pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pDataObject, ref pFetc.GetPinnableReference(), advf, ref pAdvise.GetPinnableReference(), ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, ref pAdvise, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), pFetc, advf, pAdvise, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI0> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise(ref pDataObject, pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), pFetc, advf, pAdvise, ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI0> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise(ref pDataObject, pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, FORMATETC* pFetc, uint advf, Span<IAdviseSink> pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), pFetc, advf, ref pAdvise.GetPinnableReference(), pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, FORMATETC* pFetc, uint advf, Span<IAdviseSink> pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), pFetc, advf, ref pAdvise.GetPinnableReference(), ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, Span<FORMATETC> pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), ref pFetc.GetPinnableReference(), advf, pAdvise, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI0> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise(ref pDataObject, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, Span<FORMATETC> pFetc, uint advf, IAdviseSink* pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), ref pFetc.GetPinnableReference(), advf, pAdvise, ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Advise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI0> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise(ref pDataObject, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, Span<FORMATETC> pFetc, uint advf, Span<IAdviseSink> pAdvise, uint* pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), ref pFetc.GetPinnableReference(), advf, ref pAdvise.GetPinnableReference(), pdwConnection);
    }

    /// <summary>To be documented.</summary>
    public static int Advise(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, Span<FORMATETC> pFetc, uint advf, Span<IAdviseSink> pAdvise, Span<uint> pdwConnection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pDataObject.GetPinnableReference(), ref pFetc.GetPinnableReference(), advf, ref pAdvise.GetPinnableReference(), ref pdwConnection.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdvise<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ref ComPtr<TI0> ppenumAdvise) where TI0 : unmanaged, IComVtbl<IEnumSTATDATA>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumAdvise((IEnumSTATDATA**) ppenumAdvise.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SendOnDataChange<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl, ComPtr<TI0> pDataObject, uint dwReserved, uint advf) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SendOnDataChange((IDataObject*) pDataObject.Handle, dwReserved, advf);
    }

    /// <summary>To be documented.</summary>
    public static int SendOnDataChange(this ComPtr<IDataAdviseHolder> thisVtbl, Span<IDataObject> pDataObject, uint dwReserved, uint advf)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendOnDataChange(ref pDataObject.GetPinnableReference(), dwReserved, advf);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDataAdviseHolder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
