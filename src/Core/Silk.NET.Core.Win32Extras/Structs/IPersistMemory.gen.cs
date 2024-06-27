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
    [Guid("bd1ae5e0-a6ae-11ce-bd37-504200c10000")]
    [NativeName("Name", "IPersistMemory")]
    public unsafe partial struct IPersistMemory : IComVtbl<IPersistMemory>, IComVtbl<IPersist>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("bd1ae5e0-a6ae-11ce-bd37-504200c10000");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IPersist(IPersistMemory val)
            => Unsafe.As<IPersistMemory, IPersist>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPersistMemory val)
            => Unsafe.As<IPersistMemory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPersistMemory
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
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassID(Guid* pClassID)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassID(ref Guid pClassID)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClassIDPtr = &pClassID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsDirty()
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(void* pMem, uint cbSize)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, uint, int>)@this->LpVtbl[5])(@this, pMem, cbSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load<T0>(ref T0 pMem, uint cbSize) where T0 : unmanaged
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pMemPtr = &pMem)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, uint, int>)@this->LpVtbl[5])(@this, pMemPtr, cbSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Save(void* pMem, Silk.NET.Core.Bool32 fClearDirty, uint cbSize)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, Silk.NET.Core.Bool32, uint, int>)@this->LpVtbl[6])(@this, pMem, fClearDirty, cbSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Save<T0>(ref T0 pMem, Silk.NET.Core.Bool32 fClearDirty, uint cbSize) where T0 : unmanaged
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pMemPtr = &pMem)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, Silk.NET.Core.Bool32, uint, int>)@this->LpVtbl[6])(@this, pMemPtr, fClearDirty, cbSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSizeMax(uint* pCbSize)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint*, int>)@this->LpVtbl[7])(@this, pCbSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSizeMax(ref uint pCbSize)
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCbSizePtr = &pCbSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint*, int>)@this->LpVtbl[7])(@this, pCbSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitNew()
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, int>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistMemory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
