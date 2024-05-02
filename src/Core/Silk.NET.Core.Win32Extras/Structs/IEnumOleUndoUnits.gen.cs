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
    [Guid("b3e7c340-ef97-11ce-9bc9-00aa00608e01")]
    [NativeName("Name", "IEnumOleUndoUnits")]
    public unsafe partial struct IEnumOleUndoUnits : IComVtbl<IEnumOleUndoUnits>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b3e7c340-ef97-11ce-9bc9-00aa00608e01");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IEnumOleUndoUnits val)
            => Unsafe.As<IEnumOleUndoUnits, Silk.NET.Core.Native.IUnknown>(ref val);

        public IEnumOleUndoUnits
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
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cElt, IOleUndoUnit** rgElt, uint* pcEltFetched)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgElt, pcEltFetched);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cElt, IOleUndoUnit** rgElt, ref uint pcEltFetched)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcEltFetchedPtr = &pcEltFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgElt, pcEltFetchedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cElt, ref IOleUndoUnit* rgElt, uint* pcEltFetched)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleUndoUnit** rgEltPtr = &rgElt)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgEltPtr, pcEltFetched);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cElt, ref IOleUndoUnit* rgElt, ref uint pcEltFetched)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleUndoUnit** rgEltPtr = &rgElt)
            {
                fixed (uint* pcEltFetchedPtr = &pcEltFetched)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgEltPtr, pcEltFetchedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Skip(uint cElt)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, int>)@this->LpVtbl[4])(@this, cElt);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset()
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(IEnumOleUndoUnits** ppEnum)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int>)@this->LpVtbl[6])(@this, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref IEnumOleUndoUnits* ppEnum)
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumOleUndoUnits** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int>)@this->LpVtbl[6])(@this, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next<TI0>(uint cElt, ref ComPtr<TI0> rgElt, uint* pcEltFetched) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Next(cElt, (IOleUndoUnit**) rgElt.GetAddressOf(), pcEltFetched);
        }

        /// <summary>To be documented.</summary>
        public readonly int Next<TI0>(uint cElt, ref ComPtr<TI0> rgElt, ref uint pcEltFetched) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Next(cElt, (IOleUndoUnit**) rgElt.GetAddressOf(), ref pcEltFetched);
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumOleUndoUnits>, IComVtbl<TI0>
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((IEnumOleUndoUnits**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumOleUndoUnits*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
