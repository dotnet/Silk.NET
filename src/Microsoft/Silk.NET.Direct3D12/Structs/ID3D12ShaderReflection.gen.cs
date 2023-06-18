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
    [Guid("5a58797d-a72c-478d-8ba2-efc6b0efe88e")]
    [NativeName("Name", "ID3D12ShaderReflection")]
    public unsafe partial struct ID3D12ShaderReflection : IComVtbl<ID3D12ShaderReflection>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("5a58797d-a72c-478d-8ba2-efc6b0efe88e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12ShaderReflection val)
            => Unsafe.As<ID3D12ShaderReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12ShaderReflection
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
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(ShaderDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ShaderDesc*, int>)@this->LpVtbl[3])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[4])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[5])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[6])(@this, ResourceIndex, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInputParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[7])(@this, ParameterIndex, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutputParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[8])(@this, ParameterIndex, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatchConstantParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[9])(@this, ParameterIndex, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[10])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, Name, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetMovInstructionCount()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetMovcInstructionCount()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetConversionInstructionCount()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetBitwiseInstructionCount()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Native.D3DPrimitive GetGSInputPrimitive()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Native.D3DPrimitive ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DPrimitive>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsSampleFrequencyShader()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Silk.NET.Core.Bool32>)@this->LpVtbl[17])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumInterfaceSlots()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMinFeatureLevel(Silk.NET.Core.Native.D3DFeatureLevel* pLevel)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[19])(@this, pLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZ);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetRequiresFlags()
        {
            var @this = (ID3D12ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ulong>)@this->LpVtbl[21])(@this);
            return ret;
        }

    }
}
