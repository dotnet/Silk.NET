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
    [Guid("00000110-0000-0000-c000-000000000046")]
    [NativeName("Name", "IDataAdviseHolder")]
    public unsafe partial struct IDataAdviseHolder : IComVtbl<IDataAdviseHolder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000110-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDataAdviseHolder val)
            => Unsafe.As<IDataAdviseHolder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDataAdviseHolder
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
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvise, pdwConnection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwConnectionPtr = &pdwConnection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvise, pdwConnectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IAdviseSink* pAdvisePtr = &pAdvise)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvisePtr, pdwConnection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IAdviseSink* pAdvisePtr = &pAdvise)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetc, advf, pAdvisePtr, pdwConnectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvise, pdwConnection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvise, pdwConnectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvisePtr, pdwConnection);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(IDataObject* pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pFetcPtr = &pFetc)
            {
                fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                {
                    fixed (uint* pdwConnectionPtr = &pdwConnection)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObject, pFetcPtr, advf, pAdvisePtr, pdwConnectionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvise, pdwConnection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvise, pdwConnectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvisePtr, pdwConnection);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                {
                    fixed (uint* pdwConnectionPtr = &pdwConnection)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetc, advf, pAdvisePtr, pdwConnectionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                fixed (FORMATETC* pFetcPtr = &pFetc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvise, pdwConnection);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, IAdviseSink* pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                fixed (FORMATETC* pFetcPtr = &pFetc)
                {
                    fixed (uint* pdwConnectionPtr = &pdwConnection)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvise, pdwConnectionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                fixed (FORMATETC* pFetcPtr = &pFetc)
                {
                    fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvisePtr, pdwConnection);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Advise(ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                fixed (FORMATETC* pFetcPtr = &pFetc)
                {
                    fixed (IAdviseSink* pAdvisePtr = &pAdvise)
                    {
                        fixed (uint* pdwConnectionPtr = &pdwConnection)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[3])(@this, pDataObjectPtr, pFetcPtr, advf, pAdvisePtr, pdwConnectionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Unadvise(uint dwConnection)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, uint, int>)@this->LpVtbl[4])(@this, dwConnection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdvise(IEnumSTATDATA** ppenumAdvise)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IEnumSTATDATA**, int>)@this->LpVtbl[5])(@this, ppenumAdvise);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdvise(ref IEnumSTATDATA* ppenumAdvise)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumSTATDATA** ppenumAdvisePtr = &ppenumAdvise)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IEnumSTATDATA**, int>)@this->LpVtbl[5])(@this, ppenumAdvisePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendOnDataChange(IDataObject* pDataObject, uint dwReserved, uint advf)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, uint, uint, int>)@this->LpVtbl[6])(@this, pDataObject, dwReserved, advf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SendOnDataChange(ref IDataObject pDataObject, uint dwReserved, uint advf)
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDataObject* pDataObjectPtr = &pDataObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataAdviseHolder*, IDataObject*, uint, uint, int>)@this->LpVtbl[6])(@this, pDataObjectPtr, dwReserved, advf);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0, TI1>(ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI1> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0, TI1>(ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI1> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0>(ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, ref pAdvise, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0>(ComPtr<TI0> pDataObject, FORMATETC* pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, pFetc, advf, ref pAdvise, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0, TI1>(ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI1> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly int Advise<TI0, TI1>(ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI1> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI1>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0>(ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, ref pAdvise, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly int Advise<TI0>(ComPtr<TI0> pDataObject, ref FORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((IDataObject*) pDataObject.Handle, ref pFetc, advf, ref pAdvise, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0>(ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI0> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise(ref pDataObject, pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0>(ref IDataObject pDataObject, FORMATETC* pFetc, uint advf, ComPtr<TI0> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise(ref pDataObject, pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0>(ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI0> pAdvise, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise(ref pDataObject, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly int Advise<TI0>(ref IDataObject pDataObject, ref FORMATETC pFetc, uint advf, ComPtr<TI0> pAdvise, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise(ref pDataObject, ref pFetc, advf, (IAdviseSink*) pAdvise.Handle, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdvise<TI0>(ref ComPtr<TI0> ppenumAdvise) where TI0 : unmanaged, IComVtbl<IEnumSTATDATA>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumAdvise((IEnumSTATDATA**) ppenumAdvise.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SendOnDataChange<TI0>(ComPtr<TI0> pDataObject, uint dwReserved, uint advf) where TI0 : unmanaged, IComVtbl<IDataObject>, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SendOnDataChange((IDataObject*) pDataObject.Handle, dwReserved, advf);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDataAdviseHolder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
