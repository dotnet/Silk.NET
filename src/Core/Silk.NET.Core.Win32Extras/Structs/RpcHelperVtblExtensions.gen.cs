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

public unsafe static class RpcHelperVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcHelper> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcHelper> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcHelper> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcHelper> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRpcHelper> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRpcHelper> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDCOMProtocolVersion(this ComPtr<IRpcHelper> thisVtbl, uint* pComVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, uint*, int>)@this->LpVtbl[3])(@this, pComVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDCOMProtocolVersion(this ComPtr<IRpcHelper> thisVtbl, ref uint pComVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pComVersionPtr = &pComVersion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, uint*, int>)@this->LpVtbl[3])(@this, pComVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIIDFromOBJREF(this ComPtr<IRpcHelper> thisVtbl, void* pObjRef, Guid** piid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, void*, Guid**, int>)@this->LpVtbl[4])(@this, pObjRef, piid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIIDFromOBJREF(this ComPtr<IRpcHelper> thisVtbl, void* pObjRef, ref Guid* piid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid** piidPtr = &piid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, void*, Guid**, int>)@this->LpVtbl[4])(@this, pObjRef, piidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIIDFromOBJREF<T0>(this ComPtr<IRpcHelper> thisVtbl, ref T0 pObjRef, Guid** piid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pObjRefPtr = &pObjRef)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, void*, Guid**, int>)@this->LpVtbl[4])(@this, pObjRefPtr, piid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIIDFromOBJREF<T0>(this ComPtr<IRpcHelper> thisVtbl, ref T0 pObjRef, ref Guid* piid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pObjRefPtr = &pObjRef)
        {
            fixed (Guid** piidPtr = &piid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcHelper*, void*, Guid**, int>)@this->LpVtbl[4])(@this, pObjRefPtr, piidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRpcHelper> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcHelper> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcHelper> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDCOMProtocolVersion(this ComPtr<IRpcHelper> thisVtbl, Span<uint> pComVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDCOMProtocolVersion(ref pComVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIIDFromOBJREF<T0>(this ComPtr<IRpcHelper> thisVtbl, Span<T0> pObjRef, Guid** piid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIIDFromOBJREF(ref pObjRef.GetPinnableReference(), piid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIIDFromOBJREF<T0>(this ComPtr<IRpcHelper> thisVtbl, Span<T0> pObjRef, ref Guid* piid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIIDFromOBJREF(ref pObjRef.GetPinnableReference(), ref piid);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRpcHelper> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
