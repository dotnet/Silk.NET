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
    [Guid("25b15600-0115-11d0-bf0d-00aa00b8dfd2")]
    [NativeName("Name", "IRpcChannelBuffer3")]
    public unsafe partial struct IRpcChannelBuffer3 : IComVtbl<IRpcChannelBuffer3>, IComVtbl<IRpcChannelBuffer2>, IComVtbl<IRpcChannelBuffer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("25b15600-0115-11d0-bf0d-00aa00b8dfd2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IRpcChannelBuffer2(IRpcChannelBuffer3 val)
            => Unsafe.As<IRpcChannelBuffer3, IRpcChannelBuffer2>(ref val);

        public static implicit operator IRpcChannelBuffer(IRpcChannelBuffer3 val)
            => Unsafe.As<IRpcChannelBuffer3, IRpcChannelBuffer>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IRpcChannelBuffer3 val)
            => Unsafe.As<IRpcChannelBuffer3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IRpcChannelBuffer3
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
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(RPCOLEMessage* pMessage, Guid* riid)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(RPCOLEMessage* pMessage, ref Guid riid)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(ref RPCOLEMessage pMessage, Guid* riid)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBuffer(ref RPCOLEMessage pMessage, ref Guid riid)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int SendReceive(RPCOLEMessage* pMessage, uint* pStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(RPCOLEMessage* pMessage, ref uint pStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(ref RPCOLEMessage pMessage, uint* pStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SendReceive(ref RPCOLEMessage pMessage, ref uint pStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int FreeBuffer(RPCOLEMessage* pMessage)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreeBuffer(ref RPCOLEMessage pMessage)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(ref uint pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(ref uint pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int IsConnected()
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, int>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProtocolVersion(uint* pdwVersion)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProtocolVersion(ref uint pdwVersion)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwVersionPtr = &pdwVersion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(RPCOLEMessage* pMsg, uint* pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pulStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(RPCOLEMessage* pMsg, ref uint pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pulStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Send(ref RPCOLEMessage pMsg, uint* pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsgPtr, pulStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Send(ref RPCOLEMessage pMsg, ref uint pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int Receive(RPCOLEMessage* pMsg, uint ulSize, uint* pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint, uint*, int>)@this->LpVtbl[10])(@this, pMsg, ulSize, pulStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Receive(RPCOLEMessage* pMsg, uint ulSize, ref uint pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulStatusPtr = &pulStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint, uint*, int>)@this->LpVtbl[10])(@this, pMsg, ulSize, pulStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Receive(ref RPCOLEMessage pMsg, uint ulSize, uint* pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint, uint*, int>)@this->LpVtbl[10])(@this, pMsgPtr, ulSize, pulStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Receive(ref RPCOLEMessage pMsg, uint ulSize, ref uint pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int Cancel(RPCOLEMessage* pMsg)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[11])(@this, pMsg);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Cancel(ref RPCOLEMessage pMsg)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[11])(@this, pMsgPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(RPCOLEMessage* pMsg, Guid* riid, void** pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsg, riid, pInterface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(RPCOLEMessage* pMsg, Guid* riid, ref void* pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pInterfacePtr = &pInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsg, riid, pInterfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(RPCOLEMessage* pMsg, ref Guid riid, void** pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsg, riidPtr, pInterface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(RPCOLEMessage* pMsg, ref Guid riid, ref void* pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetCallContext(ref RPCOLEMessage pMsg, Guid* riid, void** pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pMsgPtr, riid, pInterface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(ref RPCOLEMessage pMsg, Guid* riid, ref void* pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetCallContext(ref RPCOLEMessage pMsg, ref Guid riid, void** pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetCallContext(ref RPCOLEMessage pMsg, ref Guid riid, ref void* pInterface)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContext, ppvDestContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, uint* pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContext, ppvDestContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, ref uint pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContextPtr, ppvDestContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsgPtr, pdwDestContext, ppvDestContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, uint* pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, ref uint pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetDestCtxEx(ref RPCOLEMessage pMsg, ref uint pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetState(RPCOLEMessage* pMsg, uint* pState)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[14])(@this, pMsg, pState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetState(RPCOLEMessage* pMsg, ref uint pState)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatePtr = &pState)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[14])(@this, pMsg, pStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetState(ref RPCOLEMessage pMsg, uint* pState)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[14])(@this, pMsgPtr, pState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetState(ref RPCOLEMessage pMsg, ref uint pState)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int RegisterAsync(RPCOLEMessage* pMsg, IAsyncManager* pAsyncMgr)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsg, pAsyncMgr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterAsync(RPCOLEMessage* pMsg, ref IAsyncManager pAsyncMgr)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IAsyncManager* pAsyncMgrPtr = &pAsyncMgr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsg, pAsyncMgrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterAsync(ref RPCOLEMessage pMsg, IAsyncManager* pAsyncMgr)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* pMsgPtr = &pMsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsgPtr, pAsyncMgr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterAsync(ref RPCOLEMessage pMsg, ref IAsyncManager pAsyncMgr)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext<TI0>(RPCOLEMessage* pMsg, out ComPtr<TI0> pInterface) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            pInterface = default;
            return @this->GetCallContext(pMsg, SilkMarshal.GuidPtrOf<TI0>(), (void**) pInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCallContext<TI0>(ref RPCOLEMessage pMsg, out ComPtr<TI0> pInterface) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            pInterface = default;
            return @this->GetCallContext(ref pMsg, SilkMarshal.GuidPtrOf<TI0>(), (void**) pInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterAsync<TI0>(RPCOLEMessage* pMsg, ComPtr<TI0> pAsyncMgr) where TI0 : unmanaged, IComVtbl<IAsyncManager>, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterAsync(pMsg, (IAsyncManager*) pAsyncMgr.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterAsync<TI0>(ref RPCOLEMessage pMsg, ComPtr<TI0> pAsyncMgr) where TI0 : unmanaged, IComVtbl<IAsyncManager>, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterAsync(ref pMsg, (IAsyncManager*) pAsyncMgr.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetCallContext<TI0>(RPCOLEMessage* pMsg) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetCallContext(pMsg, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetCallContext<TI0>(ref RPCOLEMessage pMsg) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetCallContext(ref pMsg, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
