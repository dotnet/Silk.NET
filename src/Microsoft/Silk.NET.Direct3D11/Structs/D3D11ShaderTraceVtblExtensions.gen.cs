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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TraceReady<TThis>(this TThis thisVtbl, ulong* pTestCount) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)@this->LpVtbl[3])(@this, pTestCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TraceReady<TThis>(this TThis thisVtbl, ref ulong pTestCount) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ulong* pTestCountPtr = &pTestCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, ulong*, int>)@this->LpVtbl[3])(@this, pTestCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ResetTrace<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTraceStats<TThis>(this TThis thisVtbl, TraceStats* pTraceStats) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)@this->LpVtbl[5])(@this, pTraceStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTraceStats<TThis>(this TThis thisVtbl, ref TraceStats pTraceStats) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceStats* pTraceStatsPtr = &pTraceStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceStats*, int>)@this->LpVtbl[5])(@this, pTraceStatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PSSelectStamp<TThis>(this TThis thisVtbl, uint stampIndex) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, int>)@this->LpVtbl[6])(@this, stampIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents<TThis>(this TThis thisVtbl, TraceRegister* pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegister, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents<TThis>(this TThis thisVtbl, TraceRegister* pRegister, ref TraceValue pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceValue* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegister, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents<TThis>(this TThis thisVtbl, ref TraceRegister pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)@this->LpVtbl[7])(@this, pRegisterPtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetInitialRegisterContents<TThis>(this TThis thisVtbl, ref TraceRegister pRegister, ref TraceValue pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetStep<TThis>(this TThis thisVtbl, uint stepIndex, TraceStep* pTraceStep) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)@this->LpVtbl[8])(@this, stepIndex, pTraceStep);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStep<TThis>(this TThis thisVtbl, uint stepIndex, ref TraceStep pTraceStep) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceStep* pTraceStepPtr = &pTraceStep)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, TraceStep*, int>)@this->LpVtbl[8])(@this, stepIndex, pTraceStepPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceValue* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegister, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[9])(@this, stepIndex, writtenRegisterIndex, pRegisterPtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWrittenRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint writtenRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetReadRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, ref TraceValue pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceValue* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegister, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TraceRegister* pRegisterPtr = &pRegister)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)@this->LpVtbl[10])(@this, stepIndex, readRegisterIndex, pRegisterPtr, pValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetReadRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint readRegisterIndex, ref TraceRegister pRegister, ref TraceValue pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
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
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int TraceReady<TThis>(this TThis thisVtbl, Span<ulong> pTestCount) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->TraceReady(ref pTestCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTraceStats<TThis>(this TThis thisVtbl, Span<TraceStats> pTraceStats) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetTraceStats(ref pTraceStats.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents<TThis>(this TThis thisVtbl, TraceRegister* pRegister, Span<TraceValue> pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetInitialRegisterContents(pRegister, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInitialRegisterContents<TThis>(this TThis thisVtbl, Span<TraceRegister> pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetInitialRegisterContents(ref pRegister.GetPinnableReference(), pValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetInitialRegisterContents<TThis>(this TThis thisVtbl, Span<TraceRegister> pRegister, Span<TraceValue> pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetInitialRegisterContents(ref pRegister.GetPinnableReference(), ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStep<TThis>(this TThis thisVtbl, uint stepIndex, Span<TraceStep> pTraceStep) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStep(stepIndex, ref pTraceStep.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, Span<TraceValue> pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetWrittenRegister(stepIndex, writtenRegisterIndex, pRegister, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrittenRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint writtenRegisterIndex, Span<TraceRegister> pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetWrittenRegister(stepIndex, writtenRegisterIndex, ref pRegister.GetPinnableReference(), pValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetWrittenRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint writtenRegisterIndex, Span<TraceRegister> pRegister, Span<TraceValue> pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetWrittenRegister(stepIndex, writtenRegisterIndex, ref pRegister.GetPinnableReference(), ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, Span<TraceValue> pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetReadRegister(stepIndex, readRegisterIndex, pRegister, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReadRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint readRegisterIndex, Span<TraceRegister> pRegister, TraceValue* pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetReadRegister(stepIndex, readRegisterIndex, ref pRegister.GetPinnableReference(), pValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetReadRegister<TThis>(this TThis thisVtbl, uint stepIndex, uint readRegisterIndex, Span<TraceRegister> pRegister, Span<TraceValue> pValue) where TThis : IComVtbl<ID3D11ShaderTrace>
    {
        var @this = (ID3D11ShaderTrace*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetReadRegister(stepIndex, readRegisterIndex, ref pRegister.GetPinnableReference(), ref pValue.GetPinnableReference());
    }

}
