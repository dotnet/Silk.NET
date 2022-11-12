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

public unsafe static class D3D11FunctionReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<ID3D11FunctionReflection> thisVtbl, FunctionDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3D11FunctionReflection> thisVtbl, ref FunctionDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FunctionDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(this ComPtr<ID3D11FunctionReflection> thisVtbl, uint BufferIndex)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[1])(@this, BufferIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] string* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] in string Name)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        var NamePp = &NamePtr;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte**, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePp);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDesc(this ComPtr<ID3D11FunctionReflection> thisVtbl, uint ResourceIndex, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDesc(this ComPtr<ID3D11FunctionReflection> thisVtbl, uint ResourceIndex, ref ShaderInputBindDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] string* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionVariable* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] in string Name)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionVariable* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        var NamePp = &NamePtr;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte**, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePp);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] string* Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDesc);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] string* Name, ref ShaderInputBindDesc pDesc)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] in string Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        var NamePp = &NamePtr;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte**, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePp, pDesc);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] in string Name, ref ShaderInputBindDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        var NamePp = &NamePtr;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte**, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePp, pDescPtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11FunctionParameterReflection* GetFunctionParameter(this ComPtr<ID3D11FunctionReflection> thisVtbl, int ParameterIndex)
    {
        var @this = thisVtbl.Handle;
        ID3D11FunctionParameterReflection* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)@this->LpVtbl[6])(@this, ParameterIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3D11FunctionReflection> thisVtbl, Span<FunctionDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<string> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConstantBufferByName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDesc(this ComPtr<ID3D11FunctionReflection> thisVtbl, uint ResourceIndex, Span<ShaderInputBindDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDesc(ResourceIndex, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<string> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVariableByName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] string* Name, Span<ShaderInputBindDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDescByName(Name, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<string> Name, ShaderInputBindDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDescByName(in Name.GetPinnableReference(), pDesc);
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName(this ComPtr<ID3D11FunctionReflection> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<string> Name, Span<ShaderInputBindDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceBindingDescByName(in Name.GetPinnableReference(), ref pDesc.GetPinnableReference());
    }

}
