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

public unsafe static class D3D12FunctionReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<ID3D12FunctionReflection> thisVtbl, FunctionDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(this ComPtr<ID3D12FunctionReflection> thisVtbl, uint BufferIndex)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[1])(@this, BufferIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D12FunctionReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDesc(this ComPtr<ID3D12FunctionReflection> thisVtbl, uint ResourceIndex, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D12FunctionReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionVariable* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D12FunctionReflection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, Name, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12FunctionParameterReflection* GetFunctionParameter(this ComPtr<ID3D12FunctionReflection> thisVtbl, int ParameterIndex)
    {
        var @this = thisVtbl.Handle;
        ID3D12FunctionParameterReflection* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)@this->LpVtbl[6])(@this, ParameterIndex);
        return ret;
    }

}
