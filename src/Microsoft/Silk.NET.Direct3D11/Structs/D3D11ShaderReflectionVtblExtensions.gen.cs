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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11ShaderReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, ShaderDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ShaderDesc*, int>)@this->LpVtbl[3])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref ShaderDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ShaderDesc*, int>)@this->LpVtbl[3])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[4])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName<TThis>(this TThis thisVtbl, byte* Name) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[5])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName<TThis>(this TThis thisVtbl, ref byte Name) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[5])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[5])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDesc<TThis>(this TThis thisVtbl, uint ResourceIndex, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[6])(@this, ResourceIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDesc<TThis>(this TThis thisVtbl, uint ResourceIndex, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[6])(@this, ResourceIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInputParameterDesc<TThis>(this TThis thisVtbl, uint ParameterIndex, SignatureParameterDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[7])(@this, ParameterIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetInputParameterDesc<TThis>(this TThis thisVtbl, uint ParameterIndex, ref SignatureParameterDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SignatureParameterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[7])(@this, ParameterIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutputParameterDesc<TThis>(this TThis thisVtbl, uint ParameterIndex, SignatureParameterDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[8])(@this, ParameterIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOutputParameterDesc<TThis>(this TThis thisVtbl, uint ParameterIndex, ref SignatureParameterDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SignatureParameterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[8])(@this, ParameterIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatchConstantParameterDesc<TThis>(this TThis thisVtbl, uint ParameterIndex, SignatureParameterDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[9])(@this, ParameterIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPatchConstantParameterDesc<TThis>(this TThis thisVtbl, uint ParameterIndex, ref SignatureParameterDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SignatureParameterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)@this->LpVtbl[9])(@this, ParameterIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName<TThis>(this TThis thisVtbl, byte* Name) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionVariable* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[10])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName<TThis>(this TThis thisVtbl, ref byte Name) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionVariable* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[10])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionVariable* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[10])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, byte* Name, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, Name, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, byte* Name, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, Name, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, ref byte Name, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, ref byte Name, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* NamePtr = &Name)
        {
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDesc);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[11])(@this, NamePtr, pDescPtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMovInstructionCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMovcInstructionCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetConversionInstructionCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetBitwiseInstructionCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Native.D3DPrimitive GetGSInputPrimitive<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        Silk.NET.Core.Native.D3DPrimitive ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DPrimitive>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsSampleFrequencyShader<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, int>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumInterfaceSlots<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMinFeatureLevel<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.D3DFeatureLevel* pLevel) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[19])(@this, pLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMinFeatureLevel<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.D3DFeatureLevel pLevel) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.D3DFeatureLevel* pLevelPtr = &pLevel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)@this->LpVtbl[19])(@this, pLevelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize<TThis>(this TThis thisVtbl, uint* pSizeX, uint* pSizeY, uint* pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZ);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize<TThis>(this TThis thisVtbl, uint* pSizeX, uint* pSizeY, ref uint pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        fixed (uint* pSizeZPtr = &pSizeZ)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize<TThis>(this TThis thisVtbl, uint* pSizeX, ref uint pSizeY, uint* pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        fixed (uint* pSizeYPtr = &pSizeY)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZ);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize<TThis>(this TThis thisVtbl, uint* pSizeX, ref uint pSizeY, ref uint pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        fixed (uint* pSizeYPtr = &pSizeY)
        {
            fixed (uint* pSizeZPtr = &pSizeZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize<TThis>(this TThis thisVtbl, ref uint pSizeX, uint* pSizeY, uint* pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZ);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize<TThis>(this TThis thisVtbl, ref uint pSizeX, uint* pSizeY, ref uint pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            fixed (uint* pSizeZPtr = &pSizeZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetThreadGroupSize<TThis>(this TThis thisVtbl, ref uint pSizeX, ref uint pSizeY, uint* pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            fixed (uint* pSizeYPtr = &pSizeY)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZ);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetThreadGroupSize<TThis>(this TThis thisVtbl, ref uint pSizeX, ref uint pSizeY, ref uint pSizeZ) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        fixed (uint* pSizeXPtr = &pSizeX)
        {
            fixed (uint* pSizeYPtr = &pSizeY)
            {
                fixed (uint* pSizeZPtr = &pSizeZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)@this->LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetRequiresFlags<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflection>
    {
        var @this = (ID3D11ShaderReflection*) thisVtbl.AsVtblPtr();
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ulong>)@this->LpVtbl[21])(@this);
        return ret;
    }

}
