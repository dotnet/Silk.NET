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
    [Guid("0000002e-0000-0000-c000-000000000046")]
    [NativeName("Name", "ITypeFactory")]
    public unsafe partial struct ITypeFactory : IComVtbl<ITypeFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000002e-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ITypeFactory val)
            => Unsafe.As<ITypeFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ITypeFactory
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
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ITypeInfo* pTypeInfo, Guid* riid, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ITypeInfo* pTypeInfo, Guid* riid, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ITypeInfo* pTypeInfo, ref Guid riid, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ITypeInfo* pTypeInfo, ref Guid riid, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfo, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ref ITypeInfo pTypeInfo, Guid* riid, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ref ITypeInfo pTypeInfo, Guid* riid, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ref ITypeInfo pTypeInfo, ref Guid riid, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo(ref ITypeInfo pTypeInfo, ref Guid riid, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo* pTypeInfoPtr = &pTypeInfo)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeFactory*, ITypeInfo*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, pTypeInfoPtr, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFromTypeInfo<TI0, TI1>(ComPtr<TI0> pTypeInfo, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, SilkMarshal.GuidPtrOf<TI1>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo<TI0>(ComPtr<TI0> pTypeInfo, Guid* riid, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFromTypeInfo<TI0, TI1>(ComPtr<TI0> pTypeInfo, ref Guid riid, ref ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, ref riid, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFromTypeInfo<TI0>(ComPtr<TI0> pTypeInfo, ref Guid riid, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFromTypeInfo((ITypeInfo*) pTypeInfo.Handle, ref riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFromTypeInfo<TI0>(ref ITypeInfo pTypeInfo, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->CreateFromTypeInfo(ref pTypeInfo, SilkMarshal.GuidPtrOf<TI0>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFromTypeInfo<TI0>(ref ITypeInfo pTypeInfo, ref Guid riid, ref ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFromTypeInfo(ref pTypeInfo, ref riid, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateFromTypeInfo<TI0, TI1>(ComPtr<TI0> pTypeInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateFromTypeInfo(pTypeInfo, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateFromTypeInfo<TI0>(ref ITypeInfo pTypeInfo) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ITypeFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateFromTypeInfo(ref pTypeInfo, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
