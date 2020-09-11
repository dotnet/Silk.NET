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
    [NativeName("Name", "IDxcOptimizerPass")]
    public unsafe partial struct IDxcOptimizerPass
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOptimizerPass val)
            => Unsafe.As<IDxcOptimizerPass, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcOptimizerPass
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
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOptionName(char** ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOptionName(ref char* ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (char** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDescription(char** ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDescription(ref char* ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (char** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOptionArgCount(uint* pCount)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetOptionArgCount(ref uint pCount)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* cdecl<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCountPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOptionArgName(uint argIndex, char** ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOptionArgName(uint argIndex, ref char* ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (char** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOptionArgDescription(uint argIndex, char** ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOptionArgDescription(uint argIndex, ref char* ppResult)
        {
            fixed (IDxcOptimizerPass* @this = &this)
            {
                int ret = default;
                fixed (char** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResultPtr);
                }
                return ret;
            }
        }

    }
}
