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
    [Guid("594f31d0-7f19-11d0-b194-00a0c90dc8bf")]
    [NativeName("Name", "IRpcChannelBuffer2")]
    public unsafe partial struct IRpcChannelBuffer2 : IComVtbl<IRpcChannelBuffer2>, IComVtbl<IRpcChannelBuffer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("594f31d0-7f19-11d0-b194-00a0c90dc8bf");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IRpcChannelBuffer(IRpcChannelBuffer2 val)
            => Unsafe.As<IRpcChannelBuffer2, IRpcChannelBuffer>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IRpcChannelBuffer2 val)
            => Unsafe.As<IRpcChannelBuffer2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IRpcChannelBuffer2
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
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(RPCOLEMessage* pMessage, Guid* riid)
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, RPCOLEMessage*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(RPCOLEMessage* pMessage, uint* pStatus)
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, RPCOLEMessage*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreeBuffer(RPCOLEMessage* pMessage)
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, RPCOLEMessage*, int>)@this->LpVtbl[5])(@this, pMessage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsConnected()
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, int>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProtocolVersion(uint* pdwVersion)
        {
            var @this = (IRpcChannelBuffer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersion);
            return ret;
        }

    }
}
