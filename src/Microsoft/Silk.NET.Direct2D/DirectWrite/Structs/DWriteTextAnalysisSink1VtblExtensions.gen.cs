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

public unsafe static class DWriteTextAnalysisSink1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetScriptAnalysis(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, ScriptAnalysis*, int>)@this->LpVtbl[3])(@this, textPosition, textLength, scriptAnalysis);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLineBreakpoints(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl, uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LineBreakpoint* lineBreakpoints)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, LineBreakpoint*, int>)@this->LpVtbl[4])(@this, textPosition, textLength, lineBreakpoints);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBidiLevel(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl, uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, byte, byte, int>)@this->LpVtbl[5])(@this, textPosition, textLength, explicitLevel, resolvedLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl, uint textPosition, uint textLength, IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, IDWriteNumberSubstitution*, int>)@this->LpVtbl[6])(@this, textPosition, textLength, numberSubstitution);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGlyphOrientation(this ComPtr<IDWriteTextAnalysisSink1> thisVtbl, uint textPosition, uint textLength, GlyphOrientationAngle glyphOrientationAngle, byte adjustedBidiLevel, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, GlyphOrientationAngle, byte, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, textPosition, textLength, glyphOrientationAngle, adjustedBidiLevel, isSideways, isRightToLeft);
        return ret;
    }

}
