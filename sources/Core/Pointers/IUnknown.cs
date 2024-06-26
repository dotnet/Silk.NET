// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.Core.Pointers
{
    /// <summary>
    /// Enables clients to get pointers to other interfaces on a given object through the QueryInterface method, and manage the existence of the object through the AddRef and Release methods. All other COM interfaces are inherited, directly or indirectly, from IUnknown. Therefore, the three methods in IUnknown are the first entries in the vtable for every interface.
    /// </summary>
    [Guid("00000000-0000-0000-c000-000000000046")]
    public unsafe partial struct IUnknown : IComVtbl<IUnknown>
    {
        /// <summary>
        /// Pointer to table of virtual function pointers
        /// </summary>
        public void** LpVtbl;
        /// <summary>Queries a COM object for a pointer to one of its interface; identifying the interface by a reference to its interface identifier (IID). If the COM object implements the interface, then it returns a pointer to that interface after calling IUnknown.AddRef on it.</summary>
        public readonly int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IUnknown*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
        }

        /// <summary>Queries a COM object for a pointer to one of its interface; identifying the interface by a reference to its interface identifier (IID). If the COM object implements the interface, then it returns a pointer to that interface after calling IUnknown.AddRef on it.</summary>
        public readonly int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IUnknown*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>)LpVtbl[0])
                    (@this, riid, ppvObjectPtr);
            }
        }

        /// <summary>Queries a COM object for a pointer to one of its interface; identifying the interface by a reference to its interface identifier (IID). If the COM object implements the interface, then it returns a pointer to that interface after calling IUnknown.AddRef on it.</summary>
        public readonly int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IUnknown*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>)LpVtbl[0])
                    (@this, riidPtr, ppvObject);
            }
        }

        /// <summary>Queries a COM object for a pointer to one of its interface; identifying the interface by a reference to its interface identifier (IID). If the COM object implements the interface, then it returns a pointer to that interface after calling IUnknown.AddRef on it.</summary>
        public readonly int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IUnknown*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>)LpVtbl[0])
                        (@this, riidPtr, ppvObjectPtr);
                }
            }
        }

        /// <summary>Increments the reference count for an interface pointer to a COM object. You should call this method whenever you make a copy of an interface pointer</summary>
        public readonly uint AddRef()
        {
            var @this = (IUnknown*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IUnknown*, uint>)LpVtbl[1])(@this);
        }

        /// <summary>Decrements the reference count for an interface on a COM object.</summary>
        public readonly uint Release()
        {
            var @this = (IUnknown*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IUnknown*, uint>)LpVtbl[2])(@this);
        }

        void*** IComVtbl.AsVtblPtr() => (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    }
}
