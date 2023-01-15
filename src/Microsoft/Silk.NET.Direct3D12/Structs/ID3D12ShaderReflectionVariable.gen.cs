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

namespace Silk.NET.Direct3D12
{
    [Guid("8337a8a6-a216-444a-b2f4-314733a73aea")]
    [NativeName("Name", "ID3D12ShaderReflectionVariable")]
    public unsafe partial struct ID3D12ShaderReflectionVariable : IComVtbl<ID3D12ShaderReflectionVariable>
    {
        public static readonly Guid Guid = new("8337a8a6-a216-444a-b2f4-314733a73aea");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(ShaderVariableDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ShaderVariableDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref ShaderVariableDesc pDesc)
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderVariableDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ShaderVariableDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetType()
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionType*>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetBuffer()
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInterfaceSlot(uint uArrayIndex)
        {
            var @this = (ID3D12ShaderReflectionVariable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, uint, uint>)@this->LpVtbl[3])(@this, uArrayIndex);
            return ret;
        }

    }
}
