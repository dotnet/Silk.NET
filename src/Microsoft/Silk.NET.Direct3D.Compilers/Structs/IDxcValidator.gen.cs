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
    [NativeName("Name", "IDxcValidator")]
    public unsafe partial struct IDxcValidator
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcValidator val)
            => Unsafe.As<IDxcValidator, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcValidator* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcValidator
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
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcValidator*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcValidator*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcValidator*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcValidator*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcValidator* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcValidator*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcValidator* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcValidator*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Validate(IDxcBlob* pShader, uint Flags, IDxcOperationResult** ppResult)
        {
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Validate(IDxcBlob* pShader, uint Flags, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Validate(ref IDxcBlob pShader, uint Flags, IDxcOperationResult** ppResult)
        {
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pShaderPtr = &pShader)
                {
                    ret = ((delegate* cdecl<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Validate(ref IDxcBlob pShader, uint Flags, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcValidator* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pShaderPtr = &pShader)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
                    }
                }
                return ret;
            }
        }

    }
}
