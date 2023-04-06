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
    [Guid("000e0020-0000-0000-c000-000000000046")]
    [NativeName("Name", "AsyncIMultiQI")]
    public unsafe partial struct AsyncIMultiQI : IComVtbl<AsyncIMultiQI>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("000e0020-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(AsyncIMultiQI val)
            => Unsafe.As<AsyncIMultiQI, Silk.NET.Core.Native.IUnknown>(ref val);

        public AsyncIMultiQI
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
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginQueryMultipleInterfaces(uint cMQIs, MultiQi* pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint, MultiQi*, int>)@this->LpVtbl[3])(@this, cMQIs, pMQIs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginQueryMultipleInterfaces(uint cMQIs, ref MultiQi pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MultiQi* pMQIsPtr = &pMQIs)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, uint, MultiQi*, int>)@this->LpVtbl[3])(@this, cMQIs, pMQIsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishQueryMultipleInterfaces(MultiQi* pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, MultiQi*, int>)@this->LpVtbl[4])(@this, pMQIs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishQueryMultipleInterfaces(ref MultiQi pMQIs)
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MultiQi* pMQIsPtr = &pMQIs)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIMultiQI*, MultiQi*, int>)@this->LpVtbl[4])(@this, pMQIsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (AsyncIMultiQI*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
