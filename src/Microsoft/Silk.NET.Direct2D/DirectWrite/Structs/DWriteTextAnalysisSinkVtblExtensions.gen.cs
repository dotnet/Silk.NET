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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteTextAnalysisSinkVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextAnalysisSink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextAnalysisSink> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetScriptAnalysis(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, ScriptAnalysis*, int>)@this->LpVtbl[3])(@this, textPosition, textLength, scriptAnalysis);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetScriptAnalysis(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ScriptAnalysis scriptAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ScriptAnalysis* scriptAnalysisPtr = &scriptAnalysis)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, ScriptAnalysis*, int>)@this->LpVtbl[3])(@this, textPosition, textLength, scriptAnalysisPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLineBreakpoints(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LineBreakpoint* lineBreakpoints)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, LineBreakpoint*, int>)@this->LpVtbl[4])(@this, textPosition, textLength, lineBreakpoints);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLineBreakpoints(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LineBreakpoint lineBreakpoints)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LineBreakpoint* lineBreakpointsPtr = &lineBreakpoints)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, LineBreakpoint*, int>)@this->LpVtbl[4])(@this, textPosition, textLength, lineBreakpointsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBidiLevel(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, byte, byte, int>)@this->LpVtbl[5])(@this, textPosition, textLength, explicitLevel, resolvedLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, IDWriteNumberSubstitution*, int>)@this->LpVtbl[6])(@this, textPosition, textLength, numberSubstitution);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, ref IDWriteNumberSubstitution numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteNumberSubstitution* numberSubstitutionPtr = &numberSubstitution)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, IDWriteNumberSubstitution*, int>)@this->LpVtbl[6])(@this, textPosition, textLength, numberSubstitutionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetScriptAnalysis(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ScriptAnalysis> scriptAnalysis)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetScriptAnalysis(textPosition, textLength, in scriptAnalysis.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetLineBreakpoints(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LineBreakpoint> lineBreakpoints)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetLineBreakpoints(textPosition, textLength, in lineBreakpoints.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetNumberSubstitution<TI0>(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetNumberSubstitution(textPosition, textLength, (IDWriteNumberSubstitution*) numberSubstitution.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSink> thisVtbl, uint textPosition, uint textLength, Span<IDWriteNumberSubstitution> numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetNumberSubstitution(textPosition, textLength, ref numberSubstitution.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteTextAnalysisSink> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
