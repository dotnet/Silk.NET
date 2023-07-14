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
    public static unsafe int QueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int Connect(this ComPtr<IRpcStubBuffer> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkServer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkServerPtr);
        }
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
    public static unsafe int Invoke(this ComPtr<IRpcStubBuffer> thisVtbl, RPCOLEMessage* _prpcmsg, ref IRpcChannelBuffer _pRpcChannelBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IRpcChannelBuffer* _pRpcChannelBufferPtr = &_pRpcChannelBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, RPCOLEMessage*, IRpcChannelBuffer*, int>)@this->LpVtbl[5])(@this, _prpcmsg, _pRpcChannelBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IRpcStubBuffer> thisVtbl, ref RPCOLEMessage _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* _prpcmsgPtr = &_prpcmsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, RPCOLEMessage*, IRpcChannelBuffer*, int>)@this->LpVtbl[5])(@this, _prpcmsgPtr, _pRpcChannelBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Invoke(this ComPtr<IRpcStubBuffer> thisVtbl, ref RPCOLEMessage _prpcmsg, ref IRpcChannelBuffer _pRpcChannelBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* _prpcmsgPtr = &_prpcmsg)
        {
            fixed (IRpcChannelBuffer* _pRpcChannelBufferPtr = &_pRpcChannelBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, RPCOLEMessage*, IRpcChannelBuffer*, int>)@this->LpVtbl[5])(@this, _prpcmsgPtr, _pRpcChannelBufferPtr);
            }
        }
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
    public static unsafe IRpcStubBuffer* IsIIDSupported(this ComPtr<IRpcStubBuffer> thisVtbl, ref Guid riid)
    {
        var @this = thisVtbl.Handle;
        IRpcStubBuffer* ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)@this->LpVtbl[6])(@this, riidPtr);
        }
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
    public static unsafe int DebugServerQueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void**, int>)@this->LpVtbl[8])(@this, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DebugServerRelease(this ComPtr<IRpcStubBuffer> thisVtbl, void* pv)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void*, void>)@this->LpVtbl[9])(@this, pv);
    }

    /// <summary>To be documented.</summary>
    public static void DebugServerRelease<T0>(this ComPtr<IRpcStubBuffer> thisVtbl, ref T0 pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pvPtr = &pv)
        {
            ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void*, void>)@this->LpVtbl[9])(@this, pvPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRpcStubBuffer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcStubBuffer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Connect<TI0>(this ComPtr<IRpcStubBuffer> thisVtbl, ComPtr<TI0> pUnkServer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Connect((Silk.NET.Core.Native.IUnknown*) pUnkServer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Connect(this ComPtr<IRpcStubBuffer> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkServer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Connect(ref pUnkServer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke<TI0>(this ComPtr<IRpcStubBuffer> thisVtbl, RPCOLEMessage* _prpcmsg, ComPtr<TI0> _pRpcChannelBuffer) where TI0 : unmanaged, IComVtbl<IRpcChannelBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Invoke(_prpcmsg, (IRpcChannelBuffer*) _pRpcChannelBuffer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IRpcStubBuffer> thisVtbl, RPCOLEMessage* _prpcmsg, Span<IRpcChannelBuffer> _pRpcChannelBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(_prpcmsg, ref _pRpcChannelBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IRpcStubBuffer> thisVtbl, Span<RPCOLEMessage> _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref _prpcmsg.GetPinnableReference(), _pRpcChannelBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int Invoke<TI0>(this ComPtr<IRpcStubBuffer> thisVtbl, ref RPCOLEMessage _prpcmsg, ComPtr<TI0> _pRpcChannelBuffer) where TI0 : unmanaged, IComVtbl<IRpcChannelBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Invoke(ref _prpcmsg, (IRpcChannelBuffer*) _pRpcChannelBuffer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Invoke(this ComPtr<IRpcStubBuffer> thisVtbl, Span<RPCOLEMessage> _prpcmsg, Span<IRpcChannelBuffer> _pRpcChannelBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Invoke(ref _prpcmsg.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe IRpcStubBuffer* IsIIDSupported(this ComPtr<IRpcStubBuffer> thisVtbl, Span<Guid> riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsIIDSupported(ref riid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DebugServerRelease<T0>(this ComPtr<IRpcStubBuffer> thisVtbl, Span<T0> pv) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DebugServerRelease(ref pv.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRpcStubBuffer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
