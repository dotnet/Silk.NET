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
    [Guid("c59598b4-48b3-4869-b9b1-b1618b14a8b7")]
    [NativeName("Name", "ID3D12ShaderReflectionConstantBuffer")]
    public unsafe partial struct ID3D12ShaderReflectionConstantBuffer : IComVtbl<ID3D12ShaderReflectionConstantBuffer>
    {
        public static readonly Guid Guid = new("c59598b4-48b3-4869-b9b1-b1618b14a8b7");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public ID3D12ShaderReflectionConstantBuffer
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
        public readonly unsafe int GetDesc(ShaderBufferDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflectionConstantBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, ShaderBufferDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref ShaderBufferDesc pDesc)
        {
            var @this = (ID3D12ShaderReflectionConstantBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderBufferDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, ShaderBufferDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByIndex(uint Index)
        {
            var @this = (ID3D12ShaderReflectionConstantBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, uint, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[1])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([Flow(FlowDirection.In)] string* Name)
        {
            var @this = (ID3D12ShaderReflectionConstantBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[2])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([Flow(FlowDirection.In)] in string Name)
        {
            var @this = (ID3D12ShaderReflectionConstantBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            var NamePp = &NamePtr;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionConstantBuffer*, byte**, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[2])(@this, NamePp);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

    }
}
