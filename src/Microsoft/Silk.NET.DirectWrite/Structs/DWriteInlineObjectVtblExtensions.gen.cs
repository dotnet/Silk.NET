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
    public static unsafe int QueryInterface(this ComPtr<IDWriteInlineObject> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInlineObject> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInlineObject> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe int Draw(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextRenderer* rendererPtr = &renderer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextRenderer* rendererPtr = &renderer)
        {
            fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, ref T0 clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, ref T0 clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            fixed (IDWriteTextRenderer* rendererPtr = &renderer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            fixed (IDWriteTextRenderer* rendererPtr = &renderer)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
                }
            }
        }
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
    public static int GetMetrics(this ComPtr<IDWriteInlineObject> thisVtbl, ref InlineObjectMetrics metrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InlineObjectMetrics* metricsPtr = &metrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, InlineObjectMetrics*, int>)@this->LpVtbl[4])(@this, metricsPtr);
        }
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
    public static int GetOverhangMetrics(this ComPtr<IDWriteInlineObject> thisVtbl, ref OverhangMetrics overhangs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OverhangMetrics* overhangsPtr = &overhangs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, OverhangMetrics*, int>)@this->LpVtbl[5])(@this, overhangsPtr);
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int GetBreakConditions(this ComPtr<IDWriteInlineObject> thisVtbl, BreakCondition* breakConditionBefore, ref BreakCondition breakConditionAfter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BreakCondition* breakConditionAfterPtr = &breakConditionAfter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBefore, breakConditionAfterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBreakConditions(this ComPtr<IDWriteInlineObject> thisVtbl, ref BreakCondition breakConditionBefore, BreakCondition* breakConditionAfter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BreakCondition* breakConditionBeforePtr = &breakConditionBefore)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBeforePtr, breakConditionAfter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakConditions(this ComPtr<IDWriteInlineObject> thisVtbl, ref BreakCondition breakConditionBefore, ref BreakCondition breakConditionAfter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BreakCondition* breakConditionBeforePtr = &breakConditionBefore)
        {
            fixed (BreakCondition* breakConditionAfterPtr = &breakConditionAfter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBeforePtr, breakConditionAfterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteInlineObject> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInlineObject> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInlineObject> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<TI0, TI1>(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<TI0>(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, Span<IDWriteTextRenderer> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(clientDrawingContext, ref renderer.GetPinnableReference(), originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<TI0>(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(clientDrawingContext, ref renderer, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteInlineObject> thisVtbl, void* clientDrawingContext, Span<IDWriteTextRenderer> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(clientDrawingContext, ref renderer.GetPinnableReference(), originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, Span<T0> clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref clientDrawingContext.GetPinnableReference(), renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0, TI0, TI1>(this ComPtr<IDWriteInlineObject> thisVtbl, ref T0 clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(ref clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, Span<T0> clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref clientDrawingContext.GetPinnableReference(), renderer, originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0, TI0>(this ComPtr<IDWriteInlineObject> thisVtbl, ref T0 clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(ref clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, Span<T0> clientDrawingContext, Span<IDWriteTextRenderer> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref clientDrawingContext.GetPinnableReference(), ref renderer.GetPinnableReference(), originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0, TI0>(this ComPtr<IDWriteInlineObject> thisVtbl, ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(ref clientDrawingContext, ref renderer, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0>(this ComPtr<IDWriteInlineObject> thisVtbl, Span<T0> clientDrawingContext, Span<IDWriteTextRenderer> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Core.Native.IUnknown> clientDrawingEffect) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref clientDrawingContext.GetPinnableReference(), ref renderer.GetPinnableReference(), originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetrics(this ComPtr<IDWriteInlineObject> thisVtbl, Span<InlineObjectMetrics> metrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetrics(ref metrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetOverhangMetrics(this ComPtr<IDWriteInlineObject> thisVtbl, Span<OverhangMetrics> overhangs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetOverhangMetrics(ref overhangs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBreakConditions(this ComPtr<IDWriteInlineObject> thisVtbl, BreakCondition* breakConditionBefore, Span<BreakCondition> breakConditionAfter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBreakConditions(breakConditionBefore, ref breakConditionAfter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBreakConditions(this ComPtr<IDWriteInlineObject> thisVtbl, Span<BreakCondition> breakConditionBefore, BreakCondition* breakConditionAfter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBreakConditions(ref breakConditionBefore.GetPinnableReference(), breakConditionAfter);
    }

    /// <summary>To be documented.</summary>
    public static int GetBreakConditions(this ComPtr<IDWriteInlineObject> thisVtbl, Span<BreakCondition> breakConditionBefore, Span<BreakCondition> breakConditionAfter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBreakConditions(ref breakConditionBefore.GetPinnableReference(), ref breakConditionAfter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteInlineObject> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
