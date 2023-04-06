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

public unsafe static class RpcSyntaxNegotiateVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRpcSyntaxNegotiate> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRpcSyntaxNegotiate> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateSyntax(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, RPCOLEMessage* pMsg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, RPCOLEMessage*, int>)@this->LpVtbl[3])(@this, pMsg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateSyntax(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, ref RPCOLEMessage pMsg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcSyntaxNegotiate*, RPCOLEMessage*, int>)@this->LpVtbl[3])(@this, pMsgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateSyntax(this ComPtr<IRpcSyntaxNegotiate> thisVtbl, Span<RPCOLEMessage> pMsg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->NegotiateSyntax(ref pMsg.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRpcSyntaxNegotiate> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
