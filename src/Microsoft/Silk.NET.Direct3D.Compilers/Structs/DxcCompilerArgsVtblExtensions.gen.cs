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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe char** GetArguments<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        char** ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddArguments<TThis>(this TThis thisVtbl, char** pArguments, uint argCount) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**, uint, int>)@this->LpVtbl[5])(@this, pArguments, argCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddArguments<TThis>(this TThis thisVtbl, ref char* pArguments, uint argCount) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, char**, uint, int>)@this->LpVtbl[5])(@this, pArgumentsPtr, argCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddArgumentsUTF8<TThis>(this TThis thisVtbl, byte** pArguments, uint argCount) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, byte**, uint, int>)@this->LpVtbl[6])(@this, pArguments, argCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddArgumentsUTF8<TThis>(this TThis thisVtbl, ref byte* pArguments, uint argCount) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, byte**, uint, int>)@this->LpVtbl[6])(@this, pArgumentsPtr, argCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDefines<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Define*, uint, int>)@this->LpVtbl[7])(@this, pDefines, defineCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDefines<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount) where TThis : IComVtbl<IDxcCompilerArgs>
    {
        var @this = (IDxcCompilerArgs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Define*, uint, int>)@this->LpVtbl[7])(@this, pDefinesPtr, defineCount);
        }
        return ret;
    }

}
