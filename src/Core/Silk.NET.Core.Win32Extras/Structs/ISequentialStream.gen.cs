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
    [Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
    [NativeName("Name", "ISequentialStream")]
    public unsafe partial struct ISequentialStream : IComVtbl<ISequentialStream>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0c733a30-2a1c-11ce-ade5-00aa0044773d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ISequentialStream val)
            => Unsafe.As<ISequentialStream, Silk.NET.Core.Native.IUnknown>(ref val);

        public ISequentialStream
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
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(void* pv, uint cb, uint* pcbRead)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbRead);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(void* pv, uint cb, ref uint pcbRead)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbReadPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<T0>(ref T0 pv, uint cb, uint* pcbRead) where T0 : unmanaged
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbRead);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Read<T0>(ref T0 pv, uint cb, ref uint pcbRead) where T0 : unmanaged
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (uint* pcbReadPtr = &pcbRead)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbReadPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWritten);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, ref uint pcbWritten)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWrittenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pvPtr, cb, pcbWritten);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Write<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pvPtr, cb, pcbWrittenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
