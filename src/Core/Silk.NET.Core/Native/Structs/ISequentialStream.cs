// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
    public unsafe partial struct ISequentialStream
    {
        public static readonly Guid Guid = new("0c733a30-2a1c-11ce-ade5-00aa0044773d");

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

        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>) LpVtbl[0])(@this, riid, ppvObject);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                return ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>) LpVtbl[0])
                    (@this, riid, ppvObjectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                return ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>) LpVtbl[0])
                    (@this, riidPtr, ppvObject);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    return ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>) LpVtbl[0])
                        (@this, riidPtr, ppvObjectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<ISequentialStream*, uint>) LpVtbl[1])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<ISequentialStream*, uint>) LpVtbl[2])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int Read(void* pv, uint cb, uint* pcbRead)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>) LpVtbl[3])(@this, pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        public readonly int Read(void* pv, uint cb, ref uint pcbRead)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                return ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>) LpVtbl[3])(@this, pv, cb, pcbReadPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int Write(void* pv, uint cb, uint* pcbWritten)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>) LpVtbl[4])(@this, pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        public readonly int Write(void* pv, uint cb, ref uint pcbWritten)
        {
            var @this = (ISequentialStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                return ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, uint, uint*, int>) LpVtbl[4])(@this, pv, cb, pcbWrittenPtr);
            }
        }
    }
}
