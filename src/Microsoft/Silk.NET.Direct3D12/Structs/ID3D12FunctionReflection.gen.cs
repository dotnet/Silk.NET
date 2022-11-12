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
    [Guid("1108795c-2772-4ba9-b2a8-d464dc7e2799")]
    [NativeName("Name", "ID3D12FunctionReflection")]
    public unsafe partial struct ID3D12FunctionReflection : IComVtbl<ID3D12FunctionReflection>
    {
        public static readonly Guid Guid = new("1108795c-2772-4ba9-b2a8-d464dc7e2799");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public ID3D12FunctionReflection
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
        public readonly unsafe int GetDesc(FunctionDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref FunctionDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FunctionDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[1])(@this, BufferIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([Flow(FlowDirection.In)] string* Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([Flow(FlowDirection.In)] in string Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            var NamePp = &NamePtr;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte**, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePp);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([Flow(FlowDirection.In)] string* Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([Flow(FlowDirection.In)] in string Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            var NamePp = &NamePtr;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte**, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePp);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(FlowDirection.In)] string* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDesc);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(FlowDirection.In)] string* Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDescPtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(FlowDirection.In)] in string Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            var NamePp = &NamePtr;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte**, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePp, pDesc);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName([Flow(FlowDirection.In)] in string Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            var NamePp = &NamePtr;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte**, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePp, pDescPtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12FunctionParameterReflection* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)@this->LpVtbl[6])(@this, ParameterIndex);
            return ret;
        }

    }
}
