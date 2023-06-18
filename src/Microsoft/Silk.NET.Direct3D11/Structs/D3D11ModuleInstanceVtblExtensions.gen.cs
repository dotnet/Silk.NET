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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11ModuleInstanceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ModuleInstance> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11ModuleInstance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11ModuleInstance> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindConstantBuffer(this ComPtr<ID3D11ModuleInstance> thisVtbl, uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindConstantBufferByName(this ComPtr<ID3D11ModuleInstance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint cbDstOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResource(this ComPtr<ID3D11ModuleInstance> thisVtbl, uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindResourceByName(this ComPtr<ID3D11ModuleInstance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[6])(@this, pName, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindSampler(this ComPtr<ID3D11ModuleInstance> thisVtbl, uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindSamplerByName(this ComPtr<ID3D11ModuleInstance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[8])(@this, pName, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindUnorderedAccessView(this ComPtr<ID3D11ModuleInstance> thisVtbl, uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindUnorderedAccessViewByName(this ComPtr<ID3D11ModuleInstance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[10])(@this, pName, uDstSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BindResourceAsUnorderedAccessView(this ComPtr<ID3D11ModuleInstance> thisVtbl, uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindResourceAsUnorderedAccessViewByName(this ComPtr<ID3D11ModuleInstance> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrvName, uint uDstUavSlot, uint uCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
        return ret;
    }

}
