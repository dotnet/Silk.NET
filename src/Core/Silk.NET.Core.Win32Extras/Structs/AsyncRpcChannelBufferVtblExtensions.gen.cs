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
    public static unsafe int QueryInterface(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe int GetBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMessage, ref Guid riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMessage, ref Guid riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riidPtr);
            }
        }
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
    public static unsafe int SendReceive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMessage, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SendReceive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMessage, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatusPtr);
            }
        }
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
    public static int FreeBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMessage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessagePtr);
        }
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
    public static unsafe int GetDestCtx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDestContextPtr = &ppvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref uint pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref uint pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContextPtr);
            }
        }
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
    public static int GetProtocolVersion(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref uint pdwVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwVersionPtr = &pdwVersion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersionPtr);
        }
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
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ISynchronize* pSync, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulStatusPtr = &pulStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSync, pulStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ref ISynchronize pSync, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISynchronize* pSyncPtr = &pSync)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSyncPtr, pulStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ref ISynchronize pSync, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISynchronize* pSyncPtr = &pSync)
        {
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSyncPtr, pulStatusPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ISynchronize* pSync, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pSync, pulStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ISynchronize* pSync, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pSync, pulStatusPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ref ISynchronize pSync, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (ISynchronize* pSyncPtr = &pSync)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pSyncPtr, pulStatus);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ref ISynchronize pSync, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (ISynchronize* pSyncPtr = &pSync)
            {
                fixed (uint* pulStatusPtr = &pulStatus)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pSyncPtr, pulStatusPtr);
                }
            }
        }
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
    public static unsafe int Receive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulStatusPtr = &pulStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[10])(@this, pMsg, pulStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[10])(@this, pMsgPtr, pulStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Receive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[10])(@this, pMsgPtr, pulStatusPtr);
            }
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDestContextPtr = &ppvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContext, ppvDestContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ref uint pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContextPtr, ppvDestContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContextPtr, ppvDestContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsgPtr, pdwDestContext, ppvDestContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsgPtr, pdwDestContext, ppvDestContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ref uint pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsgPtr, pdwDestContextPtr, ppvDestContext);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                fixed (void** ppvDestContextPtr = &ppvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsgPtr, pdwDestContextPtr, ppvDestContextPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMessage, Span<Guid> riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(pMessage, ref riid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(ref pMessage.GetPinnableReference(), riid);
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMessage, Span<Guid> riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(ref pMessage.GetPinnableReference(), ref riid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMessage, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(pMessage, ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(ref pMessage.GetPinnableReference(), pStatus);
    }

    /// <summary>To be documented.</summary>
    public static int SendReceive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMessage, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(ref pMessage.GetPinnableReference(), ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FreeBuffer(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMessage)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FreeBuffer(ref pMessage.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<uint> pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtx(ref pdwDestContext.GetPinnableReference(), ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<uint> pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtx(ref pdwDestContext.GetPinnableReference(), ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static int GetProtocolVersion(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<uint> pdwVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProtocolVersion(ref pdwVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send<TI0>(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ComPtr<TI0> pSync, uint* pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Send(pMsg, (ISynchronize*) pSync.Handle, pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ISynchronize* pSync, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(pMsg, pSync, ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send<TI0>(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, ComPtr<TI0> pSync, ref uint pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Send(pMsg, (ISynchronize*) pSync.Handle, ref pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, Span<ISynchronize> pSync, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(pMsg, ref pSync.GetPinnableReference(), pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, Span<ISynchronize> pSync, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(pMsg, ref pSync.GetPinnableReference(), ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, ISynchronize* pSync, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(ref pMsg.GetPinnableReference(), pSync, pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send<TI0>(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ComPtr<TI0> pSync, uint* pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Send(ref pMsg, (ISynchronize*) pSync.Handle, pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, ISynchronize* pSync, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(ref pMsg.GetPinnableReference(), pSync, ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Send<TI0>(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, ref RPCOLEMessage pMsg, ComPtr<TI0> pSync, ref uint pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Send(ref pMsg, (ISynchronize*) pSync.Handle, ref pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, Span<ISynchronize> pSync, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(ref pMsg.GetPinnableReference(), ref pSync.GetPinnableReference(), pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static int Send(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, Span<ISynchronize> pSync, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(ref pMsg.GetPinnableReference(), ref pSync.GetPinnableReference(), ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Receive(pMsg, ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Receive(ref pMsg.GetPinnableReference(), pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static int Receive(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Receive(ref pMsg.GetPinnableReference(), ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, Span<uint> pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(pMsg, ref pdwDestContext.GetPinnableReference(), ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, RPCOLEMessage* pMsg, Span<uint> pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(pMsg, ref pdwDestContext.GetPinnableReference(), ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), pdwDestContext, ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), pdwDestContext, ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, Span<uint> pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), ref pdwDestContext.GetPinnableReference(), ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl, Span<RPCOLEMessage> pMsg, Span<uint> pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), ref pdwDestContext.GetPinnableReference(), ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IAsyncRpcChannelBuffer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
