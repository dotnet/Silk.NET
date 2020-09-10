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
    [NativeName("Name", "ID3D12FunctionReflection")]
    public unsafe partial struct ID3D12FunctionReflection
    {
        public ID3D12FunctionReflection
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
        public unsafe int GetDesc(FunctionDesc* pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref FunctionDesc pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                fixed (FunctionDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* Name)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(ref byte Name)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(string Name)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(string Name)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(byte* Name, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(byte* Name, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(ref byte Name, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetResourceBindingDescByName(ref byte Name, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(string Name, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetResourceBindingDescByName(string Name, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            fixed (ID3D12FunctionReflection* @this = &this)
            {
                ID3D12FunctionParameterReflection* ret = default;
                ret = ((delegate* cdecl<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
                return ret;
            }
        }

    }
}
