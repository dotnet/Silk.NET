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
    [Guid("d5f56afc-593b-101a-b569-08002b2dbf7a")]
    [NativeName("Name", "IRpcStubBuffer")]
    public unsafe partial struct IRpcStubBuffer : IComVtbl<IRpcStubBuffer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d5f56afc-593b-101a-b569-08002b2dbf7a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IRpcStubBuffer val)
            => Unsafe.As<IRpcStubBuffer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IRpcStubBuffer
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
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Connect(Silk.NET.Core.Native.IUnknown* pUnkServer)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkServer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Disconnect()
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void>)@this->LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(RPCOLEMessage* _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, RPCOLEMessage*, IRpcChannelBuffer*, int>)@this->LpVtbl[5])(@this, _prpcmsg, _pRpcChannelBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IRpcStubBuffer* IsIIDSupported(Guid* riid)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IRpcStubBuffer* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)@this->LpVtbl[6])(@this, riid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint CountRefs()
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DebugServerQueryInterface(void** ppv)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void**, int>)@this->LpVtbl[8])(@this, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DebugServerRelease(void* pv)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void*, void>)@this->LpVtbl[9])(@this, pv);
        }

    }
}
