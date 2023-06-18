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

public unsafe static class D3D12ShaderReflectionTypeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, ShaderTypeDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetMemberTypeByIndex(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, uint Index)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)@this->LpVtbl[1])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Name)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)@this->LpVtbl[2])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetMemberTypeName(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, uint Index)
    {
        var @this = thisVtbl.Handle;
        byte* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, byte*>)@this->LpVtbl[3])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsEqual(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, ID3D12ShaderReflectionType* pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetSubType(this ComPtr<ID3D12ShaderReflectionType> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetBaseClass(this ComPtr<ID3D12ShaderReflectionType> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumInterfaces(this ComPtr<ID3D12ShaderReflectionType> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetInterfaceByIndex(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, uint uIndex)
    {
        var @this = thisVtbl.Handle;
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)@this->LpVtbl[8])(@this, uIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsOfType(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, ID3D12ShaderReflectionType* pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ImplementsInterface(this ComPtr<ID3D12ShaderReflectionType> thisVtbl, ID3D12ShaderReflectionType* pBase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBase);
        return ret;
    }

}
