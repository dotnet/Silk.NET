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
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int Load(this ComPtr<IDxcPdbUtils> thisVtbl, ref IDxcBlob pPdbOrDxil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pPdbOrDxilPtr = &pPdbOrDxil)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxilPtr);
        }
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
    public static int GetSourceCount(this ComPtr<IDxcPdbUtils> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[4])(@this, pCountPtr);
        }
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
    public static unsafe int GetSource(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref IDxcBlobEncoding* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResultPtr);
        }
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
    public static unsafe int GetSourceName(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[6])(@this, uIndex, pResultPtr);
        }
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
    public static int GetFlagCount(this ComPtr<IDxcPdbUtils> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[7])(@this, pCountPtr);
        }
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
    public static unsafe int GetFlag(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[8])(@this, uIndex, pResultPtr);
        }
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
    public static int GetArgCount(this ComPtr<IDxcPdbUtils> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[9])(@this, pCountPtr);
        }
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
    public static unsafe int GetArg(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[10])(@this, uIndex, pResultPtr);
        }
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
    public static int GetArgPairCount(this ComPtr<IDxcPdbUtils> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[11])(@this, pCountPtr);
        }
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
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, char** pName, ref char* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pName, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref char* pName, char** pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pNamePtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref char* pName, ref char* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pNamePtr = &pName)
        {
            fixed (char** pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pNamePtr, pValuePtr);
            }
        }
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
    public static int GetDefineCount(this ComPtr<IDxcPdbUtils> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[13])(@this, pCountPtr);
        }
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
    public static unsafe int GetDefine(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[14])(@this, uIndex, pResultPtr);
        }
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
    public static unsafe int GetTargetProfile(this ComPtr<IDxcPdbUtils> thisVtbl, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[15])(@this, pResultPtr);
        }
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
    public static unsafe int GetEntryPoint(this ComPtr<IDxcPdbUtils> thisVtbl, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[16])(@this, pResultPtr);
        }
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
    public static unsafe int GetMainFileName(this ComPtr<IDxcPdbUtils> thisVtbl, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[17])(@this, pResultPtr);
        }
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
    public static unsafe int GetHash(this ComPtr<IDxcPdbUtils> thisVtbl, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[18])(@this, ppResultPtr);
        }
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
    public static unsafe int GetName(this ComPtr<IDxcPdbUtils> thisVtbl, ref char* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[19])(@this, pResultPtr);
        }
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
    public static unsafe int GetFullPDB(this ComPtr<IDxcPdbUtils> thisVtbl, ref IDxcBlob* ppFullPDB)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppFullPDBPtr = &ppFullPDB)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[21])(@this, ppFullPDBPtr);
        }
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
    public static unsafe int GetVersionInfo(this ComPtr<IDxcPdbUtils> thisVtbl, ref IDxcVersionInfo* ppVersionInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcVersionInfo** ppVersionInfoPtr = &ppVersionInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfoPtr);
        }
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
    public static int SetCompiler(this ComPtr<IDxcPdbUtils> thisVtbl, ref IDxcCompiler3 pCompiler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcCompiler3* pCompilerPtr = &pCompiler)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)@this->LpVtbl[23])(@this, pCompilerPtr);
        }
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
    public static unsafe int CompileForFullPDB(this ComPtr<IDxcPdbUtils> thisVtbl, ref IDxcResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)@this->LpVtbl[24])(@this, ppResultPtr);
        }
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
    public static int OverrideArgs(this ComPtr<IDxcPdbUtils> thisVtbl, ref ArgPair pArgPairs, uint uNumArgPairs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ArgPair* pArgPairsPtr = &pArgPairs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)@this->LpVtbl[25])(@this, pArgPairsPtr, uNumArgPairs);
        }
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

    /// <summary>To be documented.</summary>
    public static int OverrideRootSignature(this ComPtr<IDxcPdbUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pRootSignaturePtr = &pRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)@this->LpVtbl[26])(@this, pRootSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OverrideRootSignature(this ComPtr<IDxcPdbUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pRootSignaturePtr = (byte*) SilkMarshal.StringToPtr(pRootSignature, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, byte*, int>)@this->LpVtbl[26])(@this, pRootSignaturePtr);
        SilkMarshal.Free((nint)pRootSignaturePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Load<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, ComPtr<TI0> pPdbOrDxil) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Load((IDxcBlob*) pPdbOrDxil.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IDxcPdbUtils> thisVtbl, Span<IDxcBlob> pPdbOrDxil)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pPdbOrDxil.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceCount(this ComPtr<IDxcPdbUtils> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSourceCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSource<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSource(uIndex, (IDxcBlobEncoding**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceName(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetSourceName(uIndex, pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFlagCount(this ComPtr<IDxcPdbUtils> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFlagCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFlag(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetFlag(uIndex, pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetArgCount(this ComPtr<IDxcPdbUtils> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetArgCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetArg(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetArg(uIndex, pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetArgPairCount(this ComPtr<IDxcPdbUtils> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetArgPairCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetArgPair(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, string[] pNameSa, string[] pValueSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pName = (char**) SilkMarshal.StringArrayToPtr(pNameSa);
        var pValue = (char**) SilkMarshal.StringArrayToPtr(pValueSa);
        var ret = @this->GetArgPair(uIndex, pName, pValue);
        SilkMarshal.CopyPtrToStringArray((nint) pName, pNameSa);
        SilkMarshal.Free((nint) pName);
        SilkMarshal.CopyPtrToStringArray((nint) pValue, pValueSa);
        SilkMarshal.Free((nint) pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, string[] pNameSa, ref char* pValue)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pName = (char**) SilkMarshal.StringArrayToPtr(pNameSa);
        var ret = @this->GetArgPair(uIndex, pName, ref pValue);
        SilkMarshal.CopyPtrToStringArray((nint) pName, pNameSa);
        SilkMarshal.Free((nint) pName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, ref char* pName, string[] pValueSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pValue = (char**) SilkMarshal.StringArrayToPtr(pValueSa);
        var ret = @this->GetArgPair(uIndex, ref pName, pValue);
        SilkMarshal.CopyPtrToStringArray((nint) pValue, pValueSa);
        SilkMarshal.Free((nint) pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDefineCount(this ComPtr<IDxcPdbUtils> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDefineCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDefine(this ComPtr<IDxcPdbUtils> thisVtbl, uint uIndex, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetDefine(uIndex, pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTargetProfile(this ComPtr<IDxcPdbUtils> thisVtbl, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetTargetProfile(pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEntryPoint(this ComPtr<IDxcPdbUtils> thisVtbl, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetEntryPoint(pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMainFileName(this ComPtr<IDxcPdbUtils> thisVtbl, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetMainFileName(pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHash<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetHash((IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetName(this ComPtr<IDxcPdbUtils> thisVtbl, string[] pResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
        var ret = @this->GetName(pResult);
        SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
        SilkMarshal.Free((nint) pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFullPDB<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, ref ComPtr<TI0> ppFullPDB) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFullPDB((IDxcBlob**) ppFullPDB.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetVersionInfo<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, ref ComPtr<TI0> ppVersionInfo) where TI0 : unmanaged, IComVtbl<IDxcVersionInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetVersionInfo((IDxcVersionInfo**) ppVersionInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetCompiler<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, ComPtr<TI0> pCompiler) where TI0 : unmanaged, IComVtbl<IDxcCompiler3>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetCompiler((IDxcCompiler3*) pCompiler.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetCompiler(this ComPtr<IDxcPdbUtils> thisVtbl, Span<IDxcCompiler3> pCompiler)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCompiler(ref pCompiler.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CompileForFullPDB<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CompileForFullPDB((IDxcResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int OverrideArgs(this ComPtr<IDxcPdbUtils> thisVtbl, Span<ArgPair> pArgPairs, uint uNumArgPairs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OverrideArgs(ref pArgPairs.GetPinnableReference(), uNumArgPairs);
    }

    /// <summary>To be documented.</summary>
    public static int OverrideRootSignature(this ComPtr<IDxcPdbUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OverrideRootSignature(in pRootSignature.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcPdbUtils> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
