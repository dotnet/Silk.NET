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

public unsafe static class D3D11ShaderTraceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTrace> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11ShaderTrace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11ShaderTrace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TraceReady(this ComPtr<ID3D11ShaderTrace> thisVtbl, ulong* pTestCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)@this->LpVtbl[3])(@this, pTestCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ResetTrace(this ComPtr<ID3D11ShaderTrace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTraceStats(this ComPtr<ID3D11ShaderTrace> thisVtbl, TraceStats* pTraceStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)@this->LpVtbl[5])(@this, pTraceStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PSSelectStamp(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stampIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, int>)@this->LpVtbl[6])(@this, stampIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents(this ComPtr<ID3D11ShaderTrace> thisVtbl, TraceRegister* pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegister, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStep(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, TraceStep* pTraceStep)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)@this->LpVtbl[8])(@this, stepIndex, pTraceStep);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValue);
        return ret;
    }

}
