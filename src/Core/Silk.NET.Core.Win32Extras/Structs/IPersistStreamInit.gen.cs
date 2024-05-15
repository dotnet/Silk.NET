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
    [Guid("7fd52380-4e07-101b-ae2d-08002b2ec713")]
    [NativeName("Name", "IPersistStreamInit")]
    public unsafe partial struct IPersistStreamInit : IComVtbl<IPersistStreamInit>, IComVtbl<IPersist>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7fd52380-4e07-101b-ae2d-08002b2ec713");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IPersist(IPersistStreamInit val)
            => Unsafe.As<IPersistStreamInit, IPersist>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPersistStreamInit val)
            => Unsafe.As<IPersistStreamInit, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPersistStreamInit
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
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassID(Guid* pClassID)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassID(ref Guid pClassID)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClassIDPtr = &pClassID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsDirty()
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(Silk.NET.Core.Win32Extras.IStream* pStm)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStm);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref Silk.NET.Core.Win32Extras.IStream pStm)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStmPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Save(Silk.NET.Core.Win32Extras.IStream* pStm, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStm, fClearDirty);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Save(ref Silk.NET.Core.Win32Extras.IStream pStm, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStmPtr, fClearDirty);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSizeMax(ulong* pCbSize)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, ulong*, int>)@this->LpVtbl[7])(@this, pCbSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSizeMax(ref ulong pCbSize)
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pCbSizePtr = &pCbSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, ulong*, int>)@this->LpVtbl[7])(@this, pCbSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitNew()
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, int>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Load<TI0>(ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Load((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Save<TI0>(ComPtr<TI0> pStm, Silk.NET.Core.Bool32 fClearDirty) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Save((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, fClearDirty);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistStreamInit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
