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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int Connect(ref Silk.NET.Core.Native.IUnknown pUnkServer)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkServerPtr);
            }
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
        public readonly unsafe int Invoke(RPCOLEMessage* _prpcmsg, ref IRpcChannelBuffer _pRpcChannelBuffer)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IRpcChannelBuffer* _pRpcChannelBufferPtr = &_pRpcChannelBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, RPCOLEMessage*, IRpcChannelBuffer*, int>)@this->LpVtbl[5])(@this, _prpcmsg, _pRpcChannelBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(ref RPCOLEMessage _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RPCOLEMessage* _prpcmsgPtr = &_prpcmsg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, RPCOLEMessage*, IRpcChannelBuffer*, int>)@this->LpVtbl[5])(@this, _prpcmsgPtr, _pRpcChannelBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Invoke(ref RPCOLEMessage _prpcmsg, ref IRpcChannelBuffer _pRpcChannelBuffer)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe IRpcStubBuffer* IsIIDSupported(Guid* riid)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IRpcStubBuffer* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)@this->LpVtbl[6])(@this, riid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe IRpcStubBuffer* IsIIDSupported(ref Guid riid)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            IRpcStubBuffer* ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)@this->LpVtbl[6])(@this, riidPtr);
            }
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
        public readonly unsafe int DebugServerQueryInterface(ref void* ppv)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void**, int>)@this->LpVtbl[8])(@this, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DebugServerRelease(void* pv)
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void*, void>)@this->LpVtbl[9])(@this, pv);
        }

        /// <summary>To be documented.</summary>
        public readonly void DebugServerRelease<T0>(ref T0 pv) where T0 : unmanaged
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pvPtr = &pv)
            {
                ((delegate* unmanaged[Cdecl]<IRpcStubBuffer*, void*, void>)@this->LpVtbl[9])(@this, pvPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Connect<TI0>(ComPtr<TI0> pUnkServer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Connect((Silk.NET.Core.Native.IUnknown*) pUnkServer.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke<TI0>(RPCOLEMessage* _prpcmsg, ComPtr<TI0> _pRpcChannelBuffer) where TI0 : unmanaged, IComVtbl<IRpcChannelBuffer>, IComVtbl<TI0>
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Invoke(_prpcmsg, (IRpcChannelBuffer*) _pRpcChannelBuffer.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Invoke<TI0>(ref RPCOLEMessage _prpcmsg, ComPtr<TI0> _pRpcChannelBuffer) where TI0 : unmanaged, IComVtbl<IRpcChannelBuffer>, IComVtbl<TI0>
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Invoke(ref _prpcmsg, (IRpcChannelBuffer*) _pRpcChannelBuffer.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcStubBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
