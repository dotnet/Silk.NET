// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12ShaderReflection")]
    public unsafe partial struct ID3D12ShaderReflection
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12ShaderReflection val)
            => Unsafe.As<ID3D12ShaderReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12ShaderReflection
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
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(ShaderDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref ShaderDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (ShaderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[4])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* Name)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(ref byte Name)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(string Name)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ID3D12ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetInputParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetInputParameterDesc(uint ParameterIndex, ref SignatureParameterDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (SignatureParameterDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetOutputParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetOutputParameterDesc(uint ParameterIndex, ref SignatureParameterDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (SignatureParameterDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPatchConstantParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPatchConstantParameterDesc(uint ParameterIndex, ref SignatureParameterDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (SignatureParameterDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[10])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(string Name)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(byte* Name, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(byte* Name, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(ref byte Name, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetResourceBindingDescByName(ref byte Name, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResourceBindingDescByName(string Name, ShaderInputBindDesc* pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetResourceBindingDescByName(string Name, ref ShaderInputBindDesc pDesc)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
                }
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetMovInstructionCount()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint>)LpVtbl[12])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetMovcInstructionCount()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint>)LpVtbl[13])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetConversionInstructionCount()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint>)LpVtbl[14])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetBitwiseInstructionCount()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint>)LpVtbl[15])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public Silk.NET.Core.Native.D3DPrimitive GetGSInputPrimitive()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                Silk.NET.Core.Native.D3DPrimitive ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DPrimitive>)LpVtbl[16])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsSampleFrequencyShader()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, int>)LpVtbl[17])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetNumInterfaceSlots()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint>)LpVtbl[18])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMinFeatureLevel(Silk.NET.Core.Native.D3DFeatureLevel* pLevel)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevel);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMinFeatureLevel(ref Silk.NET.Core.Native.D3DFeatureLevel pLevel)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.D3DFeatureLevel* pLevelPtr = &pLevel)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevelPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZ);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, ref uint pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                fixed (uint* pSizeZPtr = &pSizeZ)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe uint GetThreadGroupSize(uint* pSizeX, ref uint pSizeY, uint* pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                fixed (uint* pSizeYPtr = &pSizeY)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZ);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe uint GetThreadGroupSize(uint* pSizeX, ref uint pSizeY, ref uint pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                fixed (uint* pSizeYPtr = &pSizeY)
                {
                    fixed (uint* pSizeZPtr = &pSizeZ)
                    {
                        ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe uint GetThreadGroupSize(ref uint pSizeX, uint* pSizeY, uint* pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                fixed (uint* pSizeXPtr = &pSizeX)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZ);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe uint GetThreadGroupSize(ref uint pSizeX, uint* pSizeY, ref uint pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                fixed (uint* pSizeXPtr = &pSizeX)
                {
                    fixed (uint* pSizeZPtr = &pSizeZ)
                    {
                        ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe uint GetThreadGroupSize(ref uint pSizeX, ref uint pSizeY, uint* pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                fixed (uint* pSizeXPtr = &pSizeX)
                {
                    fixed (uint* pSizeYPtr = &pSizeY)
                    {
                        ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZ);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetThreadGroupSize(ref uint pSizeX, ref uint pSizeY, ref uint pSizeZ)
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                uint ret = default;
                fixed (uint* pSizeXPtr = &pSizeX)
                {
                    fixed (uint* pSizeYPtr = &pSizeY)
                    {
                        fixed (uint* pSizeZPtr = &pSizeZ)
                        {
                            ret = ((delegate* cdecl<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetRequiresFlags()
        {
            fixed (ID3D12ShaderReflection* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflection*, ulong>)LpVtbl[21])(@this);
                return ret;
            }
        }

    }
}
