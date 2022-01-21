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
    [Guid("25740e2e-9cba-401b-9119-4fb42f39f270")]
    [NativeName("Name", "IDxcOptimizer")]
    public unsafe partial struct IDxcOptimizer
    {
        public static readonly Guid Guid = new("25740e2e-9cba-401b-9119-4fb42f39f270");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOptimizer val)
            => Unsafe.As<IDxcOptimizer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcOptimizer
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
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailablePassCount(uint* pCount)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAvailablePassCount(ref uint pCount)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailablePass(uint index, IDxcOptimizerPass** ppResult)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailablePass(uint index, ref IDxcOptimizerPass* ppResult)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOptimizerPass** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputText);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputText);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputText);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
                        fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

    }
}
