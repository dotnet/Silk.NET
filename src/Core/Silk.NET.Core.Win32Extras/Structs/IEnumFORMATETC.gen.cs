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
    [Guid("00000103-0000-0000-c000-000000000046")]
    [NativeName("Name", "IEnumFORMATETC")]
    public unsafe partial struct IEnumFORMATETC : IComVtbl<IEnumFORMATETC>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000103-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IEnumFORMATETC val)
            => Unsafe.As<IEnumFORMATETC, Silk.NET.Core.Native.IUnknown>(ref val);

        public IEnumFORMATETC
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
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, FORMATETC* rgelt, uint* pceltFetched)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgelt, pceltFetched);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, FORMATETC* rgelt, ref uint pceltFetched)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pceltFetchedPtr = &pceltFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgelt, pceltFetchedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref FORMATETC rgelt, uint* pceltFetched)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* rgeltPtr = &rgelt)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltPtr, pceltFetched);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Next(uint celt, ref FORMATETC rgelt, ref uint pceltFetched)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FORMATETC* rgeltPtr = &rgelt)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltPtr, pceltFetchedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Skip(uint celt)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, int>)@this->LpVtbl[4])(@this, celt);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset()
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(IEnumFORMATETC** ppenum)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, IEnumFORMATETC**, int>)@this->LpVtbl[6])(@this, ppenum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref IEnumFORMATETC* ppenum)
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumFORMATETC** ppenumPtr = &ppenum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, IEnumFORMATETC**, int>)@this->LpVtbl[6])(@this, ppenumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumFORMATETC>, IComVtbl<TI0>
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((IEnumFORMATETC**) ppenum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumFORMATETC*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
