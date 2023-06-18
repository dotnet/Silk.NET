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

public unsafe static class RpcChannelBuffer3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRpcChannelBuffer3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRpcChannelBuffer3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreeBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMessage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer3> thisVtbl, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsConnected(this ComPtr<IRpcChannelBuffer3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, int>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtocolVersion(this ComPtr<IRpcChannelBuffer3> thisVtbl, uint* pdwVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pulStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, uint ulSize, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint, uint*, int>)@this->LpVtbl[10])(@this, pMsg, ulSize, pulStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Cancel(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[11])(@this, pMsg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Guid* riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsg, riid, pInterface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContext, ppvDestContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetState(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, uint* pState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[14])(@this, pMsg, pState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAsync(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, IAsyncManager* pAsyncMgr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsg, pAsyncMgr);
        return ret;
    }

}
