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

public unsafe static class StdMarshalInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStdMarshalInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStdMarshalInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStdMarshalInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStdMarshalInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IStdMarshalInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IStdMarshalInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassForHandler(this ComPtr<IStdMarshalInfo> thisVtbl, uint dwDestContext, void* pvDestContext, Guid* pClsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContext, pClsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassForHandler(this ComPtr<IStdMarshalInfo> thisVtbl, uint dwDestContext, void* pvDestContext, ref Guid pClsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClsidPtr = &pClsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContext, pClsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassForHandler<T0>(this ComPtr<IStdMarshalInfo> thisVtbl, uint dwDestContext, ref T0 pvDestContext, Guid* pClsid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContextPtr, pClsid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClassForHandler<T0>(this ComPtr<IStdMarshalInfo> thisVtbl, uint dwDestContext, ref T0 pvDestContext, ref Guid pClsid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            fixed (Guid* pClsidPtr = &pClsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStdMarshalInfo*, uint, void*, Guid*, int>)@this->LpVtbl[3])(@this, dwDestContext, pvDestContextPtr, pClsidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IStdMarshalInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStdMarshalInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStdMarshalInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassForHandler(this ComPtr<IStdMarshalInfo> thisVtbl, uint dwDestContext, void* pvDestContext, Span<Guid> pClsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassForHandler(dwDestContext, pvDestContext, ref pClsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassForHandler<T0>(this ComPtr<IStdMarshalInfo> thisVtbl, uint dwDestContext, Span<T0> pvDestContext, Guid* pClsid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassForHandler(dwDestContext, ref pvDestContext.GetPinnableReference(), pClsid);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassForHandler<T0>(this ComPtr<IStdMarshalInfo> thisVtbl, uint dwDestContext, Span<T0> pvDestContext, Span<Guid> pClsid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassForHandler(dwDestContext, ref pvDestContext.GetPinnableReference(), ref pClsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IStdMarshalInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
