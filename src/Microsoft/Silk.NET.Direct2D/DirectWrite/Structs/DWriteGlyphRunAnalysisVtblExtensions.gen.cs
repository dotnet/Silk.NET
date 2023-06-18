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

public unsafe static class DWriteGlyphRunAnalysisVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaTextureBounds(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, Silk.NET.Maths.Box2D<int>* textureBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, textureType, textureBounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAlphaTexture(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, TextureType textureType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* textureBounds, byte* alphaValues, uint bufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, Silk.NET.Maths.Box2D<int>*, byte*, uint, int>)@this->LpVtbl[4])(@this, textureType, textureBounds, alphaValues, bufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAlphaBlendParams(this ComPtr<IDWriteGlyphRunAnalysis> thisVtbl, IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)@this->LpVtbl[5])(@this, renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
        return ret;
    }

}
