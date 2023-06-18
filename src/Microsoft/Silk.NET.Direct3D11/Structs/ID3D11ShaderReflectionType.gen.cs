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

namespace Silk.NET.Direct3D11
{
    [Guid("6e6ffa6a-9bae-4613-a51e-91652d508c21")]
    [NativeName("Name", "ID3D11ShaderReflectionType")]
    public unsafe partial struct ID3D11ShaderReflectionType : IComVtbl<ID3D11ShaderReflectionType>
    {
        public static readonly Guid Guid = new("6e6ffa6a-9bae-4613-a51e-91652d508c21");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public ID3D11ShaderReflectionType
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
        public readonly unsafe int GetDesc(ShaderTypeDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)@this->LpVtbl[1])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionType* GetMemberTypeByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, byte*, ID3D11ShaderReflectionType*>)@this->LpVtbl[2])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetMemberTypeName(uint Index)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint, byte*>)@this->LpVtbl[3])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsEqual(ID3D11ShaderReflectionType* pType)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionType* GetSubType()
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionType* GetBaseClass()
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumInterfaces()
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)@this->LpVtbl[8])(@this, uIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsOfType(ID3D11ShaderReflectionType* pType)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ImplementsInterface(ID3D11ShaderReflectionType* pBase)
        {
            var @this = (ID3D11ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBase);
            return ret;
        }

    }
}
