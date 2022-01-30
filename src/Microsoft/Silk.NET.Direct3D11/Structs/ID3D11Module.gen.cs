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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstance);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstance);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstance);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(byte* pNamespace, ref ID3D11ModuleInstance* ppModuleInstance)
        {
            var @this = (ID3D11Module*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstancePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstancePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespace, ppModuleInstancePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
            }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pNamespacePtr);
            return ret;
        }

    }
}
