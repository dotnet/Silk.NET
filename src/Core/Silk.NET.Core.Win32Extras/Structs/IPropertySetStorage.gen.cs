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
    [Guid("0000013a-0000-0000-c000-000000000046")]
    [NativeName("Name", "IPropertySetStorage")]
    public unsafe partial struct IPropertySetStorage : IComVtbl<IPropertySetStorage>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000013a-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPropertySetStorage val)
            => Unsafe.As<IPropertySetStorage, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPropertySetStorage
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
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsid, grfFlags, grfMode, ppprstg);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsid, grfFlags, grfMode, ppprstgPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pclsidPtr = &pclsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsidPtr, grfFlags, grfMode, ppprstg);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pclsidPtr = &pclsid)
            {
                fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsidPtr, grfFlags, grfMode, ppprstgPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rfmtidPtr = &rfmtid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsid, grfFlags, grfMode, ppprstg);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rfmtidPtr = &rfmtid)
            {
                fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsid, grfFlags, grfMode, ppprstgPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rfmtidPtr = &rfmtid)
            {
                fixed (Guid* pclsidPtr = &pclsid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsidPtr, grfFlags, grfMode, ppprstg);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create(ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rfmtidPtr = &rfmtid)
            {
                fixed (Guid* pclsidPtr = &pclsid)
                {
                    fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsidPtr, grfFlags, grfMode, ppprstgPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(Guid* rfmtid, uint grfMode, IPropertyStorage** ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtid, grfMode, ppprstg);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(Guid* rfmtid, uint grfMode, ref IPropertyStorage* ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtid, grfMode, ppprstgPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(ref Guid rfmtid, uint grfMode, IPropertyStorage** ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rfmtidPtr = &rfmtid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtidPtr, grfMode, ppprstg);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(ref Guid rfmtid, uint grfMode, ref IPropertyStorage* ppprstg)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rfmtidPtr = &rfmtid)
            {
                fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtidPtr, grfMode, ppprstgPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Delete(Guid* rfmtid)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, int>)@this->LpVtbl[5])(@this, rfmtid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Delete(ref Guid rfmtid)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rfmtidPtr = &rfmtid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, int>)@this->LpVtbl[5])(@this, rfmtidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Enum(IEnumSTATPROPSETSTG** ppenum)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, IEnumSTATPROPSETSTG**, int>)@this->LpVtbl[6])(@this, ppenum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Enum(ref IEnumSTATPROPSETSTG* ppenum)
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumSTATPROPSETSTG** ppenumPtr = &ppenum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, IEnumSTATPROPSETSTG**, int>)@this->LpVtbl[6])(@this, ppenumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create<TI0>(Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Create(rfmtid, pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create<TI0>(Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Create(rfmtid, in pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Create<TI0>(ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Create(ref rfmtid, pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Create<TI0>(ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Create(ref rfmtid, in pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<TI0>(Guid* rfmtid, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Open(rfmtid, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Open<TI0>(ref Guid rfmtid, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Open(ref rfmtid, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Enum<TI0>(ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumSTATPROPSETSTG>, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Enum((IEnumSTATPROPSETSTG**) ppenum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertySetStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
