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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load<TThis>(this TThis thisVtbl, IDxcBlob* pPdbOrDxil) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxil);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load<TThis>(this TThis thisVtbl, ref IDxcBlob pPdbOrDxil) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pPdbOrDxilPtr = &pPdbOrDxil)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxilPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceCount<TThis>(this TThis thisVtbl, uint* pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[4])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceCount<TThis>(this TThis thisVtbl, ref uint pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[4])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSource<TThis>(this TThis thisVtbl, uint uIndex, IDxcBlobEncoding** ppResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSource<TThis>(this TThis thisVtbl, uint uIndex, ref IDxcBlobEncoding* ppResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceName<TThis>(this TThis thisVtbl, uint uIndex, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[6])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceName<TThis>(this TThis thisVtbl, uint uIndex, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[6])(@this, uIndex, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlagCount<TThis>(this TThis thisVtbl, uint* pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[7])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFlagCount<TThis>(this TThis thisVtbl, ref uint pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[7])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlag<TThis>(this TThis thisVtbl, uint uIndex, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[8])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlag<TThis>(this TThis thisVtbl, uint uIndex, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[8])(@this, uIndex, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgCount<TThis>(this TThis thisVtbl, uint* pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[9])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetArgCount<TThis>(this TThis thisVtbl, ref uint pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[9])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArg<TThis>(this TThis thisVtbl, uint uIndex, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[10])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArg<TThis>(this TThis thisVtbl, uint uIndex, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[10])(@this, uIndex, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPairCount<TThis>(this TThis thisVtbl, uint* pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[11])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetArgPairCount<TThis>(this TThis thisVtbl, ref uint pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[11])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair<TThis>(this TThis thisVtbl, uint uIndex, char** pName, char** pValue) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pName, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair<TThis>(this TThis thisVtbl, uint uIndex, char** pName, ref char* pValue) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pName, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair<TThis>(this TThis thisVtbl, uint uIndex, ref char* pName, char** pValue) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pNamePtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair<TThis>(this TThis thisVtbl, uint uIndex, ref char* pName, ref char* pValue) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetDefineCount<TThis>(this TThis thisVtbl, uint* pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[13])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDefineCount<TThis>(this TThis thisVtbl, ref uint pCount) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[13])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefine<TThis>(this TThis thisVtbl, uint uIndex, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[14])(@this, uIndex, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefine<TThis>(this TThis thisVtbl, uint uIndex, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[14])(@this, uIndex, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetProfile<TThis>(this TThis thisVtbl, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[15])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetProfile<TThis>(this TThis thisVtbl, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[15])(@this, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPoint<TThis>(this TThis thisVtbl, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[16])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPoint<TThis>(this TThis thisVtbl, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[16])(@this, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMainFileName<TThis>(this TThis thisVtbl, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[17])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMainFileName<TThis>(this TThis thisVtbl, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[17])(@this, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHash<TThis>(this TThis thisVtbl, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[18])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHash<TThis>(this TThis thisVtbl, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[18])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName<TThis>(this TThis thisVtbl, char** pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[19])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName<TThis>(this TThis thisVtbl, ref char* pResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[19])(@this, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsFullPDB<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, int>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullPDB<TThis>(this TThis thisVtbl, IDxcBlob** ppFullPDB) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[21])(@this, ppFullPDB);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullPDB<TThis>(this TThis thisVtbl, ref IDxcBlob* ppFullPDB) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppFullPDBPtr = &ppFullPDB)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[21])(@this, ppFullPDBPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersionInfo<TThis>(this TThis thisVtbl, IDxcVersionInfo** ppVersionInfo) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersionInfo<TThis>(this TThis thisVtbl, ref IDxcVersionInfo* ppVersionInfo) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcVersionInfo** ppVersionInfoPtr = &ppVersionInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCompiler<TThis>(this TThis thisVtbl, IDxcCompiler3* pCompiler) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)@this->LpVtbl[23])(@this, pCompiler);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCompiler<TThis>(this TThis thisVtbl, ref IDxcCompiler3 pCompiler) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcCompiler3* pCompilerPtr = &pCompiler)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)@this->LpVtbl[23])(@this, pCompilerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompileForFullPDB<TThis>(this TThis thisVtbl, IDxcResult** ppResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)@this->LpVtbl[24])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompileForFullPDB<TThis>(this TThis thisVtbl, ref IDxcResult* ppResult) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)@this->LpVtbl[24])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OverrideArgs<TThis>(this TThis thisVtbl, ArgPair* pArgPairs, uint uNumArgPairs) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)@this->LpVtbl[25])(@this, pArgPairs, uNumArgPairs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OverrideArgs<TThis>(this TThis thisVtbl, ref ArgPair pArgPairs, uint uNumArgPairs) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ArgPair* pArgPairsPtr = &pArgPairs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)@this->LpVtbl[25])(@this, pArgPairsPtr, uNumArgPairs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OverrideRootSignature<TThis>(this TThis thisVtbl, char* pRootSignature) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)@this->LpVtbl[26])(@this, pRootSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OverrideRootSignature<TThis>(this TThis thisVtbl, ref char pRootSignature) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pRootSignaturePtr = &pRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)@this->LpVtbl[26])(@this, pRootSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OverrideRootSignature<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pRootSignature) where TThis : IComVtbl<IDxcPdbUtils>
    {
        var @this = (IDxcPdbUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pRootSignaturePtr = (byte*) SilkMarshal.StringToPtr(pRootSignature, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, byte*, int>)@this->LpVtbl[26])(@this, pRootSignaturePtr);
        SilkMarshal.Free((nint)pRootSignaturePtr);
        return ret;
    }

}
