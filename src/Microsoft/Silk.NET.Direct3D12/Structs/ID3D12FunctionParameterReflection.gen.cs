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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12FunctionParameterReflection")]
    public unsafe partial struct ID3D12FunctionParameterReflection
    {
        public ID3D12FunctionParameterReflection
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
        public unsafe int GetDesc(ParameterDesc* pDesc)
        {
            fixed (ID3D12FunctionParameterReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionParameterReflection*, ParameterDesc*, int>)LpVtbl[0])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref ParameterDesc pDesc)
        {
            fixed (ID3D12FunctionParameterReflection* @this = &this)
            {
                int ret = default;
                fixed (ParameterDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionParameterReflection*, ParameterDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                return ret;
            }
        }

    }
}
