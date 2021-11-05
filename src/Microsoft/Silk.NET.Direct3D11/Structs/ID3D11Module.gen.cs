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

namespace Silk.NET.Direct3D11
{
    [Guid("cac701ee-80fc-4122-8242-10b39c8cec34")]
    [NativeName("Name", "ID3D11Module")]
    public unsafe partial struct ID3D11Module
    {
        public static readonly Guid Guid = new("cac701ee-80fc-4122-8242-10b39c8cec34");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Module val)
            => Unsafe.As<ID3D11Module, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Module
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
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(byte* pNamespace, ID3D11ModuleInstance** ppModuleInstance)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstance);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(byte* pNamespace, ref ID3D11ModuleInstance* ppModuleInstance)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstancePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref byte pNamespace, ID3D11ModuleInstance** ppModuleInstance)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamespacePtr = &pNamespace)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref byte pNamespace, ref ID3D11ModuleInstance* ppModuleInstance)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamespacePtr = &pNamespace)
            {
                fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pNamespace, ID3D11ModuleInstance** ppModuleInstance)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamespacePtr = (byte*) SilkMarshal.StringToPtr(pNamespace, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
            SilkMarshal.Free((nint)pNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pNamespace, ref ID3D11ModuleInstance* ppModuleInstance)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamespacePtr = (byte*) SilkMarshal.StringToPtr(pNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
            }
            SilkMarshal.Free((nint)pNamespacePtr);
            return ret;
        }

    }
}
