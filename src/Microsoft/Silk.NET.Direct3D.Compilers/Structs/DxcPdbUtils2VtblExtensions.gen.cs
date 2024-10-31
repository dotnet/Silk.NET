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

public unsafe static class DxcPdbUtils2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcPdbUtils2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcPdbUtils2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlob* pPdbOrDxil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxil);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlob pPdbOrDxil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pPdbOrDxilPtr = &pPdbOrDxil)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxilPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceCount(this ComPtr<IDxcPdbUtils2> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[4])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceCount(this ComPtr<IDxcPdbUtils2> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[4])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSource(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcBlobEncoding** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSource(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobEncoding* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceName(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[6])(@this, uIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceName(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[6])(@this, uIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibraryPDBCount(this ComPtr<IDxcPdbUtils2> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[7])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLibraryPDBCount(this ComPtr<IDxcPdbUtils2> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[7])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibraryPDB(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcPdbUtils2** ppOutPdbUtils, IDxcBlobWide** ppLibraryName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtils, ppLibraryName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibraryPDB(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcPdbUtils2** ppOutPdbUtils, ref IDxcBlobWide* ppLibraryName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppLibraryNamePtr = &ppLibraryName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtils, ppLibraryNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibraryPDB(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcPdbUtils2* ppOutPdbUtils, IDxcBlobWide** ppLibraryName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcPdbUtils2** ppOutPdbUtilsPtr = &ppOutPdbUtils)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtilsPtr, ppLibraryName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibraryPDB(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcPdbUtils2* ppOutPdbUtils, ref IDxcBlobWide* ppLibraryName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcPdbUtils2** ppOutPdbUtilsPtr = &ppOutPdbUtils)
        {
            fixed (IDxcBlobWide** ppLibraryNamePtr = &ppLibraryName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtilsPtr, ppLibraryNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlagCount(this ComPtr<IDxcPdbUtils2> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[9])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFlagCount(this ComPtr<IDxcPdbUtils2> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[9])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlag(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[10])(@this, uIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlag(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[10])(@this, uIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgCount(this ComPtr<IDxcPdbUtils2> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[11])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetArgCount(this ComPtr<IDxcPdbUtils2> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[11])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArg(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[12])(@this, uIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArg(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[12])(@this, uIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPairCount(this ComPtr<IDxcPdbUtils2> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[13])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetArgPairCount(this ComPtr<IDxcPdbUtils2> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[13])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcBlobWide** ppName, IDxcBlobWide** ppValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppName, ppValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcBlobWide** ppName, ref IDxcBlobWide* ppValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppValuePtr = &ppValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppName, ppValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobWide* ppName, IDxcBlobWide** ppValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppNamePtr = &ppName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppNamePtr, ppValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobWide* ppName, ref IDxcBlobWide* ppValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppNamePtr = &ppName)
        {
            fixed (IDxcBlobWide** ppValuePtr = &ppValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppNamePtr, ppValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefineCount(this ComPtr<IDxcPdbUtils2> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[15])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDefineCount(this ComPtr<IDxcPdbUtils2> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[15])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefine(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[16])(@this, uIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefine(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[16])(@this, uIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetProfile(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[17])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetProfile(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[17])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPoint(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[18])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEntryPoint(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[18])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMainFileName(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[19])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMainFileName(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[19])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHash(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[20])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHash(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[20])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlobWide** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[21])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlobWide* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobWide** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[21])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersionInfo(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcVersionInfo** ppVersionInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersionInfo(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcVersionInfo* ppVersionInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcVersionInfo** ppVersionInfoPtr = &ppVersionInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustomToolchainID(this ComPtr<IDxcPdbUtils2> thisVtbl, uint* pID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[23])(@this, pID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCustomToolchainID(this ComPtr<IDxcPdbUtils2> thisVtbl, ref uint pID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pIDPtr = &pID)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[23])(@this, pIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustomToolchainData(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlob** ppBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[24])(@this, ppBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustomToolchainData(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlob* ppBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppBlobPtr = &ppBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[24])(@this, ppBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWholeDxil(this ComPtr<IDxcPdbUtils2> thisVtbl, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[25])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWholeDxil(this ComPtr<IDxcPdbUtils2> thisVtbl, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[25])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsFullPDB(this ComPtr<IDxcPdbUtils2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsPDBRef(this ComPtr<IDxcPdbUtils2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Silk.NET.Core.Bool32>)@this->LpVtbl[27])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Load<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ComPtr<TI0> pPdbOrDxil) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Load((IDxcBlob*) pPdbOrDxil.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<IDxcBlob> pPdbOrDxil)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pPdbOrDxil.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceCount(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSourceCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSource<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSource(uIndex, (IDxcBlobEncoding**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceName<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSourceName(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetLibraryPDBCount(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLibraryPDBCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLibraryPDB<TI0, TI1>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppOutPdbUtils, ref ComPtr<TI1> ppLibraryName) where TI0 : unmanaged, IComVtbl<IDxcPdbUtils2>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetLibraryPDB(uIndex, (IDxcPdbUtils2**) ppOutPdbUtils.GetAddressOf(), (IDxcBlobWide**) ppLibraryName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibraryPDB<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppOutPdbUtils, ref IDxcBlobWide* ppLibraryName) where TI0 : unmanaged, IComVtbl<IDxcPdbUtils2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetLibraryPDB(uIndex, (IDxcPdbUtils2**) ppOutPdbUtils.GetAddressOf(), ref ppLibraryName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibraryPDB<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcPdbUtils2* ppOutPdbUtils, ref ComPtr<TI0> ppLibraryName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetLibraryPDB(uIndex, ref ppOutPdbUtils, (IDxcBlobWide**) ppLibraryName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFlagCount(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFlagCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFlag<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFlag(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetArgCount(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetArgCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetArg<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetArg(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetArgPairCount(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetArgPairCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetArgPair<TI0, TI1>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppName, ref ComPtr<TI1> ppValue) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetArgPair(uIndex, (IDxcBlobWide**) ppName.GetAddressOf(), (IDxcBlobWide**) ppValue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppName, ref IDxcBlobWide* ppValue) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetArgPair(uIndex, (IDxcBlobWide**) ppName.GetAddressOf(), ref ppValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetArgPair<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref IDxcBlobWide* ppName, ref ComPtr<TI0> ppValue) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetArgPair(uIndex, ref ppName, (IDxcBlobWide**) ppValue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetDefineCount(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDefineCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDefine<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDefine(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetTargetProfile<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTargetProfile((IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetEntryPoint<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEntryPoint((IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetMainFileName<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMainFileName((IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetHash<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetHash((IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetName<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetName((IDxcBlobWide**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetVersionInfo<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppVersionInfo) where TI0 : unmanaged, IComVtbl<IDxcVersionInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetVersionInfo((IDxcVersionInfo**) ppVersionInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetCustomToolchainID(this ComPtr<IDxcPdbUtils2> thisVtbl, Span<uint> pID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCustomToolchainID(ref pID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCustomToolchainData<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppBlob) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCustomToolchainData((IDxcBlob**) ppBlob.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetWholeDxil<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetWholeDxil((IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcPdbUtils2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
