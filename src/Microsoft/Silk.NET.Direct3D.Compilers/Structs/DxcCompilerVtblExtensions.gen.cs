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

public unsafe static class DxcCompilerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcCompiler> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcCompiler> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcCompiler> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Compile(this ComPtr<IDxcCompiler> thisVtbl, IDxcBlob* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, char*, char*, char*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Preprocess(this ComPtr<IDxcCompiler> thisVtbl, IDxcBlob* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, char*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Disassemble(this ComPtr<IDxcCompiler> thisVtbl, IDxcBlob* pSource, IDxcBlobEncoding** ppDisassembly)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pSource, ppDisassembly);
        return ret;
    }

}
