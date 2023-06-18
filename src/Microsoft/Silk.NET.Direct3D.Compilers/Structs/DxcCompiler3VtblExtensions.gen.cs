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

public unsafe static class DxcCompiler3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcCompiler3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcCompiler3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcCompiler3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Compile(this ComPtr<IDxcCompiler3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Disassemble(this ComPtr<IDxcCompiler3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pObject, Guid* riid, void** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObject, riid, ppResult);
        return ret;
    }

}
