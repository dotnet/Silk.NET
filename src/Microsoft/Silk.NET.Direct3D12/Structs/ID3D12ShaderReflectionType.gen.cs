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
    [Guid("e913c351-783d-48ca-a1d1-4f306284ad56")]
    [NativeName("Name", "ID3D12ShaderReflectionType")]
    public unsafe partial struct ID3D12ShaderReflectionType
    {
        public ID3D12ShaderReflectionType
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
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref ShaderTypeDesc pDesc)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ShaderTypeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[1])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(byte* Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(ref byte Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(string Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            Marshal.FreeHGlobal((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetMemberTypeName(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, byte*>)LpVtbl[3])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly string GetMemberTypeNameS(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, string>)LpVtbl[3])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsEqual(ID3D12ShaderReflectionType* pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsEqual(ref ID3D12ShaderReflectionType pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetSubType()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetBaseClass()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumInterfaces()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[8])(@this, uIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsOfType(ID3D12ShaderReflectionType* pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsOfType(ref ID3D12ShaderReflectionType pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ImplementsInterface(ID3D12ShaderReflectionType* pBase)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBase);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ImplementsInterface(ref ID3D12ShaderReflectionType pBase)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12ShaderReflectionType* pBasePtr = &pBase)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBasePtr);
            }
            return ret;
        }

    }
}
