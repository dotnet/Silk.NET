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
    [Guid("00000151-0000-0000-c000-000000000046")]
    [NativeName("Name", "AsyncIAdviseSink2")]
    public unsafe partial struct AsyncIAdviseSink2 : IComVtbl<AsyncIAdviseSink2>, IComVtbl<AsyncIAdviseSink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000151-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator AsyncIAdviseSink(AsyncIAdviseSink2 val)
            => Unsafe.As<AsyncIAdviseSink2, AsyncIAdviseSink>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(AsyncIAdviseSink2 val)
            => Unsafe.As<AsyncIAdviseSink2, Silk.NET.Core.Native.IUnknown>(ref val);

        public AsyncIAdviseSink2
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
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginOnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmed);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginOnDataChange(FORMATETC* pFormatetc, ref STGMEDIUM pStgmed)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (STGMEDIUM* pStgmedPtr = &pStgmed)
            {
                ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetc, pStgmedPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginOnDataChange(ref FORMATETC pFormatetc, STGMEDIUM* pStgmed)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FORMATETC* pFormatetcPtr = &pFormatetc)
            {
                ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmed);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnDataChange(ref FORMATETC pFormatetc, ref STGMEDIUM pStgmed)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FORMATETC* pFormatetcPtr = &pFormatetc)
            {
                fixed (STGMEDIUM* pStgmedPtr = &pStgmed)
                {
                    ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)@this->LpVtbl[3])(@this, pFormatetcPtr, pStgmedPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishOnDataChange()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnViewChange(uint dwAspect, int lindex)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, uint, int, void>)@this->LpVtbl[5])(@this, dwAspect, lindex);
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishOnViewChange()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginOnRename(IMoniker* pmk)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[7])(@this, pmk);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnRename(ref IMoniker pmk)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IMoniker* pmkPtr = &pmk)
            {
                ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[7])(@this, pmkPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishOnRename()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[8])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnSave()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishOnSave()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[10])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnClose()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[11])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishOnClose()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[12])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginOnLinkSrcChange(IMoniker* pmk)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[13])(@this, pmk);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnLinkSrcChange(ref IMoniker pmk)
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IMoniker* pmkPtr = &pmk)
            {
                ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, IMoniker*, void>)@this->LpVtbl[13])(@this, pmkPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishOnLinkSrcChange()
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<AsyncIAdviseSink2*, void>)@this->LpVtbl[14])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnRename<TI0>(ComPtr<TI0> pmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->BeginOnRename((IMoniker*) pmk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginOnLinkSrcChange<TI0>(ComPtr<TI0> pmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->BeginOnLinkSrcChange((IMoniker*) pmk.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (AsyncIAdviseSink2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
