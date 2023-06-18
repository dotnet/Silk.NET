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
        public readonly unsafe int SendReceive(RPCOLEMessage* pMessage, uint* pStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
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
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
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
        public readonly unsafe int Send(RPCOLEMessage* pMsg, uint* pulStatus)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pulStatus);
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
        public readonly unsafe int Cancel(RPCOLEMessage* pMsg)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, int>)@this->LpVtbl[11])(@this, pMsg);
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
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[13])(@this, pMsg, pdwDestContext, ppvDestContext);
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
        public readonly unsafe int RegisterAsync(RPCOLEMessage* pMsg, IAsyncManager* pAsyncMgr)
        {
            var @this = (IRpcChannelBuffer3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer3*, RPCOLEMessage*, IAsyncManager*, int>)@this->LpVtbl[15])(@this, pMsg, pAsyncMgr);
            return ret;
        }

    }
}
