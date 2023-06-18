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

public unsafe static class D3D12Debug4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Debug4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12Debug4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12Debug4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void EnableDebugLayer(this ComPtr<ID3D12Debug4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, void>)@this->LpVtbl[3])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableGPUBasedValidation(this ComPtr<ID3D12Debug4> thisVtbl, Silk.NET.Core.Bool32 Enable)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[4])(@this, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void SetEnableSynchronizedCommandQueueValidation(this ComPtr<ID3D12Debug4> thisVtbl, Silk.NET.Core.Bool32 Enable)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[5])(@this, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void SetGPUBasedValidationFlags(this ComPtr<ID3D12Debug4> thisVtbl, GpuBasedValidationFlags Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, GpuBasedValidationFlags, void>)@this->LpVtbl[6])(@this, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void DisableDebugLayer(this ComPtr<ID3D12Debug4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, void>)@this->LpVtbl[7])(@this);
    }

}
