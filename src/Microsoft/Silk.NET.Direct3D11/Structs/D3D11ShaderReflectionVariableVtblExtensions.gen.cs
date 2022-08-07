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

public unsafe static class D3D11ShaderReflectionVariableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, ShaderVariableDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflectionVariable>
    {
        var @this = (ID3D11ShaderReflectionVariable*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, ShaderVariableDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref ShaderVariableDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflectionVariable>
    {
        var @this = (ID3D11ShaderReflectionVariable*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderVariableDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, ShaderVariableDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflectionVariable>
    {
        var @this = (ID3D11ShaderReflectionVariable*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionType*>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionConstantBuffer* GetBuffer<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflectionVariable>
    {
        var @this = (ID3D11ShaderReflectionVariable*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetInterfaceSlot<TThis>(this TThis thisVtbl, uint uArrayIndex) where TThis : IComVtbl<ID3D11ShaderReflectionVariable>
    {
        var @this = (ID3D11ShaderReflectionVariable*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, uint, uint>)@this->LpVtbl[3])(@this, uArrayIndex);
        return ret;
    }

}
