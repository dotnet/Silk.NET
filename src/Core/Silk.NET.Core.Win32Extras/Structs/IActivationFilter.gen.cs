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
    [Guid("00000017-0000-0000-c000-000000000046")]
    [NativeName("Name", "IActivationFilter")]
    public unsafe partial struct IActivationFilter
    {
        public static readonly Guid Guid = new("00000017-0000-0000-c000-000000000046");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IActivationFilter val)
            => Unsafe.As<IActivationFilter, Silk.NET.Core.Native.IUnknown>(ref val);

        public IActivationFilter
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
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HandleActivation(uint dwActivationType, Guid* rclsid, Guid* pReplacementClsId)
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)LpVtbl[3])(@this, dwActivationType, rclsid, pReplacementClsId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HandleActivation(uint dwActivationType, Guid* rclsid, ref Guid pReplacementClsId)
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pReplacementClsIdPtr = &pReplacementClsId)
            {
                ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)LpVtbl[3])(@this, dwActivationType, rclsid, pReplacementClsIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HandleActivation(uint dwActivationType, ref Guid rclsid, Guid* pReplacementClsId)
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)LpVtbl[3])(@this, dwActivationType, rclsidPtr, pReplacementClsId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HandleActivation(uint dwActivationType, ref Guid rclsid, ref Guid pReplacementClsId)
        {
            var @this = (IActivationFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (Guid* pReplacementClsIdPtr = &pReplacementClsId)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)LpVtbl[3])(@this, dwActivationType, rclsidPtr, pReplacementClsIdPtr);
                }
            }
            return ret;
        }

    }
}
