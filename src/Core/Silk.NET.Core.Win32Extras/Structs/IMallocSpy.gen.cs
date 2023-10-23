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
    [Guid("0000001d-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMallocSpy")]
    public unsafe partial struct IMallocSpy : IComVtbl<IMallocSpy>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000001d-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMallocSpy val)
            => Unsafe.As<IMallocSpy, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMallocSpy
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
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint PreAlloc(nuint cbRequest)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, nuint, nuint>)@this->LpVtbl[3])(@this, cbRequest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PostAlloc(void* pActual)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, void*>)@this->LpVtbl[4])(@this, pActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PostAlloc<T0>(ref T0 pActual) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (void* pActualPtr = &pActual)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, void*>)@this->LpVtbl[4])(@this, pActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PreFree(void* pRequest, Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[5])(@this, pRequest, fSpyed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PreFree<T0>(ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (void* pRequestPtr = &pRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[5])(@this, pRequestPtr, fSpyed);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PostFree(Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IMallocSpy*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[6])(@this, fSpyed);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe nuint PreRealloc(void* pRequest, nuint cbRequest, void** ppNewRequest, Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequest, cbRequest, ppNewRequest, fSpyed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe nuint PreRealloc(void* pRequest, nuint cbRequest, ref void* ppNewRequest, Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            fixed (void** ppNewRequestPtr = &ppNewRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequest, cbRequest, ppNewRequestPtr, fSpyed);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe nuint PreRealloc<T0>(ref T0 pRequest, nuint cbRequest, void** ppNewRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            fixed (void* pRequestPtr = &pRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequestPtr, cbRequest, ppNewRequest, fSpyed);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe nuint PreRealloc<T0>(ref T0 pRequest, nuint cbRequest, ref void* ppNewRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            fixed (void* pRequestPtr = &pRequest)
            {
                fixed (void** ppNewRequestPtr = &ppNewRequest)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, nuint, void**, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[7])(@this, pRequestPtr, cbRequest, ppNewRequestPtr, fSpyed);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PostRealloc(void* pActual, Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[8])(@this, pActual, fSpyed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PostRealloc<T0>(ref T0 pActual, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (void* pActualPtr = &pActual)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[8])(@this, pActualPtr, fSpyed);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PreGetSize(void* pRequest, Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[9])(@this, pRequest, fSpyed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PreGetSize<T0>(ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (void* pRequestPtr = &pRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[9])(@this, pRequestPtr, fSpyed);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint PostGetSize(nuint cbActual, Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, nuint, Silk.NET.Core.Bool32, nuint>)@this->LpVtbl[10])(@this, cbActual, fSpyed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PreDidAlloc(void* pRequest, Silk.NET.Core.Bool32 fSpyed)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[11])(@this, pRequest, fSpyed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* PreDidAlloc<T0>(ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (void* pRequestPtr = &pRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, void*>)@this->LpVtbl[11])(@this, pRequestPtr, fSpyed);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PostDidAlloc(void* pRequest, Silk.NET.Core.Bool32 fSpyed, int fActual)
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, int, int>)@this->LpVtbl[12])(@this, pRequest, fSpyed, fActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PostDidAlloc<T0>(ref T0 pRequest, Silk.NET.Core.Bool32 fSpyed, int fActual) where T0 : unmanaged
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pRequestPtr = &pRequest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMallocSpy*, void*, Silk.NET.Core.Bool32, int, int>)@this->LpVtbl[12])(@this, pRequestPtr, fSpyed, fActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PreHeapMinimize()
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IMallocSpy*, void>)@this->LpVtbl[13])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void PostHeapMinimize()
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IMallocSpy*, void>)@this->LpVtbl[14])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMallocSpy*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
