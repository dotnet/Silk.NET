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
    [Guid("0000010a-0000-0000-c000-000000000046")]
    [NativeName("Name", "IPersistStorage")]
    public unsafe partial struct IPersistStorage : IComVtbl<IPersistStorage>, IComVtbl<IPersist>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000010a-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IPersist(IPersistStorage val)
            => Unsafe.As<IPersistStorage, IPersist>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPersistStorage val)
            => Unsafe.As<IPersistStorage, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPersistStorage
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
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassID(Guid* pClassID)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassID(ref Guid pClassID)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClassIDPtr = &pClassID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsDirty()
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InitNew(IStorage* pStg)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[5])(@this, pStg);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitNew(ref IStorage pStg)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[5])(@this, pStgPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IStorage* pStg)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[6])(@this, pStg);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IStorage pStg)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[6])(@this, pStgPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Save(IStorage* pStgSave, Silk.NET.Core.Bool32 fSameAsLoad)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pStgSave, fSameAsLoad);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Save(ref IStorage pStgSave, Silk.NET.Core.Bool32 fSameAsLoad)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgSavePtr = &pStgSave)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pStgSavePtr, fSameAsLoad);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveCompleted(IStorage* pStgNew)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[8])(@this, pStgNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveCompleted(ref IStorage pStgNew)
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgNewPtr = &pStgNew)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[8])(@this, pStgNewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HandsOffStorage()
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, int>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int InitNew<TI0>(ComPtr<TI0> pStg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InitNew((IStorage*) pStg.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Load<TI0>(ComPtr<TI0> pStg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Load((IStorage*) pStg.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Save<TI0>(ComPtr<TI0> pStgSave, Silk.NET.Core.Bool32 fSameAsLoad) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Save((IStorage*) pStgSave.Handle, fSameAsLoad);
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveCompleted<TI0>(ComPtr<TI0> pStgNew) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SaveCompleted((IStorage*) pStgNew.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
