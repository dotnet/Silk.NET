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

public unsafe static class ReleaseMarshalBuffersVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IReleaseMarshalBuffers> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IReleaseMarshalBuffers> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IReleaseMarshalBuffers> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IReleaseMarshalBuffers> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IReleaseMarshalBuffers> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IReleaseMarshalBuffers> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalBuffer(this ComPtr<IReleaseMarshalBuffers> thisVtbl, RPCOLEMessage* pMsg, uint dwFlags, Silk.NET.Core.Native.IUnknown* pChnl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, RPCOLEMessage*, uint, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pMsg, dwFlags, pChnl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalBuffer(this ComPtr<IReleaseMarshalBuffers> thisVtbl, RPCOLEMessage* pMsg, uint dwFlags, ref Silk.NET.Core.Native.IUnknown pChnl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pChnlPtr = &pChnl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, RPCOLEMessage*, uint, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pMsg, dwFlags, pChnlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalBuffer(this ComPtr<IReleaseMarshalBuffers> thisVtbl, ref RPCOLEMessage pMsg, uint dwFlags, Silk.NET.Core.Native.IUnknown* pChnl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, RPCOLEMessage*, uint, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pMsgPtr, dwFlags, pChnl);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseMarshalBuffer(this ComPtr<IReleaseMarshalBuffers> thisVtbl, ref RPCOLEMessage pMsg, uint dwFlags, ref Silk.NET.Core.Native.IUnknown pChnl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pChnlPtr = &pChnl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, RPCOLEMessage*, uint, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pMsgPtr, dwFlags, pChnlPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IReleaseMarshalBuffers> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IReleaseMarshalBuffers> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IReleaseMarshalBuffers> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalBuffer<TI0>(this ComPtr<IReleaseMarshalBuffers> thisVtbl, RPCOLEMessage* pMsg, uint dwFlags, ComPtr<TI0> pChnl) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReleaseMarshalBuffer(pMsg, dwFlags, (Silk.NET.Core.Native.IUnknown*) pChnl.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalBuffer(this ComPtr<IReleaseMarshalBuffers> thisVtbl, RPCOLEMessage* pMsg, uint dwFlags, Span<Silk.NET.Core.Native.IUnknown> pChnl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReleaseMarshalBuffer(pMsg, dwFlags, ref pChnl.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalBuffer(this ComPtr<IReleaseMarshalBuffers> thisVtbl, Span<RPCOLEMessage> pMsg, uint dwFlags, Silk.NET.Core.Native.IUnknown* pChnl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReleaseMarshalBuffer(ref pMsg.GetPinnableReference(), dwFlags, pChnl);
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseMarshalBuffer<TI0>(this ComPtr<IReleaseMarshalBuffers> thisVtbl, ref RPCOLEMessage pMsg, uint dwFlags, ComPtr<TI0> pChnl) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReleaseMarshalBuffer(ref pMsg, dwFlags, (Silk.NET.Core.Native.IUnknown*) pChnl.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseMarshalBuffer(this ComPtr<IReleaseMarshalBuffers> thisVtbl, Span<RPCOLEMessage> pMsg, uint dwFlags, Span<Silk.NET.Core.Native.IUnknown> pChnl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReleaseMarshalBuffer(ref pMsg.GetPinnableReference(), dwFlags, ref pChnl.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IReleaseMarshalBuffers> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
