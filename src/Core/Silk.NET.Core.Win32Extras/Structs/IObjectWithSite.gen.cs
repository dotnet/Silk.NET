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
    [Guid("fc4801a3-2ba9-11cf-a229-00aa003d7352")]
    [NativeName("Name", "IObjectWithSite")]
    public unsafe partial struct IObjectWithSite : IComVtbl<IObjectWithSite>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fc4801a3-2ba9-11cf-a229-00aa003d7352");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IObjectWithSite val)
            => Unsafe.As<IObjectWithSite, Silk.NET.Core.Native.IUnknown>(ref val);

        public IObjectWithSite
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
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSite(Silk.NET.Core.Native.IUnknown* pUnkSite)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkSite);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSite(ref Silk.NET.Core.Native.IUnknown pUnkSite)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkSitePtr = &pUnkSite)
            {
                ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkSitePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSite(Guid* riid, void** ppvSite)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvSite);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSite(Guid* riid, ref void* ppvSite)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvSitePtr = &ppvSite)
            {
                ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvSitePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSite(ref Guid riid, void** ppvSite)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvSite);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSite(ref Guid riid, ref void* ppvSite)
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvSitePtr = &ppvSite)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvSitePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSite<TI0>(ComPtr<TI0> pUnkSite) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetSite((Silk.NET.Core.Native.IUnknown*) pUnkSite.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSite<TI0>(out ComPtr<TI0> ppvSite) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvSite = default;
            return @this->GetSite(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvSite.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetSite<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IObjectWithSite*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetSite(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
