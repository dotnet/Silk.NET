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
    [Guid("207bcecb-d683-4a06-a8a3-9b149b9f73a4")]
    [NativeName("Name", "ID3D11FunctionReflection")]
    public unsafe partial struct ID3D11FunctionReflection : IComVtbl<ID3D11FunctionReflection>
    {
        public static readonly Guid Guid = new("207bcecb-d683-4a06-a8a3-9b149b9f73a4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(FunctionDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref FunctionDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FunctionDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[1])(@this, BufferIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, Name, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, Name, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDesc);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDescPtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11FunctionParameterReflection* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)@this->LpVtbl[6])(@this, ParameterIndex);
            return ret;
        }

    }
}
