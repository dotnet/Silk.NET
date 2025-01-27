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
    [Guid("a7aba9c1-8983-11cf-8f20-00805f2cd064")]
    [NativeName("Name", "IProvideMultipleClassInfo")]
    public unsafe partial struct IProvideMultipleClassInfo : IComVtbl<IProvideMultipleClassInfo>, IComVtbl<IProvideClassInfo2>, IComVtbl<IProvideClassInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a7aba9c1-8983-11cf-8f20-00805f2cd064");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IProvideClassInfo2(IProvideMultipleClassInfo val)
            => Unsafe.As<IProvideMultipleClassInfo, IProvideClassInfo2>(ref val);

        public static implicit operator IProvideClassInfo(IProvideMultipleClassInfo val)
            => Unsafe.As<IProvideMultipleClassInfo, IProvideClassInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IProvideMultipleClassInfo val)
            => Unsafe.As<IProvideMultipleClassInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IProvideMultipleClassInfo
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
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInfoA(ITypeInfo** ppTI)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, ITypeInfo**, int>)@this->LpVtbl[3])(@this, ppTI);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInfoA(ref ITypeInfo* ppTI)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTIPtr = &ppTI)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, ITypeInfo**, int>)@this->LpVtbl[3])(@this, ppTIPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGUID(uint dwGuidKind, Guid* pGUID)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, Guid*, int>)@this->LpVtbl[4])(@this, dwGuidKind, pGUID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGUID(uint dwGuidKind, ref Guid pGUID)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pGUIDPtr = &pGUID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, Guid*, int>)@this->LpVtbl[4])(@this, dwGuidKind, pGUIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMultiTypeInfoCount(uint* pcti)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint*, int>)@this->LpVtbl[5])(@this, pcti);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMultiTypeInfoCount(ref uint pcti)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pctiPtr = &pcti)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint*, int>)@this->LpVtbl[5])(@this, pctiPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* piidSourcePtr = &piidSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        fixed (Guid* piidSourcePtr = &piidSource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimary, piidSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        fixed (Guid* piidSourcePtr = &piidSource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        fixed (Guid* piidSourcePtr = &piidSource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                    {
                        fixed (Guid* piidSourcePtr = &piidSource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                    {
                        fixed (Guid* piidPrimaryPtr = &piidPrimary)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex(uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
            {
                fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
                {
                    fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                    {
                        fixed (Guid* piidPrimaryPtr = &piidPrimary)
                        {
                            fixed (Guid* piidSourcePtr = &piidSource)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassInfoA<TI0>(ref ComPtr<TI0> ppTI) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetClassInfoA((ITypeInfo**) ppTI.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, ref piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, ref piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, ref piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, ref piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, ref piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, ref piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, ref piidPrimary, piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInfoOfIndex<TI0>(uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, ref piidPrimary, ref piidSource);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IProvideMultipleClassInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
