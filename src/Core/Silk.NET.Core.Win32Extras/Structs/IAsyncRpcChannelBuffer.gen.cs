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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("a5029fb6-3c34-11d1-9c99-00c04fb998aa")]
    [NativeName("Name", "IAsyncRpcChannelBuffer")]
    public unsafe partial struct IAsyncRpcChannelBuffer : IComVtbl<IAsyncRpcChannelBuffer>, IComVtbl<IRpcChannelBuffer2>, IComVtbl<IRpcChannelBuffer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a5029fb6-3c34-11d1-9c99-00c04fb998aa");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IRpcChannelBuffer2(IAsyncRpcChannelBuffer val)
            => Unsafe.As<IAsyncRpcChannelBuffer, IRpcChannelBuffer2>(ref val);

        public static implicit operator IRpcChannelBuffer(IAsyncRpcChannelBuffer val)
            => Unsafe.As<IAsyncRpcChannelBuffer, IRpcChannelBuffer>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IAsyncRpcChannelBuffer val)
            => Unsafe.As<IAsyncRpcChannelBuffer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IAsyncRpcChannelBuffer
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(RPCOLEMessage* pMessage, Guid* riid)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(RPCOLEMessage* pMessage, ref Guid riid)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(ref RPCOLEMessage pMessage, Guid* riid)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBuffer(ref RPCOLEMessage pMessage, ref Guid riid)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int SendReceive(RPCOLEMessage* pMessage, uint* pStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(RPCOLEMessage* pMessage, ref uint pStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(ref RPCOLEMessage pMessage, uint* pStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SendReceive(ref RPCOLEMessage pMessage, ref uint pStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int FreeBuffer(RPCOLEMessage* pMessage)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreeBuffer(ref RPCOLEMessage pMessage)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(ref uint pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(ref uint pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int IsConnected()
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, int>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProtocolVersion(uint* pdwVersion)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProtocolVersion(ref uint pdwVersion)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwVersionPtr = &pdwVersion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(RPCOLEMessage* pMsg, ISynchronize* pSync, uint* pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSync, pulStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(RPCOLEMessage* pMsg, ISynchronize* pSync, ref uint pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSync, pulStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(RPCOLEMessage* pMsg, ref ISynchronize pSync, uint* pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ISynchronize* pSyncPtr = &pSync)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSyncPtr, pulStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(RPCOLEMessage* pMsg, ref ISynchronize pSync, ref uint pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int Send(ref RPCOLEMessage pMsg, ISynchronize* pSync, uint* pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pSync, pulStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(ref RPCOLEMessage pMsg, ISynchronize* pSync, ref uint pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int Send(ref RPCOLEMessage pMsg, ref ISynchronize pSync, uint* pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int Send(ref RPCOLEMessage pMsg, ref ISynchronize pSync, ref uint pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int Receive(RPCOLEMessage* pMsg, uint* pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[10])(@this, pMsg, pulStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Receive(RPCOLEMessage* pMsg, ref uint pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[10])(@this, pMsg, pulStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Receive(ref RPCOLEMessage pMsg, uint* pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[10])(@this, pMsgPtr, pulStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Receive(ref RPCOLEMessage pMsg, ref uint pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContext, ppvDestContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, uint* pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContext, ppvDestContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, ref uint pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContextPtr, ppvDestContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsgPtr, pdwDestContext, ppvDestContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, uint* pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, ref uint pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send<TI0>(RPCOLEMessage* pMsg, ComPtr<TI0> pSync, uint* pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Send(pMsg, (ISynchronize*) pSync.Handle, pulStatus);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send<TI0>(RPCOLEMessage* pMsg, ComPtr<TI0> pSync, ref uint pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Send(pMsg, (ISynchronize*) pSync.Handle, ref pulStatus);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send<TI0>(ref RPCOLEMessage pMsg, ComPtr<TI0> pSync, uint* pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Send(ref pMsg, (ISynchronize*) pSync.Handle, pulStatus);
        }

        /// <summary>To be documented.</summary>
        public readonly int Send<TI0>(ref RPCOLEMessage pMsg, ComPtr<TI0> pSync, ref uint pulStatus) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Send(ref pMsg, (ISynchronize*) pSync.Handle, ref pulStatus);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
