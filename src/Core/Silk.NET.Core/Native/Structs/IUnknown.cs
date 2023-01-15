// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    [Guid("00000000-0000-0000-c000-000000000046")]
    public unsafe partial struct IUnknown : IComVtbl<IUnknown>
    {
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IUnknown*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>) LpVtbl[0])(@this, riid, ppvObject);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IUnknown*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>) LpVtbl[0])
                    (@this, riid, ppvObjectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IUnknown*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>) LpVtbl[0])
                    (@this, riidPtr, ppvObject);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IUnknown*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>) LpVtbl[0])
                        (@this, riidPtr, ppvObjectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IUnknown*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IUnknown*, uint>) LpVtbl[1])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IUnknown*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IUnknown*, uint>) LpVtbl[2])(@this);
        }

        void*** IComVtbl.AsVtblPtr() => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    }
}
