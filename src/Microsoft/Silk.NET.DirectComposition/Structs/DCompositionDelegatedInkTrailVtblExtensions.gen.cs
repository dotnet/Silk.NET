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
    public static unsafe int AddTrailPointsWithPrediction(this ComPtr<IDCompositionDelegatedInkTrail> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
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

}
