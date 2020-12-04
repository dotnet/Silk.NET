// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D12
{
    [Guid("8337a8a6-a216-444a-b2f4-314733a73aea")]
    [NativeName("Name", "ID3D12ShaderReflectionVariable")]
    public unsafe partial struct ID3D12ShaderReflectionVariable
    {
        public ID3D12ShaderReflectionVariable
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
        /// <summary>To be added.</summary>
        public readonly unsafe int GetDesc(ShaderVariableDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionVariable*, ShaderVariableDesc*, int>)LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDesc(ref ShaderVariableDesc pDesc)
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ShaderVariableDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionVariable*, ShaderVariableDesc*, int>)LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetType()
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionType*>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetBuffer()
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetInterfaceSlot(uint uArrayIndex)
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionVariable*, uint, uint>)LpVtbl[3])(@this, uArrayIndex);
            return ret;
        }

    }
}
