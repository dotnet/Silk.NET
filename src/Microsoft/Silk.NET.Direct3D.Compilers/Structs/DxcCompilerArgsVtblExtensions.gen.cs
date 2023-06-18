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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcCompilerArgsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcCompilerArgs> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcCompilerArgs> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcCompilerArgs> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe char** GetArguments(this ComPtr<IDxcCompilerArgs> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        char** ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCount(this ComPtr<IDxcCompilerArgs> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddArguments(this ComPtr<IDxcCompilerArgs> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**, uint, int>)@this->LpVtbl[5])(@this, pArguments, argCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddArgumentsUTF8(this ComPtr<IDxcCompilerArgs> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** pArguments, uint argCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, byte**, uint, int>)@this->LpVtbl[6])(@this, pArguments, argCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDefines(this ComPtr<IDxcCompilerArgs> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Define*, uint, int>)@this->LpVtbl[7])(@this, pDefines, defineCount);
        return ret;
    }

}
