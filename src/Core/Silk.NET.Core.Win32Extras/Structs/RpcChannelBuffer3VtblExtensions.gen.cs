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
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer3> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMessage, ref Guid riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMessage, ref Guid riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riidPtr);
            }
        }
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
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMessage, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SendReceive(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMessage, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatusPtr);
            }
        }
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
    public static int FreeBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMessage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessagePtr);
        }
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
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer3> thisVtbl, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDestContextPtr = &ppvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref uint pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref uint pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContextPtr);
            }
        }
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
    public static int GetProtocolVersion(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref uint pdwVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwVersionPtr = &pdwVersion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersionPtr);
        }
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
    public static unsafe int Send(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulStatusPtr = &pulStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pulStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pulStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Send(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pulStatusPtr);
            }
        }
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
    public static unsafe int Receive(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, uint ulSize, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulStatusPtr = &pulStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint, uint*, int>)@this->LpVtbl[10])(@this, pMsg, ulSize, pulStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, uint ulSize, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint, uint*, int>)@this->LpVtbl[10])(@this, pMsgPtr, ulSize, pulStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Receive(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, uint ulSize, ref uint pulStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint, uint*, int>)@this->LpVtbl[10])(@this, pMsgPtr, ulSize, pulStatusPtr);
            }
        }
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
    public static int Cancel(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[11])(@this, pMsgPtr);
        }
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
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Guid* riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pInterfacePtr = &pInterface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsg, riid, pInterfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ref Guid riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsg, riidPtr, pInterface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ref Guid riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** pInterfacePtr = &pInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsg, riidPtr, pInterfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, Guid* riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsgPtr, riid, pInterface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, Guid* riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (void** pInterfacePtr = &pInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsgPtr, riid, pInterfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ref Guid riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsgPtr, riidPtr, pInterface);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ref Guid riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** pInterfacePtr = &pInterface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsgPtr, riidPtr, pInterfacePtr);
                }
            }
        }
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
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDestContextPtr = &ppvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContext, ppvDestContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ref uint pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContextPtr, ppvDestContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContextPtr, ppvDestContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsgPtr, pdwDestContext, ppvDestContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsgPtr, pdwDestContext, ppvDestContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ref uint pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsgPtr, pdwDestContextPtr, ppvDestContext);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                fixed (void** ppvDestContextPtr = &ppvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsgPtr, pdwDestContextPtr, ppvDestContextPtr);
                }
            }
        }
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
    public static unsafe int GetState(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ref uint pState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStatePtr = &pState)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[14])(@this, pMsg, pStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetState(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, uint* pState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[14])(@this, pMsgPtr, pState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetState(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ref uint pState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (uint* pStatePtr = &pState)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[14])(@this, pMsgPtr, pStatePtr);
            }
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAsync(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ref IAsyncManager pAsyncMgr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IAsyncManager* pAsyncMgrPtr = &pAsyncMgr)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsg, pAsyncMgrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAsync(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, IAsyncManager* pAsyncMgr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsgPtr, pAsyncMgr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterAsync(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ref IAsyncManager pAsyncMgr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RPCOLEMessage* pMsgPtr = &pMsg)
        {
            fixed (IAsyncManager* pAsyncMgrPtr = &pAsyncMgr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsgPtr, pAsyncMgrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMessage, Span<Guid> riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(pMessage, ref riid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(ref pMessage.GetPinnableReference(), riid);
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMessage, Span<Guid> riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(ref pMessage.GetPinnableReference(), ref riid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMessage, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(pMessage, ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(ref pMessage.GetPinnableReference(), pStatus);
    }

    /// <summary>To be documented.</summary>
    public static int SendReceive(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMessage, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(ref pMessage.GetPinnableReference(), ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FreeBuffer(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMessage)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FreeBuffer(ref pMessage.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<uint> pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtx(ref pdwDestContext.GetPinnableReference(), ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<uint> pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtx(ref pdwDestContext.GetPinnableReference(), ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static int GetProtocolVersion(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<uint> pdwVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProtocolVersion(ref pdwVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(pMsg, ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Send(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(ref pMsg.GetPinnableReference(), pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static int Send(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Send(ref pMsg.GetPinnableReference(), ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, uint ulSize, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Receive(pMsg, ulSize, ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Receive(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, uint ulSize, uint* pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Receive(ref pMsg.GetPinnableReference(), ulSize, pulStatus);
    }

    /// <summary>To be documented.</summary>
    public static int Receive(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, uint ulSize, Span<uint> pulStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Receive(ref pMsg.GetPinnableReference(), ulSize, ref pulStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Cancel(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Cancel(ref pMsg.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, out ComPtr<TI0> pInterface) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        pInterface = default;
        return @this->GetCallContext(pMsg, SilkMarshal.GuidPtrOf<TI0>(), (void**) pInterface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Span<Guid> riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(pMsg, ref riid.GetPinnableReference(), pInterface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Span<Guid> riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(pMsg, ref riid.GetPinnableReference(), ref pInterface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Guid* riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(ref pMsg.GetPinnableReference(), riid, pInterface);
    }

    /// <summary>To be documented.</summary>
    public static int GetCallContext<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, out ComPtr<TI0> pInterface) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        pInterface = default;
        return @this->GetCallContext(ref pMsg, SilkMarshal.GuidPtrOf<TI0>(), (void**) pInterface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Guid* riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(ref pMsg.GetPinnableReference(), riid, ref pInterface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Span<Guid> riid, void** pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(ref pMsg.GetPinnableReference(), ref riid.GetPinnableReference(), pInterface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCallContext(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Span<Guid> riid, ref void* pInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCallContext(ref pMsg.GetPinnableReference(), ref riid.GetPinnableReference(), ref pInterface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Span<uint> pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(pMsg, ref pdwDestContext.GetPinnableReference(), ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Span<uint> pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(pMsg, ref pdwDestContext.GetPinnableReference(), ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), pdwDestContext, ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), pdwDestContext, ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Span<uint> pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), ref pdwDestContext.GetPinnableReference(), ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtxEx(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Span<uint> pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtxEx(ref pMsg.GetPinnableReference(), ref pdwDestContext.GetPinnableReference(), ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetState(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Span<uint> pState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetState(pMsg, ref pState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetState(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, uint* pState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetState(ref pMsg.GetPinnableReference(), pState);
    }

    /// <summary>To be documented.</summary>
    public static int GetState(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Span<uint> pState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetState(ref pMsg.GetPinnableReference(), ref pState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAsync<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, ComPtr<TI0> pAsyncMgr) where TI0 : unmanaged, IComVtbl<IAsyncManager>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterAsync(pMsg, (IAsyncManager*) pAsyncMgr.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAsync(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg, Span<IAsyncManager> pAsyncMgr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterAsync(pMsg, ref pAsyncMgr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAsync(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, IAsyncManager* pAsyncMgr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterAsync(ref pMsg.GetPinnableReference(), pAsyncMgr);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterAsync<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg, ComPtr<TI0> pAsyncMgr) where TI0 : unmanaged, IComVtbl<IAsyncManager>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterAsync(ref pMsg, (IAsyncManager*) pAsyncMgr.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterAsync(this ComPtr<IRpcChannelBuffer3> thisVtbl, Span<RPCOLEMessage> pMsg, Span<IAsyncManager> pAsyncMgr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterAsync(ref pMsg.GetPinnableReference(), ref pAsyncMgr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetCallContext<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl, RPCOLEMessage* pMsg) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCallContext(pMsg, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetCallContext<TI0>(this ComPtr<IRpcChannelBuffer3> thisVtbl, ref RPCOLEMessage pMsg) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCallContext(ref pMsg, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
