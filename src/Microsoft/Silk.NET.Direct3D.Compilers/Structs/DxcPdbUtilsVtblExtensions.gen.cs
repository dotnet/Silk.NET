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

public unsafe static class DxcPdbUtilsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcPdbUtils> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcPdbUtils> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IDxcPdbUtils> thisVtbl, IDxcBlob* pPdbOrDxil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxil);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceCount(this ComPtr<IDxcPdbUtils> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[4])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSource(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, IDxcBlobEncoding** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceName(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[6])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlagCount(this ComPtr<IDxcPdbUtils> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[7])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlag(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[8])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgCount(this ComPtr<IDxcPdbUtils> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[9])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArg(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[10])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPairCount(this ComPtr<IDxcPdbUtils> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[11])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, char** pName, char** pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pName, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefineCount(this ComPtr<IDxcPdbUtils> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[13])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefine(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[14])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetProfile(this ComPtr<IDxcPdbUtils> thisVtbl, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[15])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPoint(this ComPtr<IDxcPdbUtils> thisVtbl, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[16])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMainFileName(this ComPtr<IDxcPdbUtils> thisVtbl, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[17])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHash(this ComPtr<IDxcPdbUtils> thisVtbl, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[18])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IDxcPdbUtils> thisVtbl, char** pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[19])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsFullPDB(this ComPtr<IDxcPdbUtils> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Silk.NET.Core.Bool32>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullPDB(this ComPtr<IDxcPdbUtils> thisVtbl, IDxcBlob** ppFullPDB)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[21])(@this, ppFullPDB);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersionInfo(this ComPtr<IDxcPdbUtils> thisVtbl, IDxcVersionInfo** ppVersionInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCompiler(this ComPtr<IDxcPdbUtils> thisVtbl, IDxcCompiler3* pCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)@this->LpVtbl[23])(@this, pCompiler);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompileForFullPDB(this ComPtr<IDxcPdbUtils> thisVtbl, IDxcResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)@this->LpVtbl[24])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OverrideArgs(this ComPtr<IDxcPdbUtils> thisVtbl, ArgPair* pArgPairs, uint uNumArgPairs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)@this->LpVtbl[25])(@this, pArgPairs, uNumArgPairs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OverrideRootSignature(this ComPtr<IDxcPdbUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)@this->LpVtbl[26])(@this, pRootSignature);
        return ret;
    }

}
