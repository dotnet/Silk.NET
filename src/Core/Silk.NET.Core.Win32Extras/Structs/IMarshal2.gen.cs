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
    [Guid("000001cf-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMarshal2")]
    public unsafe partial struct IMarshal2 : IComVtbl<IMarshal2>, IComVtbl<IMarshal>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("000001cf-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IMarshal(IMarshal2 val)
            => Unsafe.As<IMarshal2, IMarshal>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMarshal2 val)
            => Unsafe.As<IMarshal2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMarshal2
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
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass(Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass(Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCidPtr = &pCid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pCidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pCid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (Guid* pCidPtr = &pCid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pCid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (Guid* pCidPtr = &pCid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pCidPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0, T1>(Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCid);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0, T1>(Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (Guid* pCidPtr = &pCid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass(ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pCid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass(ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Guid* pCidPtr = &pCid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pCidPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pCid);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (Guid* pCidPtr = &pCid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pCid);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0>(ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (Guid* pCidPtr = &pCid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pCidPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass<T0, T1>(ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCid);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetUnmarshalClass<T0, T1>(ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        fixed (Guid* pCidPtr = &pCid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax(Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax(Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizePtr = &pSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0, T1>(Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0, T1>(Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (uint* pSizePtr = &pSize)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax(ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax(ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (uint* pSizePtr = &pSize)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0>(ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (uint* pSizePtr = &pSize)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax<T0, T1>(ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSize);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMarshalSizeMax<T0, T1>(ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        fixed (uint* pSizePtr = &pSize)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pv, dwDestContext, pvDestContextPtr, mshlflags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pvPtr, dwDestContext, pvDestContext, mshlflags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, T1>(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pv, dwDestContext, pvDestContext, mshlflags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, T1>(Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface(ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pv, dwDestContext, pvDestContext, mshlflags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pv, dwDestContext, pvDestContextPtr, mshlflags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (void* pvPtr = &pv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pvPtr, dwDestContext, pvDestContext, mshlflags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, T1>(ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface(ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pv, dwDestContext, pvDestContext, mshlflags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0>(ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void* pvPtr = &pv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MarshalInterface<T0, T1>(ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void* pvPtr = &pv)
                    {
                        fixed (void* pvDestContextPtr = &pvDestContext)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void** ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, ref void* ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, void** ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, ref void* ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, void** ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, ref void* ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, void** ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, ref void* ppv)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseMarshalData(Silk.NET.Core.Win32Extras.IStream* pStm)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[7])(@this, pStm);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseMarshalData(ref Silk.NET.Core.Win32Extras.IStream pStm)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[7])(@this, pStmPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DisconnectObject(uint dwReserved)
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, uint, int>)@this->LpVtbl[8])(@this, dwReserved);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<TI0>(ComPtr<TI0> pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, TI0>(ComPtr<TI0> pStm, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, pv, dwDestContext, ref pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, TI0>(ComPtr<TI0> pStm, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, ref pv, dwDestContext, pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, T1, TI0>(ComPtr<TI0> pStm, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, ref pv, dwDestContext, ref pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<TI0>(ComPtr<TI0> pStm, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, TI0>(ComPtr<TI0> pStm, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, pv, dwDestContext, ref pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface<T0, TI0>(ComPtr<TI0> pStm, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ref pv, dwDestContext, pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly int MarshalInterface<T0, T1, TI0>(ComPtr<TI0> pStm, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ref pv, dwDestContext, ref pvDestContext, mshlflags);
        }

        /// <summary>To be documented.</summary>
        public readonly int UnmarshalInterface<TI0, TI1>(ComPtr<TI0> pStm, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface<TI0>(ComPtr<TI0> pStm, Guid* riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface<TI0>(ComPtr<TI0> pStm, ref Guid riid, void** ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface<TI0>(ComPtr<TI0> pStm, ref Guid riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ref ppv);
        }

        /// <summary>To be documented.</summary>
        public readonly int UnmarshalInterface<TI0>(ref Silk.NET.Core.Win32Extras.IStream pStm, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->UnmarshalInterface(ref pStm, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseMarshalData<TI0>(ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ReleaseMarshalData((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> UnmarshalInterface<TI0, TI1>(ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->UnmarshalInterface(pStm, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> UnmarshalInterface<TI0>(ref Silk.NET.Core.Win32Extras.IStream pStm) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMarshal2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->UnmarshalInterface(ref pStm, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
