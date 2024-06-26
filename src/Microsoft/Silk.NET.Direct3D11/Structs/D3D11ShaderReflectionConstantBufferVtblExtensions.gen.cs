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

public unsafe static class D3D11ShaderReflectionConstantBufferVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, ShaderBufferDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, ShaderBufferDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, ref ShaderBufferDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ShaderBufferDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, ShaderBufferDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByIndex(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, uint Index)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionVariable* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, uint, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[1])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionVariable* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[2])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte Name)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionVariable* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[2])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        ID3D11ShaderReflectionVariable* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionConstantBuffer*, byte*, ID3D11ShaderReflectionVariable*>)@this->LpVtbl[2])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, Span<ShaderBufferDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionVariable* GetVariableByName(this ComPtr<ID3D11ShaderReflectionConstantBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVariableByName(in Name.GetPinnableReference());
    }

}
