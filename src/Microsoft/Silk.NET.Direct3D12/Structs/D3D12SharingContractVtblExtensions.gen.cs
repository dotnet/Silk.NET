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

public unsafe static class D3D12SharingContractVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SharingContract> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12SharingContract> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12SharingContract> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Present(this ComPtr<ID3D12SharingContract> thisVtbl, ID3D12Resource* pResource, uint Subresource, nint window)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)@this->LpVtbl[3])(@this, pResource, Subresource, window);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SharedFenceSignal(this ComPtr<ID3D12SharingContract> thisVtbl, ID3D12Fence* pFence, ulong FenceValue)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)@this->LpVtbl[4])(@this, pFence, FenceValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, Guid* guid)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[5])(@this, guid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndCapturableWork(this ComPtr<ID3D12SharingContract> thisVtbl, Guid* guid)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[6])(@this, guid);
    }

}
