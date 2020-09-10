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
    [NativeName("Name", "ID3D12ShaderReflectionType")]
    public unsafe partial struct ID3D12ShaderReflectionType
    {
        public ID3D12ShaderReflectionType
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
        public unsafe int GetDesc(ShaderTypeDesc* pDesc)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref ShaderTypeDesc pDesc)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ShaderTypeDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                ID3D12ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[1])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(byte* Name)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                ID3D12ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(ref byte Name)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                ID3D12ShaderReflectionType* ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(string Name)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                ID3D12ShaderReflectionType* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe byte* GetMemberTypeName(uint Index)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                byte* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, uint, byte*>)LpVtbl[3])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public string GetMemberTypeNameS(uint Index)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                string ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, uint, string>)LpVtbl[3])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int IsEqual(ID3D12ShaderReflectionType* pType)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pType);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsEqual(ref ID3D12ShaderReflectionType pType)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pTypePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionType* GetSubType()
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                ID3D12ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)LpVtbl[5])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionType* GetBaseClass()
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                ID3D12ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)LpVtbl[6])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetNumInterfaces()
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, uint>)LpVtbl[7])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                ID3D12ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[8])(@this, uIndex);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int IsOfType(ID3D12ShaderReflectionType* pType)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pType);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsOfType(ref ID3D12ShaderReflectionType pType)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pTypePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ImplementsInterface(ID3D12ShaderReflectionType* pBase)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBase);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ImplementsInterface(ref ID3D12ShaderReflectionType pBase)
        {
            fixed (ID3D12ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ShaderReflectionType* pBasePtr = &pBase)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBasePtr);
                }
                return ret;
            }
        }

    }
}
