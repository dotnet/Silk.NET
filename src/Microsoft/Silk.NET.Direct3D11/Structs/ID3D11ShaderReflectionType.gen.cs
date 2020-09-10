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
    [NativeName("Name", "ID3D11ShaderReflectionType")]
    public unsafe partial struct ID3D11ShaderReflectionType
    {
        public ID3D11ShaderReflectionType
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
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref ShaderTypeDesc pDesc)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ShaderTypeDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)LpVtbl[1])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetMemberTypeByName(byte* Name)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, byte*, ID3D11ShaderReflectionType*>)LpVtbl[2])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetMemberTypeByName(ref byte Name)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, byte*, ID3D11ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetMemberTypeByName(string Name)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, byte*, ID3D11ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe byte* GetMemberTypeName(uint Index)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                byte* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, uint, byte*>)LpVtbl[3])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public string GetMemberTypeNameS(uint Index)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                string ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, uint, string>)LpVtbl[3])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int IsEqual(ID3D11ShaderReflectionType* pType)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)LpVtbl[4])(@this, pType);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsEqual(ref ID3D11ShaderReflectionType pType)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ShaderReflectionType* pTypePtr = &pType)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)LpVtbl[4])(@this, pTypePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetSubType()
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)LpVtbl[5])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetBaseClass()
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)LpVtbl[6])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetNumInterfaces()
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, uint>)LpVtbl[7])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D11ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                ID3D11ShaderReflectionType* ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)LpVtbl[8])(@this, uIndex);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int IsOfType(ID3D11ShaderReflectionType* pType)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)LpVtbl[9])(@this, pType);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsOfType(ref ID3D11ShaderReflectionType pType)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ShaderReflectionType* pTypePtr = &pType)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)LpVtbl[9])(@this, pTypePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ImplementsInterface(ID3D11ShaderReflectionType* pBase)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)LpVtbl[10])(@this, pBase);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ImplementsInterface(ref ID3D11ShaderReflectionType pBase)
        {
            fixed (ID3D11ShaderReflectionType* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ShaderReflectionType* pBasePtr = &pBase)
                {
                    ret = ((delegate* cdecl<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)LpVtbl[10])(@this, pBasePtr);
                }
                return ret;
            }
        }

    }
}
