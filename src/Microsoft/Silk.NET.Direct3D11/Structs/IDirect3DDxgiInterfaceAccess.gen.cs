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

namespace Silk.NET.Direct3D11
{
    [Guid("a9b3d012-3df2-4ee3-b8d1-8695f457d3c1")]
    [NativeName("Name", "IDirect3DDxgiInterfaceAccess")]
    public unsafe partial struct IDirect3DDxgiInterfaceAccess : IComVtbl<IDirect3DDxgiInterfaceAccess>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a9b3d012-3df2-4ee3-b8d1-8695f457d3c1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDxgiInterfaceAccess val)
            => Unsafe.As<IDirect3DDxgiInterfaceAccess, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DDxgiInterfaceAccess
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
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterface(Guid* iid, void** p)
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iid, p);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterface(Guid* iid, ref void* p)
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pPtr = &p)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iid, pPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterface(ref Guid iid, void** p)
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iidPtr, p);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterface(ref Guid iid, ref void* p)
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** pPtr = &p)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)@this->LpVtbl[3])(@this, iidPtr, pPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInterface<TI0>(out ComPtr<TI0> p) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            p = default;
            return @this->GetInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) p.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDxgiInterfaceAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
