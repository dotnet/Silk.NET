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

public unsafe static class RpcStubBufferVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRpcStubBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRpcStubBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Connect(this ComPtr<IRpcStubBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkServer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkServer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void Disconnect(this ComPtr<IRpcStubBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IRpcStubBuffer> thisVtbl, RPCOLEMessage* _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, RPCOLEMessage*, IRpcChannelBuffer*, int>)@this->LpVtbl[5])(@this, _prpcmsg, _pRpcChannelBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IRpcStubBuffer* IsIIDSupported(this ComPtr<IRpcStubBuffer> thisVtbl, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        IRpcStubBuffer* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)@this->LpVtbl[6])(@this, riid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint CountRefs(this ComPtr<IRpcStubBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DebugServerQueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void**, int>)@this->LpVtbl[8])(@this, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DebugServerRelease(this ComPtr<IRpcStubBuffer> thisVtbl, void* pv)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void*, void>)@this->LpVtbl[9])(@this, pv);
    }

}
