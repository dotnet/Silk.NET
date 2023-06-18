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

namespace Silk.NET.DirectStorage;

public unsafe static class DStorageCustomDecompressionQueue1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageCustomDecompressionQueue1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDStorageCustomDecompressionQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDStorageCustomDecompressionQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetEvent(this ComPtr<IDStorageCustomDecompressionQueue1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, void*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequests(this ComPtr<IDStorageCustomDecompressionQueue1> thisVtbl, uint maxRequests, CustomDecompressionRequest* requests, uint* numRequests)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[4])(@this, maxRequests, requests, numRequests);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetRequestResults(this ComPtr<IDStorageCustomDecompressionQueue1> thisVtbl, uint numResults, CustomDecompressionResult* results)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint, CustomDecompressionResult*, int>)@this->LpVtbl[5])(@this, numResults, results);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRequests1(this ComPtr<IDStorageCustomDecompressionQueue1> thisVtbl, GetRequestFlags flags, uint maxRequests, CustomDecompressionRequest* requests, uint* numRequests)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, GetRequestFlags, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[6])(@this, flags, maxRequests, requests, numRequests);
        return ret;
    }

}
