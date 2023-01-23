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
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTrace> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTrace> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTrace> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int TraceReady(this ComPtr<ID3D11ShaderTrace> thisVtbl, ref ulong pTestCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pTestCountPtr = &pTestCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)@this->LpVtbl[3])(@this, pTestCountPtr);
        }
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
    public static int GetTraceStats(this ComPtr<ID3D11ShaderTrace> thisVtbl, ref TraceStats pTraceStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceStats* pTraceStatsPtr = &pTraceStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)@this->LpVtbl[5])(@this, pTraceStatsPtr);
        }
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
    public static unsafe int GetInitialRegisterContents(this ComPtr<ID3D11ShaderTrace> thisVtbl, TraceRegister* pRegister, ref TraceValue pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceValue* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegister, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents(this ComPtr<ID3D11ShaderTrace> thisVtbl, ref TraceRegister pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegisterPtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetInitialRegisterContents(this ComPtr<ID3D11ShaderTrace> thisVtbl, ref TraceRegister pRegister, ref TraceValue pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            fixed (TraceValue* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegisterPtr, pValuePtr);
            }
        }
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
    public static int GetStep(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, ref TraceStep pTraceStep)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceStep* pTraceStepPtr = &pTraceStep)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)@this->LpVtbl[8])(@this, stepIndex, pTraceStepPtr);
        }
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
    public static unsafe int GetWrittenRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceValue* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWrittenRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            fixed (TraceValue* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValuePtr);
            }
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceValue* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetReadRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            fixed (TraceValue* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11ShaderTrace> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTrace> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTrace> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int TraceReady(this ComPtr<ID3D11ShaderTrace> thisVtbl, Span<ulong> pTestCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TraceReady(ref pTestCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTraceStats(this ComPtr<ID3D11ShaderTrace> thisVtbl, Span<TraceStats> pTraceStats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTraceStats(ref pTraceStats.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents(this ComPtr<ID3D11ShaderTrace> thisVtbl, TraceRegister* pRegister, Span<TraceValue> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInitialRegisterContents(pRegister, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents(this ComPtr<ID3D11ShaderTrace> thisVtbl, Span<TraceRegister> pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInitialRegisterContents(ref pRegister.GetPinnableReference(), pValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetInitialRegisterContents(this ComPtr<ID3D11ShaderTrace> thisVtbl, Span<TraceRegister> pRegister, Span<TraceValue> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInitialRegisterContents(ref pRegister.GetPinnableReference(), ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStep(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, Span<TraceStep> pTraceStep)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStep(stepIndex, ref pTraceStep.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, Span<TraceValue> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWrittenRegister(stepIndex, writtenRegisterIndex, pRegister, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint writtenRegisterIndex, Span<TraceRegister> pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWrittenRegister(stepIndex, writtenRegisterIndex, ref pRegister.GetPinnableReference(), pValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetWrittenRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint writtenRegisterIndex, Span<TraceRegister> pRegister, Span<TraceValue> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWrittenRegister(stepIndex, writtenRegisterIndex, ref pRegister.GetPinnableReference(), ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, Span<TraceValue> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetReadRegister(stepIndex, readRegisterIndex, pRegister, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint readRegisterIndex, Span<TraceRegister> pRegister, TraceValue* pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetReadRegister(stepIndex, readRegisterIndex, ref pRegister.GetPinnableReference(), pValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetReadRegister(this ComPtr<ID3D11ShaderTrace> thisVtbl, uint stepIndex, uint readRegisterIndex, Span<TraceRegister> pRegister, Span<TraceValue> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetReadRegister(stepIndex, readRegisterIndex, ref pRegister.GetPinnableReference(), ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11ShaderTrace> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
