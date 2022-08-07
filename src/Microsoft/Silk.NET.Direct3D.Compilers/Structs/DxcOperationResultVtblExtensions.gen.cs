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

public unsafe static class DxcOperationResultVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatus<TThis>(this TThis thisVtbl, int* pStatus) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, int*, int>)@this->LpVtbl[3])(@this, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStatus<TThis>(this TThis thisVtbl, ref int pStatus) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, int*, int>)@this->LpVtbl[3])(@this, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResult<TThis>(this TThis thisVtbl, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, IDxcBlob**, int>)@this->LpVtbl[4])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResult<TThis>(this TThis thisVtbl, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, IDxcBlob**, int>)@this->LpVtbl[4])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetErrorBuffer<TThis>(this TThis thisVtbl, IDxcBlobEncoding** ppErrors) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, ppErrors);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetErrorBuffer<TThis>(this TThis thisVtbl, ref IDxcBlobEncoding* ppErrors) where TThis : IComVtbl<IDxcOperationResult>
    {
        var @this = (IDxcOperationResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** ppErrorsPtr = &ppErrors)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, ppErrorsPtr);
        }
        return ret;
    }

}
