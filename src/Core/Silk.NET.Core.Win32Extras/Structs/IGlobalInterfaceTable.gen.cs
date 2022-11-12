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
    [Guid("00000146-0000-0000-c000-000000000046")]
    [NativeName("Name", "IGlobalInterfaceTable")]
    public unsafe partial struct IGlobalInterfaceTable : IComVtbl<IGlobalInterfaceTable>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000146-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IGlobalInterfaceTable val)
            => Unsafe.As<IGlobalInterfaceTable, Silk.NET.Core.Native.IUnknown>(ref val);

        public IGlobalInterfaceTable
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
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(Silk.NET.Core.Native.IUnknown* pUnk, Guid* riid, uint* pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riid, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(Silk.NET.Core.Native.IUnknown* pUnk, Guid* riid, ref uint pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riid, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(Silk.NET.Core.Native.IUnknown* pUnk, ref Guid riid, uint* pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riidPtr, pdwCookie);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(Silk.NET.Core.Native.IUnknown* pUnk, ref Guid riid, ref uint pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riidPtr, pdwCookiePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(ref Silk.NET.Core.Native.IUnknown pUnk, Guid* riid, uint* pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riid, pdwCookie);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(ref Silk.NET.Core.Native.IUnknown pUnk, Guid* riid, ref uint pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
            {
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riid, pdwCookiePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(ref Silk.NET.Core.Native.IUnknown pUnk, ref Guid riid, uint* pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riidPtr, pdwCookie);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterInterfaceInGlobal(ref Silk.NET.Core.Native.IUnknown pUnk, ref Guid riid, ref uint pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pdwCookiePtr = &pdwCookie)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riidPtr, pdwCookiePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeInterfaceFromGlobal(uint dwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, int>)@this->LpVtbl[4])(@this, dwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterfaceFromGlobal(uint dwCookie, Guid* riid, void** ppv)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterfaceFromGlobal(uint dwCookie, Guid* riid, ref void* ppv)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterfaceFromGlobal(uint dwCookie, ref Guid riid, void** ppv)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterfaceFromGlobal(uint dwCookie, ref Guid riid, ref void* ppv)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal<TI0>(ComPtr<TI0> pUnk, Guid* riid, uint* pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, riid, pdwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal<TI0>(ComPtr<TI0> pUnk, Guid* riid, ref uint pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, riid, ref pdwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal<TI0>(ComPtr<TI0> pUnk, ref Guid riid, uint* pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, ref riid, pdwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterInterfaceInGlobal<TI0>(ComPtr<TI0> pUnk, ref Guid riid, ref uint pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, ref riid, ref pdwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInterfaceFromGlobal<TI0>(uint dwCookie, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetInterfaceFromGlobal(dwCookie, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetInterfaceFromGlobal<TI0>(uint dwCookie) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetInterfaceFromGlobal(dwCookie, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
