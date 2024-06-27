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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12ShaderReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12ShaderReflection> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12ShaderReflection> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, ShaderDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ShaderDesc*, int>)@this->LpVtbl[3])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref ShaderDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ShaderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ShaderDesc*, int>)@this->LpVtbl[3])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint Index)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[4])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[5])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[5])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[5])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ResourceIndex, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[6])(@this, ResourceIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ResourceIndex, ref ShaderInputBindDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[6])(@this, ResourceIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInputParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, SignatureParameterDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[7])(@this, ParameterIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetInputParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, ref SignatureParameterDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SignatureParameterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[7])(@this, ParameterIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutputParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, SignatureParameterDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[8])(@this, ParameterIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOutputParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, ref SignatureParameterDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SignatureParameterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[8])(@this, ParameterIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatchConstantParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, SignatureParameterDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[9])(@this, ParameterIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPatchConstantParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, ref SignatureParameterDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SignatureParameterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[9])(@this, ParameterIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionVariable* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[10])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionVariable* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[10])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionVariable* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[10])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, Name, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name, ref ShaderInputBindDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, Name, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name, ref ShaderInputBindDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* NamePtr = &Name)
        {
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDesc);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDescPtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMovInstructionCount(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMovcInstructionCount(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetConversionInstructionCount(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetBitwiseInstructionCount(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Native.D3DPrimitive GetGSInputPrimitive(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Native.D3DPrimitive ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DPrimitive>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSampleFrequencyShader(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Silk.NET.Core.Bool32>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumInterfaceSlots(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMinFeatureLevel(this ComPtr<ID3D12ShaderReflection> thisVtbl, Silk.NET.Core.Native.D3DFeatureLevel* pLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[19])(@this, pLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMinFeatureLevel(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref Silk.NET.Core.Native.D3DFeatureLevel pLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.D3DFeatureLevel* pLevelPtr = &pLevel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[19])(@this, pLevelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint* pSizeX, uint* pSizeY, uint* pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZ);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint* pSizeX, uint* pSizeY, ref uint pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (uint* pSizeZPtr = &pSizeZ)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint* pSizeX, ref uint pSizeY, uint* pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (uint* pSizeYPtr = &pSizeY)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZ);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint* pSizeX, ref uint pSizeY, ref uint pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (uint* pSizeYPtr = &pSizeY)
        {
            fixed (uint* pSizeZPtr = &pSizeZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref uint pSizeX, uint* pSizeY, uint* pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZ);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref uint pSizeX, uint* pSizeY, ref uint pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            fixed (uint* pSizeZPtr = &pSizeZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref uint pSizeX, ref uint pSizeY, uint* pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            fixed (uint* pSizeYPtr = &pSizeY)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZ);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, ref uint pSizeX, ref uint pSizeY, ref uint pSizeZ)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            fixed (uint* pSizeYPtr = &pSizeY)
            {
                fixed (uint* pSizeZPtr = &pSizeZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetRequiresFlags(this ComPtr<ID3D12ShaderReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ulong>)@this->LpVtbl[21])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12ShaderReflection> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<ShaderDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConstantBufferByName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ResourceIndex, Span<ShaderInputBindDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDesc(ResourceIndex, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetInputParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, Span<SignatureParameterDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInputParameterDesc(ParameterIndex, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetOutputParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, Span<SignatureParameterDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetOutputParameterDesc(ParameterIndex, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPatchConstantParameterDesc(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint ParameterIndex, Span<SignatureParameterDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatchConstantParameterDesc(ParameterIndex, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVariableByName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name, Span<ShaderInputBindDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDescByName(Name, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDescByName(in Name.GetPinnableReference(), pDesc);
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Name, Span<ShaderInputBindDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDescByName(in Name.GetPinnableReference(), ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName(this ComPtr<ID3D12ShaderReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, Span<ShaderInputBindDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDescByName(Name, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMinFeatureLevel(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<Silk.NET.Core.Native.D3DFeatureLevel> pLevel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMinFeatureLevel(ref pLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint* pSizeX, uint* pSizeY, Span<uint> pSizeZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetThreadGroupSize(pSizeX, pSizeY, ref pSizeZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint* pSizeX, Span<uint> pSizeY, uint* pSizeZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetThreadGroupSize(pSizeX, ref pSizeY.GetPinnableReference(), pSizeZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, uint* pSizeX, Span<uint> pSizeY, Span<uint> pSizeZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetThreadGroupSize(pSizeX, ref pSizeY.GetPinnableReference(), ref pSizeZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<uint> pSizeX, uint* pSizeY, uint* pSizeZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetThreadGroupSize(ref pSizeX.GetPinnableReference(), pSizeY, pSizeZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<uint> pSizeX, uint* pSizeY, Span<uint> pSizeZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetThreadGroupSize(ref pSizeX.GetPinnableReference(), pSizeY, ref pSizeZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<uint> pSizeX, Span<uint> pSizeY, uint* pSizeZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetThreadGroupSize(ref pSizeX.GetPinnableReference(), ref pSizeY.GetPinnableReference(), pSizeZ);
    }

    /// <summary>To be documented.</summary>
    public static uint GetThreadGroupSize(this ComPtr<ID3D12ShaderReflection> thisVtbl, Span<uint> pSizeX, Span<uint> pSizeY, Span<uint> pSizeZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetThreadGroupSize(ref pSizeX.GetPinnableReference(), ref pSizeY.GetPinnableReference(), ref pSizeZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12ShaderReflection> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
