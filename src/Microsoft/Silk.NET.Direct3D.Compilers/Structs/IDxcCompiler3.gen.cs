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
    [Guid("228b4687-5a6a-4730-900c-9702b2203f54")]
    [NativeName("Name", "IDxcCompiler3")]
    public unsafe partial struct IDxcCompiler3
    {
        public static readonly Guid Guid = new("228b4687-5a6a-4730-900c-9702b2203f54");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcCompiler3 val)
            => Unsafe.As<IDxcCompiler3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcCompiler3
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
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (Guid* riidPtr = &riid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Guid* riidPtr = &riid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] Buffer* pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (Guid* riidPtr = &riid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(FlowDirection.In)] in Buffer pSource, ref char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppResultPtr = &ppResult)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] Buffer* pObject, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riid, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riid, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riid, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] Buffer* pObject, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riid, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riid, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riid, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] Buffer* pObject, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riidPtr, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riidPtr, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riidPtr, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] Buffer* pObject, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riidPtr, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riidPtr, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObject, riidPtr, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] in Buffer pObject, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riid, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riid, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riid, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] in Buffer pObject, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riid, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riid, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riid, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] in Buffer pObject, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
                fixed (Guid* riidPtr = &riid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(FlowDirection.In)] in Buffer pObject, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

    }
}
