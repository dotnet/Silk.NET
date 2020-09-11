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
    [NativeName("Name", "IDxcAssembler")]
    public unsafe partial struct IDxcAssembler
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcAssembler val)
            => Unsafe.As<IDxcAssembler, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcAssembler* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcAssembler
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
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcAssembler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcAssembler* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcAssembler*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcAssembler* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcAssembler*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AssembleToContainer(IDxcBlob* pShader, IDxcOperationResult** ppResult)
        {
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AssembleToContainer(IDxcBlob* pShader, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AssembleToContainer(ref IDxcBlob pShader, IDxcOperationResult** ppResult)
        {
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pShaderPtr = &pShader)
                {
                    ret = ((delegate* cdecl<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, ppResult);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AssembleToContainer(ref IDxcBlob pShader, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcAssembler* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pShaderPtr = &pShader)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, ppResultPtr);
                    }
                }
                return ret;
            }
        }

    }
}
