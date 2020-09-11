// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "IDxcOptimizer")]
    public unsafe partial struct IDxcOptimizer
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOptimizer val)
            => Unsafe.As<IDxcOptimizer, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcOptimizer
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcOptimizer*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcOptimizer*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetAvailablePassCount(uint* pCount)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetAvailablePassCount(ref uint pCount)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, uint*, int>)LpVtbl[3])(@this, pCountPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetAvailablePass(uint index, IDxcOptimizerPass** ppResult)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetAvailablePass(uint index, ref IDxcOptimizerPass* ppResult)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcOptimizerPass** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)LpVtbl[4])(@this, index, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
                        fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                        {
                            ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputText);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
                        fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                        {
                            ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (char** ppOptionsPtr = &ppOptions)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (char** ppOptionsPtr = &ppOptions)
                    {
                        fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                        {
                            ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (char** ppOptionsPtr = &ppOptions)
                    {
                        fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                        {
                            ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            fixed (IDxcOptimizer* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (char** ppOptionsPtr = &ppOptions)
                    {
                        fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                        {
                            fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                            {
                                ret = ((delegate* cdecl<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

    }
}
