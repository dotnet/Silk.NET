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
    [Guid("db2f3ace-2f86-11d1-8e04-00c04fb9989a")]
    [NativeName("Name", "IPipeDouble")]
    public unsafe partial struct IPipeDouble
    {
        public static readonly Guid Guid = new("db2f3ace-2f86-11d1-8e04-00c04fb9989a");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPipeDouble val)
            => Unsafe.As<IPipeDouble, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPipeDouble
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
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Pull(double* buf, uint cRequest, uint* pcReturned)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, double*, uint, uint*, int>)LpVtbl[3])(@this, buf, cRequest, pcReturned);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Pull(double* buf, uint cRequest, ref uint pcReturned)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcReturnedPtr = &pcReturned)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, double*, uint, uint*, int>)LpVtbl[3])(@this, buf, cRequest, pcReturnedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Pull(ref double buf, uint cRequest, uint* pcReturned)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* bufPtr = &buf)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, double*, uint, uint*, int>)LpVtbl[3])(@this, bufPtr, cRequest, pcReturned);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Pull(ref double buf, uint cRequest, ref uint pcReturned)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* bufPtr = &buf)
            {
                fixed (uint* pcReturnedPtr = &pcReturned)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, double*, uint, uint*, int>)LpVtbl[3])(@this, bufPtr, cRequest, pcReturnedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Push(double* buf, uint cSent)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, double*, uint, int>)LpVtbl[4])(@this, buf, cSent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Push(ref double buf, uint cSent)
        {
            var @this = (IPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* bufPtr = &buf)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPipeDouble*, double*, uint, int>)LpVtbl[4])(@this, bufPtr, cSent);
            }
            return ret;
        }

    }
}
