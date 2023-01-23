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
    [Guid("000001ce-0000-0000-c000-000000000046")]
    [NativeName("Name", "IComThreadingInfo")]
    public unsafe partial struct IComThreadingInfo : IComVtbl<IComThreadingInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("000001ce-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IComThreadingInfo val)
            => Unsafe.As<IComThreadingInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IComThreadingInfo
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
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentApartmentType(Apttype* pAptType)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Apttype*, int>)@this->LpVtbl[3])(@this, pAptType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentApartmentType(ref Apttype pAptType)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Apttype* pAptTypePtr = &pAptType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Apttype*, int>)@this->LpVtbl[3])(@this, pAptTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentThreadType(Thdtype* pThreadType)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Thdtype*, int>)@this->LpVtbl[4])(@this, pThreadType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentThreadType(ref Thdtype pThreadType)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Thdtype* pThreadTypePtr = &pThreadType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Thdtype*, int>)@this->LpVtbl[4])(@this, pThreadTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentLogicalThreadId(Guid* pguidLogicalThreadId)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[5])(@this, pguidLogicalThreadId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentLogicalThreadId(ref Guid pguidLogicalThreadId)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidLogicalThreadIdPtr = &pguidLogicalThreadId)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[5])(@this, pguidLogicalThreadIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCurrentLogicalThreadId(Guid* rguid)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[6])(@this, rguid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCurrentLogicalThreadId(ref Guid rguid)
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidPtr = &rguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[6])(@this, rguidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IComThreadingInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
