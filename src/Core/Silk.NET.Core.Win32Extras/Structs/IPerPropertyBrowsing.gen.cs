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
    [Guid("376bd3aa-3845-101b-84ed-08002b2ec713")]
    [NativeName("Name", "IPerPropertyBrowsing")]
    public unsafe partial struct IPerPropertyBrowsing : IComVtbl<IPerPropertyBrowsing>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("376bd3aa-3845-101b-84ed-08002b2ec713");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPerPropertyBrowsing val)
            => Unsafe.As<IPerPropertyBrowsing, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPerPropertyBrowsing
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
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayString(int dispID, char** pBstr)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, char**, int>)@this->LpVtbl[3])(@this, dispID, pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayString(int dispID, ref char* pBstr)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrPtr = &pBstr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, char**, int>)@this->LpVtbl[3])(@this, dispID, pBstrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapPropertyToPage(int dispID, Guid* pClsid)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, Guid*, int>)@this->LpVtbl[4])(@this, dispID, pClsid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapPropertyToPage(int dispID, ref Guid pClsid)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClsidPtr = &pClsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, Guid*, int>)@this->LpVtbl[4])(@this, dispID, pClsidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPredefinedStrings(int dispID, CALPOLESTR* pCaStringsOut, CADWORD* pCaCookiesOut)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOut, pCaCookiesOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPredefinedStrings(int dispID, CALPOLESTR* pCaStringsOut, ref CADWORD pCaCookiesOut)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CADWORD* pCaCookiesOutPtr = &pCaCookiesOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOut, pCaCookiesOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPredefinedStrings(int dispID, ref CALPOLESTR pCaStringsOut, CADWORD* pCaCookiesOut)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CALPOLESTR* pCaStringsOutPtr = &pCaStringsOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOutPtr, pCaCookiesOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPredefinedStrings(int dispID, ref CALPOLESTR pCaStringsOut, ref CADWORD pCaCookiesOut)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CALPOLESTR* pCaStringsOutPtr = &pCaStringsOut)
            {
                fixed (CADWORD* pCaCookiesOutPtr = &pCaCookiesOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOutPtr, pCaCookiesOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPredefinedValue(int dispID, uint dwCookie, Variant* pVarOut)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, uint, Variant*, int>)@this->LpVtbl[6])(@this, dispID, dwCookie, pVarOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPredefinedValue(int dispID, uint dwCookie, ref Variant pVarOut)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarOutPtr = &pVarOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, uint, Variant*, int>)@this->LpVtbl[6])(@this, dispID, dwCookie, pVarOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayString(int dispID, string[] pBstrSa)
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
            var ret = @this->GetDisplayString(dispID, pBstr);
            SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
            SilkMarshal.Free((nint) pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPerPropertyBrowsing*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
