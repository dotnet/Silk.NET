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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12ShaderCacheSessionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12ShaderCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12ShaderCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, void* pValue, uint* pValueSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, pValue, pValueSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue(this ComPtr<ID3D12ShaderCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pValue, uint ValueSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pValue, ValueSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDeleteOnDestroy(this ComPtr<ID3D12ShaderCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void>)@this->LpVtbl[10])(@this);
    }

    /// <summary>To be documented.</summary>
    public static ShaderCacheSessionDesc GetDesc(this ComPtr<ID3D12ShaderCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ShaderCacheSessionDesc silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ShaderCacheSessionDesc* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, ShaderCacheSessionDesc*, ShaderCacheSessionDesc*>)@this->LpVtbl[11])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

}
