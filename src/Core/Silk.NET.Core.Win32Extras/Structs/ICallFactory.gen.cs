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
    [Guid("1c733a30-2a1c-11ce-ade5-00aa0044773d")]
    [NativeName("Name", "ICallFactory")]
    public unsafe partial struct ICallFactory : IComVtbl<ICallFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1c733a30-2a1c-11ce-ade5-00aa0044773d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ICallFactory val)
            => Unsafe.As<ICallFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ICallFactory
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
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riid2Ptr = &riid2)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2Ptr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riid2Ptr = &riid2)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnk, riid2Ptr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                fixed (Guid* riid2Ptr = &riid2)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2Ptr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
            {
                fixed (Guid* riid2Ptr = &riid2)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riid, pCtrlUnkPtr, riid2Ptr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Guid* riid2Ptr = &riid2)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2Ptr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, Silk.NET.Core.Native.IUnknown* pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Guid* riid2Ptr = &riid2)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnk, riid2Ptr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, Silk.NET.Core.Native.IUnknown** ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
                {
                    fixed (Guid* riid2Ptr = &riid2)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2Ptr, ppv);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv)
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pCtrlUnkPtr = &pCtrlUnk)
                {
                    fixed (Guid* riid2Ptr = &riid2)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown** ppvPtr = &ppv)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ICallFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, Guid*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[3])(@this, riidPtr, pCtrlUnkPtr, riid2Ptr, ppvPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0, TI1>(Guid* riid, ComPtr<TI0> pCtrlUnk, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, SilkMarshal.GuidPtrOf<TI1>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0>(Guid* riid, ComPtr<TI0> pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, riid2, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0, TI1>(Guid* riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0>(Guid* riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0>(Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->CreateCall(riid, ref pCtrlUnk, SilkMarshal.GuidPtrOf<TI0>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0>(Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(riid, ref pCtrlUnk, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCall<TI0, TI1>(ref Guid riid, ComPtr<TI0> pCtrlUnk, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, SilkMarshal.GuidPtrOf<TI1>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0>(ref Guid riid, ComPtr<TI0> pCtrlUnk, Guid* riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, riid2, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCall<TI0, TI1>(ref Guid riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCall<TI0>(ref Guid riid, ComPtr<TI0> pCtrlUnk, ref Guid riid2, ref Silk.NET.Core.Native.IUnknown* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(ref riid, (Silk.NET.Core.Native.IUnknown*) pCtrlUnk.Handle, ref riid2, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCall<TI0>(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->CreateCall(ref riid, ref pCtrlUnk, SilkMarshal.GuidPtrOf<TI0>(), (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCall<TI0>(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk, ref Guid riid2, ref ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCall(ref riid, ref pCtrlUnk, ref riid2, (Silk.NET.Core.Native.IUnknown**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCall<TI0, TI1>(Guid* riid, ComPtr<TI0> pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCall(riid, pCtrlUnk, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCall<TI0>(Guid* riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCall(riid, ref pCtrlUnk, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateCall<TI0, TI1>(ref Guid riid, ComPtr<TI0> pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCall(ref riid, pCtrlUnk, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCall<TI0>(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pCtrlUnk) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ICallFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCall(ref riid, ref pCtrlUnk, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
