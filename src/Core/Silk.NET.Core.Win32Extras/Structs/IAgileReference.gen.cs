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
    [Guid("c03f6a43-65a4-9818-987e-e0b810d2a6f2")]
    [NativeName("Name", "IAgileReference")]
    public unsafe partial struct IAgileReference
    {
        public static readonly Guid Guid = new("c03f6a43-65a4-9818-987e-e0b810d2a6f2");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IAgileReference val)
            => Unsafe.As<IAgileReference, Silk.NET.Core.Native.IUnknown>(ref val);

        public IAgileReference
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
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Resolve(Guid* riid, void** ppvObjectReference)
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[3])(@this, riid, ppvObjectReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Resolve(Guid* riid, ref void* ppvObjectReference)
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectReferencePtr = &ppvObjectReference)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[3])(@this, riid, ppvObjectReferencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Resolve(ref Guid riid, void** ppvObjectReference)
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[3])(@this, riidPtr, ppvObjectReference);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Resolve(ref Guid riid, ref void* ppvObjectReference)
        {
            var @this = (IAgileReference*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectReferencePtr = &ppvObjectReference)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAgileReference*, Guid*, void**, int>)LpVtbl[3])(@this, riidPtr, ppvObjectReferencePtr);
                }
            }
            return ret;
        }

    }
}
