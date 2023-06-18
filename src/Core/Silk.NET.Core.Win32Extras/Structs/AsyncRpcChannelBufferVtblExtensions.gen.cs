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

public unsafe static class AsyncRpcChannelBufferVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreeBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMessage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsConnected(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, int>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtocolVersion(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, uint* pdwVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ISynchronize* pSync, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSync, pulStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[10])(@this, pMsg, pulStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContext, ppvDestContext);
        return ret;
    }

}
