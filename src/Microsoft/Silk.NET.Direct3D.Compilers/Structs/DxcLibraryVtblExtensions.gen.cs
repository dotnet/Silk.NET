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

public unsafe static class DxcLibraryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLibrary> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcLibrary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcLibrary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMalloc(this ComPtr<IDxcLibrary> thisVtbl, IMalloc* pMalloc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IMalloc*, int>)@this->LpVtbl[3])(@this, pMalloc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlob, offset, length, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc(this ComPtr<IDxcLibrary> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIncludeHandler(this ComPtr<IDxcLibrary> thisVtbl, IDxcIncludeHandler** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, void** ppStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlob, ppStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16(this ComPtr<IDxcLibrary> thisVtbl, IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlob, pBlobEncoding);
        return ret;
    }

}
