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
    [Guid("3af24290-0c96-11ce-a0cf-00aa00600ab8")]
    [NativeName("Name", "IAdviseSinkEx")]
    public unsafe partial struct IAdviseSinkEx : IComVtbl<IAdviseSinkEx>, IComVtbl<IAdviseSink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3af24290-0c96-11ce-a0cf-00aa00600ab8");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IAdviseSink(IAdviseSinkEx val)
            => Unsafe.As<IAdviseSinkEx, IAdviseSink>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IAdviseSinkEx val)
            => Unsafe.As<IAdviseSinkEx, Silk.NET.Core.Native.IUnknown>(ref val);

        public IAdviseSinkEx
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
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmed);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnDataChange(FORMATETC* pFormatetc, ref STGMEDIUM pStgmed)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (STGMEDIUM* pStgmedPtr = &pStgmed)
            {
                ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmedPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnDataChange(ref FORMATETC pFormatetc, STGMEDIUM* pStgmed)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FORMATETC* pFormatetcPtr = &pFormatetc)
            {
                ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmed);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OnDataChange(ref FORMATETC pFormatetc, ref STGMEDIUM pStgmed)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FORMATETC* pFormatetcPtr = &pFormatetc)
            {
                fixed (STGMEDIUM* pStgmedPtr = &pStgmed)
                {
                    ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmedPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OnViewChange(uint dwAspect, int lindex)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, uint, int, void>)@this->LpVtbl[4])(@this, dwAspect, lindex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnRename(IMoniker* pmk)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, IMoniker*, void>)@this->LpVtbl[5])(@this, pmk);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnRename(ref IMoniker pmk)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IMoniker* pmkPtr = &pmk)
            {
                ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, IMoniker*, void>)@this->LpVtbl[5])(@this, pmkPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OnSave()
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnClose()
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, void>)@this->LpVtbl[7])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnViewStatusChange(uint dwViewStatus)
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IAdviseSinkEx*, uint, void>)@this->LpVtbl[8])(@this, dwViewStatus);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void OnRename<TI0>(ComPtr<TI0> pmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OnRename((IMoniker*) pmk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAdviseSinkEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
