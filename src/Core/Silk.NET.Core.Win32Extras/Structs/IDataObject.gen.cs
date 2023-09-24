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
    [Guid("0000010e-0000-0000-c000-000000000046")]
    [NativeName("Name", "IDataObject")]
    public unsafe partial struct IDataObject : IComVtbl<IDataObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000010e-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDataObject val)
            => Unsafe.As<IDataObject, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDataObject
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
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(FORMATETC* pformatetcIn, STGMEDIUM* pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcIn, pmedium);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(FORMATETC* pformatetcIn, ref STGMEDIUM pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (STGMEDIUM* pmediumPtr = &pmedium)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcIn, pmediumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(ref FORMATETC pformatetcIn, STGMEDIUM* pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcInPtr = &pformatetcIn)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcInPtr, pmedium);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetData(ref FORMATETC pformatetcIn, ref STGMEDIUM pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcInPtr = &pformatetcIn)
            {
                fixed (STGMEDIUM* pmediumPtr = &pmedium)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[3])(@this, pformatetcInPtr, pmediumPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataHere(FORMATETC* pformatetc, STGMEDIUM* pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetc, pmedium);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataHere(FORMATETC* pformatetc, ref STGMEDIUM pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (STGMEDIUM* pmediumPtr = &pmedium)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetc, pmediumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataHere(ref FORMATETC pformatetc, STGMEDIUM* pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetcPtr, pmedium);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDataHere(ref FORMATETC pformatetc, ref STGMEDIUM pmedium)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                fixed (STGMEDIUM* pmediumPtr = &pmedium)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)@this->LpVtbl[4])(@this, pformatetcPtr, pmediumPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryGetData(FORMATETC* pformatetc)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, int>)@this->LpVtbl[5])(@this, pformatetc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryGetData(ref FORMATETC pformatetc)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, int>)@this->LpVtbl[5])(@this, pformatetcPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCanonicalFormatEtc(FORMATETC* pformatectIn, FORMATETC* pformatetcOut)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectIn, pformatetcOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCanonicalFormatEtc(FORMATETC* pformatectIn, ref FORMATETC pformatetcOut)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcOutPtr = &pformatetcOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectIn, pformatetcOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCanonicalFormatEtc(ref FORMATETC pformatectIn, FORMATETC* pformatetcOut)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatectInPtr = &pformatectIn)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectInPtr, pformatetcOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCanonicalFormatEtc(ref FORMATETC pformatectIn, ref FORMATETC pformatetcOut)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatectInPtr = &pformatectIn)
            {
                fixed (FORMATETC* pformatetcOutPtr = &pformatetcOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, FORMATETC*, int>)@this->LpVtbl[6])(@this, pformatectInPtr, pformatetcOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, Silk.NET.Core.Bool32 fRelease)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetc, pmedium, fRelease);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetData(FORMATETC* pformatetc, ref STGMEDIUM pmedium, Silk.NET.Core.Bool32 fRelease)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (STGMEDIUM* pmediumPtr = &pmedium)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetc, pmediumPtr, fRelease);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetData(ref FORMATETC pformatetc, STGMEDIUM* pmedium, Silk.NET.Core.Bool32 fRelease)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetcPtr, pmedium, fRelease);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetData(ref FORMATETC pformatetc, ref STGMEDIUM pmedium, Silk.NET.Core.Bool32 fRelease)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                fixed (STGMEDIUM* pmediumPtr = &pmedium)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, STGMEDIUM*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pformatetcPtr, pmediumPtr, fRelease);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumFormatEtc(uint dwDirection, IEnumFORMATETC** ppenumFormatEtc)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint, IEnumFORMATETC**, int>)@this->LpVtbl[8])(@this, dwDirection, ppenumFormatEtc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumFormatEtc(uint dwDirection, ref IEnumFORMATETC* ppenumFormatEtc)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumFORMATETC** ppenumFormatEtcPtr = &ppenumFormatEtc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint, IEnumFORMATETC**, int>)@this->LpVtbl[8])(@this, dwDirection, ppenumFormatEtcPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise(FORMATETC* pformatetc, uint advf, IAdviseSink* pAdvSink, uint* pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSink, pdwConnection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise(FORMATETC* pformatetc, uint advf, IAdviseSink* pAdvSink, ref uint pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwConnectionPtr = &pdwConnection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSink, pdwConnectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise(FORMATETC* pformatetc, uint advf, ref IAdviseSink pAdvSink, uint* pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSinkPtr, pdwConnection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise(FORMATETC* pformatetc, uint advf, ref IAdviseSink pAdvSink, ref uint pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetc, advf, pAdvSinkPtr, pdwConnectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise(ref FORMATETC pformatetc, uint advf, IAdviseSink* pAdvSink, uint* pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSink, pdwConnection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise(ref FORMATETC pformatetc, uint advf, IAdviseSink* pAdvSink, ref uint pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                fixed (uint* pdwConnectionPtr = &pdwConnection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSink, pdwConnectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise(ref FORMATETC pformatetc, uint advf, ref IAdviseSink pAdvSink, uint* pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSinkPtr, pdwConnection);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DAdvise(ref FORMATETC pformatetc, uint advf, ref IAdviseSink pAdvSink, ref uint pdwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* pformatetcPtr = &pformatetc)
            {
                fixed (IAdviseSink* pAdvSinkPtr = &pAdvSink)
                {
                    fixed (uint* pdwConnectionPtr = &pdwConnection)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)@this->LpVtbl[9])(@this, pformatetcPtr, advf, pAdvSinkPtr, pdwConnectionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DUnadvise(uint dwConnection)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, uint, int>)@this->LpVtbl[10])(@this, dwConnection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumDAdvise(IEnumSTATDATA** ppenumAdvise)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDataObject*, IEnumSTATDATA**, int>)@this->LpVtbl[11])(@this, ppenumAdvise);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumDAdvise(ref IEnumSTATDATA* ppenumAdvise)
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumSTATDATA** ppenumAdvisePtr = &ppenumAdvise)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDataObject*, IEnumSTATDATA**, int>)@this->LpVtbl[11])(@this, ppenumAdvisePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumFormatEtc<TI0>(uint dwDirection, ref ComPtr<TI0> ppenumFormatEtc) where TI0 : unmanaged, IComVtbl<IEnumFORMATETC>, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumFormatEtc(dwDirection, (IEnumFORMATETC**) ppenumFormatEtc.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise<TI0>(FORMATETC* pformatetc, uint advf, ComPtr<TI0> pAdvSink, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DAdvise(pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise<TI0>(FORMATETC* pformatetc, uint advf, ComPtr<TI0> pAdvSink, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DAdvise(pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DAdvise<TI0>(ref FORMATETC pformatetc, uint advf, ComPtr<TI0> pAdvSink, uint* pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DAdvise(ref pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly int DAdvise<TI0>(ref FORMATETC pformatetc, uint advf, ComPtr<TI0> pAdvSink, ref uint pdwConnection) where TI0 : unmanaged, IComVtbl<IAdviseSink>, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DAdvise(ref pformatetc, advf, (IAdviseSink*) pAdvSink.Handle, ref pdwConnection);
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumDAdvise<TI0>(ref ComPtr<TI0> ppenumAdvise) where TI0 : unmanaged, IComVtbl<IEnumSTATDATA>, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumDAdvise((IEnumSTATDATA**) ppenumAdvise.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDataObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
