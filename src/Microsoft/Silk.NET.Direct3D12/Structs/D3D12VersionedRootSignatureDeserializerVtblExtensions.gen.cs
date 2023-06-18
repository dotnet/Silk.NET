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

public unsafe static class D3D12VersionedRootSignatureDeserializerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VersionedRootSignatureDeserializer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VersionedRootSignatureDeserializer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VersionedRootSignatureDeserializer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VersionedRootSignatureDeserializer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VersionedRootSignatureDeserializer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRootSignatureDescAtVersion(this ComPtr<ID3D12VersionedRootSignatureDeserializer> thisVtbl, D3DRootSignatureVersion convertToVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc** ppDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VersionedRootSignatureDeserializer*, D3DRootSignatureVersion, VersionedRootSignatureDesc**, int>)@this->LpVtbl[3])(@this, convertToVersion, ppDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe VersionedRootSignatureDesc* GetUnconvertedRootSignatureDesc(this ComPtr<ID3D12VersionedRootSignatureDeserializer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        VersionedRootSignatureDesc* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VersionedRootSignatureDeserializer*, VersionedRootSignatureDesc*>)@this->LpVtbl[4])(@this);
        return ret;
    }

}
