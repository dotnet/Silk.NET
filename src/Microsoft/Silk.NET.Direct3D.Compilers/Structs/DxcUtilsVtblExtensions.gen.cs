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

public unsafe static class DxcUtilsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcUtils> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcUtils> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcUtils> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlob, offset, length, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pData, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMalloc, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pData, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlob, ppStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDefaultIncludeHandler(this ComPtr<IDxcUtils> thisVtbl, IDxcIncludeHandler** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pBlob, IDxcBlobUtf16** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, Guid* iid, void** ppvReflection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iid, ppvReflection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments(this ComPtr<IDxcUtils> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents(this ComPtr<IDxcUtils> thisVtbl, IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainer);
        return ret;
    }

}
