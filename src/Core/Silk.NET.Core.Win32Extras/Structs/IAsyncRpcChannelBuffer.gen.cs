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
        public readonly unsafe int SendReceive(RPCOLEMessage* pMessage, uint* pStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
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
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
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
        public readonly unsafe int Send(RPCOLEMessage* pMsg, ISynchronize* pSync, uint* pulStatus)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, ISynchronize*, uint*, int>)@this->LpVtbl[9])(@this, pMsg, pSync, pulStatus);
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
        public readonly unsafe int GetDestCtxEx(RPCOLEMessage* pMsg, uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IAsyncRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncRpcChannelBuffer*, RPCOLEMessage*, uint*, void**, int>)@this->LpVtbl[11])(@this, pMsg, pdwDestContext, ppvDestContext);
            return ret;
        }

    }
}
