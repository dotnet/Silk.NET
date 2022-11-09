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
    [Guid("00000002-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMalloc")]
    public unsafe partial struct IMalloc : IComVtbl<IMalloc>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000002-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMalloc val)
            => Unsafe.As<IMalloc, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMalloc
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
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* Alloc(nuint cb)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, nuint, void*>)@this->LpVtbl[3])(@this, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* Realloc(void* pv, nuint cb)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint, void*>)@this->LpVtbl[4])(@this, pv, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* Realloc<T0>(ref T0 pv, nuint cb) where T0 : unmanaged
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint, void*>)@this->LpVtbl[4])(@this, pvPtr, cb);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Free(void* pv)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IMalloc*, void*, void>)@this->LpVtbl[5])(@this, pv);
        }

        /// <summary>To be documented.</summary>
        public readonly void Free<T0>(ref T0 pv) where T0 : unmanaged
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pvPtr = &pv)
            {
                ((delegate* unmanaged[Cdecl]<IMalloc*, void*, void>)@this->LpVtbl[5])(@this, pvPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe nuint GetSize(void* pv)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint>)@this->LpVtbl[6])(@this, pv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetSize<T0>(ref T0 pv) where T0 : unmanaged
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint>)@this->LpVtbl[6])(@this, pvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DidAlloc(void* pv)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, int>)@this->LpVtbl[7])(@this, pv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DidAlloc<T0>(ref T0 pv) where T0 : unmanaged
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, int>)@this->LpVtbl[7])(@this, pvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void HeapMinimize()
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IMalloc*, void>)@this->LpVtbl[8])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
