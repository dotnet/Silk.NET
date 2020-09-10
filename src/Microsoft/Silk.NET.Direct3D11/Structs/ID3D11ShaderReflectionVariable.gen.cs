// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11ShaderReflectionVariable")]
    public unsafe partial struct ID3D11ShaderReflectionVariable
    {
        public ID3D11ShaderReflectionVariable
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
        public unsafe int GetDesc(ShaderVariableDesc* pDesc)
        {
            fixed (ID3D11ShaderReflectionVariable* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionVariable*, ShaderVariableDesc*, int>)LpVtbl[0])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref ShaderVariableDesc pDesc)
        {
            fixed (ID3D11ShaderReflectionVariable* @this = &this)
            {
                int ret = default;
                fixed (ShaderVariableDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderReflectionVariable*, ShaderVariableDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetType()
        {
            fixed (ID3D11ShaderReflectionVariable* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionType*>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionConstantBuffer* GetBuffer()
        {
            fixed (ID3D11ShaderReflectionVariable* @this = &this)
            {
                ID3D11ShaderReflectionConstantBuffer* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetInterfaceSlot(uint uArrayIndex)
        {
            fixed (ID3D11ShaderReflectionVariable* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionVariable*, uint, uint>)LpVtbl[3])(@this, uArrayIndex);
                return ret;
            }
        }

    }
}
