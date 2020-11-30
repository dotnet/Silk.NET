// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Guid("207bcecb-d683-4a06-a8a3-9b149b9f73a4")]
    [NativeName("Name", "ID3D11FunctionReflection")]
    public unsafe partial struct ID3D11FunctionReflection
    {
        public ID3D11FunctionReflection
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
        public readonly unsafe int GetDesc(FunctionDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDesc(ref FunctionDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (FunctionDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(ref byte Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11ShaderReflectionConstantBuffer* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(string Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11ShaderReflectionVariable* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11ShaderReflectionVariable* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(string Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetResourceBindingDescByName(ref byte Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetResourceBindingDescByName(ref byte Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetResourceBindingDescByName(string Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetResourceBindingDescByName(string Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
            }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ID3D11FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ID3D11FunctionParameterReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            return ret;
        }

    }
}
