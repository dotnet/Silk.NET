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
    [Guid("0000013b-0000-0000-c000-000000000046")]
    [NativeName("Name", "IEnumSTATPROPSETSTG")]
    public unsafe partial struct IEnumSTATPROPSETSTG : IComVtbl<IEnumSTATPROPSETSTG>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000013b-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IEnumSTATPROPSETSTG val)
            => Unsafe.As<IEnumSTATPROPSETSTG, Silk.NET.Core.Native.IUnknown>(ref val);

        public IEnumSTATPROPSETSTG
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
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, STATPROPSETSTG* rgelt, uint* pceltFetched)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgelt, pceltFetched);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, STATPROPSETSTG* rgelt, ref uint pceltFetched)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pceltFetchedPtr = &pceltFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgelt, pceltFetchedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref STATPROPSETSTG rgelt, uint* pceltFetched)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (STATPROPSETSTG* rgeltPtr = &rgelt)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltPtr, pceltFetched);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Next(uint celt, ref STATPROPSETSTG rgelt, ref uint pceltFetched)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (STATPROPSETSTG* rgeltPtr = &rgelt)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltPtr, pceltFetchedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Skip(uint celt)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, uint, int>)@this->LpVtbl[4])(@this, celt);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset()
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(IEnumSTATPROPSETSTG** ppenum)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, IEnumSTATPROPSETSTG**, int>)@this->LpVtbl[6])(@this, ppenum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref IEnumSTATPROPSETSTG* ppenum)
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumSTATPROPSETSTG** ppenumPtr = &ppenum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumSTATPROPSETSTG*, IEnumSTATPROPSETSTG**, int>)@this->LpVtbl[6])(@this, ppenumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumSTATPROPSETSTG>, IComVtbl<TI0>
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((IEnumSTATPROPSETSTG**) ppenum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumSTATPROPSETSTG*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
