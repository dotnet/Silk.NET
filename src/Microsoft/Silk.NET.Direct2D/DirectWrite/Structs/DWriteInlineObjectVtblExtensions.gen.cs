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

public unsafe static class DWriteInlineObjectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInlineObject> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteInlineObject> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteInlineObject> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetrics(this ComPtr<IDWriteInlineObject> thisVtbl, InlineObjectMetrics* metrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, InlineObjectMetrics*, int>)@this->LpVtbl[4])(@this, metrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOverhangMetrics(this ComPtr<IDWriteInlineObject> thisVtbl, OverhangMetrics* overhangs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, OverhangMetrics*, int>)@this->LpVtbl[5])(@this, overhangs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBreakConditions(this ComPtr<IDWriteInlineObject> thisVtbl, BreakCondition* breakConditionBefore, BreakCondition* breakConditionAfter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBefore, breakConditionAfter);
        return ret;
    }

}
