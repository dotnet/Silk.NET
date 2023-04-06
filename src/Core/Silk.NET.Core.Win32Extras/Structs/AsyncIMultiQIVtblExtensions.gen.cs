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

public unsafe static class AsyncIMultiQIVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIMultiQI> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIMultiQI> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIMultiQI> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIMultiQI> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<AsyncIMultiQI> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<AsyncIMultiQI> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginQueryMultipleInterfaces(this ComPtr<AsyncIMultiQI> thisVtbl, uint cMQIs, MultiQi* pMQIs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint, MultiQi*, int>)@this->LpVtbl[3])(@this, cMQIs, pMQIs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginQueryMultipleInterfaces(this ComPtr<AsyncIMultiQI> thisVtbl, uint cMQIs, ref MultiQi pMQIs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MultiQi* pMQIsPtr = &pMQIs)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint, MultiQi*, int>)@this->LpVtbl[3])(@this, cMQIs, pMQIsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishQueryMultipleInterfaces(this ComPtr<AsyncIMultiQI> thisVtbl, MultiQi* pMQIs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, MultiQi*, int>)@this->LpVtbl[4])(@this, pMQIs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishQueryMultipleInterfaces(this ComPtr<AsyncIMultiQI> thisVtbl, ref MultiQi pMQIs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MultiQi* pMQIsPtr = &pMQIs)
        {
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, MultiQi*, int>)@this->LpVtbl[4])(@this, pMQIsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<AsyncIMultiQI> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIMultiQI> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIMultiQI> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int BeginQueryMultipleInterfaces(this ComPtr<AsyncIMultiQI> thisVtbl, uint cMQIs, Span<MultiQi> pMQIs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginQueryMultipleInterfaces(cMQIs, ref pMQIs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FinishQueryMultipleInterfaces(this ComPtr<AsyncIMultiQI> thisVtbl, Span<MultiQi> pMQIs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FinishQueryMultipleInterfaces(ref pMQIs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<AsyncIMultiQI> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
