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

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionDelegatedInkTrailVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPoints, inkPointsCount, generationId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, ref uint generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* generationIdPtr = &generationId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPoints, inkPointsCount, generationIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPointsPtr, inkPointsCount, generationId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, ref uint generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
        {
            fixed (uint* generationIdPtr = &generationId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPointsPtr, inkPointsCount, generationIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* generationIdPtr = &generationId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
        {
            fixed (uint* generationIdPtr = &generationId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
        {
            fixed (uint* generationIdPtr = &generationId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
        {
            fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationId);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
        {
            fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
            {
                fixed (uint* generationIdPtr = &generationId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationIdPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, uint generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, uint, int>)@this->LpVtbl[5])(@this, generationId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StartNewTrail(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[6])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StartNewTrail(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[6])(@this, colorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, Span<uint> generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPoints(inkPoints, inkPointsCount, ref generationId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> inkPoints, uint inkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPoints(in inkPoints.GetPinnableReference(), inkPointsCount, generationId);
    }

    /// <summary>To be documented.</summary>
    public static int AddTrailPoints(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> inkPoints, uint inkPointsCount, Span<uint> generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPoints(in inkPoints.GetPinnableReference(), inkPointsCount, ref generationId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, Span<uint> generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPointsWithPrediction(inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, ref generationId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPointsWithPrediction(inkPoints, inkPointsCount, in predictedInkPoints.GetPinnableReference(), predictedInkPointsCount, generationId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> predictedInkPoints, uint predictedInkPointsCount, Span<uint> generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPointsWithPrediction(inkPoints, inkPointsCount, in predictedInkPoints.GetPinnableReference(), predictedInkPointsCount, ref generationId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPointsWithPrediction(in inkPoints.GetPinnableReference(), inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, Span<uint> generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPointsWithPrediction(in inkPoints.GetPinnableReference(), inkPointsCount, predictedInkPoints, predictedInkPointsCount, ref generationId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPointsWithPrediction(in inkPoints.GetPinnableReference(), inkPointsCount, in predictedInkPoints.GetPinnableReference(), predictedInkPointsCount, generationId);
    }

    /// <summary>To be documented.</summary>
    public static int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InkTrailPoint> predictedInkPoints, uint predictedInkPointsCount, Span<uint> generationId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTrailPointsWithPrediction(in inkPoints.GetPinnableReference(), inkPointsCount, in predictedInkPoints.GetPinnableReference(), predictedInkPointsCount, ref generationId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int StartNewTrail(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, Span<Silk.NET.DXGI.D3Dcolorvalue> color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StartNewTrail(ref color.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
