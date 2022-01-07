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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("73effe2a-70dc-45f8-9690-eff64c02429d")]
    [NativeName("Name", "IDxcCompilerArgs")]
    public unsafe partial struct IDxcCompilerArgs
    {
        public static readonly Guid Guid = new("73effe2a-70dc-45f8-9690-eff64c02429d");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcCompilerArgs val)
            => Unsafe.As<IDxcCompilerArgs, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcCompilerArgs
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
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe char** GetArguments()
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            char** ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCount()
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddArguments(char** pArguments, uint argCount)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcCompilerArgs*, char**, uint, int>)LpVtbl[5])(@this, pArguments, argCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**, uint, int>)LpVtbl[5])(@this, pArguments, argCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, char**, uint, int>)LpVtbl[5])(@this, pArguments, argCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddArguments(ref char* pArguments, uint argCount)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompilerArgs*, char**, uint, int>)LpVtbl[5])(@this, pArgumentsPtr, argCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**, uint, int>)LpVtbl[5])(@this, pArgumentsPtr, argCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, char**, uint, int>)LpVtbl[5])(@this, pArgumentsPtr, argCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddArgumentsUTF8(byte** pArguments, uint argCount)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcCompilerArgs*, byte**, uint, int>)LpVtbl[6])(@this, pArguments, argCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, byte**, uint, int>)LpVtbl[6])(@this, pArguments, argCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, byte**, uint, int>)LpVtbl[6])(@this, pArguments, argCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddArgumentsUTF8(ref byte* pArguments, uint argCount)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** pArgumentsPtr = &pArguments)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompilerArgs*, byte**, uint, int>)LpVtbl[6])(@this, pArgumentsPtr, argCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, byte**, uint, int>)LpVtbl[6])(@this, pArgumentsPtr, argCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, byte**, uint, int>)LpVtbl[6])(@this, pArgumentsPtr, argCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDefines([Flow(FlowDirection.In)] Define* pDefines, uint defineCount)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcCompilerArgs*, Define*, uint, int>)LpVtbl[7])(@this, pDefines, defineCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Define*, uint, int>)LpVtbl[7])(@this, pDefines, defineCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Define*, uint, int>)LpVtbl[7])(@this, pDefines, defineCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDefines([Flow(FlowDirection.In)] in Define pDefines, uint defineCount)
        {
            var @this = (IDxcCompilerArgs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompilerArgs*, Define*, uint, int>)LpVtbl[7])(@this, pDefinesPtr, defineCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Define*, uint, int>)LpVtbl[7])(@this, pDefinesPtr, defineCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Define*, uint, int>)LpVtbl[7])(@this, pDefinesPtr, defineCount);
                }
            #endif
            }
            return ret;
        }

    }
}
