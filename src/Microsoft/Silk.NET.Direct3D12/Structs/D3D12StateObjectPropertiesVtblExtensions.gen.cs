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

public unsafe static class D3D12StateObjectPropertiesVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectProperties> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12StateObjectProperties> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12StateObjectProperties> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetShaderIdentifier(this ComPtr<ID3D12StateObjectProperties> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, void*>)@this->LpVtbl[3])(@this, pExportName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ulong GetShaderStackSize(this ComPtr<ID3D12StateObjectProperties> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, ulong>)@this->LpVtbl[4])(@this, pExportName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetPipelineStackSize(this ComPtr<ID3D12StateObjectProperties> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, ulong>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineStackSize(this ComPtr<ID3D12StateObjectProperties> thisVtbl, ulong PipelineStackSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, ulong, void>)@this->LpVtbl[6])(@this, PipelineStackSizeInBytes);
    }

}
