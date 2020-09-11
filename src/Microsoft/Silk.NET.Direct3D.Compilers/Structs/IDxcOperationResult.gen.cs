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
    [NativeName("Name", "IDxcOperationResult")]
    public unsafe partial struct IDxcOperationResult
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOperationResult val)
            => Unsafe.As<IDxcOperationResult, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcOperationResult
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
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcOperationResult*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcOperationResult*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStatus(int* pStatus)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOperationResult*, int*, int>)LpVtbl[3])(@this, pStatus);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetStatus(ref int pStatus)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                fixed (int* pStatusPtr = &pStatus)
                {
                    ret = ((delegate* cdecl<IDxcOperationResult*, int*, int>)LpVtbl[3])(@this, pStatusPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResult(IDxcBlob** pResult)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOperationResult*, IDxcBlob**, int>)LpVtbl[4])(@this, pResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResult(ref IDxcBlob* pResult)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob** pResultPtr = &pResult)
                {
                    ret = ((delegate* cdecl<IDxcOperationResult*, IDxcBlob**, int>)LpVtbl[4])(@this, pResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetErrorBuffer(IDxcBlobEncoding** pErrors)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcOperationResult*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pErrors);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetErrorBuffer(ref IDxcBlobEncoding* pErrors)
        {
            fixed (IDxcOperationResult* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** pErrorsPtr = &pErrors)
                {
                    ret = ((delegate* cdecl<IDxcOperationResult*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pErrorsPtr);
                }
                return ret;
            }
        }

    }
}
