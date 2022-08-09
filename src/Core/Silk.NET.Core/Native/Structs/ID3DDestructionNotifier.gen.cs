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

namespace Silk.NET.Core.Native
{
    [Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3")]
    [NativeName("Name", "ID3DDestructionNotifier")]
    public unsafe partial struct ID3DDestructionNotifier : IComVtbl<ID3DDestructionNotifier>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a06eb39a-50da-425b-8c31-4eecd6c270f3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DDestructionNotifier val)
            => Unsafe.As<ID3DDestructionNotifier, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3DDestructionNotifier
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
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterDestructionCallback(PfnDestructionCallback callbackFn, void* pData, uint* pCallbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pData, pCallbackID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterDestructionCallback(PfnDestructionCallback callbackFn, void* pData, ref uint pCallbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCallbackIDPtr = &pCallbackID)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pData, pCallbackIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterDestructionCallback<T0>(PfnDestructionCallback callbackFn, ref T0 pData, uint* pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackID);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterDestructionCallback<T0>(PfnDestructionCallback callbackFn, ref T0 pData, ref uint pCallbackID) where T0 : unmanaged
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pCallbackIDPtr = &pCallbackID)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PfnDestructionCallback, void*, uint*, int>)@this->LpVtbl[3])(@this, callbackFn, pDataPtr, pCallbackIDPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterDestructionCallback(uint callbackID)
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint, int>)@this->LpVtbl[4])(@this, callbackID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DDestructionNotifier*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
